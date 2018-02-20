﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Admeli.AlmacenBox;

namespace Admeli.Navigation
{
    public partial class UCAlmacenN : UserControl
    {
        private FormPrincipal formPrincipal;
        private UCGuiaRemision uCGuiaRemision;
        private UCNotaEntrada uCNotaEntrada;
        private UCNotaSalida uCNotaSalida;

        public UCAlmacenN()
        {
            InitializeComponent();
        }

        public UCAlmacenN(FormPrincipal formPrincipal)
        {
            InitializeComponent();
            this.formPrincipal = formPrincipal;
        }

        private void togglePanelMain(string panelName)
        {
            this.limpiarControles();
            switch (panelName)
            {
                case "guiaRemision":
                    if (uCGuiaRemision == null)
                    {
                        this.uCGuiaRemision = new Admeli.AlmacenBox.UCGuiaRemision(this.formPrincipal);
                        this.formPrincipal.panelMain.Controls.Add(uCGuiaRemision);
                        this.uCGuiaRemision.Dock = System.Windows.Forms.DockStyle.Fill;
                        this.uCGuiaRemision.Location = new System.Drawing.Point(0, 0);
                        this.uCGuiaRemision.Name = "uCGuiaRemision";
                        this.uCGuiaRemision.Size = new System.Drawing.Size(250, 776);
                        this.uCGuiaRemision.TabIndex = 0;
                    }
                    else
                    {
                        this.formPrincipal.panelMain.Controls.Add(uCGuiaRemision);
                        this.uCGuiaRemision.reLoad();
                    }
                    break;
                case "notaSalida":
                    if (uCNotaSalida == null)
                    {
                        this.uCNotaSalida = new Admeli.AlmacenBox.UCNotaSalida(this.formPrincipal);
                        this.formPrincipal.panelMain.Controls.Add(uCNotaSalida);
                        this.uCNotaSalida.Dock = System.Windows.Forms.DockStyle.Fill;
                        this.uCNotaSalida.Location = new System.Drawing.Point(0, 0);
                        this.uCNotaSalida.Name = "uCNotaSalida";
                        this.uCNotaSalida.Size = new System.Drawing.Size(250, 776);
                        this.uCNotaSalida.TabIndex = 0;
                    }
                    else
                    {
                        this.formPrincipal.panelMain.Controls.Add(uCNotaSalida);
                        this.uCNotaSalida.reLoad();
                    }
                    break;
                case "notaEntrada":
                    if (uCNotaEntrada == null)
                    {
                        this.uCNotaEntrada = new Admeli.AlmacenBox.UCNotaEntrada(this.formPrincipal);
                        this.formPrincipal.panelMain.Controls.Add(uCNotaEntrada);
                        this.uCNotaEntrada.Dock = System.Windows.Forms.DockStyle.Fill;
                        this.uCNotaEntrada.Location = new System.Drawing.Point(0, 0);
                        this.uCNotaEntrada.Name = "uCNotaEntrada";
                        this.uCNotaEntrada.Size = new System.Drawing.Size(250, 776);
                        this.uCNotaEntrada.TabIndex = 0;

                    }
                    else
                    {
                        this.formPrincipal.panelMain.Controls.Add(uCNotaEntrada);
                        this.uCNotaEntrada.reLoad();
                    }
                    break;
                default:
                    break;
            }
        }

        private void limpiarControles()
        {
            this.formPrincipal.panelMain.Controls.Clear();
            this.formPrincipal.panelMenuRight.Size = new Size(0, this.formPrincipal.panelMenuRight.Size.Height);
            if (uCGuiaRemision != null) uCGuiaRemision.lisenerKeyEvents = false;
            if (uCNotaEntrada != null) uCNotaEntrada.lisenerKeyEvents = false;
            if (uCNotaEntrada != null) uCNotaEntrada.lisenerKeyEvents = false;
        }

        private void btnColor()
        {
            /// Reset Color buttons
            btnNotaEntrada.Textcolor = Color.FromArgb(139, 138, 141);
            btnNotaSalida.Textcolor = Color.FromArgb(139, 138, 141);
            btnGuiaRemision.Textcolor = Color.FromArgb(139, 138, 141);
        }

        private void btnNotaSalida_Click(object sender, EventArgs e)
        {
            btnColor(); // Color reset
            togglePanelMain("notaSalida");
            btnNotaSalida.Textcolor = Color.FromArgb(23, 203, 34); /// Color
        }

        private void btnNotaEntrada_Click(object sender, EventArgs e)
        {
            btnColor(); // Color reset
            togglePanelMain("notaEntrada");
            btnNotaEntrada.Textcolor = Color.FromArgb(23, 203, 34); /// Color
        }

        private void btnGuiaRemision_Click(object sender, EventArgs e)
        {
            btnColor(); // Color reset
            togglePanelMain("guiaRemision");
            btnGuiaRemision.Textcolor = Color.FromArgb(23, 203, 34); /// Color
        }
    }
}