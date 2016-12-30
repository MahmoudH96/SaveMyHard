namespace SaveMyHard.GUIs
{
    partial class About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            this.grd_Root = new System.Windows.Forms.TableLayoutPanel();
            this.pc_Logo = new System.Windows.Forms.PictureBox();
            this.grd_Content = new System.Windows.Forms.TableLayoutPanel();
            this.lab_Title = new System.Windows.Forms.Label();
            this.lab_Dev = new System.Windows.Forms.Label();
            this.link_Dev = new System.Windows.Forms.LinkLabel();
            this.link_GitHub = new System.Windows.Forms.LinkLabel();
            this.link_MIT = new System.Windows.Forms.LinkLabel();
            this.grd_Root.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pc_Logo)).BeginInit();
            this.grd_Content.SuspendLayout();
            this.SuspendLayout();
            // 
            // grd_Root
            // 
            this.grd_Root.ColumnCount = 2;
            this.grd_Root.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.grd_Root.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.grd_Root.Controls.Add(this.pc_Logo, 0, 0);
            this.grd_Root.Controls.Add(this.grd_Content, 1, 0);
            this.grd_Root.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd_Root.Location = new System.Drawing.Point(0, 0);
            this.grd_Root.Margin = new System.Windows.Forms.Padding(10);
            this.grd_Root.Name = "grd_Root";
            this.grd_Root.RowCount = 1;
            this.grd_Root.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.grd_Root.Size = new System.Drawing.Size(428, 141);
            this.grd_Root.TabIndex = 0;
            // 
            // pc_Logo
            // 
            this.pc_Logo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pc_Logo.Image = global::SaveMyHard.Properties.Resources.Hard;
            this.pc_Logo.Location = new System.Drawing.Point(3, 3);
            this.pc_Logo.Name = "pc_Logo";
            this.pc_Logo.Size = new System.Drawing.Size(122, 135);
            this.pc_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pc_Logo.TabIndex = 0;
            this.pc_Logo.TabStop = false;
            // 
            // grd_Content
            // 
            this.grd_Content.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grd_Content.ColumnCount = 2;
            this.grd_Content.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.grd_Content.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.grd_Content.Controls.Add(this.lab_Title, 0, 0);
            this.grd_Content.Controls.Add(this.lab_Dev, 0, 1);
            this.grd_Content.Controls.Add(this.link_Dev, 1, 1);
            this.grd_Content.Controls.Add(this.link_GitHub, 0, 2);
            this.grd_Content.Controls.Add(this.link_MIT, 0, 3);
            this.grd_Content.Location = new System.Drawing.Point(131, 3);
            this.grd_Content.Name = "grd_Content";
            this.grd_Content.RowCount = 4;
            this.grd_Content.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.grd_Content.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.grd_Content.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.grd_Content.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.grd_Content.Size = new System.Drawing.Size(294, 135);
            this.grd_Content.TabIndex = 1;
            // 
            // lab_Title
            // 
            this.lab_Title.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lab_Title.AutoSize = true;
            this.grd_Content.SetColumnSpan(this.lab_Title, 2);
            this.lab_Title.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Title.Location = new System.Drawing.Point(3, 3);
            this.lab_Title.Margin = new System.Windows.Forms.Padding(3);
            this.lab_Title.Name = "lab_Title";
            this.lab_Title.Size = new System.Drawing.Size(150, 29);
            this.lab_Title.TabIndex = 0;
            this.lab_Title.Text = "Save My Hard";
            // 
            // lab_Dev
            // 
            this.lab_Dev.AutoSize = true;
            this.lab_Dev.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Dev.Location = new System.Drawing.Point(3, 38);
            this.lab_Dev.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.lab_Dev.Name = "lab_Dev";
            this.lab_Dev.Size = new System.Drawing.Size(106, 19);
            this.lab_Dev.TabIndex = 1;
            this.lab_Dev.Text = "Developed By :";
            // 
            // link_Dev
            // 
            this.link_Dev.ActiveLinkColor = System.Drawing.Color.Black;
            this.link_Dev.AutoSize = true;
            this.link_Dev.DisabledLinkColor = System.Drawing.Color.Black;
            this.link_Dev.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.link_Dev.LinkColor = System.Drawing.Color.Black;
            this.link_Dev.Location = new System.Drawing.Point(109, 38);
            this.link_Dev.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.link_Dev.Name = "link_Dev";
            this.link_Dev.Size = new System.Drawing.Size(137, 19);
            this.link_Dev.TabIndex = 2;
            this.link_Dev.TabStop = true;
            this.link_Dev.Text = "Mahmoud Heretani";
            this.link_Dev.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_Dev_LinkClicked);
            // 
            // link_GitHub
            // 
            this.link_GitHub.ActiveLinkColor = System.Drawing.Color.Black;
            this.link_GitHub.AutoSize = true;
            this.grd_Content.SetColumnSpan(this.link_GitHub, 2);
            this.link_GitHub.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.link_GitHub.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.link_GitHub.LinkColor = System.Drawing.Color.Black;
            this.link_GitHub.Location = new System.Drawing.Point(5, 65);
            this.link_GitHub.Margin = new System.Windows.Forms.Padding(5);
            this.link_GitHub.Name = "link_GitHub";
            this.link_GitHub.Size = new System.Drawing.Size(127, 19);
            this.link_GitHub.TabIndex = 3;
            this.link_GitHub.TabStop = true;
            this.link_GitHub.Text = "GitHub Repository";
            this.link_GitHub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_GitHub_LinkClicked);
            // 
            // link_MIT
            // 
            this.link_MIT.ActiveLinkColor = System.Drawing.Color.Black;
            this.link_MIT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.link_MIT.AutoSize = true;
            this.grd_Content.SetColumnSpan(this.link_MIT, 2);
            this.link_MIT.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.link_MIT.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.link_MIT.LinkColor = System.Drawing.Color.Black;
            this.link_MIT.Location = new System.Drawing.Point(5, 110);
            this.link_MIT.Margin = new System.Windows.Forms.Padding(5, 0, 3, 10);
            this.link_MIT.Name = "link_MIT";
            this.link_MIT.Size = new System.Drawing.Size(248, 15);
            this.link_MIT.TabIndex = 4;
            this.link_MIT.TabStop = true;
            this.link_MIT.Text = "This product is licensed under the MIT license.";
            this.link_MIT.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_MIT_LinkClicked);
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(428, 141);
            this.Controls.Add(this.grd_Root);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "About";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About";
            this.grd_Root.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pc_Logo)).EndInit();
            this.grd_Content.ResumeLayout(false);
            this.grd_Content.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel grd_Root;
        private System.Windows.Forms.PictureBox pc_Logo;
        private System.Windows.Forms.TableLayoutPanel grd_Content;
        private System.Windows.Forms.Label lab_Title;
        private System.Windows.Forms.Label lab_Dev;
        private System.Windows.Forms.LinkLabel link_Dev;
        private System.Windows.Forms.LinkLabel link_GitHub;
        private System.Windows.Forms.LinkLabel link_MIT;
    }
}