
namespace UpAndDown
{
    public partial class Form1 : Form
    {

        int score = 0;
        int multiplier = 1;
        public Form1()
        {
            InitializeComponent();
            DoubleBuffered = true;

            KeyDown += Form1_KeyDown;
        }

        private void Form1_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                score *=2; multiplier *=2;
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.Clear(Color.Black);

            e.Graphics.DrawString("multiplier: " + multiplier, Font, Brushes.White, 50, 40);
            e.Graphics.DrawString("Score: " + score, Font, Brushes.White, 50, 50);

        }

        public void DoLogic(float frametime)
        {
            score += 2; multiplier = 2;
        }
    }
}
