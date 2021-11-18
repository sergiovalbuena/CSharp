using System;
namespace Rectangle4App
{
    public class Rectangle
    {
        float height;
        float width;

        public Rectangle()
        {
        }

        public Rectangle(float h, float w)
        {
            height = h;
            width = w;
        }

        public float Height
        {
            get { return height; } //get method
            set { height = value; } //set method
        }
        public float Width
        {
            get { return width; } //get method
            set { width = value; }//set method
        }

        //creat a float instance method ComputeParimeter
        public float ComputePerimeter()
        {
            return (Height * 2)+( Width * 2);
        }
        public float ComputeArea()
        {
            return (Height * Width);
        }

        //public override
        public override string ToString()
        {
            return "height: " + height + 
                "\nwidth: " + width +
                "\narea: " + ComputeArea() +
                "\nperimeter: " + ComputePerimeter();
                
        }
    }
}
