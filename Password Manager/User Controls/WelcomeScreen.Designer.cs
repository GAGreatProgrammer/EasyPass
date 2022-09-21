
namespace Password_Manager.User_Controls
{
    partial class WelcomeScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblLoadingInfo = new System.Windows.Forms.Label();
            this.dbLoader = new Bunifu.UI.WinForms.BunifuLoader();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Password_Manager.Properties.Resources.Password;
            this.pictureBox1.Location = new System.Drawing.Point(282, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(185, 185);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Password_Manager.Properties.Resources.Info;
            this.pictureBox2.Location = new System.Drawing.Point(275, 265);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(204, 95);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.label1.Location = new System.Drawing.Point(185, 360);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(379, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "Save personal information";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(100)))), ((int)(((byte)(129)))));
            this.label2.Location = new System.Drawing.Point(50, 400);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(645, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Add your passwords, credit cards, personal information and notes.";
            // 
            // lblLoadingInfo
            // 
            this.lblLoadingInfo.AutoSize = true;
            this.lblLoadingInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoadingInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(100)))), ((int)(((byte)(129)))));
            this.lblLoadingInfo.Location = new System.Drawing.Point(215, 595);
            this.lblLoadingInfo.Name = "lblLoadingInfo";
            this.lblLoadingInfo.Size = new System.Drawing.Size(90, 20);
            this.lblLoadingInfo.TabIndex = 12;
            this.lblLoadingInfo.Text = "Information";
            // 
            // dbLoader
            // 
            this.dbLoader.AllowStylePresets = true;
            this.dbLoader.BackColor = System.Drawing.Color.Transparent;
            this.dbLoader.CapStyle = Bunifu.UI.WinForms.BunifuLoader.CapStyles.Round;
            this.dbLoader.Color = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(193)))), ((int)(((byte)(82)))));
            this.dbLoader.Colors = new Bunifu.UI.WinForms.Bloom[0];
            this.dbLoader.Customization = "";
            this.dbLoader.DashWidth = 0.5F;
            this.dbLoader.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dbLoader.Image = null;
            this.dbLoader.Location = new System.Drawing.Point(300, 450);
            this.dbLoader.Name = "dbLoader";
            this.dbLoader.NoRounding = false;
            this.dbLoader.Preset = Bunifu.UI.WinForms.BunifuLoader.StylePresets.Dotted;
            this.dbLoader.RingStyle = Bunifu.UI.WinForms.BunifuLoader.RingStyles.Dotted;
            this.dbLoader.ShowText = false;
            this.dbLoader.Size = new System.Drawing.Size(120, 120);
            this.dbLoader.Speed = 5;
            this.dbLoader.TabIndex = 13;
            this.dbLoader.Text = "Loader";
            this.dbLoader.TextPadding = new System.Windows.Forms.Padding(0);
            this.dbLoader.Thickness = 15;
            this.dbLoader.Transparent = true;
            // 
            // WelcomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dbLoader);
            this.Controls.Add(this.lblLoadingInfo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "WelcomeScreen";
            this.Size = new System.Drawing.Size(750, 760);
            this.Load += new System.EventHandler(this.WelcomeScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblLoadingInfo;
        private Bunifu.UI.WinForms.BunifuLoader dbLoader;
    }
}
