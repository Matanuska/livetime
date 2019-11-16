namespace livetime
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.liveTime1 = new livetime.LiveTime();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // liveTime1
            // 
            this.liveTime1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.liveTime1.Format = "HH:mm:ss";
            this.liveTime1.Location = new System.Drawing.Point(45, 12);
            this.liveTime1.Name = "liveTime1";
            this.liveTime1.ReadOnly = true;
            this.liveTime1.Size = new System.Drawing.Size(155, 45);
            this.liveTime1.TabIndex = 0;
            this.liveTime1.Text = "19:10:44";
            this.liveTime1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.liveTime1.TimeZone = ((System.TimeZoneInfo)(resources.GetObject("liveTime1.TimeZone")));
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(45, 72);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "set to Alaska";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 118);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.liveTime1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private LiveTime liveTime1;
        private System.Windows.Forms.Button button1;
    }
}

