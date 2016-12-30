namespace SaveMyHard.GUIs
{
    partial class Configurations
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Configurations));
            this.grd_Roots = new System.Windows.Forms.TableLayoutPanel();
            this.flow_Header = new System.Windows.Forms.FlowLayoutPanel();
            this.pc_Config = new System.Windows.Forms.PictureBox();
            this.lab_Title = new System.Windows.Forms.Label();
            this.grpBox_General = new System.Windows.Forms.GroupBox();
            this.flow_GeneralSettings = new System.Windows.Forms.FlowLayoutPanel();
            this.chk_EnableProtection = new System.Windows.Forms.CheckBox();
            this.chk_DisplayNotification = new System.Windows.Forms.CheckBox();
            this.chk_Startup = new System.Windows.Forms.CheckBox();
            this.grpBox_Protection = new System.Windows.Forms.GroupBox();
            this.flow_Protection = new System.Windows.Forms.FlowLayoutPanel();
            this.rad_DisableAll = new System.Windows.Forms.RadioButton();
            this.rad_DisableSize = new System.Windows.Forms.RadioButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.num_Size = new System.Windows.Forms.NumericUpDown();
            this.lab_SizeUnit = new System.Windows.Forms.Label();
            this.grd_Roots.SuspendLayout();
            this.flow_Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pc_Config)).BeginInit();
            this.grpBox_General.SuspendLayout();
            this.flow_GeneralSettings.SuspendLayout();
            this.grpBox_Protection.SuspendLayout();
            this.flow_Protection.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_Size)).BeginInit();
            this.SuspendLayout();
            // 
            // grd_Roots
            // 
            this.grd_Roots.BackColor = System.Drawing.Color.White;
            this.grd_Roots.ColumnCount = 1;
            this.grd_Roots.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.grd_Roots.Controls.Add(this.flow_Header, 0, 0);
            this.grd_Roots.Controls.Add(this.grpBox_General, 0, 1);
            this.grd_Roots.Controls.Add(this.grpBox_Protection, 0, 2);
            this.grd_Roots.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd_Roots.Location = new System.Drawing.Point(5, 5);
            this.grd_Roots.Name = "grd_Roots";
            this.grd_Roots.RowCount = 3;
            this.grd_Roots.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.grd_Roots.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.grd_Roots.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.grd_Roots.Size = new System.Drawing.Size(346, 391);
            this.grd_Roots.TabIndex = 0;
            // 
            // flow_Header
            // 
            this.flow_Header.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flow_Header.Controls.Add(this.pc_Config);
            this.flow_Header.Controls.Add(this.lab_Title);
            this.flow_Header.Location = new System.Drawing.Point(3, 3);
            this.flow_Header.Margin = new System.Windows.Forms.Padding(0);
            this.flow_Header.Name = "flow_Header";
            this.flow_Header.Size = new System.Drawing.Size(340, 44);
            this.flow_Header.TabIndex = 0;
            // 
            // pc_Config
            // 
            this.pc_Config.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pc_Config.Image = global::SaveMyHard.Properties.Resources.Settings;
            this.pc_Config.Location = new System.Drawing.Point(0, 0);
            this.pc_Config.Margin = new System.Windows.Forms.Padding(0);
            this.pc_Config.Name = "pc_Config";
            this.pc_Config.Size = new System.Drawing.Size(40, 40);
            this.pc_Config.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pc_Config.TabIndex = 0;
            this.pc_Config.TabStop = false;
            // 
            // lab_Title
            // 
            this.lab_Title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lab_Title.AutoSize = true;
            this.lab_Title.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Title.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lab_Title.Location = new System.Drawing.Point(43, 7);
            this.lab_Title.Name = "lab_Title";
            this.lab_Title.Size = new System.Drawing.Size(136, 26);
            this.lab_Title.TabIndex = 1;
            this.lab_Title.Text = "Configurations";
            // 
            // grpBox_General
            // 
            this.grpBox_General.Controls.Add(this.flow_GeneralSettings);
            this.grpBox_General.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBox_General.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBox_General.Location = new System.Drawing.Point(4, 52);
            this.grpBox_General.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.grpBox_General.Name = "grpBox_General";
            this.grpBox_General.Padding = new System.Windows.Forms.Padding(5);
            this.grpBox_General.Size = new System.Drawing.Size(338, 146);
            this.grpBox_General.TabIndex = 1;
            this.grpBox_General.TabStop = false;
            this.grpBox_General.Text = "General";
            // 
            // flow_GeneralSettings
            // 
            this.flow_GeneralSettings.Controls.Add(this.chk_EnableProtection);
            this.flow_GeneralSettings.Controls.Add(this.chk_DisplayNotification);
            this.flow_GeneralSettings.Controls.Add(this.chk_Startup);
            this.flow_GeneralSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flow_GeneralSettings.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flow_GeneralSettings.Location = new System.Drawing.Point(5, 29);
            this.flow_GeneralSettings.Name = "flow_GeneralSettings";
            this.flow_GeneralSettings.Size = new System.Drawing.Size(328, 112);
            this.flow_GeneralSettings.TabIndex = 0;
            // 
            // chk_EnableProtection
            // 
            this.chk_EnableProtection.AutoSize = true;
            this.chk_EnableProtection.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_EnableProtection.Location = new System.Drawing.Point(3, 3);
            this.chk_EnableProtection.Name = "chk_EnableProtection";
            this.chk_EnableProtection.Size = new System.Drawing.Size(143, 23);
            this.chk_EnableProtection.TabIndex = 0;
            this.chk_EnableProtection.Text = "Enable Protection";
            this.chk_EnableProtection.UseVisualStyleBackColor = true;
            this.chk_EnableProtection.CheckedChanged += new System.EventHandler(this.chk_Options_CheckedChanged);
            // 
            // chk_DisplayNotification
            // 
            this.chk_DisplayNotification.AutoSize = true;
            this.chk_DisplayNotification.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_DisplayNotification.Location = new System.Drawing.Point(3, 32);
            this.chk_DisplayNotification.Name = "chk_DisplayNotification";
            this.chk_DisplayNotification.Size = new System.Drawing.Size(160, 23);
            this.chk_DisplayNotification.TabIndex = 1;
            this.chk_DisplayNotification.Text = "Display Notifications";
            this.chk_DisplayNotification.UseVisualStyleBackColor = true;
            this.chk_DisplayNotification.CheckedChanged += new System.EventHandler(this.chk_DisplayNotification_CheckedChanged);
            // 
            // chk_Startup
            // 
            this.chk_Startup.AutoSize = true;
            this.chk_Startup.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_Startup.Location = new System.Drawing.Point(3, 61);
            this.chk_Startup.Name = "chk_Startup";
            this.chk_Startup.Size = new System.Drawing.Size(236, 23);
            this.chk_Startup.TabIndex = 2;
            this.chk_Startup.Text = "Start SMH when Windows starts";
            this.chk_Startup.UseVisualStyleBackColor = true;
            this.chk_Startup.CheckedChanged += new System.EventHandler(this.chk_Startup_CheckedChanged);
            // 
            // grpBox_Protection
            // 
            this.grpBox_Protection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.grpBox_Protection.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grpBox_Protection.Controls.Add(this.flow_Protection);
            this.grpBox_Protection.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBox_Protection.Location = new System.Drawing.Point(4, 202);
            this.grpBox_Protection.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.grpBox_Protection.Name = "grpBox_Protection";
            this.grpBox_Protection.Padding = new System.Windows.Forms.Padding(5);
            this.grpBox_Protection.Size = new System.Drawing.Size(338, 187);
            this.grpBox_Protection.TabIndex = 2;
            this.grpBox_Protection.TabStop = false;
            this.grpBox_Protection.Text = "Protection";
            // 
            // flow_Protection
            // 
            this.flow_Protection.Controls.Add(this.rad_DisableAll);
            this.flow_Protection.Controls.Add(this.rad_DisableSize);
            this.flow_Protection.Controls.Add(this.flowLayoutPanel1);
            this.flow_Protection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flow_Protection.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flow_Protection.Location = new System.Drawing.Point(5, 29);
            this.flow_Protection.Name = "flow_Protection";
            this.flow_Protection.Size = new System.Drawing.Size(328, 153);
            this.flow_Protection.TabIndex = 0;
            // 
            // rad_DisableAll
            // 
            this.rad_DisableAll.AutoSize = true;
            this.rad_DisableAll.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_DisableAll.Location = new System.Drawing.Point(3, 3);
            this.rad_DisableAll.Name = "rad_DisableAll";
            this.rad_DisableAll.Size = new System.Drawing.Size(211, 23);
            this.rad_DisableAll.TabIndex = 0;
            this.rad_DisableAll.TabStop = true;
            this.rad_DisableAll.Text = "Disable all format processes";
            this.rad_DisableAll.UseVisualStyleBackColor = true;
            this.rad_DisableAll.CheckedChanged += new System.EventHandler(this.chk_Options_CheckedChanged);
            // 
            // rad_DisableSize
            // 
            this.rad_DisableSize.AutoSize = true;
            this.rad_DisableSize.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_DisableSize.Location = new System.Drawing.Point(3, 32);
            this.rad_DisableSize.Name = "rad_DisableSize";
            this.rad_DisableSize.Size = new System.Drawing.Size(313, 42);
            this.rad_DisableSize.TabIndex = 1;
            this.rad_DisableSize.TabStop = true;
            this.rad_DisableSize.Text = "Disable format processes for disks with size \r\nmore than :";
            this.rad_DisableSize.UseVisualStyleBackColor = true;
            this.rad_DisableSize.CheckedChanged += new System.EventHandler(this.chk_Options_CheckedChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.flowLayoutPanel1.Controls.Add(this.num_Size);
            this.flowLayoutPanel1.Controls.Add(this.lab_SizeUnit);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 80);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 32);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // num_Size
            // 
            this.num_Size.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.num_Size.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_Size.Location = new System.Drawing.Point(3, 3);
            this.num_Size.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.num_Size.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_Size.Name = "num_Size";
            this.num_Size.Size = new System.Drawing.Size(120, 27);
            this.num_Size.TabIndex = 0;
            this.num_Size.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_Size.ValueChanged += new System.EventHandler(this.num_Size_ValueChanged);
            // 
            // lab_SizeUnit
            // 
            this.lab_SizeUnit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lab_SizeUnit.AutoSize = true;
            this.lab_SizeUnit.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_SizeUnit.Location = new System.Drawing.Point(129, 7);
            this.lab_SizeUnit.Name = "lab_SizeUnit";
            this.lab_SizeUnit.Size = new System.Drawing.Size(28, 19);
            this.lab_SizeUnit.TabIndex = 1;
            this.lab_SizeUnit.Text = "GB";
            // 
            // Configurations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(356, 401);
            this.Controls.Add(this.grd_Roots);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Configurations";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Save my hard";
            this.grd_Roots.ResumeLayout(false);
            this.flow_Header.ResumeLayout(false);
            this.flow_Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pc_Config)).EndInit();
            this.grpBox_General.ResumeLayout(false);
            this.flow_GeneralSettings.ResumeLayout(false);
            this.flow_GeneralSettings.PerformLayout();
            this.grpBox_Protection.ResumeLayout(false);
            this.flow_Protection.ResumeLayout(false);
            this.flow_Protection.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_Size)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel grd_Roots;
        private System.Windows.Forms.FlowLayoutPanel flow_Header;
        private System.Windows.Forms.PictureBox pc_Config;
        private System.Windows.Forms.Label lab_Title;
        private System.Windows.Forms.GroupBox grpBox_General;
        private System.Windows.Forms.FlowLayoutPanel flow_GeneralSettings;
        private System.Windows.Forms.CheckBox chk_EnableProtection;
        private System.Windows.Forms.CheckBox chk_DisplayNotification;
        private System.Windows.Forms.CheckBox chk_Startup;
        private System.Windows.Forms.GroupBox grpBox_Protection;
        private System.Windows.Forms.FlowLayoutPanel flow_Protection;
        private System.Windows.Forms.RadioButton rad_DisableAll;
        private System.Windows.Forms.RadioButton rad_DisableSize;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.NumericUpDown num_Size;
        private System.Windows.Forms.Label lab_SizeUnit;
    }
}