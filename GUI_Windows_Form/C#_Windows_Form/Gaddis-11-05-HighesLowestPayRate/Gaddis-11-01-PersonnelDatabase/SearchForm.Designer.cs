namespace Gaddis_11_01_PersonnelDatabase
{
  partial class SearchForm
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchForm));
      this.btnSearchName = new System.Windows.Forms.Button();
      this.txtSearchName = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.personnelDataSet = new Gaddis_11_01_PersonnelDatabase.PersonnelDataSet();
      this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.employeeTableAdapter = new Gaddis_11_01_PersonnelDatabase.PersonnelDataSetTableAdapters.EmployeeTableAdapter();
      this.tableAdapterManager = new Gaddis_11_01_PersonnelDatabase.PersonnelDataSetTableAdapters.TableAdapterManager();
      this.employeeBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
      this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
      this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
      this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
      this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
      this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
      this.employeeBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
      this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.employeeDataGridView = new System.Windows.Forms.DataGridView();
      ((System.ComponentModel.ISupportInitialize)(this.personnelDataSet)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.employeeBindingNavigator)).BeginInit();
      this.employeeBindingNavigator.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.employeeDataGridView)).BeginInit();
      this.SuspendLayout();
      // 
      // btnSearchName
      // 
      this.btnSearchName.Location = new System.Drawing.Point(126, 50);
      this.btnSearchName.Name = "btnSearchName";
      this.btnSearchName.Size = new System.Drawing.Size(100, 23);
      this.btnSearchName.TabIndex = 5;
      this.btnSearchName.Text = "Search Name";
      this.btnSearchName.UseVisualStyleBackColor = true;
      this.btnSearchName.Click += new System.EventHandler(this.btnSearchName_Click);
      // 
      // txtSearchName
      // 
      this.txtSearchName.Location = new System.Drawing.Point(126, 12);
      this.txtSearchName.Name = "txtSearchName";
      this.txtSearchName.Size = new System.Drawing.Size(100, 20);
      this.txtSearchName.TabIndex = 4;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(22, 15);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(72, 13);
      this.label1.TabIndex = 3;
      this.label1.Text = "Search Name";
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
      this.employeeBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
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
      this.employeeBindingNavigator.Location = new System.Drawing.Point(0, 378);
      this.employeeBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
      this.employeeBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
      this.employeeBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
      this.employeeBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
      this.employeeBindingNavigator.Name = "employeeBindingNavigator";
      this.employeeBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
      this.employeeBindingNavigator.Size = new System.Drawing.Size(504, 25);
      this.employeeBindingNavigator.TabIndex = 6;
      this.employeeBindingNavigator.Text = "bindingNavigator1";
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
      // bindingNavigatorCountItem
      // 
      this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
      this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
      this.bindingNavigatorCountItem.Text = "of {0}";
      this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
      // 
      // bindingNavigatorSeparator1
      // 
      this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
      this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
      // 
      // bindingNavigatorMoveNextItem
      // 
      this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
      this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
      this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
      this.bindingNavigatorMoveNextItem.Text = "Move next";
      // 
      // bindingNavigatorMoveLastItem
      // 
      this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
      this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
      this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
      this.bindingNavigatorMoveLastItem.Text = "Move last";
      // 
      // bindingNavigatorSeparator2
      // 
      this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
      this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
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
      // bindingNavigatorDeleteItem
      // 
      this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
      this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
      this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
      this.bindingNavigatorDeleteItem.Text = "Delete";
      // 
      // employeeBindingNavigatorSaveItem
      // 
      this.employeeBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.employeeBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("employeeBindingNavigatorSaveItem.Image")));
      this.employeeBindingNavigatorSaveItem.Name = "employeeBindingNavigatorSaveItem";
      this.employeeBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
      this.employeeBindingNavigatorSaveItem.Text = "Save Data";
      this.employeeBindingNavigatorSaveItem.Click += new System.EventHandler(this.employeeBindingNavigatorSaveItem_Click);
      // 
      // dataGridViewTextBoxColumn4
      // 
      this.dataGridViewTextBoxColumn4.DataPropertyName = "HourlyPay";
      this.dataGridViewTextBoxColumn4.HeaderText = "HourlyPay";
      this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
      // 
      // dataGridViewTextBoxColumn3
      // 
      this.dataGridViewTextBoxColumn3.DataPropertyName = "Position";
      this.dataGridViewTextBoxColumn3.HeaderText = "Position";
      this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
      // 
      // dataGridViewTextBoxColumn2
      // 
      this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
      this.dataGridViewTextBoxColumn2.HeaderText = "Name";
      this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
      // 
      // dataGridViewTextBoxColumn1
      // 
      this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
      this.dataGridViewTextBoxColumn1.HeaderText = "Id";
      this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
      // 
      // employeeDataGridView
      // 
      this.employeeDataGridView.AutoGenerateColumns = false;
      this.employeeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.employeeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
      this.employeeDataGridView.DataSource = this.employeeBindingSource;
      this.employeeDataGridView.Location = new System.Drawing.Point(25, 113);
      this.employeeDataGridView.Name = "employeeDataGridView";
      this.employeeDataGridView.Size = new System.Drawing.Size(454, 247);
      this.employeeDataGridView.TabIndex = 6;
      // 
      // SearchForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(504, 403);
      this.Controls.Add(this.employeeDataGridView);
      this.Controls.Add(this.employeeBindingNavigator);
      this.Controls.Add(this.btnSearchName);
      this.Controls.Add(this.txtSearchName);
      this.Controls.Add(this.label1);
      this.Name = "SearchForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Search Form";
      this.Load += new System.EventHandler(this.SearchForm_Load);
      ((System.ComponentModel.ISupportInitialize)(this.personnelDataSet)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.employeeBindingNavigator)).EndInit();
      this.employeeBindingNavigator.ResumeLayout(false);
      this.employeeBindingNavigator.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.employeeDataGridView)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnSearchName;
    private System.Windows.Forms.TextBox txtSearchName;
    private System.Windows.Forms.Label label1;
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
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    private System.Windows.Forms.DataGridView employeeDataGridView;
  }
}