using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TableTennisDatabase
{
    public partial class NewPlayer : Form
    {
        DatabaseOperations dbop = new DatabaseOperations();
        NewMatch matchsss = new NewMatch();
        
        public NewPlayer()
        {
            InitializeComponent();            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAddPlayer_Click(object sender, EventArgs e)
        {
            foreach (var item in grpPlayer.Controls)
            {
               
                if (item is TextBox)
                {
                    Text = ((TextBox)item).Text;
                    if (Text == "")
                    {
                        MessageBox.Show("Please enter a name!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        for (int i = 0; i < Text.Length; i++)
                        {
                            if (Char.IsSymbol(Text[i]) || Char.IsNumber(Text[i]))
                            {
                                MessageBox.Show("Please enter the name using only character.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                    }

                }
                if (item is PictureBox)
                {
                    if (slblImagePath.Text == "")
                    {
                        MessageBox.Show("Please add an image!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                if (item is MaskedTextBox)
                {
                    Text = ((MaskedTextBox)item).Text;
                    if (Text == "")
                    {
                        MessageBox.Show("Please enter a value!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (item != mtxtPlayerID && int.Parse(mtxtPlayerAge.Text) < 15)
                    {
                        MessageBox.Show("Player age cannot be under the 15..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                if (item is ComboBox)
                {
                    Text = ((ComboBox)item).Text;
                    if (Text == "")
                    {
                        MessageBox.Show("Please select Player Country!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

            }


            foreach (var item in grpAbility.Controls)
            {

                if (item is TextBox)
                {

                    if (((TextBox)item).Text == "")
                    {
                        MessageBox.Show("Please enter ability values.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (int.Parse(((TextBox)item).Text) < 0 || int.Parse(((TextBox)item).Text) > 100 || int.Parse(((TextBox)item).Text) == 0)
                    {
                        MessageBox.Show("Abilitiy value should be between 1 -100", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }                                           
                }                
            }


            foreach (var item in grpStats.Controls)
            {
                if (item is TextBox)
                {
                    if (((TextBox)item).Text == "")
                    {
                        MessageBox.Show("Please enter stats values.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (int.Parse(((TextBox)item).Text) < 0 || int.Parse(((TextBox)item).Text) > 100)
                    {
                        MessageBox.Show("Stats values should be between 0 - 100", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    
                }
            }

            try
            {
                ConnectionDbo();
                dbop.InsertPlayer();
                Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

        }

        public void ConnectionDbo()
        {
            dbop.age = int.Parse(mtxtPlayerAge.Text);
            dbop.bck = int.Parse(txtBackhand.Text);
            dbop.country = cmbCountry.Text;
            dbop.frh = int.Parse(txtForehand.Text);
            dbop.id = int.Parse(mtxtPlayerID.Text);
            dbop.lsl = int.Parse(txtLoses.Text);
            dbop.name = txtPlayerName.Text;
            dbop.spd = int.Parse(txtSpeed.Text);
            dbop.spn = int.Parse(txtSpin.Text);
            dbop.srv = int.Parse(txtService.Text);
            dbop.win = int.Parse(txtWins.Text);
            dbop.imagepath = slblImagePath.Text;
             
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
        private void txtForehand_Click(object sender, EventArgs e)
        {
            if(sender is TextBox)
            {
                ((TextBox)sender).Clear();
            }
            

        }
    }
}
