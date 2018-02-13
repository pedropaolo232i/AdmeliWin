﻿namespace Admeli
{
    partial class FormPrincipal
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
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.panelHeader = new System.Windows.Forms.Panel();
            this.panelAsideMain = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCompras = new System.Windows.Forms.Button();
            this.btnHerramientas = new System.Windows.Forms.Button();
            this.btnConfiguracion = new System.Windows.Forms.Button();
            this.btnProducto = new System.Windows.Forms.Button();
            this.btnAlmacen = new System.Windows.Forms.Button();
            this.btnCaja = new System.Windows.Forms.Button();
            this.btnVentas = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnDownUp = new System.Windows.Forms.PictureBox();
            this.btnFullScreen = new System.Windows.Forms.PictureBox();
            this.lblUsuarioName = new System.Windows.Forms.Label();
            this.btnCerrarSesion = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.transition1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.panelAside = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSucursalName = new System.Windows.Forms.Label();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.lblDNI = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblUsuarioNombre = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panelMainContainer = new System.Windows.Forms.Panel();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBarApp = new System.Windows.Forms.ProgressBar();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panelHeader.SuspendLayout();
            this.panel2.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnDownUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFullScreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarSesion)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            this.panelAside.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelMainContainer.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(250)))), ((int)(((byte)(237)))));
            this.panelHeader.Controls.Add(this.panelAsideMain);
            this.panelHeader.Controls.Add(this.panel2);
            this.transition1.SetDecoration(this.panelHeader, BunifuAnimatorNS.DecorationType.None);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(2);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.panelHeader.Size = new System.Drawing.Size(907, 118);
            this.panelHeader.TabIndex = 4;
            this.panelHeader.Visible = false;
            this.panelHeader.Paint += new System.Windows.Forms.PaintEventHandler(this.panelAside_Paint);
            // 
            // panelAsideMain
            // 
            this.panelAsideMain.BackColor = System.Drawing.Color.White;
            this.transition1.SetDecoration(this.panelAsideMain, BunifuAnimatorNS.DecorationType.None);
            this.panelAsideMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAsideMain.Location = new System.Drawing.Point(0, 40);
            this.panelAsideMain.Margin = new System.Windows.Forms.Padding(2);
            this.panelAsideMain.Name = "panelAsideMain";
            this.panelAsideMain.Size = new System.Drawing.Size(907, 77);
            this.panelAsideMain.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(102)))), ((int)(((byte)(179)))));
            this.panel2.Controls.Add(this.flowLayoutPanel2);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel4);
            this.transition1.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(907, 40);
            this.panel2.TabIndex = 0;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.btnCompras);
            this.flowLayoutPanel2.Controls.Add(this.btnHerramientas);
            this.flowLayoutPanel2.Controls.Add(this.btnConfiguracion);
            this.flowLayoutPanel2.Controls.Add(this.btnProducto);
            this.flowLayoutPanel2.Controls.Add(this.btnAlmacen);
            this.flowLayoutPanel2.Controls.Add(this.btnCaja);
            this.flowLayoutPanel2.Controls.Add(this.btnVentas);
            this.transition1.SetDecoration(this.flowLayoutPanel2, BunifuAnimatorNS.DecorationType.None);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(43, 0);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(675, 40);
            this.flowLayoutPanel2.TabIndex = 4;
            // 
            // btnCompras
            // 
            this.transition1.SetDecoration(this.btnCompras, BunifuAnimatorNS.DecorationType.None);
            this.btnCompras.FlatAppearance.BorderSize = 0;
            this.btnCompras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompras.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompras.ForeColor = System.Drawing.Color.White;
            this.btnCompras.Location = new System.Drawing.Point(0, 10);
            this.btnCompras.Margin = new System.Windows.Forms.Padding(0);
            this.btnCompras.Name = "btnCompras";
            this.btnCompras.Size = new System.Drawing.Size(98, 30);
            this.btnCompras.TabIndex = 1;
            this.btnCompras.Text = "Compras";
            this.btnCompras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTip1.SetToolTip(this.btnCompras, "Compra");
            this.btnCompras.UseVisualStyleBackColor = true;
            this.btnCompras.Click += new System.EventHandler(this.btnCompras_Click);
            // 
            // btnHerramientas
            // 
            this.transition1.SetDecoration(this.btnHerramientas, BunifuAnimatorNS.DecorationType.None);
            this.btnHerramientas.FlatAppearance.BorderSize = 0;
            this.btnHerramientas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHerramientas.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHerramientas.ForeColor = System.Drawing.Color.White;
            this.btnHerramientas.Location = new System.Drawing.Point(98, 10);
            this.btnHerramientas.Margin = new System.Windows.Forms.Padding(0);
            this.btnHerramientas.Name = "btnHerramientas";
            this.btnHerramientas.Size = new System.Drawing.Size(98, 30);
            this.btnHerramientas.TabIndex = 7;
            this.btnHerramientas.Text = "Herramientas";
            this.btnHerramientas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTip1.SetToolTip(this.btnHerramientas, "Herramientas");
            this.btnHerramientas.UseVisualStyleBackColor = true;
            this.btnHerramientas.Click += new System.EventHandler(this.btnTools_Click);
            // 
            // btnConfiguracion
            // 
            this.transition1.SetDecoration(this.btnConfiguracion, BunifuAnimatorNS.DecorationType.None);
            this.btnConfiguracion.FlatAppearance.BorderSize = 0;
            this.btnConfiguracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfiguracion.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfiguracion.ForeColor = System.Drawing.Color.White;
            this.btnConfiguracion.Location = new System.Drawing.Point(196, 10);
            this.btnConfiguracion.Margin = new System.Windows.Forms.Padding(0);
            this.btnConfiguracion.Name = "btnConfiguracion";
            this.btnConfiguracion.Size = new System.Drawing.Size(98, 30);
            this.btnConfiguracion.TabIndex = 6;
            this.btnConfiguracion.Text = "Configuracion";
            this.btnConfiguracion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTip1.SetToolTip(this.btnConfiguracion, "Configuracion");
            this.btnConfiguracion.UseVisualStyleBackColor = true;
            this.btnConfiguracion.Click += new System.EventHandler(this.btnConfig_Click);
            // 
            // btnProducto
            // 
            this.transition1.SetDecoration(this.btnProducto, BunifuAnimatorNS.DecorationType.None);
            this.btnProducto.FlatAppearance.BorderSize = 0;
            this.btnProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProducto.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProducto.ForeColor = System.Drawing.Color.White;
            this.btnProducto.Location = new System.Drawing.Point(294, 10);
            this.btnProducto.Margin = new System.Windows.Forms.Padding(0);
            this.btnProducto.Name = "btnProducto";
            this.btnProducto.Size = new System.Drawing.Size(98, 30);
            this.btnProducto.TabIndex = 5;
            this.btnProducto.Text = "Producto";
            this.btnProducto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTip1.SetToolTip(this.btnProducto, "Producto");
            this.btnProducto.UseVisualStyleBackColor = true;
            this.btnProducto.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // btnAlmacen
            // 
            this.transition1.SetDecoration(this.btnAlmacen, BunifuAnimatorNS.DecorationType.None);
            this.btnAlmacen.FlatAppearance.BorderSize = 0;
            this.btnAlmacen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlmacen.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlmacen.ForeColor = System.Drawing.Color.White;
            this.btnAlmacen.Location = new System.Drawing.Point(392, 10);
            this.btnAlmacen.Margin = new System.Windows.Forms.Padding(0);
            this.btnAlmacen.Name = "btnAlmacen";
            this.btnAlmacen.Size = new System.Drawing.Size(98, 30);
            this.btnAlmacen.TabIndex = 4;
            this.btnAlmacen.Text = "Almacen";
            this.btnAlmacen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTip1.SetToolTip(this.btnAlmacen, "Almacen");
            this.btnAlmacen.UseVisualStyleBackColor = true;
            this.btnAlmacen.Click += new System.EventHandler(this.btnAlmacen_Click);
            // 
            // btnCaja
            // 
            this.transition1.SetDecoration(this.btnCaja, BunifuAnimatorNS.DecorationType.None);
            this.btnCaja.FlatAppearance.BorderSize = 0;
            this.btnCaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCaja.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCaja.ForeColor = System.Drawing.Color.White;
            this.btnCaja.Location = new System.Drawing.Point(490, 10);
            this.btnCaja.Margin = new System.Windows.Forms.Padding(0);
            this.btnCaja.Name = "btnCaja";
            this.btnCaja.Size = new System.Drawing.Size(98, 30);
            this.btnCaja.TabIndex = 3;
            this.btnCaja.Text = "Caja";
            this.btnCaja.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTip1.SetToolTip(this.btnCaja, "Caja");
            this.btnCaja.UseVisualStyleBackColor = true;
            this.btnCaja.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnVentas
            // 
            this.transition1.SetDecoration(this.btnVentas, BunifuAnimatorNS.DecorationType.None);
            this.btnVentas.FlatAppearance.BorderSize = 0;
            this.btnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVentas.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVentas.ForeColor = System.Drawing.Color.White;
            this.btnVentas.Location = new System.Drawing.Point(588, 10);
            this.btnVentas.Margin = new System.Windows.Forms.Padding(0);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(98, 30);
            this.btnVentas.TabIndex = 2;
            this.btnVentas.Text = "Ventas";
            this.btnVentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTip1.SetToolTip(this.btnVentas, "Venta");
            this.btnVentas.UseVisualStyleBackColor = true;
            this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnDownUp);
            this.panel6.Controls.Add(this.btnFullScreen);
            this.panel6.Controls.Add(this.lblUsuarioName);
            this.panel6.Controls.Add(this.btnCerrarSesion);
            this.transition1.SetDecoration(this.panel6, BunifuAnimatorNS.DecorationType.None);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(718, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(189, 40);
            this.panel6.TabIndex = 3;
            // 
            // btnDownUp
            // 
            this.btnDownUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transition1.SetDecoration(this.btnDownUp, BunifuAnimatorNS.DecorationType.None);
            this.btnDownUp.Image = ((System.Drawing.Image)(resources.GetObject("btnDownUp.Image")));
            this.btnDownUp.Location = new System.Drawing.Point(2, 0);
            this.btnDownUp.Margin = new System.Windows.Forms.Padding(2);
            this.btnDownUp.Name = "btnDownUp";
            this.btnDownUp.Size = new System.Drawing.Size(30, 40);
            this.btnDownUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnDownUp.TabIndex = 11;
            this.btnDownUp.TabStop = false;
            this.toolTip1.SetToolTip(this.btnDownUp, "Ocular Y Mostrar La barra de herramientas");
            this.btnDownUp.Click += new System.EventHandler(this.btnDownUp_Click);
            // 
            // btnFullScreen
            // 
            this.btnFullScreen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transition1.SetDecoration(this.btnFullScreen, BunifuAnimatorNS.DecorationType.None);
            this.btnFullScreen.Image = ((System.Drawing.Image)(resources.GetObject("btnFullScreen.Image")));
            this.btnFullScreen.Location = new System.Drawing.Point(31, 0);
            this.btnFullScreen.Margin = new System.Windows.Forms.Padding(2);
            this.btnFullScreen.Name = "btnFullScreen";
            this.btnFullScreen.Size = new System.Drawing.Size(30, 40);
            this.btnFullScreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnFullScreen.TabIndex = 10;
            this.btnFullScreen.TabStop = false;
            this.toolTip1.SetToolTip(this.btnFullScreen, "Pantalla completa");
            this.btnFullScreen.Click += new System.EventHandler(this.btnFullScreen_Click);
            // 
            // lblUsuarioName
            // 
            this.transition1.SetDecoration(this.lblUsuarioName, BunifuAnimatorNS.DecorationType.None);
            this.lblUsuarioName.ForeColor = System.Drawing.Color.White;
            this.lblUsuarioName.Location = new System.Drawing.Point(96, 14);
            this.lblUsuarioName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsuarioName.Name = "lblUsuarioName";
            this.lblUsuarioName.Size = new System.Drawing.Size(90, 12);
            this.lblUsuarioName.TabIndex = 0;
            this.lblUsuarioName.Text = "label9";
            this.lblUsuarioName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip1.SetToolTip(this.lblUsuarioName, "Nombre usuario");
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transition1.SetDecoration(this.btnCerrarSesion, BunifuAnimatorNS.DecorationType.None);
            this.btnCerrarSesion.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrarSesion.Image")));
            this.btnCerrarSesion.Location = new System.Drawing.Point(65, 0);
            this.btnCerrarSesion.Margin = new System.Windows.Forms.Padding(2);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(27, 40);
            this.btnCerrarSesion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnCerrarSesion.TabIndex = 9;
            this.btnCerrarSesion.TabStop = false;
            this.toolTip1.SetToolTip(this.btnCerrarSesion, "Cerrar sesión");
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnHome);
            this.transition1.SetDecoration(this.panel4, BunifuAnimatorNS.DecorationType.None);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(43, 40);
            this.panel4.TabIndex = 2;
            // 
            // btnHome
            // 
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transition1.SetDecoration(this.btnHome, BunifuAnimatorNS.DecorationType.None);
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.Location = new System.Drawing.Point(0, 0);
            this.btnHome.Margin = new System.Windows.Forms.Padding(0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(43, 40);
            this.btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnHome.TabIndex = 8;
            this.btnHome.TabStop = false;
            this.toolTip1.SetToolTip(this.btnHome, "Menu Principal");
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // transition1
            // 
            this.transition1.AnimationType = BunifuAnimatorNS.AnimationType.HorizBlind;
            this.transition1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.transition1.DefaultAnimation = animation1;
            this.transition1.TimeStep = 0.03F;
            // 
            // panelAside
            // 
            this.panelAside.AutoScroll = true;
            this.panelAside.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelAside.Controls.Add(this.panel1);
            this.transition1.SetDecoration(this.panelAside, BunifuAnimatorNS.DecorationType.None);
            this.panelAside.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelAside.Location = new System.Drawing.Point(0, 128);
            this.panelAside.Name = "panelAside";
            this.panelAside.Size = new System.Drawing.Size(200, 498);
            this.panelAside.TabIndex = 5;
            this.panelAside.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblSucursalName);
            this.panel1.Controls.Add(this.bunifuSeparator1);
            this.panel1.Controls.Add(this.lblDNI);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.lblUsuarioNombre);
            this.panel1.Controls.Add(this.label4);
            this.transition1.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 180);
            this.panel1.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.transition1.SetDecoration(this.label3, BunifuAnimatorNS.DecorationType.None);
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(183)))));
            this.label3.Location = new System.Drawing.Point(5, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Información General";
            // 
            // lblSucursalName
            // 
            this.transition1.SetDecoration(this.lblSucursalName, BunifuAnimatorNS.DecorationType.None);
            this.lblSucursalName.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSucursalName.Location = new System.Drawing.Point(9, 141);
            this.lblSucursalName.Name = "lblSucursalName";
            this.lblSucursalName.Size = new System.Drawing.Size(178, 32);
            this.lblSucursalName.TabIndex = 8;
            this.lblSucursalName.Text = "SUCURSAL";
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.transition1.SetDecoration(this.bunifuSeparator1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(0, 115);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(197, 35);
            this.bunifuSeparator1.TabIndex = 6;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.transition1.SetDecoration(this.lblDNI, BunifuAnimatorNS.DecorationType.None);
            this.lblDNI.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDNI.Location = new System.Drawing.Point(13, 102);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(28, 16);
            this.lblDNI.TabIndex = 7;
            this.lblDNI.Text = "DNI";
            // 
            // pictureBox2
            // 
            this.transition1.SetDecoration(this.pictureBox2, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(9, 33);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(68, 75);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // lblUsuarioNombre
            // 
            this.transition1.SetDecoration(this.lblUsuarioNombre, BunifuAnimatorNS.DecorationType.None);
            this.lblUsuarioNombre.ForeColor = System.Drawing.Color.Gray;
            this.lblUsuarioNombre.Location = new System.Drawing.Point(75, 69);
            this.lblUsuarioNombre.Name = "lblUsuarioNombre";
            this.lblUsuarioNombre.Size = new System.Drawing.Size(104, 29);
            this.lblUsuarioNombre.TabIndex = 4;
            this.lblUsuarioNombre.Text = "Usuario";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.transition1.SetDecoration(this.label4, BunifuAnimatorNS.DecorationType.None);
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(75, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Nombres Y Apellidos";
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.Gainsboro;
            this.transition1.SetDecoration(this.splitter1, BunifuAnimatorNS.DecorationType.None);
            this.splitter1.Location = new System.Drawing.Point(200, 128);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(2, 498);
            this.splitter1.TabIndex = 6;
            this.splitter1.TabStop = false;
            // 
            // panelMainContainer
            // 
            this.panelMainContainer.Controls.Add(this.panelMain);
            this.transition1.SetDecoration(this.panelMainContainer, BunifuAnimatorNS.DecorationType.None);
            this.panelMainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMainContainer.Location = new System.Drawing.Point(202, 128);
            this.panelMainContainer.Name = "panelMainContainer";
            this.panelMainContainer.Size = new System.Drawing.Size(705, 498);
            this.panelMainContainer.TabIndex = 7;
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.panel5);
            this.transition1.SetDecoration(this.panelMain, BunifuAnimatorNS.DecorationType.None);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Margin = new System.Windows.Forms.Padding(2);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(705, 498);
            this.panelMain.TabIndex = 5;
            // 
            // panel5
            // 
            this.panel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel5.Controls.Add(this.pictureBox1);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.label1);
            this.transition1.SetDecoration(this.panel5, BunifuAnimatorNS.DecorationType.None);
            this.panel5.Location = new System.Drawing.Point(151, 144);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(402, 210);
            this.panel5.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.transition1.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(74, 6);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(254, 146);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.transition1.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(54, 184);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(295, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "punto de venta y tienda en linea";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.transition1.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(102)))), ((int)(((byte)(179)))));
            this.label1.Location = new System.Drawing.Point(58, 154);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "admeli";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // progressBarApp
            // 
            this.progressBarApp.BackColor = System.Drawing.Color.White;
            this.transition1.SetDecoration(this.progressBarApp, BunifuAnimatorNS.DecorationType.BottomMirror);
            this.progressBarApp.Dock = System.Windows.Forms.DockStyle.Top;
            this.progressBarApp.Enabled = false;
            this.progressBarApp.Location = new System.Drawing.Point(0, 118);
            this.progressBarApp.Margin = new System.Windows.Forms.Padding(2);
            this.progressBarApp.MarqueeAnimationSpeed = 10;
            this.progressBarApp.Maximum = 200;
            this.progressBarApp.Name = "progressBarApp";
            this.progressBarApp.RightToLeftLayout = true;
            this.progressBarApp.Size = new System.Drawing.Size(907, 10);
            this.progressBarApp.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBarApp.TabIndex = 4;
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 200;
            this.toolTip1.AutoPopDelay = 20000;
            this.toolTip1.InitialDelay = 200;
            this.toolTip1.ReshowDelay = 40;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Admeli";
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = null;
            this.bunifuDragControl1.Vertical = true;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "left_blue_icon.png");
            this.imageList1.Images.SetKeyName(1, "right_blue_icon.png");
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(907, 626);
            this.Controls.Add(this.panelMainContainer);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panelAside);
            this.Controls.Add(this.progressBarApp);
            this.Controls.Add(this.panelHeader);
            this.transition1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admeli 0.0.0.1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.panelHeader.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnDownUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFullScreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarSesion)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            this.panelAside.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelMainContainer.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCompras;
        private System.Windows.Forms.Button btnVentas;
        private System.Windows.Forms.Button btnCaja;
        private System.Windows.Forms.Button btnAlmacen;
        private System.Windows.Forms.Button btnProducto;
        private System.Windows.Forms.Button btnConfiguracion;
        private System.Windows.Forms.Button btnHerramientas;
        private System.Windows.Forms.Label lblUsuarioName;
        public System.Windows.Forms.Panel panelHeader;
        private BunifuAnimatorNS.BunifuTransition transition1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox btnCerrarSesion;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel4;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        internal System.Windows.Forms.PictureBox btnHome;
        private System.Windows.Forms.PictureBox btnFullScreen;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel panelAside;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panelMainContainer;
        public System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        protected System.Windows.Forms.ProgressBar progressBarApp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelAsideMain;
        private System.Windows.Forms.PictureBox btnDownUp;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblUsuarioNombre;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblSucursalName;
    }
}