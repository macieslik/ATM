namespace ATM
{
    partial class ATM
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
            this.tbValue = new System.Windows.Forms.TextBox();
            this.lblAB = new System.Windows.Forms.Label();
            this.lbl200 = new System.Windows.Forms.Label();
            this.lbl100 = new System.Windows.Forms.Label();
            this.lbl50 = new System.Windows.Forms.Label();
            this.lbl20 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblETATW = new System.Windows.Forms.Label();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblWithdrawn200 = new System.Windows.Forms.Label();
            this.lblWithdrawn100 = new System.Windows.Forms.Label();
            this.lblWithdrawn50 = new System.Windows.Forms.Label();
            this.lblWithdrawn20 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbValue
            // 
            this.tbValue.Location = new System.Drawing.Point(289, 122);
            this.tbValue.Name = "tbValue";
            this.tbValue.Size = new System.Drawing.Size(100, 20);
            this.tbValue.TabIndex = 0;
            // 
            // lblAB
            // 
            this.lblAB.AutoSize = true;
            this.lblAB.Location = new System.Drawing.Point(96, 53);
            this.lblAB.Name = "lblAB";
            this.lblAB.Size = new System.Drawing.Size(70, 13);
            this.lblAB.TabIndex = 2;
            this.lblAB.Text = "Available bills";
            // 
            // lbl200
            // 
            this.lbl200.AutoSize = true;
            this.lbl200.Location = new System.Drawing.Point(52, 84);
            this.lbl200.Name = "lbl200";
            this.lbl200.Size = new System.Drawing.Size(10, 13);
            this.lbl200.TabIndex = 3;
            this.lbl200.Text = " ";
            // 
            // lbl100
            // 
            this.lbl100.AutoSize = true;
            this.lbl100.Location = new System.Drawing.Point(52, 117);
            this.lbl100.Name = "lbl100";
            this.lbl100.Size = new System.Drawing.Size(10, 13);
            this.lbl100.TabIndex = 4;
            this.lbl100.Text = " ";
            // 
            // lbl50
            // 
            this.lbl50.AutoSize = true;
            this.lbl50.Location = new System.Drawing.Point(52, 154);
            this.lbl50.Name = "lbl50";
            this.lbl50.Size = new System.Drawing.Size(10, 13);
            this.lbl50.TabIndex = 5;
            this.lbl50.Text = " ";
            // 
            // lbl20
            // 
            this.lbl20.AutoSize = true;
            this.lbl20.Location = new System.Drawing.Point(52, 189);
            this.lbl20.Name = "lbl20";
            this.lbl20.Size = new System.Drawing.Size(10, 13);
            this.lbl20.TabIndex = 6;
            this.lbl20.Text = " ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(317, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 7;
            // 
            // lblETATW
            // 
            this.lblETATW.AutoSize = true;
            this.lblETATW.Location = new System.Drawing.Point(268, 96);
            this.lblETATW.Name = "lblETATW";
            this.lblETATW.Size = new System.Drawing.Size(145, 13);
            this.lblETATW.TabIndex = 8;
            this.lblETATW.Text = "Enter the amount to withdraw";
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.Location = new System.Drawing.Point(290, 154);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(99, 36);
            this.btnWithdraw.TabIndex = 9;
            this.btnWithdraw.Text = "Withdraw";
            this.btnWithdraw.UseVisualStyleBackColor = true;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(83, 220);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(99, 36);
            this.btnReset.TabIndex = 10;
            this.btnReset.Text = "Random";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lblWithdrawn200
            // 
            this.lblWithdrawn200.AutoSize = true;
            this.lblWithdrawn200.Location = new System.Drawing.Point(468, 84);
            this.lblWithdrawn200.Name = "lblWithdrawn200";
            this.lblWithdrawn200.Size = new System.Drawing.Size(10, 13);
            this.lblWithdrawn200.TabIndex = 11;
            this.lblWithdrawn200.Text = " ";
            // 
            // lblWithdrawn100
            // 
            this.lblWithdrawn100.AutoSize = true;
            this.lblWithdrawn100.Location = new System.Drawing.Point(468, 117);
            this.lblWithdrawn100.Name = "lblWithdrawn100";
            this.lblWithdrawn100.Size = new System.Drawing.Size(10, 13);
            this.lblWithdrawn100.TabIndex = 12;
            this.lblWithdrawn100.Text = " ";
            // 
            // lblWithdrawn50
            // 
            this.lblWithdrawn50.AutoSize = true;
            this.lblWithdrawn50.Location = new System.Drawing.Point(468, 154);
            this.lblWithdrawn50.Name = "lblWithdrawn50";
            this.lblWithdrawn50.Size = new System.Drawing.Size(10, 13);
            this.lblWithdrawn50.TabIndex = 13;
            this.lblWithdrawn50.Text = " ";
            // 
            // lblWithdrawn20
            // 
            this.lblWithdrawn20.AutoSize = true;
            this.lblWithdrawn20.Location = new System.Drawing.Point(468, 189);
            this.lblWithdrawn20.Name = "lblWithdrawn20";
            this.lblWithdrawn20.Size = new System.Drawing.Size(10, 13);
            this.lblWithdrawn20.TabIndex = 14;
            this.lblWithdrawn20.Text = " ";
            // 
            // ATM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 318);
            this.Controls.Add(this.lblWithdrawn20);
            this.Controls.Add(this.lblWithdrawn50);
            this.Controls.Add(this.lblWithdrawn100);
            this.Controls.Add(this.lblWithdrawn200);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnWithdraw);
            this.Controls.Add(this.lblETATW);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbl20);
            this.Controls.Add(this.lbl50);
            this.Controls.Add(this.lbl100);
            this.Controls.Add(this.lbl200);
            this.Controls.Add(this.lblAB);
            this.Controls.Add(this.tbValue);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ATM";
            this.Text = "ATM";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbValue;
        private System.Windows.Forms.Label lblAB;
        private System.Windows.Forms.Label lbl200;
        private System.Windows.Forms.Label lbl100;
        private System.Windows.Forms.Label lbl50;
        private System.Windows.Forms.Label lbl20;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblETATW;
        private System.Windows.Forms.Button btnWithdraw;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lblWithdrawn20;
        private System.Windows.Forms.Label lblWithdrawn50;
        private System.Windows.Forms.Label lblWithdrawn100;
        private System.Windows.Forms.Label lblWithdrawn200;
    }
}

