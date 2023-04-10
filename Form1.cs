namespace SpotifyAppLiam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /* method initialization */

        user myUser = new user();

        /* media buttons pause, play, repeat */

        private void play_Click(object sender, EventArgs e)
        {
            //play
        }

        private void pause_Click(object sender, EventArgs e)
        {
            //pause
        }

        private void repeat_Click(object sender, EventArgs e)
        {
            //repeat
        }

        /* information display - FriendList - Current song - PlayList - duration */

        private void friendList_SelectedIndexChanged(object sender, EventArgs e)
        {
            //friendlist
        }

        private void curentsong_TextChanged(object sender, EventArgs e)
        {
            //curentSong
        }

        private void playList_SelectedIndexChanged(object sender, EventArgs e)
        {
            //playList - laat alle lietjes zien in w8 rij of algemeen
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            //duration bar
        }

        /* ------ */
    }
}