using pcsharp_saude.controllers;
using saude_csharp.controllers;
using saude_csharp.Controllers;
using saude_csharp.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace saude_csharp.Forms
{
    public partial class frmCadastrarFuncionario : Form
    {
        public frmCadastrarFuncionario()
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ActiveControl = txtNome;
            ArrayList list = EspecialidadeController.Recuperar();
            foreach (Especialidade esp in list)
            {
                cbEspecialidade.Items.Add(esp.Id + " - " + esp.Designacao);
            }
        }

        private void LimparCaixas()
        {
            txtId.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtEndereco.Text = string.Empty;
            txtNome.Text = string.Empty;
            txtTel1.Text = string.Empty;
            txtTel2.Text = string.Empty;
            cbEspecialidade.Text = "";
            cbSexo.Text = string.Empty;
            dtpDataDeNascimento.Value = DateTime.Now;
        }

        public void Adicionar()
        {
            int id = FuncionariosController.ObterIdUltimoRegisto();
            LimparCaixas();
            txtId.Text = id + 1 + "";
        }

        public void Gravar()
        {
            int id = int.Parse(txtId.Text);
            string nome = txtNome.Text;
            string telefone_1 = txtTel1.Text;
            string telefone_2 = txtTel2.Text;
            string email = txtEmail.Text;
            string sexo = cbSexo.Text;
            DateTime dataDeNascimento = dtpDataDeNascimento.Value.Date;
            string[] cbEspecialidadetext = cbEspecialidade.Text.Split(' ');
            int especialidade = int.Parse(cbEspecialidadetext[0]);
            string endereco = txtEndereco.Text;
            int pessoa_id = PessoasController.ObterIdUltimoRegisto() + 1;
            ArrayList list = FuncionariosController.Recuperar(id);
            if (list.Count == 0)
            {
                PessoasController.Gravar(pessoa_id, nome, dataDeNascimento, sexo, endereco, telefone_1, telefone_2, email);
                FuncionariosController.Gravar(id, pessoa_id, especialidade, "");
            }
            else
            {
                foreach (Funcionario func in list)
                {
                    pessoa_id = func.Pessoa_id;
                }
                FuncionariosController.Atualizar(id, pessoa_id, especialidade, "");
                PessoasController.Atualizar(pessoa_id, nome, dataDeNascimento, sexo, endereco, telefone_1, telefone_2, email);
            }
        }

        public void Mostrar()
        {
            frmNumeroRegisto f = new frmNumeroRegisto();
            f.ShowDialog();
            int cod = f.enterdCod;
            ArrayList listaFuncionarios = FuncionariosController.Recuperar(cod);
            ArrayList listaPessoas = new ArrayList();
            MontarCaixasDeTexto(listaFuncionarios, listaPessoas);
        }
        private void AtualizarCaixas(Boolean estado)
        {
            txtEmail.ReadOnly = estado;
            txtEndereco.ReadOnly = estado;
            txtNome.ReadOnly = estado;
            txtTel1.ReadOnly = estado;
            txtTel2.ReadOnly = estado;
            cbEspecialidade.Enabled = !estado;
            cbEspecialidade.Enabled = !estado;
            cbSexo.Enabled = !estado;
            dtpDataDeNascimento.Enabled = !estado;
        }

        public void MontarCaixasDeTexto(ArrayList listaFuncionarios, ArrayList listaPessoas)
        {
            int pessoa_id;
            ArrayList listaEspecialidades = new ArrayList();
            foreach (Funcionario func in listaFuncionarios)
            {
                pessoa_id = func.Pessoa_id;
                txtId.Text = func.Id + "";
                listaPessoas = PessoasController.Recuperar(pessoa_id);
                listaEspecialidades = EspecialidadeController.RecuperarComCod(func.Especialidade);
                //dtpDataDeNascimento.Value = func.DataDeNascimento;
            }

            foreach (Especialidade esp in listaEspecialidades)
            {
                cbEspecialidade.Text = esp.Id + " - " + esp.Designacao;
            }

            foreach (Pessoa pes in listaPessoas)
            {
                txtNome.Text = pes.Name;
                txtEmail.Text = pes.Email;
                txtEndereco.Text = pes.Endereco;
                txtTel1.Text = pes.Telefone_1;
                txtTel1.Text = pes.Telefone_2;
                cbSexo.Text = pes.Sexo;
            }
        }

        public void MontarCaixasDeTexto(ArrayList listaPessoas)
        {
            ArrayList listaFuncionarios = FuncionariosController.Recuperar();
            int pessoa_id = 0;
            ArrayList listaEspecialidades = new ArrayList();
            foreach (Pessoa pes in listaPessoas)
            {
                txtNome.Text = pes.Name;
                txtEmail.Text = pes.Email;
                txtEndereco.Text = pes.Endereco;
                txtTel1.Text = pes.Telefone_1;
                txtTel2.Text = pes.Telefone_2;
                cbSexo.Text = pes.Sexo;
                pessoa_id = pes.Id;
            }
            foreach (Funcionario func in listaFuncionarios)
            {
                if (pessoa_id == func.Pessoa_id)
                {
                    pessoa_id = func.Pessoa_id;
                    txtId.Text = func.Id + "";
                    listaPessoas = PessoasController.Recuperar(pessoa_id);
                    listaEspecialidades = EspecialidadeController.RecuperarComCod(func.Especialidade);
                }
            }

            foreach (Especialidade esp in listaEspecialidades)
            {
                cbEspecialidade.Text = esp.Id + " - " + esp.Designacao;
            }
        }

        private void Procurar(int cod)
        {
            //Procura na lista de funcionarios
            ArrayList listaFuncionarios = FuncionariosController.Recuperar(cod);
            ArrayList listaPessoas = new ArrayList();
            MontarCaixasDeTexto(listaFuncionarios, listaPessoas);
        }


        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Normal;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void btnMinimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void frmCadastrarFuncionario_Load(object sender, EventArgs e)
        {
            
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            Adicionar();
            AtualizarCaixas(false);
            txtNome.Focus();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            Gravar();
            Adicionar();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja eliminar o Funcionario?", "Atenção!",
                                          MessageBoxButtons.YesNo,
                                          MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                int id = int.Parse(txtId.Text);
                FuncionariosController.Remover(id);
                LimparCaixas();
            }
        }

        private void btnAntes_Click(object sender, EventArgs e)
        {
            int cod = 0;
            if (txtId.Text == "")
            {
                cod = FuncionariosController.ObterIdUltimoRegisto();
            }
            else
            {
                cod = int.Parse(txtId.Text) - 1;
            }
            Procurar(cod);
        }

        private void btnDepois_Click(object sender, EventArgs e)
        {
            int cod = 0;
            if (txtId.Text == "")
            {
                cod = FuncionariosController.ObterIdUltimoRegisto();
            }
            else
            {
                cod = int.Parse(txtId.Text) + 1;
            }
            Procurar(cod);
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Mostrar();
        }
    }
}
