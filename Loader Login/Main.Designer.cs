
namespace Loader_Login
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
            this.user = new System.Windows.Forms.Label();
            this.expiry = new System.Windows.Forms.Label();
            this.lastLogin = new System.Windows.Forms.Label();
            this.lblRank = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // user
            // 
            this.user.AutoSize = true;
            this.user.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user.Location = new System.Drawing.Point(265, 153);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(76, 19);
            this.user.TabIndex = 2;
            this.user.Text = "Username";
            // 
            // expiry
            // 
            this.expiry.AutoSize = true;
            this.expiry.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expiry.Location = new System.Drawing.Point(265, 181);
            this.expiry.Name = "expiry";
            this.expiry.Size = new System.Drawing.Size(54, 19);
            this.expiry.TabIndex = 3;
            this.expiry.Text = "Expiry:";
            // 
            // lastLogin
            // 
            this.lastLogin.AutoSize = true;
            this.lastLogin.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastLogin.Location = new System.Drawing.Point(265, 209);
            this.lastLogin.Name = "lastLogin";
            this.lastLogin.Size = new System.Drawing.Size(76, 19);
            this.lastLogin.TabIndex = 4;
            this.lastLogin.Text = "Last Login";
            // 
            // lblRank
            // 
            this.lblRank.AutoSize = true;
            this.lblRank.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRank.Location = new System.Drawing.Point(265, 240);
            this.lblRank.Name = "lblRank";
            this.lblRank.Size = new System.Drawing.Size(42, 19);
            this.lblRank.TabIndex = 5;
            this.lblRank.Text = "Rank";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 388);
            this.Controls.Add(this.lblRank);
            this.Controls.Add(this.lastLogin);
            this.Controls.Add(this.expiry);
            this.Controls.Add(this.user);
            this.Name = "Main";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label user;
        private System.Windows.Forms.Label expiry;
        private System.Windows.Forms.Label lastLogin;
        private System.Windows.Forms.Label lblRank;
    }
}

