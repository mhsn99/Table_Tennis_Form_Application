namespace TableTennisDatabase
{
    partial class EditPlayer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditPlayer));
            this.lblSelectFor = new System.Windows.Forms.Label();
            this.cmbEdit = new System.Windows.Forms.ComboBox();
            this.grpPlayerInfo = new System.Windows.Forms.GroupBox();
            this.txtPlayerName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.btnAddImage = new System.Windows.Forms.Button();
            this.pbPlayerImage = new System.Windows.Forms.PictureBox();
            this.cmbCountry = new System.Windows.Forms.ComboBox();
            this.txtPlayerID = new System.Windows.Forms.TextBox();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblPlayerId = new System.Windows.Forms.Label();
            this.lblPlayerAge = new System.Windows.Forms.Label();
            this.txtPlayerAge = new System.Windows.Forms.MaskedTextBox();
            this.lblEnterPlayerName = new System.Windows.Forms.Label();
            this.grpEdit = new System.Windows.Forms.GroupBox();
            this.cmbPlayerName = new System.Windows.Forms.ComboBox();
            this.btnGetPlayerInfo = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnApply = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.slblImagePath = new System.Windows.Forms.ToolStripStatusLabel();
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
            this.pbPlayerImage2 = new System.Windows.Forms.PictureBox();
            this.lblPlayerInfo = new System.Windows.Forms.Label();
            this.prgForehand = new System.Windows.Forms.ProgressBar();
            this.prgBackhand = new System.Windows.Forms.ProgressBar();
            this.prgService = new System.Windows.Forms.ProgressBar();
            this.prgSpin = new System.Windows.Forms.ProgressBar();
            this.prgSpeed = new System.Windows.Forms.ProgressBar();
            this.grpPlayerInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayerImage)).BeginInit();
            this.grpEdit.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.grpAbility.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSpin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbService)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBackhand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbForehand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayerImage2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSelectFor
            // 
            this.lblSelectFor.AutoSize = true;
            this.lblSelectFor.Location = new System.Drawing.Point(32, 24);
            this.lblSelectFor.Name = "lblSelectFor";
            this.lblSelectFor.Size = new System.Drawing.Size(93, 23);
            this.lblSelectFor.TabIndex = 0;
            this.lblSelectFor.Text = "Select For:";
            // 
            // cmbEdit
            // 
            this.cmbEdit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEdit.FormattingEnabled = true;
            this.cmbEdit.Items.AddRange(new object[] {
            "Delete Player",
            "Update Player",
            "Update Ability"});
            this.cmbEdit.Location = new System.Drawing.Point(151, 21);
            this.cmbEdit.Name = "cmbEdit";
            this.cmbEdit.Size = new System.Drawing.Size(164, 31);
            this.cmbEdit.TabIndex = 1;
            // 
            // grpPlayerInfo
            // 
            this.grpPlayerInfo.BackColor = System.Drawing.Color.White;
            this.grpPlayerInfo.Controls.Add(this.txtPlayerName);
            this.grpPlayerInfo.Controls.Add(this.lblName);
            this.grpPlayerInfo.Controls.Add(this.btnAddImage);
            this.grpPlayerInfo.Controls.Add(this.pbPlayerImage);
            this.grpPlayerInfo.Controls.Add(this.cmbCountry);
            this.grpPlayerInfo.Controls.Add(this.txtPlayerID);
            this.grpPlayerInfo.Controls.Add(this.lblCountry);
            this.grpPlayerInfo.Controls.Add(this.lblPlayerId);
            this.grpPlayerInfo.Controls.Add(this.lblPlayerAge);
            this.grpPlayerInfo.Controls.Add(this.txtPlayerAge);
            this.grpPlayerInfo.Location = new System.Drawing.Point(13, 163);
            this.grpPlayerInfo.Name = "grpPlayerInfo";
            this.grpPlayerInfo.Size = new System.Drawing.Size(331, 355);
            this.grpPlayerInfo.TabIndex = 2;
            this.grpPlayerInfo.TabStop = false;
            this.grpPlayerInfo.Text = "PlayerInfo";
            // 
            // txtPlayerName
            // 
            this.txtPlayerName.Enabled = false;
            this.txtPlayerName.Location = new System.Drawing.Point(138, 208);
            this.txtPlayerName.Name = "txtPlayerName";
            this.txtPlayerName.Size = new System.Drawing.Size(177, 30);
            this.txtPlayerName.TabIndex = 15;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(26, 215);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(106, 23);
            this.lblName.TabIndex = 16;
            this.lblName.Text = "Player Name:";
            // 
            // btnAddImage
            // 
            this.btnAddImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddImage.Location = new System.Drawing.Point(162, 105);
            this.btnAddImage.Name = "btnAddImage";
            this.btnAddImage.Size = new System.Drawing.Size(125, 39);
            this.btnAddImage.TabIndex = 14;
            this.btnAddImage.Text = "New Image";
            this.btnAddImage.UseVisualStyleBackColor = true;
            this.btnAddImage.Click += new System.EventHandler(this.btnAddImage_Click);
            // 
            // pbPlayerImage
            // 
            this.pbPlayerImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbPlayerImage.Location = new System.Drawing.Point(30, 29);
            this.pbPlayerImage.Name = "pbPlayerImage";
            this.pbPlayerImage.Size = new System.Drawing.Size(115, 115);
            this.pbPlayerImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPlayerImage.TabIndex = 16;
            this.pbPlayerImage.TabStop = false;
            // 
            // cmbCountry
            // 
            this.cmbCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCountry.Enabled = false;
            this.cmbCountry.FormattingEnabled = true;
            this.cmbCountry.Items.AddRange(new object[] {
            "CHINA",
            "BRAZIL",
            "GERMANY",
            "JAPAN",
            "ENGLAND",
            "TURKEY",
            "FRANCE"});
            this.cmbCountry.Location = new System.Drawing.Point(138, 304);
            this.cmbCountry.Name = "cmbCountry";
            this.cmbCountry.Size = new System.Drawing.Size(177, 31);
            this.cmbCountry.TabIndex = 15;
            // 
            // txtPlayerID
            // 
            this.txtPlayerID.Enabled = false;
            this.txtPlayerID.Location = new System.Drawing.Point(138, 164);
            this.txtPlayerID.Name = "txtPlayerID";
            this.txtPlayerID.Size = new System.Drawing.Size(177, 30);
            this.txtPlayerID.TabIndex = 10;
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(59, 312);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(73, 23);
            this.lblCountry.TabIndex = 14;
            this.lblCountry.Text = "Country:";
            // 
            // lblPlayerId
            // 
            this.lblPlayerId.AutoSize = true;
            this.lblPlayerId.Location = new System.Drawing.Point(26, 171);
            this.lblPlayerId.Name = "lblPlayerId";
            this.lblPlayerId.Size = new System.Drawing.Size(87, 23);
            this.lblPlayerId.TabIndex = 11;
            this.lblPlayerId.Text = "Player ID:";
            // 
            // lblPlayerAge
            // 
            this.lblPlayerAge.AutoSize = true;
            this.lblPlayerAge.Location = new System.Drawing.Point(38, 259);
            this.lblPlayerAge.Name = "lblPlayerAge";
            this.lblPlayerAge.Size = new System.Drawing.Size(94, 23);
            this.lblPlayerAge.TabIndex = 13;
            this.lblPlayerAge.Text = "Player Age:";
            // 
            // txtPlayerAge
            // 
            this.txtPlayerAge.Enabled = false;
            this.txtPlayerAge.Location = new System.Drawing.Point(138, 252);
            this.txtPlayerAge.Mask = "00";
            this.txtPlayerAge.Name = "txtPlayerAge";
            this.txtPlayerAge.Size = new System.Drawing.Size(177, 30);
            this.txtPlayerAge.TabIndex = 12;
            this.txtPlayerAge.ValidatingType = typeof(int);
            // 
            // lblEnterPlayerName
            // 
            this.lblEnterPlayerName.AutoSize = true;
            this.lblEnterPlayerName.Location = new System.Drawing.Point(12, 68);
            this.lblEnterPlayerName.Name = "lblEnterPlayerName";
            this.lblEnterPlayerName.Size = new System.Drawing.Size(113, 23);
            this.lblEnterPlayerName.TabIndex = 3;
            this.lblEnterPlayerName.Text = "Select Player:";
            // 
            // grpEdit
            // 
            this.grpEdit.BackColor = System.Drawing.Color.White;
            this.grpEdit.Controls.Add(this.cmbPlayerName);
            this.grpEdit.Controls.Add(this.btnGetPlayerInfo);
            this.grpEdit.Controls.Add(this.cmbEdit);
            this.grpEdit.Controls.Add(this.lblSelectFor);
            this.grpEdit.Controls.Add(this.lblEnterPlayerName);
            this.grpEdit.Location = new System.Drawing.Point(13, 13);
            this.grpEdit.Name = "grpEdit";
            this.grpEdit.Size = new System.Drawing.Size(330, 144);
            this.grpEdit.TabIndex = 5;
            this.grpEdit.TabStop = false;
            this.grpEdit.Text = "Edit";
            // 
            // cmbPlayerName
            // 
            this.cmbPlayerName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPlayerName.FormattingEnabled = true;
            this.cmbPlayerName.Location = new System.Drawing.Point(151, 58);
            this.cmbPlayerName.Name = "cmbPlayerName";
            this.cmbPlayerName.Size = new System.Drawing.Size(164, 31);
            this.cmbPlayerName.TabIndex = 18;
            // 
            // btnGetPlayerInfo
            // 
            this.btnGetPlayerInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGetPlayerInfo.Location = new System.Drawing.Point(151, 99);
            this.btnGetPlayerInfo.Name = "btnGetPlayerInfo";
            this.btnGetPlayerInfo.Size = new System.Drawing.Size(164, 39);
            this.btnGetPlayerInfo.TabIndex = 17;
            this.btnGetPlayerInfo.Text = "Get Player Data";
            this.btnGetPlayerInfo.UseVisualStyleBackColor = true;
            this.btnGetPlayerInfo.Click += new System.EventHandler(this.btnGetPlayerInfo_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(87, 524);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(125, 39);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnApply
            // 
            this.btnApply.BackColor = System.Drawing.Color.Lime;
            this.btnApply.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnApply.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnApply.Location = new System.Drawing.Point(218, 524);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(125, 39);
            this.btnApply.TabIndex = 12;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = false;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Transparent;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.slblImagePath});
            this.statusStrip1.Location = new System.Drawing.Point(0, 572);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(358, 22);
            this.statusStrip1.TabIndex = 14;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // slblImagePath
            // 
            this.slblImagePath.Name = "slblImagePath";
            this.slblImagePath.Size = new System.Drawing.Size(0, 17);
            // 
            // grpAbility
            // 
            this.grpAbility.BackColor = System.Drawing.Color.White;
            this.grpAbility.Controls.Add(this.prgSpeed);
            this.grpAbility.Controls.Add(this.prgSpin);
            this.grpAbility.Controls.Add(this.prgService);
            this.grpAbility.Controls.Add(this.prgBackhand);
            this.grpAbility.Controls.Add(this.prgForehand);
            this.grpAbility.Controls.Add(this.lblPlayerInfo);
            this.grpAbility.Controls.Add(this.pbPlayerImage2);
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
            this.grpAbility.Location = new System.Drawing.Point(13, 163);
            this.grpAbility.Name = "grpAbility";
            this.grpAbility.Size = new System.Drawing.Size(331, 355);
            this.grpAbility.TabIndex = 17;
            this.grpAbility.TabStop = false;
            this.grpAbility.Text = "Ability";
            // 
            // pbSpeed
            // 
            this.pbSpeed.Image = ((System.Drawing.Image)(resources.GetObject("pbSpeed.Image")));
            this.pbSpeed.Location = new System.Drawing.Point(16, 303);
            this.pbSpeed.Name = "pbSpeed";
            this.pbSpeed.Size = new System.Drawing.Size(30, 30);
            this.pbSpeed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSpeed.TabIndex = 33;
            this.pbSpeed.TabStop = false;
            // 
            // txtSpeed
            // 
            this.txtSpeed.Location = new System.Drawing.Point(246, 303);
            this.txtSpeed.Name = "txtSpeed";
            this.txtSpeed.Size = new System.Drawing.Size(69, 30);
            this.txtSpeed.TabIndex = 32;
            this.txtSpeed.Text = "0";
            this.txtSpeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSpeed.Click += new System.EventHandler(this.AbilityTextClick);
            this.txtSpeed.TextChanged += new System.EventHandler(this.AbilityTextChange);
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Location = new System.Drawing.Point(72, 310);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(60, 23);
            this.lblSpeed.TabIndex = 31;
            this.lblSpeed.Text = "Speed:";
            // 
            // pbSpin
            // 
            this.pbSpin.Image = ((System.Drawing.Image)(resources.GetObject("pbSpin.Image")));
            this.pbSpin.Location = new System.Drawing.Point(16, 267);
            this.pbSpin.Name = "pbSpin";
            this.pbSpin.Size = new System.Drawing.Size(30, 30);
            this.pbSpin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSpin.TabIndex = 30;
            this.pbSpin.TabStop = false;
            // 
            // txtSpin
            // 
            this.txtSpin.Location = new System.Drawing.Point(246, 267);
            this.txtSpin.Name = "txtSpin";
            this.txtSpin.Size = new System.Drawing.Size(69, 30);
            this.txtSpin.TabIndex = 29;
            this.txtSpin.Text = "0";
            this.txtSpin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSpin.Click += new System.EventHandler(this.AbilityTextClick);
            this.txtSpin.TextChanged += new System.EventHandler(this.AbilityTextChange);
            // 
            // lblSpin
            // 
            this.lblSpin.AutoSize = true;
            this.lblSpin.Location = new System.Drawing.Point(84, 274);
            this.lblSpin.Name = "lblSpin";
            this.lblSpin.Size = new System.Drawing.Size(48, 23);
            this.lblSpin.TabIndex = 28;
            this.lblSpin.Text = "Spin:";
            // 
            // pbService
            // 
            this.pbService.Image = ((System.Drawing.Image)(resources.GetObject("pbService.Image")));
            this.pbService.Location = new System.Drawing.Point(16, 231);
            this.pbService.Name = "pbService";
            this.pbService.Size = new System.Drawing.Size(30, 30);
            this.pbService.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbService.TabIndex = 27;
            this.pbService.TabStop = false;
            // 
            // txtService
            // 
            this.txtService.Location = new System.Drawing.Point(246, 231);
            this.txtService.Name = "txtService";
            this.txtService.Size = new System.Drawing.Size(69, 30);
            this.txtService.TabIndex = 26;
            this.txtService.Text = "0";
            this.txtService.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtService.Click += new System.EventHandler(this.AbilityTextClick);
            this.txtService.TextChanged += new System.EventHandler(this.AbilityTextChange);
            // 
            // lblService
            // 
            this.lblService.AutoSize = true;
            this.lblService.Location = new System.Drawing.Point(61, 238);
            this.lblService.Name = "lblService";
            this.lblService.Size = new System.Drawing.Size(71, 23);
            this.lblService.TabIndex = 25;
            this.lblService.Text = "Service:";
            // 
            // pbBackhand
            // 
            this.pbBackhand.Image = ((System.Drawing.Image)(resources.GetObject("pbBackhand.Image")));
            this.pbBackhand.Location = new System.Drawing.Point(16, 195);
            this.pbBackhand.Name = "pbBackhand";
            this.pbBackhand.Size = new System.Drawing.Size(30, 30);
            this.pbBackhand.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBackhand.TabIndex = 24;
            this.pbBackhand.TabStop = false;
            // 
            // txtBackhand
            // 
            this.txtBackhand.Location = new System.Drawing.Point(246, 195);
            this.txtBackhand.Name = "txtBackhand";
            this.txtBackhand.Size = new System.Drawing.Size(69, 30);
            this.txtBackhand.TabIndex = 23;
            this.txtBackhand.Text = "0";
            this.txtBackhand.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBackhand.Click += new System.EventHandler(this.AbilityTextClick);
            this.txtBackhand.TextChanged += new System.EventHandler(this.AbilityTextChange);
            // 
            // lblBackhand
            // 
            this.lblBackhand.AutoSize = true;
            this.lblBackhand.Location = new System.Drawing.Point(49, 202);
            this.lblBackhand.Name = "lblBackhand";
            this.lblBackhand.Size = new System.Drawing.Size(83, 23);
            this.lblBackhand.TabIndex = 22;
            this.lblBackhand.Text = "Backhand:";
            // 
            // pbForehand
            // 
            this.pbForehand.Image = ((System.Drawing.Image)(resources.GetObject("pbForehand.Image")));
            this.pbForehand.Location = new System.Drawing.Point(16, 159);
            this.pbForehand.Name = "pbForehand";
            this.pbForehand.Size = new System.Drawing.Size(30, 30);
            this.pbForehand.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbForehand.TabIndex = 21;
            this.pbForehand.TabStop = false;
            // 
            // txtForehand
            // 
            this.txtForehand.Location = new System.Drawing.Point(246, 159);
            this.txtForehand.Name = "txtForehand";
            this.txtForehand.Size = new System.Drawing.Size(69, 30);
            this.txtForehand.TabIndex = 20;
            this.txtForehand.Text = "0";
            this.txtForehand.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtForehand.Click += new System.EventHandler(this.AbilityTextClick);
            this.txtForehand.TextChanged += new System.EventHandler(this.AbilityTextChange);
            // 
            // lblForehand
            // 
            this.lblForehand.AutoSize = true;
            this.lblForehand.Location = new System.Drawing.Point(50, 166);
            this.lblForehand.Name = "lblForehand";
            this.lblForehand.Size = new System.Drawing.Size(82, 23);
            this.lblForehand.TabIndex = 19;
            this.lblForehand.Text = "Forehand:";
            // 
            // pbPlayerImage2
            // 
            this.pbPlayerImage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbPlayerImage2.Location = new System.Drawing.Point(223, 29);
            this.pbPlayerImage2.Name = "pbPlayerImage2";
            this.pbPlayerImage2.Size = new System.Drawing.Size(92, 92);
            this.pbPlayerImage2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPlayerImage2.TabIndex = 34;
            this.pbPlayerImage2.TabStop = false;
            // 
            // lblPlayerInfo
            // 
            this.lblPlayerInfo.AutoSize = true;
            this.lblPlayerInfo.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPlayerInfo.ForeColor = System.Drawing.Color.Black;
            this.lblPlayerInfo.Location = new System.Drawing.Point(20, 29);
            this.lblPlayerInfo.Name = "lblPlayerInfo";
            this.lblPlayerInfo.Size = new System.Drawing.Size(118, 92);
            this.lblPlayerInfo.TabIndex = 35;
            this.lblPlayerInfo.Text = "Player ID - \r\nPlayer Name - \r\nAge - \r\nCountry ";
            // 
            // prgForehand
            // 
            this.prgForehand.Location = new System.Drawing.Point(138, 159);
            this.prgForehand.Name = "prgForehand";
            this.prgForehand.Size = new System.Drawing.Size(100, 30);
            this.prgForehand.TabIndex = 36;
            // 
            // prgBackhand
            // 
            this.prgBackhand.Location = new System.Drawing.Point(138, 195);
            this.prgBackhand.Name = "prgBackhand";
            this.prgBackhand.Size = new System.Drawing.Size(100, 30);
            this.prgBackhand.TabIndex = 37;
            // 
            // prgService
            // 
            this.prgService.Location = new System.Drawing.Point(138, 231);
            this.prgService.Name = "prgService";
            this.prgService.Size = new System.Drawing.Size(100, 30);
            this.prgService.TabIndex = 38;
            // 
            // prgSpin
            // 
            this.prgSpin.Location = new System.Drawing.Point(138, 267);
            this.prgSpin.Name = "prgSpin";
            this.prgSpin.Size = new System.Drawing.Size(100, 30);
            this.prgSpin.TabIndex = 39;
            // 
            // prgSpeed
            // 
            this.prgSpeed.Location = new System.Drawing.Point(138, 303);
            this.prgSpeed.Name = "prgSpeed";
            this.prgSpeed.Size = new System.Drawing.Size(100, 30);
            this.prgSpeed.TabIndex = 40;
            // 
            // EditPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(358, 594);
            this.Controls.Add(this.grpAbility);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.grpEdit);
            this.Controls.Add(this.grpPlayerInfo);
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "EditPlayer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditPlayer";
            this.Load += new System.EventHandler(this.EditPlayer_Load);
            this.grpPlayerInfo.ResumeLayout(false);
            this.grpPlayerInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayerImage)).EndInit();
            this.grpEdit.ResumeLayout(false);
            this.grpEdit.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.grpAbility.ResumeLayout(false);
            this.grpAbility.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSpin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbService)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBackhand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbForehand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayerImage2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSelectFor;
        private System.Windows.Forms.ComboBox cmbEdit;
        private System.Windows.Forms.GroupBox grpPlayerInfo;
        private System.Windows.Forms.ComboBox cmbCountry;
        private System.Windows.Forms.TextBox txtPlayerID;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblPlayerId;
        private System.Windows.Forms.Label lblPlayerAge;
        private System.Windows.Forms.MaskedTextBox txtPlayerAge;
        private System.Windows.Forms.Label lblEnterPlayerName;
        private System.Windows.Forms.GroupBox grpEdit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnAddImage;
        private System.Windows.Forms.PictureBox pbPlayerImage;
        private System.Windows.Forms.Button btnGetPlayerInfo;
        private System.Windows.Forms.ComboBox cmbPlayerName;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel slblImagePath;
        private System.Windows.Forms.TextBox txtPlayerName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.GroupBox grpAbility;
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
        private System.Windows.Forms.PictureBox pbForehand;
        private System.Windows.Forms.TextBox txtForehand;
        private System.Windows.Forms.Label lblForehand;
        private System.Windows.Forms.PictureBox pbPlayerImage2;
        private System.Windows.Forms.Label lblPlayerInfo;
        private System.Windows.Forms.ProgressBar prgSpeed;
        private System.Windows.Forms.ProgressBar prgSpin;
        private System.Windows.Forms.ProgressBar prgService;
        private System.Windows.Forms.ProgressBar prgBackhand;
        private System.Windows.Forms.ProgressBar prgForehand;
    }
}