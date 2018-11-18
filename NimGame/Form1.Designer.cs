namespace etf.nim.ma150129d
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.sideMenu = new System.Windows.Forms.Panel();
            this.gameRulesButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.contactButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.aboutButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.statisticsButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.gameSettingsButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.gameBoardButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.menuButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.logo = new System.Windows.Forms.PictureBox();
            this.header = new System.Windows.Forms.Panel();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.logoAnimator = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.panelAnimator = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.gameBoard1 = new etf.nim.ma150129d.GameBoard();
            this.gameSettings1 = new etf.nim.ma150129d.GameSettings();
            this.sideMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 12;
            this.bunifuElipse1.TargetControl = this;
            // 
            // sideMenu
            // 
            this.sideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.sideMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sideMenu.Controls.Add(this.gameRulesButton);
            this.sideMenu.Controls.Add(this.contactButton);
            this.sideMenu.Controls.Add(this.aboutButton);
            this.sideMenu.Controls.Add(this.statisticsButton);
            this.sideMenu.Controls.Add(this.gameSettingsButton);
            this.sideMenu.Controls.Add(this.gameBoardButton);
            this.sideMenu.Controls.Add(this.menuButton);
            this.sideMenu.Controls.Add(this.logo);
            this.panelAnimator.SetDecoration(this.sideMenu, BunifuAnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this.sideMenu, BunifuAnimatorNS.DecorationType.None);
            this.sideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideMenu.Location = new System.Drawing.Point(0, 51);
            this.sideMenu.MaximumSize = new System.Drawing.Size(340, 635);
            this.sideMenu.Name = "sideMenu";
            this.sideMenu.Size = new System.Drawing.Size(340, 635);
            this.sideMenu.TabIndex = 0;
            // 
            // gameRulesButton
            // 
            this.gameRulesButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.gameRulesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.gameRulesButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gameRulesButton.BorderRadius = 0;
            this.gameRulesButton.ButtonText = "            Game rules";
            this.gameRulesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelAnimator.SetDecoration(this.gameRulesButton, BunifuAnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this.gameRulesButton, BunifuAnimatorNS.DecorationType.None);
            this.gameRulesButton.DisabledColor = System.Drawing.Color.Gray;
            this.gameRulesButton.Iconcolor = System.Drawing.Color.Transparent;
            this.gameRulesButton.Iconimage = null;
            this.gameRulesButton.Iconimage_right = null;
            this.gameRulesButton.Iconimage_right_Selected = null;
            this.gameRulesButton.Iconimage_Selected = null;
            this.gameRulesButton.IconMarginLeft = 0;
            this.gameRulesButton.IconMarginRight = 0;
            this.gameRulesButton.IconRightVisible = true;
            this.gameRulesButton.IconRightZoom = 0D;
            this.gameRulesButton.IconVisible = true;
            this.gameRulesButton.IconZoom = 90D;
            this.gameRulesButton.IsTab = true;
            this.gameRulesButton.Location = new System.Drawing.Point(67, 263);
            this.gameRulesButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gameRulesButton.Name = "gameRulesButton";
            this.gameRulesButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.gameRulesButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.gameRulesButton.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.gameRulesButton.selected = false;
            this.gameRulesButton.Size = new System.Drawing.Size(272, 56);
            this.gameRulesButton.TabIndex = 7;
            this.gameRulesButton.Text = "            Game rules";
            this.gameRulesButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gameRulesButton.Textcolor = System.Drawing.Color.Silver;
            this.gameRulesButton.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameRulesButton.Click += new System.EventHandler(this.BunifuFlatButton6_Click);
            // 
            // contactButton
            // 
            this.contactButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.contactButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.contactButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.contactButton.BorderRadius = 0;
            this.contactButton.ButtonText = "            Contact";
            this.contactButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelAnimator.SetDecoration(this.contactButton, BunifuAnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this.contactButton, BunifuAnimatorNS.DecorationType.None);
            this.contactButton.DisabledColor = System.Drawing.Color.Gray;
            this.contactButton.Iconcolor = System.Drawing.Color.Transparent;
            this.contactButton.Iconimage = null;
            this.contactButton.Iconimage_right = null;
            this.contactButton.Iconimage_right_Selected = null;
            this.contactButton.Iconimage_Selected = null;
            this.contactButton.IconMarginLeft = 0;
            this.contactButton.IconMarginRight = 0;
            this.contactButton.IconRightVisible = true;
            this.contactButton.IconRightZoom = 0D;
            this.contactButton.IconVisible = true;
            this.contactButton.IconZoom = 90D;
            this.contactButton.IsTab = true;
            this.contactButton.Location = new System.Drawing.Point(67, 455);
            this.contactButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.contactButton.Name = "contactButton";
            this.contactButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.contactButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.contactButton.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.contactButton.selected = false;
            this.contactButton.Size = new System.Drawing.Size(270, 56);
            this.contactButton.TabIndex = 6;
            this.contactButton.Text = "            Contact";
            this.contactButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.contactButton.Textcolor = System.Drawing.Color.Silver;
            this.contactButton.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactButton.Click += new System.EventHandler(this.ContactButton_Click);
            // 
            // aboutButton
            // 
            this.aboutButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.aboutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.aboutButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.aboutButton.BorderRadius = 0;
            this.aboutButton.ButtonText = "            About author";
            this.aboutButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelAnimator.SetDecoration(this.aboutButton, BunifuAnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this.aboutButton, BunifuAnimatorNS.DecorationType.None);
            this.aboutButton.DisabledColor = System.Drawing.Color.Gray;
            this.aboutButton.Iconcolor = System.Drawing.Color.Transparent;
            this.aboutButton.Iconimage = null;
            this.aboutButton.Iconimage_right = null;
            this.aboutButton.Iconimage_right_Selected = null;
            this.aboutButton.Iconimage_Selected = null;
            this.aboutButton.IconMarginLeft = 0;
            this.aboutButton.IconMarginRight = 0;
            this.aboutButton.IconRightVisible = true;
            this.aboutButton.IconRightZoom = 0D;
            this.aboutButton.IconVisible = true;
            this.aboutButton.IconZoom = 90D;
            this.aboutButton.IsTab = true;
            this.aboutButton.Location = new System.Drawing.Point(67, 391);
            this.aboutButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.aboutButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.aboutButton.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.aboutButton.selected = false;
            this.aboutButton.Size = new System.Drawing.Size(270, 56);
            this.aboutButton.TabIndex = 5;
            this.aboutButton.Text = "            About author";
            this.aboutButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.aboutButton.Textcolor = System.Drawing.Color.Silver;
            this.aboutButton.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutButton.Click += new System.EventHandler(this.AboutButton_Click);
            // 
            // statisticsButton
            // 
            this.statisticsButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.statisticsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.statisticsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.statisticsButton.BorderRadius = 0;
            this.statisticsButton.ButtonText = "            Statistics";
            this.statisticsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelAnimator.SetDecoration(this.statisticsButton, BunifuAnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this.statisticsButton, BunifuAnimatorNS.DecorationType.None);
            this.statisticsButton.DisabledColor = System.Drawing.Color.Gray;
            this.statisticsButton.Iconcolor = System.Drawing.Color.Transparent;
            this.statisticsButton.Iconimage = null;
            this.statisticsButton.Iconimage_right = null;
            this.statisticsButton.Iconimage_right_Selected = null;
            this.statisticsButton.Iconimage_Selected = null;
            this.statisticsButton.IconMarginLeft = 0;
            this.statisticsButton.IconMarginRight = 0;
            this.statisticsButton.IconRightVisible = true;
            this.statisticsButton.IconRightZoom = 0D;
            this.statisticsButton.IconVisible = true;
            this.statisticsButton.IconZoom = 90D;
            this.statisticsButton.IsTab = true;
            this.statisticsButton.Location = new System.Drawing.Point(67, 327);
            this.statisticsButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.statisticsButton.Name = "statisticsButton";
            this.statisticsButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.statisticsButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.statisticsButton.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.statisticsButton.selected = false;
            this.statisticsButton.Size = new System.Drawing.Size(270, 56);
            this.statisticsButton.TabIndex = 4;
            this.statisticsButton.Text = "            Statistics";
            this.statisticsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.statisticsButton.Textcolor = System.Drawing.Color.Silver;
            this.statisticsButton.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statisticsButton.Click += new System.EventHandler(this.StatisticsButton_Click);
            // 
            // gameSettingsButton
            // 
            this.gameSettingsButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.gameSettingsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.gameSettingsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gameSettingsButton.BorderRadius = 0;
            this.gameSettingsButton.ButtonText = "            Game settings";
            this.gameSettingsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelAnimator.SetDecoration(this.gameSettingsButton, BunifuAnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this.gameSettingsButton, BunifuAnimatorNS.DecorationType.None);
            this.gameSettingsButton.DisabledColor = System.Drawing.Color.Gray;
            this.gameSettingsButton.Iconcolor = System.Drawing.Color.Transparent;
            this.gameSettingsButton.Iconimage = null;
            this.gameSettingsButton.Iconimage_right = null;
            this.gameSettingsButton.Iconimage_right_Selected = null;
            this.gameSettingsButton.Iconimage_Selected = null;
            this.gameSettingsButton.IconMarginLeft = 0;
            this.gameSettingsButton.IconMarginRight = 0;
            this.gameSettingsButton.IconRightVisible = true;
            this.gameSettingsButton.IconRightZoom = 0D;
            this.gameSettingsButton.IconVisible = true;
            this.gameSettingsButton.IconZoom = 90D;
            this.gameSettingsButton.IsTab = true;
            this.gameSettingsButton.Location = new System.Drawing.Point(67, 193);
            this.gameSettingsButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gameSettingsButton.Name = "gameSettingsButton";
            this.gameSettingsButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.gameSettingsButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.gameSettingsButton.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.gameSettingsButton.selected = false;
            this.gameSettingsButton.Size = new System.Drawing.Size(270, 56);
            this.gameSettingsButton.TabIndex = 3;
            this.gameSettingsButton.Text = "            Game settings";
            this.gameSettingsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gameSettingsButton.Textcolor = System.Drawing.Color.Silver;
            this.gameSettingsButton.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameSettingsButton.Click += new System.EventHandler(this.BunifuFlatButton2_Click);
            // 
            // gameBoardButton
            // 
            this.gameBoardButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.gameBoardButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.gameBoardButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gameBoardButton.BorderRadius = 0;
            this.gameBoardButton.ButtonText = "            Gameboard";
            this.gameBoardButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelAnimator.SetDecoration(this.gameBoardButton, BunifuAnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this.gameBoardButton, BunifuAnimatorNS.DecorationType.None);
            this.gameBoardButton.DisabledColor = System.Drawing.Color.Gray;
            this.gameBoardButton.Iconcolor = System.Drawing.Color.Transparent;
            this.gameBoardButton.Iconimage = null;
            this.gameBoardButton.Iconimage_right = null;
            this.gameBoardButton.Iconimage_right_Selected = null;
            this.gameBoardButton.Iconimage_Selected = null;
            this.gameBoardButton.IconMarginLeft = 0;
            this.gameBoardButton.IconMarginRight = 0;
            this.gameBoardButton.IconRightVisible = true;
            this.gameBoardButton.IconRightZoom = 0D;
            this.gameBoardButton.IconVisible = true;
            this.gameBoardButton.IconZoom = 90D;
            this.gameBoardButton.IsTab = true;
            this.gameBoardButton.Location = new System.Drawing.Point(67, 129);
            this.gameBoardButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gameBoardButton.Name = "gameBoardButton";
            this.gameBoardButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.gameBoardButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.gameBoardButton.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.gameBoardButton.selected = true;
            this.gameBoardButton.Size = new System.Drawing.Size(270, 56);
            this.gameBoardButton.TabIndex = 2;
            this.gameBoardButton.Text = "            Gameboard";
            this.gameBoardButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gameBoardButton.Textcolor = System.Drawing.Color.Silver;
            this.gameBoardButton.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameBoardButton.Click += new System.EventHandler(this.BunifuFlatButton1_Click);
            // 
            // menuButton
            // 
            this.menuButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.menuButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panelAnimator.SetDecoration(this.menuButton, BunifuAnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this.menuButton, BunifuAnimatorNS.DecorationType.None);
            this.menuButton.Image = ((System.Drawing.Image)(resources.GetObject("menuButton.Image")));
            this.menuButton.ImageActive = null;
            this.menuButton.Location = new System.Drawing.Point(283, 16);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(50, 50);
            this.menuButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.menuButton.TabIndex = 1;
            this.menuButton.TabStop = false;
            this.menuButton.Zoom = 10;
            this.menuButton.Click += new System.EventHandler(this.MenuButton_Click);
            // 
            // logo
            // 
            this.logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logo.BackgroundImage")));
            this.logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logoAnimator.SetDecoration(this.logo, BunifuAnimatorNS.DecorationType.None);
            this.panelAnimator.SetDecoration(this.logo, BunifuAnimatorNS.DecorationType.None);
            this.logo.InitialImage = null;
            this.logo.Location = new System.Drawing.Point(12, 16);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(117, 65);
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.header.Controls.Add(this.bunifuImageButton2);
            this.header.Controls.Add(this.pictureBox2);
            this.header.Controls.Add(this.bunifuCustomLabel1);
            this.panelAnimator.SetDecoration(this.header, BunifuAnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this.header, BunifuAnimatorNS.DecorationType.None);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(1331, 51);
            this.header.TabIndex = 1;
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.panelAnimator.SetDecoration(this.bunifuImageButton2, BunifuAnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this.bunifuImageButton2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(1294, 12);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(25, 25);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 2;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 20;
            this.bunifuImageButton2.Click += new System.EventHandler(this.BunifuImageButton2_Click);
            // 
            // pictureBox2
            // 
            this.logoAnimator.SetDecoration(this.pictureBox2, BunifuAnimatorNS.DecorationType.None);
            this.panelAnimator.SetDecoration(this.pictureBox2, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.logoAnimator.SetDecoration(this.bunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None);
            this.panelAnimator.SetDecoration(this.bunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(47, 9);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(145, 30);
            this.bunifuCustomLabel1.TabIndex = 0;
            this.bunifuCustomLabel1.Text = "Nim Game";
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.header;
            this.bunifuDragControl1.Vertical = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gameBoard1);
            this.panel2.Controls.Add(this.gameSettings1);
            this.panelAnimator.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(340, 51);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(991, 635);
            this.panel2.TabIndex = 2;
            // 
            // logoAnimator
            // 
            this.logoAnimator.AnimationType = BunifuAnimatorNS.AnimationType.ScaleAndRotate;
            this.logoAnimator.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(30);
            animation1.RotateCoeff = 0.5F;
            animation1.RotateLimit = 0.2F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.logoAnimator.DefaultAnimation = animation1;
            this.logoAnimator.Interval = 15;
            this.logoAnimator.TimeStep = 0.04F;
            // 
            // panelAnimator
            // 
            this.panelAnimator.AnimationType = BunifuAnimatorNS.AnimationType.Mosaic;
            this.panelAnimator.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 20;
            animation2.Padding = new System.Windows.Forms.Padding(30);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.panelAnimator.DefaultAnimation = animation2;
            this.panelAnimator.Interval = 8;
            // 
            // gameBoard1
            // 
            this.gameBoard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.logoAnimator.SetDecoration(this.gameBoard1, BunifuAnimatorNS.DecorationType.None);
            this.panelAnimator.SetDecoration(this.gameBoard1, BunifuAnimatorNS.DecorationType.None);
            this.gameBoard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gameBoard1.Location = new System.Drawing.Point(0, 0);
            this.gameBoard1.Name = "gameBoard1";
            this.gameBoard1.Size = new System.Drawing.Size(991, 635);
            this.gameBoard1.TabIndex = 1;
            this.gameBoard1.Load += new System.EventHandler(this.GameBoard1_Load);
            // 
            // gameSettings1
            // 
            this.gameSettings1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.logoAnimator.SetDecoration(this.gameSettings1, BunifuAnimatorNS.DecorationType.None);
            this.panelAnimator.SetDecoration(this.gameSettings1, BunifuAnimatorNS.DecorationType.None);
            this.gameSettings1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gameSettings1.Location = new System.Drawing.Point(0, 0);
            this.gameSettings1.Name = "gameSettings1";
            this.gameSettings1.Size = new System.Drawing.Size(991, 635);
            this.gameSettings1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(1331, 686);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.sideMenu);
            this.Controls.Add(this.header);
            this.logoAnimator.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.panelAnimator.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.sideMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.menuButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel sideMenu;
        private Bunifu.Framework.UI.BunifuFlatButton gameBoardButton;
        private Bunifu.Framework.UI.BunifuImageButton menuButton;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Panel header;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuFlatButton aboutButton;
        private Bunifu.Framework.UI.BunifuFlatButton statisticsButton;
        private Bunifu.Framework.UI.BunifuFlatButton gameSettingsButton;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuFlatButton contactButton;
        private BunifuAnimatorNS.BunifuTransition panelAnimator;
        private BunifuAnimatorNS.BunifuTransition logoAnimator;
        private Bunifu.Framework.UI.BunifuFlatButton gameRulesButton;
        private GameBoard gameBoard1;
        private GameSettings gameSettings1;
    }
}

