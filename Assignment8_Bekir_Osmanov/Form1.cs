namespace Assignment8_Bekir_Osmanov
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader boys;
                string boyNames;
                boys = File.OpenText("BoyNames.txt");
                List<string> boyNameList = new List<string>();


                StreamReader girls;
                string girlNames;
                girls = File.OpenText("GirlNames.txt");
                List<string> girlNameList = new List<string>();

                boyNames = boysName.Text;
                girlNames = girlsName.Text;

                while (!boys.EndOfStream)
                {
                    boyNameList.Add(boys.ReadLine());
                }
                while (!girls.EndOfStream)
                {
                    girlNameList.Add(girls.ReadLine());
                }

                int boysPosition = boyNameList.IndexOf(boyNames);
                int girlsPosition = girlNameList.IndexOf(girlNames);

                if (boysPosition != -1)
                {
                    MessageBox.Show("This BOY name is one of the popular names.");
                }
                if (girlsPosition != -1)
                {
                    MessageBox.Show("This GIRL name is one of the most popular names.");
                }
                else if (boysPosition == -1)
                {
                    MessageBox.Show("This BOY name is NOT one of the most popular names.");
                }
                else if (girlsPosition == -1)
                {
                    MessageBox.Show("This GIRL name is NOT one of the most popular names.");
                }

            } 
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } 

        }
    }
}