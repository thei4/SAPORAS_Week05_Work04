
namespace Equipment_Manager
{
    public partial class EquipmentManager : Form
    {
        public EquipmentManager()
        {
            InitializeComponent();

            dgvEquipment.DefaultCellStyle.ForeColor = Color.Black;


            LoadSampleRecords();
            LoadStatusOptions();
        }

        private void LoadSampleRecords()
        {
            dgvEquipment.Rows.Clear();

            dgvEquipment.Rows.Add(
                "EQ-101", "Laptop", "Computer", "Room 204", "Available"
            );

            dgvEquipment.Rows.Add(
                "EQ-102", "Projector", "Audio-Visual", "Library", "Checked Out"
            );

        }

        private void LoadStatusOptions()
        {
            cmbStatus.Items.Clear();

            cmbStatus.Items.Add("Available");
            cmbStatus.Items.Add("Checked Out");
            cmbStatus.Items.Add("Under Maintenance");

            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            string assetTag = txtAssetTag.Text.Trim();
            string equipment = txtEquipment.Text.Trim();
            string category = txtCategory.Text.Trim();
            string location = txtLocation.Text.Trim();

            if (assetTag == "" || equipment == "" ||
                category == "" || location == "")
            {
                MessageBox.Show("Please fill in all fields.",
                    "Missing Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            dgvEquipment.Rows.Add(
                assetTag,
                equipment,
                category,
                location,
                "Available"
            );

            txtAssetTag.Clear();
            txtEquipment.Clear();
            txtCategory.Clear();
            txtLocation.Clear();

            MessageBox.Show("Equipment added successfully!",
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvEquipment.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an equipment record first.",
                    "No Selection",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (cmbStatus.SelectedItem == null)
            {
                MessageBox.Show("Please select a status.",
                    "Missing Status",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            string newStatus = cmbStatus.SelectedItem.ToString();

            dgvEquipment.SelectedRows[0].Cells[4].Value = newStatus;

            cmbStatus.SelectedIndex = -1;

            MessageBox.Show("Equipment status updated successfully!",
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.Trim().ToLower();

            if (searchText == "")
            {
                MessageBox.Show("Please enter an asset tag or equipment name.",
                    "Empty Search",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            bool found = false;

            dgvEquipment.ClearSelection();
            dgvEquipment.CurrentCell = null;

            foreach (DataGridViewRow row in dgvEquipment.Rows)
            {
                string assetTag = row.Cells[0].Value?.ToString().ToLower() ?? "";
                string equipment = row.Cells[1].Value?.ToString().ToLower() ?? "";

                if (assetTag.Contains(searchText) || equipment.Contains(searchText))
                {
                    row.Visible = true;
                    found = true;
                }
                else
                {
                    row.Visible = false;
                }
            }

            if (!found)
            {
                MessageBox.Show("No matching equipment found.",
                    "Search Result",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvEquipment.Rows)
            {
                row.Visible = true;
            }

            txtSearch.Clear();

            dgvEquipment.ClearSelection();
            dgvEquipment.CurrentCell = null;
        }
    }
}



