namespace Comandas
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gpxPrincipal = new ReaLTaiizor.Controls.GroupBox();
            btnUsuarios = new ReaLTaiizor.Controls.AirButton();
            btnCardapio = new ReaLTaiizor.Controls.AirButton();
            btncomanda = new ReaLTaiizor.Controls.AirButton();
            btnPedidoCozinha = new ReaLTaiizor.Controls.AirButton();
            gpxPrincipal.SuspendLayout();
            SuspendLayout();
            // 
            // gpxPrincipal
            // 
            gpxPrincipal.BackColor = Color.Transparent;
            gpxPrincipal.BackGColor = Color.DodgerBlue;
            gpxPrincipal.BaseColor = Color.Transparent;
            gpxPrincipal.BorderColorG = Color.FromArgb(159, 159, 161);
            gpxPrincipal.BorderColorH = Color.FromArgb(182, 180, 186);
            gpxPrincipal.Controls.Add(btnUsuarios);
            gpxPrincipal.Controls.Add(btnCardapio);
            gpxPrincipal.Controls.Add(btncomanda);
            gpxPrincipal.Controls.Add(btnPedidoCozinha);
            gpxPrincipal.Font = new Font("Tahoma", 9F);
            gpxPrincipal.ForeColor = Color.FromArgb(53, 53, 53);
            gpxPrincipal.HeaderColor = Color.CornflowerBlue;
            gpxPrincipal.Location = new Point(12, 177);
            gpxPrincipal.MinimumSize = new Size(136, 50);
            gpxPrincipal.Name = "gpxPrincipal";
            gpxPrincipal.Padding = new Padding(5, 28, 5, 5);
            gpxPrincipal.Size = new Size(776, 235);
            gpxPrincipal.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            gpxPrincipal.TabIndex = 0;
            gpxPrincipal.Text = "        ";
            gpxPrincipal.Click += gpxPrincipal_Click;
            // 
            // btnUsuarios
            // 
            btnUsuarios.Customization = "7e3t//Ly8v/r6+v/5ubm/+vr6//f39//p6en/zw8PP8UFBT/gICA/w==";
            btnUsuarios.Font = new Font("Segoe UI", 9F);
            btnUsuarios.Image = null;
            btnUsuarios.Location = new Point(555, 77);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.NoRounding = false;
            btnUsuarios.Size = new Size(145, 108);
            btnUsuarios.TabIndex = 3;
            btnUsuarios.Text = "Usuários";
            btnUsuarios.Transparent = false;
            btnUsuarios.DoubleClick += btnUsuarios_DoubleClick;
            // 
            // btnCardapio
            // 
            btnCardapio.Customization = "7e3t//Ly8v/r6+v/5ubm/+vr6//f39//p6en/zw8PP8UFBT/gICA/w==";
            btnCardapio.Font = new Font("Segoe UI", 9F);
            btnCardapio.Image = null;
            btnCardapio.Location = new Point(36, 77);
            btnCardapio.Name = "btnCardapio";
            btnCardapio.NoRounding = false;
            btnCardapio.Size = new Size(145, 108);
            btnCardapio.TabIndex = 0;
            btnCardapio.Text = "Cardápio";
            btnCardapio.Transparent = false;
            btnCardapio.Click += btnCardapio_Click;
            btnCardapio.DoubleClick += btnCardapio_DoubleClick;
            // 
            // btncomanda
            // 
            btncomanda.Customization = "7e3t//Ly8v/r6+v/5ubm/+vr6//f39//p6en/zw8PP8UFBT/gICA/w==";
            btncomanda.Font = new Font("Segoe UI", 9F);
            btncomanda.Image = null;
            btncomanda.Location = new Point(208, 77);
            btncomanda.Name = "btncomanda";
            btncomanda.NoRounding = false;
            btncomanda.Size = new Size(145, 108);
            btncomanda.TabIndex = 1;
            btncomanda.Text = "Comanda";
            btncomanda.Transparent = false;
            btncomanda.Click += airButton2_Click;
            btncomanda.DoubleClick += btncomanda_DoubleClick;
            // 
            // btnPedidoCozinha
            // 
            btnPedidoCozinha.Customization = "7e3t//Ly8v/r6+v/5ubm/+vr6//f39//p6en/zw8PP8UFBT/gICA/w==";
            btnPedidoCozinha.Font = new Font("Segoe UI", 9F);
            btnPedidoCozinha.Image = null;
            btnPedidoCozinha.Location = new Point(384, 77);
            btnPedidoCozinha.Name = "btnPedidoCozinha";
            btnPedidoCozinha.NoRounding = false;
            btnPedidoCozinha.Size = new Size(145, 108);
            btnPedidoCozinha.TabIndex = 2;
            btnPedidoCozinha.Text = "Pedido Cozinha";
            btnPedidoCozinha.Transparent = false;
            btnPedidoCozinha.DoubleClick += btnPedidoCozinha_DoubleClick;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(gpxPrincipal);
            Name = "FrmPrincipal";
            Text = "FrmComandaCad";
            Load += FrmPrincipal_Load;
            gpxPrincipal.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.GroupBox gpxPrincipal;
        private ReaLTaiizor.Controls.AirButton btnUsuarios;
        private ReaLTaiizor.Controls.AirButton btnPedidoCozinha;
        private ReaLTaiizor.Controls.AirButton btncomanda;
        private ReaLTaiizor.Controls.AirButton btnCardapio;
    }
}