
namespace UserSettings
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
            this.plusTen_btn = new System.Windows.Forms.Button();
            this.Count = new System.Windows.Forms.Label();
            this.Clear_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // plusTen_btn
            // 
            this.plusTen_btn.Location = new System.Drawing.Point(87, 167);
            this.plusTen_btn.Name = "plusTen_btn";
            this.plusTen_btn.Size = new System.Drawing.Size(101, 57);
            this.plusTen_btn.TabIndex = 0;
            this.plusTen_btn.Text = "+10";
            this.plusTen_btn.UseVisualStyleBackColor = true;
            this.plusTen_btn.Click += new System.EventHandler(this.plusTen_btn_Click);
            // 
            // Count
            // 
            this.Count.AutoSize = true;
            this.Count.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Count.Location = new System.Drawing.Point(132, 73);
            this.Count.Name = "Count";
            this.Count.Size = new System.Drawing.Size(0, 32);
            this.Count.TabIndex = 1;
            // 
            // Clear_btn
            // 
            this.Clear_btn.Location = new System.Drawing.Point(194, 167);
            this.Clear_btn.Name = "Clear_btn";
            this.Clear_btn.Size = new System.Drawing.Size(101, 57);
            this.Clear_btn.TabIndex = 2;
            this.Clear_btn.Text = "Clear";
            this.Clear_btn.UseVisualStyleBackColor = true;
            this.Clear_btn.Click += new System.EventHandler(this.Clear_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 279);
            this.Controls.Add(this.Clear_btn);
            this.Controls.Add(this.Count);
            this.Controls.Add(this.plusTen_btn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button plusTen_btn;
        private System.Windows.Forms.Label Count;
        private System.Windows.Forms.Button Clear_btn;
    }
}

