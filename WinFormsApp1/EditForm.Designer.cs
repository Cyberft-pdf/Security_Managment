namespace WinFormsApp1
{
    partial class EditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditForm));
            textBox_Name = new TextBox();
            textBox_Method = new TextBox();
            textBox_Person = new TextBox();
            textBox_Log = new TextBox();
            dateTimePicker_LastAttack = new DateTimePicker();
            button_Save = new Button();
            button_Cancel = new Button();
            mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            checkBox_ZeroDayExploit = new CheckBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            numericUpDown_HowMany = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_HowMany).BeginInit();
            SuspendLayout();
            // 
            // textBox_Name
            // 
            textBox_Name.Location = new Point(312, 42);
            textBox_Name.Name = "textBox_Name";
            textBox_Name.Size = new Size(100, 23);
            textBox_Name.TabIndex = 0;
            // 
            // textBox_Method
            // 
            textBox_Method.Location = new Point(312, 95);
            textBox_Method.Name = "textBox_Method";
            textBox_Method.Size = new Size(100, 23);
            textBox_Method.TabIndex = 1;
            // 
            // textBox_Person
            // 
            textBox_Person.Location = new Point(312, 201);
            textBox_Person.Name = "textBox_Person";
            textBox_Person.Size = new Size(100, 23);
            textBox_Person.TabIndex = 2;
            // 
            // textBox_Log
            // 
            textBox_Log.Location = new Point(312, 252);
            textBox_Log.Name = "textBox_Log";
            textBox_Log.Size = new Size(100, 23);
            textBox_Log.TabIndex = 3;
            // 
            // dateTimePicker_LastAttack
            // 
            dateTimePicker_LastAttack.Location = new Point(312, 153);
            dateTimePicker_LastAttack.Name = "dateTimePicker_LastAttack";
            dateTimePicker_LastAttack.Size = new Size(100, 23);
            dateTimePicker_LastAttack.TabIndex = 4;
            // 
            // button_Save
            // 
            button_Save.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            button_Save.Location = new Point(96, 489);
            button_Save.Name = "button_Save";
            button_Save.Size = new Size(96, 42);
            button_Save.TabIndex = 5;
            button_Save.Text = "save";
            button_Save.UseVisualStyleBackColor = true;
            button_Save.Click += button_Save_Click;
            // 
            // button_Cancel
            // 
            button_Cancel.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            button_Cancel.Location = new Point(316, 489);
            button_Cancel.Name = "button_Cancel";
            button_Cancel.Size = new Size(96, 42);
            button_Cancel.TabIndex = 6;
            button_Cancel.Text = "cancel";
            button_Cancel.UseVisualStyleBackColor = true;
            button_Cancel.Click += button_Cancel_Click;
            // 
            // mySqlCommand1
            // 
            mySqlCommand1.CacheAge = 0;
            mySqlCommand1.Connection = null;
            mySqlCommand1.EnableCaching = false;
            mySqlCommand1.Transaction = null;
            // 
            // checkBox_ZeroDayExploit
            // 
            checkBox_ZeroDayExploit.AutoSize = true;
            checkBox_ZeroDayExploit.Location = new Point(347, 390);
            checkBox_ZeroDayExploit.Name = "checkBox_ZeroDayExploit";
            checkBox_ZeroDayExploit.Size = new Size(15, 14);
            checkBox_ZeroDayExploit.TabIndex = 7;
            checkBox_ZeroDayExploit.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Image = (Image)resources.GetObject("label1.Image");
            label1.Location = new Point(96, 41);
            label1.Name = "label1";
            label1.Size = new Size(127, 20);
            label1.TabIndex = 8;
            label1.Text = "Name of incident:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Image = (Image)resources.GetObject("label2.Image");
            label2.Location = new Point(96, 95);
            label2.Name = "label2";
            label2.Size = new Size(126, 20);
            label2.TabIndex = 9;
            label2.Text = "Method of attack:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Image = (Image)resources.GetObject("label3.Image");
            label3.Location = new Point(96, 153);
            label3.Name = "label3";
            label3.Size = new Size(116, 20);
            label3.TabIndex = 10;
            label3.Text = "Last attack date:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Image = (Image)resources.GetObject("label4.Image");
            label4.Location = new Point(96, 201);
            label4.Name = "label4";
            label4.Size = new Size(141, 20);
            label4.TabIndex = 11;
            label4.Text = "Responsible person:";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F);
            label5.ForeColor = SystemColors.ButtonFace;
            label5.Image = (Image)resources.GetObject("label5.Image");
            label5.Location = new Point(96, 251);
            label5.Name = "label5";
            label5.Size = new Size(91, 20);
            label5.TabIndex = 12;
            label5.Text = "Incident log:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F);
            label6.ForeColor = SystemColors.ButtonFace;
            label6.Image = (Image)resources.GetObject("label6.Image");
            label6.Location = new Point(96, 390);
            label6.Name = "label6";
            label6.Size = new Size(171, 20);
            label6.TabIndex = 13;
            label6.Text = "Was it Zero Day Exploit?";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F);
            label7.ForeColor = SystemColors.ButtonFace;
            label7.Image = (Image)resources.GetObject("label7.Image");
            label7.Location = new Point(96, 303);
            label7.Name = "label7";
            label7.Size = new Size(87, 20);
            label7.TabIndex = 14;
            label7.Text = "How many: ";
            // 
            // numericUpDown_HowMany
            // 
            numericUpDown_HowMany.Location = new Point(312, 303);
            numericUpDown_HowMany.Name = "numericUpDown_HowMany";
            numericUpDown_HowMany.Size = new Size(100, 23);
            numericUpDown_HowMany.TabIndex = 15;
            // 
            // EditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(522, 631);
            Controls.Add(numericUpDown_HowMany);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(checkBox_ZeroDayExploit);
            Controls.Add(button_Cancel);
            Controls.Add(button_Save);
            Controls.Add(dateTimePicker_LastAttack);
            Controls.Add(textBox_Log);
            Controls.Add(textBox_Person);
            Controls.Add(textBox_Method);
            Controls.Add(textBox_Name);
            Name = "EditForm";
            Text = "EditForm";
            ((System.ComponentModel.ISupportInitialize)numericUpDown_HowMany).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_Name;
        private TextBox textBox_Method;
        private TextBox textBox_Person;
        private TextBox textBox_Log;
        private DateTimePicker dateTimePicker_LastAttack;
        private Button button_Save;
        private Button button_Cancel;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private CheckBox checkBox_ZeroDayExploit;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private NumericUpDown numericUpDown_HowMany;
    }
}