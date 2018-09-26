using System;
using System.Windows.Forms;

namespace Gaddis_09_02_CarClass
{
  public partial class InputForm : Form
  {
    public InputForm()
    {
      InitializeComponent();
    }

    public Car car;
    private void btnSubmit_Click(object sender, EventArgs e)
    {
      string make = txtMake.Text;
      int year;

      if (!string.IsNullOrWhiteSpace(make) && int.TryParse(txtYear.Text, out year))
      {
        car = new Car(make, year);
        this.Close();
      }
      else
        MessageBox.Show("Please enter valid input", "Invalid input");
    }
  }
}
