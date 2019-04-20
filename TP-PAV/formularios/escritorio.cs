﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_PAV.formularios;

namespace TP_PAV
{
    public partial class Escritorio : Form
    {
        public Escritorio()
        {
            InitializeComponent();
            SidePanel.Hide();
           
        }

        private void btn_menuPedidos_Click(object sender, EventArgs e)
        {
            SidePanel.Show();
            SidePanel.Height = btn_menuPedidos.Height;
            SidePanel.Top = btn_menuPedidos.Top;
         
        }

      

        private void btn_menuProductos_Click(object sender, EventArgs e)
        {
            //FORMA 1
            uc_ABM_Producto uc_producto = new uc_ABM_Producto();
            SidePanel.Show();
            SidePanel.Height = btn_menuProductos.Height;
            SidePanel.Top = btn_menuProductos.Top;
            if (!main_panel.Controls.Contains(uc_producto))
            {
                main_panel.Controls.Add(uc_producto);
                uc_producto.BringToFront();
               

            }
            else
            {
                uc_producto.BringToFront();
             
            }
          // frm_ABM_Producto frm_producto = new frm_ABM_Producto();
           //frm_producto.ShowDialog();
            
        }

        private void btn_menuVendedores_Click(object sender, EventArgs e)
        {
            SidePanel.Show();
            SidePanel.Height = btn_menuVendedores.Height;
            SidePanel.Top = btn_menuVendedores.Top;
           
        }

        private void btn_menuFranquicias_Click(object sender, EventArgs e)
        {
            //FORMA 2 VER codigo uc_abm_franquicia
            SidePanel.Show();
            SidePanel.Height = btn_menuFranquicias.Height;
            SidePanel.Top = btn_menuFranquicias.Top;
            
             if (!main_panel.Controls.Contains(uc_ABM_Franquicia.pub_instance))
            {
                main_panel.Controls.Add(uc_ABM_Franquicia.pub_instance);
                uc_ABM_Franquicia.pub_instance.BringToFront();
                

            }
            else
            {
                uc_ABM_Franquicia.pub_instance.BringToFront();
                
            
            }
        }

        private void btn_menuEstadisticas_Click(object sender, EventArgs e)
        {
            SidePanel.Show();
            SidePanel.Height = btn_menuEstadisticas.Height;
            SidePanel.Top = btn_menuEstadisticas.Top;
        }

        private void btn_menuReportes_Click(object sender, EventArgs e)
        {
            SidePanel.Show();
            SidePanel.Height = btn_menuReportes.Height;
            SidePanel.Top = btn_menuReportes.Top;
        }

        

    }
}
