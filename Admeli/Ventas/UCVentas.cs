﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Admeli.Componentes;
using Admeli.Ventas.Nuevo;
using Modelo;
using Entidad;

namespace Admeli.Ventas
{
    public partial class UCVentas : UserControl
    {
        /**
         *  Web services
         *  http://www.lineatienda.com/services.php/ventas/sucursal/1/puntoventa/0/per/0/estado/todos/1/100
         * 
         * 
         * 
         * */

        private FormPrincipal formPrincipal;
        public bool lisenerKeyEvents { get; set; }
        private Paginacion paginacion;
        private PersonalModel personalModel = new PersonalModel();
        private VentaModel ventaModel = new VentaModel();
        private SucursalModel sucursalModel = new SucursalModel();
        private PuntoVentaModel puntoVentaModel = new PuntoVentaModel();

        public UCVentas()
        {
            InitializeComponent();

            lblSpeedPages.Text = ConfigModel.configuracionGeneral.itemPorPagina.ToString();     // carganto los items por página
            paginacion = new Paginacion(Convert.ToInt32(lblCurrentPage.Text), Convert.ToInt32(lblSpeedPages.Text));
        }

        public UCVentas(FormPrincipal formPrincipal)
        {
            InitializeComponent();
            this.formPrincipal = formPrincipal;

            lblSpeedPages.Text = ConfigModel.configuracionGeneral.itemPorPagina.ToString();     // carganto los items por página
            paginacion = new Paginacion(Convert.ToInt32(lblCurrentPage.Text), Convert.ToInt32(lblSpeedPages.Text));
        }

        private void UCVentas_Load(object sender, EventArgs e)
        {
            cargarComponentes();
            cargarComponentesSecond();
            cargarComponentesThird();
            cargarRegistros();
        }

        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {
            DrawShape drawShape = new DrawShape();
            drawShape.lineBorder(panelContainer);
        }


        #region =========================== Decoration ===========================
        private void decorationDataGridView()
        {
            /*
            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                var estado = dataGridView.Rows[i].Cells.get.Value.ToString();
                dataGridView.Rows[i].DefaultCellStyle.BackColor = Color.DeepPink;
            }*/
        }
        #endregion

