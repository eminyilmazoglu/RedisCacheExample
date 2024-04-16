using System.Text;

namespace RedisCacheExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        RedisCacheManager redisCacheManager = new RedisCacheManager();
        private void button1_Click(object sender, EventArgs e)
        {
            redisCacheManager.Set("myFirstValue", "Emin2");

            MessageBox.Show(System.Text.Encoding.Default.GetString(redisCacheManager.Get("myFirstValue")));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            redisCacheManager.Remove("myFirstValue");
        }
    }
}
