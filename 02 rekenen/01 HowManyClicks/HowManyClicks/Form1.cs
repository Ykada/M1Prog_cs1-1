namespace HowManyClicks
{
    public partial class Form1 : Form
    {
        int clicks = 0;
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
