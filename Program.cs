using System;

namespace PointExample
{
    class Point2D
    {
        private float x = 0.0f;
        private float y = 0.0f;

        public Point2D(float x, float y)
        {
            this.x = x;
            this.y = y;
        }

        public Point2D()
        {
            // Default constructor sets x and y to 0.0f
        }

        public float getX()
        {
            return x;
        }

        public void setX(float x)
        {
            this.x = x;
        }

        public float getY()
        {
            return y;
        }

        public void setY(float y)
        {
            this.y = y;
        }

        public void setXY(float x, float y)
        {
            this.x = x;
            this.y = y;
        }

        public float[] GetXY()
        {
            return new float[] { x, y };
        }

        public override string ToString()
        {
            return "(" + x + ", " + y + ")";
        }
    }

    class Point3D : Point2D
    {
        private float z = 0.0f;

        public Point3D(float x, float y, float z) : base(x, y)
        {
            this.z = z;
        }

        public Point3D() : base()
        {
            // Default constructor sets x, y, and z to 0.0f
        }

        public float getZ()
        {
            return z;
        }

        public void setZ(float z)
        {
            this.z = z;
        }

        public void setXYZ(float x, float y, float z)
        {
            setXY(x, y);
            this.z = z;
        }

        public float[] GetXYZ()
        {
            return new float[] { getX(), getY(), z };
        }

        public override string ToString()
        {
            return "(" + getX() + ", " + getY() + ", " + z + ")";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Point2D point2D = new Point2D(3.0f, 4.0f);
            Point3D point3D = new Point3D(1.0f, 2.0f, 3.0f);

            Console.WriteLine("Point2D: " + point2D);
            Console.WriteLine("Point3D: " + point3D);
        }
    }
}
