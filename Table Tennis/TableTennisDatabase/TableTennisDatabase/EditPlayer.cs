using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TableTennisDatabase
{
    public partial class EditPlayer : Form
    {
        DatabaseOperations dbop = new DatabaseOperations();
        
        public EditPlayer()
        {
            InitializeComponent();
            grpPlayerInfo.Visible = false;
            grpAbility.Visible = false;
            btnApply.Visible = false;
         
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
           
        }

        private void EditPlayer_FormClosing(object sender, FormClosingEventArgs e)
        {
            Close();
            
        }

        
        public void showPlayerData()
        {
            txtPlayerName.Text = dbop.name;
            txtPlayerAge.Text = dbop.age.ToString();
            txtPlayerID.Text = dbop.id.ToString();
            cmbCountry.Text = dbop.country;

            if (dbop.image == null)
            {
                MessageBox.Show("Player has no image");
                return;
            }
            else
            {
                MemoryStream memory = new MemoryStream(dbop.image);

                pbPlayerImage.Image = Image.FromStream(memory);
                
            }
            
        }
        public void showAbilityData()
        {
            lblPlayerInfo.Text = "ID: " + dbop.id.ToString() + "\n" + 
                "Name: " +dbop.name.ToString() + "\n" + 
                "Age: " + dbop.age.ToString() + " \n" + 
                "Country: " + dbop.country.ToString();

            if (dbop.image == null)
            {
                MessageBox.Show("Player has no image");
                return;
            }
            else
            {
                MemoryStream memory = new MemoryStream(dbop.image);

                pbPlayerImage2.Image = Image.FromStream(memory);

            }
        }
        private void btnGetPlayerInfo_Click(object sender, EventArgs e)
        {
            if (cmbEdit.Text == "" || cmbPlayerName.Text == "")
            {
                MessageBox.Show("Please fill the areas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (cmbEdit.Text == "Delete Player")
                {
                    grpPlayerInfo.Visible = true;
                    grpAbility.Visible = false;
                    btnAddImage.Enabled = false;
                    btnApply.Visible = true;
                    cmbCountry.Enabled = false;
                    txtPlayerID.Enabled = false;
                    txtPlayerName.Enabled = false;
                    txtPlayerAge.Enabled = false;
                    btnApply.Visible = true;
                    pbPlayerImage.Enabled = true;
                    dbop.getPlayerData(cmbPlayerName);
                    showPlayerData();
                    

                }
                if (cmbEdit.Text == "Update Player")
                {
                    grpPlayerInfo.Visible = true;
                    grpAbility.Visible = false;
                    txtPlayerID.Enabled = false ;
                    btnApply.Visible = true;
                    txtPlayerName.Enabled = true;
                    txtPlayerAge.Enabled = true;
                    btnApply.Visible = true;
                    btnAddImage.Enabled = true;
                    cmbCountry.Enabled = true;
                    pbPlayerImage.Enabled = true;
                    dbop.getPlayerData(cmbPlayerName);
                    showPlayerData();
                }
                if (cmbEdit.Text == "Update Ability")
                {
                    grpAbility.Visible = true;
                    grpPlayerInfo.Visible = false;
                    btnApply.Visible = true;
                    dbop.getPlayerData(cmbPlayerName);
                    showAbilityData();
                    dbop.getAbility(cmbPlayerName);

                    prgForehand.Value = dbop.frh;
                    txtForehand.Text = dbop.frh.ToString();
                    prgForehand.Enabled = false;

                    prgBackhand.Value = dbop.bck;
                    txtBackhand.Text = dbop.bck.ToString();
                    prgBackhand.Enabled = false;

                    prgService.Value = dbop.srv;
                    txtService.Text = dbop.srv.ToString();
                    prgService.Enabled = false;

                    prgSpin.Value = dbop.spn;
                    txtSpin.Text = dbop.spn.ToString();
                    prgSpin.Enabled = false;

                    prgSpeed.Value = dbop.spd;
                    txtSpeed.Text = dbop.spd.ToString();
                    prgSpeed.Enabled = false;
                }
            }
            
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            
            

            if (cmbEdit.Text == "Delete Player")
            {
                if (MessageBox.Show("Are you sure want to delete the player?","Question",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    dbop.DeletePlayer(cmbPlayerName);
                    Close();
                    
                }
                //
            }
            if (cmbEdit.Text == "Update Player")
            {
                foreach (var item in grpPlayerInfo.Controls)
                {
                    
                    if (txtPlayerName.Text == "")
                    {
                        MessageBox.Show("Please enter an name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    
                    }
                    if (txtPlayerName.Text !="")
                    {
                        for (int i = 0; i < txtPlayerName.Text.Length; i++)
                        {
                            if (Char.IsSymbol(txtPlayerName.Text[i]) || Char.IsNumber(txtPlayerName.Text[i]))
                            {
                                MessageBox.Show("Please enter the name using only character.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                        continue;
                    }
                    if (cmbCountry.Text == "")
                    {
                        MessageBox.Show("Please select a country.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }


                try
                {
                    dbop.id = int.Parse(txtPlayerID.Text);
                    dbop.name = txtPlayerName.Text;
                    dbop.age = int.Parse(txtPlayerAge.Text);
                    dbop.country = cmbCountry.Text;
                    if (slblImagePath.Text != "")
                    {
                        dbop.imagepath = slblImagePath.Text;
                    }
                    else
                        dbop.imagepath = "0";

                    if (MessageBox.Show("Are you sure want to change player info?","Question",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        dbop.UpdatePlayer();
                        Close();
                        
                    }
                    

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }

            }
            if (cmbEdit.Text == "Update Ability")
            {
                foreach (var item in grpAbility.Controls)
                {

                    if (item is TextBox)
                    {

                        if (((TextBox)item).Text == "")
                        {
                            MessageBox.Show("Please enter ability values.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                }

                try
                {
                    dbop.name = cmbPlayerName.Text;
                    dbop.frh = int.Parse(txtForehand.Text);
                    dbop.bck = int.Parse(txtBackhand.Text);
                    dbop.srv = int.Parse(txtService.Text);
                    dbop.spn = int.Parse(txtSpin.Text);
                    dbop.spd = int.Parse(txtSpeed.Text);

                    if (MessageBox.Show("Are you sure want to change player ability info?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        dbop.UpdateAbility();
                        Close();
                       
                    }
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }

            }
        }

        private void btnAddImage_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "JPEG Files | *.jpg;*.jpeg| PNG Files | *png| All Files|*.*";
                ofd.Multiselect = false;
                ofd.Title = "Select Image Files";
                ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pbPlayerImage.Image = new Bitmap(ofd.FileName);
                    slblImagePath.Text = ofd.FileName.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void EditPlayer_Load(object sender, EventArgs e)
        {
            cmbPlayerName.Items.Clear();
            dbop.getPlayersName(cmbPlayerName);

            prgForehand.Value = int.Parse(txtForehand.Text);
        }

        private void AbilityTextClick(object sender, EventArgs e)
        {
            if (sender is TextBox)
            {
                ((TextBox)sender).Clear();
            }
        }
        private void AbilityTextChange(object sender, EventArgs e)
        {
            if (sender == txtForehand)
            {
                try
                {
                    if (txtForehand.Text =="")
                    {
                        prgForehand.Value = 0;
                    }
                    else
                        prgForehand.Value = int.Parse(txtForehand.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Ability Value can be integer between 0-100","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return;
                }
            }
            if (sender == txtBackhand)
            {
                try
                {
                    if (txtBackhand.Text == "")
                    {
                        prgBackhand.Value = 0;
                    }
                    else
                        prgBackhand.Value = int.Parse(txtBackhand.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Ability Value can be integer between 0-100", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            if (sender == txtService)
            {
                try
                {
                    if (txtService.Text == "")
                    {
                        prgService.Value = 0;
                    }
                    else
                        prgService.Value = int.Parse(txtService.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Ability Value can be integer between 0-100", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            if (sender == txtSpin)
            {
                try
                {
                    if (txtSpin.Text == "")
                    {
                        prgSpin.Value = 0;
                    }
                    else
                        prgSpin.Value = int.Parse(txtSpin.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Ability Value can be integer between 0-100", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            if (sender == txtSpeed)
            {
                try
                {
                    if (txtSpeed.Text == "")
                    {
                        prgSpeed.Value = 0;
                    }
                    else
                        prgSpeed.Value = int.Parse(txtSpeed.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Ability Value can be integer between 0-100", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

        }
    }
}
