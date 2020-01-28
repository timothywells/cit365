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
            comboBoxNumDraw.DataSource = Enum.GetValues(typeof(Drawer)).Cast<Drawer>().ToList();
            comboBoxDays.DataSource = Enum.GetValues(typeof(NumDays)).Cast<NumDays>().ToList();
            comboBoxSurface.DataSource = Enum.GetValues(typeof(Surface)).Cast<Surface>().ToList();
        }

        private void btnGetQuote_Click(object sender, EventArgs e)
        {

            DisplayQuote form = new DisplayQuote();
            //form.txtNameDQ.Text = textFullName.Text;
            //form.txtOrderDate(DateTime mm dd yyyy);         
            //form.txtNameDQ(textFullName.Text);
            //form.txtDWDQ(updownDW.Text);
            //form.txtDWDQ(updownDD.Text);
            //form.txtNumDrawDQ(dropNumDraw.Text);
            //form.txtSurfMatDQ(comboBoxSurface.Text);
            //form.txtOrderSpeedDQ(comboBoxDays.Text);
           


            form.Show();
            Close();


            //Temp Navigation Test
            //var displayQuote = new DisplayQuote();
            //displayQuote.Tag = this;
            //displayQuote.Show();
            //this.Hide();
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

        private void updownDW_Validating(object sender, CancelEventArgs e)
        {
                if (updownDW.Value < Desk.MINWIDTH || updownDW.Value > Desk.MAXWIDTH)
                {
                    MessageBox.Show("Please enter a number between 24 to 96", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }   
        }

        private void keypressDDValid(object sender, KeyPressEventArgs e)
        {
            if(char.IsDigit(e.KeyChar) && char.IsControl(e.KeyChar))
            { 
                if (updownDD.Value < Desk.MINDEPTH || updownDD.Value > Desk.MAXDEPTH)
                {
                    MessageBox.Show("Please enter a number between 12 to 48", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
