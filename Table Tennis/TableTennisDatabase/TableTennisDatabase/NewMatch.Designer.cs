namespace TableTennisDatabase
{
    partial class NewMatch
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTournament = new System.Windows.Forms.Label();
            this.cmbTournament = new System.Windows.Forms.ComboBox();
            this.mtxtPlayer1Score = new System.Windows.Forms.MaskedTextBox();
            this.mtxtPlayer2Score = new System.Windows.Forms.MaskedTextBox();
            this.lblPlayer1 = new System.Windows.Forms.Label();
            this.lblPlayer2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblSelectPlayer1 = new System.Windows.Forms.Label();
            this.lblSelectPlayer2 = new System.Windows.Forms.Label();
            this.cmbPlayer1 = new System.Windows.Forms.ComboBox();
            this.cmbPlayer2 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.grpTournament = new System.Windows.Forms.GroupBox();
            this.grpMatch = new System.Windows.Forms.GroupBox();
            this.mtxtDate = new System.Windows.Forms.MaskedTextBox();
            this.lblMatchDate = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAddMatchInfo = new System.Windows.Forms.Button();
            this.grpTournament.SuspendLayout();
            this.grpMatch.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTournament
            // 
            this.lblTournament.AutoSize = true;
            this.lblTournament.Location = new System.Drawing.Point(6, 40);
            this.lblTournament.Name = "lblTournament";
            this.lblTournament.Size = new System.Drawing.Size(152, 23);
            this.lblTournament.TabIndex = 0;
            this.lblTournament.Text = "Select Tournament:";
            // 
            // cmbTournament
            // 
            this.cmbTournament.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTournament.FormattingEnabled = true;
            this.cmbTournament.Items.AddRange(new object[] {
            "2020 ITTF World Tour Platinum, Qatar Open",
            "2020 ITTF World Tour, Hungarian Open",
            "2020 ITTF World Tour Platinum, German Open",
            "2020 Yıldız Technical Univercity, Davutpaşa Open "});
            this.cmbTournament.Location = new System.Drawing.Point(164, 37);
            this.cmbTournament.Name = "cmbTournament";
            this.cmbTournament.Size = new System.Drawing.Size(434, 31);
            this.cmbTournament.TabIndex = 1;
            // 
            // mtxtPlayer1Score
            // 
            this.mtxtPlayer1Score.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mtxtPlayer1Score.Location = new System.Drawing.Point(243, 41);
            this.mtxtPlayer1Score.Mask = "0";
            this.mtxtPlayer1Score.Name = "mtxtPlayer1Score";
            this.mtxtPlayer1Score.Size = new System.Drawing.Size(32, 52);
            this.mtxtPlayer1Score.TabIndex = 2;
            this.mtxtPlayer1Score.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtxtPlayer1Score.ValidatingType = typeof(int);
            // 
            // mtxtPlayer2Score
            // 
            this.mtxtPlayer2Score.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mtxtPlayer2Score.Location = new System.Drawing.Point(319, 41);
            this.mtxtPlayer2Score.Mask = "0";
            this.mtxtPlayer2Score.Name = "mtxtPlayer2Score";
            this.mtxtPlayer2Score.Size = new System.Drawing.Size(32, 52);
            this.mtxtPlayer2Score.TabIndex = 3;
            this.mtxtPlayer2Score.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtxtPlayer2Score.ValidatingType = typeof(int);
            // 
            // lblPlayer1
            // 
            this.lblPlayer1.AutoSize = true;
            this.lblPlayer1.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPlayer1.Location = new System.Drawing.Point(65, 45);
            this.lblPlayer1.Name = "lblPlayer1";
            this.lblPlayer1.Size = new System.Drawing.Size(136, 45);
            this.lblPlayer1.TabIndex = 4;
            this.lblPlayer1.Text = "Player 1";
            // 
            // lblPlayer2
            // 
            this.lblPlayer2.AutoSize = true;
            this.lblPlayer2.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPlayer2.Location = new System.Drawing.Point(393, 45);
            this.lblPlayer2.Name = "lblPlayer2";
            this.lblPlayer2.Size = new System.Drawing.Size(142, 45);
            this.lblPlayer2.TabIndex = 5;
            this.lblPlayer2.Text = "Player 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(291, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 23);
            this.label3.TabIndex = 18;
            this.label3.Text = "-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(207, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 45);
            this.label4.TabIndex = 19;
            this.label4.Text = ":";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(357, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 45);
            this.label5.TabIndex = 20;
            this.label5.Text = ":";
            // 
            // lblSelectPlayer1
            // 
            this.lblSelectPlayer1.AutoSize = true;
            this.lblSelectPlayer1.Location = new System.Drawing.Point(6, 89);
            this.lblSelectPlayer1.Name = "lblSelectPlayer1";
            this.lblSelectPlayer1.Size = new System.Drawing.Size(125, 23);
            this.lblSelectPlayer1.TabIndex = 21;
            this.lblSelectPlayer1.Text = "Select Player 1:";
            // 
            // lblSelectPlayer2
            // 
            this.lblSelectPlayer2.AutoSize = true;
            this.lblSelectPlayer2.Location = new System.Drawing.Point(465, 89);
            this.lblSelectPlayer2.Name = "lblSelectPlayer2";
            this.lblSelectPlayer2.Size = new System.Drawing.Size(133, 23);
            this.lblSelectPlayer2.TabIndex = 22;
            this.lblSelectPlayer2.Text = ": Select Player 2";
            // 
            // cmbPlayer1
            // 
            this.cmbPlayer1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPlayer1.FormattingEnabled = true;
            this.cmbPlayer1.Location = new System.Drawing.Point(137, 86);
            this.cmbPlayer1.Name = "cmbPlayer1";
            this.cmbPlayer1.Size = new System.Drawing.Size(152, 31);
            this.cmbPlayer1.TabIndex = 23;
            // 
            // cmbPlayer2
            // 
            this.cmbPlayer2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPlayer2.FormattingEnabled = true;
            this.cmbPlayer2.Location = new System.Drawing.Point(307, 86);
            this.cmbPlayer2.Name = "cmbPlayer2";
            this.cmbPlayer2.Size = new System.Drawing.Size(152, 31);
            this.cmbPlayer2.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(281, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 45);
            this.label8.TabIndex = 25;
            this.label8.Text = "-";
            // 
            // grpTournament
            // 
            this.grpTournament.BackColor = System.Drawing.Color.White;
            this.grpTournament.Controls.Add(this.lblTournament);
            this.grpTournament.Controls.Add(this.cmbPlayer2);
            this.grpTournament.Controls.Add(this.cmbTournament);
            this.grpTournament.Controls.Add(this.cmbPlayer1);
            this.grpTournament.Controls.Add(this.lblSelectPlayer1);
            this.grpTournament.Controls.Add(this.lblSelectPlayer2);
            this.grpTournament.Controls.Add(this.label3);
            this.grpTournament.Location = new System.Drawing.Point(12, 12);
            this.grpTournament.Name = "grpTournament";
            this.grpTournament.Size = new System.Drawing.Size(612, 132);
            this.grpTournament.TabIndex = 26;
            this.grpTournament.TabStop = false;
            this.grpTournament.Text = "Tournament Details";
            // 
            // grpMatch
            // 
            this.grpMatch.BackColor = System.Drawing.Color.White;
            this.grpMatch.Controls.Add(this.mtxtDate);
            this.grpMatch.Controls.Add(this.lblMatchDate);
            this.grpMatch.Controls.Add(this.lblPlayer2);
            this.grpMatch.Controls.Add(this.mtxtPlayer1Score);
            this.grpMatch.Controls.Add(this.label8);
            this.grpMatch.Controls.Add(this.mtxtPlayer2Score);
            this.grpMatch.Controls.Add(this.label5);
            this.grpMatch.Controls.Add(this.lblPlayer1);
            this.grpMatch.Controls.Add(this.label4);
            this.grpMatch.Location = new System.Drawing.Point(12, 160);
            this.grpMatch.Name = "grpMatch";
            this.grpMatch.Size = new System.Drawing.Size(612, 181);
            this.grpMatch.TabIndex = 27;
            this.grpMatch.TabStop = false;
            this.grpMatch.Text = "Match Score";
            // 
            // mtxtDate
            // 
            this.mtxtDate.Location = new System.Drawing.Point(281, 132);
            this.mtxtDate.Mask = "00/00/0000";
            this.mtxtDate.Name = "mtxtDate";
            this.mtxtDate.Size = new System.Drawing.Size(132, 30);
            this.mtxtDate.TabIndex = 27;
            this.mtxtDate.ValidatingType = typeof(System.DateTime);
            // 
            // lblMatchDate
            // 
            this.lblMatchDate.AutoSize = true;
            this.lblMatchDate.Location = new System.Drawing.Point(174, 135);
            this.lblMatchDate.Name = "lblMatchDate";
            this.lblMatchDate.Size = new System.Drawing.Size(101, 23);
            this.lblMatchDate.TabIndex = 26;
            this.lblMatchDate.Text = "Match Date:";
            // 
            // btnCancel
            // 
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(331, 347);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(125, 39);
            this.btnCancel.TabIndex = 29;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAddMatchInfo
            // 
            this.btnAddMatchInfo.BackColor = System.Drawing.Color.Lime;
            this.btnAddMatchInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddMatchInfo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddMatchInfo.Location = new System.Drawing.Point(461, 347);
            this.btnAddMatchInfo.Name = "btnAddMatchInfo";
            this.btnAddMatchInfo.Size = new System.Drawing.Size(163, 39);
            this.btnAddMatchInfo.TabIndex = 28;
            this.btnAddMatchInfo.Text = "Add Match Info";
            this.btnAddMatchInfo.UseVisualStyleBackColor = false;
            this.btnAddMatchInfo.Click += new System.EventHandler(this.btnAddMatchInfo_Click);
            // 
            // NewMatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OrangeRed;
            this.ClientSize = new System.Drawing.Size(636, 398);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddMatchInfo);
            this.Controls.Add(this.grpMatch);
            this.Controls.Add(this.grpTournament);
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "NewMatch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewMatch";
            this.Load += new System.EventHandler(this.NewMatch_Load);
            this.grpTournament.ResumeLayout(false);
            this.grpTournament.PerformLayout();
            this.grpMatch.ResumeLayout(false);
            this.grpMatch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTournament;
        private System.Windows.Forms.ComboBox cmbTournament;
        private System.Windows.Forms.MaskedTextBox mtxtPlayer1Score;
        private System.Windows.Forms.MaskedTextBox mtxtPlayer2Score;
        private System.Windows.Forms.Label lblPlayer1;
        private System.Windows.Forms.Label lblPlayer2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblSelectPlayer1;
        private System.Windows.Forms.Label lblSelectPlayer2;
        private System.Windows.Forms.ComboBox cmbPlayer1;
        private System.Windows.Forms.ComboBox cmbPlayer2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox grpTournament;
        private System.Windows.Forms.GroupBox grpMatch;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAddMatchInfo;
        private System.Windows.Forms.MaskedTextBox mtxtDate;
        private System.Windows.Forms.Label lblMatchDate;
    }
}