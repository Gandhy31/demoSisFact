﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Facturacion.Models;

public partial class Factura
{
    public int IdFactura { get; set; }

    public string Nombre { get; set; }

    public DateOnly FechaCreacion { get; set; }

    public DateOnly FechaModificacion { get; set; }

    public int IdUsuario { get; set; }

    public int IdCliente { get; set; }

    public virtual Cliente IdClienteNavigation { get; set; }

    public virtual Usuario IdUsuarioNavigation { get; set; }
}