namespace DemoApp
{
    partial class ApplicationsForm
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
            textSearch = new TextBox();
            buttonSearch = new Button();
            buttonStatistics = new Button();
            buttonAdd = new Button();
            panelApplications = new FlowLayoutPanel();
            label1 = new Label();
            SuspendLayout();
            // 
            // textSearch
            // 
            textSearch.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            textSearch.Location = new Point(10, 18);
            textSearch.Margin = new Padding(3, 2, 3, 2);
            textSearch.Name = "textSearch";
            textSearch.Size = new Size(274, 36);
            textSearch.TabIndex = 0;
            // 
            // buttonSearch
            // 
            buttonSearch.BackColor = Color.Cyan;
            buttonSearch.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSearch.Location = new Point(290, 18);
            buttonSearch.Margin = new Padding(3, 2, 3, 2);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(104, 36);
            buttonSearch.TabIndex = 1;
            buttonSearch.Text = "Search";
            buttonSearch.UseVisualStyleBackColor = false;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // buttonStatistics
            // 
            buttonStatistics.BackColor = Color.Cyan;
            buttonStatistics.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonStatistics.Location = new Point(835, 11);
            buttonStatistics.Margin = new Padding(3, 2, 3, 2);
            buttonStatistics.Name = "buttonStatistics";
            buttonStatistics.Size = new Size(104, 41);
            buttonStatistics.TabIndex = 2;
            buttonStatistics.Text = "Open";
            buttonStatistics.UseVisualStyleBackColor = false;
            buttonStatistics.Click += buttonStatistics_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = Color.Cyan;
            buttonAdd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAdd.Location = new Point(835, 439);
            buttonAdd.Margin = new Padding(3, 2, 3, 2);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(104, 41);
            buttonAdd.TabIndex = 3;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // panelApplications
            // 
            panelApplications.AutoScroll = true;
            panelApplications.Location = new Point(3, 70);
            panelApplications.Margin = new Padding(3, 2, 3, 2);
            panelApplications.Name = "panelApplications";
            panelApplications.Size = new Size(944, 365);
            panelApplications.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(675, 26);
            label1.Name = "label1";
            label1.Size = new Size(154, 21);
            label1.TabIndex = 5;
            label1.Text = "Application statistics:";
            // 
            // ApplicationsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(949, 490);
            Controls.Add(label1);
            Controls.Add(panelApplications);
            Controls.Add(buttonAdd);
            Controls.Add(buttonStatistics);
            Controls.Add(buttonSearch);
            Controls.Add(textSearch);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ApplicationsForm";
            Text = "Заявки";
            Load += ApplicationsForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textSearch;
        private Button buttonSearch;
        private Button buttonStatistics;
        private Button buttonAdd;
        private FlowLayoutPanel panelApplications;
        private Label label1;
    }
}