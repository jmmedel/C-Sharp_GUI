/*
Multiform Personnel Database Application Create an application that connects to the Personnel.mdf database that you created in Programming Problem 1. The application’s main form should display the Employee table in a DataGridView control. The main form should also have a button that, when clicked, displays a second form. The second form should display the Employee table in a Details view. Make sure that when the second form is closed, the main form refills the dataset so the most current data is displayed.
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
  }
}
