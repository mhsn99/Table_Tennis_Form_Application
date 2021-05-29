using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TableTennisDatabase
{
    public partial class NewMatch : Form
    {
        DatabaseOperations dbop = new DatabaseOperations();
        public NewMatch()
        {
            InitializeComponent();
           
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        int total;
        private void btnAddMatchInfo_Click(object sender, EventArgs e)
        {
            total = 0;

            foreach (var item in grpTournament.Controls)
            {
                if (item is ComboBox && ((ComboBox)item).Text == "")
                {
                    MessageBox.Show("Please select Tournament Details!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (cmbPlayer1.Text == cmbPlayer2.Text)
                {
                    MessageBox.Show("Players cannot play with themselves!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            total += 1;

            foreach (var item in grpMatch.Controls)
            {
                if (item is MaskedTextBox)
                {
                    if (mtxtPlayer1Score.Text == "" || mtxtPlayer2Score.Text == "")
                    {
                        MessageBox.Show("Please enter match score!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (mtxtDate.Text == "")
                    {
                        MessageBox.Show("Please enter match date!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (int.Parse(mtxtPlayer1Score.Text) < 0 || int.Parse(mtxtPlayer1Score.Text) > 4) 
                    {
                        MessageBox.Show("Score can be between 0 - 4 !!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (int.Parse(mtxtPlayer2Score.Text) < 0 || int.Parse(mtxtPlayer2Score.Text) > 4)
                    {
                        MessageBox.Show("Score can be between 0 - 4 !!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (int.Parse(mtxtPlayer1Score.Text) == int.Parse(mtxtPlayer2Score.Text))
                    {
                        MessageBox.Show("Scores cannot be equal!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (int.Parse(mtxtPlayer1Score.Text) < 4 && int.Parse(mtxtPlayer2Score.Text) != 4)
                    {
                        MessageBox.Show("One score must be 4 l!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (int.Parse(mtxtPlayer1Score.Text) != 4 && int.Parse(mtxtPlayer2Score.Text) < 4)
                    {
                        MessageBox.Show("One score must be 4 l!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                }
            }
            total += 1;

            if (total == 2)
            {
                try
                {
                    dbop.tournamentName = cmbTournament.Text;
                    dbop.pName1 = cmbPlayer1.Text;
                    dbop.pName2 = cmbPlayer2.Text;
                    dbop.score1 = int.Parse(mtxtPlayer1Score.Text);
                    dbop.score2 = int.Parse(mtxtPlayer2Score.Text);
                    dbop.date = mtxtDate.Text;

                    dbop.InsertMatch();
                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
                
            }

        }

        private void NewMatch_Load(object sender, EventArgs e)
        {
            cmbPlayer1.Items.Clear();
            cmbPlayer2.Items.Clear();
            dbop.getPlayersName(cmbPlayer1);
            dbop.getPlayersName(cmbPlayer2);
        }
    }
}
