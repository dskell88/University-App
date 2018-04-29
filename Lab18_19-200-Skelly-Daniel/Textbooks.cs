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
    public partial class Textbooks : Form
    {
        public Textbooks()
        {
            InitializeComponent();
        }

        private void productsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (DataValid())
            {

                try
                {
                    this.productsBindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.cSharpUniversityDataSet);
                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show(ex.Message, "Argument Exception");
                }
                catch (DBConcurrencyException)
                {
                    MessageBox.Show("A concurrency occured");
                    this.productsTableAdapter.Fill(this.cSharpUniversityDataSet.Products);
                }


            }
        }

        private void Textbooks_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cSharpUniversityDataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.cSharpUniversityDataSet.Products);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                string productID = Convert.ToString(prodCodeTextBox.Text);
                this.productsTableAdapter.FillBy(this.cSharpUniversityDataSet.Products, productID);
                if (prodCodeTextBox.Text == "")
                    MessageBox.Show("Product ID must be entered");
                    
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

            prodCodeTextBox.Focus();
 
            

        }

        private void getAlltoolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.productsTableAdapter.Fill(this.cSharpUniversityDataSet.Products);
            }
            catch (OleDbException ex)
            {
                MessageBox.Show("Database error #" + ": " + ex.Message,
                    ex.GetType().ToString());
            }
        }

        private void unit_PriceTextBox_TextChanged(object sender, EventArgs e)
        {
        

        }

        private void ReadOnlyFalse()
        {
            product_CodeTextBox.ReadOnly = false;
            descriptionTextBox.ReadOnly = false;
            unit_PriceTextBox.ReadOnly = false;
        }
        private void ReadOnlyTrue()
        {
            product_CodeTextBox.ReadOnly = true;
            descriptionTextBox.ReadOnly = true;
            unit_PriceTextBox.ReadOnly = true;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            ReadOnlyFalse();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            ReadOnlyTrue();
        }
        public bool DataValid()
        {
            if (product_CodeTextBox.Text == "")
            {
                MessageBox.Show("Product Code required", "Product Entry Error");
                product_CodeTextBox.Focus();
                return false;
            }
            else if (descriptionTextBox.Text == "")
            {
                MessageBox.Show("Description", "description entry error");
                product_CodeTextBox.Focus();
                return false;
            }
            else if (unit_PriceTextBox.Text == "")
            {
                MessageBox.Show("Unit Price required", "Unit Price Entry Error");
                product_CodeTextBox.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }

    }
   
}
