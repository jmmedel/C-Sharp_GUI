namespace Gaddis_11_01_PersonnelDatabase
{
  partial class frmPersonnel
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPersonnel));
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
      this.employeeDataGridView = new System.Windows.Forms.DataGridView();
      this.btnDetails = new System.Windows.Forms.Button();
      this.btnSortPayDesc = new System.Windows.Forms.Button();
      this.btnSortPayAsc = new System.Windows.Forms.Button();
      this.btnSearch = new System.Windows.Forms.Button();
      this.btnHighestPayRate = new System.Windows.Forms.Button();
      this.btnLowestPayRate = new System.Windows.Forms.Button();
      this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.personnelDataSet = new Gaddis_11_01_PersonnelDatabase.PersonnelDataSet();
      this.employeeTableAdapter = new Gaddis_11_01_PersonnelDatabase.PersonnelDataSetTableAdapters.EmployeeTableAdapter();
      this.tableAdapterManager = new Gaddis_11_01_PersonnelDatabase.PersonnelDataSetTableAdapters.TableAdapterManager();
      ((System.ComponentModel.ISupportInitialize)(this.employeeBindingNavigator)).BeginInit();
      this.employeeBindingNavigator.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.employeeDataGridView)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.personnelDataSet)).BeginInit();
      this.SuspendLayout();
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
      this.employeeBindingNavigator.Size = new System.Drawing.Size(540, 25);
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
      this.employeeDataGridView.Location = new System.Drawing.Point(12, 28);
      this.employeeDataGridView.Name = "employeeDataGridView";
      this.employeeDataGridView.Size = new System.Drawing.Size(481, 220);
      this.employeeDataGridView.TabIndex = 1;
      // 
      // btnDetails
      // 
      this.btnDetails.Location = new System.Drawing.Point(418, 262);
      this.btnDetails.Name = "btnDetails";
      this.btnDetails.Size = new System.Drawing.Size(75, 37);
      this.btnDetails.TabIndex = 3;
      this.btnDetails.Text = "Show Details";
      this.btnDetails.UseVisualStyleBackColor = true;
      this.btnDetails.Click += new System.EventHandler(this.btnDetails_Click);
      // 
      // btnSortPayDesc
      // 
      this.btnSortPayDesc.Location = new System.Drawing.Point(337, 262);
      this.btnSortPayDesc.Name = "btnSortPayDesc";
      this.btnSortPayDesc.Size = new System.Drawing.Size(75, 37);
      this.btnSortPayDesc.TabIndex = 6;
      this.btnSortPayDesc.Text = "Sort By Pay Rate Desc";
      this.btnSortPayDesc.UseVisualStyleBackColor = true;
      this.btnSortPayDesc.Click += new System.EventHandler(this.btnSortPayDesc_Click);
      // 
      // btnSortPayAsc
      // 
      this.btnSortPayAsc.Location = new System.Drawing.Point(256, 262);
      this.btnSortPayAsc.Name = "btnSortPayAsc";
      this.btnSortPayAsc.Size = new System.Drawing.Size(75, 37);
      this.btnSortPayAsc.TabIndex = 5;
      this.btnSortPayAsc.Text = "Sort By Pay Rate Asc";
      this.btnSortPayAsc.UseVisualStyleBackColor = true;
      this.btnSortPayAsc.Click += new System.EventHandler(this.btnSortPayAsc_Click);
      // 
      // btnSearch
      // 
      this.btnSearch.Location = new System.Drawing.Point(175, 262);
      this.btnSearch.Name = "btnSearch";
      this.btnSearch.Size = new System.Drawing.Size(75, 37);
      this.btnSearch.TabIndex = 7;
      this.btnSearch.Text = "Search";
      this.btnSearch.UseVisualStyleBackColor = true;
      this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
      // 
      // btnHighestPayRate
      // 
      this.btnHighestPayRate.Location = new System.Drawing.Point(12, 262);
      this.btnHighestPayRate.Name = "btnHighestPayRate";
      this.btnHighestPayRate.Size = new System.Drawing.Size(75, 37);
      this.btnHighestPayRate.TabIndex = 9;
      this.btnHighestPayRate.Text = "Highest Pay Rate";
      this.btnHighestPayRate.UseVisualStyleBackColor = true;
      this.btnHighestPayRate.Click += new System.EventHandler(this.btnHighestPayRate_Click);
      // 
      // btnLowestPayRate
      // 
      this.btnLowestPayRate.Location = new System.Drawing.Point(94, 262);
      this.btnLowestPayRate.Name = "btnLowestPayRate";
      this.btnLowestPayRate.Size = new System.Drawing.Size(75, 37);
      this.btnLowestPayRate.TabIndex = 8;
      this.btnLowestPayRate.Text = "Lowest Pay Rate";
      this.btnLowestPayRate.UseVisualStyleBackColor = true;
      this.btnLowestPayRate.Click += new System.EventHandler(this.btnLowestPayRate_Click);
      // 
      // dataGridViewTextBoxColumn1
      // 
      this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
      this.dataGridViewTextBoxColumn1.HeaderText = "Id";
      this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
      // 
      // dataGridViewTextBoxColumn2
      // 
      this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
      this.dataGridViewTextBoxColumn2.HeaderText = "Name";
      this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
      // 
      // dataGridViewTextBoxColumn3
      // 
      this.dataGridViewTextBoxColumn3.DataPropertyName = "Position";
      this.dataGridViewTextBoxColumn3.HeaderText = "Position";
      this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
      // 
      // dataGridViewTextBoxColumn4
      // 
      this.dataGridViewTextBoxColumn4.DataPropertyName = "HourlyPay";
      this.dataGridViewTextBoxColumn4.HeaderText = "HourlyPay";
      this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
      // 
      // employeeBindingSource
      // 
      this.employeeBindingSource.DataMember = "Employee";
      this.employeeBindingSource.DataSource = this.personnelDataSet;
      // 
      // personnelDataSet
      // 
      this.personnelDataSet.DataSetName = "PersonnelDataSet";
      this.personnelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
      // frmPersonnel
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(540, 311);
      this.Controls.Add(this.btnHighestPayRate);
      this.Controls.Add(this.btnLowestPayRate);
      this.Controls.Add(this.btnSearch);
      this.Controls.Add(this.btnSortPayDesc);
      this.Controls.Add(this.btnSortPayAsc);
      this.Controls.Add(this.btnDetails);
      this.Controls.Add(this.employeeDataGridView);
      this.Controls.Add(this.employeeBindingNavigator);
      this.Name = "frmPersonnel";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Personnel Database";
      this.Load += new System.EventHandler(this.frmPersonnel_Load);
      ((System.ComponentModel.ISupportInitialize)(this.employeeBindingNavigator)).EndInit();
      this.employeeBindingNavigator.ResumeLayout(false);
      this.employeeBindingNavigator.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.employeeDataGridView)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.personnelDataSet)).EndInit();
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
    private System.Windows.Forms.DataGridView employeeDataGridView;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    private System.Windows.Forms.Button btnDetails;
    private System.Windows.Forms.Button btnSortPayDesc;
    private System.Windows.Forms.Button btnSortPayAsc;
    private System.Windows.Forms.Button btnSearch;
    private System.Windows.Forms.Button btnHighestPayRate;
    private System.Windows.Forms.Button btnLowestPayRate;
  }
}

