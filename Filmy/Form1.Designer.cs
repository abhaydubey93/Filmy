namespace Filmy
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
            this.TitleLabel = new System.Windows.Forms.Label();
            this.TitleBox = new System.Windows.Forms.TextBox();
            this.YearLabel = new System.Windows.Forms.Label();
            this.YearBox = new System.Windows.Forms.TextBox();
            this.TypeLabel = new System.Windows.Forms.Label();
            this.TypeBox = new System.Windows.Forms.ComboBox();
            this.PlotLabel = new System.Windows.Forms.Label();
            this.PlotBox = new System.Windows.Forms.ComboBox();
            this.TomatoesBox = new System.Windows.Forms.Label();
            this.TRatingBox = new System.Windows.Forms.ComboBox();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TitleLabel2 = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.YearLabel2 = new System.Windows.Forms.Label();
            this.Year = new System.Windows.Forms.Label();
            this.GenreLabel = new System.Windows.Forms.Label();
            this.Genre = new System.Windows.Forms.Label();
            this.ActorsLabel = new System.Windows.Forms.Label();
            this.Actors = new System.Windows.Forms.Label();
            this.PlotLabel2 = new System.Windows.Forms.Label();
            this.Plot = new System.Windows.Forms.RichTextBox();
            this.DirectorLabel = new System.Windows.Forms.Label();
            this.Director = new System.Windows.Forms.Label();
            this.RatingLabel = new System.Windows.Forms.Label();
            this.Rating = new System.Windows.Forms.Label();
            this.AwardsLabel = new System.Windows.Forms.Label();
            this.Awards = new System.Windows.Forms.Label();
            this.TomatoesLabel = new System.Windows.Forms.Label();
            this.Tomatoes = new System.Windows.Forms.Label();
            this.SeasonLabel = new System.Windows.Forms.Label();
            this.SeasonBox = new System.Windows.Forms.TextBox();
            this.EpisodeLabel = new System.Windows.Forms.Label();
            this.EpisodeBox = new System.Windows.Forms.TextBox();
            this.Warning = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(21, 27);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(45, 17);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Title:";
            // 
            // TitleBox
            // 
            this.TitleBox.Location = new System.Drawing.Point(63, 26);
            this.TitleBox.Name = "TitleBox";
            this.TitleBox.Size = new System.Drawing.Size(337, 20);
            this.TitleBox.TabIndex = 1;
            // 
            // YearLabel
            // 
            this.YearLabel.AutoSize = true;
            this.YearLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YearLabel.Location = new System.Drawing.Point(19, 73);
            this.YearLabel.Name = "YearLabel";
            this.YearLabel.Size = new System.Drawing.Size(47, 17);
            this.YearLabel.TabIndex = 2;
            this.YearLabel.Text = "Year:";
            // 
            // YearBox
            // 
            this.YearBox.Location = new System.Drawing.Point(64, 73);
            this.YearBox.Name = "YearBox";
            this.YearBox.Size = new System.Drawing.Size(121, 20);
            this.YearBox.TabIndex = 3;
            // 
            // TypeLabel
            // 
            this.TypeLabel.AutoSize = true;
            this.TypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypeLabel.Location = new System.Drawing.Point(195, 74);
            this.TypeLabel.Name = "TypeLabel";
            this.TypeLabel.Size = new System.Drawing.Size(49, 17);
            this.TypeLabel.TabIndex = 4;
            this.TypeLabel.Text = "Type:";
            // 
            // TypeBox
            // 
            this.TypeBox.FormattingEnabled = true;
            this.TypeBox.Items.AddRange(new object[] {
            "movie",
            "series",
            "episode"});
            this.TypeBox.Location = new System.Drawing.Point(252, 71);
            this.TypeBox.Name = "TypeBox";
            this.TypeBox.Size = new System.Drawing.Size(148, 21);
            this.TypeBox.TabIndex = 5;
            this.TypeBox.SelectedIndexChanged += new System.EventHandler(this.TypeBox_SelectedIndexChanged);
            // 
            // PlotLabel
            // 
            this.PlotLabel.AutoSize = true;
            this.PlotLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlotLabel.Location = new System.Drawing.Point(25, 145);
            this.PlotLabel.Name = "PlotLabel";
            this.PlotLabel.Size = new System.Drawing.Size(41, 17);
            this.PlotLabel.TabIndex = 6;
            this.PlotLabel.Text = "Plot:";
            // 
            // PlotBox
            // 
            this.PlotBox.FormattingEnabled = true;
            this.PlotBox.Items.AddRange(new object[] {
            "short",
            "full"});
            this.PlotBox.Location = new System.Drawing.Point(64, 145);
            this.PlotBox.Name = "PlotBox";
            this.PlotBox.Size = new System.Drawing.Size(121, 21);
            this.PlotBox.TabIndex = 7;
            // 
            // TomatoesBox
            // 
            this.TomatoesBox.AutoSize = true;
            this.TomatoesBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TomatoesBox.Location = new System.Drawing.Point(198, 146);
            this.TomatoesBox.Name = "TomatoesBox";
            this.TomatoesBox.Size = new System.Drawing.Size(136, 17);
            this.TomatoesBox.TabIndex = 8;
            this.TomatoesBox.Text = "Tomatoes Rating:";
            // 
            // TRatingBox
            // 
            this.TRatingBox.FormattingEnabled = true;
            this.TRatingBox.Items.AddRange(new object[] {
            "true",
            "false"});
            this.TRatingBox.Location = new System.Drawing.Point(341, 146);
            this.TRatingBox.Name = "TRatingBox";
            this.TRatingBox.Size = new System.Drawing.Size(59, 21);
            this.TRatingBox.TabIndex = 9;
            // 
            // SubmitButton
            // 
            this.SubmitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitButton.Location = new System.Drawing.Point(169, 175);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(75, 23);
            this.SubmitButton.TabIndex = 10;
            this.SubmitButton.Text = "Search";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(19, 218);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(136, 153);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // TitleLabel2
            // 
            this.TitleLabel2.AutoSize = true;
            this.TitleLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel2.Location = new System.Drawing.Point(170, 229);
            this.TitleLabel2.Name = "TitleLabel2";
            this.TitleLabel2.Size = new System.Drawing.Size(45, 17);
            this.TitleLabel2.TabIndex = 12;
            this.TitleLabel2.Text = "Title:";
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Location = new System.Drawing.Point(221, 232);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(0, 13);
            this.Title.TabIndex = 13;
            // 
            // YearLabel2
            // 
            this.YearLabel2.AutoSize = true;
            this.YearLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YearLabel2.Location = new System.Drawing.Point(169, 258);
            this.YearLabel2.Name = "YearLabel2";
            this.YearLabel2.Size = new System.Drawing.Size(47, 17);
            this.YearLabel2.TabIndex = 14;
            this.YearLabel2.Text = "Year:";
            // 
            // Year
            // 
            this.Year.AutoSize = true;
            this.Year.Location = new System.Drawing.Point(221, 260);
            this.Year.Name = "Year";
            this.Year.Size = new System.Drawing.Size(0, 13);
            this.Year.TabIndex = 15;
            // 
            // GenreLabel
            // 
            this.GenreLabel.AutoSize = true;
            this.GenreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenreLabel.Location = new System.Drawing.Point(159, 285);
            this.GenreLabel.Name = "GenreLabel";
            this.GenreLabel.Size = new System.Drawing.Size(58, 17);
            this.GenreLabel.TabIndex = 16;
            this.GenreLabel.Text = "Genre:";
            // 
            // Genre
            // 
            this.Genre.AutoSize = true;
            this.Genre.Location = new System.Drawing.Point(223, 289);
            this.Genre.Name = "Genre";
            this.Genre.Size = new System.Drawing.Size(0, 13);
            this.Genre.TabIndex = 17;
            // 
            // ActorsLabel
            // 
            this.ActorsLabel.AutoSize = true;
            this.ActorsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActorsLabel.Location = new System.Drawing.Point(159, 313);
            this.ActorsLabel.Name = "ActorsLabel";
            this.ActorsLabel.Size = new System.Drawing.Size(59, 17);
            this.ActorsLabel.TabIndex = 18;
            this.ActorsLabel.Text = "Actors:";
            // 
            // Actors
            // 
            this.Actors.AutoSize = true;
            this.Actors.Location = new System.Drawing.Point(224, 316);
            this.Actors.Name = "Actors";
            this.Actors.Size = new System.Drawing.Size(0, 13);
            this.Actors.TabIndex = 19;
            // 
            // PlotLabel2
            // 
            this.PlotLabel2.AutoSize = true;
            this.PlotLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlotLabel2.Location = new System.Drawing.Point(175, 339);
            this.PlotLabel2.Name = "PlotLabel2";
            this.PlotLabel2.Size = new System.Drawing.Size(41, 17);
            this.PlotLabel2.TabIndex = 20;
            this.PlotLabel2.Text = "Plot:";
            // 
            // Plot
            // 
            this.Plot.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Plot.Location = new System.Drawing.Point(223, 339);
            this.Plot.Name = "Plot";
            this.Plot.ReadOnly = true;
            this.Plot.Size = new System.Drawing.Size(212, 96);
            this.Plot.TabIndex = 21;
            this.Plot.Text = "";
            // 
            // DirectorLabel
            // 
            this.DirectorLabel.AutoSize = true;
            this.DirectorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DirectorLabel.Location = new System.Drawing.Point(146, 449);
            this.DirectorLabel.Name = "DirectorLabel";
            this.DirectorLabel.Size = new System.Drawing.Size(71, 17);
            this.DirectorLabel.TabIndex = 22;
            this.DirectorLabel.Text = "Director:";
            // 
            // Director
            // 
            this.Director.AutoSize = true;
            this.Director.Location = new System.Drawing.Point(223, 453);
            this.Director.Name = "Director";
            this.Director.Size = new System.Drawing.Size(0, 13);
            this.Director.TabIndex = 23;
            // 
            // RatingLabel
            // 
            this.RatingLabel.AutoSize = true;
            this.RatingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RatingLabel.Location = new System.Drawing.Point(117, 480);
            this.RatingLabel.Name = "RatingLabel";
            this.RatingLabel.Size = new System.Drawing.Size(102, 17);
            this.RatingLabel.TabIndex = 24;
            this.RatingLabel.Text = "IMDB Rating:";
            // 
            // Rating
            // 
            this.Rating.AutoSize = true;
            this.Rating.Location = new System.Drawing.Point(223, 483);
            this.Rating.Name = "Rating";
            this.Rating.Size = new System.Drawing.Size(0, 13);
            this.Rating.TabIndex = 25;
            // 
            // AwardsLabel
            // 
            this.AwardsLabel.AutoSize = true;
            this.AwardsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AwardsLabel.Location = new System.Drawing.Point(153, 509);
            this.AwardsLabel.Name = "AwardsLabel";
            this.AwardsLabel.Size = new System.Drawing.Size(65, 17);
            this.AwardsLabel.TabIndex = 26;
            this.AwardsLabel.Text = "Awards:";
            // 
            // Awards
            // 
            this.Awards.AutoSize = true;
            this.Awards.Location = new System.Drawing.Point(220, 514);
            this.Awards.Name = "Awards";
            this.Awards.Size = new System.Drawing.Size(0, 13);
            this.Awards.TabIndex = 27;
            // 
            // TomatoesLabel
            // 
            this.TomatoesLabel.AutoSize = true;
            this.TomatoesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TomatoesLabel.Location = new System.Drawing.Point(79, 536);
            this.TomatoesLabel.Name = "TomatoesLabel";
            this.TomatoesLabel.Size = new System.Drawing.Size(136, 17);
            this.TomatoesLabel.TabIndex = 28;
            this.TomatoesLabel.Text = "Tomatoes Rating:";
            // 
            // Tomatoes
            // 
            this.Tomatoes.AutoSize = true;
            this.Tomatoes.Location = new System.Drawing.Point(223, 540);
            this.Tomatoes.Name = "Tomatoes";
            this.Tomatoes.Size = new System.Drawing.Size(0, 13);
            this.Tomatoes.TabIndex = 29;
            // 
            // SeasonLabel
            // 
            this.SeasonLabel.AutoSize = true;
            this.SeasonLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SeasonLabel.Location = new System.Drawing.Point(-1, 112);
            this.SeasonLabel.Name = "SeasonLabel";
            this.SeasonLabel.Size = new System.Drawing.Size(67, 17);
            this.SeasonLabel.TabIndex = 30;
            this.SeasonLabel.Text = "Season:";
            // 
            // SeasonBox
            // 
            this.SeasonBox.Enabled = false;
            this.SeasonBox.Location = new System.Drawing.Point(64, 112);
            this.SeasonBox.Name = "SeasonBox";
            this.SeasonBox.Size = new System.Drawing.Size(121, 20);
            this.SeasonBox.TabIndex = 31;
            // 
            // EpisodeLabel
            // 
            this.EpisodeLabel.AutoSize = true;
            this.EpisodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EpisodeLabel.Location = new System.Drawing.Point(195, 115);
            this.EpisodeLabel.Name = "EpisodeLabel";
            this.EpisodeLabel.Size = new System.Drawing.Size(71, 17);
            this.EpisodeLabel.TabIndex = 32;
            this.EpisodeLabel.Text = "Episode:";
            // 
            // EpisodeBox
            // 
            this.EpisodeBox.Enabled = false;
            this.EpisodeBox.Location = new System.Drawing.Point(273, 111);
            this.EpisodeBox.Name = "EpisodeBox";
            this.EpisodeBox.Size = new System.Drawing.Size(127, 20);
            this.EpisodeBox.TabIndex = 33;
            // 
            // Warning
            // 
            this.Warning.AutoSize = true;
            this.Warning.Location = new System.Drawing.Point(146, 10);
            this.Warning.Name = "Warning";
            this.Warning.Size = new System.Drawing.Size(125, 13);
            this.Warning.TabIndex = 34;
            this.Warning.Text = "*Leave as it is if not sure.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(481, 486);
            this.Controls.Add(this.Warning);
            this.Controls.Add(this.EpisodeBox);
            this.Controls.Add(this.EpisodeLabel);
            this.Controls.Add(this.SeasonBox);
            this.Controls.Add(this.SeasonLabel);
            this.Controls.Add(this.Tomatoes);
            this.Controls.Add(this.TomatoesLabel);
            this.Controls.Add(this.Awards);
            this.Controls.Add(this.AwardsLabel);
            this.Controls.Add(this.Rating);
            this.Controls.Add(this.RatingLabel);
            this.Controls.Add(this.Director);
            this.Controls.Add(this.DirectorLabel);
            this.Controls.Add(this.Plot);
            this.Controls.Add(this.PlotLabel2);
            this.Controls.Add(this.Actors);
            this.Controls.Add(this.ActorsLabel);
            this.Controls.Add(this.Genre);
            this.Controls.Add(this.GenreLabel);
            this.Controls.Add(this.Year);
            this.Controls.Add(this.YearLabel2);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.TitleLabel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.TRatingBox);
            this.Controls.Add(this.TomatoesBox);
            this.Controls.Add(this.PlotBox);
            this.Controls.Add(this.PlotLabel);
            this.Controls.Add(this.TypeBox);
            this.Controls.Add(this.TypeLabel);
            this.Controls.Add(this.YearBox);
            this.Controls.Add(this.YearLabel);
            this.Controls.Add(this.TitleBox);
            this.Controls.Add(this.TitleLabel);
            this.Name = "Form1";
            this.Text = "Filmy";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.TextBox TitleBox;
        private System.Windows.Forms.Label YearLabel;
        private System.Windows.Forms.TextBox YearBox;
        private System.Windows.Forms.Label TypeLabel;
        private System.Windows.Forms.ComboBox TypeBox;
        private System.Windows.Forms.Label PlotLabel;
        private System.Windows.Forms.ComboBox PlotBox;
        private System.Windows.Forms.Label TomatoesBox;
        private System.Windows.Forms.ComboBox TRatingBox;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label TitleLabel2;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label YearLabel2;
        private System.Windows.Forms.Label Year;
        private System.Windows.Forms.Label GenreLabel;
        private System.Windows.Forms.Label Genre;
        private System.Windows.Forms.Label ActorsLabel;
        private System.Windows.Forms.Label Actors;
        private System.Windows.Forms.Label PlotLabel2;
        private System.Windows.Forms.RichTextBox Plot;
        private System.Windows.Forms.Label DirectorLabel;
        private System.Windows.Forms.Label Director;
        private System.Windows.Forms.Label RatingLabel;
        private System.Windows.Forms.Label Rating;
        private System.Windows.Forms.Label AwardsLabel;
        private System.Windows.Forms.Label Awards;
        private System.Windows.Forms.Label TomatoesLabel;
        private System.Windows.Forms.Label Tomatoes;
        private System.Windows.Forms.Label SeasonLabel;
        private System.Windows.Forms.TextBox SeasonBox;
        private System.Windows.Forms.Label EpisodeLabel;
        private System.Windows.Forms.TextBox EpisodeBox;
        private System.Windows.Forms.Label Warning;
    }
}

