﻿#region COPYRIGHT
/**
 * This file is part of Sardauscan by Fabio Ferretti, licensed under the CC-BY-NC-SA 4.0 Licence.
 * You can find the original code in this GitHub repository: https://github.com/Sardau/Sardauscan
 */
#endregion
using Sardauscan.Gui.Controls;
namespace Sardauscan.Gui.Forms
{
    partial class TaskPropertiesForm
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
			this.Grid = new System.Windows.Forms.PropertyGrid();
			this.imageButton1 = new Sardauscan.Gui.Controls.ImageButton();
			this.imageButton2 = new Sardauscan.Gui.Controls.ImageButton();
			this.SuspendLayout();
			// 
			// Grid
			// 
			this.Grid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.Grid.Location = new System.Drawing.Point(0, -1);
			this.Grid.Name = "Grid";
			this.Grid.Size = new System.Drawing.Size(456, 307);
			this.Grid.TabIndex = 0;
			this.Grid.ToolbarVisible = false;
			// 
			// imageButton1
			// 
			this.imageButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.imageButton1.BackColor = System.Drawing.Color.Transparent;
			this.imageButton1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.imageButton1.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.imageButton1.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.imageButton1.Image = global::Sardauscan.Properties.Resources.Check;
			this.imageButton1.Location = new System.Drawing.Point(372, 312);
			this.imageButton1.Name = "imageButton1";
			this.imageButton1.Size = new System.Drawing.Size(36, 35);
			this.imageButton1.TabIndex = 1;
			this.imageButton1.Click += new System.EventHandler(this.imageButton1_Click);
			// 
			// imageButton2
			// 
			this.imageButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.imageButton2.BackColor = System.Drawing.Color.Transparent;
			this.imageButton2.Cursor = System.Windows.Forms.Cursors.Hand;
			this.imageButton2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.imageButton2.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.imageButton2.Image = global::Sardauscan.Properties.Resources.Uncheck;
			this.imageButton2.Location = new System.Drawing.Point(414, 312);
			this.imageButton2.Name = "imageButton2";
			this.imageButton2.Size = new System.Drawing.Size(36, 35);
			this.imageButton2.TabIndex = 2;
			this.imageButton2.Click += new System.EventHandler(this.imageButton1_Click);
			// 
			// TaskPropertiesForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(457, 349);
			this.Controls.Add(this.imageButton2);
			this.Controls.Add(this.imageButton1);
			this.Controls.Add(this.Grid);
			this.Name = "TaskPropertiesForm";
			this.Text = "Edit Task Settings";
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PropertyGrid Grid;
        private ImageButton imageButton1;
        private ImageButton imageButton2;
    }
}