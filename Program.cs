using System;
using System.Net.Mail;

namespace Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Defina una clase abstracta Shape con el método abstracto CalculateSurface() y el ancho y alto de los campos. Defina dos clases adicionales para un triangle y un rectangle, que implementan CalculateSurface(). 
            //Este método tiene que devolver las áreas del rectángulo (alto*ancho) y del triángulo (alto*ancho/2).  Defina una clase para un Circle con un constructor apropiado, que inicialice los dos campos (alto y ancho) 
            //con el mismo valor (el radio) e implemente el método abstracto para calcular el área. Crea una matriz de diferentes Shapes y calcula el área de cada forma en otra matriz.
            Shape[] shapes = new Shape[]{
                new Rectangle(7,8),
                new Triangle (9,10),
                new Circle(5)
                
            };

            foreach(Shape shape in shapes){
                    Console.WriteLine($"{shape.GetType().Name}: {shape.CalculateSurface()}");

            }

        }
    }
    public abstract class Shape
    {
        protected double alto;
        protected double ancho;

        public Shape(double alto, double ancho)
        {
            this.alto = alto;
            this.ancho = ancho;
        }
        public abstract double CalculateSurface();

    }
    public class Triangle : Shape
    {
        public Triangle(double alto, double ancho) : base(alto, ancho){}

        public override double CalculateSurface()
        {
            return (ancho*alto)/2;
        }
    }
    public class Rectangle : Shape
    {
        public Rectangle(double alto, double ancho) : base(alto, ancho){}
        public override double CalculateSurface()
        {
            return (alto*ancho);
        }
    }
    public class Circle : Shape
    {
        public Circle(double radio) : base(radio, radio){}
        
        

        public override double CalculateSurface()
        {
            return Math.PI *alto *alto;
        }
    }
}