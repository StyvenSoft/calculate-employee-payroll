﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fase1SteveenEcheverri
{
    public partial class EmployeeScreen : Form
    {

        Nomina theNomina = new Nomina();

        public EmployeeScreen()
        {
            InitializeComponent();
        }

        private void checkBoxMale_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxMale.Checked == true)
            {
                checkBoxFemale.Checked = false;
            }
        }

        private void checkBoxFemale_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxFemale.Checked == true)
            {
                checkBoxMale.Checked = false;
            }
        }

        private void cmbPosition_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cmbPosition.SelectedIndex;
            if (index == 0)
            {
                txtSalary.Text = "60000";
            } else if (index == 1)
            {
                txtSalary.Text = "65000";
            }
            else if (index == 2)
            {
                txtSalary.Text = "70000";
            }
            else if (index == 3)
            {
                txtSalary.Text = "40000";
            }
            else
            {
                txtSalary.Text = "50000";
            }
        }

        private void btnSaveRegister_Click(object sender, EventArgs e)
        {
            if (txtIdentification.Text != "")
            {
                theNomina.IdEmployee = Convert.ToInt32(txtIdentification.Text);
                theNomina.FullName = txtFullName.Text;
                if (checkBoxMale.Checked == true)
                {
                    theNomina.Gender = "Masculino";
                }
                else
                {
                    theNomina.Gender = "Femenino";
                }
                theNomina.WorkingDays = txtDays.Text;
                theNomina.DailySalary = txtSalary.Text;
                MessageBox.Show("Datos guardados con exito!");
            } else
            {
                MessageBox.Show("Error al guardar los datos!");
            }
        }
    }
}
