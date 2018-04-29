using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab18_19_200_Skelly_Daniel
{
    public partial class Student : Form
    {
        public Student()
        {
            InitializeComponent();
        }

        private void studentsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.studentsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cSharpUniversityDataSet);

        }

        private void Student_Load(object sender, EventArgs e)
        {
            try
            {
                this.studentsTableAdapter.Fill(this.cSharpUniversityDataSet.Students);
            }
            catch (OleDbException ex)
            {
                MessageBox.Show("Database error #" + ": " + ex.Message,
        ex.GetType().ToString());
            }

        }

        private void stateCodeLabel_Click(object sender, EventArgs e)
        {

        }

        private void stateCodeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void firstNameLabel_Click(object sender, EventArgs e)
        {

        }

        public bool DataValid()
        {
            if (studentIDTextBox.Text == "")
            {
                MessageBox.Show("Student ID is required", "Student ID Entry Error");
                studentIDTextBox.Focus();
                return false;

            }
            else if (firstNameTextBox.Text == "")
            {
                MessageBox.Show("First name is required", "First Name Entry Error");
                firstNameTextBox.Focus();
                return false;
            }
            else if (lastNameTextBox.Text == "")
            {
                MessageBox.Show("Last name is required", "Last Name Entry Error");
                lastNameComboBox.Focus();

                return false;
            }
            else if (addressTextBox.Text == "")
            {
                MessageBox.Show("Address is required", "Address Entry Error");
                addressTextBox.Focus();

                return false;
            }
            else if (cityTextBox.Text == "")
            {
                MessageBox.Show("City is required", "City Entry Error");
               cityTextBox.Focus();

                return false;
            }
            else if (stateCodeTextBox.Text == "")
            {
                MessageBox.Show("State is required", "State Entry Error");
                stateCodeTextBox.Focus();

                return false;
            }
            else if (zipCodeTextBox.Text == "")
            {
                MessageBox.Show("Zip is required", "Zip Entry Error");
                zipCodeTextBox.Focus();

                return false;
            }
            else if (telephoneNumberTextBox.Text == "")
            {
                MessageBox.Show("Telephone is required", "Telephone Entry Error");
                telephoneNumberTextBox.Focus();

                return false;
            }
            else if (emailTextBox.Text == "")
            {
                MessageBox.Show("Email is required", "Email Entry Error");
                emailTextBox.Focus();

                return false;
            }
            else if (amountOwedTextBox.Text == "")
            {
                MessageBox.Show("Amount is required", "Amount Entry Error");
                amountOwedTextBox.Focus();

                return false;
            }
            else
            {
                return true;
            }

        }

        private void bindingNavigatorControlFalse()
        {
            
                bindingNavigatorMoveFirstItem.Visible = false;
                bindingNavigatorMoveLastItem.Visible = false;
                bindingNavigatorMoveNextItem.Visible = false;
                bindingNavigatorMovePreviousItem.Visible = false;
                bindingNavigatorPositionItem.Visible = false;
                bindingNavigatorAddNewItem.Visible = false;
            bindingNavigatorAddNewItem.Visible = false;   
            
        }

        private void bindingNavigatorControlTrue()
        {
            bindingNavigatorMoveFirstItem.Visible = true;
            bindingNavigatorMoveLastItem.Visible = true;
            bindingNavigatorMoveNextItem.Visible = true;
            bindingNavigatorMovePreviousItem.Visible = true;
            bindingNavigatorPositionItem.Visible = true;
            bindingNavigatorAddNewItem.Visible = true;
            bindingNavigatorAddNewItem.Visible = true;
    

        }
        private void ReadOnlyFalse()
        {
            studentIDTextBox.ReadOnly = false;
            lastNameTextBox.ReadOnly = false;
            firstNameTextBox.ReadOnly = false;
            addressTextBox.ReadOnly = false;
            cityTextBox.ReadOnly = false;
            zipCodeTextBox.ReadOnly = false;
            telephoneNumberTextBox.ReadOnly = false;
            emailTextBox.ReadOnly = false;
            amountOwedTextBox.ReadOnly = false;
        }
        private void ReadOnlyTrue()
        {
            studentIDTextBox.ReadOnly = true;
            lastNameTextBox.ReadOnly = true;
            firstNameTextBox.ReadOnly = true;
            addressTextBox.ReadOnly = true;
            cityTextBox.ReadOnly = true;
            zipCodeTextBox.ReadOnly = true;
            telephoneNumberTextBox.ReadOnly = true;
            emailTextBox.ReadOnly = true;
            amountOwedTextBox.ReadOnly = true;
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            ReadOnlyFalse();
            bindingNavigatorControlFalse();
            lastNameComboBox.Enabled = false;
        }

        private void cancelEditToolStrip_Click(object sender, EventArgs e)
        {
            ReadOnlyTrue();
            bindingNavigatorControlTrue();
            lastNameComboBox.Enabled = true;
        }
    }
}
        
    
