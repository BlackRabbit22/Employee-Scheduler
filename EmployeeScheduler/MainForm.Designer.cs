namespace EmployeeScheduler
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employees_ListBox = new System.Windows.Forms.ListBox();
            this.newEmployee_Button = new System.Windows.Forms.Button();
            this.edit_Button = new System.Windows.Forms.Button();
            this.delete_Button = new System.Windows.Forms.Button();
            this.employees_Label = new System.Windows.Forms.Label();
            this.employeeSchedule_Label = new System.Windows.Forms.Label();
            this.newList_Button = new System.Windows.Forms.Button();
            this.openList_Button = new System.Windows.Forms.Button();
            this.employeeSchedule_TextBox = new System.Windows.Forms.TextBox();
            this.month_Label = new System.Windows.Forms.Label();
            this.fullName_Label = new System.Windows.Forms.Label();
            this.phoneNumber_Label = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(969, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.toolStripSeparator2,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.toolStripMenuItem1.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(143, 6);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(143, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // employees_ListBox
            // 
            this.employees_ListBox.FormattingEnabled = true;
            this.employees_ListBox.ItemHeight = 15;
            this.employees_ListBox.Location = new System.Drawing.Point(12, 92);
            this.employees_ListBox.Name = "employees_ListBox";
            this.employees_ListBox.Size = new System.Drawing.Size(445, 244);
            this.employees_ListBox.TabIndex = 1;
            this.employees_ListBox.Visible = false;
            this.employees_ListBox.SelectedIndexChanged += new System.EventHandler(this.employees_ListBox_SelectedIndexChanged);
            // 
            // newEmployee_Button
            // 
            this.newEmployee_Button.Location = new System.Drawing.Point(118, 355);
            this.newEmployee_Button.Name = "newEmployee_Button";
            this.newEmployee_Button.Size = new System.Drawing.Size(161, 37);
            this.newEmployee_Button.TabIndex = 2;
            this.newEmployee_Button.Text = "New Employee";
            this.newEmployee_Button.UseVisualStyleBackColor = true;
            this.newEmployee_Button.Visible = false;
            this.newEmployee_Button.Click += new System.EventHandler(this.newEmployee_Button_Click);
            // 
            // edit_Button
            // 
            this.edit_Button.Location = new System.Drawing.Point(474, 355);
            this.edit_Button.Name = "edit_Button";
            this.edit_Button.Size = new System.Drawing.Size(161, 37);
            this.edit_Button.TabIndex = 3;
            this.edit_Button.Text = "Edit";
            this.edit_Button.UseVisualStyleBackColor = true;
            this.edit_Button.Visible = false;
            this.edit_Button.Click += new System.EventHandler(this.edit_Button_Click);
            // 
            // delete_Button
            // 
            this.delete_Button.Location = new System.Drawing.Point(741, 355);
            this.delete_Button.Name = "delete_Button";
            this.delete_Button.Size = new System.Drawing.Size(161, 37);
            this.delete_Button.TabIndex = 4;
            this.delete_Button.Text = "Delete";
            this.delete_Button.UseVisualStyleBackColor = true;
            this.delete_Button.Visible = false;
            this.delete_Button.Click += new System.EventHandler(this.delete_Button_Click);
            // 
            // employees_Label
            // 
            this.employees_Label.AutoSize = true;
            this.employees_Label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.employees_Label.Location = new System.Drawing.Point(154, 35);
            this.employees_Label.Name = "employees_Label";
            this.employees_Label.Size = new System.Drawing.Size(85, 21);
            this.employees_Label.TabIndex = 6;
            this.employees_Label.Text = "Employees";
            this.employees_Label.Visible = false;
            // 
            // employeeSchedule_Label
            // 
            this.employeeSchedule_Label.AutoSize = true;
            this.employeeSchedule_Label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.employeeSchedule_Label.Location = new System.Drawing.Point(631, 35);
            this.employeeSchedule_Label.Name = "employeeSchedule_Label";
            this.employeeSchedule_Label.Size = new System.Drawing.Size(145, 21);
            this.employeeSchedule_Label.TabIndex = 8;
            this.employeeSchedule_Label.Text = "Employee Schedule";
            this.employeeSchedule_Label.Visible = false;
            // 
            // newList_Button
            // 
            this.newList_Button.Location = new System.Drawing.Point(266, 182);
            this.newList_Button.Name = "newList_Button";
            this.newList_Button.Size = new System.Drawing.Size(182, 52);
            this.newList_Button.TabIndex = 9;
            this.newList_Button.Text = "New Schedule";
            this.newList_Button.UseVisualStyleBackColor = true;
            this.newList_Button.Click += new System.EventHandler(this.newList_Click);
            // 
            // openList_Button
            // 
            this.openList_Button.Location = new System.Drawing.Point(474, 182);
            this.openList_Button.Name = "openList_Button";
            this.openList_Button.Size = new System.Drawing.Size(182, 52);
            this.openList_Button.TabIndex = 10;
            this.openList_Button.Text = "Open File";
            this.openList_Button.UseVisualStyleBackColor = true;
            this.openList_Button.Click += new System.EventHandler(this.openList_Button_Click);
            // 
            // employeeSchedule_TextBox
            // 
            this.employeeSchedule_TextBox.Location = new System.Drawing.Point(463, 92);
            this.employeeSchedule_TextBox.Multiline = true;
            this.employeeSchedule_TextBox.Name = "employeeSchedule_TextBox";
            this.employeeSchedule_TextBox.ReadOnly = true;
            this.employeeSchedule_TextBox.Size = new System.Drawing.Size(494, 244);
            this.employeeSchedule_TextBox.TabIndex = 11;
            this.employeeSchedule_TextBox.Visible = false;
            // 
            // month_Label
            // 
            this.month_Label.AutoSize = true;
            this.month_Label.Location = new System.Drawing.Point(12, 74);
            this.month_Label.Name = "month_Label";
            this.month_Label.Size = new System.Drawing.Size(43, 15);
            this.month_Label.TabIndex = 12;
            this.month_Label.Text = "Month";
            this.month_Label.Visible = false;
            // 
            // fullName_Label
            // 
            this.fullName_Label.AutoSize = true;
            this.fullName_Label.Location = new System.Drawing.Point(97, 74);
            this.fullName_Label.Name = "fullName_Label";
            this.fullName_Label.Size = new System.Drawing.Size(61, 15);
            this.fullName_Label.TabIndex = 13;
            this.fullName_Label.Text = "Full Name";
            this.fullName_Label.Visible = false;
            // 
            // phoneNumber_Label
            // 
            this.phoneNumber_Label.AutoSize = true;
            this.phoneNumber_Label.Location = new System.Drawing.Point(285, 74);
            this.phoneNumber_Label.Name = "phoneNumber_Label";
            this.phoneNumber_Label.Size = new System.Drawing.Size(88, 15);
            this.phoneNumber_Label.TabIndex = 15;
            this.phoneNumber_Label.Text = "Phone Number";
            this.phoneNumber_Label.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 411);
            this.Controls.Add(this.phoneNumber_Label);
            this.Controls.Add(this.fullName_Label);
            this.Controls.Add(this.month_Label);
            this.Controls.Add(this.employeeSchedule_TextBox);
            this.Controls.Add(this.openList_Button);
            this.Controls.Add(this.newList_Button);
            this.Controls.Add(this.employeeSchedule_Label);
            this.Controls.Add(this.employees_Label);
            this.Controls.Add(this.delete_Button);
            this.Controls.Add(this.edit_Button);
            this.Controls.Add(this.newEmployee_Button);
            this.Controls.Add(this.employees_ListBox);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Employee Scheduler";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ListBox employees_ListBox;
        private Button newEmployee_Button;
        private Button edit_Button;
        private Button delete_Button;
        private Label employees_Label;
        private Label employeeSchedule_Label;
        private Button newList_Button;
        private Button openList_Button;
        private TextBox employeeSchedule_TextBox;
        private Label month_Label;
        private Label fullName_Label;
        private Label phoneNumber_Label;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripSeparator toolStripSeparator1;
    }
}