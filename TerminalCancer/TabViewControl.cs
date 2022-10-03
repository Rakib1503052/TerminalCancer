using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TerminalCancer
{
    public partial class TabViewControl : UserControl
    {
        private LinkedList<Button> Tabs = new LinkedList<Button>();
        private Button NewTabButton = new Button();
        public TabViewControl()
        {
            InitializeComponent();

            NewTabButton.Text = "+";
            NewTabButton.Click += NewTab_Click;
            NewTabButton.Height = 50;
            NewTabButton.Width = 50;
            Tabs.AddLast(NewTabButton);
            SuspendLayout();
            tableLayoutPanel3.Controls.Add(Tabs.ElementAt(0), 0, 0);
            ResumeLayout();
        }

        private void NewTab_Click(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
