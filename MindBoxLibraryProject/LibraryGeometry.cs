namespace Libraries
{
    public static class LibraryGeometry
    {
        public static double CalculateCircleArea(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        public static double CalculateTriangleArea(double a, double b, double c)
        {
            double s = (a + b + c) / 2;
            double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
            return area;
        }

        public static bool CheckingTriangleRight(double a, double b, double c)
        {
            if ((Math.Pow(a, 2) == Math.Pow(b, 2) + Math.Pow(c, 2)) || (Math.Pow(b, 2) == Math.Pow(a, 2) + Math.Pow(c, 2)) || (Math.Pow(c, 2) == Math.Pow(a, 2) + Math.Pow(b, 2)))
                return true;
            else return false;
        }
    }
}