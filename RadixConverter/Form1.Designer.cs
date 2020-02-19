namespace RedixConverter
{
    partial class RadixConverter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RadixConverter));
            this.btnConvert = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblOriginalEncoding = new System.Windows.Forms.Label();
            this.txtOriginalEncoding = new System.Windows.Forms.TextBox();
            this.grpInput = new System.Windows.Forms.GroupBox();
            this.txtInRadix = new System.Windows.Forms.TextBox();
            this.lblOriginalRadix = new System.Windows.Forms.Label();
            this.lblInputNumber = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.grpTarget = new System.Windows.Forms.GroupBox();
            this.lblCutoffdp = new System.Windows.Forms.Label();
            this.txtCutoffdp = new System.Windows.Forms.TextBox();
            this.lblTargetRadix = new System.Windows.Forms.Label();
            this.txtTargetRadix = new System.Windows.Forms.TextBox();
            this.txtTargetEncoding = new System.Windows.Forms.TextBox();
            this.lblTargetEncoding = new System.Windows.Forms.Label();
            this.chkTop = new System.Windows.Forms.CheckBox();
            this.grpInput.SuspendLayout();
            this.grpTarget.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(12, 137);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(211, 31);
            this.btnConvert.TabIndex = 2;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(12, 187);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(428, 20);
            this.txtResult.TabIndex = 4;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(12, 171);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(37, 13);
            this.lblResult.TabIndex = 9;
            this.lblResult.Text = "Result";
            // 
            // lblOriginalEncoding
            // 
            this.lblOriginalEncoding.AutoSize = true;
            this.lblOriginalEncoding.Location = new System.Drawing.Point(6, 55);
            this.lblOriginalEncoding.Name = "lblOriginalEncoding";
            this.lblOriginalEncoding.Size = new System.Drawing.Size(90, 13);
            this.lblOriginalEncoding.TabIndex = 11;
            this.lblOriginalEncoding.Text = "Original Encoding";
            // 
            // txtOriginalEncoding
            // 
            this.txtOriginalEncoding.Location = new System.Drawing.Point(6, 71);
            this.txtOriginalEncoding.Multiline = true;
            this.txtOriginalEncoding.Name = "txtOriginalEncoding";
            this.txtOriginalEncoding.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtOriginalEncoding.Size = new System.Drawing.Size(198, 39);
            this.txtOriginalEncoding.TabIndex = 12;
            this.txtOriginalEncoding.Text = "0123456789ABCDEF";
            this.txtOriginalEncoding.WordWrap = false;
            // 
            // grpInput
            // 
            this.grpInput.Controls.Add(this.txtInRadix);
            this.grpInput.Controls.Add(this.txtOriginalEncoding);
            this.grpInput.Controls.Add(this.lblOriginalRadix);
            this.grpInput.Controls.Add(this.lblOriginalEncoding);
            this.grpInput.Controls.Add(this.lblInputNumber);
            this.grpInput.Controls.Add(this.txtInput);
            this.grpInput.Location = new System.Drawing.Point(12, 12);
            this.grpInput.Name = "grpInput";
            this.grpInput.Size = new System.Drawing.Size(211, 119);
            this.grpInput.TabIndex = 13;
            this.grpInput.TabStop = false;
            this.grpInput.Text = "Input";
            // 
            // txtInRadix
            // 
            this.txtInRadix.Location = new System.Drawing.Point(108, 32);
            this.txtInRadix.Name = "txtInRadix";
            this.txtInRadix.Size = new System.Drawing.Size(96, 20);
            this.txtInRadix.TabIndex = 12;
            this.txtInRadix.Text = "10";
            // 
            // lblOriginalRadix
            // 
            this.lblOriginalRadix.AutoSize = true;
            this.lblOriginalRadix.Location = new System.Drawing.Point(105, 16);
            this.lblOriginalRadix.Name = "lblOriginalRadix";
            this.lblOriginalRadix.Size = new System.Drawing.Size(72, 13);
            this.lblOriginalRadix.TabIndex = 11;
            this.lblOriginalRadix.Text = "Original Radix";
            // 
            // lblInputNumber
            // 
            this.lblInputNumber.AutoSize = true;
            this.lblInputNumber.Location = new System.Drawing.Point(6, 16);
            this.lblInputNumber.Name = "lblInputNumber";
            this.lblInputNumber.Size = new System.Drawing.Size(71, 13);
            this.lblInputNumber.TabIndex = 7;
            this.lblInputNumber.Text = "Input Number";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(6, 32);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(96, 20);
            this.txtInput.TabIndex = 6;
            this.txtInput.Text = "-128.125";
            // 
            // grpTarget
            // 
            this.grpTarget.Controls.Add(this.lblCutoffdp);
            this.grpTarget.Controls.Add(this.txtCutoffdp);
            this.grpTarget.Controls.Add(this.lblTargetRadix);
            this.grpTarget.Controls.Add(this.txtTargetRadix);
            this.grpTarget.Controls.Add(this.txtTargetEncoding);
            this.grpTarget.Controls.Add(this.lblTargetEncoding);
            this.grpTarget.Location = new System.Drawing.Point(229, 12);
            this.grpTarget.Name = "grpTarget";
            this.grpTarget.Size = new System.Drawing.Size(211, 119);
            this.grpTarget.TabIndex = 14;
            this.grpTarget.TabStop = false;
            this.grpTarget.Text = "Target";
            // 
            // lblCutoffdp
            // 
            this.lblCutoffdp.AutoSize = true;
            this.lblCutoffdp.Location = new System.Drawing.Point(6, 16);
            this.lblCutoffdp.Name = "lblCutoffdp";
            this.lblCutoffdp.Size = new System.Drawing.Size(61, 13);
            this.lblCutoffdp.TabIndex = 16;
            this.lblCutoffdp.Text = "Cut-Off d.p.";
            // 
            // txtCutoffdp
            // 
            this.txtCutoffdp.Location = new System.Drawing.Point(6, 32);
            this.txtCutoffdp.Name = "txtCutoffdp";
            this.txtCutoffdp.Size = new System.Drawing.Size(96, 20);
            this.txtCutoffdp.TabIndex = 15;
            this.txtCutoffdp.Text = "10";
            // 
            // lblTargetRadix
            // 
            this.lblTargetRadix.AutoSize = true;
            this.lblTargetRadix.Location = new System.Drawing.Point(105, 16);
            this.lblTargetRadix.Name = "lblTargetRadix";
            this.lblTargetRadix.Size = new System.Drawing.Size(68, 13);
            this.lblTargetRadix.TabIndex = 14;
            this.lblTargetRadix.Text = "Target Radix";
            // 
            // txtTargetRadix
            // 
            this.txtTargetRadix.Location = new System.Drawing.Point(108, 32);
            this.txtTargetRadix.Name = "txtTargetRadix";
            this.txtTargetRadix.Size = new System.Drawing.Size(96, 20);
            this.txtTargetRadix.TabIndex = 13;
            this.txtTargetRadix.Text = "2";
            // 
            // txtTargetEncoding
            // 
            this.txtTargetEncoding.Location = new System.Drawing.Point(6, 71);
            this.txtTargetEncoding.Multiline = true;
            this.txtTargetEncoding.Name = "txtTargetEncoding";
            this.txtTargetEncoding.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtTargetEncoding.Size = new System.Drawing.Size(198, 39);
            this.txtTargetEncoding.TabIndex = 12;
            this.txtTargetEncoding.Text = "0123456789ABCDEF";
            this.txtTargetEncoding.WordWrap = false;
            // 
            // lblTargetEncoding
            // 
            this.lblTargetEncoding.AutoSize = true;
            this.lblTargetEncoding.Location = new System.Drawing.Point(6, 55);
            this.lblTargetEncoding.Name = "lblTargetEncoding";
            this.lblTargetEncoding.Size = new System.Drawing.Size(86, 13);
            this.lblTargetEncoding.TabIndex = 11;
            this.lblTargetEncoding.Text = "Target Encoding";
            // 
            // chkTop
            // 
            this.chkTop.AutoSize = true;
            this.chkTop.Location = new System.Drawing.Point(229, 137);
            this.chkTop.Name = "chkTop";
            this.chkTop.Size = new System.Drawing.Size(68, 17);
            this.chkTop.TabIndex = 15;
            this.chkTop.Text = "TopMost";
            this.chkTop.UseVisualStyleBackColor = true;
            // 
            // RadixConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 216);
            this.Controls.Add(this.chkTop);
            this.Controls.Add(this.grpTarget);
            this.Controls.Add(this.grpInput);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnConvert);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RadixConverter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Radix Converter";
            this.grpInput.ResumeLayout(false);
            this.grpInput.PerformLayout();
            this.grpTarget.ResumeLayout(false);
            this.grpTarget.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblOriginalEncoding;
        private System.Windows.Forms.TextBox txtOriginalEncoding;
        private System.Windows.Forms.GroupBox grpInput;
        private System.Windows.Forms.TextBox txtInRadix;
        private System.Windows.Forms.Label lblOriginalRadix;
        private System.Windows.Forms.Label lblInputNumber;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.GroupBox grpTarget;
        private System.Windows.Forms.Label lblCutoffdp;
        private System.Windows.Forms.TextBox txtCutoffdp;
        private System.Windows.Forms.Label lblTargetRadix;
        private System.Windows.Forms.TextBox txtTargetRadix;
        private System.Windows.Forms.TextBox txtTargetEncoding;
        private System.Windows.Forms.Label lblTargetEncoding;
        private System.Windows.Forms.CheckBox chkTop;
    }
}

