namespace WinFormsApp8
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.DataGridView dgvBooks;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.Button btnEditBook;
        private System.Windows.Forms.Button btnSearchBook;
        private System.Windows.Forms.Button btnOrderBook;
        private System.Windows.Forms.Button btnLogin;

        private void InitializeComponent()
        {
            this.dgvBooks = new System.Windows.Forms.DataGridView();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.btnEditBook = new System.Windows.Forms.Button();
            this.btnSearchBook = new System.Windows.Forms.Button();
            this.btnOrderBook = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBooks
            // 
            this.dgvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooks.Location = new System.Drawing.Point(12, 70);
            this.dgvBooks.Name = "dgvBooks";
            this.dgvBooks.Size = new System.Drawing.Size(1300, 368);
            this.dgvBooks.TabIndex = 5;
            // 
            // btnAddBook
            // 
            this.btnAddBook.Location = new System.Drawing.Point(12, 12);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(100, 40);
            this.btnAddBook.TabIndex = 0;
            this.btnAddBook.Text = "Add Book";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // btnEditBook
            // 
            this.btnEditBook.Location = new System.Drawing.Point(130, 12);
            this.btnEditBook.Name = "btnEditBook";
            this.btnEditBook.Size = new System.Drawing.Size(100, 40);
            this.btnEditBook.TabIndex = 1;
            this.btnEditBook.Text = "Edit Book";
            this.btnEditBook.UseVisualStyleBackColor = true;
            this.btnEditBook.Click += new System.EventHandler(this.btnEditBook_Click);
            // 
            // btnSearchBook
            // 
            this.btnSearchBook.Location = new System.Drawing.Point(250, 12);
            this.btnSearchBook.Name = "btnSearchBook";
            this.btnSearchBook.Size = new System.Drawing.Size(100, 40);
            this.btnSearchBook.TabIndex = 2;
            this.btnSearchBook.Text = "Search Book";
            this.btnSearchBook.UseVisualStyleBackColor = true;
            this.btnSearchBook.Click += new System.EventHandler(this.btnSearchBook_Click);
            // 
            // btnOrderBook
            // 
            this.btnOrderBook.Location = new System.Drawing.Point(370, 12);
            this.btnOrderBook.Name = "btnOrderBook";
            this.btnOrderBook.Size = new System.Drawing.Size(100, 40);
            this.btnOrderBook.TabIndex = 3;
            this.btnOrderBook.Text = "Order Book";
            this.btnOrderBook.UseVisualStyleBackColor = true;
            this.btnOrderBook.Click += new System.EventHandler(this.btnOrderBook_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(490, 12);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(100, 40);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(1400, 450);
            this.Controls.Add(this.dgvBooks);

            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnOrderBook);
            this.Controls.Add(this.btnSearchBook);
            this.Controls.Add(this.btnEditBook);
            this.Controls.Add(this.btnAddBook);
            this.Name = "MainForm";
            this.Text = "Library Management";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
