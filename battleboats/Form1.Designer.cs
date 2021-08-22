
namespace battleboats
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
            this.A1Player = new System.Windows.Forms.Button();
            this.A2Player = new System.Windows.Forms.Button();
            this.A4Player = new System.Windows.Forms.Button();
            this.A3Player = new System.Windows.Forms.Button();
            this.B4Player = new System.Windows.Forms.Button();
            this.B3Player = new System.Windows.Forms.Button();
            this.B2Player = new System.Windows.Forms.Button();
            this.B1Player = new System.Windows.Forms.Button();
            this.C4Player = new System.Windows.Forms.Button();
            this.C3Player = new System.Windows.Forms.Button();
            this.C2Player = new System.Windows.Forms.Button();
            this.C1Player = new System.Windows.Forms.Button();
            this.D4Player = new System.Windows.Forms.Button();
            this.D3Player = new System.Windows.Forms.Button();
            this.D2Player = new System.Windows.Forms.Button();
            this.D1Player = new System.Windows.Forms.Button();
            this.D4Comp = new System.Windows.Forms.Button();
            this.D3Comp = new System.Windows.Forms.Button();
            this.D2Comp = new System.Windows.Forms.Button();
            this.D1Comp = new System.Windows.Forms.Button();
            this.C4Comp = new System.Windows.Forms.Button();
            this.C3Comp = new System.Windows.Forms.Button();
            this.C2Comp = new System.Windows.Forms.Button();
            this.C1Comp = new System.Windows.Forms.Button();
            this.B4Comp = new System.Windows.Forms.Button();
            this.B3Comp = new System.Windows.Forms.Button();
            this.B2Comp = new System.Windows.Forms.Button();
            this.B1Comp = new System.Windows.Forms.Button();
            this.A4Comp = new System.Windows.Forms.Button();
            this.A3Comp = new System.Windows.Forms.Button();
            this.A2Comp = new System.Windows.Forms.Button();
            this.A1Comp = new System.Windows.Forms.Button();
            this.AttackChoices = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.attackButton = new System.Windows.Forms.Button();
            this.playerScoreTxt = new System.Windows.Forms.Label();
            this.compScoreTxt = new System.Windows.Forms.Label();
            this.enemyMoveTxt = new System.Windows.Forms.Label();
            this.compMove = new System.Windows.Forms.Label();
            this.roundsTxt = new System.Windows.Forms.Label();
            this.CompPlayTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // A1Player
            // 
            this.A1Player.Location = new System.Drawing.Point(130, 91);
            this.A1Player.Name = "A1Player";
            this.A1Player.Size = new System.Drawing.Size(75, 61);
            this.A1Player.TabIndex = 0;
            this.A1Player.Text = "A1";
            this.A1Player.UseVisualStyleBackColor = true;
            this.A1Player.Click += new System.EventHandler(this.PlayerPositionButtonsEvent);
            // 
            // A2Player
            // 
            this.A2Player.Location = new System.Drawing.Point(211, 91);
            this.A2Player.Name = "A2Player";
            this.A2Player.Size = new System.Drawing.Size(75, 61);
            this.A2Player.TabIndex = 1;
            this.A2Player.Text = "A2";
            this.A2Player.UseVisualStyleBackColor = true;
            this.A2Player.Click += new System.EventHandler(this.PlayerPositionButtonsEvent);
            // 
            // A4Player
            // 
            this.A4Player.Location = new System.Drawing.Point(373, 91);
            this.A4Player.Name = "A4Player";
            this.A4Player.Size = new System.Drawing.Size(75, 61);
            this.A4Player.TabIndex = 3;
            this.A4Player.Text = "A4";
            this.A4Player.UseVisualStyleBackColor = true;
            this.A4Player.Click += new System.EventHandler(this.PlayerPositionButtonsEvent);
            // 
            // A3Player
            // 
            this.A3Player.Location = new System.Drawing.Point(292, 91);
            this.A3Player.Name = "A3Player";
            this.A3Player.Size = new System.Drawing.Size(75, 61);
            this.A3Player.TabIndex = 2;
            this.A3Player.Text = "A3";
            this.A3Player.UseVisualStyleBackColor = true;
            this.A3Player.Click += new System.EventHandler(this.PlayerPositionButtonsEvent);
            // 
            // B4Player
            // 
            this.B4Player.Location = new System.Drawing.Point(373, 158);
            this.B4Player.Name = "B4Player";
            this.B4Player.Size = new System.Drawing.Size(75, 61);
            this.B4Player.TabIndex = 7;
            this.B4Player.Text = "B4";
            this.B4Player.UseVisualStyleBackColor = true;
            this.B4Player.Click += new System.EventHandler(this.PlayerPositionButtonsEvent);
            // 
            // B3Player
            // 
            this.B3Player.Location = new System.Drawing.Point(292, 158);
            this.B3Player.Name = "B3Player";
            this.B3Player.Size = new System.Drawing.Size(75, 61);
            this.B3Player.TabIndex = 6;
            this.B3Player.Text = "B3";
            this.B3Player.UseVisualStyleBackColor = true;
            this.B3Player.Click += new System.EventHandler(this.PlayerPositionButtonsEvent);
            // 
            // B2Player
            // 
            this.B2Player.Location = new System.Drawing.Point(211, 158);
            this.B2Player.Name = "B2Player";
            this.B2Player.Size = new System.Drawing.Size(75, 61);
            this.B2Player.TabIndex = 5;
            this.B2Player.Text = "B2";
            this.B2Player.UseVisualStyleBackColor = true;
            this.B2Player.Click += new System.EventHandler(this.PlayerPositionButtonsEvent);
            // 
            // B1Player
            // 
            this.B1Player.Location = new System.Drawing.Point(130, 158);
            this.B1Player.Name = "B1Player";
            this.B1Player.Size = new System.Drawing.Size(75, 61);
            this.B1Player.TabIndex = 4;
            this.B1Player.Text = "B1";
            this.B1Player.UseVisualStyleBackColor = true;
            this.B1Player.Click += new System.EventHandler(this.PlayerPositionButtonsEvent);
            // 
            // C4Player
            // 
            this.C4Player.Location = new System.Drawing.Point(373, 225);
            this.C4Player.Name = "C4Player";
            this.C4Player.Size = new System.Drawing.Size(75, 61);
            this.C4Player.TabIndex = 11;
            this.C4Player.Text = "C4";
            this.C4Player.UseVisualStyleBackColor = true;
            this.C4Player.Click += new System.EventHandler(this.PlayerPositionButtonsEvent);
            // 
            // C3Player
            // 
            this.C3Player.Location = new System.Drawing.Point(292, 225);
            this.C3Player.Name = "C3Player";
            this.C3Player.Size = new System.Drawing.Size(75, 61);
            this.C3Player.TabIndex = 10;
            this.C3Player.Text = "C3";
            this.C3Player.UseVisualStyleBackColor = true;
            this.C3Player.Click += new System.EventHandler(this.PlayerPositionButtonsEvent);
            // 
            // C2Player
            // 
            this.C2Player.Location = new System.Drawing.Point(211, 225);
            this.C2Player.Name = "C2Player";
            this.C2Player.Size = new System.Drawing.Size(75, 61);
            this.C2Player.TabIndex = 9;
            this.C2Player.Text = "C2";
            this.C2Player.UseVisualStyleBackColor = true;
            this.C2Player.Click += new System.EventHandler(this.PlayerPositionButtonsEvent);
            // 
            // C1Player
            // 
            this.C1Player.Location = new System.Drawing.Point(130, 225);
            this.C1Player.Name = "C1Player";
            this.C1Player.Size = new System.Drawing.Size(75, 61);
            this.C1Player.TabIndex = 8;
            this.C1Player.Text = "C1";
            this.C1Player.UseVisualStyleBackColor = true;
            this.C1Player.Click += new System.EventHandler(this.PlayerPositionButtonsEvent);
            // 
            // D4Player
            // 
            this.D4Player.Location = new System.Drawing.Point(373, 292);
            this.D4Player.Name = "D4Player";
            this.D4Player.Size = new System.Drawing.Size(75, 61);
            this.D4Player.TabIndex = 15;
            this.D4Player.Text = "D4";
            this.D4Player.UseVisualStyleBackColor = true;
            this.D4Player.Click += new System.EventHandler(this.PlayerPositionButtonsEvent);
            // 
            // D3Player
            // 
            this.D3Player.Location = new System.Drawing.Point(292, 292);
            this.D3Player.Name = "D3Player";
            this.D3Player.Size = new System.Drawing.Size(75, 61);
            this.D3Player.TabIndex = 14;
            this.D3Player.Text = "D3";
            this.D3Player.UseVisualStyleBackColor = true;
            this.D3Player.Click += new System.EventHandler(this.PlayerPositionButtonsEvent);
            // 
            // D2Player
            // 
            this.D2Player.Location = new System.Drawing.Point(211, 292);
            this.D2Player.Name = "D2Player";
            this.D2Player.Size = new System.Drawing.Size(75, 61);
            this.D2Player.TabIndex = 13;
            this.D2Player.Text = "D2";
            this.D2Player.UseVisualStyleBackColor = true;
            this.D2Player.Click += new System.EventHandler(this.PlayerPositionButtonsEvent);
            // 
            // D1Player
            // 
            this.D1Player.Location = new System.Drawing.Point(130, 292);
            this.D1Player.Name = "D1Player";
            this.D1Player.Size = new System.Drawing.Size(75, 61);
            this.D1Player.TabIndex = 12;
            this.D1Player.Text = "D1";
            this.D1Player.UseVisualStyleBackColor = true;
            this.D1Player.Click += new System.EventHandler(this.PlayerPositionButtonsEvent);
            // 
            // D4Comp
            // 
            this.D4Comp.Location = new System.Drawing.Point(870, 292);
            this.D4Comp.Name = "D4Comp";
            this.D4Comp.Size = new System.Drawing.Size(75, 61);
            this.D4Comp.TabIndex = 31;
            this.D4Comp.Text = "D4";
            this.D4Comp.UseVisualStyleBackColor = true;
            // 
            // D3Comp
            // 
            this.D3Comp.Location = new System.Drawing.Point(789, 292);
            this.D3Comp.Name = "D3Comp";
            this.D3Comp.Size = new System.Drawing.Size(75, 61);
            this.D3Comp.TabIndex = 30;
            this.D3Comp.Text = "D3";
            this.D3Comp.UseVisualStyleBackColor = true;
            // 
            // D2Comp
            // 
            this.D2Comp.Location = new System.Drawing.Point(708, 292);
            this.D2Comp.Name = "D2Comp";
            this.D2Comp.Size = new System.Drawing.Size(75, 61);
            this.D2Comp.TabIndex = 29;
            this.D2Comp.Text = "D2";
            this.D2Comp.UseVisualStyleBackColor = true;
            // 
            // D1Comp
            // 
            this.D1Comp.Location = new System.Drawing.Point(627, 292);
            this.D1Comp.Name = "D1Comp";
            this.D1Comp.Size = new System.Drawing.Size(75, 61);
            this.D1Comp.TabIndex = 28;
            this.D1Comp.Text = "D1";
            this.D1Comp.UseVisualStyleBackColor = true;
            // 
            // C4Comp
            // 
            this.C4Comp.Location = new System.Drawing.Point(870, 225);
            this.C4Comp.Name = "C4Comp";
            this.C4Comp.Size = new System.Drawing.Size(75, 61);
            this.C4Comp.TabIndex = 27;
            this.C4Comp.Text = "C4";
            this.C4Comp.UseVisualStyleBackColor = true;
            // 
            // C3Comp
            // 
            this.C3Comp.Location = new System.Drawing.Point(789, 225);
            this.C3Comp.Name = "C3Comp";
            this.C3Comp.Size = new System.Drawing.Size(75, 61);
            this.C3Comp.TabIndex = 26;
            this.C3Comp.Text = "C3";
            this.C3Comp.UseVisualStyleBackColor = true;
            // 
            // C2Comp
            // 
            this.C2Comp.Location = new System.Drawing.Point(708, 225);
            this.C2Comp.Name = "C2Comp";
            this.C2Comp.Size = new System.Drawing.Size(75, 61);
            this.C2Comp.TabIndex = 25;
            this.C2Comp.Text = "C2";
            this.C2Comp.UseVisualStyleBackColor = true;
            // 
            // C1Comp
            // 
            this.C1Comp.Location = new System.Drawing.Point(627, 225);
            this.C1Comp.Name = "C1Comp";
            this.C1Comp.Size = new System.Drawing.Size(75, 61);
            this.C1Comp.TabIndex = 24;
            this.C1Comp.Text = "C1";
            this.C1Comp.UseVisualStyleBackColor = true;
            // 
            // B4Comp
            // 
            this.B4Comp.Location = new System.Drawing.Point(870, 158);
            this.B4Comp.Name = "B4Comp";
            this.B4Comp.Size = new System.Drawing.Size(75, 61);
            this.B4Comp.TabIndex = 23;
            this.B4Comp.Text = "B4";
            this.B4Comp.UseVisualStyleBackColor = true;
            // 
            // B3Comp
            // 
            this.B3Comp.Location = new System.Drawing.Point(789, 158);
            this.B3Comp.Name = "B3Comp";
            this.B3Comp.Size = new System.Drawing.Size(75, 61);
            this.B3Comp.TabIndex = 22;
            this.B3Comp.Text = "B3";
            this.B3Comp.UseVisualStyleBackColor = true;
            // 
            // B2Comp
            // 
            this.B2Comp.Location = new System.Drawing.Point(708, 158);
            this.B2Comp.Name = "B2Comp";
            this.B2Comp.Size = new System.Drawing.Size(75, 61);
            this.B2Comp.TabIndex = 21;
            this.B2Comp.Text = "B2";
            this.B2Comp.UseVisualStyleBackColor = true;
            // 
            // B1Comp
            // 
            this.B1Comp.Location = new System.Drawing.Point(627, 158);
            this.B1Comp.Name = "B1Comp";
            this.B1Comp.Size = new System.Drawing.Size(75, 61);
            this.B1Comp.TabIndex = 20;
            this.B1Comp.Text = "B1";
            this.B1Comp.UseVisualStyleBackColor = true;
            // 
            // A4Comp
            // 
            this.A4Comp.Location = new System.Drawing.Point(870, 91);
            this.A4Comp.Name = "A4Comp";
            this.A4Comp.Size = new System.Drawing.Size(75, 61);
            this.A4Comp.TabIndex = 19;
            this.A4Comp.Text = "A4";
            this.A4Comp.UseVisualStyleBackColor = true;
            // 
            // A3Comp
            // 
            this.A3Comp.Location = new System.Drawing.Point(789, 91);
            this.A3Comp.Name = "A3Comp";
            this.A3Comp.Size = new System.Drawing.Size(75, 61);
            this.A3Comp.TabIndex = 18;
            this.A3Comp.Text = "A3";
            this.A3Comp.UseVisualStyleBackColor = true;
            // 
            // A2Comp
            // 
            this.A2Comp.Location = new System.Drawing.Point(708, 91);
            this.A2Comp.Name = "A2Comp";
            this.A2Comp.Size = new System.Drawing.Size(75, 61);
            this.A2Comp.TabIndex = 17;
            this.A2Comp.Text = "A2";
            this.A2Comp.UseVisualStyleBackColor = true;
            // 
            // A1Comp
            // 
            this.A1Comp.Location = new System.Drawing.Point(627, 91);
            this.A1Comp.Name = "A1Comp";
            this.A1Comp.Size = new System.Drawing.Size(75, 61);
            this.A1Comp.TabIndex = 16;
            this.A1Comp.Text = "A1";
            this.A1Comp.UseVisualStyleBackColor = true;
            // 
            // AttackChoices
            // 
            this.AttackChoices.FormattingEnabled = true;
            this.AttackChoices.Location = new System.Drawing.Point(236, 32);
            this.AttackChoices.Name = "AttackChoices";
            this.AttackChoices.Size = new System.Drawing.Size(74, 21);
            this.AttackChoices.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(153, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Choose Attack";
            // 
            // attackButton
            // 
            this.attackButton.Location = new System.Drawing.Point(316, 32);
            this.attackButton.Name = "attackButton";
            this.attackButton.Size = new System.Drawing.Size(75, 23);
            this.attackButton.TabIndex = 34;
            this.attackButton.Text = "Fire";
            this.attackButton.UseVisualStyleBackColor = true;
            this.attackButton.Click += new System.EventHandler(this.AttackButtonEvent);
            // 
            // playerScoreTxt
            // 
            this.playerScoreTxt.AutoSize = true;
            this.playerScoreTxt.Location = new System.Drawing.Point(410, 379);
            this.playerScoreTxt.Name = "playerScoreTxt";
            this.playerScoreTxt.Size = new System.Drawing.Size(19, 13);
            this.playerScoreTxt.TabIndex = 35;
            this.playerScoreTxt.Text = "00";
            // 
            // compScoreTxt
            // 
            this.compScoreTxt.AutoSize = true;
            this.compScoreTxt.Location = new System.Drawing.Point(922, 379);
            this.compScoreTxt.Name = "compScoreTxt";
            this.compScoreTxt.Size = new System.Drawing.Size(19, 13);
            this.compScoreTxt.TabIndex = 36;
            this.compScoreTxt.Text = "00";
            // 
            // enemyMoveTxt
            // 
            this.enemyMoveTxt.AutoSize = true;
            this.enemyMoveTxt.Location = new System.Drawing.Point(755, 42);
            this.enemyMoveTxt.Name = "enemyMoveTxt";
            this.enemyMoveTxt.Size = new System.Drawing.Size(68, 13);
            this.enemyMoveTxt.TabIndex = 37;
            this.enemyMoveTxt.Text = "Enemy move";
            // 
            // compMove
            // 
            this.compMove.AutoSize = true;
            this.compMove.Location = new System.Drawing.Point(844, 42);
            this.compMove.Name = "compMove";
            this.compMove.Size = new System.Drawing.Size(20, 13);
            this.compMove.TabIndex = 38;
            this.compMove.Text = "A1";
            // 
            // roundsTxt
            // 
            this.roundsTxt.AutoSize = true;
            this.roundsTxt.Location = new System.Drawing.Point(514, 72);
            this.roundsTxt.Name = "roundsTxt";
            this.roundsTxt.Size = new System.Drawing.Size(35, 13);
            this.roundsTxt.TabIndex = 39;
            this.roundsTxt.Text = "label2";
            // 
            // CompPlayTimer
            // 
            this.CompPlayTimer.Interval = 1000;
            this.CompPlayTimer.Tick += new System.EventHandler(this.EnemyPlayTimerEvent);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 510);
            this.Controls.Add(this.roundsTxt);
            this.Controls.Add(this.compMove);
            this.Controls.Add(this.enemyMoveTxt);
            this.Controls.Add(this.compScoreTxt);
            this.Controls.Add(this.playerScoreTxt);
            this.Controls.Add(this.attackButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AttackChoices);
            this.Controls.Add(this.D4Comp);
            this.Controls.Add(this.D3Comp);
            this.Controls.Add(this.D2Comp);
            this.Controls.Add(this.D1Comp);
            this.Controls.Add(this.C4Comp);
            this.Controls.Add(this.C3Comp);
            this.Controls.Add(this.C2Comp);
            this.Controls.Add(this.C1Comp);
            this.Controls.Add(this.B4Comp);
            this.Controls.Add(this.B3Comp);
            this.Controls.Add(this.B2Comp);
            this.Controls.Add(this.B1Comp);
            this.Controls.Add(this.A4Comp);
            this.Controls.Add(this.A3Comp);
            this.Controls.Add(this.A2Comp);
            this.Controls.Add(this.A1Comp);
            this.Controls.Add(this.D4Player);
            this.Controls.Add(this.D3Player);
            this.Controls.Add(this.D2Player);
            this.Controls.Add(this.D1Player);
            this.Controls.Add(this.C4Player);
            this.Controls.Add(this.C3Player);
            this.Controls.Add(this.C2Player);
            this.Controls.Add(this.C1Player);
            this.Controls.Add(this.B4Player);
            this.Controls.Add(this.B3Player);
            this.Controls.Add(this.B2Player);
            this.Controls.Add(this.B1Player);
            this.Controls.Add(this.A4Player);
            this.Controls.Add(this.A3Player);
            this.Controls.Add(this.A2Player);
            this.Controls.Add(this.A1Player);
            this.Name = "Form1";
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button A1Player;
        private System.Windows.Forms.Button A2Player;
        private System.Windows.Forms.Button A4Player;
        private System.Windows.Forms.Button A3Player;
        private System.Windows.Forms.Button B4Player;
        private System.Windows.Forms.Button B3Player;
        private System.Windows.Forms.Button B2Player;
        private System.Windows.Forms.Button B1Player;
        private System.Windows.Forms.Button C4Player;
        private System.Windows.Forms.Button C3Player;
        private System.Windows.Forms.Button C2Player;
        private System.Windows.Forms.Button C1Player;
        private System.Windows.Forms.Button D4Player;
        private System.Windows.Forms.Button D3Player;
        private System.Windows.Forms.Button D2Player;
        private System.Windows.Forms.Button D1Player;
        private System.Windows.Forms.Button D4Comp;
        private System.Windows.Forms.Button D3Comp;
        private System.Windows.Forms.Button D2Comp;
        private System.Windows.Forms.Button D1Comp;
        private System.Windows.Forms.Button C4Comp;
        private System.Windows.Forms.Button C3Comp;
        private System.Windows.Forms.Button C2Comp;
        private System.Windows.Forms.Button C1Comp;
        private System.Windows.Forms.Button B4Comp;
        private System.Windows.Forms.Button B3Comp;
        private System.Windows.Forms.Button B2Comp;
        private System.Windows.Forms.Button B1Comp;
        private System.Windows.Forms.Button A4Comp;
        private System.Windows.Forms.Button A3Comp;
        private System.Windows.Forms.Button A2Comp;
        private System.Windows.Forms.Button A1Comp;
        private System.Windows.Forms.ComboBox AttackChoices;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button attackButton;
        private System.Windows.Forms.Label playerScoreTxt;
        private System.Windows.Forms.Label compScoreTxt;
        private System.Windows.Forms.Label enemyMoveTxt;
        private System.Windows.Forms.Label compMove;
        private System.Windows.Forms.Label roundsTxt;
        private System.Windows.Forms.Timer CompPlayTimer;
    }
}

