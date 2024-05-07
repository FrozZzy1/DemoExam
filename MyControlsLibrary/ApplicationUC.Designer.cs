namespace MyControlsLibrary
{
    partial class ApplicationUC
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            tbId = new TextBox();
            tbDate = new TextBox();
            tbEquipment = new TextBox();
            tbDefect = new TextBox();
            tbClient = new TextBox();
            tbStatus = new TextBox();
            tbResponsible = new TextBox();
            label7 = new Label();
            tbProblemDescription = new RichTextBox();
            label8 = new Label();
            EditButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(5, 5);
            label1.Name = "label1";
            label1.Size = new Size(68, 23);
            label1.TabIndex = 0;
            label1.Text = "Number";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(71, 5);
            label2.Name = "label2";
            label2.Size = new Size(45, 23);
            label2.TabIndex = 1;
            label2.Text = "Date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(172, 5);
            label3.Name = "label3";
            label3.Size = new Size(84, 23);
            label3.TabIndex = 2;
            label3.Text = "Equipment";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(339, 5);
            label4.Name = "label4";
            label4.Size = new Size(61, 23);
            label4.TabIndex = 3;
            label4.Text = "Defect";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(506, 5);
            label5.Name = "label5";
            label5.Size = new Size(53, 23);
            label5.TabIndex = 4;
            label5.Text = "Client";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(637, 5);
            label6.Name = "label6";
            label6.Size = new Size(58, 23);
            label6.TabIndex = 5;
            label6.Text = "Status";
            label6.Click += label6_Click;
            // 
            // tbId
            // 
            tbId.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            tbId.Location = new Point(5, 31);
            tbId.Name = "tbId";
            tbId.ReadOnly = true;
            tbId.Size = new Size(60, 26);
            tbId.TabIndex = 6;
            // 
            // tbDate
            // 
            tbDate.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            tbDate.Location = new Point(71, 31);
            tbDate.Name = "tbDate";
            tbDate.ReadOnly = true;
            tbDate.Size = new Size(95, 26);
            tbDate.TabIndex = 7;
            // 
            // tbEquipment
            // 
            tbEquipment.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            tbEquipment.Location = new Point(172, 31);
            tbEquipment.Name = "tbEquipment";
            tbEquipment.ReadOnly = true;
            tbEquipment.Size = new Size(161, 26);
            tbEquipment.TabIndex = 8;
            // 
            // tbDefect
            // 
            tbDefect.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            tbDefect.Location = new Point(339, 31);
            tbDefect.Name = "tbDefect";
            tbDefect.ReadOnly = true;
            tbDefect.Size = new Size(161, 26);
            tbDefect.TabIndex = 9;
            // 
            // tbClient
            // 
            tbClient.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            tbClient.Location = new Point(506, 31);
            tbClient.Name = "tbClient";
            tbClient.ReadOnly = true;
            tbClient.Size = new Size(125, 26);
            tbClient.TabIndex = 10;
            // 
            // tbStatus
            // 
            tbStatus.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            tbStatus.Location = new Point(637, 31);
            tbStatus.Name = "tbStatus";
            tbStatus.ReadOnly = true;
            tbStatus.Size = new Size(125, 26);
            tbStatus.TabIndex = 11;
            // 
            // tbResponsible
            // 
            tbResponsible.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            tbResponsible.Location = new Point(768, 31);
            tbResponsible.Name = "tbResponsible";
            tbResponsible.ReadOnly = true;
            tbResponsible.Size = new Size(128, 26);
            tbResponsible.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(768, 5);
            label7.Name = "label7";
            label7.Size = new Size(96, 23);
            label7.TabIndex = 13;
            label7.Text = "Responsible";
            // 
            // tbProblemDescription
            // 
            tbProblemDescription.Location = new Point(3, 90);
            tbProblemDescription.Name = "tbProblemDescription";
            tbProblemDescription.ReadOnly = true;
            tbProblemDescription.Size = new Size(759, 51);
            tbProblemDescription.TabIndex = 14;
            tbProblemDescription.Text = "";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(3, 64);
            label8.Name = "label8";
            label8.Size = new Size(208, 23);
            label8.TabIndex = 15;
            label8.Text = "Description of the problem";
            // 
            // EditButton
            // 
            EditButton.BackColor = Color.Cyan;
            EditButton.Font = new Font("Comic Sans MS", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            EditButton.Location = new Point(768, 90);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(128, 51);
            EditButton.TabIndex = 16;
            EditButton.Text = "Edit";
            EditButton.UseVisualStyleBackColor = false;
            // 
            // ApplicationUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(EditButton);
            Controls.Add(label8);
            Controls.Add(tbProblemDescription);
            Controls.Add(label7);
            Controls.Add(tbResponsible);
            Controls.Add(tbStatus);
            Controls.Add(tbClient);
            Controls.Add(tbDefect);
            Controls.Add(tbEquipment);
            Controls.Add(tbDate);
            Controls.Add(tbId);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ApplicationUC";
            Size = new Size(901, 146);
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
        private TextBox tbId;
        private TextBox tbDate;
        private TextBox tbEquipment;
        private TextBox tbDefect;
        private TextBox tbClient;
        private TextBox tbStatus;
        private TextBox tbResponsible;
        private Label label7;
        private RichTextBox tbProblemDescription;
        private Label label8;
        private Button EditButton;
    }
}