namespace WinFormsApp8
{
    partial class SearchBookForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblAuthors;
        private System.Windows.Forms.TextBox txtAuthors;
        private System.Windows.Forms.Label lblPublisher;
        private System.Windows.Forms.TextBox txtPublisher;
        private System.Windows.Forms.Label lblPageCount;
        private System.Windows.Forms.TextBox txtPageCount;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.TextBox txtGenre;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblLibraryStorage;
        private System.Windows.Forms.TextBox txtLibraryStorage;
        private System.Windows.Forms.Button btnSearch;

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblAuthors = new System.Windows.Forms.Label();
            this.txtAuthors = new System.Windows.Forms.TextBox();
            this.lblPublisher = new System.Windows.Forms.Label();
            this.txtPublisher = new System.Windows.Forms.TextBox();
            this.lblPageCount = new System.Windows.Forms.Label();
            this.txtPageCount = new System.Windows.Forms.TextBox();
            this.lblGenre = new System.Windows.Forms.Label();
            this.txtGenre = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblLibraryStorage = new System.Windows.Forms.Label();
            this.txtLibraryStorage = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(13, 13);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(27, 13);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Title";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(150, 10);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(250, 20);
            this.txtTitle.TabIndex = 1;
            // 
            // lblAuthors
            // 
            this.lblAuthors.AutoSize = true;
            this.lblAuthors.Location = new System.Drawing.Point(13, 50);
            this.lblAuthors.Name = "lblAuthors";
            this.lblAuthors.Size = new System.Drawing.Size(44, 13);
            this.lblAuthors.TabIndex = 2;
            this.lblAuthors.Text = "Authors";
            // 
            // txtAuthors
            // 
            this.txtAuthors.Location = new System.Drawing.Point(150, 47);
            this.txtAuthors.Name = "txtAuthors";
            this.txtAuthors.ReadOnly = true;
            this.txtAuthors.Size = new System.Drawing.Size(250, 20);
            this.txtAuthors.TabIndex = 3;
            // 
            // lblPublisher
            // 
            this.lblPublisher.AutoSize = true;
            this.lblPublisher.Location = new System.Drawing.Point(13, 90);
            this.lblPublisher.Name = "lblPublisher";
            this.lblPublisher.Size = new System.Drawing.Size(53, 13);
            this.lblPublisher.TabIndex = 4;
            this.lblPublisher.Text = "Publisher";
            // 
            // txtPublisher
            // 
            this.txtPublisher.Location = new System.Drawing.Point(150, 87);
            this.txtPublisher.Name = "txtPublisher";
            this.txtPublisher.ReadOnly = true;
            this.txtPublisher.Size = new System.Drawing.Size(250, 20);
            this.txtPublisher.TabIndex = 5;
            // 
            // lblPageCount
            // 
            this.lblPageCount.AutoSize = true;
            this.lblPageCount.Location = new System.Drawing.Point(13, 130);
            this.lblPageCount.Name = "lblPageCount";
            this.lblPageCount.Size = new System.Drawing.Size(65, 13);
            this.lblPageCount.TabIndex = 6;
            this.lblPageCount.Text = "Page Count";
            // 
            // txtPageCount
            // 
            this.txtPageCount.Location = new System.Drawing.Point(150, 127);
            this.txtPageCount.Name = "txtPageCount";
            this.txtPageCount.ReadOnly = true;
            this.txtPageCount.Size = new System.Drawing.Size(250, 20);
            this.txtPageCount.TabIndex = 7;
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Location = new System.Drawing.Point(13, 170);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(39, 13);
            this.lblGenre.TabIndex = 8;
            this.lblGenre.Text = "Genre";
            // 
            // txtGenre
            // 
            this.txtGenre.Location = new System.Drawing.Point(150, 167);
            this.txtGenre.Name = "txtGenre";
            this.txtGenre.ReadOnly = true;
            this.txtGenre.Size = new System.Drawing.Size(250, 20);
            this.txtGenre.TabIndex = 9;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(13, 210);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(31, 13);
            this.lblPrice.TabIndex = 10;
            this.lblPrice.Text = "Price";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(150, 207);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(250, 20);
            this.txtPrice.TabIndex = 11;
            // 
            // lblLibraryStorage
            // 
            this.lblLibraryStorage.AutoSize = true;
            this.lblLibraryStorage.Location = new System.Drawing.Point(13, 250);
            this.lblLibraryStorage.Name = "lblLibraryStorage";
            this.lblLibraryStorage.Size = new System.Drawing.Size(82, 13);
            this.lblLibraryStorage.TabIndex = 12;
            this.lblLibraryStorage.Text = "Library Storage";
            // 
            // txtLibraryStorage
            // 
            this.txtLibraryStorage.Location = new System.Drawing.Point(150, 247);
            this.txtLibraryStorage.Name = "txtLibraryStorage";
            this.txtLibraryStorage.ReadOnly = true;
            this.txtLibraryStorage.Size = new System.Drawing.Size(250, 20);
            this.txtLibraryStorage.TabIndex = 13;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(20, 290);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 40);
            this.btnSearch.TabIndex = 14;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // SearchBookForm
            // 
            this.ClientSize = new System.Drawing.Size(420, 350);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtLibraryStorage);
            this.Controls.Add(this.lblLibraryStorage);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.txtGenre);
            this.Controls.Add(this.lblGenre);
            this.Controls.Add(this.txtPageCount);
            this.Controls.Add(this.lblPageCount);
            this.Controls.Add(this.txtPublisher);
            this.Controls.Add(this.lblPublisher);
            this.Controls.Add(this.txtAuthors);
            this.Controls.Add(this.lblAuthors);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lblTitle);
            this.Name = "SearchBookForm";
            this.Text = "Search Book";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
