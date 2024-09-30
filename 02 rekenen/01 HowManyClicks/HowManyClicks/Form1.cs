namespace HowManyClicks
{
    public partial class Form1 : Form
    {
        int clicks = 1;
        //1) maak hier een variable (int met als naam clicks)
        private int clicks;
        public Form1()
        {
            InitializeComponent(clicks);
        }

        private void plusButton_Click(object sender, EventArgs e)
        {

            //2) tel hier 1 op bij clicks (zie boven in de klas)
            clicks ++;
            clicksAmountText.Text = clicks.ToString();
        }
    }
}
