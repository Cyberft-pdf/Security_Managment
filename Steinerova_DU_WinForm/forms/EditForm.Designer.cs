namespace Steinerova_DU_WinForm.forms
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
            button_Save = new Button();
            button_Cancel = new Button();
            label1 = new Label();
            label2 = new Label();
            dateTimePicker_LastAttack = new DateTimePicker();
            label3 = new Label();
            label4 = new Label();
            checkBox_ZeroDayExploit = new CheckBox();
            textBox_Name = new TextBox();
            textBox_Method = new TextBox();
            textBox_Person = new TextBox();
            textBox_Log = new TextBox();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // button_Save
            // 
            button_Save.Location = new Point(80, 453);
            button_Save.Name = "button_Save";
            button_Save.Size = new Size(87, 39);
            button_Save.TabIndex = 0;
            button_Save.Text = "Save";
            button_Save.UseVisualStyleBackColor = true;
            button_Save.Click += button_Save_Click;
            // 
            // button_Cancel
            // 
            button_Cancel.Location = new Point(255, 450);
            button_Cancel.Name = "button_Cancel";
            button_Cancel.Size = new Size(92, 42);
            button_Cancel.TabIndex = 1;
            button_Cancel.Text = "Cancel";
            button_Cancel.UseVisualStyleBackColor = true;
            button_Cancel.Click += button_Cancel_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift", 11.25F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Image = (Image)resources.GetObject("label1.Image");
            label1.Location = new Point(46, 81);
            label1.Name = "label1";
            label1.Size = new Size(121, 18);
            label1.TabIndex = 2;
            label1.Text = "Name of incident";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift", 11.25F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Image = (Image)resources.GetObject("label2.Image");
            label2.Location = new Point(46, 133);
            label2.Name = "label2";
            label2.Size = new Size(144, 18);
            label2.TabIndex = 3;
            label2.Text = "Attack method used:";
            // 
            // dateTimePicker_LastAttack
            // 
            dateTimePicker_LastAttack.Location = new Point(218, 174);
            dateTimePicker_LastAttack.Name = "dateTimePicker_LastAttack";
            dateTimePicker_LastAttack.Size = new Size(165, 23);
            dateTimePicker_LastAttack.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift", 11.25F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Image = (Image)resources.GetObject("label3.Image");
            label3.Location = new Point(46, 225);
            label3.Name = "label3";
            label3.Size = new Size(136, 18);
            label3.TabIndex = 5;
            label3.Text = "responsible person";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bahnschrift", 11.25F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Image = (Image)resources.GetObject("label4.Image");
            label4.Location = new Point(46, 277);
            label4.Name = "label4";
            label4.Size = new Size(89, 18);
            label4.TabIndex = 6;
            label4.Text = "Incident Log";
            // 
            // checkBox_ZeroDayExploit
            // 
            checkBox_ZeroDayExploit.AutoSize = true;
            checkBox_ZeroDayExploit.Location = new Point(264, 358);
            checkBox_ZeroDayExploit.Name = "checkBox_ZeroDayExploit";
            checkBox_ZeroDayExploit.Size = new Size(15, 14);
            checkBox_ZeroDayExploit.TabIndex = 7;
            checkBox_ZeroDayExploit.UseVisualStyleBackColor = true;
            // 
            // textBox_Name
            // 
            textBox_Name.Location = new Point(218, 81);
            textBox_Name.Name = "textBox_Name";
            textBox_Name.Size = new Size(100, 23);
            textBox_Name.TabIndex = 8;
            // 
            // textBox_Method
            // 
            textBox_Method.Location = new Point(218, 133);
            textBox_Method.Name = "textBox_Method";
            textBox_Method.Size = new Size(100, 23);
            textBox_Method.TabIndex = 9;
            // 
            // textBox_Person
            // 
            textBox_Person.Location = new Point(218, 225);
            textBox_Person.Name = "textBox_Person";
            textBox_Person.Size = new Size(100, 23);
            textBox_Person.TabIndex = 11;
            // 
            // textBox_Log
            // 
            textBox_Log.Location = new Point(218, 272);
            textBox_Log.Name = "textBox_Log";
            textBox_Log.Size = new Size(100, 23);
            textBox_Log.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Bahnschrift", 11.25F, FontStyle.Bold);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Image = (Image)resources.GetObject("label5.Image");
            label5.Location = new Point(46, 356);
            label5.Name = "label5";
            label5.Size = new Size(165, 18);
            label5.TabIndex = 13;
            label5.Text = "Was it zero day exploit?";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Bahnschrift", 11.25F, FontStyle.Bold);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Image = (Image)resources.GetObject("label6.Image");
            label6.Location = new Point(46, 174);
            label6.Name = "label6";
            label6.Size = new Size(114, 18);
            label6.TabIndex = 14;
            label6.Text = "Datum of attack";
            // 
            // EditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(440, 553);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(textBox_Log);
            Controls.Add(textBox_Person);
            Controls.Add(textBox_Method);
            Controls.Add(textBox_Name);
            Controls.Add(checkBox_ZeroDayExploit);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dateTimePicker_LastAttack);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button_Cancel);
            Controls.Add(button_Save);
            Name = "EditForm";
            Text = "EditForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_Save;
        private Button button_Cancel;
        private Label label1;
        private Label label2;
        private DateTimePicker dateTimePicker_LastAttack;
        private Label label3;
        private Label label4;
        private CheckBox checkBox_ZeroDayExploit;
        private TextBox textBox_Name;
        private TextBox textBox_Method;
        private TextBox textBox_Person;
        private TextBox textBox_Log;
        private Label label5;
        private Label label6;
    }
}