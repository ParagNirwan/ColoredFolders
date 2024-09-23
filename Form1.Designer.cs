namespace ColoredFolders
{
    partial class ColoredFolders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ColoredFolders));
            this.On = new System.Windows.Forms.RadioButton();
            this.Off = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // On
            // 
            this.On.AutoSize = true;
            this.On.Location = new System.Drawing.Point(35, 52);
            this.On.Name = "On";
            this.On.Size = new System.Drawing.Size(64, 29);
            this.On.TabIndex = 0;
            this.On.Text = "On";
            this.On.UseVisualStyleBackColor = true;
            this.On.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // Off
            // 
            this.Off.AutoSize = true;
            this.Off.Checked = true;
            this.Off.Location = new System.Drawing.Point(35, 87);
            this.Off.Name = "Off";
            this.Off.Size = new System.Drawing.Size(63, 29);
            this.Off.TabIndex = 1;
            this.Off.TabStop = true;
            this.Off.Text = "Off";
            this.Off.UseVisualStyleBackColor = true;
            this.Off.CheckedChanged += new System.EventHandler(this.Off_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Made By Parag Nirwan";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(391, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Contex Menu Option (Right Click on Folder)";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // ColoredFolders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 192);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Off);
            this.Controls.Add(this.On);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ColoredFolders";
            this.Text = "Colored Folders";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton On;
        private System.Windows.Forms.RadioButton Off;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

