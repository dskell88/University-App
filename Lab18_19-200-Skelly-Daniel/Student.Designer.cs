namespace Lab18_19_200_Skelly_Daniel
{
    partial class Student
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
            System.Windows.Forms.Label studentIDLabel;
            System.Windows.Forms.Label lastNameLabel;
            System.Windows.Forms.Label firstNameLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label cityLabel;
            System.Windows.Forms.Label stateCodeLabel;
            System.Windows.Forms.Label zipCodeLabel;
            System.Windows.Forms.Label telephoneNumberLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label amountOwedLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Student));
            this.cSharpUniversityDataSet = new Lab18_19_200_Skelly_Daniel.CSharpUniversityDataSet();
            this.studentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentsTableAdapter = new Lab18_19_200_Skelly_Daniel.CSharpUniversityDataSetTableAdapters.StudentsTableAdapter();
            this.tableAdapterManager = new Lab18_19_200_Skelly_Daniel.CSharpUniversityDataSetTableAdapters.TableAdapterManager();
            this.studentsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cancelEditToolStrip = new System.Windows.Forms.ToolStripButton();
            this.editToolStrip = new System.Windows.Forms.ToolStripButton();
            this.studentIDTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.stateCodeTextBox = new System.Windows.Forms.TextBox();
            this.zipCodeTextBox = new System.Windows.Forms.TextBox();
            this.telephoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.amountOwedTextBox = new System.Windows.Forms.TextBox();
            this.lastNameComboBox = new System.Windows.Forms.ComboBox();
            studentIDLabel = new System.Windows.Forms.Label();
            lastNameLabel = new System.Windows.Forms.Label();
            firstNameLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            cityLabel = new System.Windows.Forms.Label();
            stateCodeLabel = new System.Windows.Forms.Label();
            zipCodeLabel = new System.Windows.Forms.Label();
            telephoneNumberLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            amountOwedLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cSharpUniversityDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingNavigator)).BeginInit();
            this.studentsBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // studentIDLabel
            // 
            studentIDLabel.AutoSize = true;
            studentIDLabel.Location = new System.Drawing.Point(13, 46);
            studentIDLabel.Name = "studentIDLabel";
            studentIDLabel.Size = new System.Drawing.Size(61, 13);
            studentIDLabel.TabIndex = 1;
            studentIDLabel.Text = "Student ID:";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new System.Drawing.Point(13, 81);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(61, 13);
            lastNameLabel.TabIndex = 3;
            lastNameLabel.Text = "Last Name:";
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new System.Drawing.Point(258, 79);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(60, 13);
            firstNameLabel.TabIndex = 5;
            firstNameLabel.Text = "First Name:";
            firstNameLabel.Click += new System.EventHandler(this.firstNameLabel_Click);
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(13, 107);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(48, 13);
            addressLabel.TabIndex = 7;
            addressLabel.Text = "Address:";
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Location = new System.Drawing.Point(13, 133);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new System.Drawing.Size(27, 13);
            cityLabel.TabIndex = 9;
            cityLabel.Text = "City:";
            // 
            // stateCodeLabel
            // 
            stateCodeLabel.AutoSize = true;
            stateCodeLabel.Location = new System.Drawing.Point(236, 137);
            stateCodeLabel.Name = "stateCodeLabel";
            stateCodeLabel.Size = new System.Drawing.Size(35, 13);
            stateCodeLabel.TabIndex = 11;
            stateCodeLabel.Text = "State:";
            stateCodeLabel.Click += new System.EventHandler(this.stateCodeLabel_Click);
            // 
            // zipCodeLabel
            // 
            zipCodeLabel.AutoSize = true;
            zipCodeLabel.Location = new System.Drawing.Point(13, 168);
            zipCodeLabel.Name = "zipCodeLabel";
            zipCodeLabel.Size = new System.Drawing.Size(53, 13);
            zipCodeLabel.TabIndex = 13;
            zipCodeLabel.Text = "Zip Code:";
            // 
            // telephoneNumberLabel
            // 
            telephoneNumberLabel.AutoSize = true;
            telephoneNumberLabel.Location = new System.Drawing.Point(226, 168);
            telephoneNumberLabel.Name = "telephoneNumberLabel";
            telephoneNumberLabel.Size = new System.Drawing.Size(101, 13);
            telephoneNumberLabel.TabIndex = 15;
            telephoneNumberLabel.Text = "Telephone Number:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(13, 206);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(35, 13);
            emailLabel.TabIndex = 17;
            emailLabel.Text = "Email:";
            // 
            // amountOwedLabel
            // 
            amountOwedLabel.AutoSize = true;
            amountOwedLabel.Location = new System.Drawing.Point(13, 232);
            amountOwedLabel.Name = "amountOwedLabel";
            amountOwedLabel.Size = new System.Drawing.Size(77, 13);
            amountOwedLabel.TabIndex = 19;
            amountOwedLabel.Text = "Amount Owed:";
            // 
            // cSharpUniversityDataSet
            // 
            this.cSharpUniversityDataSet.DataSetName = "CSharpUniversityDataSet";
            this.cSharpUniversityDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentsBindingSource
            // 
            this.studentsBindingSource.DataMember = "Students";
            this.studentsBindingSource.DataSource = this.cSharpUniversityDataSet;
            // 
            // studentsTableAdapter
            // 
            this.studentsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ProductsTableAdapter = null;
            this.tableAdapterManager.StudentsTableAdapter = this.studentsTableAdapter;
            this.tableAdapterManager.UpdateOrder = Lab18_19_200_Skelly_Daniel.CSharpUniversityDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // studentsBindingNavigator
            // 
            this.studentsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.studentsBindingNavigator.BindingSource = this.studentsBindingSource;
            this.studentsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.studentsBindingNavigator.DeleteItem = null;
            this.studentsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.cancelEditToolStrip,
            this.editToolStrip});
            this.studentsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.studentsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.studentsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.studentsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.studentsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.studentsBindingNavigator.Name = "studentsBindingNavigator";
            this.studentsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.studentsBindingNavigator.Size = new System.Drawing.Size(457, 25);
            this.studentsBindingNavigator.TabIndex = 0;
            this.studentsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
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
            // cancelEditToolStrip
            // 
            this.cancelEditToolStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.cancelEditToolStrip.Image = ((System.Drawing.Image)(resources.GetObject("cancelEditToolStrip.Image")));
            this.cancelEditToolStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cancelEditToolStrip.Name = "cancelEditToolStrip";
            this.cancelEditToolStrip.Size = new System.Drawing.Size(47, 22);
            this.cancelEditToolStrip.Text = "Cancel";
            this.cancelEditToolStrip.Click += new System.EventHandler(this.cancelEditToolStrip_Click);
            // 
            // editToolStrip
            // 
            this.editToolStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.editToolStrip.Image = ((System.Drawing.Image)(resources.GetObject("editToolStrip.Image")));
            this.editToolStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.editToolStrip.Name = "editToolStrip";
            this.editToolStrip.Size = new System.Drawing.Size(31, 22);
            this.editToolStrip.Text = "Edit";
            // 
            // studentIDTextBox
            // 
            this.studentIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentsBindingSource, "StudentID", true));
            this.studentIDTextBox.Location = new System.Drawing.Point(120, 43);
            this.studentIDTextBox.Name = "studentIDTextBox";
            this.studentIDTextBox.ReadOnly = true;
            this.studentIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.studentIDTextBox.TabIndex = 2;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentsBindingSource, "LastName", true));
            this.lastNameTextBox.Location = new System.Drawing.Point(120, 78);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.ReadOnly = true;
            this.lastNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.lastNameTextBox.TabIndex = 4;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentsBindingSource, "FirstName", true));
            this.firstNameTextBox.Location = new System.Drawing.Point(333, 75);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.ReadOnly = true;
            this.firstNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.firstNameTextBox.TabIndex = 6;
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentsBindingSource, "Address", true));
            this.addressTextBox.Location = new System.Drawing.Point(120, 104);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.ReadOnly = true;
            this.addressTextBox.Size = new System.Drawing.Size(191, 20);
            this.addressTextBox.TabIndex = 8;
            // 
            // cityTextBox
            // 
            this.cityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentsBindingSource, "City", true));
            this.cityTextBox.Location = new System.Drawing.Point(120, 130);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.ReadOnly = true;
            this.cityTextBox.Size = new System.Drawing.Size(100, 20);
            this.cityTextBox.TabIndex = 10;
            // 
            // stateCodeTextBox
            // 
            this.stateCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentsBindingSource, "StateCode", true));
            this.stateCodeTextBox.Location = new System.Drawing.Point(277, 133);
            this.stateCodeTextBox.Name = "stateCodeTextBox";
            this.stateCodeTextBox.ReadOnly = true;
            this.stateCodeTextBox.Size = new System.Drawing.Size(49, 20);
            this.stateCodeTextBox.TabIndex = 12;
            this.stateCodeTextBox.TextChanged += new System.EventHandler(this.stateCodeTextBox_TextChanged);
            // 
            // zipCodeTextBox
            // 
            this.zipCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentsBindingSource, "ZipCode", true));
            this.zipCodeTextBox.Location = new System.Drawing.Point(120, 165);
            this.zipCodeTextBox.Name = "zipCodeTextBox";
            this.zipCodeTextBox.ReadOnly = true;
            this.zipCodeTextBox.Size = new System.Drawing.Size(100, 20);
            this.zipCodeTextBox.TabIndex = 14;
            // 
            // telephoneNumberTextBox
            // 
            this.telephoneNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentsBindingSource, "TelephoneNumber", true));
            this.telephoneNumberTextBox.Location = new System.Drawing.Point(333, 165);
            this.telephoneNumberTextBox.Name = "telephoneNumberTextBox";
            this.telephoneNumberTextBox.ReadOnly = true;
            this.telephoneNumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.telephoneNumberTextBox.TabIndex = 16;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentsBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(120, 203);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.ReadOnly = true;
            this.emailTextBox.Size = new System.Drawing.Size(162, 20);
            this.emailTextBox.TabIndex = 18;
            // 
            // amountOwedTextBox
            // 
            this.amountOwedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentsBindingSource, "AmountOwed", true));
            this.amountOwedTextBox.Location = new System.Drawing.Point(120, 229);
            this.amountOwedTextBox.Name = "amountOwedTextBox";
            this.amountOwedTextBox.ReadOnly = true;
            this.amountOwedTextBox.Size = new System.Drawing.Size(100, 20);
            this.amountOwedTextBox.TabIndex = 20;
            // 
            // lastNameComboBox
            // 
            this.lastNameComboBox.DataSource = this.studentsBindingSource;
            this.lastNameComboBox.DisplayMember = "LastName";
            this.lastNameComboBox.FormattingEnabled = true;
            this.lastNameComboBox.Location = new System.Drawing.Point(251, 42);
            this.lastNameComboBox.Name = "lastNameComboBox";
            this.lastNameComboBox.Size = new System.Drawing.Size(121, 21);
            this.lastNameComboBox.TabIndex = 21;
            this.lastNameComboBox.ValueMember = "StudentID";
            // 
            // Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 268);
            this.Controls.Add(this.lastNameComboBox);
            this.Controls.Add(studentIDLabel);
            this.Controls.Add(this.studentIDTextBox);
            this.Controls.Add(lastNameLabel);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(firstNameLabel);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(addressLabel);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(cityLabel);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(stateCodeLabel);
            this.Controls.Add(this.stateCodeTextBox);
            this.Controls.Add(zipCodeLabel);
            this.Controls.Add(this.zipCodeTextBox);
            this.Controls.Add(telephoneNumberLabel);
            this.Controls.Add(this.telephoneNumberTextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(amountOwedLabel);
            this.Controls.Add(this.amountOwedTextBox);
            this.Controls.Add(this.studentsBindingNavigator);
            this.Name = "Student";
            this.Text = "Student";
            this.Load += new System.EventHandler(this.Student_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cSharpUniversityDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingNavigator)).EndInit();
            this.studentsBindingNavigator.ResumeLayout(false);
            this.studentsBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CSharpUniversityDataSet cSharpUniversityDataSet;
        private System.Windows.Forms.BindingSource studentsBindingSource;
        private CSharpUniversityDataSetTableAdapters.StudentsTableAdapter studentsTableAdapter;
        private CSharpUniversityDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator studentsBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.TextBox studentIDTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox stateCodeTextBox;
        private System.Windows.Forms.TextBox zipCodeTextBox;
        private System.Windows.Forms.TextBox telephoneNumberTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox amountOwedTextBox;
        private System.Windows.Forms.ToolStripButton cancelEditToolStrip;
        private System.Windows.Forms.ToolStripButton editToolStrip;
        private System.Windows.Forms.ComboBox lastNameComboBox;
    }
}