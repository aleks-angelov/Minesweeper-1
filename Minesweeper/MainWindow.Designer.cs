namespace Minesweeper
{
    partial class Window
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Window));
            this.minesleft = new System.Windows.Forms.Label();
            this.minesleftvalue = new System.Windows.Forms.Label();
            this.timepast = new System.Windows.Forms.Label();
            this.timepastvalue = new System.Windows.Forms.Label();
            this.field = new System.Windows.Forms.Panel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.newgame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // minesleft
            // 
            this.minesleft.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minesleft.Location = new System.Drawing.Point(9, 9);
            this.minesleft.Margin = new System.Windows.Forms.Padding(0);
            this.minesleft.Name = "minesleft";
            this.minesleft.Size = new System.Drawing.Size(96, 48);
            this.minesleft.TabIndex = 2;
            this.minesleft.Text = "Mines left:";
            this.minesleft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // minesleftvalue
            // 
            this.minesleftvalue.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minesleftvalue.Location = new System.Drawing.Point(9, 57);
            this.minesleftvalue.Margin = new System.Windows.Forms.Padding(0);
            this.minesleftvalue.Name = "minesleftvalue";
            this.minesleftvalue.Size = new System.Drawing.Size(96, 48);
            this.minesleftvalue.TabIndex = 2;
            this.minesleftvalue.Text = "40";
            this.minesleftvalue.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // timepast
            // 
            this.timepast.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timepast.Location = new System.Drawing.Point(432, 9);
            this.timepast.Margin = new System.Windows.Forms.Padding(0);
            this.timepast.Name = "timepast";
            this.timepast.Size = new System.Drawing.Size(96, 48);
            this.timepast.TabIndex = 2;
            this.timepast.Text = "Time past:";
            this.timepast.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timepastvalue
            // 
            this.timepastvalue.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timepastvalue.Location = new System.Drawing.Point(431, 57);
            this.timepastvalue.Margin = new System.Windows.Forms.Padding(0);
            this.timepastvalue.Name = "timepastvalue";
            this.timepastvalue.Size = new System.Drawing.Size(96, 48);
            this.timepastvalue.TabIndex = 2;
            this.timepastvalue.Text = "0";
            this.timepastvalue.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // field
            // 
            this.field.Location = new System.Drawing.Point(12, 119);
            this.field.Name = "field";
            this.field.Size = new System.Drawing.Size(512, 512);
            this.field.TabIndex = 3;
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // newgame
            // 
            this.newgame.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("newgame.BackgroundImage")));
            this.newgame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.newgame.Location = new System.Drawing.Point(225, 12);
            this.newgame.Name = "newgame";
            this.newgame.Size = new System.Drawing.Size(96, 96);
            this.newgame.TabIndex = 1;
            this.newgame.Tag = "";
            this.newgame.UseVisualStyleBackColor = true;
            this.newgame.Click += new System.EventHandler(this.newgame_Click);
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 643);
            this.Controls.Add(this.field);
            this.Controls.Add(this.timepastvalue);
            this.Controls.Add(this.minesleftvalue);
            this.Controls.Add(this.timepast);
            this.Controls.Add(this.minesleft);
            this.Controls.Add(this.newgame);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Window";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Minesweeper - Aleks Angelov";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button newgame;
        private System.Windows.Forms.Label minesleft;
        private System.Windows.Forms.Label minesleftvalue;
        private System.Windows.Forms.Label timepast;
        private System.Windows.Forms.Label timepastvalue;
        private System.Windows.Forms.Panel field;
        private System.Windows.Forms.Timer timer;

    }
}

