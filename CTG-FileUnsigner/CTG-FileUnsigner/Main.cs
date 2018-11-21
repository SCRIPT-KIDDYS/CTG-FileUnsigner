using MetroFramework.Forms;
using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace CTG_FileUnsigner
{

    public partial class Main : MetroForm
    {
        [DllImport("Imagehlp.dll")]
        private static extern bool ImageRemoveCertificate(IntPtr handle, int index);

        string[] handles;
        new bool Refresh = true;

        public Main()
        {
            InitializeComponent();
        }

        private void MainDragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }

        private void MainDragDrop(object sender, DragEventArgs e)
        {
            MainListView.Items.Clear();

            if (Refresh)
                handles = (string[])e.Data.GetData(DataFormats.FileDrop, false);

            foreach (string s in handles)
                if (File.Exists(s))
                {
                    if (string.Compare(Path.GetExtension(s), ".exe", true) == 0)
                        AddFileToListview(s);
                }
                else if (Directory.Exists(s) && SubDirectoriesCheckBox.Checked == true)
                {
                    DirectoryInfo di = new DirectoryInfo(s);
                    FileInfo[] files = di.GetFiles("*.exe", SearchOption.AllDirectories);
                    Console.WriteLine("Checked");
                    foreach (FileInfo file in files)
                        AddFileToListview(file.FullName);
                }
                else if (Directory.Exists(s))
                {
                    DirectoryInfo di = new DirectoryInfo(s);
                    FileInfo[] files = di.GetFiles("*.exe");
                    Console.WriteLine("UnChecked");
                    foreach (FileInfo file in files)
                        AddFileToListview(file.FullName);
                }
            Refresh = true;
        }

        private void AddFileToListview(string fullFilePath)
        {
            bool signed = false;

            if (!File.Exists(fullFilePath))
                return;

            string fileName = Path.GetFileName(fullFilePath);
            string dirName = Path.GetDirectoryName(fullFilePath);

            if (!dirName.EndsWith(Convert.ToString(Path.DirectorySeparatorChar)))
                dirName = dirName + @"\";

            try
            {
                X509Certificate certificate = new X509Certificate(dirName + fileName);
                signed = true;
            } catch { }

            if (signed)
            {
                ListViewItem itm = MainListView.Items.Add(fileName);
                itm.SubItems.Add(dirName);
                itm.Group = MainListView.Groups[0];
            }
            else
            {
                ListViewItem itm = MainListView.Items.Add(fileName);
                itm.SubItems.Add(dirName);
                itm.Group = MainListView.Groups[1];
            }
        }

        private void UnSignButton_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in MainListView.CheckedItems)
                if (item.Group.Header == "Un-Signed")
                    OutputBox.AppendText(Environment.NewLine + "File is not Signed so can not UnSign.");
                else
                    try
                    {
                        Console.WriteLine(item.Index + "  -  -  ");
                        UnsignFile(item.SubItems[1].Text + item.SubItems[0].Text);
                        OutputBox.AppendText(Environment.NewLine + item.SubItems[0].Text + " - Unsigned");
                    }
                    catch (Exception ex)
                    { OutputBox.AppendText(Environment.NewLine + "Failed trying to unsign  -  " + ex.Message); }

            Refresh = false;
            MainDragDrop(this,null);
        }

        private static void UnsignFile(string file)
        {
            X509Certificate certificate = new X509Certificate(file);
            File.Copy(file, file + ".SigBak", false);
            using (FileStream fs = new FileStream(file, System.IO.FileMode.Open, System.IO.FileAccess.ReadWrite))
                ImageRemoveCertificate(fs.SafeFileHandle.DangerousGetHandle(), 0);
        }

        private void WeirdStyleIssue(object sender, EventArgs e)
        {
            OutputBox.Focus();
        }

        private void SubDirectoriesCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (SubDirectoriesCheckBox.Checked)
                MetroFramework.MetroMessageBox.Show(this, "THIS WILL SEARCH SUB DIRECTORIES! DON'T BE SILLY AND LOAD THE ENTIRE C: DRIVE.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning, 180);
        }
    }
}
