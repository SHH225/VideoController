namespace ZDWindowsFormsTest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.MaterialList = new System.Windows.Forms.ListBox();
            this.AnimateList = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ConnectBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.模板ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveDrama = new System.Windows.Forms.ToolStripMenuItem();
            this.CloseDrama = new System.Windows.Forms.ToolStripMenuItem();
            this.InEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.系统状态ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label5 = new System.Windows.Forms.Label();
            this.PropertiseList = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.PropertiseAddList = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AnimatePreviewList = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.FinalList = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.paneltop = new System.Windows.Forms.Panel();
            this.ExpandBtn = new System.Windows.Forms.Button();
            this.MinBtn = new System.Windows.Forms.Button();
            this.ShutDownBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.MoveUpBt = new System.Windows.Forms.Button();
            this.ClearBt = new System.Windows.Forms.Button();
            this.DeleteBt = new System.Windows.Forms.Button();
            this.MoveDownBt = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.splitContainer5 = new System.Windows.Forms.SplitContainer();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ConCfirmBtn = new System.Windows.Forms.Button();
            this.PortNum = new System.Windows.Forms.TextBox();
            this.IPAddressNum = new System.Windows.Forms.TextBox();
            this.PortNuml = new System.Windows.Forms.Label();
            this.IPAddressNuml = new System.Windows.Forms.Label();
            this.splitContainer6 = new System.Windows.Forms.SplitContainer();
            this.panel4 = new System.Windows.Forms.Panel();
            this.StatusLight = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.paneltop.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).BeginInit();
            this.splitContainer5.Panel1.SuspendLayout();
            this.splitContainer5.Panel2.SuspendLayout();
            this.splitContainer5.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer6)).BeginInit();
            this.splitContainer6.Panel1.SuspendLayout();
            this.splitContainer6.Panel2.SuspendLayout();
            this.splitContainer6.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StatusLight)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MaterialList
            // 
            this.MaterialList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(108)))), ((int)(((byte)(106)))));
            this.MaterialList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MaterialList.FormattingEnabled = true;
            this.MaterialList.ItemHeight = 17;
            this.MaterialList.Location = new System.Drawing.Point(0, 0);
            this.MaterialList.Name = "MaterialList";
            this.MaterialList.Size = new System.Drawing.Size(232, 699);
            this.MaterialList.TabIndex = 2;
            this.MaterialList.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // AnimateList
            // 
            this.AnimateList.AllowDrop = true;
            this.AnimateList.FormattingEnabled = true;
            this.AnimateList.ItemHeight = 17;
            this.AnimateList.Location = new System.Drawing.Point(3, 3);
            this.AnimateList.Name = "AnimateList";
            this.AnimateList.Size = new System.Drawing.Size(178, 310);
            this.AnimateList.TabIndex = 14;
            this.AnimateList.DragDrop += new System.Windows.Forms.DragEventHandler(this.Animate_DragDrop);
            this.AnimateList.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Aniamte_MouseDown);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ConnectBtn,
            this.模板ToolStripMenuItem,
            this.SaveDrama,
            this.CloseDrama,
            this.InEdit,
            this.系统状态ToolStripMenuItem,
            this.设置ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(-1, 2);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(512, 39);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // ConnectBtn
            // 
            this.ConnectBtn.BackgroundImage = global::ZDWindowsFormsTest.Properties.Resources.titlebg;
            this.ConnectBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ConnectBtn.Checked = true;
            this.ConnectBtn.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ConnectBtn.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ConnectBtn.ForeColor = System.Drawing.Color.White;
            this.ConnectBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ConnectBtn.Margin = new System.Windows.Forms.Padding(2);
            this.ConnectBtn.Name = "ConnectBtn";
            this.ConnectBtn.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.ConnectBtn.Size = new System.Drawing.Size(60, 31);
            this.ConnectBtn.Text = "连 接";
            this.ConnectBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.ConnectBtn.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // 模板ToolStripMenuItem
            // 
            this.模板ToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("模板ToolStripMenuItem.BackgroundImage")));
            this.模板ToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.模板ToolStripMenuItem.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.模板ToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.模板ToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.模板ToolStripMenuItem.Margin = new System.Windows.Forms.Padding(2);
            this.模板ToolStripMenuItem.Name = "模板ToolStripMenuItem";
            this.模板ToolStripMenuItem.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.模板ToolStripMenuItem.Size = new System.Drawing.Size(80, 31);
            this.模板ToolStripMenuItem.Text = "打开剧本";
            // 
            // SaveDrama
            // 
            this.SaveDrama.BackgroundImage = global::ZDWindowsFormsTest.Properties.Resources.titlebg;
            this.SaveDrama.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SaveDrama.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SaveDrama.ForeColor = System.Drawing.Color.White;
            this.SaveDrama.Margin = new System.Windows.Forms.Padding(2);
            this.SaveDrama.Name = "SaveDrama";
            this.SaveDrama.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.SaveDrama.Size = new System.Drawing.Size(80, 31);
            this.SaveDrama.Text = "保存剧本";
            this.SaveDrama.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.SaveDrama.Click += new System.EventHandler(this.Save_drama);
            // 
            // CloseDrama
            // 
            this.CloseDrama.BackgroundImage = global::ZDWindowsFormsTest.Properties.Resources.titlebg;
            this.CloseDrama.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CloseDrama.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CloseDrama.ForeColor = System.Drawing.Color.White;
            this.CloseDrama.Margin = new System.Windows.Forms.Padding(2);
            this.CloseDrama.Name = "CloseDrama";
            this.CloseDrama.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.CloseDrama.Size = new System.Drawing.Size(80, 31);
            this.CloseDrama.Text = "关闭剧本";
            this.CloseDrama.Click += new System.EventHandler(this.CloseDrama_Click);
            // 
            // InEdit
            // 
            this.InEdit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("InEdit.BackgroundImage")));
            this.InEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.InEdit.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.InEdit.ForeColor = System.Drawing.Color.White;
            this.InEdit.Margin = new System.Windows.Forms.Padding(2);
            this.InEdit.Name = "InEdit";
            this.InEdit.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.InEdit.Size = new System.Drawing.Size(60, 31);
            this.InEdit.Text = "编 辑";
            this.InEdit.Click += new System.EventHandler(this.InEdit_Click);
            // 
            // 系统状态ToolStripMenuItem
            // 
            this.系统状态ToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("系统状态ToolStripMenuItem.BackgroundImage")));
            this.系统状态ToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.系统状态ToolStripMenuItem.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.系统状态ToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.系统状态ToolStripMenuItem.Margin = new System.Windows.Forms.Padding(2);
            this.系统状态ToolStripMenuItem.Name = "系统状态ToolStripMenuItem";
            this.系统状态ToolStripMenuItem.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.系统状态ToolStripMenuItem.Size = new System.Drawing.Size(60, 31);
            this.系统状态ToolStripMenuItem.Text = "播 出";
            this.系统状态ToolStripMenuItem.Click += new System.EventHandler(this.InBroadcast);
            // 
            // 设置ToolStripMenuItem
            // 
            this.设置ToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("设置ToolStripMenuItem.BackgroundImage")));
            this.设置ToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.设置ToolStripMenuItem.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.设置ToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.设置ToolStripMenuItem.Margin = new System.Windows.Forms.Padding(2);
            this.设置ToolStripMenuItem.Name = "设置ToolStripMenuItem";
            this.设置ToolStripMenuItem.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.设置ToolStripMenuItem.Size = new System.Drawing.Size(56, 31);
            this.设置ToolStripMenuItem.Text = "设置";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(55, 1);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.label5.Size = new System.Drawing.Size(117, 21);
            this.label5.TabIndex = 19;
            this.label5.Text = "模 板 列 表";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PropertiseList
            // 
            this.PropertiseList.FormattingEnabled = true;
            this.PropertiseList.ItemHeight = 17;
            this.PropertiseList.Location = new System.Drawing.Point(1, 4);
            this.PropertiseList.Name = "PropertiseList";
            this.PropertiseList.Size = new System.Drawing.Size(182, 310);
            this.PropertiseList.TabIndex = 27;
            this.PropertiseList.DoubleClick += new System.EventHandler(this.PropertisesEditList);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(61, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 28;
            this.label3.Text = "动 画 添 加";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(44, 4);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 17);
            this.label8.TabIndex = 32;
            this.label8.Text = "实 时 属 性 更 新";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PropertiseAddList
            // 
            this.PropertiseAddList.FormattingEnabled = true;
            this.PropertiseAddList.ItemHeight = 17;
            this.PropertiseAddList.Location = new System.Drawing.Point(1, 4);
            this.PropertiseAddList.Name = "PropertiseAddList";
            this.PropertiseAddList.Size = new System.Drawing.Size(189, 310);
            this.PropertiseAddList.TabIndex = 33;
            this.PropertiseAddList.DoubleClick += new System.EventHandler(this.PropertisesAddList);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(62, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 34;
            this.label2.Text = "属 性 添 加";
            // 
            // AnimatePreviewList
            // 
            this.AnimatePreviewList.FormattingEnabled = true;
            this.AnimatePreviewList.ItemHeight = 17;
            this.AnimatePreviewList.Location = new System.Drawing.Point(3, 4);
            this.AnimatePreviewList.Name = "AnimatePreviewList";
            this.AnimatePreviewList.Size = new System.Drawing.Size(185, 310);
            this.AnimatePreviewList.TabIndex = 35;
            this.AnimatePreviewList.SelectedIndexChanged += new System.EventHandler(this.AnimatePreview_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(43, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 17);
            this.label6.TabIndex = 36;
            this.label6.Text = "动 画 实 时 预 览";
            // 
            // FinalList
            // 
            this.FinalList.AllowDrop = true;
            this.FinalList.Font = new System.Drawing.Font("微软雅黑", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FinalList.FormattingEnabled = true;
            this.FinalList.HorizontalScrollbar = true;
            this.FinalList.ItemHeight = 17;
            this.FinalList.Location = new System.Drawing.Point(3, 32);
            this.FinalList.Name = "FinalList";
            this.FinalList.Size = new System.Drawing.Size(422, 684);
            this.FinalList.TabIndex = 20;
            this.FinalList.Click += new System.EventHandler(this.FinalList_SelectedIndexChanged);
            this.FinalList.DragDrop += new System.Windows.Forms.DragEventHandler(this.FinalList_DragDrop);
            this.FinalList.DragEnter += new System.Windows.Forms.DragEventHandler(this.FinalList_DragEnter);
            this.FinalList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PressSpaceKeyDown);
            this.FinalList.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FinaList_MouseDown);
            this.FinalList.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FinaList_MouseUp);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(11, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 41;
            this.label4.Text = "预 览 窗 口";
            // 
            // paneltop
            // 
            this.paneltop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.paneltop.Controls.Add(this.ExpandBtn);
            this.paneltop.Controls.Add(this.MinBtn);
            this.paneltop.Controls.Add(this.ShutDownBtn);
            this.paneltop.Controls.Add(this.label1);
            this.paneltop.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneltop.ForeColor = System.Drawing.Color.White;
            this.paneltop.Location = new System.Drawing.Point(0, 0);
            this.paneltop.Name = "paneltop";
            this.paneltop.Size = new System.Drawing.Size(1470, 30);
            this.paneltop.TabIndex = 42;
            this.paneltop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_title_MouseDown);
            this.paneltop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_title_MouseMove);
            // 
            // ExpandBtn
            // 
            this.ExpandBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ExpandBtn.BackColor = System.Drawing.Color.Transparent;
            this.ExpandBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ExpandBtn.BackgroundImage")));
            this.ExpandBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ExpandBtn.FlatAppearance.BorderSize = 0;
            this.ExpandBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExpandBtn.ForeColor = System.Drawing.Color.Transparent;
            this.ExpandBtn.Location = new System.Drawing.Point(1403, 2);
            this.ExpandBtn.Margin = new System.Windows.Forms.Padding(0);
            this.ExpandBtn.Name = "ExpandBtn";
            this.ExpandBtn.Size = new System.Drawing.Size(27, 27);
            this.ExpandBtn.TabIndex = 3;
            this.ExpandBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.ExpandBtn.UseVisualStyleBackColor = false;
            this.ExpandBtn.Click += new System.EventHandler(this.MaxForm);
            // 
            // MinBtn
            // 
            this.MinBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MinBtn.BackColor = System.Drawing.Color.Transparent;
            this.MinBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MinBtn.BackgroundImage")));
            this.MinBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MinBtn.FlatAppearance.BorderSize = 0;
            this.MinBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinBtn.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MinBtn.Location = new System.Drawing.Point(1374, 2);
            this.MinBtn.Name = "MinBtn";
            this.MinBtn.Size = new System.Drawing.Size(27, 27);
            this.MinBtn.TabIndex = 2;
            this.MinBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.MinBtn.UseVisualStyleBackColor = false;
            this.MinBtn.Click += new System.EventHandler(this.Minform);
            // 
            // ShutDownBtn
            // 
            this.ShutDownBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ShutDownBtn.BackColor = System.Drawing.Color.Transparent;
            this.ShutDownBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ShutDownBtn.BackgroundImage")));
            this.ShutDownBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ShutDownBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.ShutDownBtn.FlatAppearance.BorderSize = 0;
            this.ShutDownBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ShutDownBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShutDownBtn.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ShutDownBtn.Location = new System.Drawing.Point(1431, 2);
            this.ShutDownBtn.Margin = new System.Windows.Forms.Padding(0);
            this.ShutDownBtn.Name = "ShutDownBtn";
            this.ShutDownBtn.Size = new System.Drawing.Size(27, 27);
            this.ShutDownBtn.TabIndex = 1;
            this.ShutDownBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.ShutDownBtn.UseVisualStyleBackColor = false;
            this.ShutDownBtn.Click += new System.EventHandler(this.Shutdownform);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(14, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "VideoController";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.MaterialList);
            this.panel1.Location = new System.Drawing.Point(2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(232, 699);
            this.panel1.TabIndex = 21;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.FinalList);
            this.panel2.Controls.Add(this.MoveUpBt);
            this.panel2.Controls.Add(this.ClearBt);
            this.panel2.Controls.Add(this.DeleteBt);
            this.panel2.Controls.Add(this.MoveDownBt);
            this.panel2.Location = new System.Drawing.Point(239, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(429, 712);
            this.panel2.TabIndex = 21;
            // 
            // MoveUpBt
            // 
            this.MoveUpBt.BackColor = System.Drawing.Color.Transparent;
            this.MoveUpBt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MoveUpBt.BackgroundImage")));
            this.MoveUpBt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MoveUpBt.FlatAppearance.BorderSize = 0;
            this.MoveUpBt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MoveUpBt.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MoveUpBt.Location = new System.Drawing.Point(4, 3);
            this.MoveUpBt.Margin = new System.Windows.Forms.Padding(0);
            this.MoveUpBt.Name = "MoveUpBt";
            this.MoveUpBt.Size = new System.Drawing.Size(64, 26);
            this.MoveUpBt.TabIndex = 38;
            this.MoveUpBt.Text = "上 移";
            this.MoveUpBt.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.MoveUpBt.UseVisualStyleBackColor = false;
            this.MoveUpBt.Click += new System.EventHandler(this.MoveUpBt_Click);
            // 
            // ClearBt
            // 
            this.ClearBt.BackColor = System.Drawing.Color.Transparent;
            this.ClearBt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ClearBt.BackgroundImage")));
            this.ClearBt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClearBt.FlatAppearance.BorderSize = 0;
            this.ClearBt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearBt.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ClearBt.Location = new System.Drawing.Point(211, 3);
            this.ClearBt.Margin = new System.Windows.Forms.Padding(0);
            this.ClearBt.Name = "ClearBt";
            this.ClearBt.Size = new System.Drawing.Size(64, 26);
            this.ClearBt.TabIndex = 12;
            this.ClearBt.Text = "清 空";
            this.ClearBt.UseVisualStyleBackColor = false;
            this.ClearBt.Click += new System.EventHandler(this.button3_Click);
            // 
            // DeleteBt
            // 
            this.DeleteBt.BackColor = System.Drawing.Color.Transparent;
            this.DeleteBt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DeleteBt.BackgroundImage")));
            this.DeleteBt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DeleteBt.FlatAppearance.BorderSize = 0;
            this.DeleteBt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteBt.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DeleteBt.Location = new System.Drawing.Point(142, 3);
            this.DeleteBt.Margin = new System.Windows.Forms.Padding(0);
            this.DeleteBt.Name = "DeleteBt";
            this.DeleteBt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DeleteBt.Size = new System.Drawing.Size(64, 26);
            this.DeleteBt.TabIndex = 37;
            this.DeleteBt.Text = "删 除";
            this.DeleteBt.UseVisualStyleBackColor = false;
            this.DeleteBt.Click += new System.EventHandler(this.DeleteBt_Click);
            // 
            // MoveDownBt
            // 
            this.MoveDownBt.BackColor = System.Drawing.Color.Transparent;
            this.MoveDownBt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MoveDownBt.BackgroundImage")));
            this.MoveDownBt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MoveDownBt.FlatAppearance.BorderSize = 0;
            this.MoveDownBt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MoveDownBt.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MoveDownBt.Location = new System.Drawing.Point(73, 3);
            this.MoveDownBt.Margin = new System.Windows.Forms.Padding(0);
            this.MoveDownBt.Name = "MoveDownBt";
            this.MoveDownBt.Size = new System.Drawing.Size(64, 26);
            this.MoveDownBt.TabIndex = 39;
            this.MoveDownBt.Text = "下 移";
            this.MoveDownBt.UseVisualStyleBackColor = false;
            this.MoveDownBt.Click += new System.EventHandler(this.MoveDownBt_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(667, 43);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer1.Panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("splitContainer1.Panel1.BackgroundImage")));
            this.splitContainer1.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.Black;
            this.splitContainer1.Size = new System.Drawing.Size(775, 361);
            this.splitContainer1.SplitterDistance = 31;
            this.splitContainer1.TabIndex = 43;
            // 
            // splitContainer2
            // 
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(670, 409);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer2.Panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("splitContainer2.Panel1.BackgroundImage")));
            this.splitContainer2.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.splitContainer2.Panel1.Controls.Add(this.label8);
            this.splitContainer2.Panel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.PropertiseList);
            this.splitContainer2.Size = new System.Drawing.Size(187, 344);
            this.splitContainer2.SplitterDistance = 25;
            this.splitContainer2.TabIndex = 44;
            // 
            // splitContainer3
            // 
            this.splitContainer3.IsSplitterFixed = true;
            this.splitContainer3.Location = new System.Drawing.Point(861, 408);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer3.Panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("splitContainer3.Panel1.BackgroundImage")));
            this.splitContainer3.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.splitContainer3.Panel1.Controls.Add(this.label2);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.PropertiseAddList);
            this.splitContainer3.Size = new System.Drawing.Size(194, 344);
            this.splitContainer3.SplitterDistance = 25;
            this.splitContainer3.TabIndex = 45;
            // 
            // splitContainer4
            // 
            this.splitContainer4.IsSplitterFixed = true;
            this.splitContainer4.Location = new System.Drawing.Point(1061, 408);
            this.splitContainer4.Name = "splitContainer4";
            this.splitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer4.Panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("splitContainer4.Panel1.BackgroundImage")));
            this.splitContainer4.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.splitContainer4.Panel1.Controls.Add(this.label6);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.AnimatePreviewList);
            this.splitContainer4.Size = new System.Drawing.Size(189, 346);
            this.splitContainer4.SplitterDistance = 25;
            this.splitContainer4.TabIndex = 46;
            // 
            // splitContainer5
            // 
            this.splitContainer5.IsSplitterFixed = true;
            this.splitContainer5.Location = new System.Drawing.Point(1256, 408);
            this.splitContainer5.Name = "splitContainer5";
            this.splitContainer5.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer5.Panel1
            // 
            this.splitContainer5.Panel1.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer5.Panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("splitContainer5.Panel1.BackgroundImage")));
            this.splitContainer5.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.splitContainer5.Panel1.Controls.Add(this.label3);
            // 
            // splitContainer5.Panel2
            // 
            this.splitContainer5.Panel2.Controls.Add(this.AnimateList);
            this.splitContainer5.Size = new System.Drawing.Size(184, 347);
            this.splitContainer5.SplitterDistance = 25;
            this.splitContainer5.TabIndex = 47;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.ConCfirmBtn);
            this.panel3.Controls.Add(this.PortNum);
            this.panel3.Controls.Add(this.IPAddressNum);
            this.panel3.Controls.Add(this.PortNuml);
            this.panel3.Controls.Add(this.IPAddressNuml);
            this.panel3.Controls.Add(this.splitContainer6);
            this.panel3.Controls.Add(this.splitContainer1);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.menuStrip1);
            this.panel3.Controls.Add(this.splitContainer5);
            this.panel3.Controls.Add(this.splitContainer2);
            this.panel3.Controls.Add(this.splitContainer4);
            this.panel3.Controls.Add(this.splitContainer3);
            this.panel3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.panel3.ForeColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(9, 31);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1451, 767);
            this.panel3.TabIndex = 48;
            // 
            // ConCfirmBtn
            // 
            this.ConCfirmBtn.BackColor = System.Drawing.Color.Transparent;
            this.ConCfirmBtn.BackgroundImage = global::ZDWindowsFormsTest.Properties.Resources.titlebg2;
            this.ConCfirmBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ConCfirmBtn.FlatAppearance.BorderSize = 0;
            this.ConCfirmBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ConCfirmBtn.ForeColor = System.Drawing.Color.White;
            this.ConCfirmBtn.Location = new System.Drawing.Point(1366, 11);
            this.ConCfirmBtn.Name = "ConCfirmBtn";
            this.ConCfirmBtn.Size = new System.Drawing.Size(75, 23);
            this.ConCfirmBtn.TabIndex = 53;
            this.ConCfirmBtn.Text = "确 认";
            this.ConCfirmBtn.UseVisualStyleBackColor = false;
            this.ConCfirmBtn.Click += new System.EventHandler(this.ConCfirmBtn_Click);
            // 
            // PortNum
            // 
            this.PortNum.Location = new System.Drawing.Point(1253, 11);
            this.PortNum.Name = "PortNum";
            this.PortNum.Size = new System.Drawing.Size(100, 23);
            this.PortNum.TabIndex = 52;
            // 
            // IPAddressNum
            // 
            this.IPAddressNum.Location = new System.Drawing.Point(1086, 11);
            this.IPAddressNum.Name = "IPAddressNum";
            this.IPAddressNum.Size = new System.Drawing.Size(100, 23);
            this.IPAddressNum.TabIndex = 51;
            // 
            // PortNuml
            // 
            this.PortNuml.AutoSize = true;
            this.PortNuml.Location = new System.Drawing.Point(1193, 14);
            this.PortNuml.Name = "PortNuml";
            this.PortNuml.Size = new System.Drawing.Size(68, 17);
            this.PortNuml.TabIndex = 50;
            this.PortNuml.Text = "端 口 号 ：";
            // 
            // IPAddressNuml
            // 
            this.IPAddressNuml.AutoSize = true;
            this.IPAddressNuml.Location = new System.Drawing.Point(1026, 14);
            this.IPAddressNuml.Name = "IPAddressNuml";
            this.IPAddressNuml.Size = new System.Drawing.Size(68, 17);
            this.IPAddressNuml.TabIndex = 49;
            this.IPAddressNuml.Text = "IP 地 址 ：";
            // 
            // splitContainer6
            // 
            this.splitContainer6.IsSplitterFixed = true;
            this.splitContainer6.Location = new System.Drawing.Point(7, 43);
            this.splitContainer6.Name = "splitContainer6";
            this.splitContainer6.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer6.Panel1
            // 
            this.splitContainer6.Panel1.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer6.Panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("splitContainer6.Panel1.BackgroundImage")));
            this.splitContainer6.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.splitContainer6.Panel1.Controls.Add(this.label5);
            // 
            // splitContainer6.Panel2
            // 
            this.splitContainer6.Panel2.Controls.Add(this.panel1);
            this.splitContainer6.Size = new System.Drawing.Size(230, 709);
            this.splitContainer6.SplitterDistance = 25;
            this.splitContainer6.TabIndex = 48;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Controls.Add(this.StatusLight);
            this.panel4.Location = new System.Drawing.Point(9, 801);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1451, 29);
            this.panel4.TabIndex = 49;
            // 
            // StatusLight
            // 
            this.StatusLight.BackgroundImage = global::ZDWindowsFormsTest.Properties.Resources.redlight;
            this.StatusLight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.StatusLight.Location = new System.Drawing.Point(7, 3);
            this.StatusLight.Name = "StatusLight";
            this.StatusLight.Size = new System.Drawing.Size(21, 22);
            this.StatusLight.TabIndex = 1;
            this.StatusLight.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1470, 840);
            this.ControlBox = false;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.paneltop);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Size_Change);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.paneltop.ResumeLayout(false);
            this.paneltop.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel1.PerformLayout();
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            this.splitContainer5.Panel1.ResumeLayout(false);
            this.splitContainer5.Panel1.PerformLayout();
            this.splitContainer5.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).EndInit();
            this.splitContainer5.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.splitContainer6.Panel1.ResumeLayout(false);
            this.splitContainer6.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer6)).EndInit();
            this.splitContainer6.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.StatusLight)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ListBox MaterialList;
		private System.Windows.Forms.Button ClearBt;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 模板ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem InEdit;
        private System.Windows.Forms.ToolStripMenuItem 设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ConnectBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox PropertiseList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox AnimateList;
        private System.Windows.Forms.ListBox PropertiseAddList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox AnimatePreviewList;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox FinalList;
        private System.Windows.Forms.Button DeleteBt;
        private System.Windows.Forms.Button MoveUpBt;
        private System.Windows.Forms.Button MoveDownBt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel paneltop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ShutDownBtn;
        private System.Windows.Forms.Button MinBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.SplitContainer splitContainer5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.SplitContainer splitContainer6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button ExpandBtn;
        private System.Windows.Forms.ToolStripMenuItem 系统状态ToolStripMenuItem;
        private System.Windows.Forms.PictureBox StatusLight;
        private System.Windows.Forms.ToolStripMenuItem SaveDrama;
        private System.Windows.Forms.ToolStripMenuItem CloseDrama;
        private System.Windows.Forms.TextBox PortNum;
        private System.Windows.Forms.TextBox IPAddressNum;
        private System.Windows.Forms.Label PortNuml;
        private System.Windows.Forms.Label IPAddressNuml;
        private System.Windows.Forms.Button ConCfirmBtn;
    }
}

