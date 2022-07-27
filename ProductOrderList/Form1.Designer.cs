namespace ProductOrderList
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
            this.lblBrand = new System.Windows.Forms.Label();
            this.lblCat = new System.Windows.Forms.Label();
            this.lblQ = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.btnEnter = new System.Windows.Forms.Button();
            this.lblDis = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.rdoDell = new System.Windows.Forms.RadioButton();
            this.rdoAsus = new System.Windows.Forms.RadioButton();
            this.rdomsi = new System.Windows.Forms.RadioButton();
            this.rdoLenovo = new System.Windows.Forms.RadioButton();
            this.rdoMac = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lblBrand
            // 
            this.lblBrand.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrand.Location = new System.Drawing.Point(47, 41);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(59, 23);
            this.lblBrand.TabIndex = 0;
            this.lblBrand.Text = "Brand";
            // 
            // lblCat
            // 
            this.lblCat.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCat.Location = new System.Drawing.Point(47, 103);
            this.lblCat.Name = "lblCat";
            this.lblCat.Size = new System.Drawing.Size(69, 18);
            this.lblCat.TabIndex = 1;
            this.lblCat.Text = "Category";
            // 
            // lblQ
            // 
            this.lblQ.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQ.Location = new System.Drawing.Point(245, 103);
            this.lblQ.Name = "lblQ";
            this.lblQ.Size = new System.Drawing.Size(69, 23);
            this.lblQ.TabIndex = 2;
            this.lblQ.Text = "Quantity";
            // 
            // lblAmount
            // 
            this.lblAmount.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(424, 103);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(60, 23);
            this.lblAmount.TabIndex = 3;
            this.lblAmount.Text = "Amount";
            // 
            // txtCategory
            // 
            this.txtCategory.Font = new System.Drawing.Font("Arial", 9F);
            this.txtCategory.Location = new System.Drawing.Point(50, 124);
            this.txtCategory.Multiline = true;
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(173, 31);
            this.txtCategory.TabIndex = 5;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Font = new System.Drawing.Font("Arial", 9F);
            this.txtQuantity.Location = new System.Drawing.Point(239, 124);
            this.txtQuantity.Multiline = true;
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(173, 31);
            this.txtQuantity.TabIndex = 6;
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("Arial", 9F);
            this.txtAmount.Location = new System.Drawing.Point(427, 124);
            this.txtAmount.Multiline = true;
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(173, 31);
            this.txtAmount.TabIndex = 7;
            // 
            // btnEnter
            // 
            this.btnEnter.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnter.Location = new System.Drawing.Point(368, 173);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(113, 36);
            this.btnEnter.TabIndex = 8;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // lblDis
            // 
            this.lblDis.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDis.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDis.Location = new System.Drawing.Point(51, 183);
            this.lblDis.Name = "lblDis";
            this.lblDis.Size = new System.Drawing.Size(293, 170);
            this.lblDis.TabIndex = 9;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(487, 173);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(113, 36);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // rdoDell
            // 
            this.rdoDell.AutoSize = true;
            this.rdoDell.Location = new System.Drawing.Point(138, 41);
            this.rdoDell.Name = "rdoDell";
            this.rdoDell.Size = new System.Drawing.Size(43, 17);
            this.rdoDell.TabIndex = 11;
            this.rdoDell.TabStop = true;
            this.rdoDell.Text = "Dell";
            this.rdoDell.UseVisualStyleBackColor = true;
            // 
            // rdoAsus
            // 
            this.rdoAsus.AutoSize = true;
            this.rdoAsus.Location = new System.Drawing.Point(219, 41);
            this.rdoAsus.Name = "rdoAsus";
            this.rdoAsus.Size = new System.Drawing.Size(48, 17);
            this.rdoAsus.TabIndex = 12;
            this.rdoAsus.TabStop = true;
            this.rdoAsus.Text = "Asus";
            this.rdoAsus.UseVisualStyleBackColor = true;
            // 
            // rdomsi
            // 
            this.rdomsi.AutoSize = true;
            this.rdomsi.Location = new System.Drawing.Point(303, 41);
            this.rdomsi.Name = "rdomsi";
            this.rdomsi.Size = new System.Drawing.Size(41, 17);
            this.rdomsi.TabIndex = 13;
            this.rdomsi.TabStop = true;
            this.rdomsi.Text = "Msi";
            this.rdomsi.UseVisualStyleBackColor = true;
            // 
            // rdoLenovo
            // 
            this.rdoLenovo.AutoSize = true;
            this.rdoLenovo.Location = new System.Drawing.Point(377, 41);
            this.rdoLenovo.Name = "rdoLenovo";
            this.rdoLenovo.Size = new System.Drawing.Size(61, 17);
            this.rdoLenovo.TabIndex = 14;
            this.rdoLenovo.TabStop = true;
            this.rdoLenovo.Text = "Lenovo";
            this.rdoLenovo.UseVisualStyleBackColor = true;
            // 
            // rdoMac
            // 
            this.rdoMac.AutoSize = true;
            this.rdoMac.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.rdoMac.Location = new System.Drawing.Point(477, 41);
            this.rdoMac.Name = "rdoMac";
            this.rdoMac.Size = new System.Drawing.Size(71, 17);
            this.rdoMac.TabIndex = 15;
            this.rdoMac.TabStop = true;
            this.rdoMac.Text = "MacBook";
            this.rdoMac.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 373);
            this.Controls.Add(this.rdoMac);
            this.Controls.Add(this.rdoLenovo);
            this.Controls.Add(this.rdomsi);
            this.Controls.Add(this.rdoAsus);
            this.Controls.Add(this.rdoDell);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblDis);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtCategory);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lblQ);
            this.Controls.Add(this.lblCat);
            this.Controls.Add(this.lblBrand);
            this.Name = "Form1";
            this.Text = "Order List";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Label lblCat;
        private System.Windows.Forms.Label lblQ;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Label lblDis;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.RadioButton rdoDell;
        private System.Windows.Forms.RadioButton rdoAsus;
        private System.Windows.Forms.RadioButton rdomsi;
        private System.Windows.Forms.RadioButton rdoLenovo;
        private System.Windows.Forms.RadioButton rdoMac;
    }
}

