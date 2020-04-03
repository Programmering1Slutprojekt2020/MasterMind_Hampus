namespace MasterMind
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCheck = new System.Windows.Forms.Button();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.btnPink = new System.Windows.Forms.Button();
            this.btnOrange = new System.Windows.Forms.Button();
            this.btnDarkGreen = new System.Windows.Forms.Button();
            this.btnDarkBlue = new System.Windows.Forms.Button();
            this.btnYellow = new System.Windows.Forms.Button();
            this.btnLightGreen = new System.Windows.Forms.Button();
            this.btnBlue = new System.Windows.Forms.Button();
            this.btnRed = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.Controls.Add(this.btnCheck);
            this.panel1.Controls.Add(this.btnNewGame);
            this.panel1.Controls.Add(this.btnPink);
            this.panel1.Controls.Add(this.btnOrange);
            this.panel1.Controls.Add(this.btnDarkGreen);
            this.panel1.Controls.Add(this.btnDarkBlue);
            this.panel1.Controls.Add(this.btnYellow);
            this.panel1.Controls.Add(this.btnLightGreen);
            this.panel1.Controls.Add(this.btnBlue);
            this.panel1.Controls.Add(this.btnRed);
            this.panel1.Location = new System.Drawing.Point(10, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 700);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseClick);
            // 
            // btnCheck
            // 
            this.btnCheck.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCheck.BackColor = System.Drawing.Color.LightGray;
            this.btnCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCheck.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnCheck.FlatAppearance.BorderSize = 3;
            this.btnCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheck.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheck.ForeColor = System.Drawing.Color.Black;
            this.btnCheck.Location = new System.Drawing.Point(228, 492);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(60, 30);
            this.btnCheck.TabIndex = 10;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // btnNewGame
            // 
            this.btnNewGame.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnNewGame.BackColor = System.Drawing.Color.LightGray;
            this.btnNewGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewGame.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnNewGame.FlatAppearance.BorderSize = 3;
            this.btnNewGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewGame.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewGame.ForeColor = System.Drawing.Color.Black;
            this.btnNewGame.Location = new System.Drawing.Point(280, 559);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(67, 68);
            this.btnNewGame.TabIndex = 9;
            this.btnNewGame.Text = "New Game";
            this.btnNewGame.UseVisualStyleBackColor = false;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // btnPink
            // 
            this.btnPink.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnPink.BackColor = System.Drawing.Color.Pink;
            this.btnPink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPink.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPink.ForeColor = System.Drawing.Color.Black;
            this.btnPink.Location = new System.Drawing.Point(180, 596);
            this.btnPink.Name = "btnPink";
            this.btnPink.Size = new System.Drawing.Size(40, 40);
            this.btnPink.TabIndex = 8;
            this.btnPink.UseVisualStyleBackColor = false;
            this.btnPink.Click += new System.EventHandler(this.btnPink_Click);
            // 
            // btnOrange
            // 
            this.btnOrange.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnOrange.BackColor = System.Drawing.Color.Orange;
            this.btnOrange.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOrange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrange.ForeColor = System.Drawing.Color.Black;
            this.btnOrange.Location = new System.Drawing.Point(130, 596);
            this.btnOrange.Name = "btnOrange";
            this.btnOrange.Size = new System.Drawing.Size(40, 40);
            this.btnOrange.TabIndex = 7;
            this.btnOrange.UseVisualStyleBackColor = false;
            this.btnOrange.Click += new System.EventHandler(this.btnOrange_Click);
            // 
            // btnDarkGreen
            // 
            this.btnDarkGreen.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDarkGreen.BackColor = System.Drawing.Color.DarkGreen;
            this.btnDarkGreen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDarkGreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDarkGreen.ForeColor = System.Drawing.Color.Black;
            this.btnDarkGreen.Location = new System.Drawing.Point(80, 596);
            this.btnDarkGreen.Name = "btnDarkGreen";
            this.btnDarkGreen.Size = new System.Drawing.Size(40, 40);
            this.btnDarkGreen.TabIndex = 6;
            this.btnDarkGreen.UseVisualStyleBackColor = false;
            this.btnDarkGreen.Click += new System.EventHandler(this.btnDarkGreen_Click);
            // 
            // btnDarkBlue
            // 
            this.btnDarkBlue.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDarkBlue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnDarkBlue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDarkBlue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDarkBlue.Location = new System.Drawing.Point(30, 596);
            this.btnDarkBlue.Name = "btnDarkBlue";
            this.btnDarkBlue.Size = new System.Drawing.Size(40, 40);
            this.btnDarkBlue.TabIndex = 5;
            this.btnDarkBlue.UseVisualStyleBackColor = false;
            this.btnDarkBlue.Click += new System.EventHandler(this.btnDarkBlue_Click);
            // 
            // btnYellow
            // 
            this.btnYellow.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnYellow.BackColor = System.Drawing.Color.Yellow;
            this.btnYellow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnYellow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYellow.ForeColor = System.Drawing.Color.Black;
            this.btnYellow.Location = new System.Drawing.Point(180, 550);
            this.btnYellow.Name = "btnYellow";
            this.btnYellow.Size = new System.Drawing.Size(40, 40);
            this.btnYellow.TabIndex = 4;
            this.btnYellow.UseVisualStyleBackColor = false;
            this.btnYellow.Click += new System.EventHandler(this.btnYellow_Click);
            // 
            // btnLightGreen
            // 
            this.btnLightGreen.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLightGreen.BackColor = System.Drawing.Color.LightGreen;
            this.btnLightGreen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLightGreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLightGreen.ForeColor = System.Drawing.Color.Black;
            this.btnLightGreen.Location = new System.Drawing.Point(130, 550);
            this.btnLightGreen.Name = "btnLightGreen";
            this.btnLightGreen.Size = new System.Drawing.Size(40, 40);
            this.btnLightGreen.TabIndex = 3;
            this.btnLightGreen.UseVisualStyleBackColor = false;
            this.btnLightGreen.Click += new System.EventHandler(this.btnLightGreen_Click);
            // 
            // btnBlue
            // 
            this.btnBlue.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBlue.BackColor = System.Drawing.Color.Blue;
            this.btnBlue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBlue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBlue.ForeColor = System.Drawing.Color.Black;
            this.btnBlue.Location = new System.Drawing.Point(80, 550);
            this.btnBlue.Name = "btnBlue";
            this.btnBlue.Size = new System.Drawing.Size(40, 40);
            this.btnBlue.TabIndex = 2;
            this.btnBlue.UseVisualStyleBackColor = false;
            this.btnBlue.Click += new System.EventHandler(this.btnBlue_Click);
            // 
            // btnRed
            // 
            this.btnRed.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnRed.BackColor = System.Drawing.Color.Red;
            this.btnRed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRed.Location = new System.Drawing.Point(30, 550);
            this.btnRed.Name = "btnRed";
            this.btnRed.Size = new System.Drawing.Size(40, 40);
            this.btnRed.TabIndex = 1;
            this.btnRed.UseVisualStyleBackColor = false;
            this.btnRed.Click += new System.EventHandler(this.btnRed_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(434, 711);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "MasterMind";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button btnNewGame;
        public System.Windows.Forms.Button btnRed;
        public System.Windows.Forms.Button btnBlue;
        public System.Windows.Forms.Button btnLightGreen;
        public System.Windows.Forms.Button btnYellow;
        public System.Windows.Forms.Button btnPink;
        public System.Windows.Forms.Button btnOrange;
        public System.Windows.Forms.Button btnDarkGreen;
        public System.Windows.Forms.Button btnDarkBlue;
        public System.Windows.Forms.Button btnCheck;
    }
}

