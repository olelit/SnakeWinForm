﻿namespace SnakeWinForm
{
    partial class Menu
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
            this.start = new System.Windows.Forms.Button();
            this.score = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(314, 145);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(188, 82);
            this.start.TabIndex = 0;
            this.start.Text = "Начать";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // score
            // 
            this.score.Location = new System.Drawing.Point(314, 233);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(188, 74);
            this.score.TabIndex = 1;
            this.score.Text = "Очки";
            this.score.UseVisualStyleBackColor = true;
            this.score.Click += new System.EventHandler(this.score_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(314, 313);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(188, 74);
            this.exit.TabIndex = 2;
            this.exit.Text = "Выход";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.score);
            this.Controls.Add(this.start);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button score;
        private System.Windows.Forms.Button exit;
    }
}