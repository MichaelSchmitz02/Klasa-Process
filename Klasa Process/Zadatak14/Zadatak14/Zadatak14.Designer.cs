namespace Zadatak14
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
            this.btnInternet = new System.Windows.Forms.Button();
            this.btnExcel = new System.Windows.Forms.Button();
            this.btnWord = new System.Windows.Forms.Button();
            this.btnStartInfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnInternet
            // 
            this.btnInternet.Location = new System.Drawing.Point(159, 69);
            this.btnInternet.Name = "btnInternet";
            this.btnInternet.Size = new System.Drawing.Size(170, 63);
            this.btnInternet.TabIndex = 0;
            this.btnInternet.Text = "Pokrenite Internet Explorer";
            this.btnInternet.UseVisualStyleBackColor = true;
            this.btnInternet.Click += new System.EventHandler(this.btnInternet_Click);
            // 
            // btnExcel
            // 
            this.btnExcel.Location = new System.Drawing.Point(463, 69);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(170, 63);
            this.btnExcel.TabIndex = 1;
            this.btnExcel.Text = "Pokrenite Excel";
            this.btnExcel.UseVisualStyleBackColor = true;
            // 
            // btnWord
            // 
            this.btnWord.Location = new System.Drawing.Point(159, 212);
            this.btnWord.Name = "btnWord";
            this.btnWord.Size = new System.Drawing.Size(170, 63);
            this.btnWord.TabIndex = 2;
            this.btnWord.Text = "Pokrenite Word";
            this.btnWord.UseVisualStyleBackColor = true;
            // 
            // btnStartInfo
            // 
            this.btnStartInfo.Location = new System.Drawing.Point(463, 212);
            this.btnStartInfo.Name = "btnStartInfo";
            this.btnStartInfo.Size = new System.Drawing.Size(170, 63);
            this.btnStartInfo.TabIndex = 3;
            this.btnStartInfo.Text = "StartInfo";
            this.btnStartInfo.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnStartInfo);
            this.Controls.Add(this.btnWord);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.btnInternet);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInternet;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Button btnWord;
        private System.Windows.Forms.Button btnStartInfo;
    }
}

