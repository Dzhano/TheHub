using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayer
{
    public partial class MusicPlayer : Form
    {
        public MusicPlayer()
        {
            InitializeComponent();
        }

        // Create Global Variables of String Type Array to save the titles or name of the Tracks and path of the track.
        List<String> paths = new List<String>();
        List<String> files = new List<String>();

        private void MusicPlayer_Load(object sender, EventArgs e)
        {

        }

        private void Songs_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Write a code to play music
            axWindowsMediaPlayerMusic.URL = paths[Songs.SelectedIndex];
        }

        private void Songs_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void Songs_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void NextSong_Button_Click(object sender, EventArgs e)
        {
            if (Songs.SelectedIndex < Songs.Items.Count - 1) Songs.SelectedIndex += 1;
            else Songs.SelectedIndex = 0;
        }

        private void PreviousSong_Button_Click(object sender, EventArgs e)
        {
            if (Songs.SelectedIndex > 0) Songs.SelectedIndex -= 1;
            else Songs.SelectedIndex = Songs.Items.Count - 1;
        }

        private void TheHUB_MouseClick(object sender, MouseEventArgs e)
        {
            System.Diagnostics.Process.Start("https://thehub-aubg.com/");
        }

        private void TheHUB_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void TheHUB_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void RJC_MouseClick(object sender, MouseEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/rjcaubg");
        }

        private void RJC_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void RJC_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void AURA_MouseClick(object sender, MouseEventArgs e)
        {
            System.Diagnostics.Process.Start("https://radio-aura.org/");
        }

        private void AURA_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void AURA_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void label_MouseClick(object sender, MouseEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Dzhano/");
        }

        private void label_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void label_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void PlaySong_Click(object sender, EventArgs e)
        {
            // Code to select song
            OpenFileDialog ofd = new OpenFileDialog();
            // Code to select multiple files
            ofd.Multiselect = true;

            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                for (int i = 0; i < ofd.SafeFileNames.Count(); i++)
                {
                    if(!files.Contains(ofd.SafeFileNames[i]))
                    {
                        files.Add(ofd.SafeFileNames[i]); // Save the names of the track in file array.
                        paths.Add(ofd.FileNames[i]); // Save the paths of the tracks in path array.
                        Songs.Items.Add(ofd.SafeFileNames[i]); // Display Songs in ListBox
                    }
                }
            }
        }
    }
}
