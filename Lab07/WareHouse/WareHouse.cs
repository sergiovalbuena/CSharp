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

/*
OUTPUT: 
WareHouse

Box 1:
 Height: 3
 Width: 4
 Depth: 5
 Volume: 60.00

Box 2:
 Height: 4
 Width: 6
 Depth: 7
 Volume: 168.00

Box 3:
 Height: 1.5
 Width: 4
 Depth: 6
 Volume: 36.00

Box 4:
 Height: 6
 Width: 4
 Depth: 4
 Volume: 96.00

Box 5:
 Height: 2
 Width: 3.5
 Depth: 8
 Volume: 56.00

Total volume of 5 boxes is 416.00.
*/
