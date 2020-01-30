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
        txtFtemp.Text = RecipeCaculations.CaculateTemp(CTemp).ToString("0.00");
        txtCups.Text = RecipeCaculations.CaculateVolume(mL).ToString("0.00");

        txtCtemp.Focus();
      }
      else if (validTemp && txtmL.Text.Trim() == "") //for if only temp has data
      {
        //Set the text fields to the caculated values
        txtFtemp.Text = RecipeCaculations.CaculateTemp(CTemp).ToString("0.00");
        txtCups.Text = "";

        txtCtemp.Focus();
      }
      else if (validVolume && txtCtemp.Text.Trim() == "") //for if only volume has data
      {
        //Set the text fields to the caculated values
        txtCups.Text = RecipeCaculations.CaculateVolume(mL).ToString("0.00");
        txtFtemp.Text = "";

        txtmL.Focus();
      }
      else //for if invalid data was given.
      {
        MessageBox.Show("Please enter numbers with no units attached.");
      }
    }
  }
}
