using BL.Tecnologia;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Tecnologia
{
   public class FacturaBL
    {
        Contexto _contexto;

        public BindingList<Factura> ListaFacturas { get; set; }

        public FacturaBL()
        {
            _contexto = new Contexto();
        }

        public BindingList<Factura> ObtenerFacturas()
        {
            _contexto.Facturas.Include("FacturaDetalle").Load();
                ListaFacturas = _contexto.Facturas.Local.ToBindingList();

            return ListaFacturas;
        }

        public void AgregarFactura()
        {
            var nuevaFactura = new Factura();
            _contexto.Facturas.Add(nuevaFactura);
        }

        public void AgregarFactura(Factura factura)
        {
            if(factura != null)
            {
                var nuevoDetalle = new FacturaDetalle();
                factura.FacturaDetalle.Add(nuevoDetalle);
            }
        }

        public void RemoverFacturaDetalle(Factura factura, FacturaDetalle facturaDetalle)
        {
            if(factura != null && facturaDetalle != null)
            {
                factura.FacturaDetalle.Remove(facturaDetalle);
            }
        }

        public void CancelarCambios()
        {
            foreach (var item in _contexto.ChangeTracker.Entries())
            {
                item.State = EntityState.Unchanged;
                item.Reload();
            }
        }
            public Resultado GuardarFactura(Factura factura)
        {
            var resultado = Validar(factura);
            if (resultado.Correcto == false)
            {
                return resultado;
            }

            _contexto.SaveChanges();
            resultado.Correcto = true;
            return resultado;
        }

        private Resultado Validar(Factura factura)
        {
            var resultado = new Resultado();
            resultado.Correcto = true;

            if(factura == null)
            {
                resultado.Incorrecto = "Agregue una Factura";
                resultado.Correcto = false;

                return resultado;
            }

            if(factura.Activo == false)
            {
                resultado.Incorrecto = "Factura Anulada";
                resultado.Correcto = false;
            }
            if(factura.ClienteId ==0)
            {
                resultado.Incorrecto = "Seleccione un Cliente";
                resultado.Correcto = false;
            }
            if(factura.FacturaDetalle.Count == 0)
            {
                resultado.Incorrecto = "Agregue Productos a la Factura";
                resultado.Correcto = false;
            }
            foreach (var detalle in factura.FacturaDetalle)
            {
                if(detalle.ProductoId== 0)
                {
                    resultado.Incorrecto = "Seleccione Productos Validos";
                    resultado.Correcto = false;
                }
            }


            return resultado;
        }


        public void CalcularFactura(Factura factura)
        {
            if(factura != null)
            {
                double Subtotal = 0;

                foreach (var detalle in factura.FacturaDetalle)
                {
                    var producto = _contexto.Productos.Find(detalle.ProductoId);

                    if(producto != null)
                    {
                        detalle.Precio = producto.Precio;
                        detalle.Total = detalle.Cantidad * producto.Precio;

                        Subtotal += detalle.Total;

                    }
                }

                factura.SubTotal = Subtotal;
                factura.Impuesto = Subtotal * 0.15;
                factura.Total = Subtotal + factura.Impuesto;
            }
        }

        public bool AnularFactura(int id)
        {
            foreach (var factura in ListaFacturas)
            {
                if(factura.Id == id)
                {
                    factura.Activo = false;
                    _contexto.SaveChanges();
                    return true;
                }
            }

            return false;
        }


    }




    public class Factura
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public string Vendedor { get; set; }
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
        public BindingList<FacturaDetalle > FacturaDetalle{ get; set; }
        public double SubTotal { get; set; }
        public double Impuesto { get; set; }
        public double Total { get; set; }
        public bool Activo { get; set; }

        public Factura()
        {
            Fecha = DateTime.Now;
            FacturaDetalle = new BindingList<FacturaDetalle>();
            Activo = true;
        }
    }

    public class FacturaDetalle
    {
        public int Id { get; set; }
        public int ProductoId { get; set; }
        public Producto Producto { get; set; }
        public int Cantidad { get; set; }
        public double Precio { get; set; }
        public double Total { get; set; }


        public FacturaDetalle()
        {
            Cantidad = 1;
        }
    }

}