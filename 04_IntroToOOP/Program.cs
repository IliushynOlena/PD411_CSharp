﻿using System.ComponentModel.Design;

namespace _04_IntroToOOP
{
    struct NewPoint
    {

        public int X; 
        public int Y;
        public void Print()
        {
            Console.WriteLine($"X : {X}, Y : {Y}");
          
        }
    }
    partial class Point : Object //internal
    {
        private NewPoint newPoint;
        public NewPoint NewPoint { get; set; }
        //public 
        //private (default for field)
        //protected
        //internal
        //protected internal

        //class body

        //private int number = 10;//private
        //private string name;
        //private const float PI = 3.14f;
        //private readonly int id;
        //public Point()
        //{
        //    id = 1;
        //}
        //void setId(int id)
        //{
        //    this.id = id;
        //}

        private static int count;
        static Point()
        {
            count = 0;
        }
        public Point() : this(0, 0) { }
        public Point(int value)
        {
            xCoord = value;
            yCoord = value;
        }
        public Point(int xCoord, int yCoord)
        {
            setXCoord(xCoord);              
            setYCoord(yCoord);             

        }       
        public void Print()
        {
            Console.WriteLine($"X : {xCoord}, Y : {yCoord}");
            //Console.SetCursorPosition(xCoord, yCoord); Console.WriteLine("*");
        }
        public override string ToString()
        {
            return $"X : {xCoord}, Y : {yCoord}";
        }

    }
    class ChildClass: Point//public inheritance 
    {    }


    class Program
    {
        static void Main(string[] args)
        {
            Point @class = new Point();
            Point p = new Point(-5, 10);
            //p.Print();
            //Console.WriteLine(p.ToString());
            p.setXCoord(22);
            p.setYCoord(10);
            //Console.WriteLine(p);
            //p.Print() ;
            Console.WriteLine(p.getXCoord());
            Console.WriteLine(p.getYCoord());

            p.XCoord = 1000;//value = 1000 - setter
            Console.WriteLine(p.XCoord);//getter

            p.Name = "2D Point";//set
            Console.WriteLine(p.Name);
            p.Length = 50;
            Console.WriteLine(p.Length);

            Console.WriteLine(p.Color);

            p.MovePoint(-10, -100);
            Console.WriteLine(p);

            Point[] point = new Point[5];
            try
            {
                for (int i = 0; i < point.Length; i++)
                {
                    point[i].Age = int.Parse(Console.ReadLine()!);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
          
            point[0] = p;
            point[1] = new Point(5,4);

            p.Address = "Rivne";
            p.Age = 100;
            Console.WriteLine(p.Address);//getter
            Console.WriteLine(p.Age);//getter;


        }
    }
}
