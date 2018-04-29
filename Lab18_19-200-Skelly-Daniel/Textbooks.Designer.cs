namespace Lab18_19_200_Skelly_Daniel
{
    partial class Textbooks
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label product_CodeLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label unit_PriceLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Textbooks));
            this.cSharpUniversityDataSet = new Lab18_19_200_Skelly_Daniel.CSharpUniversityDataSet();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productsTableAdapter = new Lab18_19_200_Skelly_Daniel.CSharpUniversityDataSetTableAdapters.ProductsTableAdapter();
            this.tableAdapterManager = new Lab18_19_200_Skelly_Daniel.CSharpUniversityDataSetTableAdapters.TableAdapterManager();
            this.productsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.productsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.product_CodeTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.unit_PriceTextBox = new System.Windows.Forms.TextBox();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.product_CodeToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.prodCodeTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.getAlltoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.addButton = new System.Windows.Forms.ToolStripButton();
            this.cancelButton = new System.Windows.Forms.ToolStripButton();
            product_CodeLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            unit_PriceLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cSharpUniversityDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingNavigator)).BeginInit();
            this.productsBindingNavigator.SuspendLayout();
            this.fillByToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // product_CodeLabel
            // 
            product_CodeLabel.AutoSize = true;
            product_CodeLabel.Location = new System.Drawing.Point(54, 90);
            product_CodeLabel.Name = "product_CodeLabel";
            product_CodeLabel.Size = new System.Drawing.Size(75, 13);
            product_CodeLabel.TabIndex = 1;
            product_CodeLabel.Text = "Product Code:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(54, 116);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(63, 13);
            descriptionLabel.TabIndex = 3;
            descriptionLabel.Text = "Description:";
            // 
            // unit_PriceLabel
            // 
            unit_PriceLabel.AutoSize = true;
            unit_PriceLabel.Location = new System.Drawing.Point(54, 142);
            unit_PriceLabel.Name = "unit_PriceLabel";
            unit_PriceLabel.Size = new System.Drawing.Size(56, 13);
            unit_PriceLabel.TabIndex = 5;
            unit_PriceLabel.Text = "Unit Price:";
            // 
            // cSharpUniversityDataSet
            // 
            this.cSharpUniversityDataSet.DataSetName = "CSharpUniversityDataSet";
            this.cSharpUniversityDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.cSharpUniversityDataSet;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ProductsTableAdapter = this.productsTableAdapter;
            this.tableAdapterManager.StudentsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Lab18_19_200_Skelly_Daniel.CSharpUniversityDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // productsBindingNavigator
            // 
            this.productsBindingNavigator.AddNewItem = null;
            this.productsBindingNavigator.BindingSource = this.productsBindingSource;
            this.productsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.productsBindingNavigator.DeleteItem = null;
            this.productsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.productsBindingNavigatorSaveItem,
            this.toolStripSeparator,
            this.toolStripSeparator1,
            this.addButton,
            this.cancelButton});
            this.productsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.productsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.productsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.productsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.productsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.productsBindingNavigator.Name = "productsBindingNavigator";
            this.productsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.productsBindingNavigator.Size = new System.Drawing.Size(501, 25);
            this.productsBindingNavigator.TabIndex = 0;
            this.productsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // productsBindingNavigatorSaveItem
            // 
            this.productsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.productsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("productsBindingNavigatorSaveItem.Image")));
            this.productsBindingNavigatorSaveItem.Name = "productsBindingNavigatorSaveItem";
            this.productsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.productsBindingNavigatorSaveItem.Text = "Save Data";
            this.productsBindingNavigatorSaveItem.Click += new System.EventHandler(this.productsBindingNavigatorSaveItem_Click);
            // 
            // product_CodeTextBox
            // 
            this.product_CodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "Product Code", true));
            this.product_CodeTextBox.Location = new System.Drawing.Point(135, 87);
            this.product_CodeTextBox.Name = "product_CodeTextBox";
            this.product_CodeTextBox.ReadOnly = true;
            this.product_CodeTextBox.Size = new System.Drawing.Size(128, 20);
            this.product_CodeTextBox.TabIndex = 2;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "Description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(135, 113);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.ReadOnly = true;
            this.descriptionTextBox.Size = new System.Drawing.Size(128, 20);
            this.descriptionTextBox.TabIndex = 4;
            // 
            // unit_PriceTextBox
            // 
            this.unit_PriceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "Unit Price", true));
            this.unit_PriceTextBox.Location = new System.Drawing.Point(135, 139);
            this.unit_PriceTextBox.Name = "unit_PriceTextBox";
            this.unit_PriceTextBox.ReadOnly = true;
            this.unit_PriceTextBox.Size = new System.Drawing.Size(128, 20);
            this.unit_PriceTextBox.TabIndex = 6;
            this.unit_PriceTextBox.TextChanged += new System.EventHandler(this.unit_PriceTextBox_TextChanged);
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.product_CodeToolStripLabel,
            this.prodCodeTextBox,
            this.fillByToolStripButton,
            this.getAlltoolStripButton});
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 25);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(501, 25);
            this.fillByToolStrip.TabIndex = 7;
            this.fillByToolStrip.Text = "fillByToolStrip";
            // 
            // product_CodeToolStripLabel
            // 
            this.product_CodeToolStripLabel.Name = "product_CodeToolStripLabel";
            this.product_CodeToolStripLabel.Size = new System.Drawing.Size(85, 22);
            this.product_CodeToolStripLabel.Text = "Product_Code:";
            // 
            // prodCodeTextBox
            // 
            this.prodCodeTextBox.Name = "prodCodeTextBox";
            this.prodCodeTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(99, 22);
            this.fillByToolStripButton.Text = "GetProductCode";
            this.fillByToolStripButton.Click += new System.EventHandler(this.fillByToolStripButton_Click);
            // 
            // getAlltoolStripButton
            // 
            this.getAlltoolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.getAlltoolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("getAlltoolStripButton.Image")));
            this.getAlltoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.getAlltoolStripButton.Name = "getAlltoolStripButton";
            this.getAlltoolStripButton.Size = new System.Drawing.Size(96, 22);
            this.getAlltoolStripButton.Text = "Get All Products";
            this.getAlltoolStripButton.Click += new System.EventHandler(this.getAlltoolStripButton_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // addButton
            // 
            this.addButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.addButton.Image = ((System.Drawing.Image)(resources.GetObject("addButton.Image")));
            this.addButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(33, 22);
            this.addButton.Text = "Add";
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.cancelButton.Image = ((System.Drawing.Image)(resources.GetObject("cancelButton.Image")));
            this.cancelButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(47, 22);
            this.cancelButton.Text = "Cancel";
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // Textbooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 190);
            this.Controls.Add(this.fillByToolStrip);
            this.Controls.Add(product_CodeLabel);
            this.Controls.Add(this.product_CodeTextBox);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(unit_PriceLabel);
            this.Controls.Add(this.unit_PriceTextBox);
            this.Controls.Add(this.productsBindingNavigator);
            this.Name = "Textbooks";
            this.Text = "Textbooks";
            this.Load += new System.EventHandler(this.Textbooks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cSharpUniversityDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingNavigator)).EndInit();
            this.productsBindingNavigator.ResumeLayout(false);
            this.productsBindingNavigator.PerformLayout();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CSharpUniversityDataSet cSharpUniversityDataSet;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private CSharpUniversityDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
        private CSharpUniversityDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator productsBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton productsBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox product_CodeTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox unit_PriceTextBox;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripLabel product_CodeToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox prodCodeTextBox;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
        private System.Windows.Forms.ToolStripButton getAlltoolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton addButton;
        private System.Windows.Forms.ToolStripButton cancelButton;
    }
}