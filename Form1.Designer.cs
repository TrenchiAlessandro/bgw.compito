namespace bgw.compito
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.btStop2 = new System.Windows.Forms.Button();
            this.btAvvio2 = new System.Windows.Forms.Button();
            this.btAvvio100 = new System.Windows.Forms.Button();
            this.btStop100 = new System.Windows.Forms.Button();
            this.txtBox1 = new System.Windows.Forms.TextBox();
            this.txtBox2 = new System.Windows.Forms.TextBox();
            this.bgw = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // btStop2
            // 
            this.btStop2.Location = new System.Drawing.Point(31, 384);
            this.btStop2.Name = "btStop2";
            this.btStop2.Size = new System.Drawing.Size(82, 22);
            this.btStop2.TabIndex = 0;
            this.btStop2.Text = "Stop ";
            this.btStop2.UseVisualStyleBackColor = true;
            this.btStop2.Click += new System.EventHandler(this.btStop2_Click);
            // 
            // btAvvio2
            // 
            this.btAvvio2.Location = new System.Drawing.Point(31, 337);
            this.btAvvio2.Name = "btAvvio2";
            this.btAvvio2.Size = new System.Drawing.Size(82, 23);
            this.btAvvio2.TabIndex = 1;
            this.btAvvio2.Text = "Avvio 2";
            this.btAvvio2.UseVisualStyleBackColor = true;
            this.btAvvio2.Click += new System.EventHandler(this.btAvvio2_Click);
            // 
            // btAvvio100
            // 
            this.btAvvio100.Location = new System.Drawing.Point(230, 337);
            this.btAvvio100.Name = "btAvvio100";
            this.btAvvio100.Size = new System.Drawing.Size(82, 21);
            this.btAvvio100.TabIndex = 2;
            this.btAvvio100.Text = "Avvio 100";
            this.btAvvio100.UseVisualStyleBackColor = true;
            this.btAvvio100.Click += new System.EventHandler(this.btAvvio100_Click);
            // 
            // btStop100
            // 
            this.btStop100.Location = new System.Drawing.Point(231, 384);
            this.btStop100.Name = "btStop100";
            this.btStop100.Size = new System.Drawing.Size(82, 22);
            this.btStop100.TabIndex = 3;
            this.btStop100.Text = "Stop";
            this.btStop100.UseVisualStyleBackColor = true;
            this.btStop100.Click += new System.EventHandler(this.btStop100_Click);
            // 
            // txtBox1
            // 
            this.txtBox1.Location = new System.Drawing.Point(31, 35);
            this.txtBox1.Multiline = true;
            this.txtBox1.Name = "txtBox1";
            this.txtBox1.Size = new System.Drawing.Size(82, 273);
            this.txtBox1.TabIndex = 6;
            // 
            // txtBox2
            // 
            this.txtBox2.Location = new System.Drawing.Point(231, 35);
            this.txtBox2.Multiline = true;
            this.txtBox2.Name = "txtBox2";
            this.txtBox2.Size = new System.Drawing.Size(81, 273);
            this.txtBox2.TabIndex = 5;
            // 
            // bgw
            // 
            this.bgw.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgw_DoWork);
            this.bgw.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgw_ProgressChanged);
            this.bgw.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgw_RunWorkerCompleted);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 450);
            this.Controls.Add(this.txtBox2);
            this.Controls.Add(this.txtBox1);
            this.Controls.Add(this.btStop100);
            this.Controls.Add(this.btAvvio100);
            this.Controls.Add(this.btAvvio2);
            this.Controls.Add(this.btStop2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btStop2;
        private System.Windows.Forms.Button btAvvio2;
        private System.Windows.Forms.Button btAvvio100;
        private System.Windows.Forms.Button btStop100;
        private System.Windows.Forms.TextBox txtBox1;
        private System.Windows.Forms.TextBox txtBox2;
        private System.ComponentModel.BackgroundWorker bgw;
    }
}

