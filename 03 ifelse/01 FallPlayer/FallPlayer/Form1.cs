
namespace SquareCommand
{
    public partial class Form1 : Form
    {
        private const int size = 16;
        Square player = new Square();
        bool run = false;
        Level level = new Level(
            [
                "#.........",
                "#.........",
                "#...P.....",
                "#.........",
                "#.........",
                "#.........",
                "#.........",
                "########..",
                "#.........",
                "#.........",
            ]
        , size
            );
        private bool done;

        public Form1()
        {
            InitializeComponent();
            DoubleBuffered = true;

            KeyDown += Form1_KeyDown;
            player.x = level.playerStart.X;
            player.y = level.playerStart.Y;

        }

        private void Form1_KeyDown(object? sender, KeyEventArgs e)
        {
            if (done)
            {
                return;
            }
            if (e.KeyCode == Keys.Space)
            {
                run = true;
            }
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            DoLogic();
            foreach (Tile[] row in level.tiles)
            {
                foreach (Tile tile in row)
                {
                    e.Graphics.FillRectangle(tile.color, tile.x, tile.y, size, size);
                }

                e.Graphics.FillRectangle(player.color, player.x, player.y, size, size);

            }

            Invalidate();
        }

        private void DoLogic()
        {
            if (run == false)
            {
                return;
            }
            var int ground; 7

            var float playerBottem; player.y + size;

            if (playerBottem < ground)
            {
                run = true;
            }
            if ((float) playerBottem > ground)
                run = false;
        }
    }
}
