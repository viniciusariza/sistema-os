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
using DAO;  

namespace os
{
    public partial class frmLogin : Form
    {

        //Importa dll para mover formulário
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                int idUser = new UsuarioDAO().ValidarUsuario(txtNome.Text, txtSenha.Text);
                
                if(idUser == -1)
                {
                    MessageBox.Show("Usuário e/ou senha inválido(s)!", "Falha ao fazer login");
                    txtNome.Focus();
                }
                else
                {
                    Usuario.CodigoUsuarioLogado = idUser;
                    this.DialogResult = DialogResult.OK;
                }
            }
        }

        private bool ValidarCampos()
        {
            bool ret = true;
            string campo = "";

            if (txtNome.Text.Trim() == "")
            {
                ret = false;
                campo = "- Nome";
            }

            if (txtSenha.Text.Trim() == "")
            {
                ret = false;
                campo += "\n- Senha";
            }

            if (!ret)
            {
                Util.ExibirMsgValidarCampos(campo);
            }

            return ret;

        }

        private void frmLogin_MouseDown(object sender, MouseEventArgs e)
        {
            //Mover formulário
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void txtNome_Enter(object sender, EventArgs e)
        {
            if (txtNome.Text == "Nome")
            {
                txtNome.Text = "";
                txtNome.ForeColor = Color.White;
            }
        }

        private void txtNome_Leave(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
            {
                txtNome.Text = "Nome";
                txtNome.ForeColor = Color.DarkGray;
            }
        }

        private void txtSenha_Enter(object sender, EventArgs e)
        {
            if (txtSenha.Text == "Password")
            {
                txtSenha.Text = "";
                txtSenha.ForeColor = Color.White;
            }
        }

        private void txtSenha_Leave(object sender, EventArgs e)
        {
            if (txtSenha.Text == "")
            {
                txtSenha.Text = "Password";
                txtSenha.ForeColor = Color.DarkGray;
            }
        }

        private void txtNome_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtSenha.Focus();
            }
        }

        private void txtSenha_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnEntrar.Focus();
            }
        }
    }
}
