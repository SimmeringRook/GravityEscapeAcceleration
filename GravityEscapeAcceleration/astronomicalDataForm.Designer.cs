namespace SurfaceGravityCalculator
{
    partial class AstronomicalDataForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.loadedObjectsCombo = new System.Windows.Forms.ComboBox();
            this.massTextBox = new System.Windows.Forms.TextBox();
            this.massUnitsCombo = new System.Windows.Forms.ComboBox();
            this.massLabel = new System.Windows.Forms.Label();
            this.radiusLabel = new System.Windows.Forms.Label();
            this.radiusUnitsCombo = new System.Windows.Forms.ComboBox();
            this.radiusTextBox = new System.Windows.Forms.TextBox();
            this.radiusExponentLabel = new System.Windows.Forms.Label();
            this.radiusExponentTextBox = new System.Windows.Forms.TextBox();
            this.massExponentLabel = new System.Windows.Forms.Label();
            this.massExponentTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.dataTabControl = new System.Windows.Forms.TabControl();
            this.viewDataTabPage = new System.Windows.Forms.TabPage();
            this.intensityLabel = new System.Windows.Forms.Label();
            this.distanceTextBox = new System.Windows.Forms.TextBox();
            this.distanceTrackBar = new System.Windows.Forms.TrackBar();
            this.unitsLabel2 = new System.Windows.Forms.Label();
            this.unitsLabel1 = new System.Windows.Forms.Label();
            this.gravityOutputTextBox = new System.Windows.Forms.TextBox();
            this.distanceLabel = new System.Windows.Forms.Label();
            this.addDataTabPage = new System.Windows.Forms.TabPage();
            this.add_GravityLabel = new System.Windows.Forms.Label();
            this.add_DistanceTextBox = new System.Windows.Forms.TextBox();
            this.add_DistanceTrackBar = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.add_IntensityTextBox = new System.Windows.Forms.TextBox();
            this.add_DistanceLabel = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.saveCheckBox = new System.Windows.Forms.CheckBox();
            this.add_NameLabel = new System.Windows.Forms.Label();
            this.add_MassTextBox = new System.Windows.Forms.TextBox();
            this.add_NameTextBox = new System.Windows.Forms.TextBox();
            this.add_MassUnitComboBox = new System.Windows.Forms.ComboBox();
            this.add_RadiusExponentLabel = new System.Windows.Forms.Label();
            this.add_MassLabel = new System.Windows.Forms.Label();
            this.add_RadiusExponentTextBox = new System.Windows.Forms.TextBox();
            this.add_RadiusTextBox = new System.Windows.Forms.TextBox();
            this.add_MassExponentLabel = new System.Windows.Forms.Label();
            this.add_RadiusUnitComboBox = new System.Windows.Forms.ComboBox();
            this.add_MassExponentTextBox = new System.Windows.Forms.TextBox();
            this.add_RadiusLabel = new System.Windows.Forms.Label();
            this.add_CalculateButton = new System.Windows.Forms.Button();
            this.dataTabControl.SuspendLayout();
            this.viewDataTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.distanceTrackBar)).BeginInit();
            this.addDataTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.add_DistanceTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // loadedObjectsCombo
            // 
            this.loadedObjectsCombo.FormattingEnabled = true;
            this.loadedObjectsCombo.Items.AddRange(new object[] {
            "--Select a loaded Astronomical Object--"});
            this.loadedObjectsCombo.Location = new System.Drawing.Point(166, 21);
            this.loadedObjectsCombo.Name = "loadedObjectsCombo";
            this.loadedObjectsCombo.Size = new System.Drawing.Size(319, 33);
            this.loadedObjectsCombo.TabIndex = 0;
            this.loadedObjectsCombo.Text = "    --Select Prexisiting Data--";
            this.loadedObjectsCombo.SelectedIndexChanged += new System.EventHandler(this.loadedObjectsCombo_SelectedIndexChanged);
            // 
            // massTextBox
            // 
            this.massTextBox.Enabled = false;
            this.massTextBox.Location = new System.Drawing.Point(140, 145);
            this.massTextBox.Name = "massTextBox";
            this.massTextBox.ReadOnly = true;
            this.massTextBox.Size = new System.Drawing.Size(100, 31);
            this.massTextBox.TabIndex = 2;
            // 
            // massUnitsCombo
            // 
            this.massUnitsCombo.Enabled = false;
            this.massUnitsCombo.FormattingEnabled = true;
            this.massUnitsCombo.Items.AddRange(new object[] {
            "kilograms",
            "Solar Masses"});
            this.massUnitsCombo.Location = new System.Drawing.Point(446, 144);
            this.massUnitsCombo.Name = "massUnitsCombo";
            this.massUnitsCombo.Size = new System.Drawing.Size(197, 33);
            this.massUnitsCombo.TabIndex = 4;
            // 
            // massLabel
            // 
            this.massLabel.AutoSize = true;
            this.massLabel.Location = new System.Drawing.Point(52, 149);
            this.massLabel.Name = "massLabel";
            this.massLabel.Size = new System.Drawing.Size(70, 25);
            this.massLabel.TabIndex = 3;
            this.massLabel.Text = "Mass:";
            // 
            // radiusLabel
            // 
            this.radiusLabel.AutoSize = true;
            this.radiusLabel.Location = new System.Drawing.Point(52, 201);
            this.radiusLabel.Name = "radiusLabel";
            this.radiusLabel.Size = new System.Drawing.Size(85, 25);
            this.radiusLabel.TabIndex = 6;
            this.radiusLabel.Text = "Radius:";
            // 
            // radiusUnitsCombo
            // 
            this.radiusUnitsCombo.Enabled = false;
            this.radiusUnitsCombo.FormattingEnabled = true;
            this.radiusUnitsCombo.Items.AddRange(new object[] {
            "meters",
            "kilometers"});
            this.radiusUnitsCombo.Location = new System.Drawing.Point(446, 196);
            this.radiusUnitsCombo.Name = "radiusUnitsCombo";
            this.radiusUnitsCombo.Size = new System.Drawing.Size(197, 33);
            this.radiusUnitsCombo.TabIndex = 7;
            // 
            // radiusTextBox
            // 
            this.radiusTextBox.Enabled = false;
            this.radiusTextBox.Location = new System.Drawing.Point(140, 197);
            this.radiusTextBox.Name = "radiusTextBox";
            this.radiusTextBox.ReadOnly = true;
            this.radiusTextBox.Size = new System.Drawing.Size(100, 31);
            this.radiusTextBox.TabIndex = 5;
            // 
            // radiusExponentLabel
            // 
            this.radiusExponentLabel.AutoSize = true;
            this.radiusExponentLabel.Location = new System.Drawing.Point(247, 201);
            this.radiusExponentLabel.Name = "radiusExponentLabel";
            this.radiusExponentLabel.Size = new System.Drawing.Size(69, 25);
            this.radiusExponentLabel.TabIndex = 11;
            this.radiusExponentLabel.Text = "x 10 ^";
            this.radiusExponentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // radiusExponentTextBox
            // 
            this.radiusExponentTextBox.Enabled = false;
            this.radiusExponentTextBox.Location = new System.Drawing.Point(335, 197);
            this.radiusExponentTextBox.Name = "radiusExponentTextBox";
            this.radiusExponentTextBox.ReadOnly = true;
            this.radiusExponentTextBox.Size = new System.Drawing.Size(100, 31);
            this.radiusExponentTextBox.TabIndex = 6;
            // 
            // massExponentLabel
            // 
            this.massExponentLabel.AutoSize = true;
            this.massExponentLabel.Location = new System.Drawing.Point(247, 149);
            this.massExponentLabel.Name = "massExponentLabel";
            this.massExponentLabel.Size = new System.Drawing.Size(69, 25);
            this.massExponentLabel.TabIndex = 9;
            this.massExponentLabel.Text = "x 10 ^";
            this.massExponentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // massExponentTextBox
            // 
            this.massExponentTextBox.Enabled = false;
            this.massExponentTextBox.Location = new System.Drawing.Point(335, 145);
            this.massExponentTextBox.Name = "massExponentTextBox";
            this.massExponentTextBox.ReadOnly = true;
            this.massExponentTextBox.Size = new System.Drawing.Size(100, 31);
            this.massExponentTextBox.TabIndex = 3;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(52, 101);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(74, 25);
            this.nameLabel.TabIndex = 13;
            this.nameLabel.Text = "Name:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Enabled = false;
            this.nameTextBox.Location = new System.Drawing.Point(140, 97);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.ReadOnly = true;
            this.nameTextBox.Size = new System.Drawing.Size(295, 31);
            this.nameTextBox.TabIndex = 1;
            // 
            // dataTabControl
            // 
            this.dataTabControl.Controls.Add(this.viewDataTabPage);
            this.dataTabControl.Controls.Add(this.addDataTabPage);
            this.dataTabControl.Location = new System.Drawing.Point(-3, 0);
            this.dataTabControl.Name = "dataTabControl";
            this.dataTabControl.SelectedIndex = 0;
            this.dataTabControl.Size = new System.Drawing.Size(702, 496);
            this.dataTabControl.TabIndex = 14;
            // 
            // viewDataTabPage
            // 
            this.viewDataTabPage.Controls.Add(this.intensityLabel);
            this.viewDataTabPage.Controls.Add(this.distanceTextBox);
            this.viewDataTabPage.Controls.Add(this.distanceTrackBar);
            this.viewDataTabPage.Controls.Add(this.unitsLabel2);
            this.viewDataTabPage.Controls.Add(this.unitsLabel1);
            this.viewDataTabPage.Controls.Add(this.gravityOutputTextBox);
            this.viewDataTabPage.Controls.Add(this.distanceLabel);
            this.viewDataTabPage.Controls.Add(this.loadedObjectsCombo);
            this.viewDataTabPage.Controls.Add(this.nameLabel);
            this.viewDataTabPage.Controls.Add(this.massTextBox);
            this.viewDataTabPage.Controls.Add(this.nameTextBox);
            this.viewDataTabPage.Controls.Add(this.massUnitsCombo);
            this.viewDataTabPage.Controls.Add(this.radiusExponentLabel);
            this.viewDataTabPage.Controls.Add(this.massLabel);
            this.viewDataTabPage.Controls.Add(this.radiusExponentTextBox);
            this.viewDataTabPage.Controls.Add(this.radiusTextBox);
            this.viewDataTabPage.Controls.Add(this.massExponentLabel);
            this.viewDataTabPage.Controls.Add(this.radiusUnitsCombo);
            this.viewDataTabPage.Controls.Add(this.massExponentTextBox);
            this.viewDataTabPage.Controls.Add(this.radiusLabel);
            this.viewDataTabPage.Location = new System.Drawing.Point(4, 34);
            this.viewDataTabPage.Name = "viewDataTabPage";
            this.viewDataTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.viewDataTabPage.Size = new System.Drawing.Size(694, 458);
            this.viewDataTabPage.TabIndex = 0;
            this.viewDataTabPage.Text = "View Existing Data";
            this.viewDataTabPage.UseVisualStyleBackColor = true;
            // 
            // intensityLabel
            // 
            this.intensityLabel.AutoSize = true;
            this.intensityLabel.Location = new System.Drawing.Point(49, 394);
            this.intensityLabel.Name = "intensityLabel";
            this.intensityLabel.Size = new System.Drawing.Size(240, 25);
            this.intensityLabel.TabIndex = 20;
            this.intensityLabel.Text = "Acceleration by Gravity:";
            // 
            // distanceTextBox
            // 
            this.distanceTextBox.Enabled = false;
            this.distanceTextBox.Location = new System.Drawing.Point(278, 349);
            this.distanceTextBox.Name = "distanceTextBox";
            this.distanceTextBox.ReadOnly = true;
            this.distanceTextBox.Size = new System.Drawing.Size(275, 31);
            this.distanceTextBox.TabIndex = 19;
            // 
            // distanceTrackBar
            // 
            this.distanceTrackBar.Location = new System.Drawing.Point(54, 248);
            this.distanceTrackBar.Name = "distanceTrackBar";
            this.distanceTrackBar.Size = new System.Drawing.Size(586, 90);
            this.distanceTrackBar.TabIndex = 18;
            this.distanceTrackBar.Scroll += new System.EventHandler(this.distanceTrackBar_Scroll);
            // 
            // unitsLabel2
            // 
            this.unitsLabel2.AutoSize = true;
            this.unitsLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unitsLabel2.Location = new System.Drawing.Point(422, 410);
            this.unitsLabel2.Name = "unitsLabel2";
            this.unitsLabel2.Size = new System.Drawing.Size(45, 25);
            this.unitsLabel2.TabIndex = 17;
            this.unitsLabel2.Text = "s^2";
            // 
            // unitsLabel1
            // 
            this.unitsLabel1.AutoSize = true;
            this.unitsLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unitsLabel1.Location = new System.Drawing.Point(422, 385);
            this.unitsLabel1.Name = "unitsLabel1";
            this.unitsLabel1.Size = new System.Drawing.Size(41, 25);
            this.unitsLabel1.TabIndex = 16;
            this.unitsLabel1.Text = " m ";
            // 
            // gravityOutputTextBox
            // 
            this.gravityOutputTextBox.Enabled = false;
            this.gravityOutputTextBox.Location = new System.Drawing.Point(301, 391);
            this.gravityOutputTextBox.Name = "gravityOutputTextBox";
            this.gravityOutputTextBox.Size = new System.Drawing.Size(100, 31);
            this.gravityOutputTextBox.TabIndex = 8;
            // 
            // distanceLabel
            // 
            this.distanceLabel.AutoSize = true;
            this.distanceLabel.Location = new System.Drawing.Point(49, 352);
            this.distanceLabel.Name = "distanceLabel";
            this.distanceLabel.Size = new System.Drawing.Size(227, 25);
            this.distanceLabel.TabIndex = 14;
            this.distanceLabel.Text = "Distance from surface:";
            // 
            // addDataTabPage
            // 
            this.addDataTabPage.Controls.Add(this.add_GravityLabel);
            this.addDataTabPage.Controls.Add(this.add_DistanceTextBox);
            this.addDataTabPage.Controls.Add(this.add_DistanceTrackBar);
            this.addDataTabPage.Controls.Add(this.label5);
            this.addDataTabPage.Controls.Add(this.label6);
            this.addDataTabPage.Controls.Add(this.add_IntensityTextBox);
            this.addDataTabPage.Controls.Add(this.add_DistanceLabel);
            this.addDataTabPage.Controls.Add(this.clearButton);
            this.addDataTabPage.Controls.Add(this.saveCheckBox);
            this.addDataTabPage.Controls.Add(this.add_NameLabel);
            this.addDataTabPage.Controls.Add(this.add_MassTextBox);
            this.addDataTabPage.Controls.Add(this.add_NameTextBox);
            this.addDataTabPage.Controls.Add(this.add_MassUnitComboBox);
            this.addDataTabPage.Controls.Add(this.add_RadiusExponentLabel);
            this.addDataTabPage.Controls.Add(this.add_MassLabel);
            this.addDataTabPage.Controls.Add(this.add_RadiusExponentTextBox);
            this.addDataTabPage.Controls.Add(this.add_RadiusTextBox);
            this.addDataTabPage.Controls.Add(this.add_MassExponentLabel);
            this.addDataTabPage.Controls.Add(this.add_RadiusUnitComboBox);
            this.addDataTabPage.Controls.Add(this.add_MassExponentTextBox);
            this.addDataTabPage.Controls.Add(this.add_RadiusLabel);
            this.addDataTabPage.Controls.Add(this.add_CalculateButton);
            this.addDataTabPage.Location = new System.Drawing.Point(4, 34);
            this.addDataTabPage.Name = "addDataTabPage";
            this.addDataTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.addDataTabPage.Size = new System.Drawing.Size(694, 458);
            this.addDataTabPage.TabIndex = 1;
            this.addDataTabPage.Text = "Add New Data";
            this.addDataTabPage.UseVisualStyleBackColor = true;
            // 
            // add_GravityLabel
            // 
            this.add_GravityLabel.AutoSize = true;
            this.add_GravityLabel.Location = new System.Drawing.Point(52, 396);
            this.add_GravityLabel.Name = "add_GravityLabel";
            this.add_GravityLabel.Size = new System.Drawing.Size(240, 25);
            this.add_GravityLabel.TabIndex = 40;
            this.add_GravityLabel.Text = "Acceleration by Gravity:";
            // 
            // add_DistanceTextBox
            // 
            this.add_DistanceTextBox.Enabled = false;
            this.add_DistanceTextBox.Location = new System.Drawing.Point(281, 351);
            this.add_DistanceTextBox.Name = "add_DistanceTextBox";
            this.add_DistanceTextBox.ReadOnly = true;
            this.add_DistanceTextBox.Size = new System.Drawing.Size(275, 31);
            this.add_DistanceTextBox.TabIndex = 39;
            // 
            // add_DistanceTrackBar
            // 
            this.add_DistanceTrackBar.Location = new System.Drawing.Point(57, 250);
            this.add_DistanceTrackBar.Name = "add_DistanceTrackBar";
            this.add_DistanceTrackBar.Size = new System.Drawing.Size(586, 90);
            this.add_DistanceTrackBar.TabIndex = 38;
            this.add_DistanceTrackBar.Scroll += new System.EventHandler(this.add_DistanceTrackBar_Scroll);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(425, 412);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 25);
            this.label5.TabIndex = 37;
            this.label5.Text = "s^2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(425, 387);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 25);
            this.label6.TabIndex = 36;
            this.label6.Text = " m ";
            // 
            // add_IntensityTextBox
            // 
            this.add_IntensityTextBox.Enabled = false;
            this.add_IntensityTextBox.Location = new System.Drawing.Point(304, 393);
            this.add_IntensityTextBox.Name = "add_IntensityTextBox";
            this.add_IntensityTextBox.Size = new System.Drawing.Size(100, 31);
            this.add_IntensityTextBox.TabIndex = 34;
            // 
            // add_DistanceLabel
            // 
            this.add_DistanceLabel.AutoSize = true;
            this.add_DistanceLabel.Location = new System.Drawing.Point(52, 354);
            this.add_DistanceLabel.Name = "add_DistanceLabel";
            this.add_DistanceLabel.Size = new System.Drawing.Size(227, 25);
            this.add_DistanceLabel.TabIndex = 35;
            this.add_DistanceLabel.Text = "Distance from surface:";
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(507, 35);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(137, 40);
            this.clearButton.TabIndex = 33;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // saveCheckBox
            // 
            this.saveCheckBox.AutoSize = true;
            this.saveCheckBox.Location = new System.Drawing.Point(170, 194);
            this.saveCheckBox.Name = "saveCheckBox";
            this.saveCheckBox.Size = new System.Drawing.Size(93, 29);
            this.saveCheckBox.TabIndex = 32;
            this.saveCheckBox.Text = "Save";
            this.saveCheckBox.UseVisualStyleBackColor = true;
            // 
            // add_NameLabel
            // 
            this.add_NameLabel.AutoSize = true;
            this.add_NameLabel.Location = new System.Drawing.Point(50, 43);
            this.add_NameLabel.Name = "add_NameLabel";
            this.add_NameLabel.Size = new System.Drawing.Size(74, 25);
            this.add_NameLabel.TabIndex = 27;
            this.add_NameLabel.Text = "Name:";
            // 
            // add_MassTextBox
            // 
            this.add_MassTextBox.Location = new System.Drawing.Point(138, 87);
            this.add_MassTextBox.Name = "add_MassTextBox";
            this.add_MassTextBox.Size = new System.Drawing.Size(100, 31);
            this.add_MassTextBox.TabIndex = 15;
            this.add_MassTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.add_MassTextBox_KeyPress);
            // 
            // add_NameTextBox
            // 
            this.add_NameTextBox.Location = new System.Drawing.Point(138, 39);
            this.add_NameTextBox.Name = "add_NameTextBox";
            this.add_NameTextBox.Size = new System.Drawing.Size(295, 31);
            this.add_NameTextBox.TabIndex = 26;
            // 
            // add_MassUnitComboBox
            // 
            this.add_MassUnitComboBox.FormattingEnabled = true;
            this.add_MassUnitComboBox.Items.AddRange(new object[] {
            "kilograms",
            "Solar Masses"});
            this.add_MassUnitComboBox.Location = new System.Drawing.Point(444, 86);
            this.add_MassUnitComboBox.Name = "add_MassUnitComboBox";
            this.add_MassUnitComboBox.Size = new System.Drawing.Size(200, 33);
            this.add_MassUnitComboBox.TabIndex = 16;
            // 
            // add_RadiusExponentLabel
            // 
            this.add_RadiusExponentLabel.AutoSize = true;
            this.add_RadiusExponentLabel.Location = new System.Drawing.Point(245, 143);
            this.add_RadiusExponentLabel.Name = "add_RadiusExponentLabel";
            this.add_RadiusExponentLabel.Size = new System.Drawing.Size(69, 25);
            this.add_RadiusExponentLabel.TabIndex = 25;
            this.add_RadiusExponentLabel.Text = "x 10 ^";
            this.add_RadiusExponentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // add_MassLabel
            // 
            this.add_MassLabel.AutoSize = true;
            this.add_MassLabel.Location = new System.Drawing.Point(50, 91);
            this.add_MassLabel.Name = "add_MassLabel";
            this.add_MassLabel.Size = new System.Drawing.Size(70, 25);
            this.add_MassLabel.TabIndex = 17;
            this.add_MassLabel.Text = "Mass:";
            // 
            // add_RadiusExponentTextBox
            // 
            this.add_RadiusExponentTextBox.Location = new System.Drawing.Point(333, 139);
            this.add_RadiusExponentTextBox.Name = "add_RadiusExponentTextBox";
            this.add_RadiusExponentTextBox.Size = new System.Drawing.Size(100, 31);
            this.add_RadiusExponentTextBox.TabIndex = 24;
            this.add_RadiusExponentTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.add_RadiusExponentTextBox_KeyPress);
            // 
            // add_RadiusTextBox
            // 
            this.add_RadiusTextBox.Location = new System.Drawing.Point(138, 139);
            this.add_RadiusTextBox.Name = "add_RadiusTextBox";
            this.add_RadiusTextBox.Size = new System.Drawing.Size(100, 31);
            this.add_RadiusTextBox.TabIndex = 18;
            this.add_RadiusTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.add_RadiusTextBox_KeyPress);
            // 
            // add_MassExponentLabel
            // 
            this.add_MassExponentLabel.AutoSize = true;
            this.add_MassExponentLabel.Location = new System.Drawing.Point(245, 91);
            this.add_MassExponentLabel.Name = "add_MassExponentLabel";
            this.add_MassExponentLabel.Size = new System.Drawing.Size(69, 25);
            this.add_MassExponentLabel.TabIndex = 23;
            this.add_MassExponentLabel.Text = "x 10 ^";
            this.add_MassExponentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // add_RadiusUnitComboBox
            // 
            this.add_RadiusUnitComboBox.FormattingEnabled = true;
            this.add_RadiusUnitComboBox.Items.AddRange(new object[] {
            "meters",
            "kilometers"});
            this.add_RadiusUnitComboBox.Location = new System.Drawing.Point(444, 138);
            this.add_RadiusUnitComboBox.Name = "add_RadiusUnitComboBox";
            this.add_RadiusUnitComboBox.Size = new System.Drawing.Size(200, 33);
            this.add_RadiusUnitComboBox.TabIndex = 19;
            // 
            // add_MassExponentTextBox
            // 
            this.add_MassExponentTextBox.Location = new System.Drawing.Point(333, 87);
            this.add_MassExponentTextBox.Name = "add_MassExponentTextBox";
            this.add_MassExponentTextBox.Size = new System.Drawing.Size(100, 31);
            this.add_MassExponentTextBox.TabIndex = 22;
            this.add_MassExponentTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.add_MassExponentTextBox_KeyPress);
            // 
            // add_RadiusLabel
            // 
            this.add_RadiusLabel.AutoSize = true;
            this.add_RadiusLabel.Location = new System.Drawing.Point(50, 143);
            this.add_RadiusLabel.Name = "add_RadiusLabel";
            this.add_RadiusLabel.Size = new System.Drawing.Size(85, 25);
            this.add_RadiusLabel.TabIndex = 20;
            this.add_RadiusLabel.Text = "Radius:";
            // 
            // add_CalculateButton
            // 
            this.add_CalculateButton.Location = new System.Drawing.Point(340, 187);
            this.add_CalculateButton.Name = "add_CalculateButton";
            this.add_CalculateButton.Size = new System.Drawing.Size(137, 40);
            this.add_CalculateButton.TabIndex = 21;
            this.add_CalculateButton.Text = "Calculate";
            this.add_CalculateButton.UseVisualStyleBackColor = true;
            this.add_CalculateButton.Click += new System.EventHandler(this.add_CalculateButton_Click);
            // 
            // AstronomicalDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 487);
            this.Controls.Add(this.dataTabControl);
            this.Name = "AstronomicalDataForm";
            this.Text = "Astronomical Data";
            this.dataTabControl.ResumeLayout(false);
            this.viewDataTabPage.ResumeLayout(false);
            this.viewDataTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.distanceTrackBar)).EndInit();
            this.addDataTabPage.ResumeLayout(false);
            this.addDataTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.add_DistanceTrackBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox loadedObjectsCombo;
        private System.Windows.Forms.TextBox massTextBox;
        private System.Windows.Forms.ComboBox massUnitsCombo;
        private System.Windows.Forms.Label massLabel;
        private System.Windows.Forms.Label radiusLabel;
        private System.Windows.Forms.ComboBox radiusUnitsCombo;
        private System.Windows.Forms.TextBox radiusTextBox;
        private System.Windows.Forms.Label radiusExponentLabel;
        private System.Windows.Forms.TextBox radiusExponentTextBox;
        private System.Windows.Forms.Label massExponentLabel;
        private System.Windows.Forms.TextBox massExponentTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TabControl dataTabControl;
        private System.Windows.Forms.TabPage viewDataTabPage;
        private System.Windows.Forms.TabPage addDataTabPage;
        private System.Windows.Forms.Label add_NameLabel;
        private System.Windows.Forms.TextBox add_MassTextBox;
        private System.Windows.Forms.TextBox add_NameTextBox;
        private System.Windows.Forms.ComboBox add_MassUnitComboBox;
        private System.Windows.Forms.Label add_RadiusExponentLabel;
        private System.Windows.Forms.Label add_MassLabel;
        private System.Windows.Forms.TextBox add_RadiusExponentTextBox;
        private System.Windows.Forms.TextBox add_RadiusTextBox;
        private System.Windows.Forms.Label add_MassExponentLabel;
        private System.Windows.Forms.ComboBox add_RadiusUnitComboBox;
        private System.Windows.Forms.TextBox add_MassExponentTextBox;
        private System.Windows.Forms.Label add_RadiusLabel;
        private System.Windows.Forms.Button add_CalculateButton;
        private System.Windows.Forms.Label distanceLabel;
        private System.Windows.Forms.Label unitsLabel2;
        private System.Windows.Forms.Label unitsLabel1;
        private System.Windows.Forms.TextBox gravityOutputTextBox;
        private System.Windows.Forms.CheckBox saveCheckBox;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.TrackBar distanceTrackBar;
        private System.Windows.Forms.Label intensityLabel;
        private System.Windows.Forms.TextBox distanceTextBox;
        private System.Windows.Forms.Label add_GravityLabel;
        private System.Windows.Forms.TextBox add_DistanceTextBox;
        private System.Windows.Forms.TrackBar add_DistanceTrackBar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox add_IntensityTextBox;
        private System.Windows.Forms.Label add_DistanceLabel;
    }
}