namespace Gaddis_11_01_PersonnelDatabase
{
  partial class Details
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
      System.Windows.Forms.Label idLabel;
      System.Windows.Forms.Label nameLabel;
      System.Windows.Forms.Label positionLabel;
      System.Windows.Forms.Label hourlyPayLabel;
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Details));
      this.personnelDataSet = new Gaddis_11_01_PersonnelDatabase.PersonnelDataSet();
      this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.employeeTableAdapter = new Gaddis_11_01_PersonnelDatabase.PersonnelDataSetTableAdapters.EmployeeTableAdapter();
      this.tableAdapterManager = new Gaddis_11_01_PersonnelDatabase.PersonnelDataSetTableAdapters.TableAdapterManager();
      this.employeeBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
      this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
      this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
      this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
      this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
      this.employeeBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
      this.idTextBox = new System.Windows.Forms.TextBox();
      this.nameTextBox = new System.Windows.Forms.TextBox();
      this.positionTextBox = new System.Windows.Forms.TextBox();
      this.hourlyPayTextBox = new System.Windows.Forms.TextBox();
      idLabel = new System.Windows.Forms.Label();
      nameLabel = new System.Windows.Forms.Label();
      positionLabel = new System.Windows.Forms.Label();
      hourlyPayLabel = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.personnelDataSet)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.employeeBindingNavigator)).BeginInit();
      this.employeeBindingNavigator.SuspendLayout();
      this.SuspendLayout();
      // 
      // idLabel
      // 
      idLabel.AutoSize = true;
      idLabel.Location = new System.Drawing.Point(89, 81);
      idLabel.Name = "idLabel";
      idLabel.Size = new System.Drawing.Size(19, 13);
      idLabel.TabIndex = 1;
      idLabel.Text = "Id:";
      // 
      // nameLabel
      // 
      nameLabel.AutoSize = true;
      nameLabel.Location = new System.Drawing.Point(89, 107);
      nameLabel.Name = "nameLabel";
      nameLabel.Size = new System.Drawing.Size(38, 13);
      nameLabel.TabIndex = 3;
      nameLabel.Text = "Name:";
      // 
      // positionLabel
      // 
      positionLabel.AutoSize = true;
      positionLabel.Location = new System.Drawing.Point(89, 133);
      positionLabel.Name = "positionLabel";
      positionLabel.Size = new System.Drawing.Size(47, 13);
      positionLabel.TabIndex = 5;
      positionLabel.Text = "Position:";
      // 
      // hourlyPayLabel
      // 
      hourlyPayLabel.AutoSize = true;
      hourlyPayLabel.Location = new System.Drawing.Point(89, 159);
      hourlyPayLabel.Name = "hourlyPayLabel";
      hourlyPayLabel.Size = new System.Drawing.Size(61, 13);
      hourlyPayLabel.TabIndex = 7;
      hourlyPayLabel.Text = "Hourly Pay:";
      // 
      // personnelDataSet
      // 
      this.personnelDataSet.DataSetName = "PersonnelDataSet";
      this.personnelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
      // 
      // employeeBindingSource
      // 
      this.employeeBindingSource.DataMember = "Employee";
      this.employeeBindingSource.DataSource = this.personnelDataSet;
      // 
      // employeeTableAdapter
      // 
      this.employeeTableAdapter.ClearBeforeFill = true;
      // 
      // tableAdapterManager
      // 
      this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
      this.tableAdapterManager.EmployeeTableAdapter = this.employeeTableAdapter;
      this.tableAdapterManager.UpdateOrder = Gaddis_11_01_PersonnelDatabase.PersonnelDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
      // 
      // employeeBindingNavigator
      // 
      this.employeeBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
      this.employeeBindingNavigator.BindingSource = this.employeeBindingSource;
      this.employeeBindingNavigator.CountItem = this.bindingNavigatorCountItem;
      this.employeeBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
      this.employeeBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bindingNavigatorDeleteItem,
            this.employeeBindingNavigatorSaveItem});
      this.employeeBindingNavigator.Location = new System.Drawing.Point(0, 0);
      this.employeeBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
      this.employeeBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
      this.employeeBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
      this.employeeBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
      this.employeeBindingNavigator.Name = "employeeBindingNavigator";
      this.employeeBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
      this.employeeBindingNavigator.Size = new System.Drawing.Size(344, 25);
      this.employeeBindingNavigator.TabIndex = 0;
      this.employeeBindingNavigator.Text = "bindingNavigator1";
      // 
      // bindingNavigatorAddNewItem
      // 
      this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
      this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
      this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
      this.bindingNavigatorAddNewItem.Text = "Add new";
      // 
      // bindingNavigatorCountItem
      // 
      this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
      this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
      this.bindingNavigatorCountItem.Text = "of {0}";
      this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
      // 
      // bindingNavigatorDeleteItem
      // 
      this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
      this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
      this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
      this.bindingNavigatorDeleteItem.Text = "Delete";
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
      // employeeBindingNavigatorSaveItem
      // 
      this.employeeBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.employeeBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("employeeBindingNavigatorSaveItem.Image")));
      this.employeeBindingNavigatorSaveItem.Name = "employeeBindingNavigatorSaveItem";
      this.employeeBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
      this.employeeBindingNavigatorSaveItem.Text = "Save Data";
      this.employeeBindingNavigatorSaveItem.Click += new System.EventHandler(this.employeeBindingNavigatorSaveItem_Click);
      // 
      // idTextBox
      // 
      this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "Id", true));
      this.idTextBox.Location = new System.Drawing.Point(156, 78);
      this.idTextBox.Name = "idTextBox";
      this.idTextBox.Size = new System.Drawing.Size(100, 20);
      this.idTextBox.TabIndex = 2;
      // 
      // nameTextBox
      // 
      this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "Name", true));
      this.nameTextBox.Location = new System.Drawing.Point(156, 104);
      this.nameTextBox.Name = "nameTextBox";
      this.nameTextBox.Size = new System.Drawing.Size(100, 20);
      this.nameTextBox.TabIndex = 4;
      // 
      // positionTextBox
      // 
      this.positionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "Position", true));
      this.positionTextBox.Location = new System.Drawing.Point(156, 130);
      this.positionTextBox.Name = "positionTextBox";
      this.positionTextBox.Size = new System.Drawing.Size(100, 20);
      this.positionTextBox.TabIndex = 6;
      // 
      // hourlyPayTextBox
      // 
      this.hourlyPayTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "HourlyPay", true));
      this.hourlyPayTextBox.Location = new System.Drawing.Point(156, 156);
      this.hourlyPayTextBox.Name = "hourlyPayTextBox";
      this.hourlyPayTextBox.Size = new System.Drawing.Size(100, 20);
      this.hourlyPayTextBox.TabIndex = 8;
      // 
      // Details
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(344, 261);
      this.Controls.Add(idLabel);
      this.Controls.Add(this.idTextBox);
      this.Controls.Add(nameLabel);
      this.Controls.Add(this.nameTextBox);
      this.Controls.Add(positionLabel);
      this.Controls.Add(this.positionTextBox);
      this.Controls.Add(hourlyPayLabel);
      this.Controls.Add(this.hourlyPayTextBox);
      this.Controls.Add(this.employeeBindingNavigator);
      this.Name = "Details";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Details";
      this.Load += new System.EventHandler(this.Details_Load);
      ((System.ComponentModel.ISupportInitialize)(this.personnelDataSet)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.employeeBindingNavigator)).EndInit();
      this.employeeBindingNavigator.ResumeLayout(false);
      this.employeeBindingNavigator.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private PersonnelDataSet personnelDataSet;
    private System.Windows.Forms.BindingSource employeeBindingSource;
    private PersonnelDataSetTableAdapters.EmployeeTableAdapter employeeTableAdapter;
    private PersonnelDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    private System.Windows.Forms.BindingNavigator employeeBindingNavigator;
    private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
    private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
    private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
    private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
    private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
    private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
    private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
    private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
    private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
    private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
    private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
    private System.Windows.Forms.ToolStripButton employeeBindingNavigatorSaveItem;
    private System.Windows.Forms.TextBox idTextBox;
    private System.Windows.Forms.TextBox nameTextBox;
    private System.Windows.Forms.TextBox positionTextBox;
    private System.Windows.Forms.TextBox hourlyPayTextBox;
  }
}