﻿
namespace MouseMover
{
    partial class TitlePage
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
            this.begin = new System.Windows.Forms.Button();
            this.stop = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.TextBox();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // begin
            // 
            this.begin.Location = new System.Drawing.Point(199, 232);
            this.begin.Name = "begin";
            this.begin.Size = new System.Drawing.Size(75, 23);
            this.begin.TabIndex = 0;
            this.begin.Text = "Begin";
            this.begin.UseVisualStyleBackColor = true;
            this.begin.Click += new System.EventHandler(this.begin_Click);
            // 
            // stop
            // 
            this.stop.Location = new System.Drawing.Point(501, 232);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(75, 23);
            this.stop.TabIndex = 1;
            this.stop.Text = "Stop";
            this.stop.UseVisualStyleBackColor = true;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // title
            // 
            this.title.Location = new System.Drawing.Point(199, 83);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(377, 20);
            this.title.TabIndex = 2;
            this.title.Text = "Mouse Mover 2000";
            this.title.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Timer1
            // 
            this.Timer1.Interval = 5000;
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // comboBox1
            // 
            this.comboBox1.Items.AddRange(new object[] {
            "3 seconds",
            "10 seconds",
            "30 seconds",
            "1 minute",
            "5 minutes",
            "10 minutes"});
            this.comboBox1.Location = new System.Drawing.Point(328, 291);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // TitlePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.title);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.begin);
            this.Name = "TitlePage";
            this.Text = "Mouse Mover 2000";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button begin;
        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.TextBox title;
        private System.Windows.Forms.Timer Timer1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

