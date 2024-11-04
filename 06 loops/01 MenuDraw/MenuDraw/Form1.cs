
namespace MenuDraw
{
    public partial class Form1 : Form
    {
        GameMenuItem[] menu;

        public Form1()
        {
            InitializeComponent();
            DoubleBuffered = true;

            menu = new GameMenuItem[]
            {
                new GameMenuItem("Continue"),
                new GameMenuItem("New Game"),
                new GameMenuItem("Load game"),
                new GameMenuItem("Options")
            };

            for (int i = 0; i < menu.Length; i++)
            {
                menu[i].bounds.Y = i * menu[i].bounds.Height;
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.Clear(Color.Black);
            for (int i = 0; i < menu.Length; i++)
            {
				GameMenuItem menuItem = menu[i];
                menuItem.Draw(e.Graphics);
            }
        }

        public void DoLogic(float frametime)
        {
        }
    }
}
