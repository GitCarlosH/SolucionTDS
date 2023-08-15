using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SolucionTDS.Clases;

namespace SolucionTDS
{
    public partial class FrmProbarClaseCirculo : Form //INICIALIZA FORMULARIO 
    {
        Circunferencia objcircunsferencia;
              

        Rectangulo objrectangulo = new Rectangulo(); // CREA OBJETO RECTANGULO
        private double _lado1rectangulo ; //INICIALIZAMOS VARIABLES EN CERO PARA PODER SER USADAS MAS ADELANTE
        private double _lado2rectangulo ;
        private double _radiocircunsferencia;

        public FrmProbarClaseCirculo() // INICIALIZA CONSTRUCTOR, SE EJECUTA UNA SOLA VEZ CUANDO SE CREA EL OBJETO
          
        {
            _lado1rectangulo = 1;
            _lado2rectangulo = 2;
            _radiocircunsferencia = 3;
            InitializeComponent(); // //ARMA LA INTERFAZ, ENCAPSULADO//
        }
        

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e) //CALCULAR AREA DE LA CIRCUNFERENCIA
        {

            objcircunsferencia = new Circunferencia();
            objcircunsferencia.ModificarRadio(_radiocircunsferencia); //ASIGNA EL RADIO INGRESADO AL OBJETO
            double areaCircun1 = objcircunsferencia.CalcularArea(); //DECLARA UNA VARIABLE Y LE ASIGNA EL VALOR DEL CALCULO DEL AREA
            txtSupCircunForm.Text = areaCircun1.ToString("####.##"); //CONVIERTE EL VALOR DEL AREA CALCULADO A STRING Y LO COLOCA COMO TEXTO
            objcircunsferencia = new Circunferencia(8);
            double areaCircun2 = objcircunsferencia.CalcularArea();
            txtSupSobrec.Text = areaCircun2.ToString("####.##");
        }

        private void button2_Click(object sender, EventArgs e) // CALCULAR PERIMETRO DE LA CIRCUNFERENCIA
        {
            objcircunsferencia = new Circunferencia();
            objcircunsferencia.ModificarRadio(_radiocircunsferencia); //LE ASIGNA EL VALOR DEL RADIO AL OBJETO
            double perimetroCircun1 = objcircunsferencia.CalcularPerimetro(); //CREA UNA VARIABLE Y LE ASIGNA EL VALOR DEL PERIMETRO
            txtPerCircunForm.Text = perimetroCircun1.ToString("#####.##"); //CONVIERTE EL VALOR DEL PERIMETRO A STRING Y LO COLOCA COMO TEXTO
            objcircunsferencia = new Circunferencia(8);
            double areaCircun2 = objcircunsferencia.CalcularPerimetro();
            txtPerSobrec.Text = areaCircun2.ToString("####.##");
        }

        private void txtRadio_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e) //CALCULAR PERIMETRO RECTANGULO
        {
            
            objrectangulo.ModificarLado1(_lado1rectangulo); //LE MODIFICA EL VALOR DEL LADO 1 AL OBJETO
            objrectangulo.ModificarLado2(_lado2rectangulo); //LE MODIFICA EL VALOR DEL LADO 2 AL OBJETO
            double perimetroRect = objrectangulo.CalcularPerimetro(); //CREA UNA VARIABLE Y LE ASIGNA EL VALOR DEL CALCULO DEL PERIMETRO
            txtPerRectangulo.Text = perimetroRect.ToString("####.##"); //CONVIERTE EL VALOR DEL CALCULO DEL PERIMETRO A STRING Y SE LO ASIGNA AL CASILLERO DEL TEXTO
        }

        private void button4_Click(object sender, EventArgs e) //CALCULAR AREA RECTANGULO
        {
            
            objrectangulo.ModificarLado1(_lado1rectangulo);
            objrectangulo.ModificarLado2(_lado2rectangulo);
            double areaRect = objrectangulo.CalcularArea();
            txtAreaRectangulo.Text = areaRect.ToString("####.##");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            objcircunsferencia = null;
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            System.GC.Collect();
        }
    }
}
