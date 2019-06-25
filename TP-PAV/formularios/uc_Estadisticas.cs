﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using TP_PAV.clases;

namespace TP_PAV.formularios
{
    public partial class uc_Estadisticas : UserControl
    {
        Vendedor vendedor = new Vendedor();
        Franquicia franquicia = new Franquicia();
        Producto producto = new Producto();
        Pedido pedido = new Pedido();
        private static uc_Estadisticas priv_instance;
        public static uc_Estadisticas pub_instance
        {
            get
            {
                if (priv_instance == null)
                    priv_instance = new uc_Estadisticas();
                return priv_instance;
            }

        }
        public uc_Estadisticas()
        {
            InitializeComponent();
        }

        private void uc_Reportes_Load(object sender, EventArgs e)
        {
            grafico.Series.Clear();
        }

        private void llenarGrafico(DataTable tablaDatos, string titulo, string tituloLeyenda)
        {
            if (tablaDatos.Rows.Count < 1)
            {
                lbl_mensaje.ForeColor = Color.Red;
                lbl_mensaje.Text = "No ha sido posible recuperar los datos";
                return;
            }
            grafico.Series.Clear();
            grafico.Titles.Clear();
            grafico.Palette = ChartColorPalette.SeaGreen;
            grafico.Titles.Add(titulo);

            
            List<string> series = new List<string> { };
            List<int> puntos = new List<int> { };

            for (int i = 0; i < tablaDatos.Rows.Count; i++)
            {
                series.Add(tablaDatos.Rows[i][0].ToString());
                puntos.Add(int.Parse(tablaDatos.Rows[i][1].ToString()));
            }
            for (int i = 0; i < series.Count; i++)
            {
                Series serie;
                serie = grafico.Series.Add(series[i].ToString());
                serie.Label = "$ " + puntos[i].ToString();
                serie.Points.Add(puntos[i]);
            }
            
            grafico.ChartAreas[0].AxisY.Minimum = 0;
            grafico.ChartAreas[0].AxisY.Maximum = (puntos.Max() - puntos.Max() % 1000) + 1000;
      
        }
        private void visibilidadFechas(bool estado){

            dtp_fechaHasta.Visible = estado;
            dtp_fechaDesde.Visible = estado;
            lbl_fechaDesde.Visible = estado;
            lbl_fechaHasta.Visible = estado;

        }
        //Para no hacer tantos grupos puse todos en el mismo grupo, pero solo muestra las opciones que corresponde segun el boton que tocan
        private void btn_estVendedores_Click(object sender, EventArgs e)
        {
            grp_estadisticas.Text = "Estadisticas de Vendedores";
            grp_estadisticas.Visible = true;
            btn_estFranquicias.Visible = false;
            btn_estPedidos.Visible = false;
            btn_estProductos.Visible = false;
            //Activar la visibilidad de sus botones que muestran la estadistica 
            btn_EstadisticaVendedorPedidos.Visible = true;
        }

        private void btn_estFranquicias_Click(object sender, EventArgs e)
        {
            grp_estadisticas.Text = "Estadisticas de Franquicias";
            grp_estadisticas.Visible = true;
            btn_estVendedores.Visible = false;
            btn_estPedidos.Visible = false;
            btn_estProductos.Visible = false;
            //Activar la visibilidad de sus botones que muestran la estadistica 
            visibilidadFechas(true);
            btn_franquiciaMasPedidosHistorico.Visible = true;
            btn_franquiciaMasPedidosEnPeriodo.Visible = true;
            btn_franquiciaMenosPedidosEnPeriodo.Visible = true;
            btn_franquiciaMenosPedidosHistorico.Visible = true;
        }

        private void btn_estProductos_Click(object sender, EventArgs e)
        {
            grp_estadisticas.Text = "Estadisticas de Productos";
            grp_estadisticas.Visible = true;
            btn_estVendedores.Visible = false;
            btn_estPedidos.Visible = false;
            btn_estFranquicias.Visible = false;
            //Activar la visibilidad de sus botones que muestran la estadistica 
            btn_productoMasVendido.Visible = true;
            btn_productoMasVendidoPeriodo.Visible = true;
            visibilidadFechas(true);
        }

        private void btn_estPedidos_Click(object sender, EventArgs e)
        {
            grp_estadisticas.Text = "Estadisticas de Pedidos";
            grp_estadisticas.Visible = true;
            btn_estVendedores.Visible = false;
            btn_estProductos.Visible = false;
            btn_estFranquicias.Visible = false;
            //Activar la visibilidad de sus botones que muestran la estadistica 
            btn_EstadisticaCantPedidosPend.Visible = true;
            visibilidadFechas(true);
        }

