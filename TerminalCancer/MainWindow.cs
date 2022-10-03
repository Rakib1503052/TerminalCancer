namespace TerminalCancer
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();

            TabViewPages = new TabViewControl();
            SuspendLayout();
            tableLayoutPanel1.Controls.Add(TabViewPages, 0, 0);
            ResumeLayout();
        }

        private void SetThemes()
        {

        }
    }
}