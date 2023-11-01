namespace Маяки
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
            this.components = new System.ComponentModel.Container();
            this.LightHouseImage1 = new System.Windows.Forms.PictureBox();
            this.LightHouseImage2 = new System.Windows.Forms.PictureBox();
            this.LightHouseImage3 = new System.Windows.Forms.PictureBox();
            this.StartCountEnabled = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.TimerLabel = new System.Windows.Forms.Label();
            this.LightHouseLabel1 = new System.Windows.Forms.Label();
            this.LightHouseLabel2 = new System.Windows.Forms.Label();
            this.LightHouseLabel3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.StartCountDisabled = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.LightHouseImage1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LightHouseImage2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LightHouseImage3)).BeginInit();
            this.SuspendLayout();
            // 
            // LightHouseImage1
            // 
            this.LightHouseImage1.BackColor = System.Drawing.Color.Red;
            this.LightHouseImage1.Location = new System.Drawing.Point(27, 22);
            this.LightHouseImage1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LightHouseImage1.Name = "LightHouseImage1";
            this.LightHouseImage1.Size = new System.Drawing.Size(150, 77);
            this.LightHouseImage1.TabIndex = 0;
            this.LightHouseImage1.TabStop = false;
            // 
            // LightHouseImage2
            // 
            this.LightHouseImage2.BackColor = System.Drawing.Color.Red;
            this.LightHouseImage2.Location = new System.Drawing.Point(274, 23);
            this.LightHouseImage2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LightHouseImage2.Name = "LightHouseImage2";
            this.LightHouseImage2.Size = new System.Drawing.Size(150, 77);
            this.LightHouseImage2.TabIndex = 1;
            this.LightHouseImage2.TabStop = false;
            // 
            // LightHouseImage3
            // 
            this.LightHouseImage3.BackColor = System.Drawing.Color.Red;
            this.LightHouseImage3.Location = new System.Drawing.Point(519, 22);
            this.LightHouseImage3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LightHouseImage3.Name = "LightHouseImage3";
            this.LightHouseImage3.Size = new System.Drawing.Size(150, 77);
            this.LightHouseImage3.TabIndex = 2;
            this.LightHouseImage3.TabStop = false;
            // 
            // StartCountEnabled
            // 
            this.StartCountEnabled.Location = new System.Drawing.Point(27, 158);
            this.StartCountEnabled.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.StartCountEnabled.Name = "StartCountEnabled";
            this.StartCountEnabled.Size = new System.Drawing.Size(237, 35);
            this.StartCountEnabled.TabIndex = 3;
            this.StartCountEnabled.Text = "Подсчет для красных";
            this.StartCountEnabled.UseVisualStyleBackColor = true;
            this.StartCountEnabled.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // TimerLabel
            // 
            this.TimerLabel.AutoSize = true;
            this.TimerLabel.Location = new System.Drawing.Point(514, 158);
            this.TimerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TimerLabel.Name = "TimerLabel";
            this.TimerLabel.Size = new System.Drawing.Size(66, 20);
            this.TimerLabel.TabIndex = 4;
            this.TimerLabel.Text = "Время: ";
            // 
            // LightHouseLabel1
            // 
            this.LightHouseLabel1.AutoSize = true;
            this.LightHouseLabel1.Location = new System.Drawing.Point(75, 109);
            this.LightHouseLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LightHouseLabel1.Name = "LightHouseLabel1";
            this.LightHouseLabel1.Size = new System.Drawing.Size(51, 20);
            this.LightHouseLabel1.TabIndex = 5;
            this.LightHouseLabel1.Text = "label1";
            // 
            // LightHouseLabel2
            // 
            this.LightHouseLabel2.AutoSize = true;
            this.LightHouseLabel2.Location = new System.Drawing.Point(322, 111);
            this.LightHouseLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LightHouseLabel2.Name = "LightHouseLabel2";
            this.LightHouseLabel2.Size = new System.Drawing.Size(51, 20);
            this.LightHouseLabel2.TabIndex = 6;
            this.LightHouseLabel2.Text = "label2";
            // 
            // LightHouseLabel3
            // 
            this.LightHouseLabel3.AutoSize = true;
            this.LightHouseLabel3.Location = new System.Drawing.Point(568, 111);
            this.LightHouseLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LightHouseLabel3.Name = "LightHouseLabel3";
            this.LightHouseLabel3.Size = new System.Drawing.Size(51, 20);
            this.LightHouseLabel3.TabIndex = 7;
            this.LightHouseLabel3.Text = "label3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 166);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 8;
            // 
            // StartCountDisabled
            // 
            this.StartCountDisabled.Location = new System.Drawing.Point(27, 229);
            this.StartCountDisabled.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.StartCountDisabled.Name = "StartCountDisabled";
            this.StartCountDisabled.Size = new System.Drawing.Size(237, 35);
            this.StartCountDisabled.TabIndex = 9;
            this.StartCountDisabled.Text = "Подсчет для синих";
            this.StartCountDisabled.UseVisualStyleBackColor = true;
            this.StartCountDisabled.Click += new System.EventHandler(this.button2_Click);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 429);
            this.Controls.Add(this.StartCountDisabled);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LightHouseLabel3);
            this.Controls.Add(this.LightHouseLabel2);
            this.Controls.Add(this.LightHouseLabel1);
            this.Controls.Add(this.TimerLabel);
            this.Controls.Add(this.StartCountEnabled);
            this.Controls.Add(this.LightHouseImage3);
            this.Controls.Add(this.LightHouseImage2);
            this.Controls.Add(this.LightHouseImage1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Маяки";
            ((System.ComponentModel.ISupportInitialize)(this.LightHouseImage1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LightHouseImage2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LightHouseImage3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox LightHouseImage1;
        private System.Windows.Forms.PictureBox LightHouseImage2;
        private System.Windows.Forms.PictureBox LightHouseImage3;
        private System.Windows.Forms.Button StartCountEnabled;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label TimerLabel;
        private System.Windows.Forms.Label LightHouseLabel1;
        private System.Windows.Forms.Label LightHouseLabel2;
        private System.Windows.Forms.Label LightHouseLabel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button StartCountDisabled;
        private System.Windows.Forms.Timer timer2;
    }
}

