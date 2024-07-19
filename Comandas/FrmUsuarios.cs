using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comandas
{
    public partial class FrmUsuarios : Form
    {
        private bool novo;

        public FrmUsuarios()
        {
            InitializeComponent();
            ListarUsuarios();
        }
        // conectar no banco
        private void ListarUsuarios()
        {

            using (var banco = new AppDbContext())
            {   // SELECT * FROM usuarios
                var usuarios = banco.Usuarios.ToList();
                // Popular a tabela na tela DataGridView
                dgvUsuarios.DataSource = usuarios;
            }
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (novo) // usar chaves apenas quando é mais de uma linha
                /// metodo que vai inserir o usuario no banco
                CriarUsuario();

            else
                //AtualizarUsuario();
                AtualizarUsuario();
            DesabilitarCampos();
            ListarUsuarios();
            LimparCampos();
        }

        private void LimparCampos()
        {
            txtId.TextButton = string.Empty;
            txtNome.TextButton = string.Empty;  
            txtEmail.TextButton = string.Empty;
            txtSenha.TextButton = string.Empty;
        }

        // Ctrl+K e Ctrl+D formatar certo!!
        private void AtualizarUsuario()
        {
            using (var banco = new AppDbContext())
            {
                var usuario = banco
                    .Usuarios
                    .Where(e => e.Id == int.Parse(txtId.Text)).FirstOrDefault();
                usuario.Nome = txtNome.Text;
                usuario.Email = txtEmail.Text;
                usuario.Senha = txtSenha.Text;
                banco.SaveChanges();
            }
        }

        private void CriarUsuario()
        {
            // acessar o banco
            using (var banco = new AppDbContext())
            {
                // criar um novo usuario
                var novoUsuario = new Usuario();
                // atribuir propiedades
                novoUsuario.Nome = txtNome.TextButton;
                novoUsuario.Email = txtEmail.TextButton;
                novoUsuario.Senha = txtSenha.TextButton;
                // salvar as alterações(INSERT INTO usuarios)
                banco.Usuarios.Add(novoUsuario);
                banco.SaveChanges();
                MessageBox.Show("Usuário cadastrado com sucesso.");
            }


        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            novo = true;
            HabilitarCampos();
        }

        private void HabilitarCampos()
        {
            txtNome.Enabled = true;
            txtEmail.Enabled = true;
            txtSenha.Enabled = true;
        }

        private void DesabilitarCampos()
        {
            txtNome.Enabled = false;
            txtEmail.Enabled = false;
            txtSenha.Enabled = false;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {   // indiaca que esta editando o usuario
            novo = false;
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }
    }
}
