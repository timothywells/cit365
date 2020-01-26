using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Wells
{
    public partial class AddQuote : Form
    {
        public AddQuote()
        {
            InitializeComponent();
            var materials = new List<Surface>();
            materials = Enum.GetValues(typeof(Surface)).Cast<Surface>().ToList();
        }


        private void comboBoxDW_Validating(object sender, EventArgs e)
        {
            //if (comboBoxDW.SelectedValue < 24 || comboBoxDW.SelectedValue > 96)
            {
               // MessageBox.Show("Please enter a number between 24 to 96", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGetQuote_Click(object sender, EventArgs e)
        {
            //Temp Navigation Test
            var displayQuote = new DisplayQuote();
            displayQuote.Tag = this;
            displayQuote.Show();
            this.Hide();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            MainMenu viewMainMenu = (MainMenu)Tag;
            viewMainMenu.Show();
            Close();
        }

        private void comboBoxSurface_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxDW_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (double.TryParse(comboBoxDW, out double value))
            {
                if (value < 24 || value > 96) ;
            }

        }
    }
}
