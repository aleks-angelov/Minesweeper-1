namespace Minesweeper
{
    partial class DifficultyWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DifficultyWindow));
            this.difficulty_info = new System.Windows.Forms.Label();
            this.difficulty_scale = new System.Windows.Forms.TrackBar();
            this.difficulty_min = new System.Windows.Forms.Label();
            this.difficulty_max = new System.Windows.Forms.Label();
            this.difficulty_start = new System.Windows.Forms.Button();
            this.difficulty_value = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.difficulty_scale)).BeginInit();
            this.SuspendLayout();
            // 
            // difficulty_info
            // 
            this.difficulty_info.Location = new System.Drawing.Point(108, 9);
            this.difficulty_info.Name = "difficulty_info";
            this.difficulty_info.Size = new System.Drawing.Size(120, 35);
            this.difficulty_info.TabIndex = 0;
            this.difficulty_info.Text = "Number of Mines (Default is 40)";
            this.difficulty_info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // difficulty_scale
            // 
            this.difficulty_scale.Location = new System.Drawing.Point(16, 63);
            this.difficulty_scale.Maximum = 232;
            this.difficulty_scale.Minimum = 10;
            this.difficulty_scale.Name = "difficulty_scale";
            this.difficulty_scale.Size = new System.Drawing.Size(302, 45);
            this.difficulty_scale.TabIndex = 1;
            this.difficulty_scale.TickStyle = System.Windows.Forms.TickStyle.None;
            this.difficulty_scale.Value = 40;
            this.difficulty_scale.Scroll += new System.EventHandler(this.difficulty_scale_Scroll);
            // 
            // difficulty_min
            // 
            this.difficulty_min.AutoSize = true;
            this.difficulty_min.Location = new System.Drawing.Point(20, 89);
            this.difficulty_min.Name = "difficulty_min";
            this.difficulty_min.Size = new System.Drawing.Size(19, 13);
            this.difficulty_min.TabIndex = 2;
            this.difficulty_min.Text = "10";
            this.difficulty_min.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // difficulty_max
            // 
            this.difficulty_max.AutoSize = true;
            this.difficulty_max.Location = new System.Drawing.Point(289, 89);
            this.difficulty_max.Name = "difficulty_max";
            this.difficulty_max.Size = new System.Drawing.Size(25, 13);
            this.difficulty_max.TabIndex = 3;
            this.difficulty_max.Text = "232";
            // 
            // difficulty_start
            // 
            this.difficulty_start.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.difficulty_start.Location = new System.Drawing.Point(129, 102);
            this.difficulty_start.Name = "difficulty_start";
            this.difficulty_start.Size = new System.Drawing.Size(76, 23);
            this.difficulty_start.TabIndex = 4;
            this.difficulty_start.Text = "Start!";
            this.difficulty_start.UseVisualStyleBackColor = true;
            // 
            // difficulty_value
            // 
            this.difficulty_value.AutoSize = true;
            this.difficulty_value.Location = new System.Drawing.Point(158, 49);
            this.difficulty_value.Name = "difficulty_value";
            this.difficulty_value.Size = new System.Drawing.Size(19, 13);
            this.difficulty_value.TabIndex = 5;
            this.difficulty_value.Text = "40";
            this.difficulty_value.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DifficultyWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 148);
            this.Controls.Add(this.difficulty_value);
            this.Controls.Add(this.difficulty_start);
            this.Controls.Add(this.difficulty_max);
            this.Controls.Add(this.difficulty_min);
            this.Controls.Add(this.difficulty_scale);
            this.Controls.Add(this.difficulty_info);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "DifficultyWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Minesweeper - Aleks Angelov";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.difficulty_window_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.difficulty_scale)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label difficulty_info;
        private System.Windows.Forms.Label difficulty_min;
        private System.Windows.Forms.Label difficulty_max;
        private System.Windows.Forms.Button difficulty_start;
        private System.Windows.Forms.Label difficulty_value;
        private System.Windows.Forms.TrackBar difficulty_scale;
    }
}