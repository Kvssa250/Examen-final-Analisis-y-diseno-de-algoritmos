using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int x = 0;
        int y = 0;
        int z = 0;

        private void Rectangulo()
        {
            System.Drawing.Pen color = new System.Drawing.Pen(System.Drawing.Color.Red, 4);
            System.Drawing.Graphics formGraphics;

            formGraphics = this.CreateGraphics();
            formGraphics.DrawRectangle(color, new Rectangle(360, 260, x, y));
            color.Dispose();
            formGraphics.Dispose();
        }

        private void Cuadrado()
        {
            System.Drawing.Pen color = new System.Drawing.Pen(System.Drawing.Color.Blue, 4);
            System.Drawing.Graphics formGraphics;

            formGraphics = this.CreateGraphics();
            formGraphics.DrawRectangle(color, new Rectangle(360, 260, x, y));
            color.Dispose();
            formGraphics.Dispose();
        }
        private void Triangulo()
        {
            System.Drawing.Pen color = new System.Drawing.Pen(System.Drawing.Color.Green, 4);
            System.Drawing.Graphics formGraphics;
            Point TopV = new Point(360, 260);
            Point BottomRV = new Point(TopV.X + x, TopV.Y + (int)(Math.Sqrt(3) / 2 * x));
            Point BottomLV = new Point(TopV.X - x, TopV.Y + (int)(Math.Sqrt(3) / 2 * x));

            Point[] trianglePoints = new Point[]
            {TopV, BottomRV, BottomLV};

            formGraphics = this.CreateGraphics();
            formGraphics.DrawPolygon(color, trianglePoints);
            color.Dispose();
            formGraphics.Dispose();
        }

        private void Romboide()
        {
            System.Drawing.Pen color = new System.Drawing.Pen(System.Drawing.Color.Yellow, 4);
            System.Drawing.Graphics formGraphics;
            Point topLeftVertex = new Point(360, 260);
            Point topRightVertex = new Point(topLeftVertex.X + x, topLeftVertex.Y);
            Point bottomRightVertex = new Point(topRightVertex.X - (int)(y * Math.Cos(Math.PI / 4)), topRightVertex.Y + (int)(y * Math.Sin(Math.PI / 4)));
            Point bottomLeftVertex = new Point(topLeftVertex.X - (int)(y * Math.Cos(Math.PI / 4)), topLeftVertex.Y + (int)(y * Math.Sin(Math.PI / 4)));


            Point[] rhomboidPoints = new Point[] { topLeftVertex, topRightVertex, bottomRightVertex, bottomLeftVertex };
            formGraphics = this.CreateGraphics();
            formGraphics.DrawPolygon(color, rhomboidPoints);
            color.Dispose();
            formGraphics.Dispose();
        }

        private void Circulo()
        {
            System.Drawing.Pen color = new System.Drawing.Pen(System.Drawing.Color.Red, 4);
            System.Drawing.Graphics formGraphics;

            formGraphics = this.CreateGraphics();
            formGraphics.DrawEllipse(color, new Rectangle(360, 260, x, y));
            color.Dispose();
            formGraphics.Dispose();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBox1.Text);
            double b = double.Parse(textBox2.Text);
            double c = double.Parse(textBox3.Text);

            double area;
            area = a * 10;

            if (a == b && b == c) // Es un cuadrado
            {
                area = Math.Pow(a, 2);
                MessageBox.Show("Estos son los datos del cuadrado");
                MessageBox.Show($"Area: {area} pixeles");
                double circleRadius = a / 2;
                double circArea = (circleRadius * circleRadius) * 3.14;
                MessageBox.Show("Estos son los datos del circulo");
                MessageBox.Show($"Area: {circArea} pixeles, Radio {circleRadius} pixeles");

            }
            else if (a == b || a == c || b == c) // Es un rectángulo o un rombo
            {
                if (a == b && a != c || a == c && a != b || b == c && b != a) // Es un rombo
                {
                    area = (a * c) / 2;
                    MessageBox.Show("Estos son los datos del rombo");
                    MessageBox.Show($"Area: {area} pixeles");
                }
                if (a == b) // Es un rectángulo
                {
                    area = a * c;
                    MessageBox.Show("Estos son los datos del rectángulo");
                    MessageBox.Show($"Area: {area} pixeles");
                }
                else if (a == c)
                {
                    area = a * b;
                    MessageBox.Show("Estos son los datos del rectángulo");
                    MessageBox.Show($"Area: {area} pixeles");
                }
                else if (b == c)
                {
                    area = b * a;
                    MessageBox.Show("Estos son los datos del rectángulo");
                    MessageBox.Show($"Area: {area} pixeles");
                }
            }
            else if (a != b && a != c && b != c) // Es un triangulo
            {
                Console.WriteLine("Ha creado un triángulo escaleno con lados {0}, {1} y {2}", a, b, c);
                double s = (a + b + c) / 2;
                area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
                MessageBox.Show("Estos son los datos del triángulo");
                MessageBox.Show($"Area: {area} pixeles");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBox1.Text);
            double b = double.Parse(textBox2.Text);
            double c = double.Parse(textBox3.Text);

            double perimeter;
            perimeter = b * 10;

            if (a == b && b == c) // Es un cuadrado
            {
                perimeter = a * 4;
                MessageBox.Show("Estos son los datos del cuadrado");
                MessageBox.Show($"Perimetro: {perimeter} pixeles");
                double circleRadius = a / 2;
                double circArea = (circleRadius * circleRadius) * 3.14;
                MessageBox.Show("Estos son los datos del círculo");
                MessageBox.Show($"Area: {circArea} pixeles, Radio {circleRadius} pixeles");

            }
            else if (a == b || a == c || b == c) // Es un rectángulo o un rombo
            {
                if (a == b && a != c || a == c && a != b || b == c && b != a) // Es un rombo
                {
                    perimeter = a * 2 + b * 2;
                    MessageBox.Show("Estos son los datos del rombo");
                    MessageBox.Show($"Perimetro: {perimeter} pixeles");
                }
                if (a == b) // Es un rectángulo
                {
                    perimeter = a * 2 + b * 2;
                    MessageBox.Show("Estos son los datos del rectángulo");
                    MessageBox.Show($"Perimetro: {perimeter} pixeles");
                }
                else if (a == c)
                {
                    perimeter = a * 2 + c * 2;
                    MessageBox.Show("Estos son los datos del rectángulo");
                    MessageBox.Show($"Perimetro: {perimeter} pixeles");
                }
                else if (b == c)
                {
                    perimeter = b * 2 + c * 2;
                    MessageBox.Show("Estos son los datos del rectángulo");
                    MessageBox.Show($"Perimetro: {perimeter} pixeles");
                }
            }
            else if (a != b && a != c && b != c) // Es un triangulo
            {
                Console.WriteLine("Ha creado un triángulo escaleno con lados {0}, {1} y {2}", a, b, c);
                double s = (a + b + c) / 2;
                perimeter = a + b + c;
                MessageBox.Show("Estos son los datos del triángulo");
                MessageBox.Show($"Perimetro: {perimeter} pixeles");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBox1.Text);
            double b = double.Parse(textBox2.Text);
            double c = double.Parse(textBox3.Text);
            double lado_del_cuadrado = 0;
            double radio_del_circulo = 0;
            x = Convert.ToInt32(a);
            y = Convert.ToInt32(b);
            z = Convert.ToInt32(c);

            if (a == b && b == c) // Son un cuadrado y un circulo
            {
                lado_del_cuadrado = a;
                radio_del_circulo = a / 2;
                Cuadrado();
                Circulo();
            }
            else if (a == b || a == c || b == c) // Son un romboide y un rectangulo
            {
                Romboide();
                Rectangulo();
            }
            else if (a != b && a != c && b != c) // Es un triangulo 
            {
                Triangulo();
            }
        }
    }
}
