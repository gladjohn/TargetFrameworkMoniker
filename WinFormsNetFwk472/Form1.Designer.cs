
namespace WinFormsNetFwk472
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
            this.btnConvertToMiles = new System.Windows.Forms.Button();
            this.lblKms = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.cmbKms = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnConvertToMiles
            // 
            this.btnConvertToMiles.Location = new System.Drawing.Point(97, 136);
            this.btnConvertToMiles.Name = "btnConvertToMiles";
            this.btnConvertToMiles.Size = new System.Drawing.Size(200, 66);
            this.btnConvertToMiles.TabIndex = 0;
            this.btnConvertToMiles.Text = "Convert to Miles";
            this.btnConvertToMiles.UseVisualStyleBackColor = true;
            this.btnConvertToMiles.Click += new System.EventHandler(this.btnConvertToMiles_Click);
            // 
            // lblKms
            // 
            this.lblKms.AutoSize = true;
            this.lblKms.Location = new System.Drawing.Point(70, 41);
            this.lblKms.Name = "lblKms";
            this.lblKms.Size = new System.Drawing.Size(127, 13);
            this.lblKms.TabIndex = 2;
            this.lblKms.Text = "Select a Kilometer value :";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(160, 230);
            this.lblResult.Name = "lblResult";
            this.lblResult.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblResult.Size = new System.Drawing.Size(0, 24);
            this.lblResult.TabIndex = 3;
            // 
            // cmbKms
            // 
            this.cmbKms.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKms.FormattingEnabled = true;
            this.cmbKms.ItemHeight = 13;
            this.cmbKms.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cmbKms.Location = new System.Drawing.Point(97, 70);
            this.cmbKms.Name = "cmbKms";
            this.cmbKms.Size = new System.Drawing.Size(200, 21);
            this.cmbKms.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 294);
            this.Controls.Add(this.cmbKms);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblKms);
            this.Controls.Add(this.btnConvertToMiles);
            this.Name = "Form1";
            this.Text = "Convert from Kms to Miles";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConvertToMiles;
        private System.Windows.Forms.Label lblKms;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.ComboBox cmbKms;
    }
}

