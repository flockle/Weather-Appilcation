
namespace Weather_Appilcation
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.City = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.labCondition = new System.Windows.Forms.Label();
            this.labDetail = new System.Windows.Forms.Label();
            this.lab = new System.Windows.Forms.Label();
            this.labSunrise = new System.Windows.Forms.Label();
            this.labsunset = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labWindSpeed = new System.Windows.Forms.Label();
            this.labWindS = new System.Windows.Forms.Label();
            this.labr = new System.Windows.Forms.Label();
            this.labHumidity = new System.Windows.Forms.Label();
            this.picIcon = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labTemp = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(23, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "City:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // City
            // 
            this.City.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.City.Location = new System.Drawing.Point(82, 120);
            this.City.Name = "City";
            this.City.Size = new System.Drawing.Size(248, 31);
            this.City.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSearch.Location = new System.Drawing.Point(347, 120);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(92, 37);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // labCondition
            // 
            this.labCondition.AutoSize = true;
            this.labCondition.BackColor = System.Drawing.Color.Transparent;
            this.labCondition.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCondition.ForeColor = System.Drawing.Color.White;
            this.labCondition.Location = new System.Drawing.Point(12, 233);
            this.labCondition.Name = "labCondition";
            this.labCondition.Size = new System.Drawing.Size(85, 23);
            this.labCondition.TabIndex = 3;
            this.labCondition.Text = "Condition";
            // 
            // labDetail
            // 
            this.labDetail.AutoSize = true;
            this.labDetail.BackColor = System.Drawing.Color.Transparent;
            this.labDetail.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDetail.ForeColor = System.Drawing.Color.White;
            this.labDetail.Location = new System.Drawing.Point(12, 272);
            this.labDetail.Name = "labDetail";
            this.labDetail.Size = new System.Drawing.Size(62, 23);
            this.labDetail.TabIndex = 5;
            this.labDetail.Text = "Details";
            // 
            // lab
            // 
            this.lab.AutoSize = true;
            this.lab.BackColor = System.Drawing.Color.Transparent;
            this.lab.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab.ForeColor = System.Drawing.Color.White;
            this.lab.Location = new System.Drawing.Point(12, 318);
            this.lab.Name = "lab";
            this.lab.Size = new System.Drawing.Size(72, 23);
            this.lab.TabIndex = 6;
            this.lab.Text = "Sunrise:";
            // 
            // labSunrise
            // 
            this.labSunrise.AutoSize = true;
            this.labSunrise.BackColor = System.Drawing.Color.Transparent;
            this.labSunrise.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSunrise.ForeColor = System.Drawing.Color.White;
            this.labSunrise.Location = new System.Drawing.Point(85, 318);
            this.labSunrise.Name = "labSunrise";
            this.labSunrise.Size = new System.Drawing.Size(39, 23);
            this.labSunrise.TabIndex = 9;
            this.labSunrise.Text = "N/A";
            // 
            // labsunset
            // 
            this.labsunset.AutoSize = true;
            this.labsunset.BackColor = System.Drawing.Color.Transparent;
            this.labsunset.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labsunset.ForeColor = System.Drawing.Color.White;
            this.labsunset.Location = new System.Drawing.Point(85, 356);
            this.labsunset.Name = "labsunset";
            this.labsunset.Size = new System.Drawing.Size(39, 23);
            this.labsunset.TabIndex = 12;
            this.labsunset.Text = "N/A";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 356);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 23);
            this.label4.TabIndex = 13;
            this.label4.Text = "Sunset:";
            // 
            // labWindSpeed
            // 
            this.labWindSpeed.AutoSize = true;
            this.labWindSpeed.BackColor = System.Drawing.Color.Transparent;
            this.labWindSpeed.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labWindSpeed.ForeColor = System.Drawing.Color.White;
            this.labWindSpeed.Location = new System.Drawing.Point(343, 318);
            this.labWindSpeed.Name = "labWindSpeed";
            this.labWindSpeed.Size = new System.Drawing.Size(107, 23);
            this.labWindSpeed.TabIndex = 14;
            this.labWindSpeed.Text = "Wind Speed:";
            // 
            // labWindS
            // 
            this.labWindS.AutoSize = true;
            this.labWindS.BackColor = System.Drawing.Color.Transparent;
            this.labWindS.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labWindS.ForeColor = System.Drawing.Color.White;
            this.labWindS.Location = new System.Drawing.Point(456, 318);
            this.labWindS.Name = "labWindS";
            this.labWindS.Size = new System.Drawing.Size(39, 23);
            this.labWindS.TabIndex = 15;
            this.labWindS.Text = "N/A";
            // 
            // labr
            // 
            this.labr.AutoSize = true;
            this.labr.BackColor = System.Drawing.Color.Transparent;
            this.labr.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labr.ForeColor = System.Drawing.Color.White;
            this.labr.Location = new System.Drawing.Point(343, 272);
            this.labr.Name = "labr";
            this.labr.Size = new System.Drawing.Size(80, 23);
            this.labr.TabIndex = 17;
            this.labr.Text = "Humidity";
            // 
            // labHumidity
            // 
            this.labHumidity.AutoSize = true;
            this.labHumidity.BackColor = System.Drawing.Color.Transparent;
            this.labHumidity.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labHumidity.ForeColor = System.Drawing.Color.White;
            this.labHumidity.Location = new System.Drawing.Point(456, 272);
            this.labHumidity.Name = "labHumidity";
            this.labHumidity.Size = new System.Drawing.Size(39, 23);
            this.labHumidity.TabIndex = 18;
            this.labHumidity.Text = "N/A";
            this.labHumidity.Click += new System.EventHandler(this.labPressure_Click);
            // 
            // picIcon
            // 
            this.picIcon.BackColor = System.Drawing.Color.Transparent;
            this.picIcon.Location = new System.Drawing.Point(571, 65);
            this.picIcon.Name = "picIcon";
            this.picIcon.Size = new System.Drawing.Size(125, 86);
            this.picIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picIcon.TabIndex = 19;
            this.picIcon.TabStop = false;
            this.picIcon.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(343, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 23);
            this.label2.TabIndex = 20;
            this.label2.Text = "Temperature";
            // 
            // labTemp
            // 
            this.labTemp.AutoSize = true;
            this.labTemp.BackColor = System.Drawing.Color.Transparent;
            this.labTemp.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTemp.ForeColor = System.Drawing.Color.White;
            this.labTemp.Location = new System.Drawing.Point(457, 233);
            this.labTemp.Name = "labTemp";
            this.labTemp.Size = new System.Drawing.Size(39, 23);
            this.labTemp.TabIndex = 21;
            this.labTemp.Text = "N/A";
            this.labTemp.Click += new System.EventHandler(this.labTemp_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(823, 498);
            this.Controls.Add(this.labTemp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.picIcon);
            this.Controls.Add(this.labHumidity);
            this.Controls.Add(this.labr);
            this.Controls.Add(this.labWindS);
            this.Controls.Add(this.labWindSpeed);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labsunset);
            this.Controls.Add(this.labSunrise);
            this.Controls.Add(this.lab);
            this.Controls.Add(this.labDetail);
            this.Controls.Add(this.labCondition);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.City);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Weather  ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox City;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label labCondition;
        private System.Windows.Forms.Label labDetail;
        private System.Windows.Forms.Label lab;
        private System.Windows.Forms.Label labSunrise;
        private System.Windows.Forms.Label labsunset;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labWindSpeed;
        private System.Windows.Forms.Label labWindS;
        private System.Windows.Forms.Label labr;
        private System.Windows.Forms.Label labHumidity;
        private System.Windows.Forms.PictureBox picIcon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labTemp;
    }
}

