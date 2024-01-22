namespace Calculs_Orthologick
{
    partial class Authentication
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Authentication));
			this.tb_Username = new System.Windows.Forms.TextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.tb_Password = new System.Windows.Forms.TextBox();
			this.btn_Login = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// tb_Username
			// 
			this.tb_Username.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tb_Username.Location = new System.Drawing.Point(3, 3);
			this.tb_Username.Multiline = true;
			this.tb_Username.Name = "tb_Username";
			this.tb_Username.Size = new System.Drawing.Size(194, 20);
			this.tb_Username.TabIndex = 1;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Silver;
			this.panel1.Controls.Add(this.tb_Username);
			this.panel1.Location = new System.Drawing.Point(165, 97);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(200, 26);
			this.panel1.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(36, 101);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(110, 15);
			this.label1.TabIndex = 4;
			this.label1.Text = "Nom d\'utilisateur :";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(37, 153);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(86, 15);
			this.label2.TabIndex = 6;
			this.label2.Text = "Mot de passe :";
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.Silver;
			this.panel2.Controls.Add(this.tb_Password);
			this.panel2.Location = new System.Drawing.Point(166, 148);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(200, 26);
			this.panel2.TabIndex = 5;
			// 
			// tb_Password
			// 
			this.tb_Password.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tb_Password.Location = new System.Drawing.Point(3, 3);
			this.tb_Password.Multiline = true;
			this.tb_Password.Name = "tb_Password";
			this.tb_Password.PasswordChar = '*';
			this.tb_Password.Size = new System.Drawing.Size(194, 20);
			this.tb_Password.TabIndex = 1;
			this.tb_Password.TextChanged += new System.EventHandler(this.tb_Password_TextChanged);
			// 
			// btn_Login
			// 
			this.btn_Login.BackColor = System.Drawing.Color.WhiteSmoke;
			this.btn_Login.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(60)))), ((int)(((byte)(32)))));
			this.btn_Login.FlatAppearance.BorderSize = 2;
			this.btn_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_Login.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_Login.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btn_Login.Location = new System.Drawing.Point(277, 197);
			this.btn_Login.Name = "btn_Login";
			this.btn_Login.Size = new System.Drawing.Size(88, 26);
			this.btn_Login.TabIndex = 7;
			this.btn_Login.Text = "Se connecter";
			this.btn_Login.UseVisualStyleBackColor = false;
			this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::Calculs_Orthologick.Properties.Resources.Logo_Orthologick;
			this.pictureBox1.Location = new System.Drawing.Point(94, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(232, 71);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// Authentication
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(417, 254);
			this.Controls.Add(this.btn_Login);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.pictureBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximumSize = new System.Drawing.Size(433, 293);
			this.MinimumSize = new System.Drawing.Size(433, 293);
			this.Name = "Authentication";
			this.Load += new System.EventHandler(this.Authentication_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tb_Username;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tb_Password;
        private System.Windows.Forms.Button btn_Login;
    }
}

