namespace Plan_B_Administration
{
    partial class Main
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
            AnimatorNS.Animation animation1 = new AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            AnimatorNS.Animation animation2 = new AnimatorNS.Animation();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.sidemenu = new System.Windows.Forms.Panel();
            this.LogoFull = new System.Windows.Forms.PictureBox();
            this.btnAbout = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnTasks = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSotr = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnMain = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnMenu = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnExit = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LogoAnimator1 = new AnimatorNS.Animator(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.todoCard = new Bunifu.Framework.UI.BunifuCards();
            this.todoPanel = new System.Windows.Forms.Panel();
            this.logomain = new System.Windows.Forms.PictureBox();
            this.txtTaskName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnAddTask = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.PanelAnimator = new AnimatorNS.Animator(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.sidemenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoFull)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.todoCard.SuspendLayout();
            this.todoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logomain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddTask)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // sidemenu
            // 
            this.sidemenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.sidemenu.Controls.Add(this.LogoFull);
            this.sidemenu.Controls.Add(this.btnAbout);
            this.sidemenu.Controls.Add(this.btnTasks);
            this.sidemenu.Controls.Add(this.btnSotr);
            this.sidemenu.Controls.Add(this.btnMain);
            this.sidemenu.Controls.Add(this.btnMenu);
            this.PanelAnimator.SetDecoration(this.sidemenu, AnimatorNS.DecorationType.None);
            this.LogoAnimator1.SetDecoration(this.sidemenu, AnimatorNS.DecorationType.None);
            this.sidemenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidemenu.Location = new System.Drawing.Point(0, 48);
            this.sidemenu.Name = "sidemenu";
            this.sidemenu.Size = new System.Drawing.Size(300, 652);
            this.sidemenu.TabIndex = 0;
            // 
            // LogoFull
            // 
            this.LogoAnimator1.SetDecoration(this.LogoFull, AnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.LogoFull, AnimatorNS.DecorationType.None);
            this.LogoFull.Image = global::Plan_B_Administration.Properties.Resources.plan_b_printing_logo2;
            this.LogoFull.Location = new System.Drawing.Point(29, 6);
            this.LogoFull.Name = "LogoFull";
            this.LogoFull.Size = new System.Drawing.Size(206, 104);
            this.LogoFull.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoFull.TabIndex = 7;
            this.LogoFull.TabStop = false;
            // 
            // btnAbout
            // 
            this.btnAbout.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(160)))), ((int)(((byte)(71)))));
            this.btnAbout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnAbout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAbout.BorderRadius = 0;
            this.btnAbout.ButtonText = "                О нас";
            this.btnAbout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelAnimator.SetDecoration(this.btnAbout, AnimatorNS.DecorationType.None);
            this.LogoAnimator1.SetDecoration(this.btnAbout, AnimatorNS.DecorationType.None);
            this.btnAbout.DisabledColor = System.Drawing.Color.Gray;
            this.btnAbout.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAbout.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAbout.Iconimage")));
            this.btnAbout.Iconimage_right = null;
            this.btnAbout.Iconimage_right_Selected = null;
            this.btnAbout.Iconimage_Selected = null;
            this.btnAbout.IconMarginLeft = 0;
            this.btnAbout.IconMarginRight = 0;
            this.btnAbout.IconRightVisible = true;
            this.btnAbout.IconRightZoom = 0D;
            this.btnAbout.IconVisible = true;
            this.btnAbout.IconZoom = 90D;
            this.btnAbout.IsTab = true;
            this.btnAbout.Location = new System.Drawing.Point(0, 403);
            this.btnAbout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnAbout.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(160)))), ((int)(((byte)(71)))));
            this.btnAbout.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAbout.selected = false;
            this.btnAbout.Size = new System.Drawing.Size(300, 59);
            this.btnAbout.TabIndex = 6;
            this.btnAbout.Text = "                О нас";
            this.btnAbout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbout.Textcolor = System.Drawing.Color.White;
            this.btnAbout.TextFont = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnTasks
            // 
            this.btnTasks.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(160)))), ((int)(((byte)(71)))));
            this.btnTasks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnTasks.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTasks.BorderRadius = 0;
            this.btnTasks.ButtonText = "                Задания";
            this.btnTasks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelAnimator.SetDecoration(this.btnTasks, AnimatorNS.DecorationType.None);
            this.LogoAnimator1.SetDecoration(this.btnTasks, AnimatorNS.DecorationType.None);
            this.btnTasks.DisabledColor = System.Drawing.Color.Gray;
            this.btnTasks.Iconcolor = System.Drawing.Color.Transparent;
            this.btnTasks.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnTasks.Iconimage")));
            this.btnTasks.Iconimage_right = null;
            this.btnTasks.Iconimage_right_Selected = null;
            this.btnTasks.Iconimage_Selected = null;
            this.btnTasks.IconMarginLeft = 0;
            this.btnTasks.IconMarginRight = 0;
            this.btnTasks.IconRightVisible = true;
            this.btnTasks.IconRightZoom = 0D;
            this.btnTasks.IconVisible = true;
            this.btnTasks.IconZoom = 90D;
            this.btnTasks.IsTab = true;
            this.btnTasks.Location = new System.Drawing.Point(0, 336);
            this.btnTasks.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTasks.Name = "btnTasks";
            this.btnTasks.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnTasks.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(160)))), ((int)(((byte)(71)))));
            this.btnTasks.OnHoverTextColor = System.Drawing.Color.White;
            this.btnTasks.selected = false;
            this.btnTasks.Size = new System.Drawing.Size(301, 59);
            this.btnTasks.TabIndex = 5;
            this.btnTasks.Text = "                Задания";
            this.btnTasks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTasks.Textcolor = System.Drawing.Color.White;
            this.btnTasks.TextFont = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTasks.Click += new System.EventHandler(this.bunifuFlatButton4_Click);
            // 
            // btnSotr
            // 
            this.btnSotr.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(160)))), ((int)(((byte)(71)))));
            this.btnSotr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnSotr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSotr.BorderRadius = 0;
            this.btnSotr.ButtonText = "                Сотрудники";
            this.btnSotr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelAnimator.SetDecoration(this.btnSotr, AnimatorNS.DecorationType.None);
            this.LogoAnimator1.SetDecoration(this.btnSotr, AnimatorNS.DecorationType.None);
            this.btnSotr.DisabledColor = System.Drawing.Color.Gray;
            this.btnSotr.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSotr.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnSotr.Iconimage")));
            this.btnSotr.Iconimage_right = null;
            this.btnSotr.Iconimage_right_Selected = null;
            this.btnSotr.Iconimage_Selected = null;
            this.btnSotr.IconMarginLeft = 0;
            this.btnSotr.IconMarginRight = 0;
            this.btnSotr.IconRightVisible = true;
            this.btnSotr.IconRightZoom = 0D;
            this.btnSotr.IconVisible = true;
            this.btnSotr.IconZoom = 90D;
            this.btnSotr.IsTab = true;
            this.btnSotr.Location = new System.Drawing.Point(0, 269);
            this.btnSotr.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSotr.Name = "btnSotr";
            this.btnSotr.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnSotr.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(160)))), ((int)(((byte)(71)))));
            this.btnSotr.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSotr.selected = false;
            this.btnSotr.Size = new System.Drawing.Size(301, 59);
            this.btnSotr.TabIndex = 3;
            this.btnSotr.Text = "                Сотрудники";
            this.btnSotr.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSotr.Textcolor = System.Drawing.Color.White;
            this.btnSotr.TextFont = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSotr.Click += new System.EventHandler(this.btnSotr_Click);
            // 
            // btnMain
            // 
            this.btnMain.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(160)))), ((int)(((byte)(71)))));
            this.btnMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMain.BorderRadius = 0;
            this.btnMain.ButtonText = "                Главная";
            this.btnMain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelAnimator.SetDecoration(this.btnMain, AnimatorNS.DecorationType.None);
            this.LogoAnimator1.SetDecoration(this.btnMain, AnimatorNS.DecorationType.None);
            this.btnMain.DisabledColor = System.Drawing.Color.Gray;
            this.btnMain.Iconcolor = System.Drawing.Color.Transparent;
            this.btnMain.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnMain.Iconimage")));
            this.btnMain.Iconimage_right = null;
            this.btnMain.Iconimage_right_Selected = null;
            this.btnMain.Iconimage_Selected = null;
            this.btnMain.IconMarginLeft = 0;
            this.btnMain.IconMarginRight = 0;
            this.btnMain.IconRightVisible = true;
            this.btnMain.IconRightZoom = 0D;
            this.btnMain.IconVisible = true;
            this.btnMain.IconZoom = 90D;
            this.btnMain.IsTab = true;
            this.btnMain.Location = new System.Drawing.Point(0, 202);
            this.btnMain.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMain.Name = "btnMain";
            this.btnMain.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnMain.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(160)))), ((int)(((byte)(71)))));
            this.btnMain.OnHoverTextColor = System.Drawing.Color.White;
            this.btnMain.selected = true;
            this.btnMain.Size = new System.Drawing.Size(301, 59);
            this.btnMain.TabIndex = 2;
            this.btnMain.Text = "                Главная";
            this.btnMain.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMain.Textcolor = System.Drawing.Color.White;
            this.btnMain.TextFont = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMain.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.PanelAnimator.SetDecoration(this.btnMenu, AnimatorNS.DecorationType.None);
            this.LogoAnimator1.SetDecoration(this.btnMenu, AnimatorNS.DecorationType.None);
            this.btnMenu.Image = global::Plan_B_Administration.Properties.Resources.download_422593;
            this.btnMenu.ImageActive = null;
            this.btnMenu.Location = new System.Drawing.Point(255, 30);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(25, 25);
            this.btnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMenu.TabIndex = 1;
            this.btnMenu.TabStop = false;
            this.btnMenu.Zoom = 10;
            this.btnMenu.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.panel2.Controls.Add(this.btnExit);
            this.panel2.Controls.Add(this.bunifuCustomLabel1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.PanelAnimator.SetDecoration(this.panel2, AnimatorNS.DecorationType.None);
            this.LogoAnimator1.SetDecoration(this.panel2, AnimatorNS.DecorationType.None);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1149, 48);
            this.panel2.TabIndex = 1;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.PanelAnimator.SetDecoration(this.btnExit, AnimatorNS.DecorationType.None);
            this.LogoAnimator1.SetDecoration(this.btnExit, AnimatorNS.DecorationType.None);
            this.btnExit.Image = global::Plan_B_Administration.Properties.Resources.icons8_удалить_filled_50;
            this.btnExit.ImageActive = null;
            this.btnExit.Location = new System.Drawing.Point(1112, 11);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(25, 25);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnExit.TabIndex = 3;
            this.btnExit.TabStop = false;
            this.btnExit.Zoom = 10;
            this.btnExit.Click += new System.EventHandler(this.bunifuImageButton2_Click);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.LogoAnimator1.SetDecoration(this.bunifuCustomLabel1, AnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.bunifuCustomLabel1, AnimatorNS.DecorationType.None);
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.SystemColors.Control;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(67, 11);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(213, 23);
            this.bunifuCustomLabel1.TabIndex = 0;
            this.bunifuCustomLabel1.Text = "Plan-B Administration";
            // 
            // pictureBox1
            // 
            this.LogoAnimator1.SetDecoration(this.pictureBox1, AnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.pictureBox1, AnimatorNS.DecorationType.None);
            this.pictureBox1.Image = global::Plan_B_Administration.Properties.Resources.unnamed;
            this.pictureBox1.Location = new System.Drawing.Point(17, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // LogoAnimator1
            // 
            this.LogoAnimator1.AnimationType = AnimatorNS.AnimationType.ScaleAndRotate;
            this.LogoAnimator1.Cursor = null;
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
            this.LogoAnimator1.DefaultAnimation = animation1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.todoCard);
            this.PanelAnimator.SetDecoration(this.panel3, AnimatorNS.DecorationType.None);
            this.LogoAnimator1.SetDecoration(this.panel3, AnimatorNS.DecorationType.None);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(300, 48);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(849, 652);
            this.panel3.TabIndex = 2;
            // 
            // todoCard
            // 
            this.todoCard.BackColor = System.Drawing.Color.White;
            this.todoCard.BorderRadius = 5;
            this.todoCard.BottomSahddow = true;
            this.todoCard.color = System.Drawing.Color.White;
            this.todoCard.Controls.Add(this.todoPanel);
            this.todoCard.Controls.Add(this.txtTaskName);
            this.todoCard.Controls.Add(this.btnAddTask);
            this.todoCard.Controls.Add(this.panel1);
            this.PanelAnimator.SetDecoration(this.todoCard, AnimatorNS.DecorationType.None);
            this.LogoAnimator1.SetDecoration(this.todoCard, AnimatorNS.DecorationType.None);
            this.todoCard.LeftSahddow = false;
            this.todoCard.Location = new System.Drawing.Point(0, 0);
            this.todoCard.Name = "todoCard";
            this.todoCard.RightSahddow = true;
            this.todoCard.ShadowDepth = 20;
            this.todoCard.Size = new System.Drawing.Size(849, 652);
            this.todoCard.TabIndex = 0;
            this.todoCard.Visible = false;
            // 
            // todoPanel
            // 
            this.todoPanel.AutoScroll = true;
            this.todoPanel.BackColor = System.Drawing.Color.White;
            this.todoPanel.Controls.Add(this.logomain);
            this.PanelAnimator.SetDecoration(this.todoPanel, AnimatorNS.DecorationType.None);
            this.LogoAnimator1.SetDecoration(this.todoPanel, AnimatorNS.DecorationType.None);
            this.todoPanel.Location = new System.Drawing.Point(152, 59);
            this.todoPanel.Name = "todoPanel";
            this.todoPanel.Size = new System.Drawing.Size(488, 443);
            this.todoPanel.TabIndex = 4;
            // 
            // logomain
            // 
            this.LogoAnimator1.SetDecoration(this.logomain, AnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.logomain, AnimatorNS.DecorationType.None);
            this.logomain.Image = global::Plan_B_Administration.Properties.Resources.Plan_B_logo_black1;
            this.logomain.Location = new System.Drawing.Point(5, 133);
            this.logomain.Name = "logomain";
            this.logomain.Size = new System.Drawing.Size(483, 253);
            this.logomain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logomain.TabIndex = 1;
            this.logomain.TabStop = false;
            // 
            // txtTaskName
            // 
            this.txtTaskName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PanelAnimator.SetDecoration(this.txtTaskName, AnimatorNS.DecorationType.None);
            this.LogoAnimator1.SetDecoration(this.txtTaskName, AnimatorNS.DecorationType.None);
            this.txtTaskName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtTaskName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTaskName.HintForeColor = System.Drawing.Color.Empty;
            this.txtTaskName.HintText = "";
            this.txtTaskName.isPassword = false;
            this.txtTaskName.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtTaskName.LineIdleColor = System.Drawing.Color.Gray;
            this.txtTaskName.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtTaskName.LineThickness = 3;
            this.txtTaskName.Location = new System.Drawing.Point(152, 584);
            this.txtTaskName.Margin = new System.Windows.Forms.Padding(4);
            this.txtTaskName.Name = "txtTaskName";
            this.txtTaskName.Size = new System.Drawing.Size(370, 44);
            this.txtTaskName.TabIndex = 3;
            this.txtTaskName.Text = "Введите название задачи";
            this.txtTaskName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnAddTask
            // 
            this.btnAddTask.BackColor = System.Drawing.Color.White;
            this.PanelAnimator.SetDecoration(this.btnAddTask, AnimatorNS.DecorationType.None);
            this.LogoAnimator1.SetDecoration(this.btnAddTask, AnimatorNS.DecorationType.None);
            this.btnAddTask.Image = global::Plan_B_Administration.Properties.Resources.Add_50px;
            this.btnAddTask.ImageActive = null;
            this.btnAddTask.Location = new System.Drawing.Point(584, 572);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(56, 56);
            this.btnAddTask.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAddTask.TabIndex = 2;
            this.btnAddTask.TabStop = false;
            this.btnAddTask.Zoom = 10;
            this.btnAddTask.Click += new System.EventHandler(this.bunifuImageButton1_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(160)))), ((int)(((byte)(71)))));
            this.panel1.Controls.Add(this.bunifuCustomLabel2);
            this.PanelAnimator.SetDecoration(this.panel1, AnimatorNS.DecorationType.None);
            this.LogoAnimator1.SetDecoration(this.panel1, AnimatorNS.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(849, 37);
            this.panel1.TabIndex = 1;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.LogoAnimator1.SetDecoration(this.bunifuCustomLabel2, AnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.bunifuCustomLabel2, AnimatorNS.DecorationType.None);
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.SystemColors.Control;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(345, 5);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(128, 23);
            this.bunifuCustomLabel2.TabIndex = 6;
            this.bunifuCustomLabel2.Text = "Список дел";
            // 
            // PanelAnimator
            // 
            this.PanelAnimator.AnimationType = AnimatorNS.AnimationType.Particles;
            this.PanelAnimator.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 1;
            animation2.Padding = new System.Windows.Forms.Padding(100, 50, 100, 150);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 2F;
            animation2.TransparencyCoeff = 0F;
            this.PanelAnimator.DefaultAnimation = animation2;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = null;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = null;
            this.bunifuDragControl2.Vertical = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1149, 700);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.sidemenu);
            this.Controls.Add(this.panel2);
            this.LogoAnimator1.SetDecoration(this, AnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this, AnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.sidemenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LogoFull)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.todoCard.ResumeLayout(false);
            this.todoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logomain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddTask)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel sidemenu;
        private Bunifu.Framework.UI.BunifuImageButton btnMenu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuFlatButton btnMain;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuImageButton btnExit;
        private Bunifu.Framework.UI.BunifuFlatButton btnSotr;
        private Bunifu.Framework.UI.BunifuFlatButton btnAbout;
        private Bunifu.Framework.UI.BunifuFlatButton btnTasks;
        private System.Windows.Forms.PictureBox LogoFull;
        private AnimatorNS.Animator PanelAnimator;
        private AnimatorNS.Animator LogoAnimator1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuCards todoCard;
        private System.Windows.Forms.Panel todoPanel;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtTaskName;
        private Bunifu.Framework.UI.BunifuImageButton btnAddTask;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private System.Windows.Forms.PictureBox logomain;
    }
}