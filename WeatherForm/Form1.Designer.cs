namespace WeatherForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxZipCode = new System.Windows.Forms.TextBox();
            this.buttonLookupWeather = new System.Windows.Forms.Button();
            this.textBoxResults = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter a zip code:";
            // 
            // textBoxZipCode
            // 
            this.textBoxZipCode.Location = new System.Drawing.Point(105, 13);
            this.textBoxZipCode.Name = "textBoxZipCode";
            this.textBoxZipCode.Size = new System.Drawing.Size(125, 20);
            this.textBoxZipCode.TabIndex = 1;
            this.textBoxZipCode.Text = "10118";
            // 
            // buttonLookupWeather
            // 
            this.buttonLookupWeather.Location = new System.Drawing.Point(12, 39);
            this.buttonLookupWeather.Name = "buttonLookupWeather";
            this.buttonLookupWeather.Size = new System.Drawing.Size(218, 23);
            this.buttonLookupWeather.TabIndex = 2;
            this.buttonLookupWeather.Text = "Lookup Weather";
            this.buttonLookupWeather.UseVisualStyleBackColor = true;
            this.buttonLookupWeather.Click += new System.EventHandler(this.buttonLookupWeather_Click);
            // 
            // textBoxResults
            // 
            this.textBoxResults.Location = new System.Drawing.Point(12, 68);
            this.textBoxResults.Multiline = true;
            this.textBoxResults.Name = "textBoxResults";
            this.textBoxResults.ReadOnly = true;
            this.textBoxResults.Size = new System.Drawing.Size(218, 149);
            this.textBoxResults.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 239);
            this.Controls.Add(this.textBoxResults);
            this.Controls.Add(this.buttonLookupWeather);
            this.Controls.Add(this.textBoxZipCode);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Weather Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxZipCode;
        private System.Windows.Forms.Button buttonLookupWeather;
        private System.Windows.Forms.TextBox textBoxResults;
    }
}

