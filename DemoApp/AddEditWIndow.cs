using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyControlsLibrary;

namespace DemoApp
{
    public partial class AddEditWIndow : Form
    {
        public MyApplication currentApplication;
        public int id;
        public DateTime dateStart, dateEnd;
        public AddEditWIndow(MyApplication app)
        {
            InitializeComponent();
            currentApplication = app;
            if (IsAddWindow())
            {
                FillTextBoxesAdd();
            }
            else
            {
                FillTextBoxesEdit();
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (textClient.Text == "" || textDate.Text == "" || textDefect.Text == "" || textEquipment.Text == ""
                || textId.Text == "" || textProblemDescription.Text == "")
            {
                MessageBox.Show("Fill in all the fields");
                return;
            }

            if (IsAddWindow())
            {
                if (!int.TryParse(textId.Text, out id))
                {
                    MessageBox.Show("Invalid Id");
                    textId.Text = "";
                    return;
                }
                if (!DateTime.TryParse(textDate.Text, out dateStart))
                {
                    MessageBox.Show("Invalid date");
                    textDate.Text = "";
                    return;
                }
            }
            else
            {
                if(boxState.SelectedIndex == 0 && currentApplication.DateEnd == DateTime.MinValue)
                {
                    dateEnd = DateTime.Now;
                    currentApplication.DateEnd = dateEnd;
                }
                else if((boxState.SelectedIndex == 0 || boxState.SelectedIndex == 1) && textResponsible.Text == "")
                {
                    MessageBox.Show("Specify the person responsible for completing the application");
                    return;
                }
            }
            this.DialogResult = DialogResult.OK;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        public bool IsAddWindow()
        {
            if (currentApplication == null) return true;
            return false;
        }

        public void FillTextBoxesAdd() 
        {
            textResponsible.ReadOnly = true;
            boxState.SelectedIndex = 2;
            boxState.Enabled = false;
        }

        public void FillTextBoxesEdit()
        {
            textClient.Text = currentApplication.Client;
            textDate.Text = currentApplication.DateStart.ToString();
            textDefect.Text = currentApplication.Defect;
            textEquipment.Text = currentApplication.Equipment;
            textProblemDescription.Text = currentApplication.ProblemDescription;
            textId.Text = currentApplication.Id.ToString();
            textResponsible.Text = currentApplication.Responsible;
            foreach (var item in boxState.Items)
            {
                if(item == currentApplication.Status)
                {
                    boxState.SelectedItem = item;
                    break;
                }
            }

            textId.ReadOnly = true;
            textDate.ReadOnly = true;
            textClient.ReadOnly = true;
            textEquipment.ReadOnly = true;
            textDefect.ReadOnly = true;
        }
    }
}
