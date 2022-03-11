using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Dashboard
{
    public partial class Form1 : Form
    {

      
        

            [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

            private static extern IntPtr CreateRoundRectRgn
            (
                int nLeftRect,
                int nTopRect,
                int nRightRect,
                int nBottomRect,
                int nWidthEllipse,
                int nHeightEllipse
            );




            public Form1()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            pnlNav.Height = btnDashboard.Height;
            pnlNav.Top = btnDashboard.Top;
            pnlNav.Left = btnDashboard.Left;
            btnDashboard.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnDashboard.Height;
            pnlNav.Top = btnDashboard.Top;
            pnlNav.Left = btnDashboard.Left;
            btnDashboard.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnAnaliticos_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnAnaliticos.Height;
            pnlNav.Top = btnAnaliticos.Top;
            btnAnaliticos.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnCalendario_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnCalendario.Height;
            pnlNav.Top = btnCalendario.Top;
            btnCalendario.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnContatos_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnContatos.Height;
            pnlNav.Top = btnContatos.Top;
            btnContatos.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnConfiguracoes_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnConfiguracoes.Height;
            pnlNav.Top = btnConfiguracoes.Top;
            btnConfiguracoes.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnDashboard_Leave(object sender, EventArgs e)
        {
            btnDashboard.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnAnaliticos_Leave(object sender, EventArgs e)
        {
            btnAnaliticos.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnCalendario_Leave(object sender, EventArgs e)
        {
            btnCalendario.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnContatos_Leave(object sender, EventArgs e)
        {
            btnContatos.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnConfiguracoes_Leave(object sender, EventArgs e)
        {
            btnConfiguracoes.BackColor = Color.FromArgb(24, 30, 54);
        }
    }
}