using saude_csharp.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace saude_csharp
{
    public partial class Form1 : Form
    {
        //Campos 
        private Button currentButton;
        private Form activeForm;

        //Construtor
        public Form1()
        {
            InitializeComponent();
            btnClose.Visible = false;
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        //Metodos
        private Color SelectThemeColor() { 
            string color = ThemeColor.ColorList[0];
            return ColorTranslator.FromHtml(color);
        }

        private void ActiveButton(Object btnSender) { 
            if(btnSender != null)
            {
                if (currentButton != (Button)btnSender) { 
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    panelLogo.BackColor = color;
                    panelTitle.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    ThemeColor.PrimaryColor = color;
                    ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    btnClose.Visible = true;
                }
            }
        }

        private void DisableButton() {
            foreach (Control ctrl in panelMenu.Controls) {
                if (ctrl.GetType() == typeof(Button)) {
                    ctrl.BackColor = Color.FromArgb(51, 51, 76);
                    ctrl.ForeColor = Color.Gainsboro;
                    ctrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void OpenChildForm(Form childForm, Object btnSender) {
            if (activeForm != null) { 
                activeForm.Close();
            }
            ActiveButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPanel.Controls.Add(childForm);
            this.panelDesktopPanel.Tag = childForm;
            childForm.BringToFront();
            if(childForm.Name == "frmCadastrarEspecialidade") { 
                childForm.Anchor = AnchorStyles.Left;
                childForm.Anchor = AnchorStyles.Top;
            }
            childForm.Show();
            labelTitle.Text = childForm.Text;
        }

        private void btnPessoas_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            OpenChildForm(new frmPessoas(), sender);
        }

        private void btnConcultas_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
        }

        private void btnMedicamentos_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
        }

        private void btnReceitas_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
        }

        private void btnEspecialidades_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            OpenChildForm(new frmCadastrarEspecialidade(), sender);
        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if(activeForm != null)
                activeForm.Close();
            Reset();
        }

        private void Reset() { 
            DisableButton();
            labelTitle.Text = "Pagina Inicial";
            panelTitle.BackColor = Color.FromArgb(0, 150, 136);
            panelLogo.BackColor = Color.FromArgb(39, 39, 58);
            currentButton = null;
            btnClose.Visible = false;
        }

        private void panelTitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void btnMinimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
