using System.Reflection.Metadata.Ecma335;

namespace RpgBattle
{
    public partial class Form1 : Form
    {
        int monsterHealth = 100;
        int playerAttack = 900000000;
        int playerMagicAttack = 50;
        public Form1()
        {
            InitializeComponent();
            monsterhealth.Text = monsterHealth.ToString();
        }
        //1)
        private void DoDamage(int damage)
        {
            monsterHealth -= damage;
            monsterhealth.Text = monsterHealth.ToString();
        }



        //maak hier een function: 
        //- DoDamage, 
        //- met 1 argument: (int damage), 
        //- maak de function private, 
        // - met void als returntype

        //2) zet de code hieronder tussen de {} (de body of scope van de function)

        //monsterHealth -= damage;
        //monsterhealth.Text = monsterHealth.ToString();
        // monsterHealthLabel.Text = monsterHealth.ToString();


        private void attack_Click(object sender, EventArgs e)
        {
            //3)
            DoDamage(playerAttack + playerMagicAttack); //gebruik hier de playerAttack
			

        }

        private void fireball_Click(object sender, EventArgs e)
        {
            //4)
            DoDamage(playerMagicAttack); //gebruik hier de playerMagicAttack


        }
    }
}
