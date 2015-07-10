using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Collections;
using System.Net;
using System.Web;
using System.Web.Script.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Filmy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.TypeBox.SelectedItem = "movie";
            PlotBox.SelectedItem = "short";
            TRatingBox.SelectedItem = "true";
        }

        public static void DisplayDetails(string str, Form1 f1)
        {
            string details = "";
            Dictionary<string, object> dict;

            using (WebClient client = new WebClient())
            {
                try
                {
                    details = client.DownloadString("http://www.omdbapi.com/?t=" + str + "&type=" + f1.TypeBox.SelectedItem.ToString() +"&Season=" + f1.SeasonBox.Text.ToString() +"&Episode=" + f1.EpisodeBox.Text.ToString() +"&tomatoes=" + f1.TRatingBox.SelectedItem.ToString() +"&y=" + f1.YearBox.Text.ToString() +"&plot=" + f1.PlotBox.SelectedItem.ToString() +"&r=json");
                }
                catch (WebException ex)
                {
                    //TextBox1.Text = "" + ex;
                    Console.WriteLine("Sorry! Something went wrong!!" + ex);
                    return;
                }
                JavaScriptSerializer ser = new JavaScriptSerializer();
                dict = ser.Deserialize<Dictionary<string, object>>(details);
                string final = dict["Title"].ToString();
                f1.Title.Text = final;
                f1.pictureBox1.ImageLocation = dict["Poster"].ToString();
                f1.Year.Text = dict["Year"].ToString();
                f1.Genre.Text = dict["Genre"].ToString();
                f1.Actors.Text = dict["Actors"].ToString();
                f1.Plot.Text = dict["Plot"].ToString();
                f1.Director.Text = dict["Director"].ToString();
                f1.Rating.Text = dict["imdbRating"].ToString();
                f1.Awards.Text = dict["Awards"].ToString();
                f1.Tomatoes.Text = dict["tomatoRating"].ToString();
            }
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            DisplayDetails(TitleBox.Text.ToString(), this);
        }

        private void TypeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(TypeBox.SelectedItem.ToString()=="episode")
            {
                SeasonBox.Enabled = true;
                EpisodeBox.Enabled = true;
            }
        }
    }
}
