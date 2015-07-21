﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EC_Admin.Forms
{
    public partial class frmEditarCuenta : Form
    {
        Cuenta c;
        TipoCuenta t;
        public frmEditarCuenta(int id)
        {
            InitializeComponent();
            c = new Cuenta(id);
        }

        private void ObtenerDatos()
        {
            try
            {
                c.ObtenerDatos();
                txtClabe.Text = c.Clabe;
                txtBanco.Text = c.Banco;
                txtBeneficiario.Text = c.Beneficiario;
                txtSucursal.Text = c.Sucursal;
                txtNumCuenta.Text = c.NumeroCuenta;
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al obtener los datos de la cuenta. No se ha podido conectar con la base de datos.", "Admin CSY", ex);
            }
            catch (Exception ex)
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al obtener los datos de la cuenta.", "Admin CSY", ex);
            }
        }

        private void Editar()
        {
            try
            {
                c.Clabe = txtClabe.Text;
                c.Banco = txtBanco.Text;
                c.Beneficiario = txtBeneficiario.Text;
                c.Sucursal = txtSucursal.Text;
                c.NumeroCuenta = txtNumCuenta.Text;
                c.TipoCuenta = t;
                c.Editar();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private bool VerificarDatos()
        {
            bool res = true;
            if (txtClabe.Text.Trim() == "")
            {
                FuncionesGenerales.ColoresError(txtClabe);
                res = false;
            }
            else
            {
                FuncionesGenerales.ColoresBien(txtClabe);
            }
            if (txtBanco.Text.Trim() == "")
            {
                FuncionesGenerales.ColoresError(txtBanco);
                res = false;
            }
            else
            {
                FuncionesGenerales.ColoresBien(txtBanco);
            }
            if (txtBeneficiario.Text.Trim() == "")
            {
                FuncionesGenerales.ColoresError(txtBeneficiario);
                res = false;
            }
            else
            {
                FuncionesGenerales.ColoresBien(txtBeneficiario);
            }
            return res;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (VerificarDatos())
            {
                try
                {
                    Editar();
                    FuncionesGenerales.Mensaje(this, Mensajes.Exito, "¡Se ha modificado la cuenta correctamente!", "Admin CSY");
                    this.Close();
                }
                catch (MySql.Data.MySqlClient.MySqlException ex)
                {
                    FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al crear la nueva cuenta. No se ha podido conectar con la base de datos.", "Admin CSY", ex);
                }
                catch (Exception ex)
                {
                    FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al crear la nueva cuenta.", "Admin CSY", ex);
                }
            }
            else
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "Los campos en color rojo son obligatorios", "Admin CSY");
            }
        }

        private void frmEditarCuenta_Load(object sender, EventArgs e)
        {
            ObtenerDatos();
        }

        private void txtNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            FuncionesGenerales.VerificarEsNumero(ref sender, ref e, true);
        }

        private void cboTipoCuenta_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboTipoCuenta.SelectedIndex)
            {
                case 0: t = TipoCuenta.Sucursal; break;
                case 1: t = TipoCuenta.Cliente; break;
                case 2: t = TipoCuenta.Proveedor; break;
            }
        }

    }
}
