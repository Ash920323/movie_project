namespace personal_project_app.UserControls
{
    partial class ViewMovieUC
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewMovieUC));
            this.MoviePic = new System.Windows.Forms.PictureBox();
            this.lbTitle = new System.Windows.Forms.Label();
            this.lbRate = new System.Windows.Forms.Label();
            this.tbxComment = new System.Windows.Forms.TextBox();
            this.dataManagementBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lbRateNum = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btnSubmitReview = new System.Windows.Forms.Button();
            this.listBoxReviews = new System.Windows.Forms.ListBox();
            this.lbYear = new System.Windows.Forms.Label();
            this.lbInfo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MoviePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataManagementBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // MoviePic
            // 
            this.MoviePic.Image = ((System.Drawing.Image)(resources.GetObject("MoviePic.Image")));
            this.MoviePic.Location = new System.Drawing.Point(13, 16);
            this.MoviePic.Name = "MoviePic";
            this.MoviePic.Size = new System.Drawing.Size(381, 214);
            this.MoviePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MoviePic.TabIndex = 0;
            this.MoviePic.TabStop = false;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Location = new System.Drawing.Point(421, 32);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(38, 20);
            this.lbTitle.TabIndex = 1;
            this.lbTitle.Text = "Title";
            // 
            // lbRate
            // 
            this.lbRate.AutoSize = true;
            this.lbRate.Location = new System.Drawing.Point(30, 269);
            this.lbRate.Name = "lbRate";
            this.lbRate.Size = new System.Drawing.Size(55, 20);
            this.lbRate.TabIndex = 2;
            this.lbRate.Text = "Rating:";
            // 
            // tbxComment
            // 
            this.tbxComment.Location = new System.Drawing.Point(39, 317);
            this.tbxComment.Name = "tbxComment";
            this.tbxComment.PlaceholderText = "Comment...";
            this.tbxComment.Size = new System.Drawing.Size(441, 27);
            this.tbxComment.TabIndex = 3;
            // 
            // lbRateNum
            // 
            this.lbRateNum.AutoSize = true;
            this.lbRateNum.Location = new System.Drawing.Point(599, 195);
            this.lbRateNum.Name = "lbRateNum";
            this.lbRateNum.Size = new System.Drawing.Size(17, 20);
            this.lbRateNum.TabIndex = 5;
            this.lbRateNum.Text = "0";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(136, 267);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(150, 27);
            this.numericUpDown1.TabIndex = 6;
            // 
            // btnSubmitReview
            // 
            this.btnSubmitReview.Location = new System.Drawing.Point(486, 317);
            this.btnSubmitReview.Name = "btnSubmitReview";
            this.btnSubmitReview.Size = new System.Drawing.Size(130, 29);
            this.btnSubmitReview.TabIndex = 7;
            this.btnSubmitReview.Text = "submit review";
            this.btnSubmitReview.UseVisualStyleBackColor = true;
            this.btnSubmitReview.Click += new System.EventHandler(this.btnSubmitReview_Click);
            // 
            // listBoxReviews
            // 
            this.listBoxReviews.FormattingEnabled = true;
            this.listBoxReviews.ItemHeight = 20;
            this.listBoxReviews.Location = new System.Drawing.Point(30, 361);
            this.listBoxReviews.Name = "listBoxReviews";
            this.listBoxReviews.Size = new System.Drawing.Size(592, 104);
            this.listBoxReviews.TabIndex = 8;
            // 
            // lbYear
            // 
            this.lbYear.AutoSize = true;
            this.lbYear.Location = new System.Drawing.Point(423, 80);
            this.lbYear.Name = "lbYear";
            this.lbYear.Size = new System.Drawing.Size(40, 20);
            this.lbYear.TabIndex = 9;
            this.lbYear.Text = "Year:";
            // 
            // lbInfo
            // 
            this.lbInfo.AutoSize = true;
            this.lbInfo.Location = new System.Drawing.Point(427, 139);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(38, 20);
            this.lbInfo.TabIndex = 10;
            this.lbInfo.Text = "Info:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(427, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Rating:";
            // 
            // ViewMovieUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbInfo);
            this.Controls.Add(this.lbYear);
            this.Controls.Add(this.listBoxReviews);
            this.Controls.Add(this.btnSubmitReview);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.lbRateNum);
            this.Controls.Add(this.tbxComment);
            this.Controls.Add(this.lbRate);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.MoviePic);
            this.Name = "ViewMovieUC";
            this.Size = new System.Drawing.Size(654, 484);
            ((System.ComponentModel.ISupportInitialize)(this.MoviePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataManagementBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox MoviePic;
        private Label lbTitle;
        private Label lbRate;
        private TextBox tbxComment;
        private BindingSource dataManagementBindingSource;
        private Label lbRateNum;
        private NumericUpDown numericUpDown1;
        private Button btnSubmitReview;
        private ListBox listBoxReviews;
        private Label lbYear;
        private Label lbInfo;
        private Label label1;
    }
}
