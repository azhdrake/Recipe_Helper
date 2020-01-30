using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecipeHelper
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void buttConvert_Click(object sender, EventArgs e)
    {
      //Data validation.
      bool validTemp = double.TryParse(txtCtemp.Text, out double CTemp);
      bool validVolume = double.TryParse(txtmL.Text, out double mL);

      if(validTemp && validVolume) //for if both fields have data
      {
        //Set the text fields to the caculated values
        txtFtemp.Text = RecipeCaculations.CaculateTemp(CTemp).ToString();
        txtCups.Text = RecipeCaculations.CaculateVolume(mL).ToString();

        txtCtemp.Focus();
      }
    }
  }
}
