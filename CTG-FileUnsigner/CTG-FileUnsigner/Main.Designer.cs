namespace CTG_FileUnsigner
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Signed", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("Un-Signed", System.Windows.Forms.HorizontalAlignment.Left);
            this.MainListView = new MetroFramework.Controls.MetroListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OutputBox = new MetroFramework.Controls.MetroTextBox();
            this.SubDirectoriesCheckBox = new MetroFramework.Controls.MetroCheckBox();
            this.UnSignButton = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // MainListView
            // 
            this.MainListView.BackColor = System.Drawing.Color.White;
            this.MainListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MainListView.CheckBoxes = true;
            this.MainListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2});
            this.MainListView.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.MainListView.ForeColor = System.Drawing.SystemColors.Window;
            this.MainListView.FullRowSelect = true;
            listViewGroup1.Header = "Signed";
            listViewGroup1.Name = "listViewGroup1";
            listViewGroup2.Header = "Un-Signed";
            listViewGroup2.Name = "listViewGroup2";
            this.MainListView.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2});
            this.MainListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.MainListView.Location = new System.Drawing.Point(20, 63);
            this.MainListView.Margin = new System.Windows.Forms.Padding(0, 3, 0, 10);
            this.MainListView.MultiSelect = false;
            this.MainListView.Name = "MainListView";
            this.MainListView.OwnerDraw = true;
            this.MainListView.Size = new System.Drawing.Size(371, 173);
            this.MainListView.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.MainListView.Style = MetroFramework.MetroColorStyle.Green;
            this.MainListView.TabIndex = 3;
            this.MainListView.TabStop = false;
            this.MainListView.Theme = MetroFramework.MetroThemeStyle.Light;
            this.MainListView.TileSize = new System.Drawing.Size(1, 1);
            this.MainListView.UseCompatibleStateImageBehavior = false;
            this.MainListView.UseCustomBackColor = true;
            this.MainListView.UseSelectable = true;
            this.MainListView.UseStyleColors = true;
            this.MainListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Width = 350;
            // 
            // OutputBox
            // 
            // 
            // 
            // 
            this.OutputBox.CustomButton.Image = null;
            this.OutputBox.CustomButton.Location = new System.Drawing.Point(173, 2);
            this.OutputBox.CustomButton.Name = "";
            this.OutputBox.CustomButton.Size = new System.Drawing.Size(195, 195);
            this.OutputBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.OutputBox.CustomButton.TabIndex = 1;
            this.OutputBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.OutputBox.CustomButton.UseSelectable = true;
            this.OutputBox.CustomButton.Visible = false;
            this.OutputBox.Lines = new string[0];
            this.OutputBox.Location = new System.Drawing.Point(20, 281);
            this.OutputBox.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.OutputBox.MaxLength = 32767;
            this.OutputBox.Multiline = true;
            this.OutputBox.Name = "OutputBox";
            this.OutputBox.PasswordChar = '\0';
            this.OutputBox.ReadOnly = true;
            this.OutputBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.OutputBox.SelectedText = "";
            this.OutputBox.SelectionLength = 0;
            this.OutputBox.SelectionStart = 0;
            this.OutputBox.ShortcutsEnabled = true;
            this.OutputBox.Size = new System.Drawing.Size(371, 200);
            this.OutputBox.Style = MetroFramework.MetroColorStyle.Green;
            this.OutputBox.TabIndex = 4;
            this.OutputBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.OutputBox.Theme = MetroFramework.MetroThemeStyle.Light;
            this.OutputBox.UseSelectable = true;
            this.OutputBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.OutputBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // SubDirectoriesCheckBox
            // 
            this.SubDirectoriesCheckBox.AutoSize = true;
            this.SubDirectoriesCheckBox.Location = new System.Drawing.Point(20, 251);
            this.SubDirectoriesCheckBox.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.SubDirectoriesCheckBox.Name = "SubDirectoriesCheckBox";
            this.SubDirectoriesCheckBox.Padding = new System.Windows.Forms.Padding(10);
            this.SubDirectoriesCheckBox.Size = new System.Drawing.Size(168, 15);
            this.SubDirectoriesCheckBox.Style = MetroFramework.MetroColorStyle.Green;
            this.SubDirectoriesCheckBox.TabIndex = 5;
            this.SubDirectoriesCheckBox.TabStop = false;
            this.SubDirectoriesCheckBox.Text = "Search SubDirectories Also?";
            this.SubDirectoriesCheckBox.Theme = MetroFramework.MetroThemeStyle.Light;
            this.SubDirectoriesCheckBox.UseSelectable = true;
            this.SubDirectoriesCheckBox.UseVisualStyleBackColor = true;
            this.SubDirectoriesCheckBox.CheckedChanged += new System.EventHandler(this.SubDirectoriesCheckBox_CheckedChanged);
            this.SubDirectoriesCheckBox.Click += new System.EventHandler(this.WeirdStyleIssue);
            // 
            // UnSignButton
            // 
            this.UnSignButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.UnSignButton.Location = new System.Drawing.Point(20, 491);
            this.UnSignButton.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.UnSignButton.Name = "UnSignButton";
            this.UnSignButton.Size = new System.Drawing.Size(371, 40);
            this.UnSignButton.Style = MetroFramework.MetroColorStyle.Green;
            this.UnSignButton.TabIndex = 6;
            this.UnSignButton.Text = "Un-Sign File(s)";
            this.UnSignButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.UnSignButton.UseSelectable = true;
            this.UnSignButton.UseVisualStyleBackColor = true;
            this.UnSignButton.Click += new System.EventHandler(this.UnSignButton_Click);
            // 
            // Main
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 547);
            this.Controls.Add(this.UnSignButton);
            this.Controls.Add(this.OutputBox);
            this.Controls.Add(this.SubDirectoriesCheckBox);
            this.Controls.Add(this.MainListView);
            this.Name = "Main";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "CTG - File UnSigner";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainDragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainDragEnter);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroListView MainListView;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private MetroFramework.Controls.MetroTextBox OutputBox;
        private MetroFramework.Controls.MetroCheckBox SubDirectoriesCheckBox;
        private MetroFramework.Controls.MetroButton UnSignButton;
    }
}

