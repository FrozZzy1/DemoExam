using Microsoft.VisualBasic.ApplicationServices;
using System.ComponentModel;

namespace MyControlsLibrary
{
    [DefaultEvent(nameof(Click))]
    public partial class ApplicationUC : UserControl
    {
        public ApplicationUC()
        {
            InitializeComponent();
        }

        [Browsable(true)]
        public new event EventHandler? Click
        {
            add { EditButton.Click += value; }
            remove { EditButton.Click -= value; }
        }

        [Browsable(true)]
        public string Id
        {
            get => tbId.Text;
            set => tbId.Text = value;
        }

        [Browsable(true)]
        public string Date
        {
            get => tbDate.Text;
            set => tbDate.Text = value;
        }

        [Browsable(true)]
        public string Equipment
        {
            get => tbEquipment.Text;
            set => tbEquipment.Text = value;
        }

        [Browsable(true)]
        public string Defect
        {
            get => tbDefect.Text;
            set => tbDefect.Text = value;
        }

        [Browsable(true)]
        public string Client
        {
            get => tbClient.Text;
            set => tbClient.Text = value;
        }

        [Browsable(true)]
        public string Status
        {
            get => tbStatus.Text;
            set => tbStatus.Text = value;
        }

        [Browsable(true)]
        public string Responsible
        {
            get => tbResponsible.Text;
            set => tbResponsible.Text = value;
        }

        [Browsable(true)]
        public string ProblemDescription
        {
            get => tbProblemDescription.Text;
            set => tbProblemDescription.Text = value;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}