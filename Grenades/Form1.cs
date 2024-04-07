using System.Media;

namespace Grenades
{
    public partial class Form1 : Form
    {
        /* EXPLOSION SOUND */
        SoundPlayer soundPlayer = new SoundPlayer(Resource1.explosion);

        /*GRENADE LOCATIONS*/
        Random xRandom = new Random(); // 0-750

        /*GRENADE PICTUREBOX*/
        PictureBox grenade;
        PictureBox grenade2;

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Left)
            {
                character.Location = new Point(character.Location.X - 7, character.Location.Y);
                character.Image = Resource1.runner_left;
            }
            if (e.KeyCode == Keys.Right)
            {
                character.Location = new Point(character.Location.X + 7, character.Location.Y);
                character.Image = Resource1.runner_right;
            }
        }


        public Form1()
        {
            InitializeComponent();
        }

        private void generationTimer_Tick(object sender, EventArgs e)
        {
            /*GRENADE 1*/
            grenade = new PictureBox();
            grenade.Image = Resource1.grenade;
            grenade.SizeMode = PictureBoxSizeMode.CenterImage;
            grenade.Size = new Size(50, 50);
            grenade.Location = new Point(xRandom.Next(0, 750), 20);

            /* GRENADE 2 */
            grenade2 = new PictureBox();
            grenade2.Image = Resource1.grenade;
            grenade2.SizeMode = PictureBoxSizeMode.CenterImage;
            grenade2.Size = new Size(50, 50);
            grenade2.Location = new Point(xRandom.Next(0, 750), 20);

            /*ADD THE FORM*/
            this.Controls.Add(grenade);
            this.Controls.Add(grenade2);
        }

        private void movementTimer_Tick(object sender, EventArgs e)
        {
            if (grenade != null && grenade2 != null)
            {
                grenade.Location = new Point(grenade.Location.X, grenade.Location.Y + 7);
                grenade2.Location = new Point(grenade2.Location.X, grenade2.Location.Y + 7);

                if(character.Bounds.IntersectsWith(grenade.Bounds) || character.Bounds.IntersectsWith(grenade2.Bounds))
                {
                    /* DELETE GRENADE OBJECTS */
                    grenade.Dispose();
                    grenade2.Dispose();

                    /* TIMER STOP */
                    generationTimer.Stop();
                    movementTimer.Stop();

                    /* EXPLOSION SOUND */
                    soundPlayer.Play();

                    /* MESSAGE */
                    MessageBox.Show("You Died!","Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    /* CLOSE THE APP */
                    this.Dispose();
                }
            }
        }

   
    }
}
