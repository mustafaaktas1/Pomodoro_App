namespace Pomodoro_App
{
    partial class Main
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose (bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent ()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.buttonstart = new System.Windows.Forms.Button();
            this.buttonpause = new System.Windows.Forms.Button();
            this.buttonreset = new System.Windows.Forms.Button();
            this.buttonsure = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(217, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(471, 112);
            this.label1.TabIndex = 0;
            this.label1.Text = "00:00:00";
            // 
            // buttonstart
            // 
            this.buttonstart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(205)))), ((int)(((byte)(151)))));
            this.buttonstart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonstart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonstart.ForeColor = System.Drawing.Color.White;
            this.buttonstart.Location = new System.Drawing.Point(52, 178);
            this.buttonstart.Name = "buttonstart";
            this.buttonstart.Size = new System.Drawing.Size(150, 50);
            this.buttonstart.TabIndex = 1;
            this.buttonstart.Text = "Başla";
            this.buttonstart.UseVisualStyleBackColor = false;
            this.buttonstart.Click += new System.EventHandler(this.buttonstart_Click);
            // 
            // buttonpause
            // 
            this.buttonpause.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(86)))), ((int)(((byte)(91)))));
            this.buttonpause.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonpause.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonpause.ForeColor = System.Drawing.Color.White;
            this.buttonpause.Location = new System.Drawing.Point(253, 178);
            this.buttonpause.Name = "buttonpause";
            this.buttonpause.Size = new System.Drawing.Size(150, 50);
            this.buttonpause.TabIndex = 2;
            this.buttonpause.Text = "Duraklat";
            this.buttonpause.UseVisualStyleBackColor = false;
            this.buttonpause.Click += new System.EventHandler(this.buttonpause_Click);
            // 
            // buttonreset
            // 
            this.buttonreset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(130)))), ((int)(((byte)(196)))));
            this.buttonreset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonreset.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonreset.ForeColor = System.Drawing.Color.White;
            this.buttonreset.Location = new System.Drawing.Point(464, 177);
            this.buttonreset.Name = "buttonreset";
            this.buttonreset.Size = new System.Drawing.Size(150, 50);
            this.buttonreset.TabIndex = 3;
            this.buttonreset.Text = "Sıfırla";
            this.buttonreset.UseVisualStyleBackColor = false;
            this.buttonreset.Click += new System.EventHandler(this.buttonreset_Click);
            // 
            // buttonsure
            // 
            this.buttonsure.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(190)))), ((int)(((byte)(22)))));
            this.buttonsure.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonsure.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonsure.ForeColor = System.Drawing.Color.White;
            this.buttonsure.Location = new System.Drawing.Point(659, 177);
            this.buttonsure.Name = "buttonsure";
            this.buttonsure.Size = new System.Drawing.Size(175, 50);
            this.buttonsure.TabIndex = 4;
            this.buttonsure.Text = "Süreyi Değiştir";
            this.buttonsure.UseVisualStyleBackColor = false;
            this.buttonsure.Click += new System.EventHandler(this.buttonsure_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(38)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(872, 258);
            this.Controls.Add(this.buttonsure);
            this.Controls.Add(this.buttonreset);
            this.Controls.Add(this.buttonpause);
            this.Controls.Add(this.buttonstart);
            this.Controls.Add(this.label1);
            this.Name = "Main";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonstart;
        private System.Windows.Forms.Button buttonpause;
        private System.Windows.Forms.Button buttonreset;
        private System.Windows.Forms.Button buttonsure;
    }
}