        #region ======================= Loads =======================
        private async void cargarComponentes()
        {
            // Cargando el combobox ce estados
            DataTable table = new DataTable();
            table.Columns.Add("idEstado", typeof(string));
            table.Columns.Add("estado", typeof(string));

            table.Rows.Add("todos", "Todos los estados");
            table.Rows.Add("0", "Anulados");
            table.Rows.Add("1", "Activos");

            cbxEstados.ComboBox.DataSource = table;
            cbxEstados.ComboBox.DisplayMember = "estado";
            cbxEstados.ComboBox.ValueMember = "idEstado";
            //cbxEstados.ComboBox.SelectedIndex = 0;

            // Cargando el combobox de personales
            loadState(true);
            try
            {
                cbxPersonales.ComboBox.DataSource = await personalModel.listarPersonalCompras(ConfigModel.sucursal.idSucursal);
                cbxPersonales.ComboBox.DisplayMember = "nombres";
                cbxPersonales.ComboBox.ValueMember = "idPersonal";
                cbxPersonales.ComboBox.SelectedValue = PersonalModel.personal.idPersonal;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Listar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private async void cargarComponentesSecond()
        {
            // cargando los sucursales activos
            loadState(true);
            try
            {
                cbxSucursales.ComboBox.DataSource = await sucursalModel.listarSucursalesActivos();
                cbxSucursales.ComboBox.DisplayMember = "nombre";
                cbxSucursales.ComboBox.ValueMember = "idSucursal";
                cbxSucursales.ComboBox.SelectedValue = ConfigModel.sucursal.idSucursal;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Listar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        
        private async void cargarComponentesThird()
        {
            // cargando los sucursales activos
            loadState(true);
            try
            {
                cbxPuntosVenta.ComboBox.DataSource = await puntoVentaModel.puntoVentasyTodos(ConfigModel.sucursal.idSucursal);
                cbxPuntosVenta.ComboBox.DisplayMember = "nombre";
                cbxPuntosVenta.ComboBox.ValueMember = "idPuntoVenta";
                cbxPuntosVenta.ComboBox.SelectedValue = ConfigModel.currentPuntoVenta;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Listar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        internal void reLoad()
        {
            cargarComponentes();
            cargarComponentesSecond();
            cargarComponentesThird();
            cargarRegistros();
            lisenerKeyEvents = true; // Active lisener key events
        }

        private async void cargarRegistros()
        {
            loadState(true);
            try
            {

                int personalId = (cbxPersonales.SelectedIndex == -1) ? PersonalModel.personal.idPersonal : Convert.ToInt32(cbxPersonales.ComboBox.SelectedValue);
                int sucursalId = (cbxSucursales.SelectedIndex == -1) ? ConfigModel.sucursal.idSucursal : Convert.ToInt32(cbxSucursales.ComboBox.SelectedValue);
                string estado = (cbxEstados.SelectedIndex == -1) ? "todos" : cbxEstados.ComboBox.SelectedValue.ToString();
                int puntoVentaId = (cbxPuntosVenta.SelectedIndex == -1) ? ConfigModel.currentPuntoVenta : Convert.ToInt32(cbxPuntosVenta.ComboBox.SelectedValue);

                RootObject<Venta> ventas = await ventaModel.ventas(sucursalId, puntoVentaId,  personalId, estado, paginacion.currentPage, paginacion.speed);

                // actualizando datos de páginacón
                paginacion.itemsCount = ventas.nro_registros;
                paginacion.reload();

                // Ingresando
                ventaBindingSource.DataSource = ventas.datos;
                dataGridView.Refresh();
                mostrarPaginado();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Listar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                loadState(false);
            }
        }
        #endregion

        #region =========================== Estados ===========================
        private void loadState(bool state)
        {
            formPrincipal.appLoadState(state);
            panelNavigation.Enabled = !state;
            toolStripCrud.Enabled = !state;
            toolStripTools.Enabled = !state;
            dataGridView.Enabled = !state;
        }
        #endregion

        #region ===================== Eventos Páginación =====================
        private void mostrarPaginado()
        {
            lblCurrentPage.Text = paginacion.currentPage.ToString();
            lblPageAllItems.Text = String.Format("{0} Registros", paginacion.itemsCount.ToString());
            lblPageCount.Text = paginacion.pageCount.ToString();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (lblCurrentPage.Text != "1")
            {
                paginacion.previousPage();
                cargarRegistros();
            }
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            if (lblCurrentPage.Text != "1")
            {
                paginacion.firstPage();
                cargarRegistros();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (lblPageCount.Text == "0") return;
            if (lblPageCount.Text != lblCurrentPage.Text)
            {
                paginacion.nextPage();
                cargarRegistros();
            }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            if (lblPageCount.Text == "0") return;
            if (lblPageCount.Text != lblCurrentPage.Text)
            {
                paginacion.lastPage();
                cargarRegistros();
            }
        }

        private void lblSpeedPages_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                paginacion.speed = Convert.ToInt32(lblSpeedPages.Text);
                paginacion.currentPage = 1;
                cargarRegistros();
            }
        }

        private void lblCurrentPage_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                paginacion.reloadPage(Convert.ToInt32(lblCurrentPage.Text));
                cargarRegistros();
            }
        }

        private void lblCurrentPage_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validator.isNumber(e);
        }

        private void lblSpeedPages_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validator.isNumber(e);
        }
        #endregion

        #region ==================== CRUD ====================
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            cargarRegistros();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            cargarRegistros();
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FormVentaNuevo ventaNuevo = new FormVentaNuevo();
            ventaNuevo.ShowDialog();
        }
        private void textBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            //
        }
        #endregion
    }
}
