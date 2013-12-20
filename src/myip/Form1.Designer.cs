namespace myip
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.IPLabel = new System.Windows.Forms.Label();
            this.networkAdapterComboBox = new System.Windows.Forms.ComboBox();
            this.copyButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Network Adapter:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "IP Address:";
            // 
            // IPLabel
            // 
            this.IPLabel.AutoSize = true;
            this.IPLabel.Location = new System.Drawing.Point(126, 106);
            this.IPLabel.Name = "IPLabel";
            this.IPLabel.Size = new System.Drawing.Size(0, 12);
            this.IPLabel.TabIndex = 2;
            // 
            // networkAdapterComboBox
            // 
            this.networkAdapterComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.networkAdapterComboBox.FormattingEnabled = true;
            this.networkAdapterComboBox.Location = new System.Drawing.Point(128, 58);
            this.networkAdapterComboBox.Name = "networkAdapterComboBox";
            this.networkAdapterComboBox.Size = new System.Drawing.Size(182, 20);
            this.networkAdapterComboBox.TabIndex = 3;
            this.networkAdapterComboBox.SelectedValueChanged += new System.EventHandler(this.networkAdapterComboBox_SelectedValueChanged);
            // 
            // copyButton
            // 
            this.copyButton.Location = new System.Drawing.Point(115, 157);
            this.copyButton.Name = "copyButton";
            this.copyButton.Size = new System.Drawing.Size(75, 23);
            this.copyButton.TabIndex = 4;
            this.copyButton.Text = "&Copy";
            this.copyButton.UseVisualStyleBackColor = true;
            this.copyButton.Click += new System.EventHandler(this.copyButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 212);
            this.Controls.Add(this.copyButton);
            this.Controls.Add(this.networkAdapterComboBox);
            this.Controls.Add(this.IPLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "My IP";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label IPLabel;
        private System.Windows.Forms.ComboBox networkAdapterComboBox;
        private System.Windows.Forms.Button copyButton;
    }
}

