namespace WindowsFormsApp_Probaviszga2019
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
            this.button_save = new System.Windows.Forms.Button();
            this.button_right = new System.Windows.Forms.Button();
            this.button_left = new System.Windows.Forms.Button();
            this.picturebox_gepterem = new System.Windows.Forms.PictureBox();
            this.panel_pont = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox_gepterem)).BeginInit();
            this.SuspendLayout();
            // 
            // button_save
            // 
            this.button_save.BackgroundImage = global::WindowsFormsApp_Probaviszga2019.Properties.Resources.ment;
            this.button_save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_save.Location = new System.Drawing.Point(119, 250);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(63, 53);
            this.button_save.TabIndex = 3;
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // button_right
            // 
            this.button_right.BackgroundImage = global::WindowsFormsApp_Probaviszga2019.Properties.Resources.jobb;
            this.button_right.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_right.Location = new System.Drawing.Point(222, 114);
            this.button_right.Name = "button_right";
            this.button_right.Size = new System.Drawing.Size(63, 53);
            this.button_right.TabIndex = 2;
            this.button_right.UseVisualStyleBackColor = true;
            this.button_right.Click += new System.EventHandler(this.button_right_Click);
            // 
            // button_left
            // 
            this.button_left.BackgroundImage = global::WindowsFormsApp_Probaviszga2019.Properties.Resources.bal;
            this.button_left.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_left.Location = new System.Drawing.Point(12, 114);
            this.button_left.Name = "button_left";
            this.button_left.Size = new System.Drawing.Size(63, 53);
            this.button_left.TabIndex = 1;
            this.button_left.UseVisualStyleBackColor = true;
            this.button_left.Click += new System.EventHandler(this.button_left_Click);
            // 
            // picturebox_gepterem
            // 
            this.picturebox_gepterem.Location = new System.Drawing.Point(81, 66);
            this.picturebox_gepterem.Name = "picturebox_gepterem";
            this.picturebox_gepterem.Size = new System.Drawing.Size(135, 178);
            this.picturebox_gepterem.TabIndex = 0;
            this.picturebox_gepterem.TabStop = false;
            // 
            // panel_pont
            // 
            this.panel_pont.Location = new System.Drawing.Point(291, 67);
            this.panel_pont.Name = "panel_pont";
            this.panel_pont.Size = new System.Drawing.Size(459, 275);
            this.panel_pont.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 428);
            this.Controls.Add(this.panel_pont);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.button_right);
            this.Controls.Add(this.button_left);
            this.Controls.Add(this.picturebox_gepterem);
            this.Name = "Form1";
            this.Text = "Neumann Janos gépterem";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picturebox_gepterem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picturebox_gepterem;
        private System.Windows.Forms.Button button_left;
        private System.Windows.Forms.Button button_right;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Panel panel_pont;
    }
}

