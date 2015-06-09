﻿using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EC_Admin
{
    public partial class Ticket
    {
        int y;
        const int saltoLinea = 15;
        int idVenta;
        int idProd;
        bool esCierreCaja;
        //Variables para el corte de caja
        int idApertura;
        int idCierre;

        string impresora;
        string impresoraTickets;
        string lineaSup01;
        string lineaSup02;
        string lineaSup03;
        string lineaSup04;
        string lineaSup05;
        string lineaSup06;
        string lineaSup07;
        string lineaInf01;
        string lineaInf02;
        string lineaInf03;

        PrintDocument pd;
        PrintPreviewDialog ppd;
        DataTable dtVenta;
        DataTable dtVentaDetallada;
        DataTable dtCaja;
        Font fuenteNormal;
        Font fuenteNormalResaltada;
        Font fuenteGrande;
        Font fuenteGrandeResaltada;

    }
}