        private void btn_cerrarGrupo_Click(object sender, EventArgs e)
        {
            //Si quieren pueden hacer un ciclo que lo automatice pero un viaje
            btn_estVendedores.Visible = true;
            btn_estFranquicias.Visible = true;
            btn_estPedidos.Visible = true;
            btn_estProductos.Visible = true;
            //Hay que sacarle la visibilidad a todos los botones del grupo si no cuando 
            //abrimos otra opcion sigue quedando el boton de la opcion anterior
            btn_franquiciaMenosPedidosHistorico.Visible = false;
            btn_franquiciaMenosPedidosEnPeriodo.Visible = false;
            btn_franquiciaMasPedidosEnPeriodo.Visible = false;
            btn_franquiciaMasPedidosHistorico.Visible = false;
            btn_EstadisticaVendedorPedidos.Visible = false;
            btn_productoMasVendido.Visible = false;
            btn_EstadisticaCantPedidosPend.Visible = false;
            grp_estadisticas.Visible = false;
            grp_estadisticas.Text = "";
            visibilidadFechas(false);
        }


        private bool validarFechas()
        {
            
            if (dtp_fechaHasta.Value.Date < dtp_fechaDesde.Value.Date)
            {
                lbl_mensaje.ForeColor = Color.Red;
                lbl_mensaje.Text = "No se puede seleccionar una Fecha Hasta menor a la Fecha Desde.";
                return false;
            }
            if (dtp_fechaHasta.Value.Date > DateTime.Now.Date)
            {
                lbl_mensaje.ForeColor = Color.Red;
                lbl_mensaje.Text = "No se puede seleccionar una Fecha Hasta mayor a la fecha actual.";
                return false;
            }
            return true;
        }

        private void btn_EstadisticaVendedorPedidos_Click(object sender, EventArgs e)
        {
            llenarGrafico(vendedor.MejoresVendedores(), "MEJORES VENDEDORES: ","Nombre y apellido del vendedor");
        }

        private void btn_productoMasVendido_Click(object sender, EventArgs e)
        {
            llenarGrafico(producto.productosMasVendidosHistorico(), "PRODUCTOS MAS VENDIDOS", "Nombre del producto");
        }

        private void btn_EstadisticaCantPedidosPend_Click(object sender, EventArgs e)
        {
            llenarGrafico(pedido.CantidadPedidoXRangoFecha(dtp_fechaDesde.Value, dtp_fechaHasta.Value, 1), "CANTIDAD DE PEDIDOS PENDIENTES", "Mes y cantidad de pedidos");
        }

        private void btn_productoMasVendidoPeriodo_Click(object sender, EventArgs e)
        {
            if(validarFechas())
            {
                llenarGrafico(producto.ProductosMasVendidosXTiempo(dtp_fechaDesde.Value.Date.ToShortDateString(), 
                    dtp_fechaHasta.Value.Date.ToShortDateString()),
                    "PRODUCTOS MAS VENDIDOS EN UN PERIODO", "Nombre del producto");
            }
        }

        private void btn_franquiciaMasPedidosHistorico_Click(object sender, EventArgs e)
        {
            llenarGrafico(franquicia.MejoresFranquicias(), "MEJORES FRANQUICIAS: ", "Nombre y apellido del representante");
        }

        private void btn_franquiciaMenosPedidosHistorico_Click(object sender, EventArgs e)
        {
            llenarGrafico(franquicia.PeoresFranquicias(), "PEORES FRANQUICIAS: ", "Nombre y apellido del representante");
        }

        private void btn_franquiciaMenosPedidosEnPeriodo_Click(object sender, EventArgs e)
        {
            if (validarFechas())
            {
                llenarGrafico(franquicia.PeoresFranquicias(dtp_fechaDesde.Value, dtp_fechaHasta.Value), "PEORES FRANQUICIAS EN PERIODO: ", "Nombre y apellido del representante");
            }
        }

        private void btn_franquiciaMasPedidosEnPeriodo_Click(object sender, EventArgs e)
        {
            if (validarFechas())
            {
                llenarGrafico(franquicia.MejoresFranquicias(dtp_fechaDesde.Value, dtp_fechaHasta.Value), "MEJORES FRANQUICIAS EN PERIODO:", "Nombre y apellido del representante");
            }
        }


    }
}
