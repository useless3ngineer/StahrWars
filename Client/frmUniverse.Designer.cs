﻿using System;
using System.Windows.Forms;

namespace Client
{
    partial class frmUniverse
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
            this.panCanvas = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.panCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // panCanvas
            // 
            this.panCanvas.BackColor = System.Drawing.Color.Black;
            this.panCanvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panCanvas.Location = new System.Drawing.Point(12, 11);
            this.panCanvas.Name = "panCanvas";
            this.panCanvas.Size = new System.Drawing.Size(600, 600);
            this.panCanvas.TabIndex = 6;
            this.panCanvas.TabStop = false;
            this.panCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.panCanvas_Paint);

            // 
            // frmUniverse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 610);
            this.Controls.Add(this.panCanvas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUniverse";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StahrWars";
            ((System.ComponentModel.ISupportInitialize)(this.panCanvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion
		private PictureBox panCanvas;
        private String txtbox;



    }
}

