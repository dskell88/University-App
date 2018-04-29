using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab18_19_200_Skelly_Daniel
{
    public partial class ProductDataGridView : Form
    {
        public ProductDataGridView()
        {
            InitializeComponent();
            Textbooks f1 = new Textbooks();
            Student f2 = new Student();
            f1.Show();
            f2.Show();
        }

        private void productsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cSharpUniversityDataSet);

        }

        private void ProductDataGridView_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cSharpUniversityDataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.cSharpUniversityDataSet.Products);

        }
    }
}
