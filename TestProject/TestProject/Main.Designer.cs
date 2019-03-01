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
            ((System.ComponentModel.ISupportInitialize)(this.dataGVFromDocument)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGVFromDocument
            // 
            this.dataGVFromDocument.AllowUserToAddRows = false;
            this.dataGVFromDocument.AllowUserToDeleteRows = false;
            this.dataGVFromDocument.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVFromDocument.Location = new System.Drawing.Point(21, 22);
            this.dataGVFromDocument.Name = "dataGVFromDocument";
            this.dataGVFromDocument.ReadOnly = true;
            this.dataGVFromDocument.Size = new System.Drawing.Size(567, 235);
            this.dataGVFromDocument.TabIndex = 0;
            // 
            // checkBoxDate
            // 
            this.checkBoxDate.AutoSize = true;
            this.checkBoxDate.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxDate.Location = new System.Drawing.Point(115, 263);
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
            this.checkBoxOrganization.Location = new System.Drawing.Point(173, 263);
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
            this.checkBoxCity.Location = new System.Drawing.Point(280, 263);
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
            this.checkBoxCountry.Location = new System.Drawing.Point(347, 263);
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
            this.checkBoxManager.Location = new System.Drawing.Point(421, 263);
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
            this.btnResultCancel.Location = new System.Drawing.Point(253, 290);
            this.btnResultCancel.Name = "btnResultCancel";
            this.btnResultCancel.Size = new System.Drawing.Size(128, 23);
            this.btnResultCancel.TabIndex = 9;
            this.btnResultCancel.Text = "Результат / Отмена";
            this.btnResultCancel.UseVisualStyleBackColor = false;
            this.btnResultCancel.Click += new System.EventHandler(this.btnResultCancel_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(608, 322);
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
    }
}