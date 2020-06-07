using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KittyServices
{
    public partial class frmMain : Form
    {
        public int kitty_count = -1;
        public String service_title = "";
        public double service_value = -1;
        public String spa_Treatments_title = "";
        public double spa_Treatments_value = -1;
        private double[] spa_treatment_value = { 22.75, 80.00, 33.75, 0 };
        private double[] service_listview_value = { 10.00, 25.00, 35.75, 15.00 };
        public frmMain()
        {
            InitializeComponent();
        }
        private void onKittyNumberComboItemSelected(object sender, EventArgs e)
        {
            if (kitty_number_combo.SelectedIndex != -1)
            {
                lblOne.Text = kitty_number_combo.SelectedItem.ToString() + " kitties";
                lblOne.Visible = true;
                kitty_count = (int)kitty_number_combo.SelectedItem;
            }
            if (kitty_count != -1 && !service_title.Equals("") && !spa_Treatments_title.Equals("") && name_textbox.Text.Length != 0)
                calculate();
        }
        private void onServiceListItemClicked(object sender, EventArgs e)
        {
            if (service_listview.SelectedIndex != -1)
            {
                service_title = service_listview.SelectedItem.ToString();
                service_value = service_listview_value[service_listview.SelectedIndex];
                lblTwo.Text = service_listview.SelectedItem.ToString();
                lblTwo.Visible = true;
            }
            if (kitty_count != -1 && !service_title.Equals("") && !spa_Treatments_title.Equals("") && name_textbox.Text.Length != 0)
                calculate();
        }
        private void onSpaTreatmentsComboItemSelected(object sender, EventArgs e)
        {
            if (spa_treatments_combo.SelectedIndex != -1)
            {
                spa_Treatments_title = spa_treatments_combo.SelectedItem.ToString();
                spa_Treatments_value = spa_treatment_value[spa_treatments_combo.SelectedIndex];
                lblThree.Text = spa_treatments_combo.SelectedItem.ToString();
                lblThree.Visible = true;
            }
            if (kitty_count != -1 && !service_title.Equals("") && !spa_Treatments_title.Equals("") && name_textbox.Text.Length != 0)
                calculate();
        }

        private void trim_radio_CheckedChanged(object sender, EventArgs e)
        {
            lblFour.Text = trim_radio.Text;
            lblFour.Visible = true;
        }

        private void shave_radio_CheckedChanged(object sender, EventArgs e)
        {
            lblFour.Text = shave_radio.Text;
            lblFour.Visible = true;
        }

        private void spa_bath_check_CheckedChanged(object sender, EventArgs e)
        {
            if (spa_bath_check.Checked == true)
            {
                lblFive.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                lblFive.Text = spa_bath_check.Text;
                lblFive.Visible = true;
            }
            else
            {
                lblFive.Text = "";
                lblFive.Visible = false;
            }
            
        }

        private void comb_out_check_CheckedChanged(object sender, EventArgs e)
        {
            if (comb_out_check.Checked == true)
            {
                lblSix.Text = comb_out_check.Text;
                lblSix.Visible = true;
            }
            else
            {
                lblSix.Text = "";
                lblSix.Visible = false;
            }
        }

        private void nail_service_check_CheckedChanged(object sender, EventArgs e)
        {
            if (nail_service_check.Checked == true)
            {
                lblSeven.Text = nail_service_check.Text;
                lblSeven.Visible = true;
            } 
            else
            {
                lblSeven.Text = "";
                lblSeven.Visible = false;
            }
        }

        private void calculateOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (kitty_count == -1 || service_title.Equals("") || spa_Treatments_title.Equals("") || name_textbox.Text.Length == 0)
                MessageBox.Show("Please input all information");
            else
                calculate();
        }

        private void calculate()
        {
            string newLine = Environment.NewLine;
            total_textbox.Text = kitty_count + " kitties" + newLine;
            total_textbox.Text += service_title + newLine;
            total_textbox.Text += spa_Treatments_title + newLine;
            total_textbox.Text += "Total = $" + (service_value + spa_Treatments_value) * kitty_count;
        }

        private void clearFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kitty_count = -1;
            service_title = "";
            service_value = -1;
            spa_Treatments_title = "";
            spa_Treatments_value = -1;

            name_textbox.Text = "";
            total_textbox.Text = "";

            kitty_number_combo.SelectedIndex = -1;
            service_listview.SelectedIndex = -1;
            spa_treatments_combo.SelectedIndex = -1;
            trim_radio.Checked = false;
            shave_radio.Checked = false;
            spa_bath_check.Checked = false;
            comb_out_check.Checked = false;
            nail_service_check.Checked = false;

            lblOne.Visible = false;
            lblTwo.Visible = false;
            lblThree.Visible = false;
            lblFour.Visible = false;
            lblFive.Visible = false;
            lblSix.Visible = false;
            lblSeven.Visible = false;
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog dlg = new FontDialog();

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                title_tab1.Font = dlg.Font;
                title_tab2.Font = dlg.Font;
            }
        }

        private void colorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                title_tab1.ForeColor = dlg.Color;
                title_tab2.ForeColor = dlg.Color;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void contactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kitty's Service Application\n\n\nVersion 1", "About Kitty's Service", MessageBoxButtons.OK);
        }
    }
}
