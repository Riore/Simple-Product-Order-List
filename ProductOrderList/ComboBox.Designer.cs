namespace ProductOrderList
{
    partial class ComboBox
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblD = new System.Windows.Forms.Label();
            this.btnEnter = new System.Windows.Forms.Button();
            this.txtbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "MacBook",
            "Asus",
            "Dell",
            "Lenovo",
            "Hp"});
            this.comboBox1.Location = new System.Drawing.Point(127, 54);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(117, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // lblD
            // 
            this.lblD.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblD.Location = new System.Drawing.Point(250, 54);
            this.lblD.Name = "lblD";
            this.lblD.Size = new System.Drawing.Size(173, 119);
            this.lblD.TabIndex = 1;
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(127, 160);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(90, 33);
            this.btnEnter.TabIndex = 2;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // txtbox
            // 
            this.txtbox.Location = new System.Drawing.Point(127, 105);
            this.txtbox.Multiline = true;
            this.txtbox.Name = "txtbox";
            this.txtbox.Size = new System.Drawing.Size(117, 33);
            this.txtbox.TabIndex = 3;
            // 
            // ComboBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 243);
            this.Controls.Add(this.txtbox);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.lblD);
            this.Controls.Add(this.comboBox1);
            this.Name = "ComboBox";
            this.Text = "ComboBox";
            this.Load += new System.EventHandler(this.ComboBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblD;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.TextBox txtbox;
    }
}