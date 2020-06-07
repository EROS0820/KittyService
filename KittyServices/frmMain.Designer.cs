using System.Windows.Forms;

namespace KittyServices
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.calculateOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.total_textbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.name_textbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.title_tab1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblSeven = new System.Windows.Forms.Label();
            this.lblSix = new System.Windows.Forms.Label();
            this.lblFive = new System.Windows.Forms.Label();
            this.lblFour = new System.Windows.Forms.Label();
            this.lblThree = new System.Windows.Forms.Label();
            this.lblTwo = new System.Windows.Forms.Label();
            this.lblOne = new System.Windows.Forms.Label();
            this.extra_groupbox = new System.Windows.Forms.GroupBox();
            this.nail_service_check = new System.Windows.Forms.CheckBox();
            this.comb_out_check = new System.Windows.Forms.CheckBox();
            this.spa_bath_check = new System.Windows.Forms.CheckBox();
            this.kitty_cut_groupbox = new System.Windows.Forms.GroupBox();
            this.shave_radio = new System.Windows.Forms.RadioButton();
            this.trim_radio = new System.Windows.Forms.RadioButton();
            this.spa_treatments_combo = new System.Windows.Forms.ComboBox();
            this.spa_treatments_label = new System.Windows.Forms.Label();
            this.service_listview = new System.Windows.Forms.ListBox();
            this.service_listview_label = new System.Windows.Forms.Label();
            this.kitty_number_combo = new System.Windows.Forms.ComboBox();
            this.kitty_number_label = new System.Windows.Forms.Label();
            this.title_tab2 = new System.Windows.Forms.Label();
            this.menuStrip2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.extra_groupbox.SuspendLayout();
            this.kitty_cut_groupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(584, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(584, 24);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculateOrderToolStripMenuItem,
            this.clearFormToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F)));
            this.toolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.toolStripMenuItem1.Text = "&File";
            // 
            // calculateOrderToolStripMenuItem
            // 
            this.calculateOrderToolStripMenuItem.Name = "calculateOrderToolStripMenuItem";
            this.calculateOrderToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.calculateOrderToolStripMenuItem.Text = "Calculate Order";
            this.calculateOrderToolStripMenuItem.Click += new System.EventHandler(this.calculateOrderToolStripMenuItem_Click);
            // 
            // clearFormToolStripMenuItem
            // 
            this.clearFormToolStripMenuItem.Name = "clearFormToolStripMenuItem";
            this.clearFormToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clearFormToolStripMenuItem.Text = "Clear Form";
            this.clearFormToolStripMenuItem.Click += new System.EventHandler(this.clearFormToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fontToolStripMenuItem,
            this.colorsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.O)));
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.fileToolStripMenuItem.Text = "F&ormat";
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fontToolStripMenuItem.Text = "Font";
            this.fontToolStripMenuItem.Click += new System.EventHandler(this.fontToolStripMenuItem_Click);
            // 
            // colorsToolStripMenuItem
            // 
            this.colorsToolStripMenuItem.Name = "colorsToolStripMenuItem";
            this.colorsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.colorsToolStripMenuItem.Text = "Colors";
            this.colorsToolStripMenuItem.Click += new System.EventHandler(this.colorsToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contactToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.O)));
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "&About";
            // 
            // contactToolStripMenuItem
            // 
            this.contactToolStripMenuItem.Name = "contactToolStripMenuItem";
            this.contactToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.contactToolStripMenuItem.Text = "Contact";
            this.contactToolStripMenuItem.Click += new System.EventHandler(this.contactToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 38);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(584, 500);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Gray;
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.total_textbox);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.name_textbox);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.title_tab1);
            this.tabPage1.ForeColor = System.Drawing.Color.Black;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(576, 474);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Name/Total";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(347, 103);
            this.pictureBox1.MaximumSize = new System.Drawing.Size(187, 270);
            this.pictureBox1.MinimumSize = new System.Drawing.Size(187, 270);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(187, 270);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // total_textbox
            // 
            this.total_textbox.Enabled = false;
            this.total_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_textbox.Location = new System.Drawing.Point(54, 192);
            this.total_textbox.Multiline = true;
            this.total_textbox.Name = "total_textbox";
            this.total_textbox.Size = new System.Drawing.Size(154, 181);
            this.total_textbox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(51, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Total:";
            // 
            // name_textbox
            // 
            this.name_textbox.Location = new System.Drawing.Point(54, 108);
            this.name_textbox.Name = "name_textbox";
            this.name_textbox.Size = new System.Drawing.Size(154, 20);
            this.name_textbox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Name:";
            // 
            // title_tab1
            // 
            this.title_tab1.AutoSize = true;
            this.title_tab1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_tab1.Location = new System.Drawing.Point(211, 24);
            this.title_tab1.Name = "title_tab1";
            this.title_tab1.Size = new System.Drawing.Size(145, 25);
            this.title_tab1.TabIndex = 3;
            this.title_tab1.Text = "Kitty Services";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Gray;
            this.tabPage2.Controls.Add(this.lblSeven);
            this.tabPage2.Controls.Add(this.lblSix);
            this.tabPage2.Controls.Add(this.lblFive);
            this.tabPage2.Controls.Add(this.lblFour);
            this.tabPage2.Controls.Add(this.lblThree);
            this.tabPage2.Controls.Add(this.lblTwo);
            this.tabPage2.Controls.Add(this.lblOne);
            this.tabPage2.Controls.Add(this.extra_groupbox);
            this.tabPage2.Controls.Add(this.kitty_cut_groupbox);
            this.tabPage2.Controls.Add(this.spa_treatments_combo);
            this.tabPage2.Controls.Add(this.spa_treatments_label);
            this.tabPage2.Controls.Add(this.service_listview);
            this.tabPage2.Controls.Add(this.service_listview_label);
            this.tabPage2.Controls.Add(this.kitty_number_combo);
            this.tabPage2.Controls.Add(this.kitty_number_label);
            this.tabPage2.Controls.Add(this.title_tab2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(576, 474);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Spa/Treatment";
            // 
            // lblSeven
            // 
            this.lblSeven.AutoSize = true;
            this.lblSeven.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSeven.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeven.Location = new System.Drawing.Point(414, 416);
            this.lblSeven.Name = "lblSeven";
            this.lblSeven.Size = new System.Drawing.Size(33, 22);
            this.lblSeven.TabIndex = 21;
            this.lblSeven.Text = "OK";
            this.lblSeven.Visible = false;
            // 
            // lblSix
            // 
            this.lblSix.AutoSize = true;
            this.lblSix.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSix.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSix.Location = new System.Drawing.Point(414, 392);
            this.lblSix.Name = "lblSix";
            this.lblSix.Size = new System.Drawing.Size(33, 22);
            this.lblSix.TabIndex = 20;
            this.lblSix.Text = "OK";
            this.lblSix.Visible = false;
            // 
            // lblFive
            // 
            this.lblFive.AutoSize = true;
            this.lblFive.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFive.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFive.Location = new System.Drawing.Point(414, 368);
            this.lblFive.Name = "lblFive";
            this.lblFive.Size = new System.Drawing.Size(33, 22);
            this.lblFive.TabIndex = 19;
            this.lblFive.Text = "OK";
            this.lblFive.Visible = false;
            // 
            // lblFour
            // 
            this.lblFour.AutoSize = true;
            this.lblFour.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFour.Location = new System.Drawing.Point(236, 414);
            this.lblFour.Name = "lblFour";
            this.lblFour.Size = new System.Drawing.Size(33, 22);
            this.lblFour.TabIndex = 18;
            this.lblFour.Text = "OK";
            this.lblFour.Visible = false;
            // 
            // lblThree
            // 
            this.lblThree.AutoSize = true;
            this.lblThree.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblThree.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThree.Location = new System.Drawing.Point(236, 368);
            this.lblThree.Name = "lblThree";
            this.lblThree.Size = new System.Drawing.Size(33, 22);
            this.lblThree.TabIndex = 17;
            this.lblThree.Text = "OK";
            this.lblThree.Visible = false;
            // 
            // lblTwo
            // 
            this.lblTwo.AutoSize = true;
            this.lblTwo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTwo.Location = new System.Drawing.Point(55, 414);
            this.lblTwo.Name = "lblTwo";
            this.lblTwo.Size = new System.Drawing.Size(33, 22);
            this.lblTwo.TabIndex = 16;
            this.lblTwo.Text = "OK";
            this.lblTwo.Visible = false;
            // 
            // lblOne
            // 
            this.lblOne.AutoSize = true;
            this.lblOne.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOne.Location = new System.Drawing.Point(55, 368);
            this.lblOne.Name = "lblOne";
            this.lblOne.Size = new System.Drawing.Size(33, 22);
            this.lblOne.TabIndex = 15;
            this.lblOne.Text = "OK";
            this.lblOne.Visible = false;
            // 
            // extra_groupbox
            // 
            this.extra_groupbox.Controls.Add(this.nail_service_check);
            this.extra_groupbox.Controls.Add(this.comb_out_check);
            this.extra_groupbox.Controls.Add(this.spa_bath_check);
            this.extra_groupbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.extra_groupbox.Location = new System.Drawing.Point(339, 219);
            this.extra_groupbox.Name = "extra_groupbox";
            this.extra_groupbox.Size = new System.Drawing.Size(200, 121);
            this.extra_groupbox.TabIndex = 14;
            this.extra_groupbox.TabStop = false;
            this.extra_groupbox.Text = "Extra";
            // 
            // nail_service_check
            // 
            this.nail_service_check.AutoSize = true;
            this.nail_service_check.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nail_service_check.Location = new System.Drawing.Point(7, 89);
            this.nail_service_check.Name = "nail_service_check";
            this.nail_service_check.Size = new System.Drawing.Size(158, 21);
            this.nail_service_check.TabIndex = 2;
            this.nail_service_check.Text = "Nail Services - $5.75";
            this.nail_service_check.UseVisualStyleBackColor = true;
            this.nail_service_check.CheckedChanged += new System.EventHandler(this.nail_service_check_CheckedChanged);
            // 
            // comb_out_check
            // 
            this.comb_out_check.AutoSize = true;
            this.comb_out_check.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comb_out_check.Location = new System.Drawing.Point(7, 58);
            this.comb_out_check.Name = "comb_out_check";
            this.comb_out_check.Size = new System.Drawing.Size(148, 21);
            this.comb_out_check.TabIndex = 1;
            this.comb_out_check.Text = "Comb-Out - $10.50";
            this.comb_out_check.UseVisualStyleBackColor = true;
            this.comb_out_check.CheckedChanged += new System.EventHandler(this.comb_out_check_CheckedChanged);
            // 
            // spa_bath_check
            // 
            this.spa_bath_check.AutoSize = true;
            this.spa_bath_check.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spa_bath_check.Location = new System.Drawing.Point(7, 26);
            this.spa_bath_check.Name = "spa_bath_check";
            this.spa_bath_check.Size = new System.Drawing.Size(161, 21);
            this.spa_bath_check.TabIndex = 0;
            this.spa_bath_check.Text = "Spa Bathing - $15.00";
            this.spa_bath_check.UseVisualStyleBackColor = true;
            this.spa_bath_check.CheckedChanged += new System.EventHandler(this.spa_bath_check_CheckedChanged);
            // 
            // kitty_cut_groupbox
            // 
            this.kitty_cut_groupbox.Controls.Add(this.shave_radio);
            this.kitty_cut_groupbox.Controls.Add(this.trim_radio);
            this.kitty_cut_groupbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kitty_cut_groupbox.Location = new System.Drawing.Point(339, 88);
            this.kitty_cut_groupbox.Name = "kitty_cut_groupbox";
            this.kitty_cut_groupbox.Size = new System.Drawing.Size(200, 99);
            this.kitty_cut_groupbox.TabIndex = 13;
            this.kitty_cut_groupbox.TabStop = false;
            this.kitty_cut_groupbox.Text = "Kitty Cut";
            // 
            // shave_radio
            // 
            this.shave_radio.AutoSize = true;
            this.shave_radio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shave_radio.Location = new System.Drawing.Point(7, 62);
            this.shave_radio.Name = "shave_radio";
            this.shave_radio.Size = new System.Drawing.Size(123, 21);
            this.shave_radio.TabIndex = 1;
            this.shave_radio.TabStop = true;
            this.shave_radio.Text = "Shave - $24.50";
            this.shave_radio.UseVisualStyleBackColor = true;
            this.shave_radio.CheckedChanged += new System.EventHandler(this.shave_radio_CheckedChanged);
            // 
            // trim_radio
            // 
            this.trim_radio.AutoSize = true;
            this.trim_radio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trim_radio.Location = new System.Drawing.Point(7, 28);
            this.trim_radio.Name = "trim_radio";
            this.trim_radio.Size = new System.Drawing.Size(111, 21);
            this.trim_radio.TabIndex = 0;
            this.trim_radio.TabStop = true;
            this.trim_radio.Text = "Trim - $46.00";
            this.trim_radio.UseVisualStyleBackColor = true;
            this.trim_radio.CheckedChanged += new System.EventHandler(this.trim_radio_CheckedChanged);
            // 
            // spa_treatments_combo
            // 
            this.spa_treatments_combo.FormattingEnabled = true;
            this.spa_treatments_combo.Items.AddRange(new object[] {
            "Vaccinations - $22.75",
            "Neuters - $80.00",
            "Dental Care - $33.75",
            "Pay - Time - Free"});
            this.spa_treatments_combo.Location = new System.Drawing.Point(55, 319);
            this.spa_treatments_combo.Name = "spa_treatments_combo";
            this.spa_treatments_combo.Size = new System.Drawing.Size(188, 21);
            this.spa_treatments_combo.TabIndex = 12;
            this.spa_treatments_combo.SelectedValueChanged += new System.EventHandler(this.onSpaTreatmentsComboItemSelected);
            // 
            // spa_treatments_label
            // 
            this.spa_treatments_label.AutoSize = true;
            this.spa_treatments_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spa_treatments_label.Location = new System.Drawing.Point(56, 296);
            this.spa_treatments_label.Name = "spa_treatments_label";
            this.spa_treatments_label.Size = new System.Drawing.Size(137, 20);
            this.spa_treatments_label.TabIndex = 11;
            this.spa_treatments_label.Text = "Spa Treatments";
            // 
            // service_listview
            // 
            this.service_listview.FormattingEnabled = true;
            this.service_listview.Items.AddRange(new object[] {
            "Cat Message - $10.00",
            "Flea Dips - $25.00",
            "Microchip - $35.75",
            "Kitty Cuddle - $15.00"});
            this.service_listview.Location = new System.Drawing.Point(55, 194);
            this.service_listview.MultiColumn = true;
            this.service_listview.Name = "service_listview";
            this.service_listview.Size = new System.Drawing.Size(188, 69);
            this.service_listview.TabIndex = 10;
            this.service_listview.SelectedValueChanged += new System.EventHandler(this.onServiceListItemClicked);
            // 
            // service_listview_label
            // 
            this.service_listview_label.AutoSize = true;
            this.service_listview_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.service_listview_label.Location = new System.Drawing.Point(56, 167);
            this.service_listview_label.Name = "service_listview_label";
            this.service_listview_label.Size = new System.Drawing.Size(159, 20);
            this.service_listview_label.TabIndex = 9;
            this.service_listview_label.Text = "A La Carte Service";
            // 
            // kitty_number_combo
            // 
            this.kitty_number_combo.FormattingEnabled = true;
            this.kitty_number_combo.Items.AddRange(new object[] {
            1,
            2,
            3,
            4,
            5,
            6,
            7,
            8,
            9,
            10});
            this.kitty_number_combo.Location = new System.Drawing.Point(55, 114);
            this.kitty_number_combo.Name = "kitty_number_combo";
            this.kitty_number_combo.Size = new System.Drawing.Size(188, 21);
            this.kitty_number_combo.TabIndex = 8;
            this.kitty_number_combo.SelectedValueChanged += new System.EventHandler(this.onKittyNumberComboItemSelected);
            // 
            // kitty_number_label
            // 
            this.kitty_number_label.AutoSize = true;
            this.kitty_number_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kitty_number_label.Location = new System.Drawing.Point(55, 88);
            this.kitty_number_label.Name = "kitty_number_label";
            this.kitty_number_label.Size = new System.Drawing.Size(192, 20);
            this.kitty_number_label.TabIndex = 7;
            this.kitty_number_label.Text = "Number of Kitty Angels";
            // 
            // title_tab2
            // 
            this.title_tab2.AutoSize = true;
            this.title_tab2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_tab2.Location = new System.Drawing.Point(160, 24);
            this.title_tab2.Name = "title_tab2";
            this.title_tab2.Size = new System.Drawing.Size(246, 25);
            this.title_tab2.TabIndex = 4;
            this.title_tab2.Text = "Kitty Spa and Treatment";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 536);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(600, 575);
            this.MinimumSize = new System.Drawing.Size(600, 575);
            this.Name = "frmMain";
            this.Text = "Kitty Services";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.extra_groupbox.ResumeLayout(false);
            this.extra_groupbox.PerformLayout();
            this.kitty_cut_groupbox.ResumeLayout(false);
            this.kitty_cut_groupbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem calculateOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox name_textbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label title_tab1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox total_textbox;
        private System.Windows.Forms.Label title_tab2;
        private System.Windows.Forms.Label kitty_number_label;
        private System.Windows.Forms.Label service_listview_label;
        private System.Windows.Forms.ComboBox kitty_number_combo;
        private System.Windows.Forms.ListBox service_listview;
        private ComboBox spa_treatments_combo;
        private Label spa_treatments_label;
        private GroupBox kitty_cut_groupbox;
        private Label lblSeven;
        private Label lblSix;
        private Label lblFive;
        private Label lblFour;
        private Label lblThree;
        private Label lblTwo;
        private Label lblOne;
        private GroupBox extra_groupbox;
        private CheckBox nail_service_check;
        private CheckBox comb_out_check;
        private CheckBox spa_bath_check;
        private RadioButton shave_radio;
        private RadioButton trim_radio;
        private ToolStripMenuItem contactToolStripMenuItem;
    }
}

