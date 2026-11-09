using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class SAPORAS_Week05_Work04 : Form
    {
        public SAPORAS_Week05_Work04()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to close the Product Form?",
                "Confirm Exit",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBarcode.Clear();
            txtName.Clear();
            txtDescription.Clear();

            cmbCategory.SelectedIndex = -1;

            rdoLocal.Checked = false;
            rdoAbroad.Checked = false;

            chkActive.Checked = false;

            txtCost.Clear();
            txtPrice.Clear();
            txtMarkup.Clear();

            txtBarcode.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            decimal cost, price;

            if (string.IsNullOrWhiteSpace(txtBarcode.Text))
            {
                MessageBox.Show("Please enter the product barcode.",
                    "Missing Barcode", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtBarcode.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Please enter the anime merchandise name.",
                    "Missing Product Name", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtName.Focus();
                return;
            }

            if (cmbCategory.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a merchandise category.",
                    "Missing Category", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                cmbCategory.Focus();
                return;
            }

            if (!rdoLocal.Checked && !rdoAbroad.Checked)
            {
                MessageBox.Show("Please select the merchandise origin.",
                    "Missing Origin", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtCost.Text, out cost) || cost <= 0)
            {
                MessageBox.Show("Please enter a valid merchandise cost.",
                    "Invalid Cost", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtCost.Focus();
                return;
            }

            if (!decimal.TryParse(txtPrice.Text, out price) || price <= 0)
            {
                MessageBox.Show("Please enter a valid selling price.",
                    "Invalid Price", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtPrice.Focus();
                return;
            }

            string origin = rdoLocal.Checked ? "Local" : "Abroad";
            string status = chkActive.Checked ? "Available" : "Unavailable";

            MessageBox.Show(
                "✨ ANIME MERCHANDISE ADDED! ✨\n\n" +
                "Barcode: " + txtBarcode.Text +
                "\nMerchandise: " + txtName.Text +
                "\nDescription: " + txtDescription.Text +
                "\nCategory: " + cmbCategory.Text +
                "\nOrigin: " + origin +
                "\nAvailability: " + status +
                "\n\nCost: ₱" + cost.ToString("N2") +
                "\nSelling Price: ₱" + price.ToString("N2") +
                "\nMarkup: " + txtMarkup.Text + "%" +
                "\n\nYour anime merchandise is ready for inventory!",
                "Anime Merch Inventory",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void CalculateMarkup()
        {
            decimal cost, price;

            if (decimal.TryParse(txtCost.Text, out cost) &&
                decimal.TryParse(txtPrice.Text, out price) &&
                cost > 0)
            {
                decimal markup = ((price - cost) / cost) * 100;

                txtMarkup.Text = markup.ToString("0.00");
            }
            else
            {
                txtMarkup.Clear();
            }
        }

        private void txtCost_TextChanged(object sender, EventArgs e)
        {
            CalculateMarkup();
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            CalculateMarkup();
        }

        private void SAPORAS_Week05_Work04_Load(object sender, EventArgs e)
        {
            cmbCategory.Items.Add("Figures");
            cmbCategory.Items.Add("Acrylic Stands");
            cmbCategory.Items.Add("Keychains");
            cmbCategory.Items.Add("Posters");
            cmbCategory.Items.Add("Plushies");
            cmbCategory.Items.Add("Pins & Badges");
            cmbCategory.Items.Add("Apparel");
            cmbCategory.Items.Add("Manga");

            cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
        }
    }
}
