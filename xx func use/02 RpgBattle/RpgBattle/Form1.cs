namespace RpgBattle
{
    public partial class Form1 : Form
    {
        int monsterHealth = 100;
        int playerAttack = 20;
        int playerMagicAttack = 50;
        public Form1()
        {
            InitializeComponent();
            monsterhealth.Text=monsterHealth.ToString();
            playerchar.BackgroundImage = Bitmap.FromFile("wizard.PNG");
            playerchar.BackgroundImageLayout = ImageLayout.Zoom;
            monster.BackgroundImage = Bitmap.FromFile("goblin.PNG");
            monster.BackgroundImageLayout = ImageLayout.Zoom;
        }
		//1)
		???
		//maak hier een function: 
		//- DoDamage, 
		//- met 1 argument: (int damage), 
		//- maak de function private, 
		// - met void als returntype
		
		
		//2) zet de code hieronder tussen de {} (de body of scope van de function)

		//monsterHealth -= damage;
		// monsterhealth.Text = monsterHealth.ToString();


        private void attack_Click(object sender, EventArgs e)
        {
            DoDamage(???); //gebruik hier de playerAttack
			

        }

        private void fireball_Click(object sender, EventArgs e)
        {
            DoDamage(???); //gebruik hier de playerMagicAttack


        }
    }
}
