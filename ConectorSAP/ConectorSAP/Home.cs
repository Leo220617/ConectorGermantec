using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.Configuration;
using System.IO;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.Xml.Serialization;
 
using System.Xml;
 
using System.Net.Http;
using System.Web.Configuration;

namespace ConectorSAP
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            timerFacturas.Interval = Convert.ToInt32(ObtenerConfig("TiempoFacturasRecibir"));
            timerSAPfacturas.Interval = Convert.ToInt32(ObtenerConfig("TiempoFacturasInsertar"));
            timerInsertarInventario.Interval = Convert.ToInt32(ObtenerConfig("TiempoInventarioInsertar"));
            timerInvVT.Interval = Convert.ToInt32(ObtenerConfig("TiempoInventarioInsertarVT"));
            timerPrecios.Interval = Convert.ToInt32(ObtenerConfig("TiempoUpdatePrecios"));
            timerBodega.Interval = Convert.ToInt32(ObtenerConfig("TiempoBodegasInvetarios"));
            timerPagos.Interval = Convert.ToInt32(ObtenerConfig("TiempoPagos"));


        }

        private void timerFacturas_Tick(object sender, EventArgs e)
        {
            Task.Run(async () =>
            {
                Invoke(new Action(() => { timerFacturas.Enabled = false; }));
                try
                {
                    AgregarMensajeEstado("Insertando Facturas", true);
                    AgregarBitacora("Insertando Facturas...", "");

                    HttpClient cliente = new HttpClient();
                    string path = ObtenerConfig("urlInsercionFacturas");
                    HttpResponseMessage response = await cliente.GetAsync(path);

                    if (response.IsSuccessStatusCode)
                    {
                        AgregarMensajeEstado("Finalizado", true);
                    }
                    else
                    {
                        throw new Exception(response.ReasonPhrase);
                    }

                    AgregarBitacora("Facturas Insertadas exitosamente...", "");

                }
                catch (Exception ex)
                {

                    AgregarError(ex, "Facturas ");
                }

                Invoke(new Action(() => { timerFacturas.Enabled = true; }));
            });
        }


        private void AgregarError(Exception ex, string prefijo)
        {
            Invoke(new Action(() => { lbErrores.Items.Add(DateTime.Now.ToString("g") + " " + prefijo + ex.Message); Application.DoEvents(); }));
        }

        private void AgregarBitacora(string ex, string prefijo)
        {
            Invoke(new Action(() => { lbBitacora.Items.Add(DateTime.Now.ToString("g") + " " + prefijo + ex); Application.DoEvents(); }));
        }


        private void AgregarMensajeEstado(string mensaje, bool limpiar)
        {
            if (limpiar == true)
            {
              
                Invoke(new Action(() => { lbEstadoActual.Text = ""; }));
            }
            else
            {
                mensaje = " " + mensaje;
            }
          

            Invoke(new Action(() => { lbEstadoActual.Text += mensaje; Application.DoEvents(); }));

            //Application.DoEvents();
        }

        public static string ObtenerConfig(string v)
        {
            try
            {
                return WebConfigurationManager.AppSettings[v];
            }
            catch
            {
                return "";
            }
        }

        private void timerSAPfacturas_Tick(object sender, EventArgs e)
        {
            Task.Run(async () =>
            {
                Invoke(new Action(() => { timerSAPfacturas.Enabled = false; }));
                try
                {
                    AgregarMensajeEstado("Mandando Facturas a SAP", true);
                    AgregarBitacora("Insertando Facturas en SAP...", "");
                    HttpClient cliente = new HttpClient();
                    string path = ObtenerConfig("urlInsercionFacturasSAP");
                    var httpContent = new StringContent("", Encoding.UTF8, "application/json");
                    HttpResponseMessage response = await cliente.PostAsync(path, httpContent);

                    if (response.IsSuccessStatusCode)
                    {
                        AgregarMensajeEstado("Finalizado SAP", true);
                    }
                    else
                    {
                        throw new Exception(response.ReasonPhrase);
                    }

                    AgregarBitacora("Facturas Insertadas en SAP...", "");
                }
                catch (Exception ex)
                {

                    AgregarError(ex, "Facturas SAP ");
                }

                Invoke(new Action(() => { timerSAPfacturas.Enabled = true; }));
            });
        }

        private void timerInsertarInventario_Tick(object sender, EventArgs e)
        {
            Task.Run(async () =>
            {
                Invoke(new Action(() => { timerInsertarInventario.Enabled = false; }));
                try
                {
                    AgregarMensajeEstado("Insertando Inventario", true);
                    AgregarBitacora("Insertando Inventario...", "");
                    HttpClient cliente = new HttpClient();
                    string path = ObtenerConfig("urlInsertarInventario");
                     
                    HttpResponseMessage response = await cliente.GetAsync(path);

                    if (response.IsSuccessStatusCode)
                    {
                        AgregarMensajeEstado("Finalizado Inventario", true);
                    }
                    else
                    {
                        throw new Exception(response.ReasonPhrase);
                    }

                    AgregarBitacora("Insertado el inventario con éxito...", "");
                }
                catch (Exception ex)
                {

                    AgregarError(ex, "Insertar Inventario ");
                }

                Invoke(new Action(() => { timerInsertarInventario.Enabled = true; }));
            });
        }

        private void timerInvVT_Tick(object sender, EventArgs e)
        {
            Task.Run(async () =>
            {
                Invoke(new Action(() => { timerInsertarInventario.Enabled = false; }));
                try
                {
                    AgregarMensajeEstado("Insertando Inventario en VTEX", true);
                    AgregarBitacora("Insertando Inventario en VTEX...", "");
                    HttpClient cliente = new HttpClient();
                    string path = ObtenerConfig("urlInsertarInventarioVT");

                    HttpResponseMessage response = await cliente.GetAsync(path);

                    if (response.IsSuccessStatusCode)
                    {
                        AgregarMensajeEstado("Finalizado Inventario VTEX", true);
                    }
                    else
                    {
                        throw new Exception(response.ReasonPhrase);
                    }

                    AgregarBitacora("Inventario insertado en VTEX...", "");
                }
                catch (Exception ex)
                {

                    AgregarError(ex, "Insertar Inventario VTEX ");
                }

                Invoke(new Action(() => { timerInsertarInventario.Enabled = true; }));
            });
        }

        private void timerPrecios_Tick(object sender, EventArgs e)
        {
            Task.Run(async () =>
            {
                Invoke(new Action(() => { timerInsertarInventario.Enabled = false; }));
                try
                {
                    AgregarMensajeEstado("Actualizando Precios en VTEX", true);
                    AgregarBitacora("Actualizando Precios en VTEX...", "");
                    HttpClient cliente = new HttpClient();
                    string path = ObtenerConfig("urlUpdatePrecios");

                    HttpResponseMessage response = await cliente.GetAsync(path);

                    if (response.IsSuccessStatusCode)
                    {
                        AgregarMensajeEstado("Finalizado Precios VTEX", true);
                    }
                    else
                    {
                        throw new Exception(response.ReasonPhrase);
                    }

                    AgregarBitacora("Precios Actualizados en VTEX...", "");
                }
                catch (Exception ex)
                {

                    AgregarError(ex, "Actualizar Precios VTEX ");
                }

                Invoke(new Action(() => { timerInsertarInventario.Enabled = true; }));
            });
        }

        private void checkBoxFac_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxFac.Checked)
            {
            
                timerFacturas.Enabled = true;
            }
            else
            {
                timerFacturas.Enabled = false;
            }
        }

        private void InsercionFacturasSAP_CheckedChanged(object sender, EventArgs e)
        {
            if (InsercionFacturasSAP.Checked)
            {
                timerSAPfacturas.Enabled = true;
            }
            else
            {
                timerSAPfacturas.Enabled = false;
            }
        }

        private void InsertarInventario_CheckedChanged(object sender, EventArgs e)
        {
            if (InsertarInventario.Checked)
            {
                timerInsertarInventario.Enabled = true;
            }
            else
            {
                timerInsertarInventario.Enabled = false;
            }
        }

        private void InventarioVTEX_CheckedChanged(object sender, EventArgs e)
        {
            if (InventarioVTEX.Checked)
            {
                timerInvVT.Enabled = true;
            }
            else
            {
                timerInvVT.Enabled = false;
            }
        }

        private void ActualizarPrecios_CheckedChanged(object sender, EventArgs e)
        {
            if (ActualizarPrecios.Checked)
            {
                timerPrecios.Enabled = true;
            }
            else
            {
                timerPrecios.Enabled = false;
            }

        }

        private void timerBodega_Tick(object sender, EventArgs e)
        {
            Task.Run(async () =>
            {
                Invoke(new Action(() => { timerBodega.Enabled = false; }));
                try
                {
                    AgregarMensajeEstado("Actualizando Bodegas", true);
                    AgregarBitacora("Actualizando Bodegas...", "");
                    HttpClient cliente = new HttpClient();
                    string path = ObtenerConfig("urlBodegasInventarios");

                    HttpResponseMessage response = await cliente.GetAsync(path);

                    if (response.IsSuccessStatusCode)
                    {
                        AgregarMensajeEstado("Finalizado Bodegas", true);
                    }
                    else
                    {
                        throw new Exception(response.ReasonPhrase);
                    }

                    AgregarBitacora("Finalizado Bodegas...", "");
                }
                catch (Exception ex)
                {

                    AgregarError(ex, "Actualizar Bodegas ");
                }

                Invoke(new Action(() => { timerBodega.Enabled = true; }));
            });
        }

        private void Bodegas_CheckedChanged(object sender, EventArgs e)
        {
            if (Bodegas.Checked)
            {
                timerBodega.Enabled = true;
            }
            else
            {
                timerBodega.Enabled = false;
            }
        }

        private void Pagos_CheckedChanged(object sender, EventArgs e)
        {
            if (Pagos.Checked)
            {
                timerPagos.Enabled = true;
            }
            else
            {
                timerPagos.Enabled = false;
            }
        }

        private void timerPagos_Tick(object sender, EventArgs e)
        {
            Task.Run(async () =>
            {
                Invoke(new Action(() => { timerBodega.Enabled = false; }));
                try
                {
                    AgregarMensajeEstado("Reenviando Pagos", true);
                    AgregarBitacora("Enviando Pagos Contingencia...", "");
                    HttpClient cliente = new HttpClient();
                    string path = ObtenerConfig("urlPagos");

                    HttpResponseMessage response = await cliente.GetAsync(path);

                    if (response.IsSuccessStatusCode)
                    {
                        AgregarMensajeEstado("Finalizado Pagos", true);
                    }
                    else
                    {
                        throw new Exception(response.ReasonPhrase);
                    }

                    AgregarBitacora("Finalizado Pagos...", "");
                }
                catch (Exception ex)
                {

                    AgregarError(ex, "Enviando Pagos ");
                }

                Invoke(new Action(() => { timerBodega.Enabled = true; }));
            });
        }
    }
}
