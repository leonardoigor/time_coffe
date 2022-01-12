
namespace CoffeTime
{
    partial class Hora
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.button1 = new System.Windows.Forms.Button();
            this.hour = new System.Windows.Forms.Label();
            this.minute = new System.Windows.Forms.Label();
            this.second = new System.Windows.Forms.Label();
            this.mili = new System.Windows.Forms.Label();
            this.percentLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(0, 428);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(798, 23);
            this.progressBar1.TabIndex = 0;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(723, 399);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_ClickAsync);
            // 
            // hour
            // 
            this.hour.AutoSize = true;
            this.hour.Location = new System.Drawing.Point(12, 9);
            this.hour.Name = "hour";
            this.hour.Size = new System.Drawing.Size(35, 13);
            this.hour.TabIndex = 2;
            this.hour.Text = "label1";
            // 
            // minute
            // 
            this.minute.AutoSize = true;
            this.minute.Location = new System.Drawing.Point(12, 31);
            this.minute.Name = "minute";
            this.minute.Size = new System.Drawing.Size(35, 13);
            this.minute.TabIndex = 3;
            this.minute.Text = "label1";
            // 
            // second
            // 
            this.second.AutoSize = true;
            this.second.Location = new System.Drawing.Point(12, 55);
            this.second.Name = "second";
            this.second.Size = new System.Drawing.Size(35, 13);
            this.second.TabIndex = 4;
            this.second.Text = "label2";
            // 
            // mili
            // 
            this.mili.AutoSize = true;
            this.mili.Location = new System.Drawing.Point(12, 87);
            this.mili.Name = "mili";
            this.mili.Size = new System.Drawing.Size(35, 13);
            this.mili.TabIndex = 5;
            this.mili.Text = "label3";
            // 
            // percentLabel
            // 
            this.percentLabel.AutoSize = true;
            this.percentLabel.Location = new System.Drawing.Point(432, 404);
            this.percentLabel.Name = "percentLabel";
            this.percentLabel.Size = new System.Drawing.Size(21, 13);
            this.percentLabel.TabIndex = 6;
            this.percentLabel.Text = "0%";
            // 
            // Hora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.percentLabel);
            this.Controls.Add(this.mili);
            this.Controls.Add(this.second);
            this.Controls.Add(this.minute);
            this.Controls.Add(this.hour);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.progressBar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Hora";
            this.Text = "Hora Do Café";
            this.Load += new System.EventHandler(this.Hora_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label hour;
        private System.Windows.Forms.Label minute;
        private System.Windows.Forms.Label second;
        private System.Windows.Forms.Label mili;
        private System.Windows.Forms.Label percentLabel;
    }
}

