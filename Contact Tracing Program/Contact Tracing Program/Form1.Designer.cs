
namespace Contact_Tracing_Program
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.SexBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.OpenDirectory = new System.Windows.Forms.Button();
            this.ContactGroup = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ContactBox2 = new System.Windows.Forms.TextBox();
            this.EMAIL = new System.Windows.Forms.Label();
            this.PHONE = new System.Windows.Forms.Label();
            this.ContactBox1 = new System.Windows.Forms.TextBox();
            this.NewButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.DateGroup = new System.Windows.Forms.GroupBox();
            this.DateBox3 = new System.Windows.Forms.TextBox();
            this.DateBox2 = new System.Windows.Forms.TextBox();
            this.DateBox1 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.AddressGroup = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.HouseBox5 = new System.Windows.Forms.TextBox();
            this.HouseBox4 = new System.Windows.Forms.TextBox();
            this.HouseBox3 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.HouseBox2 = new System.Windows.Forms.TextBox();
            this.HouseBox1 = new System.Windows.Forms.TextBox();
            this.ASTGroup = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TempBox = new System.Windows.Forms.TextBox();
            this.AgeBox = new System.Windows.Forms.TextBox();
            this.NameGroup = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NameBox3 = new System.Windows.Forms.TextBox();
            this.NameBox2 = new System.Windows.Forms.TextBox();
            this.NameBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.ContactGroup.SuspendLayout();
            this.DateGroup.SuspendLayout();
            this.AddressGroup.SuspendLayout();
            this.ASTGroup.SuspendLayout();
            this.NameGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // SexBox
            // 
            this.SexBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SexBox.FormattingEnabled = true;
            this.SexBox.Items.AddRange(new object[] {
            resources.GetString("SexBox.Items"),
            resources.GetString("SexBox.Items1")});
            resources.ApplyResources(this.SexBox, "SexBox");
            this.SexBox.Name = "SexBox";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.OpenDirectory);
            this.groupBox1.Controls.Add(this.ContactGroup);
            this.groupBox1.Controls.Add(this.NewButton);
            this.groupBox1.Controls.Add(this.SaveButton);
            this.groupBox1.Controls.Add(this.DateGroup);
            this.groupBox1.Controls.Add(this.AddressGroup);
            this.groupBox1.Controls.Add(this.ASTGroup);
            this.groupBox1.Controls.Add(this.NameGroup);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // OpenDirectory
            // 
            resources.ApplyResources(this.OpenDirectory, "OpenDirectory");
            this.OpenDirectory.Name = "OpenDirectory";
            this.OpenDirectory.UseVisualStyleBackColor = true;
            this.OpenDirectory.Click += new System.EventHandler(this.OpenDirectory_Click);
            // 
            // ContactGroup
            // 
            this.ContactGroup.Controls.Add(this.label8);
            this.ContactGroup.Controls.Add(this.ContactBox2);
            this.ContactGroup.Controls.Add(this.EMAIL);
            this.ContactGroup.Controls.Add(this.PHONE);
            this.ContactGroup.Controls.Add(this.ContactBox1);
            resources.ApplyResources(this.ContactGroup, "ContactGroup");
            this.ContactGroup.Name = "ContactGroup";
            this.ContactGroup.TabStop = false;
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Name = "label8";
            // 
            // ContactBox2
            // 
            resources.ApplyResources(this.ContactBox2, "ContactBox2");
            this.ContactBox2.Name = "ContactBox2";
            // 
            // EMAIL
            // 
            resources.ApplyResources(this.EMAIL, "EMAIL");
            this.EMAIL.Name = "EMAIL";
            // 
            // PHONE
            // 
            resources.ApplyResources(this.PHONE, "PHONE");
            this.PHONE.Name = "PHONE";
            // 
            // ContactBox1
            // 
            resources.ApplyResources(this.ContactBox1, "ContactBox1");
            this.ContactBox1.Name = "ContactBox1";
            // 
            // NewButton
            // 
            resources.ApplyResources(this.NewButton, "NewButton");
            this.NewButton.Name = "NewButton";
            this.NewButton.UseVisualStyleBackColor = true;
            this.NewButton.Click += new System.EventHandler(this.NewButton_Click);
            // 
            // SaveButton
            // 
            resources.ApplyResources(this.SaveButton, "SaveButton");
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // DateGroup
            // 
            this.DateGroup.Controls.Add(this.DateBox3);
            this.DateGroup.Controls.Add(this.DateBox2);
            this.DateGroup.Controls.Add(this.DateBox1);
            this.DateGroup.Controls.Add(this.label10);
            this.DateGroup.Controls.Add(this.label12);
            this.DateGroup.Controls.Add(this.label16);
            resources.ApplyResources(this.DateGroup, "DateGroup");
            this.DateGroup.Name = "DateGroup";
            this.DateGroup.TabStop = false;
            // 
            // DateBox3
            // 
            resources.ApplyResources(this.DateBox3, "DateBox3");
            this.DateBox3.Name = "DateBox3";
            // 
            // DateBox2
            // 
            resources.ApplyResources(this.DateBox2, "DateBox2");
            this.DateBox2.Name = "DateBox2";
            // 
            // DateBox1
            // 
            this.DateBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DateBox1.FormattingEnabled = true;
            this.DateBox1.Items.AddRange(new object[] {
            resources.GetString("DateBox1.Items"),
            resources.GetString("DateBox1.Items1"),
            resources.GetString("DateBox1.Items2"),
            resources.GetString("DateBox1.Items3"),
            resources.GetString("DateBox1.Items4"),
            resources.GetString("DateBox1.Items5"),
            resources.GetString("DateBox1.Items6"),
            resources.GetString("DateBox1.Items7"),
            resources.GetString("DateBox1.Items8"),
            resources.GetString("DateBox1.Items9"),
            resources.GetString("DateBox1.Items10"),
            resources.GetString("DateBox1.Items11")});
            resources.ApplyResources(this.DateBox1, "DateBox1");
            this.DateBox1.Name = "DateBox1";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.Name = "label12";
            // 
            // label16
            // 
            resources.ApplyResources(this.label16, "label16");
            this.label16.Name = "label16";
            // 
            // AddressGroup
            // 
            this.AddressGroup.Controls.Add(this.label13);
            this.AddressGroup.Controls.Add(this.label14);
            this.AddressGroup.Controls.Add(this.label15);
            this.AddressGroup.Controls.Add(this.HouseBox5);
            this.AddressGroup.Controls.Add(this.HouseBox4);
            this.AddressGroup.Controls.Add(this.HouseBox3);
            this.AddressGroup.Controls.Add(this.label9);
            this.AddressGroup.Controls.Add(this.label11);
            this.AddressGroup.Controls.Add(this.HouseBox2);
            this.AddressGroup.Controls.Add(this.HouseBox1);
            resources.ApplyResources(this.AddressGroup, "AddressGroup");
            this.AddressGroup.Name = "AddressGroup";
            this.AddressGroup.TabStop = false;
            // 
            // label13
            // 
            resources.ApplyResources(this.label13, "label13");
            this.label13.Name = "label13";
            // 
            // label14
            // 
            resources.ApplyResources(this.label14, "label14");
            this.label14.Name = "label14";
            // 
            // label15
            // 
            resources.ApplyResources(this.label15, "label15");
            this.label15.Name = "label15";
            // 
            // HouseBox5
            // 
            resources.ApplyResources(this.HouseBox5, "HouseBox5");
            this.HouseBox5.Name = "HouseBox5";
            // 
            // HouseBox4
            // 
            resources.ApplyResources(this.HouseBox4, "HouseBox4");
            this.HouseBox4.Name = "HouseBox4";
            // 
            // HouseBox3
            // 
            resources.ApplyResources(this.HouseBox3, "HouseBox3");
            this.HouseBox3.Name = "HouseBox3";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            // 
            // HouseBox2
            // 
            resources.ApplyResources(this.HouseBox2, "HouseBox2");
            this.HouseBox2.Name = "HouseBox2";
            // 
            // HouseBox1
            // 
            resources.ApplyResources(this.HouseBox1, "HouseBox1");
            this.HouseBox1.Name = "HouseBox1";
            // 
            // ASTGroup
            // 
            this.ASTGroup.Controls.Add(this.SexBox);
            this.ASTGroup.Controls.Add(this.label4);
            this.ASTGroup.Controls.Add(this.label5);
            this.ASTGroup.Controls.Add(this.label6);
            this.ASTGroup.Controls.Add(this.TempBox);
            this.ASTGroup.Controls.Add(this.AgeBox);
            resources.ApplyResources(this.ASTGroup, "ASTGroup");
            this.ASTGroup.Name = "ASTGroup";
            this.ASTGroup.TabStop = false;
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // TempBox
            // 
            resources.ApplyResources(this.TempBox, "TempBox");
            this.TempBox.Name = "TempBox";
            // 
            // AgeBox
            // 
            resources.ApplyResources(this.AgeBox, "AgeBox");
            this.AgeBox.Name = "AgeBox";
            // 
            // NameGroup
            // 
            this.NameGroup.Controls.Add(this.label7);
            this.NameGroup.Controls.Add(this.label3);
            this.NameGroup.Controls.Add(this.label2);
            this.NameGroup.Controls.Add(this.label1);
            this.NameGroup.Controls.Add(this.NameBox3);
            this.NameGroup.Controls.Add(this.NameBox2);
            this.NameGroup.Controls.Add(this.NameBox1);
            resources.ApplyResources(this.NameGroup, "NameGroup");
            this.NameGroup.Name = "NameGroup";
            this.NameGroup.TabStop = false;
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Name = "label7";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // NameBox3
            // 
            resources.ApplyResources(this.NameBox3, "NameBox3");
            this.NameBox3.Name = "NameBox3";
            // 
            // NameBox2
            // 
            resources.ApplyResources(this.NameBox2, "NameBox2");
            this.NameBox2.Name = "NameBox2";
            // 
            // NameBox1
            // 
            resources.ApplyResources(this.NameBox1, "NameBox1");
            this.NameBox1.Name = "NameBox1";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.ContactGroup.ResumeLayout(false);
            this.ContactGroup.PerformLayout();
            this.DateGroup.ResumeLayout(false);
            this.DateGroup.PerformLayout();
            this.AddressGroup.ResumeLayout(false);
            this.AddressGroup.PerformLayout();
            this.ASTGroup.ResumeLayout(false);
            this.ASTGroup.PerformLayout();
            this.NameGroup.ResumeLayout(false);
            this.NameGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox NameGroup;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NameBox3;
        private System.Windows.Forms.TextBox NameBox2;
        private System.Windows.Forms.TextBox NameBox1;
        private System.Windows.Forms.GroupBox ASTGroup;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TempBox;
        private System.Windows.Forms.TextBox AgeBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox SexBox;
        private System.Windows.Forms.GroupBox AddressGroup;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox HouseBox5;
        private System.Windows.Forms.TextBox HouseBox4;
        private System.Windows.Forms.TextBox HouseBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox HouseBox2;
        private System.Windows.Forms.TextBox HouseBox1;
        private System.Windows.Forms.GroupBox DateGroup;
        private System.Windows.Forms.ComboBox DateBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox DateBox3;
        private System.Windows.Forms.TextBox DateBox2;
        private System.Windows.Forms.Button NewButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.GroupBox ContactGroup;
        private System.Windows.Forms.TextBox ContactBox2;
        private System.Windows.Forms.Label EMAIL;
        private System.Windows.Forms.Label PHONE;
        private System.Windows.Forms.TextBox ContactBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button OpenDirectory;
    }
}

