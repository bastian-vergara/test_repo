using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace MediaPlayer
{
    public partial class MainPlayer : Form
    {
        WindowsMediaPlayer song = new WindowsMediaPlayer();
        WindowsMediaPlayer pl = new WindowsMediaPlayer();

        public MainPlayer()
        {
            InitializeComponent();

        }

        public void MainPlayer_Load(object sender, EventArgs e)
        {
            SongAlbumTag.Visible = false;
            SongArtistTag.Visible = false;
            SongTitleTag.Visible = false;
            TimeElapsed.Visible = false;
            TimeTotal.Visible = false;
            PictureShow.BorderStyle = BorderStyle.Fixed3D;
            
        }

        private void OpenFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            
            song.URL = openFileDialog1.FileName;
            TagLib.File tags = TagLib.File.Create(song.URL);
            
            
            SongTitleTag.Text = tags.Tag.Title;
            SongArtistTag.Text = tags.Tag.FirstPerformer;
            SongAlbumTag.Text = tags.Tag.Album;

            if (tags.Tag.Pictures.Length >= 1)
            {
                var bin = (byte[])(tags.Tag.Pictures[0].Data.Data);
                PictureShow.Image = Image.FromStream(new MemoryStream(bin));
            }
            LyricsBox.Text = tags.Tag.Lyrics;
            Timer.Enabled = true;
            SongAlbumTag.Visible = true;
            SongArtistTag.Visible = true;
            SongTitleTag.Visible = true;
            TimeElapsed.Visible = true;
            TimeTotal.Visible = true;
            PictureShow.Visible = true;

            song.currentPlaylist.insertItem(0,song.controls.currentItem);
            
        }

        private void Play_Click(object sender, EventArgs e)
        {
            song.controls.play();
            SongAlbumTag.Visible = true;
            SongArtistTag.Visible = true;
            SongTitleTag.Visible = true;
            TimeElapsed.Visible = true;
            TimeTotal.Visible = true;
            PictureShow.Visible = true;

            TagLib.File tags = TagLib.File.Create(song.URL);

            if (tags.Tag.Pictures.Length >= 1)
            {
                var bin = (byte[])(tags.Tag.Pictures[0].Data.Data);
                PictureShow.Image = Image.FromStream(new MemoryStream(bin));
            }

        }

        private void Stop_Click(object sender, EventArgs e)
        {
            song.controls.stop();
            SongAlbumTag.Visible = false;
            SongArtistTag.Visible = false;
            SongTitleTag.Visible = false;
            TimeElapsed.Visible = false;
            TimeTotal.Visible = false;
            PictureShow.Image = null;
            
        }

        private void Pause_Click(object sender, EventArgs e)
        {
            song.controls.pause();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            progressBar.Value = (int)song.controls.currentPosition;
            progressBar.Maximum = (int)song.controls.currentItem.duration;
            TimeTotal.Text = song.controls.currentItem.durationString;
            TimeElapsed.Text = song.controls.currentPositionString;
        }

        private void Next_Click(object sender, EventArgs e)
        {
            song.controls.next();
        }

        private void Previous_Click(object sender, EventArgs e)
        {
            song.controls.previous();
        }

        private void AddFiletoPL_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            
        }

    
    }
}
