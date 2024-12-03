namespace Circle
{
    public class Circle
    {
        private double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double CalculateDiameter(double radius)
        {
            double circleDiameter = radius * 2;
            return circleDiameter;
        }

        public double CalculateCircumference(double radius)
        {
            double circumference = 2 * Math.PI * radius; 
            return circumference;
        }
        public double CalculateArea (double radius)
        {
            double radiusSquared = radius * radius;
            double area = radiusSquared * Math.PI;
            return area;
        }

        public void Grow()
        {
            double circleGrow = Radius * 2;
            
        }

        public double GetRadius()
            { return Radius; }

    }
}
