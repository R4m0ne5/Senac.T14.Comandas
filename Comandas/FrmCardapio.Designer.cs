﻿namespace Comandas
{
    partial class FrmCardapio
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
            btnVoltar = new ReaLTaiizor.Controls.CyberButton();
            txtPesquisar = new ReaLTaiizor.Controls.CyberTextBox();
            btnNovo = new ReaLTaiizor.Controls.CyberButton();
            dgvCardapio = new DataGridView();
            btnEditar = new ReaLTaiizor.Controls.CyberButton();
            btnExcluir = new ReaLTaiizor.Controls.CyberButton();
            ((System.ComponentModel.ISupportInitialize)dgvCardapio).BeginInit();
            SuspendLayout();
            // 
            // btnVoltar
            // 
            btnVoltar.Alpha = 20;
            btnVoltar.BackColor = Color.Transparent;
            btnVoltar.Background = true;
            btnVoltar.Background_WidthPen = 4F;
            btnVoltar.BackgroundPen = true;
            btnVoltar.ColorBackground = Color.FromArgb(37, 52, 68);
            btnVoltar.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            btnVoltar.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            btnVoltar.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            btnVoltar.ColorLighting = Color.FromArgb(29, 200, 238);
            btnVoltar.ColorPen_1 = Color.FromArgb(37, 52, 68);
            btnVoltar.ColorPen_2 = Color.FromArgb(41, 63, 86);
            btnVoltar.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            btnVoltar.Effect_1 = true;
            btnVoltar.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            btnVoltar.Effect_1_Transparency = 25;
            btnVoltar.Effect_2 = true;
            btnVoltar.Effect_2_ColorBackground = Color.White;
            btnVoltar.Effect_2_Transparency = 20;
            btnVoltar.Font = new Font("Arial", 11F);
            btnVoltar.ForeColor = Color.FromArgb(245, 245, 245);
            btnVoltar.Lighting = false;
            btnVoltar.LinearGradient_Background = false;
            btnVoltar.LinearGradientPen = false;
            btnVoltar.Location = new Point(30, 460);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.PenWidth = 15;
            btnVoltar.Rounding = true;
            btnVoltar.RoundingInt = 70;
            btnVoltar.Size = new Size(164, 66);
            btnVoltar.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnVoltar.TabIndex = 1;
            btnVoltar.Tag = "Cyber";
            btnVoltar.TextButton = "Voltar";
            btnVoltar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnVoltar.Timer_Effect_1 = 5;
            btnVoltar.Timer_RGB = 300;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // txtPesquisar
            // 
            txtPesquisar.Alpha = 20;
            txtPesquisar.BackColor = Color.Transparent;
            txtPesquisar.Background_WidthPen = 3F;
            txtPesquisar.BackgroundPen = true;
            txtPesquisar.ColorBackground = Color.FromArgb(37, 52, 68);
            txtPesquisar.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            txtPesquisar.ColorLighting = Color.FromArgb(29, 200, 238);
            txtPesquisar.ColorPen_1 = Color.FromArgb(29, 200, 238);
            txtPesquisar.ColorPen_2 = Color.FromArgb(37, 52, 68);
            txtPesquisar.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            txtPesquisar.Font = new Font("Arial", 16F);
            txtPesquisar.ForeColor = Color.Silver;
            txtPesquisar.Lighting = false;
            txtPesquisar.LinearGradientPen = false;
            txtPesquisar.Location = new Point(30, 24);
            txtPesquisar.Name = "txtPesquisar";
            txtPesquisar.PenWidth = 15;
            txtPesquisar.RGB = false;
            txtPesquisar.Rounding = true;
            txtPesquisar.RoundingInt = 60;
            txtPesquisar.Size = new Size(988, 66);
            txtPesquisar.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            txtPesquisar.TabIndex = 2;
            txtPesquisar.Tag = "Cyber";
            txtPesquisar.TextButton = "Pesquisar...";
            txtPesquisar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            txtPesquisar.Timer_RGB = 300;
            // 
            // btnNovo
            // 
            btnNovo.Alpha = 20;
            btnNovo.BackColor = Color.Transparent;
            btnNovo.Background = true;
            btnNovo.Background_WidthPen = 4F;
            btnNovo.BackgroundPen = true;
            btnNovo.ColorBackground = Color.FromArgb(37, 52, 68);
            btnNovo.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            btnNovo.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            btnNovo.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            btnNovo.ColorLighting = Color.FromArgb(29, 200, 238);
            btnNovo.ColorPen_1 = Color.FromArgb(37, 52, 68);
            btnNovo.ColorPen_2 = Color.FromArgb(41, 63, 86);
            btnNovo.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            btnNovo.Effect_1 = true;
            btnNovo.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            btnNovo.Effect_1_Transparency = 25;
            btnNovo.Effect_2 = true;
            btnNovo.Effect_2_ColorBackground = Color.White;
            btnNovo.Effect_2_Transparency = 20;
            btnNovo.Font = new Font("Arial", 11F);
            btnNovo.ForeColor = Color.FromArgb(245, 245, 245);
            btnNovo.Lighting = false;
            btnNovo.LinearGradient_Background = false;
            btnNovo.LinearGradientPen = false;
            btnNovo.Location = new Point(30, 105);
            btnNovo.Name = "btnNovo";
            btnNovo.PenWidth = 15;
            btnNovo.Rounding = true;
            btnNovo.RoundingInt = 70;
            btnNovo.Size = new Size(195, 75);
            btnNovo.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnNovo.TabIndex = 3;
            btnNovo.Tag = "Cyber";
            btnNovo.TextButton = "+ Novo Item Cardapio";
            btnNovo.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnNovo.Timer_Effect_1 = 5;
            btnNovo.Timer_RGB = 300;
            btnNovo.Click += btnNovo_Click;
            // 
            // dgvCardapio
            // 
            dgvCardapio.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCardapio.Location = new Point(21, 186);
            dgvCardapio.Name = "dgvCardapio";
            dgvCardapio.RowHeadersWidth = 62;
            dgvCardapio.Size = new Size(1016, 268);
            dgvCardapio.TabIndex = 4;
            // 
            // btnEditar
            // 
            btnEditar.Alpha = 20;
            btnEditar.BackColor = Color.Transparent;
            btnEditar.Background = true;
            btnEditar.Background_WidthPen = 4F;
            btnEditar.BackgroundPen = true;
            btnEditar.ColorBackground = Color.FromArgb(37, 52, 68);
            btnEditar.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            btnEditar.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            btnEditar.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            btnEditar.ColorLighting = Color.FromArgb(29, 200, 238);
            btnEditar.ColorPen_1 = Color.FromArgb(37, 52, 68);
            btnEditar.ColorPen_2 = Color.FromArgb(41, 63, 86);
            btnEditar.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            btnEditar.Effect_1 = true;
            btnEditar.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            btnEditar.Effect_1_Transparency = 25;
            btnEditar.Effect_2 = true;
            btnEditar.Effect_2_ColorBackground = Color.White;
            btnEditar.Effect_2_Transparency = 20;
            btnEditar.Font = new Font("Arial", 11F);
            btnEditar.ForeColor = Color.FromArgb(245, 245, 245);
            btnEditar.Lighting = false;
            btnEditar.LinearGradient_Background = false;
            btnEditar.LinearGradientPen = false;
            btnEditar.Location = new Point(842, 460);
            btnEditar.Name = "btnEditar";
            btnEditar.PenWidth = 15;
            btnEditar.Rounding = true;
            btnEditar.RoundingInt = 70;
            btnEditar.Size = new Size(195, 75);
            btnEditar.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnEditar.TabIndex = 5;
            btnEditar.Tag = "Cyber";
            btnEditar.TextButton = "# Editar";
            btnEditar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnEditar.Timer_Effect_1 = 5;
            btnEditar.Timer_RGB = 300;
            // 
            // btnExcluir
            // 
            btnExcluir.Alpha = 20;
            btnExcluir.BackColor = Color.Transparent;
            btnExcluir.Background = true;
            btnExcluir.Background_WidthPen = 4F;
            btnExcluir.BackgroundPen = true;
            btnExcluir.ColorBackground = Color.FromArgb(37, 52, 68);
            btnExcluir.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            btnExcluir.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            btnExcluir.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            btnExcluir.ColorLighting = Color.FromArgb(29, 200, 238);
            btnExcluir.ColorPen_1 = Color.FromArgb(37, 52, 68);
            btnExcluir.ColorPen_2 = Color.FromArgb(41, 63, 86);
            btnExcluir.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            btnExcluir.Effect_1 = true;
            btnExcluir.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            btnExcluir.Effect_1_Transparency = 25;
            btnExcluir.Effect_2 = true;
            btnExcluir.Effect_2_ColorBackground = Color.White;
            btnExcluir.Effect_2_Transparency = 20;
            btnExcluir.Font = new Font("Arial", 11F);
            btnExcluir.ForeColor = Color.FromArgb(245, 245, 245);
            btnExcluir.Lighting = false;
            btnExcluir.LinearGradient_Background = false;
            btnExcluir.LinearGradientPen = false;
            btnExcluir.Location = new Point(641, 460);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.PenWidth = 15;
            btnExcluir.Rounding = true;
            btnExcluir.RoundingInt = 70;
            btnExcluir.Size = new Size(195, 75);
            btnExcluir.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnExcluir.TabIndex = 6;
            btnExcluir.Tag = "Cyber";
            btnExcluir.TextButton = "X Excluir";
            btnExcluir.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnExcluir.Timer_Effect_1 = 5;
            btnExcluir.Timer_RGB = 300;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // FrmCardapio
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1049, 538);
            Controls.Add(btnExcluir);
            Controls.Add(btnEditar);
            Controls.Add(dgvCardapio);
            Controls.Add(btnNovo);
            Controls.Add(txtPesquisar);
            Controls.Add(btnVoltar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmCardapio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cardapio";
            Load += FrmCardapio_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCardapio).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.CyberButton btnVoltar;
        private ReaLTaiizor.Controls.CyberTextBox txtPesquisar;
        private ReaLTaiizor.Controls.CyberButton btnNovo;
        private DataGridView dgvCardapio;
        private ReaLTaiizor.Controls.CyberButton btnEditar;
        private ReaLTaiizor.Controls.CyberButton btnExcluir;
    }
}