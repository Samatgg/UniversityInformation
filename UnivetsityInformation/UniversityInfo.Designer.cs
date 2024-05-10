namespace UnivetsityInformation
{
    partial class UniversityInfoForm
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
            this.textBoxUniversityInfo = new System.Windows.Forms.TextBox();
            this.pictureBoxUniversity = new System.Windows.Forms.PictureBox();
            this.label_name = new System.Windows.Forms.Label();
            this.label_city = new System.Windows.Forms.Label();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.textBoxUniversityName = new System.Windows.Forms.TextBox();
            this.labelInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUniversity)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxUniversityInfo
            // 
            this.textBoxUniversityInfo.Location = new System.Drawing.Point(621, 53);
            this.textBoxUniversityInfo.Multiline = true;
            this.textBoxUniversityInfo.Name = "textBoxUniversityInfo";
            this.textBoxUniversityInfo.Size = new System.Drawing.Size(481, 114);
            this.textBoxUniversityInfo.TabIndex = 0;
            // 
            // pictureBoxUniversity
            // 
            this.pictureBoxUniversity.Location = new System.Drawing.Point(40, 183);
            this.pictureBoxUniversity.Name = "pictureBoxUniversity";
            this.pictureBoxUniversity.Size = new System.Drawing.Size(1062, 573);
            this.pictureBoxUniversity.TabIndex = 1;
            this.pictureBoxUniversity.TabStop = false;
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_name.Location = new System.Drawing.Point(35, 53);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(99, 25);
            this.label_name.TabIndex = 2;
            this.label_name.Text = "Название";
            // 
            // label_city
            // 
            this.label_city.AutoSize = true;
            this.label_city.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_city.Location = new System.Drawing.Point(35, 128);
            this.label_city.Name = "label_city";
            this.label_city.Size = new System.Drawing.Size(69, 25);
            this.label_city.TabIndex = 3;
            this.label_city.Text = "Город";
            // 
            // textBoxCity
            // 
            this.textBoxCity.Location = new System.Drawing.Point(160, 128);
            this.textBoxCity.Multiline = true;
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(323, 33);
            this.textBoxCity.TabIndex = 4;
            // 
            // textBoxUniversityName
            // 
            this.textBoxUniversityName.Location = new System.Drawing.Point(160, 53);
            this.textBoxUniversityName.Multiline = true;
            this.textBoxUniversityName.Name = "textBoxUniversityName";
            this.textBoxUniversityName.Size = new System.Drawing.Size(323, 33);
            this.textBoxUniversityName.TabIndex = 5;
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInfo.Location = new System.Drawing.Point(720, 9);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(301, 25);
            this.labelInfo.TabIndex = 6;
            this.labelInfo.Text = "Информация об университете";
            // 
            // UniversityInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(1145, 768);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.textBoxUniversityName);
            this.Controls.Add(this.textBoxCity);
            this.Controls.Add(this.label_city);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.pictureBoxUniversity);
            this.Controls.Add(this.textBoxUniversityInfo);
            this.Name = "UniversityInfoForm";
            this.Text = "UniversityInfo";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUniversity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxUniversityInfo;
        private System.Windows.Forms.PictureBox pictureBoxUniversity;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_city;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.TextBox textBoxUniversityName;
        private System.Windows.Forms.Label labelInfo;
    }
}