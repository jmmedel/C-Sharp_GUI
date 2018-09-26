/*
Employee Search Create an application that connects to the Personnel.mdf database that you created in Programming Problem 1. The application’s form should display the Employee table in a DataGridView control. The application should let the user specify a name in a text box and then search for that name in the Employee table. The application should display any rows that contain a full or partial match of the specified name. 
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gaddis_11_01_PersonnelDatabase
{
  public partial class frmPersonnel : Form
  {
    public frmPersonnel()
    {
      InitializeComponent();
    }

    private void frmPersonnel_Load(object sender, EventArgs e)
    {
      // TODO: This line of code loads data into the 'personnelDataSet.Employee' table. You can move, or remove it, as needed.
      this.employeeTableAdapter.Fill(this.personnelDataSet.Employee);

    }

    private void employeeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
    {
      this.Validate();
      this.employeeBindingSource.EndEdit();
      this.tableAdapterManager.UpdateAll(this.personnelDataSet);

    }

    private void btnDetails_Click(object sender, EventArgs e)
    {
      Details detailsForm = new Details();
      detailsForm.ShowDialog();
      employeeTableAdapter.Fill(personnelDataSet.Employee);
    }

    private void btnSortPayAsc_Click(object sender, EventArgs e)
    {
      employeeTableAdapter.FillByHourlyPayAsc(personnelDataSet.Employee);
    }

    private void btnSortPayDesc_Click(object sender, EventArgs e)
    {
      employeeTableAdapter.FillByHourlyPayDesc(personnelDataSet.Employee);
    }

    private void btnSearch_Click(object sender, EventArgs e)
    {
      SearchForm searchForm = new SearchForm();
      searchForm.ShowDialog();
    }
  }
}
