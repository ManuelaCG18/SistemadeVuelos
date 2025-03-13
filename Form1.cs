using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vuelos
{
    public partial class ReservarVuelos : Form
    {
        private List<Vuelo> listaVuelos = new List<Vuelo>();
        public ReservarVuelos()
        {
            InitializeComponent();
        }

        private void btnAgregarVuelo_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtCodigoVuelo.Text) || 
                string.IsNullOrWhiteSpace(txtOrigen.Text) || 
                string.IsNullOrWhiteSpace(txtDestino.Text) || 
                string.IsNullOrWhiteSpace(dtpFechaSalida.Text) || 
                string.IsNullOrWhiteSpace(txtAsientosDisponibles.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios :)");
                return;
            }

            if (!int.TryParse(txtAsientosDisponibles.Text, out int asientos) || asientos <= 0)
            {
                MessageBox.Show("La cantidad de asientos debe ser un número entero positivo");
                return;
            }

            Vuelo nuevoVuelo = new Vuelo(txtCodigoVuelo.Text,
                                    txtOrigen.Text,
                                    txtDestino.Text,
                                    dtpFechaSalida.Value,
                                    asientos);

            listaVuelos.Add(nuevoVuelo);
            ActualizarListaVuelos();
            LimpiarCamposVuelos();
        }

        private void btnReservarVuelo_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtCodigoReserva.Text) || (string.IsNullOrEmpty(txtCantidadReservas.Text)))
            {
                MessageBox.Show("Todos los campos son obligatorios :)");
                return;
            }
            if(!int.TryParse(txtCantidadReservas.Text, out int cantidad) || cantidad <= 0)
            {
                MessageBox.Show("La cantidad de asientos a reservar debe ser un número entero positivo");
                return;
            }

            Vuelo vuelo = listaVuelos.FirstOrDefault(v => v.Codigo == txtCodigoReserva.Text); /** v representa cada vuelo en la lista
                                                                                                  v.Codigo == codigo compara el código del vuelo (v.Codigo) con el código ingresado (codigo).
                                                                                                  Si encuentra un vuelo con ese código, lo guarda en listaVuelos.
                                                                                               **/
            if(vuelo != null)
            {
                if(vuelo.ReservarAsientos(cantidad))
                {
                    MessageBox.Show($"Reserva exitosa! Asientos reservados: {cantidad}");
                    ActualizarListaVuelos();
                    LimpiarCamposVuelos();
                }
                else
                {
                    MessageBox.Show("No hay suficientes asientos disponibles :(");
                }
            }
            else
            {
                MessageBox.Show("Vuelo no encontrado :( intente con otro codigo de vuelo.");
            }
        }

        private void ActualizarListaVuelos()
        {
            listBoxVuelos.Items.Clear();
            foreach (Vuelo vuelo in listaVuelos)
            {
                listBoxVuelos.Items.Add(vuelo);
            }
        }

        private void LimpiarCamposVuelos()
        {
            txtCodigoVuelo.Clear();
            txtOrigen.Clear();
            txtDestino.Clear();
            dtpFechaSalida.Value = DateTime.Now;
            txtAsientosDisponibles.Clear();
        }
    }
}
