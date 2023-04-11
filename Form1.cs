using System.Windows.Forms;

namespace SpotifyAppLiam
{
    public partial class Form1 : Form
    {
        public List<user> users = new();
        public Form1()
        {
            InitializeComponent();

            users.Add(new user { Name = "Liam Kilsdonk", Id = 1 });
            users.Add(new user { Name = "Meneer Held", Id = 2 });
            users.Add(new user { Name = "Luke Peters", Id = 3 });
            users.Add(new user { Name = "Amber Opsteen", Id = 4 });
            users.Add(new user { Name = "Daan Parker", Id = 5 });

            /*for(int i=0; i < 10; i++)
                strings.Add(i.ToString());

            strings.ForEach(str => {
                friendList.Items.Add(str);
            });*/

            users.ForEach(user => friendList.Items.Add(user.Name));
        }

        /* method initialization */

        user myUser = new();
        List<string> strings = new();

        public class MyList
        {
            public List<string> Items { get; } = new List<string>();
        }

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
            user user = users[friendList.SelectedIndex];
            
            Console.WriteLine(user.Name);
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