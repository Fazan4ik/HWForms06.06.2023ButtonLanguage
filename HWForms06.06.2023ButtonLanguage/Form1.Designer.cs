namespace HWForms06._06._2023ButtonLanguage
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            buttonUA = new Button();
            buttonENG = new Button();
            buttonGER = new Button();
            SuspendLayout();
            // 
            // buttonUA
            // 
            buttonUA.Image = Properties.Resources.ukraine_flag_icon;
            buttonUA.Location = new Point(150, 133);
            buttonUA.Name = "buttonUA";
            buttonUA.Size = new Size(57, 53);
            buttonUA.TabIndex = 1;
            buttonUA.Text = "UA";
            buttonUA.UseVisualStyleBackColor = true;
            buttonUA.Click += buttonUA_Click;
            // 
            // buttonENG
            // 
            buttonENG.Image = (Image)resources.GetObject("buttonENG.Image");
            buttonENG.Location = new Point(213, 133);
            buttonENG.Name = "buttonENG";
            buttonENG.Size = new Size(57, 53);
            buttonENG.TabIndex = 2;
            buttonENG.Text = "ENG";
            buttonENG.UseVisualStyleBackColor = true;
            buttonENG.Click += buttonENG_Click;
            // 
            // buttonGER
            // 
            buttonGER.Image = Properties.Resources.germany_flag_icon;
            buttonGER.Location = new Point(276, 133);
            buttonGER.Name = "buttonGER";
            buttonGER.Size = new Size(57, 53);
            buttonGER.TabIndex = 3;
            buttonGER.Text = "GER";
            buttonGER.UseVisualStyleBackColor = true;
            buttonGER.Click += buttonGER_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(499, 341);
            Controls.Add(buttonGER);
            Controls.Add(buttonENG);
            Controls.Add(buttonUA);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion
        private Button buttonUA;
        private Button buttonENG;
        private Button buttonGER;
    }
}