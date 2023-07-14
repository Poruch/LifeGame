namespace Life
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.button6 = new System.Windows.Forms.Button();
            this.scale1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.X2 = new System.Windows.Forms.TextBox();
            this.Y2 = new System.Windows.Forms.TextBox();
            this.Y1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.X1 = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Count1 = new System.Windows.Forms.TextBox();
            this.SpeedTime = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Spawner1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Painter = new System.Windows.Forms.Timer(this.components);
            this.Generation = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.button6);
            this.splitContainer1.Panel1.Controls.Add(this.scale1);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.X2);
            this.splitContainer1.Panel1.Controls.Add(this.Y2);
            this.splitContainer1.Panel1.Controls.Add(this.Y1);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.X1);
            this.splitContainer1.Panel1.Controls.Add(this.button5);
            this.splitContainer1.Panel1.Controls.Add(this.button4);
            this.splitContainer1.Panel1.Controls.Add(this.button3);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.Count1);
            this.splitContainer1.Panel1.Controls.Add(this.SpeedTime);
            this.splitContainer1.Panel1.Controls.Add(this.button2);
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            this.splitContainer1.Panel1.Controls.Add(this.Spawner1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox1);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(758, 554);
            this.splitContainer1.SplitterDistance = 200;
            this.splitContainer1.TabIndex = 0;
            this.splitContainer1.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainer1_SplitterMoved);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(4, 326);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 25;
            this.button6.Text = "применить";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // scale1
            // 
            this.scale1.Location = new System.Drawing.Point(7, 300);
            this.scale1.Name = "scale1";
            this.scale1.Size = new System.Drawing.Size(61, 20);
            this.scale1.TabIndex = 24;
            this.scale1.Text = "10";
            this.scale1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.X1_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 284);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Маштаб";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(114, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "2 точка";
            // 
            // X2
            // 
            this.X2.Location = new System.Drawing.Point(117, 178);
            this.X2.Name = "X2";
            this.X2.Size = new System.Drawing.Size(20, 20);
            this.X2.TabIndex = 21;
            this.X2.Text = "0";
            this.X2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.X1_KeyPress);
            // 
            // Y2
            // 
            this.Y2.Location = new System.Drawing.Point(143, 178);
            this.Y2.Name = "Y2";
            this.Y2.Size = new System.Drawing.Size(20, 20);
            this.Y2.TabIndex = 20;
            this.Y2.Text = "0";
            this.Y2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.X1_KeyPress);
            // 
            // Y1
            // 
            this.Y1.Location = new System.Drawing.Point(31, 178);
            this.Y1.Name = "Y1";
            this.Y1.Size = new System.Drawing.Size(20, 20);
            this.Y1.TabIndex = 19;
            this.Y1.Text = "0";
            this.Y1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.X1_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "1 точка";
            // 
            // X1
            // 
            this.X1.Location = new System.Drawing.Point(7, 178);
            this.X1.Name = "X1";
            this.X1.Size = new System.Drawing.Size(20, 20);
            this.X1.TabIndex = 17;
            this.X1.Text = "0";
            this.X1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.X1_KeyPress);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(4, 149);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(189, 23);
            this.button5.TabIndex = 13;
            this.button5.Text = "Delete ";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(117, 380);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 12;
            this.button4.Text = "Настройки";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(4, 119);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(189, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "Spawn Tree";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Count";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 367);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Speed Time";
            // 
            // Count1
            // 
            this.Count1.Location = new System.Drawing.Point(51, 93);
            this.Count1.Name = "Count1";
            this.Count1.Size = new System.Drawing.Size(34, 20);
            this.Count1.TabIndex = 4;
            this.Count1.Text = "1";
            this.Count1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.X1_KeyPress);
            // 
            // SpeedTime
            // 
            this.SpeedTime.Location = new System.Drawing.Point(7, 383);
            this.SpeedTime.Name = "SpeedTime";
            this.SpeedTime.Size = new System.Drawing.Size(64, 20);
            this.SpeedTime.TabIndex = 3;
            this.SpeedTime.Text = "1";
            this.SpeedTime.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.SpeedTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.X1_KeyPress);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(4, 64);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(189, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Spawn Omnivorous";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(4, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(189, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Spawn Predator";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Spawner1
            // 
            this.Spawner1.Location = new System.Drawing.Point(4, 4);
            this.Spawner1.Name = "Spawner1";
            this.Spawner1.Size = new System.Drawing.Size(189, 23);
            this.Spawner1.TabIndex = 0;
            this.Spawner1.Text = "SpawnAnimal";
            this.Spawner1.UseVisualStyleBackColor = true;
            this.Spawner1.Click += new System.EventHandler(this.Spawner1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(550, 550);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.DoubleClick += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Painter
            // 
            this.Painter.Enabled = true;
            this.Painter.Interval = 1;
            this.Painter.Tick += new System.EventHandler(this.Generation_Tick);
            // 
            // Generation
            // 
            this.Generation.Enabled = true;
            this.Generation.Interval = 1;
            this.Generation.Tick += new System.EventHandler(this.Generation_Tick_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 554);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        internal System.Windows.Forms.Timer Painter;
        private System.Windows.Forms.Button Spawner1;
        private System.Windows.Forms.Timer Generation;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox Count1;
        private System.Windows.Forms.TextBox SpeedTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox X1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox X2;
        private System.Windows.Forms.TextBox Y2;
        private System.Windows.Forms.TextBox Y1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox scale1;
        private System.Windows.Forms.Label label5;
    }
}

