using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CajeroAutomatico
{
    public partial class MenuPrincipal : Form
    {
      
        public MenuPrincipal()
        {
            InitializeComponent();
        }
        double saldo = 100000, retiro, resultado, cantidad;

        private void txtretiro_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnsalir1_Click(object sender, EventArgs e)
        {
            // Configura botón para regresar a la pantalla principal
            DialogResult resultado = MessageBox.Show("¿Seguro que desea regresar?", "Información Del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado != DialogResult.No)
            {
                this.Hide();

                Form1 form1 = new Form1();
                form1.ShowDialog();
            }
            
        }


        private void btndepo_Click(object sender, EventArgs e)
        {
            // Declaro variables e inicia operación para el depósito

            cantidad = Convert.ToDouble(txtdepositos.Text);

            if (cantidad > 0)          
            {
                resultado = cantidad + saldo;
                saldo = resultado;
                lblsaldo.Text = "₡" + resultado.ToString();
                MessageBox.Show("Procesando depósito...DEPÓSITO ÉXITOSO", "Información Del Sistema", MessageBoxButtons.OK);
                txtdepositos.Clear();
            }
            if(cantidad <= 0)
            {
                // Respuesta para valores inválidos
                MessageBox.Show("Valor inválido, solo se acepta valores positivos mayores a 0", "Información Del Sistema", MessageBoxButtons.OK);
            }
        }   
       
        private void btnretiro_Click(object sender, EventArgs e)
        {
            //Declaro variable e inicio operación para el retiro
            
            
            cantidad = Convert.ToDouble(txtretiro.Text);

            if (saldo > cantidad && cantidad > 0)
            {
                resultado = saldo - cantidad;

                saldo = resultado;
                MessageBox.Show("Procesando retiro...RETIRO ÉXITOSO", "Información Del Sistema", MessageBoxButtons.OK);
                
                txtretiro.Clear();

                lblsaldo.Text = "₡"+ resultado.ToString();
            }
            // Respuesta para el ingreso de valores inválidos o insuficientes 
            if(cantidad > saldo)
            {
                MessageBox.Show("Fondo Insuficientes","Información Del Sistema", MessageBoxButtons.OK);
            }
            if (cantidad <=0)
            {
                MessageBox.Show("Valor inválido, solo se acepta valores positivos mayores a 0", "Información Del Sistema", MessageBoxButtons.OK);
            }
        }

       
    }
}
