/*
Population Database In the Chap11 folder of the Student Sample Programs, you will find a database file named PopulationDB.mdf.The database has a table named City. The City table has the following columns: 

Column Name          Data Type
City                nvarchar(50) Primary key
Population             float

The City column stores the name of a city and the Population column stores the population of that city.The database has 20 rows already entered.Create an application that connects to the PopulationDB.mdf database and allows the user to perform the following: 
• Use data-bound controls to add new rows to the database, change existing rows, and delete rows.
• Sort the list of cities by population, in ascending order. 
• Sort the list of cities by population, in descending order. 
• Sort the list of cities by name.
• Get the total population of all the cities. 
• Get the average population of all the cities. 
• Get the highest population. 
• Get the lowest population.
*/
using System;
using System.Windows.Forms;

namespace Gaddis_11_06_PopulationDatabase
{
  public partial class frmPopulationDatabase : Form
  {
    public frmPopulationDatabase()
    {
      InitializeComponent();
    }

    private void frmPopulationDatabase_Load(object sender, EventArgs e)
    {
      // TODO: This line of code loads data into the 'populationDataSet.Cities' table. You can move, or remove it, as needed.
      this.citiesTableAdapter.Fill(this.populationDataSet.Cities);

    }

    private void citiesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
    {
      this.Validate();
      this.citiesBindingSource.EndEdit();
      this.tableAdapterManager.UpdateAll(this.populationDataSet);

    }

    private void cmbSelectFunction_SelectedIndexChanged(object sender, EventArgs e)
    {
      switch(cmbSelectFunction.SelectedIndex)
      {
        case 0:
          citiesTableAdapter.FillByOrderPopulationAsc(populationDataSet.Cities);
          break;
        case 1:
          citiesTableAdapter.FillByOrderByPopulationDesc(populationDataSet.Cities);
          break;
        case 2:
          citiesTableAdapter.FillByOrderByCityAsc(populationDataSet.Cities);
          break;
        case 3:
          MessageBox.Show(citiesTableAdapter.PopulationSum().ToString());
          break;
        case 4:
          MessageBox.Show(citiesTableAdapter.PopulationAvg().ToString());
          break;
        case 5:
          MessageBox.Show(citiesTableAdapter.PopulationMax().ToString());
          break;
        case 6:
          MessageBox.Show(citiesTableAdapter.PopulationMin().ToString());
          break;
      }
    }
  }
}
