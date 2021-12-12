using System;
namespace WareHouse
{
    public class Box
    {
        float height;
        float width;
        float depth;


        public Box()
        {
        }

        public Box(float height, float width, float depth)
        {
            this.height = height;
            this.width = width;
            this.depth = depth;
        }

        public float Volume()
        {
            return width * height * depth;
        }

        public override string ToString()
        {
            return string.Format(
                $" Height: {height}" +
                $"\n Width: {width}" +
                $"\n Depth: {depth}" +
                $"\n Volume: {Volume():f2}\n"
                );
        }

    }
}
