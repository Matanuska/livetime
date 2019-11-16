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
            this.liveTime2 = new livetime.LiveTime();
            this.liveTime1 = new livetime.LiveTime();
            this.SuspendLayout();
            // 
            // liveTime2
            // 
            this.liveTime2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.liveTime2.Format = "HH:mm:ss";
            this.liveTime2.Location = new System.Drawing.Point(211, 169);
            this.liveTime2.Name = "liveTime2";
            this.liveTime2.ReadOnly = true;
            this.liveTime2.Size = new System.Drawing.Size(155, 45);
            this.liveTime2.TabIndex = 1;
            this.liveTime2.Text = "19:07:40";
            this.liveTime2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.liveTime2.TimeZone = ((System.TimeZoneInfo)(resources.GetObject("liveTime2.TimeZone")));
            // 
            // liveTime1
            // 
            this.liveTime1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.liveTime1.Format = "HH:mm:ss";
            this.liveTime1.Location = new System.Drawing.Point(211, 47);
            this.liveTime1.Name = "liveTime1";
            this.liveTime1.ReadOnly = true;
            this.liveTime1.Size = new System.Drawing.Size(155, 45);
            this.liveTime1.TabIndex = 0;
            this.liveTime1.Text = "19:07:40";
            this.liveTime1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.liveTime1.TimeZone = ((System.TimeZoneInfo)(resources.GetObject("liveTime1.TimeZone")));
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.liveTime2);
            this.Controls.Add(this.liveTime1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private LiveTime liveTime1;
        private LiveTime liveTime2;
    }
}

