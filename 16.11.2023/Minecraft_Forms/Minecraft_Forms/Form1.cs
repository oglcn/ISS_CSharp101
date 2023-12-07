using Minecraft_Forms.Entitites;

namespace Minecraft_Forms
{
    public partial class Form1 : Form // To Be Continued
    {
        public Form1()
        {
            InitializeComponent();
        }

        int counter = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            counter++;
            label1.Text = counter.ToString();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //GenericEntity entity1 = new GenericEntity("Steve",500);
        }
    }
}