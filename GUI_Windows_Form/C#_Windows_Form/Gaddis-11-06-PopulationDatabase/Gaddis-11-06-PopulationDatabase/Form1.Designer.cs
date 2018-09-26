namespace Gaddis_11_06_PopulationDatabase
{
  partial class frmPopulationDatabase
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPopulationDatabase));
      this.cmbSelectFunction = new System.Windows.Forms.ComboBox();
      this.citiesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
      this.citiesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
      this.citiesDataGridView = new System.Windows.Forms.DataGridView();
      this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.citiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.populationDataSet = new Gaddis_11_06_PopulationDatabase.PopulationDataSet();
      this.citiesTableAdapter = new Gaddis_11_06_PopulationDatabase.PopulationDataSetTableAdapters.CitiesTableAdapter();
      this.tableAdapterManager = new Gaddis_11_06_PopulationDatabase.PopulationDataSetTableAdapters.TableAdapterManager();
      ((System.ComponentModel.ISupportInitialize)(this.citiesBindingNavigator)).BeginInit();
      this.citiesBindingNavigator.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.citiesDataGridView)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.citiesBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.populationDataSet)).BeginInit();
      this.SuspendLayout();
      // 
      // cmbSelectFunction
      // 
      this.cmbSelectFunction.FormattingEnabled = true;
      this.cmbSelectFunction.Items.AddRange(new object[] {
            "Sort the list of cities by population, in asc order",
            "Sort the list of cities by population, in desc order",
            "Sort the list of cities by name",
            "Get the total population of all the cities",
            "Get the average population of all the cities",
            "Get the highest population.",
            "Get the lowest population"});
      this.cmbSelectFunction.Location = new System.Drawing.Point(361, 39);
      this.cmbSelectFunction.Name = "cmbSelectFunction";
      this.cmbSelectFunction.Size = new System.Drawing.Size(244, 21);
      this.cmbSelectFunction.TabIndex = 0;
      this.cmbSelectFunction.SelectedIndexChanged += new System.EventHandler(this.cmbSelectFunction_SelectedIndexChanged);
      // 
      // citiesBindingNavigator
      // 
      this.citiesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
      this.citiesBindingNavigator.BindingSource = this.citiesBindingSource;
      this.citiesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
      this.citiesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
      this.citiesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.citiesBindingNavigatorSaveItem});
      this.citiesBindingNavigator.Location = new System.Drawing.Point(0, 0);
      this.citiesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
      this.citiesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
      this.citiesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
      this.citiesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
      this.citiesBindingNavigator.Name = "citiesBindingNavigator";
      this.citiesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
      this.citiesBindingNavigator.Size = new System.Drawing.Size(659, 25);
      this.citiesBindingNavigator.TabIndex = 1;
      this.citiesBindingNavigator.Text = "bindingNavigator1";
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
      this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
      this.bindingNavigatorCountItem.Text = "of {0}";
      this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
      // 
      // bindingNavigatorSeparator1
      // 
      this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
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
      this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
      this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
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
      this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
      this.bindingNavigatorDeleteItem.Text = "Delete";
      // 
      // citiesBindingNavigatorSaveItem
      // 
      this.citiesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.citiesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("citiesBindingNavigatorSaveItem.Image")));
      this.citiesBindingNavigatorSaveItem.Name = "citiesBindingNavigatorSaveItem";
      this.citiesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
      this.citiesBindingNavigatorSaveItem.Text = "Save Data";
      this.citiesBindingNavigatorSaveItem.Click += new System.EventHandler(this.citiesBindingNavigatorSaveItem_Click);
      // 
      // citiesDataGridView
      // 
      this.citiesDataGridView.AutoGenerateColumns = false;
      this.citiesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.citiesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
      this.citiesDataGridView.DataSource = this.citiesBindingSource;
      this.citiesDataGridView.Location = new System.Drawing.Point(12, 39);
      this.citiesDataGridView.Name = "citiesDataGridView";
      this.citiesDataGridView.Size = new System.Drawing.Size(300, 279);
      this.citiesDataGridView.TabIndex = 2;
      // 
      // dataGridViewTextBoxColumn1
      // 
      this.dataGridViewTextBoxColumn1.DataPropertyName = "City";
      this.dataGridViewTextBoxColumn1.HeaderText = "City";
      this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
      // 
      // dataGridViewTextBoxColumn2
      // 
      this.dataGridViewTextBoxColumn2.DataPropertyName = "Population";
      this.dataGridViewTextBoxColumn2.HeaderText = "Population";
      this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
      // 
      // citiesBindingSource
      // 
      this.citiesBindingSource.DataMember = "Cities";
      this.citiesBindingSource.DataSource = this.populationDataSet;
      // 
      // populationDataSet
      // 
      this.populationDataSet.DataSetName = "PopulationDataSet";
      this.populationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
      // 
      // citiesTableAdapter
      // 
      this.citiesTableAdapter.ClearBeforeFill = true;
      // 
      // tableAdapterManager
      // 
      this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
      this.tableAdapterManager.CitiesTableAdapter = this.citiesTableAdapter;
      this.tableAdapterManager.UpdateOrder = Gaddis_11_06_PopulationDatabase.PopulationDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
      // 
      // frmPopulationDatabase
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(659, 330);
      this.Controls.Add(this.citiesDataGridView);
      this.Controls.Add(this.citiesBindingNavigator);
      this.Controls.Add(this.cmbSelectFunction);
      this.Name = "frmPopulationDatabase";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Population";
      this.Load += new System.EventHandler(this.frmPopulationDatabase_Load);
      ((System.ComponentModel.ISupportInitialize)(this.citiesBindingNavigator)).EndInit();
      this.citiesBindingNavigator.ResumeLayout(false);
      this.citiesBindingNavigator.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.citiesDataGridView)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.citiesBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.populationDataSet)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ComboBox cmbSelectFunction;
    private System.Windows.Forms.BindingSource citiesBindingSource;
    private PopulationDataSetTableAdapters.CitiesTableAdapter citiesTableAdapter;
    private PopulationDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    private System.Windows.Forms.BindingNavigator citiesBindingNavigator;
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
    private System.Windows.Forms.ToolStripButton citiesBindingNavigatorSaveItem;
    private System.Windows.Forms.DataGridView citiesDataGridView;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    private PopulationDataSet populationDataSet;
  }
}

