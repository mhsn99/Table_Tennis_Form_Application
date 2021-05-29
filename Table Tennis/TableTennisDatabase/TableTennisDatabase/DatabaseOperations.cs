using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace TableTennisDatabase
{
    class DatabaseOperations
    {
        SqlConnection sqlConnection = new SqlConnection(Properties.Settings.Default.MyConnection);
        BindingSource binder = new BindingSource();

        public int id, age, frh, bck, srv, spd, spn, win, lsl, score1, score2;
        public string name, country, imagepath, date, tournamentName, pName1, pName2;

        public byte[] image = null;

        bool abc;


        public void InsertPlayer() // Adding new player
        {
            try
            {
                abc = false;
                FileStream file = new FileStream(imagepath, FileMode.Open, FileAccess.Read);
                BinaryReader bnr = new BinaryReader(file);
                image = bnr.ReadBytes((int)file.Length); //For adding image to database


                sqlConnection.Open();
                SqlCommand controlCmd = new SqlCommand("PlayerProcedure", sqlConnection); // new player name and id cannot be equals recorded player name or id 
                controlCmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader readPlayer = controlCmd.ExecuteReader();

                while (readPlayer.Read())
                {
                    if (id.ToString() == (readPlayer["Player ID"]).ToString() || name == (readPlayer["Player Name"]).ToString())
                    {
                        abc = true;
                        sqlConnection.Close(); 
                        readPlayer.Close();
                        MessageBox.Show("This ID or name belongs to another player.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                readPlayer.Close();
                if (abc == false)
                {
                    SqlCommand InsertCmd = new SqlCommand("InsertPlayer", sqlConnection);
                    InsertCmd.CommandType = CommandType.StoredProcedure;

                    InsertCmd.Parameters.AddWithValue("@newID", id);
                    InsertCmd.Parameters.AddWithValue("@newName", name);
                    InsertCmd.Parameters.AddWithValue("@newAge", age);
                    InsertCmd.Parameters.AddWithValue("@newCountry", country);
                    InsertCmd.Parameters.AddWithValue("@forehand", frh);
                    InsertCmd.Parameters.AddWithValue("@backhand", bck);
                    InsertCmd.Parameters.AddWithValue("@service", srv);
                    InsertCmd.Parameters.AddWithValue("@speed", spd);
                    InsertCmd.Parameters.AddWithValue("@spin", spn);
                    InsertCmd.Parameters.AddWithValue("@win", win);
                    InsertCmd.Parameters.AddWithValue("@loses", lsl);
                    InsertCmd.Parameters.Add(new SqlParameter("@newImage", image));


                    InsertCmd.ExecuteNonQuery();
                    sqlConnection.Close();

                    MessageBox.Show("New Player Added!!!","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    return;
                }


            }
            catch (Exception ex)
            {
                sqlConnection.Close();
                MessageBox.Show(ex.Message);
                return;
            }
        }

        public void InsertMatch() //new match
        {
            try
            {
                sqlConnection.Open();
                SqlCommand InsertCmd = new SqlCommand("InsertMatch", sqlConnection);
                InsertCmd.CommandType = CommandType.StoredProcedure;

                InsertCmd.Parameters.AddWithValue("@tournament", tournamentName);
                InsertCmd.Parameters.AddWithValue("@player1", pName1);
                InsertCmd.Parameters.AddWithValue("@player2", pName2);
                InsertCmd.Parameters.AddWithValue("@score1", score1);
                InsertCmd.Parameters.AddWithValue("@score2", score2);
                InsertCmd.Parameters.AddWithValue("@date", date);

                InsertCmd.ExecuteNonQuery();
                sqlConnection.Close();

                MessageBox.Show("New match is added.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;

            }
            catch (Exception ex)
            {
                sqlConnection.Close();
                MessageBox.Show(ex.Message);
                return;
            }

        }
        public void showPlayerList(DataGridView data, Label lbl) //Showing all players info
        {
            sqlConnection.Open();
            SqlDataAdapter sqlData = new SqlDataAdapter("Select [Player ID],[Player Name],Age,Country From Player", sqlConnection);
            SqlCommand countCmd = new SqlCommand("Select COUNT(*) From Player", sqlConnection);
            lbl.Text = countCmd.ExecuteScalar().ToString();
            DataTable dt = new DataTable();
            sqlData.Fill(dt);

            binder.DataSource = dt;
            data.DataSource = binder;
            sqlConnection.Close();

        }

        public void showMatchList(DataGridView data, Label lbl, ComboBox box) // Showing players match
        {
            sqlConnection.Open();

            if (box.Text == "All") //all player
            {
                
                SqlDataAdapter sqlData = new SqlDataAdapter("Select [Player 1],[Score P1],[Score P2],[Player 2],Tournament,Date From Match", sqlConnection);
                SqlCommand countCmd = new SqlCommand("Select Count(*) From Match", sqlConnection);
                countCmd.Parameters.AddWithValue("@name", box.Text);

                lbl.Text = countCmd.ExecuteScalar().ToString();
                DataTable dt = new DataTable();
                sqlData.Fill(dt);

                binder.DataSource = dt;
                data.DataSource = binder;
                
            }
            else //specific
            { 
                
                SqlDataAdapter sqlData = new SqlDataAdapter("Select [Player 1],[Score P1],[Score P2],[Player 2],Tournament,Date From Match Where [Player 1] = '" + box.Text + "' OR [Player 2] = '" + box.Text + "'", sqlConnection);
                SqlCommand countCmd = new SqlCommand("Select Count(*) From Match Where [Player 1] = @name OR [Player 2] = @name", sqlConnection);
                countCmd.Parameters.AddWithValue("@name", box.Text);

                lbl.Text = countCmd.ExecuteScalar().ToString();
                DataTable dt = new DataTable();
                sqlData.Fill(dt);

                binder.DataSource = dt;
                data.DataSource = binder;
                
            }

            sqlConnection.Close();

        }

        public void UpdateAbility() // update ability
        {
            try
            {
                sqlConnection.Open();
                SqlCommand UpdateCmd = new SqlCommand("UpdateAbility", sqlConnection);
                UpdateCmd.CommandType = CommandType.StoredProcedure;

                
                UpdateCmd.Parameters.Add(new SqlParameter("@name", name));
                UpdateCmd.Parameters.Add(new SqlParameter("@forehand", frh));
                UpdateCmd.Parameters.Add(new SqlParameter("@backhand", bck));
                UpdateCmd.Parameters.Add(new SqlParameter("@service", srv));
                UpdateCmd.Parameters.Add(new SqlParameter("@speed", spd));
                UpdateCmd.Parameters.Add(new SqlParameter("@spin", spn));

                UpdateCmd.ExecuteNonQuery();
                sqlConnection.Close();
                MessageBox.Show("Player Ability updated.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            catch (Exception ex)
            {
                sqlConnection.Close();
                MessageBox.Show(ex.Message);
                return;
            }
        }

        public void UpdatePlayer() //update player
        {
            try
            {                             
                sqlConnection.Open();

                SqlCommand UpdateCmd = new SqlCommand("UpdatePlayer", sqlConnection);
                UpdateCmd.CommandType = CommandType.StoredProcedure;

                UpdateCmd.Parameters.Add(new SqlParameter("@id", id));
                UpdateCmd.Parameters.Add(new SqlParameter("@name", name));
                UpdateCmd.Parameters.Add(new SqlParameter("@age", age));
                UpdateCmd.Parameters.Add(new SqlParameter("@country", country));
                if (imagepath != "0")
                {
                    FileStream file = new FileStream(imagepath, FileMode.Open, FileAccess.Read);
                    BinaryReader bnr = new BinaryReader(file);
                    image = bnr.ReadBytes((int)file.Length);
                }

                UpdateCmd.Parameters.Add(new SqlParameter("@image", image));

                UpdateCmd.ExecuteNonQuery();
                sqlConnection.Close();
                MessageBox.Show("Player updated.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;

            }
            catch (Exception ex)
            {
                sqlConnection.Close();
                MessageBox.Show(ex.Message);
                return;
            }
        }
        public void DeletePlayer(ComboBox box) //delete
        {
            try
            {
                sqlConnection.Open();
                SqlCommand deleteCmd = new SqlCommand("DeletePlayer", sqlConnection);
                deleteCmd.CommandType = CommandType.StoredProcedure;

                deleteCmd.Parameters.AddWithValue("@name", box.Text);
                deleteCmd.ExecuteNonQuery();
                sqlConnection.Close();
                MessageBox.Show("Player deleted in database.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            catch (Exception ex)
            {
                sqlConnection.Close();
                MessageBox.Show(ex.Message);
                return;
            }
        }
        public void getPlayersName(ComboBox box) // get player name from database to combobox
        {
            try
            {
                sqlConnection.Open();
                SqlCommand getPlayerCmd = new SqlCommand("PlayerProcedure", sqlConnection);
                getPlayerCmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader readPlayer = getPlayerCmd.ExecuteReader();
                while (readPlayer.Read())
                {
                    box.Items.Add(readPlayer["Player Name"]);
                }
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                sqlConnection.Close();  
                MessageBox.Show(ex.Message);
                return;
            }
                                                                                                                                            
        }

        public void showStats(ComboBox box) //Showing Stats
        {
            try
            {
                sqlConnection.Open();
                SqlCommand statsCmd = new SqlCommand("SELECT Wins,Loses FROM Stats WHERE [Player Name] = @name",sqlConnection);
                statsCmd.Parameters.AddWithValue("@name", box.Text);
                SqlDataReader readStats = statsCmd.ExecuteReader();
                readStats.Read();
                if (readStats.HasRows)
                {
                    win = int.Parse(readStats[0].ToString());
                    lsl = int.Parse(readStats[1].ToString());
                }
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                sqlConnection.Close();
                MessageBox.Show(ex.Message);
                return;
            }
        }
        public void getAbility(ComboBox box) //Get players ability
        {
            try
            {
                sqlConnection.Open();
                SqlCommand abilityCmd = new SqlCommand("ShowPlayerAbility", sqlConnection);
                abilityCmd.CommandType = CommandType.StoredProcedure;
                abilityCmd.Parameters.AddWithValue("@name", box.Text);
                SqlDataReader readAbility = abilityCmd.ExecuteReader();
                readAbility.Read();

                if (readAbility.HasRows)
                {
                    frh = int.Parse(readAbility[0].ToString());
                    bck = int.Parse(readAbility[1].ToString());
                    srv = int.Parse(readAbility[2].ToString());
                    spn = int.Parse(readAbility[3].ToString());
                    spd = int.Parse(readAbility[4].ToString());
                }
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                sqlConnection.Close();
                MessageBox.Show(ex.Message);
                return;
            }


        }
        public void getPlayerData(ComboBox box) // getting player data because of 
        {
            try
            {
                sqlConnection.Open();

                SqlCommand getPlayerCmd = new SqlCommand("GetPlayerInfo", sqlConnection);
                getPlayerCmd.CommandType = CommandType.StoredProcedure;
                getPlayerCmd.Parameters.AddWithValue("@name", box.Text);
                SqlDataReader readPlayer = getPlayerCmd.ExecuteReader();
                readPlayer.Read();

                if (readPlayer.HasRows)
                {
                    id = int.Parse(readPlayer[0].ToString());
                    name = readPlayer[1].ToString();
                    age = int.Parse(readPlayer[2].ToString());
                    country = readPlayer[3].ToString();

                    if (readPlayer[4] != null)
                    {
                        image = ((byte[])readPlayer[4]);
                    }

                }

                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                sqlConnection.Close();
                MessageBox.Show(ex.Message);
                return;
            }

        }

    }
}
