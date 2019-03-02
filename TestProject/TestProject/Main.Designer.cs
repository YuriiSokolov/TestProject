namespace TestProject
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
            this.dataGVFromDocument = new System.Windows.Forms.DataGridView();
            this.checkBoxDate = new System.Windows.Forms.CheckBox();
            this.checkBoxOrganization = new System.Windows.Forms.CheckBox();
            this.checkBoxCity = new System.Windows.Forms.CheckBox();
            this.checkBoxCountry = new System.Windows.Forms.CheckBox();
            this.checkBoxManager = new System.Windows.Forms.CheckBox();
            this.btnResultCancel = new System.Windows.Forms.Button();
            this.btnCreateForm = new System.Windows.Forms.Button();
            this.btnChangeManager = new System.Windows.Forms.Button();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.labelExit = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVFromDocument)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGVFromDocument
            // 
            this.dataGVFromDocument.AllowUserToAddRows = false;
            this.dataGVFromDocument.AllowUserToDeleteRows = false;
            this.dataGVFromDocument.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVFromDocument.Location = new System.Drawing.Point(12, 46);
            this.dataGVFromDocument.Name = "dataGVFromDocument";
            this.dataGVFromDocument.ReadOnly = true;
            this.dataGVFromDocument.Size = new System.Drawing.Size(567, 235);
            this.dataGVFromDocument.TabIndex = 0;
            // 
            // checkBoxDate
            // 
            this.checkBoxDate.AutoSize = true;
            this.checkBoxDate.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxDate.Location = new System.Drawing.Point(44, 287);
            this.checkBoxDate.Name = "checkBoxDate";
            this.checkBoxDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBoxDate.Size = new System.Drawing.Size(55, 21);
            this.checkBoxDate.TabIndex = 2;
            this.checkBoxDate.Text = "Дата";
            this.checkBoxDate.UseVisualStyleBackColor = true;
            // 
            // checkBoxOrganization
            // 
            this.checkBoxOrganization.AutoSize = true;
            this.checkBoxOrganization.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxOrganization.Location = new System.Drawing.Point(102, 287);
            this.checkBoxOrganization.Name = "checkBoxOrganization";
            this.checkBoxOrganization.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBoxOrganization.Size = new System.Drawing.Size(101, 21);
            this.checkBoxOrganization.TabIndex = 3;
            this.checkBoxOrganization.Text = "Организация";
            this.checkBoxOrganization.UseVisualStyleBackColor = true;
            // 
            // checkBoxCity
            // 
            this.checkBoxCity.AutoSize = true;
            this.checkBoxCity.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxCity.Location = new System.Drawing.Point(209, 287);
            this.checkBoxCity.Name = "checkBoxCity";
            this.checkBoxCity.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBoxCity.Size = new System.Drawing.Size(61, 21);
            this.checkBoxCity.TabIndex = 4;
            this.checkBoxCity.Text = "Город";
            this.checkBoxCity.UseVisualStyleBackColor = true;
            // 
            // checkBoxCountry
            // 
            this.checkBoxCountry.AutoSize = true;
            this.checkBoxCountry.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxCountry.Location = new System.Drawing.Point(276, 287);
            this.checkBoxCountry.Name = "checkBoxCountry";
            this.checkBoxCountry.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBoxCountry.Size = new System.Drawing.Size(68, 21);
            this.checkBoxCountry.TabIndex = 5;
            this.checkBoxCountry.Text = "Страна";
            this.checkBoxCountry.UseVisualStyleBackColor = true;
            // 
            // checkBoxManager
            // 
            this.checkBoxManager.AutoSize = true;
            this.checkBoxManager.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxManager.Location = new System.Drawing.Point(350, 287);
            this.checkBoxManager.Name = "checkBoxManager";
            this.checkBoxManager.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBoxManager.Size = new System.Drawing.Size(89, 21);
            this.checkBoxManager.TabIndex = 6;
            this.checkBoxManager.Text = "Менеджер";
            this.checkBoxManager.UseVisualStyleBackColor = true;
            // 
            // btnResultCancel
            // 
            this.btnResultCancel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnResultCancel.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnResultCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnResultCancel.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnResultCancel.Location = new System.Drawing.Point(445, 285);
            this.btnResultCancel.Name = "btnResultCancel";
            this.btnResultCancel.Size = new System.Drawing.Size(90, 23);
            this.btnResultCancel.TabIndex = 9;
            this.btnResultCancel.Text = "Результат";
            this.btnResultCancel.UseVisualStyleBackColor = false;
            this.btnResultCancel.Click += new System.EventHandler(this.btnResultCancel_Click);
            // 
            // btnCreateForm
            // 
            this.btnCreateForm.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCreateForm.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCreateForm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCreateForm.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCreateForm.Location = new System.Drawing.Point(44, 314);
            this.btnCreateForm.Name = "btnCreateForm";
            this.btnCreateForm.Size = new System.Drawing.Size(116, 23);
            this.btnCreateForm.TabIndex = 10;
            this.btnCreateForm.Text = "Новая Отгрузка";
            this.btnCreateForm.UseVisualStyleBackColor = false;
            this.btnCreateForm.Click += new System.EventHandler(this.btnCreateForm_Click);
            // 
            // btnChangeManager
            // 
            this.btnChangeManager.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnChangeManager.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnChangeManager.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnChangeManager.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnChangeManager.Location = new System.Drawing.Point(350, 314);
            this.btnChangeManager.Name = "btnChangeManager";
            this.btnChangeManager.Size = new System.Drawing.Size(185, 23);
            this.btnChangeManager.TabIndex = 11;
            this.btnChangeManager.Text = "Управление Менеджерами";
            this.btnChangeManager.UseVisualStyleBackColor = false;
            this.btnChangeManager.Click += new System.EventHandler(this.btnChangeManager_Click);
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWelcome.Location = new System.Drawing.Point(12, 9);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(89, 17);
            this.labelWelcome.TabIndex = 14;
            this.labelWelcome.Text = "Здраствуйте:  ";
            // 
            // labelExit
            // 
            this.labelExit.AutoSize = true;
            this.labelExit.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelExit.Location = new System.Drawing.Point(158, 9);
            this.labelExit.Name = "labelExit";
            this.labelExit.Size = new System.Drawing.Size(45, 17);
            this.labelExit.TabIndex = 15;
            this.labelExit.Text = "Выход";
            this.labelExit.Click += new System.EventHandler(this.labelExit_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(608, 350);
            this.Controls.Add(this.labelExit);
            this.Controls.Add(this.labelWelcome);
            this.Controls.Add(this.btnChangeManager);
            this.Controls.Add(this.btnCreateForm);
            this.Controls.Add(this.btnResultCancel);
            this.Controls.Add(this.checkBoxManager);
            this.Controls.Add(this.checkBoxCountry);
            this.Controls.Add(this.checkBoxCity);
            this.Controls.Add(this.checkBoxOrganization);
            this.Controls.Add(this.checkBoxDate);
            this.Controls.Add(this.dataGVFromDocument);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGVFromDocument)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGVFromDocument;
        private System.Windows.Forms.CheckBox checkBoxDate;
        private System.Windows.Forms.CheckBox checkBoxOrganization;
        private System.Windows.Forms.CheckBox checkBoxCity;
        private System.Windows.Forms.CheckBox checkBoxCountry;
        private System.Windows.Forms.CheckBox checkBoxManager;
        private System.Windows.Forms.Button btnResultCancel;
        private System.Windows.Forms.Button btnCreateForm;
        private System.Windows.Forms.Button btnChangeManager;
        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Label labelExit;
    }
}