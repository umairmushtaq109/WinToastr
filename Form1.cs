namespace WinToastr
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Toast toast = new Toast("Connected to iPhone 12", ToastType.Information);
            toast.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Toast toast = new Toast("Record Submitted Successfully", ToastType.Success);
            toast.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Toast toast = new Toast("Failed to connect to internet", ToastType.Error);
            toast.Show();
        }
    }
}