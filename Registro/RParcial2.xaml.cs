using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Parcial2_Maria.Entidades;
using Parcial2_Maria.BLL;
using Microsoft.EntityFrameworkCore;

namespace Parcial2_Maria.Registro
{
    public partial class RParcial2 : Window
    {
        Llamadas llamadas = new Llamadas();
        public RParcial2()
        {
            InitializeComponent();
            this.DataContext = llamadas;
            IdTextBox.Text = "0";
        }

        private void Limpiar()
        {
            IdTextBox.Text = "0";
            DescripcionTextBox.Text = string.Empty;

            DetalleDataGrid.ItemsSource = new List<LlamadasDetalles>();
            Actualizar();
        }

        private void Actualizar()
        {
            this.DataContext = null;
            this.DataContext = llamadas;
        }

        private bool Existe()
        {
            llamadas = LlamadasBll.Buscar(Convert.ToInt32(IdTextBox.Text));
            return (llamadas != null);
        }

        private void GuardarButton_Click(object sender, RoutedEventArgs e)
        {
            bool paso = false;
            if (string.IsNullOrWhiteSpace(IdTextBox.Text) || IdTextBox.Text == "0")
                paso = LlamadasBll.Guardar(llamadas);
            else
            {
                if (!Existe())
                {
                    MessageBox.Show("No se puede Modificar porque no existe", "Fallo", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
                paso = LlamadasBll.Modificar(llamadas);
            }

            if (paso)
            {
                Limpiar();
                MessageBox.Show("Guardado!!", "Exito", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("No se puede Guardar", "Fallo", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void NuevoButton_Click(object sender, RoutedEventArgs e)
        {
            Limpiar();
        }

        private void BuscarButton_Click(object sender, RoutedEventArgs e)
        {
            Llamadas anterior = LlamadasBll.Buscar(Convert.ToInt32(IdTextBox.Text));

            if(anterior!= null)
            {
                llamadas = anterior;
                Actualizar();
            }
            else
            {
                MessageBox.Show("llamadas no encontrada");
            }
        }

        private void EliminarButton_Click(object sender, RoutedEventArgs e)
        {
            int id;
            id = Convert.ToInt32(IdTextBox.Text);

            Limpiar();

            if (LlamadasBll.Eliminar(id))
                MessageBox.Show("Eliminar", "Exito", MessageBoxButton.OK, MessageBoxImage.Information);
            else
                MessageBox.Show(IdTextBox.Text, "No se puede eliminar una llamada que no existe");
        }

        private void AgregarButton_Click(object sender, RoutedEventArgs e)
        {
            llamadas.LlamadasDetalles.Add(new LlamadasDetalles(Convert.ToInt32(IdTextBox.Text), ProblemaTextBox.Text,SolucionTextBox.Text));
            Actualizar();
           ProblemaTextBox.Focus();
        }

        private void RemoverButton_Click(object sender, RoutedEventArgs e)
        {
            llamadas.LlamadasDetalles.RemoveAt(DetalleDataGrid.FrozenColumnCount);
            Actualizar();
        }

       
    }
}
