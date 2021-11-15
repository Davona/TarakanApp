
namespace TarakanApp
{
    partial class TarakanForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TarakanForm));
            this.tarakan = new System.Windows.Forms.Button();
            this.tarakan1 = new System.Windows.Forms.Button();
            this.tarakan2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.startbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tarakan
            // 
            this.tarakan.Location = new System.Drawing.Point(85, 55);
            this.tarakan.Name = "tarakan";
            this.tarakan.Size = new System.Drawing.Size(83, 23);
            this.tarakan.TabIndex = 0;
            this.tarakan.Text = "Tarakan";
            this.tarakan.UseVisualStyleBackColor = true;
            // 
            // tarakan1
            // 
            this.tarakan1.Location = new System.Drawing.Point(85, 160);
            this.tarakan1.Name = "tarakan1";
            this.tarakan1.Size = new System.Drawing.Size(83, 23);
            this.tarakan1.TabIndex = 1;
            this.tarakan1.Text = "Tarakan1";
            this.tarakan1.UseVisualStyleBackColor = true;
            // 
            // tarakan2
            // 
            this.tarakan2.Location = new System.Drawing.Point(85, 259);
            this.tarakan2.Name = "tarakan2";
            this.tarakan2.Size = new System.Drawing.Size(83, 23);
            this.tarakan2.TabIndex = 2;
            this.tarakan2.Text = "Tarakan2";
            this.tarakan2.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(681, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(107, 330);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // startbutton
            // 
            this.startbutton.Location = new System.Drawing.Point(349, 404);
            this.startbutton.Name = "startbutton";
            this.startbutton.Size = new System.Drawing.Size(75, 23);
            this.startbutton.TabIndex = 4;
            this.startbutton.Text = "Start";
            this.startbutton.UseVisualStyleBackColor = true;
            this.startbutton.Click += new System.EventHandler(this.startbutton_Click);
            // 
            // TarakanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.startbutton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tarakan2);
            this.Controls.Add(this.tarakan1);
            this.Controls.Add(this.tarakan);
            this.Name = "TarakanForm";
            this.Text = "TarakanForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button tarakan;
        private System.Windows.Forms.Button tarakan1;
        private System.Windows.Forms.Button tarakan2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button startbutton;
    }
}

