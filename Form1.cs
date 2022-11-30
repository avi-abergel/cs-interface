namespace week_10_4
{
    public partial class Form1 : Form
    {

        IItem[] ItemArr = new IItem[5];
        int ItemIdx = 0;
        public Form1()
        {
            InitializeComponent();
        }

        public enum days{
            sunday,monday, tuesday,wednesday,thursday,friday,saturday
        };

        public days wd;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            File.AppendAllText("fortText.txt",textBox1.Text+","+textBox2.Text+","+textBox3.Text+"\n");
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";

        }
        int count = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            string[] fileContent = File.ReadAllLines("fortText.txt");
            if (count==0)
            {
                count = fileContent.Length - 1;
            }
            else
            {
                count=count-1;
            }
            string[] words = fileContent[count].Split(",");
            textBox1.Text = words[0];
            textBox2.Text = words[1];
            textBox3.Text = words[2];
            days day = (days)Enum.Parse(typeof(days),words[2], true);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            IItem item = new cola();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            ItemArr[ItemIdx] = new cola();
            ItemIdx++;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ItemArr[ItemIdx] = new kinley();
            ItemIdx++;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string msg="";
            for (int i = 0; i <ItemIdx; i++)
            {
                msg += ItemArr[i].GetPrice().ToString() + "\n";
            }
            MessageBox.Show(msg);
        }
    }
}