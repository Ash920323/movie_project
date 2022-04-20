using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicLibrary;



namespace personal_project_app.UserControls
{
    public partial class ViewMovieUC : UserControl
    {
        private FilmManager FilmManager;
        public UserManager userManager;
        private iUser iuser;
        public UserClass CurrentUser { get; set; }
        public Film CurrentFilm { get { return CurrentFilm; } set {; } }
        public ViewMovieUC()
        {
            InitializeComponent();
            ShowInfo();
        }

        private void ShowInfo()
        {
            userManager = new UserManager(iuser);
            lbTitle.Text = CurrentFilm.Title.ToString();
            lbYear.Text = $"Year : {CurrentFilm.Year}";
            lbInfo.Text = $"Info : {CurrentFilm.Info}";
            lbRateNum.Text = Convert.ToString(CurrentFilm.Rate);
            
            foreach (Rate r in FilmManager.GetAllReviews())
            {
                if (r.Film == CurrentFilm)
                {
                    listBoxReviews.Text += $"{CurrentFilm.Title} is rated {r.Rating} by {r.User.Username} and they think {r.Comment}";
                }
            }
        }

        private void btnSubmitReview_Click(object sender, EventArgs e)
        {
            UpdateReview();
        }

        private void UpdateReview()
        {
            string comment = tbxComment.Text;
            int rating = (int)numericUpDown1.Value;
            Rate rate = new Rate(rating, CurrentUser, CurrentFilm, comment);
            FilmManager.UpdateReview(rate);
            if (comment != "")
            {
                listBoxReviews.Text += $"{CurrentFilm.Title} is rated {rating} by {CurrentUser.Username} and they think {comment}";
            }
            listBoxReviews.Text += $"{CurrentFilm.Title} is rated {rating} by {CurrentUser.Username}";
        }
    }
}
