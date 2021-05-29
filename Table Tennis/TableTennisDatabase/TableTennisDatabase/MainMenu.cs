using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;

namespace TableTennisDatabase
{
    public partial class MainMenu : Form
    {
        DatabaseOperations dbop = new DatabaseOperations();
        public MainMenu()
        {
            InitializeComponent();
            pnlPlayerInfo.Visible = false;
            pnlMatch.Visible = false;
            pnlAbility.Visible = false;
            grpStats.Visible = false;
            dgvPlayer.ForeColor = Color.Black;
            dgvMatch.ForeColor = Color.Black;
            
        }

        int sec = 0;
        private void tmrPrg_Tick(object sender, EventArgs e) //forProgressbar
        {
            sec++;
            if (toolprg.Value >= 1000)
            {
                sec++;
                if (sec > 0.5)
                {
                    tmrPrg.Enabled = false;
                    toolprg.Visible = false;
                    
                    sec = 0;
                }
            }
        }

        
        
        public void toolPrg()
        {
            
            
            tmrPrg.Enabled = false;
            if (toolprg.Visible == false)
            {
                toolprg.Visible = true;
                
            }          

            for (int i = 0; i <= 1000; i += 250)
            {
                toolprg.Value = i;
                
            }
            tmrPrg.Enabled = true;

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Are you sure want to exit?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                Environment.Exit(0);
            }

        }

        private void MainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (MessageBox.Show("Are you sure want to exit?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
                Environment.Exit(0);
        }   

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure want to back Login Menu?","Question",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Visible = false;
                FormLogin login = new FormLogin();
                login.Show();
            }           
        }

        private void playerToolStripMenuItem_Click(object sender, EventArgs e) 
        {
            NewPlayer player = new NewPlayer();
            player.ShowDialog();
            

        }

        private void matchToolStripMenuItem_Click(object sender, EventArgs e) 
        {
            NewMatch match = new NewMatch();
            match.ShowDialog();
            
        }

        private void editPlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditPlayer edit = new EditPlayer();
            edit.ShowDialog();
            
        }

        private void timerMenu_Tick(object sender, EventArgs e)
        {
            
            stsDate.Text = DateTime.Now.ToString("dd MMMM dddd yyyy - HH:mm"); 
        }

        private void btnPlayerInfo_Click(object sender, EventArgs e) // all players general info
        {
            dgvPlayer.DataSource = null;
            toolPrg();

            if (pnlAbility.Visible == true)
            {
                pnlAbility.Visible = false;
            }
            else if (pnlMatch.Visible == true)
            {
                pnlMatch.Visible = false;
            }
            
            pnlPlayerInfo.Visible = true;
            dbop.showPlayerList(dgvPlayer, lblTotal);
        }

        
        private void btnPlayerAbility_Click(object sender, EventArgs e) // Show player ability
        {
            
            toolPrg();
            grpAbility.Visible = false;
            if (pnlPlayerInfo.Visible == true)
            {
                pnlPlayerInfo.Visible = false;
            }
            else if (pnlMatch.Visible == true)
            {
                pnlMatch.Visible = false;
            }
            pnlAbility.Visible = true;
            cmbPlayer.Items.Clear();
            dbop.getPlayersName(cmbPlayer);
            
            lblPlayerInfo.Text = "Player ID - Player Name - Age - Country ";

            lblOverall.Visible = false;
            lblOverallValue.Visible = false;

            pbPlayerImage.Image = null;


        }

        private void btnPlayerMatch_Click(object sender, EventArgs e) // match
        {
            if (pnlMatch.Visible == false)
            {
                toolPrg();
            }        
            if (pnlAbility.Visible == true)
            {
                pnlAbility.Visible = false;
            }
            else if (pnlPlayerInfo.Visible == true)
            {
                pnlPlayerInfo.Visible = false;
            }
            pnlMatch.Visible = true;

            grpStats.Visible = false;
            cmbMatchPlayer.Items.Clear();
            cmbMatchPlayer.Items.Add("All");
            dbop.getPlayersName(cmbMatchPlayer);
    
            lblRecordedMatchs.Text = "Recorded Matchs";
            lblRecordedTotalMatch.Text = "0";
            
            dgvMatch.DataSource = null;
            
            
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            toolPrg();
        }

        public void showAbility()
        {
            dbop.getPlayerData(cmbPlayer);
            dbop.getAbility(cmbPlayer);
            lblPlayerInfo.Text = dbop.id + " - " + dbop.name + " - " + dbop.age + " - " + dbop.country;

            grpAbility.Visible = true;

            prgForehand.Value = dbop.frh * 4;
            lblForehandValue.Text = dbop.frh.ToString();

            prgBackhand.Value = dbop.bck * 4;
            lblBackhandValue.Text = dbop.bck.ToString();

            prgService.Value = dbop.srv * 4;
            lblServiceValue.Text = dbop.srv.ToString();

            prgSpin.Value = dbop.spn * 4;
            lblSpinValue.Text = dbop.spn.ToString();

            prgSpeed.Value = dbop.spd * 4;
            lblSpeedValue.Text = dbop.spd.ToString();

            float mean = ((dbop.bck + dbop.frh + dbop.spd + dbop.spn + dbop.srv) / 5);
            lblOverall.Visible = true;
            lblOverallValue.Visible = true;
            lblOverallValue.Text = mean.ToString();

            MemoryStream memory = new MemoryStream(dbop.image);

            pbPlayerImage.Image = Image.FromStream(memory);
        }
        private void cmbPlayer_SelectedIndexChanged(object sender, EventArgs e)
        {
            toolPrg();
            showAbility();
            
        }

        public void showMatch()
        {
            if (cmbMatchPlayer.Text == "All")
            {
                toolPrg();
                grpStats.Visible = false;
                dbop.showMatchList(dgvMatch, lblRecordedTotalMatch, cmbMatchPlayer);
            }
            else
            {
                toolPrg();
                dbop.showMatchList(dgvMatch, lblRecordedTotalMatch, cmbMatchPlayer);
                grpStats.Visible = true;
                dbop.showStats(cmbMatchPlayer);
                prgWins.Value = dbop.win * 10;
                lblTotalWins.Text = dbop.win.ToString();

                prgLoses.Value = dbop.lsl * 10;
                lblTotalLoses.Text = dbop.lsl.ToString();
            }
        }

        private void cmbMatchPlayer_SelectedIndexChanged(object sender, EventArgs e)
        {

            showMatch();
        }

        private void ClosePanel(object sender, EventArgs e)
        {
            foreach (var item in Controls)
            {
                if (item is Panel)
                {
                    ((Panel)item).Visible = false;
                }
            }
        }

        private void SaveImage(object sender, EventArgs e)
        {
            if (pnlAbility.Visible == true)
            {


                if (cmbPlayer.SelectedItem == null)
                {
                    MessageBox.Show("You didn't select a player.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                string filePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop).ToString() + "\\" + (cmbPlayer.Text.ToString() + ".jpg");
                Bitmap bmp = new Bitmap(pnlAbility.Width, pnlAbility.Height);

                pnlAbility.DrawToBitmap(bmp, new Rectangle(0, 0, pnlAbility.Width, pnlAbility.Height));

                bmp.Save(filePath, ImageFormat.Jpeg);

                MessageBox.Show("Player Abilities' Screenshot was saved to Desktop.");
                return;


            }
            else
            {
                MessageBox.Show("You should open the player ability menu.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }


    }
}
