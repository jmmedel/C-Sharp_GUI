/*
Personnel Database Use Visual Studio to create a database named Personnel.mdf.The database should have a table named Employee, with columns for employee ID, name, position, and hourly pay rate.The employee ID should be the primary key.Insert at least five sample rows of data into the Employee table.Create an application that displays the Employee table in a DataGridView control.
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
  }
}
