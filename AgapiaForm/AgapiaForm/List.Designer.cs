
namespace AgapiaForm
{
    partial class List
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lv_product = new System.Windows.Forms.ListView();
            this.ch_name = new System.Windows.Forms.ColumnHeader();
            this.ch_price = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // lv_product
            // 
            this.lv_product.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ch_name,
            this.ch_price});
            this.lv_product.HideSelection = false;
            this.lv_product.Location = new System.Drawing.Point(177, 101);
            this.lv_product.MultiSelect = false;
            this.lv_product.Name = "lv_product";
            this.lv_product.Size = new System.Drawing.Size(407, 196);
            this.lv_product.TabIndex = 0;
            this.lv_product.UseCompatibleStateImageBehavior = false;
            this.lv_product.View = System.Windows.Forms.View.Details;
            // 
            // ch_name
            // 
            this.ch_name.Text = "Produs";
            this.ch_name.Width = 200;
            // 
            // ch_price
            // 
            this.ch_price.Text = "Pret";
            this.ch_price.Width = 200;
            // 
            // List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lv_product);
            this.Name = "List";
            this.Size = new System.Drawing.Size(752, 413);
            this.Load += new System.EventHandler(this.List_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lv_product;
        private System.Windows.Forms.ColumnHeader ch_name;
        private System.Windows.Forms.ColumnHeader ch_price;
    }
}
