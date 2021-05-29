namespace TableTennisDatabase
{
    partial class NewPlayer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewPlayer));
            this.lblPlayerID = new System.Windows.Forms.Label();
            this.txtPlayerName = new System.Windows.Forms.TextBox();
            this.pbPlayerImage = new System.Windows.Forms.PictureBox();
            this.btnAddImage = new System.Windows.Forms.Button();
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.mtxtPlayerID = new System.Windows.Forms.MaskedTextBox();
            this.mtxtPlayerAge = new System.Windows.Forms.MaskedTextBox();
            this.lblPlayerAge = new System.Windows.Forms.Label();
            this.grpPlayer = new System.Windows.Forms.GroupBox();
            this.cmbCountry = new System.Windows.Forms.ComboBox();
            this.lblCountry = new System.Windows.Forms.Label();
            this.grpAbility = new System.Windows.Forms.GroupBox();
            this.pbSpeed = new System.Windows.Forms.PictureBox();
            this.txtSpeed = new System.Windows.Forms.TextBox();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.pbSpin = new System.Windows.Forms.PictureBox();
            this.txtSpin = new System.Windows.Forms.TextBox();
            this.lblSpin = new System.Windows.Forms.Label();
            this.pbService = new System.Windows.Forms.PictureBox();
            this.txtService = new System.Windows.Forms.TextBox();
            this.lblService = new System.Windows.Forms.Label();
            this.pbBackhand = new System.Windows.Forms.PictureBox();
            this.txtBackhand = new System.Windows.Forms.TextBox();
            this.lblBackhand = new System.Windows.Forms.Label();
            this.pbForehand = new System.Windows.Forms.PictureBox();
            this.txtForehand = new System.Windows.Forms.TextBox();
            this.lblForehand = new System.Windows.Forms.Label();
            this.btnAddPlayer = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grpStats = new System.Windows.Forms.GroupBox();
            this.txtLoses = new System.Windows.Forms.TextBox();
            this.lblLoses = new System.Windows.Forms.Label();
            this.txtWins = new System.Windows.Forms.TextBox();
            this.lblWins = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.slblImagePath = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayerImage)).BeginInit();
            this.grpPlayer.SuspendLayout();
            this.grpAbility.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSpin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbService)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBackhand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbForehand)).BeginInit();
            this.grpStats.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPlayerID
            // 
            this.lblPlayerID.AutoSize = true;
            this.lblPlayerID.Location = new System.Drawing.Point(225, 40);
            this.lblPlayerID.Name = "lblPlayerID";
            this.lblPlayerID.Size = new System.Drawing.Size(87, 23);
            this.lblPlayerID.TabIndex = 0;
            this.lblPlayerID.Text = "Player ID:";
            // 
            // txtPlayerName
            // 
            this.txtPlayerName.Location = new System.Drawing.Point(318, 87);
            this.txtPlayerName.Name = "txtPlayerName";
            this.txtPlayerName.Size = new System.Drawing.Size(177, 30);
            this.txtPlayerName.TabIndex = 1;
            // 
            // pbPlayerImage
            // 
            this.pbPlayerImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbPlayerImage.Image = global::TableTennisDatabase.Properties.Resources.Player;
            this.pbPlayerImage.Location = new System.Drawing.Point(21, 33);
            this.pbPlayerImage.Name = "pbPlayerImage";
            this.pbPlayerImage.Size = new System.Drawing.Size(140, 152);
            this.pbPlayerImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPlayerImage.TabIndex = 2;
            this.pbPlayerImage.TabStop = false;
            // 
            // btnAddImage
            // 
            this.btnAddImage.Location = new System.Drawing.Point(21, 191);
            this.btnAddImage.Name = "btnAddImage";
            this.btnAddImage.Size = new System.Drawing.Size(140, 34);
            this.btnAddImage.TabIndex = 3;
            this.btnAddImage.Text = "Add Image";
            this.btnAddImage.UseVisualStyleBackColor = true;
            this.btnAddImage.Click += new System.EventHandler(this.btnAddImage_Click);
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.AutoSize = true;
            this.lblPlayerName.Location = new System.Drawing.Point(206, 94);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(106, 23);
            this.lblPlayerName.TabIndex = 4;
            this.lblPlayerName.Text = "Player Name:";
            // 
            // mtxtPlayerID
            // 
            this.mtxtPlayerID.Location = new System.Drawing.Point(318, 33);
            this.mtxtPlayerID.Mask = "000000";
            this.mtxtPlayerID.Name = "mtxtPlayerID";
            this.mtxtPlayerID.Size = new System.Drawing.Size(177, 30);
            this.mtxtPlayerID.TabIndex = 5;
            this.mtxtPlayerID.ValidatingType = typeof(int);
            // 
            // mtxtPlayerAge
            // 
            this.mtxtPlayerAge.Location = new System.Drawing.Point(318, 141);
            this.mtxtPlayerAge.Mask = "00";
            this.mtxtPlayerAge.Name = "mtxtPlayerAge";
            this.mtxtPlayerAge.Size = new System.Drawing.Size(177, 30);
            this.mtxtPlayerAge.TabIndex = 6;
            this.mtxtPlayerAge.ValidatingType = typeof(int);
            // 
            // lblPlayerAge
            // 
            this.lblPlayerAge.AutoSize = true;
            this.lblPlayerAge.Location = new System.Drawing.Point(218, 148);
            this.lblPlayerAge.Name = "lblPlayerAge";
            this.lblPlayerAge.Size = new System.Drawing.Size(94, 23);
            this.lblPlayerAge.TabIndex = 7;
            this.lblPlayerAge.Text = "Player Age:";
            // 
            // grpPlayer
            // 
            this.grpPlayer.BackColor = System.Drawing.Color.White;
            this.grpPlayer.Controls.Add(this.cmbCountry);
            this.grpPlayer.Controls.Add(this.lblCountry);
            this.grpPlayer.Controls.Add(this.pbPlayerImage);
            this.grpPlayer.Controls.Add(this.lblPlayerAge);
            this.grpPlayer.Controls.Add(this.lblPlayerID);
            this.grpPlayer.Controls.Add(this.mtxtPlayerAge);
            this.grpPlayer.Controls.Add(this.txtPlayerName);
            this.grpPlayer.Controls.Add(this.mtxtPlayerID);
            this.grpPlayer.Controls.Add(this.btnAddImage);
            this.grpPlayer.Controls.Add(this.lblPlayerName);
            this.grpPlayer.Location = new System.Drawing.Point(12, 12);
            this.grpPlayer.Name = "grpPlayer";
            this.grpPlayer.Size = new System.Drawing.Size(521, 250);
            this.grpPlayer.TabIndex = 8;
            this.grpPlayer.TabStop = false;
            this.grpPlayer.Text = "Player";
            // 
            // cmbCountry
            // 
            this.cmbCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCountry.FormattingEnabled = true;
            this.cmbCountry.Items.AddRange(new object[] {
            "CHINA",
            "BRAZIL",
            "GERMANY",
            "JAPAN",
            "ENGLAND",
            "TURKEY",
            "FRANCE"});
            this.cmbCountry.Location = new System.Drawing.Point(318, 194);
            this.cmbCountry.Name = "cmbCountry";
            this.cmbCountry.Size = new System.Drawing.Size(177, 31);
            this.cmbCountry.TabIndex = 9;
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(239, 202);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(73, 23);
            this.lblCountry.TabIndex = 8;
            this.lblCountry.Text = "Country:";
            // 
            // grpAbility
            // 
            this.grpAbility.BackColor = System.Drawing.Color.White;
            this.grpAbility.Controls.Add(this.pbSpeed);
            this.grpAbility.Controls.Add(this.txtSpeed);
            this.grpAbility.Controls.Add(this.lblSpeed);
            this.grpAbility.Controls.Add(this.pbSpin);
            this.grpAbility.Controls.Add(this.txtSpin);
            this.grpAbility.Controls.Add(this.lblSpin);
            this.grpAbility.Controls.Add(this.pbService);
            this.grpAbility.Controls.Add(this.txtService);
            this.grpAbility.Controls.Add(this.lblService);
            this.grpAbility.Controls.Add(this.pbBackhand);
            this.grpAbility.Controls.Add(this.txtBackhand);
            this.grpAbility.Controls.Add(this.lblBackhand);
            this.grpAbility.Controls.Add(this.pbForehand);
            this.grpAbility.Controls.Add(this.txtForehand);
            this.grpAbility.Controls.Add(this.lblForehand);
            this.grpAbility.Location = new System.Drawing.Point(12, 272);
            this.grpAbility.Name = "grpAbility";
            this.grpAbility.Size = new System.Drawing.Size(521, 159);
            this.grpAbility.TabIndex = 9;
            this.grpAbility.TabStop = false;
            this.grpAbility.Text = "Ability";
            // 
            // pbSpeed
            // 
            this.pbSpeed.Image = ((System.Drawing.Image)(resources.GetObject("pbSpeed.Image")));
            this.pbSpeed.Location = new System.Drawing.Point(296, 87);
            this.pbSpeed.Name = "pbSpeed";
            this.pbSpeed.Size = new System.Drawing.Size(30, 30);
            this.pbSpeed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSpeed.TabIndex = 18;
            this.pbSpeed.TabStop = false;
            // 
            // txtSpeed
            // 
            this.txtSpeed.Location = new System.Drawing.Point(425, 87);
            this.txtSpeed.Name = "txtSpeed";
            this.txtSpeed.Size = new System.Drawing.Size(69, 30);
            this.txtSpeed.TabIndex = 17;
            this.txtSpeed.Text = "0";
            this.txtSpeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSpeed.Click += new System.EventHandler(this.txtForehand_Click);
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Location = new System.Drawing.Point(341, 90);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(60, 23);
            this.lblSpeed.TabIndex = 16;
            this.lblSpeed.Text = "Speed:";
            // 
            // pbSpin
            // 
            this.pbSpin.Image = ((System.Drawing.Image)(resources.GetObject("pbSpin.Image")));
            this.pbSpin.Location = new System.Drawing.Point(296, 51);
            this.pbSpin.Name = "pbSpin";
            this.pbSpin.Size = new System.Drawing.Size(30, 30);
            this.pbSpin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSpin.TabIndex = 15;
            this.pbSpin.TabStop = false;
            // 
            // txtSpin
            // 
            this.txtSpin.Location = new System.Drawing.Point(425, 51);
            this.txtSpin.Name = "txtSpin";
            this.txtSpin.Size = new System.Drawing.Size(69, 30);
            this.txtSpin.TabIndex = 14;
            this.txtSpin.Text = "0";
            this.txtSpin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSpin.Click += new System.EventHandler(this.txtForehand_Click);
            // 
            // lblSpin
            // 
            this.lblSpin.AutoSize = true;
            this.lblSpin.Location = new System.Drawing.Point(341, 54);
            this.lblSpin.Name = "lblSpin";
            this.lblSpin.Size = new System.Drawing.Size(48, 23);
            this.lblSpin.TabIndex = 13;
            this.lblSpin.Text = "Spin:";
            // 
            // pbService
            // 
            this.pbService.Image = ((System.Drawing.Image)(resources.GetObject("pbService.Image")));
            this.pbService.Location = new System.Drawing.Point(35, 107);
            this.pbService.Name = "pbService";
            this.pbService.Size = new System.Drawing.Size(30, 30);
            this.pbService.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbService.TabIndex = 12;
            this.pbService.TabStop = false;
            // 
            // txtService
            // 
            this.txtService.Location = new System.Drawing.Point(164, 107);
            this.txtService.Name = "txtService";
            this.txtService.Size = new System.Drawing.Size(69, 30);
            this.txtService.TabIndex = 11;
            this.txtService.Text = "0";
            this.txtService.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtService.Click += new System.EventHandler(this.txtForehand_Click);
            // 
            // lblService
            // 
            this.lblService.AutoSize = true;
            this.lblService.Location = new System.Drawing.Point(87, 110);
            this.lblService.Name = "lblService";
            this.lblService.Size = new System.Drawing.Size(71, 23);
            this.lblService.TabIndex = 10;
            this.lblService.Text = "Service:";
            // 
            // pbBackhand
            // 
            this.pbBackhand.Image = ((System.Drawing.Image)(resources.GetObject("pbBackhand.Image")));
            this.pbBackhand.Location = new System.Drawing.Point(35, 71);
            this.pbBackhand.Name = "pbBackhand";
            this.pbBackhand.Size = new System.Drawing.Size(30, 30);
            this.pbBackhand.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBackhand.TabIndex = 9;
            this.pbBackhand.TabStop = false;
            // 
            // txtBackhand
            // 
            this.txtBackhand.Location = new System.Drawing.Point(164, 71);
            this.txtBackhand.Name = "txtBackhand";
            this.txtBackhand.Size = new System.Drawing.Size(69, 30);
            this.txtBackhand.TabIndex = 8;
            this.txtBackhand.Text = "0";
            this.txtBackhand.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBackhand.Click += new System.EventHandler(this.txtForehand_Click);
            // 
            // lblBackhand
            // 
            this.lblBackhand.AutoSize = true;
            this.lblBackhand.Location = new System.Drawing.Point(77, 74);
            this.lblBackhand.Name = "lblBackhand";
            this.lblBackhand.Size = new System.Drawing.Size(83, 23);
            this.lblBackhand.TabIndex = 7;
            this.lblBackhand.Text = "Backhand:";
            // 
            // pbForehand
            // 
            this.pbForehand.Image = ((System.Drawing.Image)(resources.GetObject("pbForehand.Image")));
            this.pbForehand.Location = new System.Drawing.Point(35, 35);
            this.pbForehand.Name = "pbForehand";
            this.pbForehand.Size = new System.Drawing.Size(30, 30);
            this.pbForehand.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbForehand.TabIndex = 3;
            this.pbForehand.TabStop = false;
            // 
            // txtForehand
            // 
            this.txtForehand.Location = new System.Drawing.Point(164, 35);
            this.txtForehand.Name = "txtForehand";
            this.txtForehand.Size = new System.Drawing.Size(69, 30);
            this.txtForehand.TabIndex = 2;
            this.txtForehand.Text = "0";
            this.txtForehand.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtForehand.Click += new System.EventHandler(this.txtForehand_Click);
            // 
            // lblForehand
            // 
            this.lblForehand.AutoSize = true;
            this.lblForehand.Location = new System.Drawing.Point(76, 38);
            this.lblForehand.Name = "lblForehand";
            this.lblForehand.Size = new System.Drawing.Size(82, 23);
            this.lblForehand.TabIndex = 0;
            this.lblForehand.Text = "Forehand:";
            // 
            // btnAddPlayer
            // 
            this.btnAddPlayer.BackColor = System.Drawing.Color.Lime;
            this.btnAddPlayer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddPlayer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddPlayer.Location = new System.Drawing.Point(407, 533);
            this.btnAddPlayer.Name = "btnAddPlayer";
            this.btnAddPlayer.Size = new System.Drawing.Size(125, 39);
            this.btnAddPlayer.TabIndex = 10;
            this.btnAddPlayer.Text = "Add Player";
            this.btnAddPlayer.UseVisualStyleBackColor = false;
            this.btnAddPlayer.Click += new System.EventHandler(this.btnAddPlayer_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(276, 533);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(125, 39);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // grpStats
            // 
            this.grpStats.BackColor = System.Drawing.Color.White;
            this.grpStats.Controls.Add(this.txtLoses);
            this.grpStats.Controls.Add(this.lblLoses);
            this.grpStats.Controls.Add(this.txtWins);
            this.grpStats.Controls.Add(this.lblWins);
            this.grpStats.Location = new System.Drawing.Point(12, 442);
            this.grpStats.Name = "grpStats";
            this.grpStats.Size = new System.Drawing.Size(521, 69);
            this.grpStats.TabIndex = 12;
            this.grpStats.TabStop = false;
            this.grpStats.Text = "Stats";
            // 
            // txtLoses
            // 
            this.txtLoses.Location = new System.Drawing.Point(369, 23);
            this.txtLoses.Name = "txtLoses";
            this.txtLoses.Size = new System.Drawing.Size(69, 30);
            this.txtLoses.TabIndex = 22;
            this.txtLoses.Text = "0";
            this.txtLoses.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtLoses.Click += new System.EventHandler(this.txtForehand_Click);
            // 
            // lblLoses
            // 
            this.lblLoses.AutoSize = true;
            this.lblLoses.Location = new System.Drawing.Point(292, 26);
            this.lblLoses.Name = "lblLoses";
            this.lblLoses.Size = new System.Drawing.Size(54, 23);
            this.lblLoses.TabIndex = 21;
            this.lblLoses.Text = "Loses:";
            // 
            // txtWins
            // 
            this.txtWins.Location = new System.Drawing.Point(153, 23);
            this.txtWins.Name = "txtWins";
            this.txtWins.Size = new System.Drawing.Size(69, 30);
            this.txtWins.TabIndex = 20;
            this.txtWins.Text = "0";
            this.txtWins.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtWins.Click += new System.EventHandler(this.txtForehand_Click);
            // 
            // lblWins
            // 
            this.lblWins.AutoSize = true;
            this.lblWins.Location = new System.Drawing.Point(76, 26);
            this.lblWins.Name = "lblWins";
            this.lblWins.Size = new System.Drawing.Size(52, 23);
            this.lblWins.TabIndex = 19;
            this.lblWins.Text = "Wins:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Transparent;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.slblImagePath});
            this.statusStrip1.Location = new System.Drawing.Point(0, 583);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(545, 22);
            this.statusStrip1.TabIndex = 13;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // slblImagePath
            // 
            this.slblImagePath.Name = "slblImagePath";
            this.slblImagePath.Size = new System.Drawing.Size(0, 17);
            // 
            // NewPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(545, 605);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.grpStats);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddPlayer);
            this.Controls.Add(this.grpAbility);
            this.Controls.Add(this.grpPlayer);
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "NewPlayer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Player";
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayerImage)).EndInit();
            this.grpPlayer.ResumeLayout(false);
            this.grpPlayer.PerformLayout();
            this.grpAbility.ResumeLayout(false);
            this.grpAbility.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSpin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbService)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBackhand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbForehand)).EndInit();
            this.grpStats.ResumeLayout(false);
            this.grpStats.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPlayerID;
        private System.Windows.Forms.TextBox txtPlayerName;
        private System.Windows.Forms.PictureBox pbPlayerImage;
        private System.Windows.Forms.Button btnAddImage;
        private System.Windows.Forms.Label lblPlayerName;
        private System.Windows.Forms.MaskedTextBox mtxtPlayerID;
        private System.Windows.Forms.MaskedTextBox mtxtPlayerAge;
        private System.Windows.Forms.Label lblPlayerAge;
        private System.Windows.Forms.GroupBox grpPlayer;
        private System.Windows.Forms.ComboBox cmbCountry;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.GroupBox grpAbility;
        private System.Windows.Forms.Label lblForehand;
        private System.Windows.Forms.PictureBox pbForehand;
        private System.Windows.Forms.TextBox txtForehand;
        private System.Windows.Forms.PictureBox pbSpeed;
        private System.Windows.Forms.TextBox txtSpeed;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.PictureBox pbSpin;
        private System.Windows.Forms.TextBox txtSpin;
        private System.Windows.Forms.Label lblSpin;
        private System.Windows.Forms.PictureBox pbService;
        private System.Windows.Forms.TextBox txtService;
        private System.Windows.Forms.Label lblService;
        private System.Windows.Forms.PictureBox pbBackhand;
        private System.Windows.Forms.TextBox txtBackhand;
        private System.Windows.Forms.Label lblBackhand;
        private System.Windows.Forms.Button btnAddPlayer;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox grpStats;
        private System.Windows.Forms.TextBox txtLoses;
        private System.Windows.Forms.Label lblLoses;
        private System.Windows.Forms.TextBox txtWins;
        private System.Windows.Forms.Label lblWins;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel slblImagePath;
    }
}