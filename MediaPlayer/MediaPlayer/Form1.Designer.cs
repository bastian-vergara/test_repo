namespace MediaPlayer
{
    partial class MainPlayer
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPlayer));
            this.Play = new System.Windows.Forms.Button();
            this.Stop = new System.Windows.Forms.Button();
            this.Pause = new System.Windows.Forms.Button();
            this.SongTitleTag = new System.Windows.Forms.Label();
            this.SongAlbumTag = new System.Windows.Forms.Label();
            this.SongArtistTag = new System.Windows.Forms.Label();
            this.PictureShow = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.OpenFile = new System.Windows.Forms.Button();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.TimeElapsed = new System.Windows.Forms.Label();
            this.TimeTotal = new System.Windows.Forms.Label();
            this.Artista = new System.Windows.Forms.Label();
            this.Album = new System.Windows.Forms.Label();
            this.Titulo = new System.Windows.Forms.Label();
            this.Previous = new System.Windows.Forms.Button();
            this.Next = new System.Windows.Forms.Button();
            this.AddFiletoPL = new System.Windows.Forms.Button();
            this.BandPicture = new System.Windows.Forms.PictureBox();
            this.LyricsBox = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureShow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BandPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // Play
            // 
            this.Play.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Play.BackgroundImage")));
            this.Play.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Play.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Play.ForeColor = System.Drawing.SystemColors.Control;
            this.Play.Location = new System.Drawing.Point(185, 317);
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(70, 70);
            this.Play.TabIndex = 0;
            this.Play.UseVisualStyleBackColor = true;
            this.Play.Click += new System.EventHandler(this.Play_Click);
            // 
            // Stop
            // 
            this.Stop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Stop.BackgroundImage")));
            this.Stop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Stop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Stop.ForeColor = System.Drawing.SystemColors.Control;
            this.Stop.Location = new System.Drawing.Point(261, 334);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(50, 50);
            this.Stop.TabIndex = 1;
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // Pause
            // 
            this.Pause.BackColor = System.Drawing.SystemColors.Control;
            this.Pause.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Pause.BackgroundImage")));
            this.Pause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Pause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Pause.ForeColor = System.Drawing.SystemColors.Control;
            this.Pause.Location = new System.Drawing.Point(129, 337);
            this.Pause.Name = "Pause";
            this.Pause.Size = new System.Drawing.Size(50, 50);
            this.Pause.TabIndex = 2;
            this.Pause.UseVisualStyleBackColor = false;
            this.Pause.Click += new System.EventHandler(this.Pause_Click);
            // 
            // SongTitleTag
            // 
            this.SongTitleTag.AutoSize = true;
            this.SongTitleTag.Location = new System.Drawing.Point(193, 289);
            this.SongTitleTag.Name = "SongTitleTag";
            this.SongTitleTag.Size = new System.Drawing.Size(71, 13);
            this.SongTitleTag.TabIndex = 3;
            this.SongTitleTag.Text = "SongTitleTag";
            // 
            // SongAlbumTag
            // 
            this.SongAlbumTag.AutoSize = true;
            this.SongAlbumTag.Location = new System.Drawing.Point(193, 266);
            this.SongAlbumTag.Name = "SongAlbumTag";
            this.SongAlbumTag.Size = new System.Drawing.Size(80, 13);
            this.SongAlbumTag.TabIndex = 4;
            this.SongAlbumTag.Text = "SongAlbumTag";
            // 
            // SongArtistTag
            // 
            this.SongArtistTag.AutoSize = true;
            this.SongArtistTag.Location = new System.Drawing.Point(193, 244);
            this.SongArtistTag.Name = "SongArtistTag";
            this.SongArtistTag.Size = new System.Drawing.Size(74, 13);
            this.SongArtistTag.TabIndex = 5;
            this.SongArtistTag.Text = "SongArtistTag";
            // 
            // PictureShow
            // 
            this.PictureShow.Location = new System.Drawing.Point(110, 12);
            this.PictureShow.Name = "PictureShow";
            this.PictureShow.Size = new System.Drawing.Size(220, 220);
            this.PictureShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureShow.TabIndex = 6;
            this.PictureShow.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // OpenFile
            // 
            this.OpenFile.Location = new System.Drawing.Point(5, 12);
            this.OpenFile.Name = "OpenFile";
            this.OpenFile.Size = new System.Drawing.Size(75, 23);
            this.OpenFile.TabIndex = 7;
            this.OpenFile.Text = "OpenFile";
            this.OpenFile.UseVisualStyleBackColor = true;
            this.OpenFile.Click += new System.EventHandler(this.OpenFile_Click);
            // 
            // Timer
            // 
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(12, 390);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(413, 20);
            this.progressBar.TabIndex = 9;
            // 
            // TimeElapsed
            // 
            this.TimeElapsed.AutoSize = true;
            this.TimeElapsed.Location = new System.Drawing.Point(12, 374);
            this.TimeElapsed.Name = "TimeElapsed";
            this.TimeElapsed.Size = new System.Drawing.Size(68, 13);
            this.TimeElapsed.TabIndex = 10;
            this.TimeElapsed.Text = "TimeElapsed";
            // 
            // TimeTotal
            // 
            this.TimeTotal.AutoSize = true;
            this.TimeTotal.Location = new System.Drawing.Point(394, 374);
            this.TimeTotal.Name = "TimeTotal";
            this.TimeTotal.Size = new System.Drawing.Size(54, 13);
            this.TimeTotal.TabIndex = 11;
            this.TimeTotal.Text = "TimeTotal";
            // 
            // Artista
            // 
            this.Artista.AutoSize = true;
            this.Artista.Location = new System.Drawing.Point(155, 244);
            this.Artista.Name = "Artista";
            this.Artista.Size = new System.Drawing.Size(39, 13);
            this.Artista.TabIndex = 12;
            this.Artista.Text = "Artista:";
            // 
            // Album
            // 
            this.Album.AutoSize = true;
            this.Album.Location = new System.Drawing.Point(155, 266);
            this.Album.Name = "Album";
            this.Album.Size = new System.Drawing.Size(39, 13);
            this.Album.TabIndex = 13;
            this.Album.Text = "Album:";
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.Location = new System.Drawing.Point(155, 289);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(36, 13);
            this.Titulo.TabIndex = 14;
            this.Titulo.Text = "Titulo:";
            // 
            // Previous
            // 
            this.Previous.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Previous.BackgroundImage")));
            this.Previous.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Previous.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Previous.ForeColor = System.Drawing.SystemColors.Control;
            this.Previous.Location = new System.Drawing.Point(90, 354);
            this.Previous.Name = "Previous";
            this.Previous.Size = new System.Drawing.Size(33, 33);
            this.Previous.TabIndex = 16;
            this.Previous.UseVisualStyleBackColor = true;
            this.Previous.Click += new System.EventHandler(this.Previous_Click);
            // 
            // Next
            // 
            this.Next.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Next.BackgroundImage")));
            this.Next.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Next.ForeColor = System.Drawing.SystemColors.Control;
            this.Next.Location = new System.Drawing.Point(317, 351);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(33, 33);
            this.Next.TabIndex = 15;
            this.Next.UseVisualStyleBackColor = true;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // AddFiletoPL
            // 
            this.AddFiletoPL.Location = new System.Drawing.Point(5, 42);
            this.AddFiletoPL.Name = "AddFiletoPL";
            this.AddFiletoPL.Size = new System.Drawing.Size(75, 23);
            this.AddFiletoPL.TabIndex = 17;
            this.AddFiletoPL.Text = "AddFiletoPL";
            this.AddFiletoPL.UseVisualStyleBackColor = true;
            this.AddFiletoPL.Click += new System.EventHandler(this.AddFiletoPL_Click);
            // 
            // BandPicture
            // 
            this.BandPicture.Location = new System.Drawing.Point(336, 13);
            this.BandPicture.Name = "BandPicture";
            this.BandPicture.Size = new System.Drawing.Size(157, 134);
            this.BandPicture.TabIndex = 18;
            this.BandPicture.TabStop = false;
            // 
            // LyricsBox
            // 
            this.LyricsBox.Location = new System.Drawing.Point(336, 13);
            this.LyricsBox.Name = "LyricsBox";
            this.LyricsBox.Size = new System.Drawing.Size(336, 219);
            this.LyricsBox.TabIndex = 19;
            this.LyricsBox.Text = "";
            // 
            // MainPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 417);
            this.Controls.Add(this.LyricsBox);
            this.Controls.Add(this.BandPicture);
            this.Controls.Add(this.AddFiletoPL);
            this.Controls.Add(this.Previous);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.Titulo);
            this.Controls.Add(this.Album);
            this.Controls.Add(this.Artista);
            this.Controls.Add(this.TimeTotal);
            this.Controls.Add(this.TimeElapsed);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.OpenFile);
            this.Controls.Add(this.PictureShow);
            this.Controls.Add(this.SongArtistTag);
            this.Controls.Add(this.SongAlbumTag);
            this.Controls.Add(this.SongTitleTag);
            this.Controls.Add(this.Pause);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.Play);
            this.Name = "MainPlayer";
            this.Text = "MainPlayer";
            this.Load += new System.EventHandler(this.MainPlayer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureShow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BandPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Play;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.Button Pause;
        private System.Windows.Forms.Label SongTitleTag;
        private System.Windows.Forms.Label SongAlbumTag;
        private System.Windows.Forms.Label SongArtistTag;
        private System.Windows.Forms.PictureBox PictureShow;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button OpenFile;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label TimeElapsed;
        private System.Windows.Forms.Label TimeTotal;
        private System.Windows.Forms.Label Artista;
        private System.Windows.Forms.Label Album;
        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.Button Previous;
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.Button AddFiletoPL;
        private System.Windows.Forms.PictureBox BandPicture;
        private System.Windows.Forms.RichTextBox LyricsBox;
    }
}

