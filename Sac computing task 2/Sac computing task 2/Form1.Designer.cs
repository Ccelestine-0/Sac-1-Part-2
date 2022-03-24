namespace Sac_computing_task_2
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
            this.btnCalc = new System.Windows.Forms.Button();
            this.dgvSales = new System.Windows.Forms.DataGridView();
            this.colTextbook = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSeller = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPurchaser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPurchasePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSalePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProfit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblProfitTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSales)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(71, 72);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(112, 34);
            this.btnCalc.TabIndex = 0;
            this.btnCalc.Text = "Calculate Profit";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // dgvSales
            // 
            this.dgvSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTextbook,
            this.colSubject,
            this.colSeller,
            this.colPurchaser,
            this.colPurchasePrice,
            this.colSalePrice,
            this.colProfit});
            this.dgvSales.Location = new System.Drawing.Point(71, 129);
            this.dgvSales.Name = "dgvSales";
            this.dgvSales.RowHeadersWidth = 62;
            this.dgvSales.RowTemplate.Height = 33;
            this.dgvSales.Size = new System.Drawing.Size(1123, 463);
            this.dgvSales.TabIndex = 1;
            // 
            // colTextbook
            // 
            this.colTextbook.HeaderText = "Textbook";
            this.colTextbook.MinimumWidth = 8;
            this.colTextbook.Name = "colTextbook";
            this.colTextbook.Width = 150;
            // 
            // colSubject
            // 
            this.colSubject.HeaderText = "Subject";
            this.colSubject.MinimumWidth = 8;
            this.colSubject.Name = "colSubject";
            this.colSubject.Width = 150;
            // 
            // colSeller
            // 
            this.colSeller.HeaderText = "Seller";
            this.colSeller.MinimumWidth = 8;
            this.colSeller.Name = "colSeller";
            this.colSeller.Width = 150;
            // 
            // colPurchaser
            // 
            this.colPurchaser.HeaderText = "Purchaser";
            this.colPurchaser.MinimumWidth = 8;
            this.colPurchaser.Name = "colPurchaser";
            this.colPurchaser.Width = 150;
            // 
            // colPurchasePrice
            // 
            this.colPurchasePrice.HeaderText = "Purchase Price";
            this.colPurchasePrice.MinimumWidth = 8;
            this.colPurchasePrice.Name = "colPurchasePrice";
            this.colPurchasePrice.Width = 150;
            // 
            // colSalePrice
            // 
            this.colSalePrice.HeaderText = "Sale Price";
            this.colSalePrice.MinimumWidth = 8;
            this.colSalePrice.Name = "colSalePrice";
            this.colSalePrice.Width = 150;
            // 
            // colProfit
            // 
            this.colProfit.HeaderText = "Profit";
            this.colProfit.MinimumWidth = 8;
            this.colProfit.Name = "colProfit";
            this.colProfit.Width = 150;
            // 
            // lblProfitTotal
            // 
            this.lblProfitTotal.AutoSize = true;
            this.lblProfitTotal.Location = new System.Drawing.Point(887, 72);
            this.lblProfitTotal.Name = "lblProfitTotal";
            this.lblProfitTotal.Size = new System.Drawing.Size(0, 25);
            this.lblProfitTotal.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1252, 652);
            this.Controls.Add(this.lblProfitTotal);
            this.Controls.Add(this.dgvSales);
            this.Controls.Add(this.btnCalc);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnCalc;
        private DataGridView dgvSales;
        private DataGridViewTextBoxColumn colTextbook;
        private DataGridViewTextBoxColumn colSubject;
        private DataGridViewTextBoxColumn colSeller;
        private DataGridViewTextBoxColumn colPurchaser;
        private DataGridViewTextBoxColumn colPurchasePrice;
        private DataGridViewTextBoxColumn colSalePrice;
        private DataGridViewTextBoxColumn colProfit;
        private Label lblProfitTotal;
    }
}