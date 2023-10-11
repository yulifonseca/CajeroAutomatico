using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CajeroAutomatico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Declaro variables
       private int intento = 0;
       private const int limite = 2;
       private bool bloqueo = false;
        
      

        private void btningresar_Click(object sender, EventArgs e)
        {
            // Configura botón de ingreso
            {
                if (txtncuenta.Text != "" && txtclave.Text == "118250760")
                {
                    MessageBox.Show("Número de cuenta y clave son válidos, acceso permitido", "Información Del Sistema");
                   this.Hide();
                    MenuPrincipal menuPrincipal = new MenuPrincipal();
                    menuPrincipal.ShowDialog();
                    txtncuenta.Clear();
                    txtclave.Clear();

                }
                else
                {
                    // Configura el botón de ingreso para algún error de dato
                    MessageBox.Show("ACCESO DENEGADO. El número de cuenta o la clave son inválidos.", "Información Del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtncuenta.Clear();
                    txtclave.Clear();
                }

                intento++;
                if (intento > limite)
                {
                    cuentabloqueada();
                }
            }
            
        }

        //Bloqueo de cuenta al fallar 2 veces
        public void cuentabloqueada()
        {
            bloqueo = true;
            btningresar.Enabled = false;
            txtncuenta.Enabled = false;
            txtclave.Enabled = false;
            MessageBox.Show("Esta cuenta ha sido temporalmente bloqueada por su seguridad. Contacta al banco para desbloquearla.", "Información del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        
        private void btnsalir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Está seguro que desea salir?", "Información Del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado != DialogResult.No)
            {
                this.Close();
            }

        }

    }
}
