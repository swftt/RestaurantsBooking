namespace RestaurantsBooking
{
    partial class MainMenu
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
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroButton1
            // 
            this.metroButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroButton1.Location = new System.Drawing.Point(264, 133);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(264, 73);
            this.metroButton1.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroButton1.TabIndex = 0;
            this.metroButton1.Text = "Show booked tables";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroButton2.Location = new System.Drawing.Point(264, 264);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(264, 80);
            this.metroButton2.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroButton2.TabIndex = 1;
            this.metroButton2.Text = "Book tables";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 480);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroButton1);
            this.MaximumSize = new System.Drawing.Size(800, 480);
            this.MinimumSize = new System.Drawing.Size(640, 320);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton2;
    }
}