
namespace battleboats
{
    partial class menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menu));
            this.newGame = new System.Windows.Forms.Button();
            this.howTo = new System.Windows.Forms.Button();
            this.resumeGame = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // newGame
            // 
            this.newGame.Location = new System.Drawing.Point(611, 113);
            this.newGame.Name = "newGame";
            this.newGame.Size = new System.Drawing.Size(102, 26);
            this.newGame.TabIndex = 0;
            this.newGame.Text = "NewGame";
            this.newGame.UseVisualStyleBackColor = true;
            this.newGame.Click += new System.EventHandler(this.newGame_Click);
            // 
            // howTo
            // 
            this.howTo.Location = new System.Drawing.Point(611, 142);
            this.howTo.Name = "howTo";
            this.howTo.Size = new System.Drawing.Size(102, 26);
            this.howTo.TabIndex = 1;
            this.howTo.Text = "How To Play";
            this.howTo.UseVisualStyleBackColor = true;
            this.howTo.Click += new System.EventHandler(this.howTo_Click);
            // 
            // resumeGame
            // 
            this.resumeGame.Location = new System.Drawing.Point(611, 171);
            this.resumeGame.Name = "resumeGame";
            this.resumeGame.Size = new System.Drawing.Size(102, 26);
            this.resumeGame.TabIndex = 2;
            this.resumeGame.Text = "Resume Game";
            this.resumeGame.UseVisualStyleBackColor = true;
            this.resumeGame.Click += new System.EventHandler(this.resumeGame_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(611, 200);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(102, 26);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Quit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(23, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(480, 362);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palace Script MT", 56.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(509, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 69);
            this.label1.TabIndex = 5;
            this.label1.Text = "Battle Boats";
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.resumeGame);
            this.Controls.Add(this.howTo);
            this.Controls.Add(this.newGame);
            this.Name = "menu";
            this.Text = "menu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button newGame;
        private System.Windows.Forms.Button howTo;
        private System.Windows.Forms.Button resumeGame;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}