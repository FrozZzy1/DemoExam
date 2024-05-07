namespace DemoApp
{
    partial class AddEditWIndow
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
            textId = new TextBox();
            textDate = new TextBox();
            textEquipment = new TextBox();
            textDefect = new TextBox();
            textResponsible = new TextBox();
            textProblemDescription = new RichTextBox();
            boxState = new ComboBox();
            textClient = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            buttonBack = new Button();
            buttonSave = new Button();
            SuspendLayout();
            // 
            // textId
            // 
            textId.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textId.Location = new Point(41, 36);
            textId.Margin = new Padding(3, 2, 3, 2);
            textId.Name = "textId";
            textId.Size = new Size(328, 32);
            textId.TabIndex = 0;
            // 
            // textDate
            // 
            textDate.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textDate.Location = new Point(41, 98);
            textDate.Margin = new Padding(3, 2, 3, 2);
            textDate.Name = "textDate";
            textDate.Size = new Size(328, 32);
            textDate.TabIndex = 1;
            // 
            // textEquipment
            // 
            textEquipment.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textEquipment.Location = new Point(41, 164);
            textEquipment.Margin = new Padding(3, 2, 3, 2);
            textEquipment.Name = "textEquipment";
            textEquipment.Size = new Size(328, 32);
            textEquipment.TabIndex = 2;
            // 
            // textDefect
            // 
            textDefect.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textDefect.Location = new Point(41, 231);
            textDefect.Margin = new Padding(3, 2, 3, 2);
            textDefect.Name = "textDefect";
            textDefect.Size = new Size(328, 32);
            textDefect.TabIndex = 3;
            // 
            // textResponsible
            // 
            textResponsible.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textResponsible.Location = new Point(41, 566);
            textResponsible.Margin = new Padding(3, 2, 3, 2);
            textResponsible.Name = "textResponsible";
            textResponsible.Size = new Size(328, 32);
            textResponsible.TabIndex = 4;
            // 
            // textProblemDescription
            // 
            textProblemDescription.Location = new Point(41, 299);
            textProblemDescription.Margin = new Padding(3, 2, 3, 2);
            textProblemDescription.Name = "textProblemDescription";
            textProblemDescription.Size = new Size(328, 91);
            textProblemDescription.TabIndex = 5;
            textProblemDescription.Text = "";
            // 
            // boxState
            // 
            boxState.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            boxState.FormattingEnabled = true;
            boxState.Items.AddRange(new object[] { "Completed", "At work", "Not completed" });
            boxState.Location = new Point(41, 496);
            boxState.Margin = new Padding(3, 2, 3, 2);
            boxState.Name = "boxState";
            boxState.Size = new Size(328, 33);
            boxState.TabIndex = 6;
            // 
            // textClient
            // 
            textClient.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textClient.Location = new Point(41, 428);
            textClient.Margin = new Padding(3, 2, 3, 2);
            textClient.Name = "textClient";
            textClient.Size = new Size(328, 32);
            textClient.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(44, 14);
            label1.Name = "label1";
            label1.Size = new Size(23, 21);
            label1.TabIndex = 8;
            label1.Text = "Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(44, 75);
            label2.Name = "label2";
            label2.Size = new Size(121, 21);
            label2.TabIndex = 9;
            label2.Text = "Date of addition";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(44, 141);
            label3.Name = "label3";
            label3.Size = new Size(85, 21);
            label3.TabIndex = 10;
            label3.Text = "Equipment";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(44, 208);
            label4.Name = "label4";
            label4.Size = new Size(106, 21);
            label4.TabIndex = 11;
            label4.Text = "Type of defect";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(44, 276);
            label5.Name = "label5";
            label5.Size = new Size(196, 21);
            label5.TabIndex = 12;
            label5.Text = "Description of the problem";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(44, 405);
            label6.Name = "label6";
            label6.Size = new Size(50, 21);
            label6.TabIndex = 13;
            label6.Text = "Client";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(44, 473);
            label7.Name = "label7";
            label7.Size = new Size(52, 21);
            label7.TabIndex = 14;
            label7.Text = "Status";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(44, 543);
            label8.Name = "label8";
            label8.Size = new Size(94, 21);
            label8.TabIndex = 15;
            label8.Text = "Responsible";
            // 
            // buttonBack
            // 
            buttonBack.BackColor = Color.Red;
            buttonBack.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonBack.Location = new Point(41, 616);
            buttonBack.Margin = new Padding(3, 2, 3, 2);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(151, 38);
            buttonBack.TabIndex = 16;
            buttonBack.Text = "Back";
            buttonBack.UseVisualStyleBackColor = false;
            buttonBack.Click += buttonBack_Click;
            // 
            // buttonSave
            // 
            buttonSave.BackColor = Color.FromArgb(0, 192, 0);
            buttonSave.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSave.Location = new Point(217, 616);
            buttonSave.Margin = new Padding(3, 2, 3, 2);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(151, 38);
            buttonSave.TabIndex = 17;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += buttonSave_Click;
            // 
            // AddEditWIndow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(407, 671);
            Controls.Add(buttonSave);
            Controls.Add(buttonBack);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textClient);
            Controls.Add(boxState);
            Controls.Add(textProblemDescription);
            Controls.Add(textResponsible);
            Controls.Add(textDefect);
            Controls.Add(textEquipment);
            Controls.Add(textDate);
            Controls.Add(textId);
            Margin = new Padding(3, 2, 3, 2);
            Name = "AddEditWIndow";
            Text = "AddEditWIndow";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button buttonBack;
        private Button buttonSave;
        public TextBox textId;
        public TextBox textDate;
        public TextBox textEquipment;
        public TextBox textDefect;
        public TextBox textResponsible;
        public RichTextBox textProblemDescription;
        public ComboBox boxState;
        public TextBox textClient;
    }
}