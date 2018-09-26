using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gaddis_09_07_EmailAddressBook
{
  public partial class frmDisplayData : Form
  {
    public frmDisplayData()
    {
      InitializeComponent();
    }

    private void frmDisplayData_Load(object sender, EventArgs e)
    {
      int selectedPerson = frmInputData.selectedPerson;
      //lstOutput.Items.Add(frmInputData.persons[selectedPerson]);
      string[] splitData = frmInputData.persons[selectedPerson].ToString().Split('\n');
      foreach(string s in splitData)
      {
        lstOutput.Items.Add(s);
      }
    }

    private void btnReturn_Click(object sender, EventArgs e)
    {
      this.Close();
    }
  }
}
