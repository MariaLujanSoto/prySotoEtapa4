using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prySotoEtapa4
{
    public partial class frmEtapa4 : Form
    {
        public frmEtapa4()
        {
            InitializeComponent();
        }

        clsVehiculo objAuto;
        clsVehiculo objAvion;
        clsVehiculo objBarco;
        List<clsVehiculo> vehiculos = new List<clsVehiculo>();

        private void frmEtapa4_Load(object sender, EventArgs e)
        {
            objAuto = new clsVehiculo();
            objAvion = new clsVehiculo();
            objBarco = new clsVehiculo();

            objAuto.crearAuto();
            objAvion.crearAvion();
            objBarco.crearBarco();

        }
        bool Auto = false;
        bool Avion = false;
        bool Barco = false;

        private void btnCrearBarco_Click(object sender, EventArgs e)
        {
            objBarco.crearBarco();
            objBarco.Barco.Location = new Point(300, 350);
            this.Controls.Add(objBarco.Barco);
            Barco = true;
            if(Avion == true)
            {
                objAvion.Avion.Dispose();
                Avion = false;
            }
            if(Auto== true)
            {
                objAuto.Auto.Dispose();
                Auto = false;
            }
            vehiculos.Add(objBarco);

        }

        private void btnCrearAuto_Click(object sender, EventArgs e)
        {
            objAuto.crearAuto();
            objAuto.Auto.Location = new Point(400, 500);
            this.Controls.Add(objAuto.Auto);
            Auto = true;
            if (Avion == true)
            {
                objAvion.Avion.Dispose();
                Avion = false;
            }
            if (Barco == true)
            {
                objBarco.Barco.Dispose();
                Barco = false;
            }
            vehiculos.Add(objAuto);
        }

        private void btnCrearAvion_Click(object sender, EventArgs e)
        {
            objAvion.crearAvion();
            objAvion.Avion.Location = new Point(200, 100);
            Controls.Add(objAvion.Avion);
            Avion = true;
            if (Auto == true)
            {
                objAuto.Auto.Dispose();
                Auto = false;
            }
            if (Barco == true)
            {
                objBarco.Barco.Dispose();
                Barco = false;
            }

            vehiculos.Add(objAvion);
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
               
            lstVehiculos.Items.Clear();

            foreach (clsVehiculo vehiculo in vehiculos)
            {
                lstVehiculos.Items.Add(vehiculo.tipoVehiculo);
            }
        }
    }
}
