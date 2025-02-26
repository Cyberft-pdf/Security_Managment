namespace WinFormsApp1
{
    partial class ManagmentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagmentForm));
            button_add = new Button();
            button_edit = new Button();
            button_delete = new Button();
            dataGridView_SecurityIncidents = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView_SecurityIncidents).BeginInit();
            SuspendLayout();
            // 
            // button_add
            // 
            button_add.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            button_add.Location = new Point(619, 494);
            button_add.Name = "button_add";
            button_add.Size = new Size(85, 39);
            button_add.TabIndex = 7;
            button_add.Text = "add";
            button_add.UseVisualStyleBackColor = true;
            button_add.Click += button_add_Click;
            // 
            // button_edit
            // 
            button_edit.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            button_edit.Location = new Point(744, 494);
            button_edit.Name = "button_edit";
            button_edit.Size = new Size(82, 39);
            button_edit.TabIndex = 6;
            button_edit.Text = "edit";
            button_edit.UseVisualStyleBackColor = true;
            button_edit.Click += button_edit_Click;
            // 
            // button_delete
            // 
            button_delete.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            button_delete.Location = new Point(867, 494);
            button_delete.Name = "button_delete";
            button_delete.Size = new Size(85, 39);
            button_delete.TabIndex = 5;
            button_delete.Text = "delete";
            button_delete.UseVisualStyleBackColor = true;
            button_delete.Click += button_delete_Click;
            // 
            // dataGridView_SecurityIncidents
            // 
            dataGridView_SecurityIncidents.AllowUserToAddRows = false;
            dataGridView_SecurityIncidents.AllowUserToDeleteRows = false;
            dataGridView_SecurityIncidents.BackgroundColor = SystemColors.ButtonFace;
            dataGridView_SecurityIncidents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_SecurityIncidents.Location = new Point(39, 25);
            dataGridView_SecurityIncidents.Name = "dataGridView_SecurityIncidents";
            dataGridView_SecurityIncidents.ReadOnly = true;
            dataGridView_SecurityIncidents.Size = new Size(913, 413);
            dataGridView_SecurityIncidents.TabIndex = 4;
            dataGridView_SecurityIncidents.CellContentClick += dataGridView_SecurityIncidents_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Image = (Image)resources.GetObject("label1.Image");
            label1.Location = new Point(39, 518);
            label1.Name = "label1";
            label1.Size = new Size(144, 15);
            label1.TabIndex = 8;
            label1.Text = "made by Adéla Steinerová";
            // 
            // ManagmentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1006, 588);
            Controls.Add(label1);
            Controls.Add(button_add);
            Controls.Add(button_edit);
            Controls.Add(button_delete);
            Controls.Add(dataGridView_SecurityIncidents);
            Name = "ManagmentForm";
            Text = "ManagmentForm";
            Load += ManagmentForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView_SecurityIncidents).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_add;
        private Button button_edit;
        private Button button_delete;
        private DataGridView dataGridView_SecurityIncidents;
        private Label label1;
    }
}