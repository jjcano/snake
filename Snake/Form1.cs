using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
    public partial class Form1 : Form
    {
        cola cabeza;
        Comida comida;
        Graphics g;
        int xdir = 0;
        int ydir = 0;
        //int cuadro = 10;
        Boolean ejex = true;
        Boolean ejey = true;
        int puntaje = 0;
        int tiempo = 100;

        public Form1()
        {
            InitializeComponent();
            cabeza = new cola(10, 10);
            comida = new Comida();
            g = canvas.CreateGraphics();
            //velocidad();
        }

        public void movimiento()
        {
            cabeza.setxy(cabeza.verx() + xdir, cabeza.very() + ydir);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bucle_Tick(object sender, EventArgs e)
        {
            
            g.Clear(Color.White);
            cabeza.dibujar(g);
            comida.dibujar(g);
            movimiento();
            choquecuerpo();
            choquePared();
            velocidad();
            bucle.Interval = tiempo;

            if (cabeza.interseccion(comida))
            {
                comida.colocar();
                cabeza.meter();
                puntaje++;
                puntos.Text = puntaje.ToString();
            }

        }

        public void choquePared()
        {
            if (cabeza.verx() < 0 || cabeza.verx() > 675 || cabeza.very() < 0 || cabeza.very() > 304)
            {
                findejuego();
            }
        }

        public void velocidad()
        {
            int valor = Int32.Parse(puntos.Text);
            

            if (valor%10 == 0 && valor != 0)
            {
                valor = valor / 10;
                vel.Text = puntos.Text;
                /*bucle.Interval = bucle.Interval - 2;
                tiempo = bucle.Interval;*/
                tiempo = tiempo - 2;
                
            }

            //bucle.Interval = tiempo;
        }

        public void findejuego()
        {
            puntaje = 0;
            puntos.Text = "0";
            ejex = true;
            ejey = true;
            xdir = 0;
            ydir = 0;
            cabeza = new cola(10, 10);
            comida = new Comida();
            MessageBox.Show("Haz Perdido, Intentalo Más Tarde");
        }
        public void choquecuerpo()
        {
            cola temp;
            try
            {
                temp = cabeza.verSiguiente().verSiguiente();
            }
            catch (Exception err)
            {
                temp = null;
            }
            while (temp != null)
            {
                if (cabeza.interseccion(temp))
                {
                    findejuego();
                }
                else
                {
                    temp = temp.verSiguiente();
                }
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (ejex)
            {
                if (e.KeyCode == Keys.Up)
                {
                    ydir = -10;
                    xdir = 0;
                    ejex = false;
                    ejey = true;
                }
                if(e.KeyCode == Keys.Down)
                {
                    ydir = 10;
                    xdir = 0;
                    ejex = false;
                    ejey = true;
                }
            }
            if (ejey)
            {
                if (e.KeyCode == Keys.Right)
                {
                    ydir = 0;
                    xdir = 10;
                    ejex = true;
                    ejey = false;
                }
                if (e.KeyCode == Keys.Left)
                {
                    ydir = 0;
                    xdir = -10;
                    ejex = true;
                    ejey = false;
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
