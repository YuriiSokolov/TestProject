namespace TestProject
{
    partial class AdminPanel
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
            this.comboBoxLogin = new System.Windows.Forms.ComboBox();
            this.labelManagers = new System.Windows.Forms.Label();
            this.btnBan = new System.Windows.Forms.Button();
            this.btnIsAdmin = new System.Windows.Forms.Button();
            this.btnChangeLogin = new System.Windows.Forms.Button();
            this.btnChangePass = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnCreateManager = new System.Windows.Forms.Button();
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelPass = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.txtNewLogin = new System.Windows.Forms.TextBox();
            this.txtNewPass = new System.Windows.Forms.TextBox();
            this.btnDeleteManager = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxLogin
            // 
            this.comboBoxLogin.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxLogin.FormattingEnabled = true;
            this.comboBoxLogin.Location = new System.Drawing.Point(145, 6);
            this.comboBoxLogin.Name = "comboBoxLogin";
            this.comboBoxLogin.Size = new System.Drawing.Size(147, 25);
            this.comboBoxLogin.TabIndex = 12;
            // 
            // labelManagers
            // 
            this.labelManagers.AutoSize = true;
            this.labelManagers.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelManagers.Location = new System.Drawing.Point(12, 9);
            this.labelManagers.Name = "labelManagers";
            this.labelManagers.Size = new System.Drawing.Size(130, 17);
            this.labelManagers.TabIndex = 13;
            this.labelManagers.Text = "Список Менеджеров:";
            // 
            // btnBan
            // 
            this.btnBan.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBan.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnBan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBan.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBan.Location = new System.Drawing.Point(307, 6);
            this.btnBan.Name = "btnBan";
            this.btnBan.Size = new System.Drawing.Size(147, 23);
            this.btnBan.TabIndex = 14;
            this.btnBan.Text = "Забанить / Разбанить";
            this.btnBan.UseVisualStyleBackColor = false;
            this.btnBan.Click += new System.EventHandler(this.btnBan_Click);
            // 
            // btnIsAdmin
            // 
            this.btnIsAdmin.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnIsAdmin.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnIsAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIsAdmin.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnIsAdmin.Location = new System.Drawing.Point(307, 35);
            this.btnIsAdmin.Name = "btnIsAdmin";
            this.btnIsAdmin.Size = new System.Drawing.Size(147, 23);
            this.btnIsAdmin.TabIndex = 15;
            this.btnIsAdmin.Text = "Сделать Админом";
            this.btnIsAdmin.UseVisualStyleBackColor = false;
            this.btnIsAdmin.Click += new System.EventHandler(this.btnIsAdmin_Click);
            // 
            // btnChangeLogin
            // 
            this.btnChangeLogin.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnChangeLogin.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnChangeLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnChangeLogin.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnChangeLogin.Location = new System.Drawing.Point(307, 64);
            this.btnChangeLogin.Name = "btnChangeLogin";
            this.btnChangeLogin.Size = new System.Drawing.Size(147, 23);
            this.btnChangeLogin.TabIndex = 16;
            this.btnChangeLogin.Text = "Сменить Логин";
            this.btnChangeLogin.UseVisualStyleBackColor = false;
            this.btnChangeLogin.Click += new System.EventHandler(this.btnChangeLogin_Click);
            // 
            // btnChangePass
            // 
            this.btnChangePass.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnChangePass.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnChangePass.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnChangePass.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnChangePass.Location = new System.Drawing.Point(307, 93);
            this.btnChangePass.Name = "btnChangePass";
            this.btnChangePass.Size = new System.Drawing.Size(147, 23);
            this.btnChangePass.TabIndex = 17;
            this.btnChangePass.Text = "Сменить Пароль";
            this.btnChangePass.UseVisualStyleBackColor = false;
            this.btnChangePass.Click += new System.EventHandler(this.btnChangePass_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(144, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Создание нового менеджера:";
            // 
            // txtLogin
            // 
            this.txtLogin.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtLogin.Location = new System.Drawing.Point(190, 181);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(147, 23);
            this.txtLogin.TabIndex = 19;
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPass.Location = new System.Drawing.Point(190, 210);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(147, 23);
            this.txtPass.TabIndex = 20;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtName.Location = new System.Drawing.Point(190, 239);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(147, 23);
            this.txtName.TabIndex = 21;
            // 
            // btnCreateManager
            // 
            this.btnCreateManager.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCreateManager.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCreateManager.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCreateManager.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCreateManager.Location = new System.Drawing.Point(195, 268);
            this.btnCreateManager.Name = "btnCreateManager";
            this.btnCreateManager.Size = new System.Drawing.Size(99, 23);
            this.btnCreateManager.TabIndex = 22;
            this.btnCreateManager.Text = "Создать";
            this.btnCreateManager.UseVisualStyleBackColor = false;
            this.btnCreateManager.Click += new System.EventHandler(this.btnCreateManager_Click);
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLogin.Location = new System.Drawing.Point(131, 184);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(44, 17);
            this.labelLogin.TabIndex = 23;
            this.labelLogin.Text = "Логин:";
            // 
            // labelPass
            // 
            this.labelPass.AutoSize = true;
            this.labelPass.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPass.Location = new System.Drawing.Point(131, 213);
            this.labelPass.Name = "labelPass";
            this.labelPass.Size = new System.Drawing.Size(53, 17);
            this.labelPass.TabIndex = 24;
            this.labelPass.Text = "Пароль:";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.Location = new System.Drawing.Point(131, 242);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 17);
            this.labelName.TabIndex = 25;
            this.labelName.Text = "ФИО:";
            // 
            // txtNewLogin
            // 
            this.txtNewLogin.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtNewLogin.Location = new System.Drawing.Point(145, 64);
            this.txtNewLogin.Name = "txtNewLogin";
            this.txtNewLogin.Size = new System.Drawing.Size(147, 23);
            this.txtNewLogin.TabIndex = 26;
            // 
            // txtNewPass
            // 
            this.txtNewPass.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtNewPass.Location = new System.Drawing.Point(145, 93);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.Size = new System.Drawing.Size(147, 23);
            this.txtNewPass.TabIndex = 27;
            // 
            // btnDeleteManager
            // 
            this.btnDeleteManager.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDeleteManager.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDeleteManager.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeleteManager.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDeleteManager.Location = new System.Drawing.Point(307, 122);
            this.btnDeleteManager.Name = "btnDeleteManager";
            this.btnDeleteManager.Size = new System.Drawing.Size(147, 23);
            this.btnDeleteManager.TabIndex = 28;
            this.btnDeleteManager.Text = "Удалить Менеджера";
            this.btnDeleteManager.UseVisualStyleBackColor = false;
            this.btnDeleteManager.Click += new System.EventHandler(this.btnDeleteManager_Click);
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(472, 332);
            this.Controls.Add(this.btnDeleteManager);
            this.Controls.Add(this.txtNewPass);
            this.Controls.Add(this.txtNewLogin);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelPass);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.btnCreateManager);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnChangePass);
            this.Controls.Add(this.btnChangeLogin);
            this.Controls.Add(this.btnIsAdmin);
            this.Controls.Add(this.btnBan);
            this.Controls.Add(this.labelManagers);
            this.Controls.Add(this.comboBoxLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AdminPanel";
            this.Text = "AdminPanel";
            this.Load += new System.EventHandler(this.AdminPanel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxLogin;
        private System.Windows.Forms.Label labelManagers;
        private System.Windows.Forms.Button btnBan;
        private System.Windows.Forms.Button btnIsAdmin;
        private System.Windows.Forms.Button btnChangeLogin;
        private System.Windows.Forms.Button btnChangePass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnCreateManager;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label labelPass;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox txtNewLogin;
        private System.Windows.Forms.TextBox txtNewPass;
        private System.Windows.Forms.Button btnDeleteManager;
    }
}