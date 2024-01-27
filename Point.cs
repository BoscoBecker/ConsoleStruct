namespace ConsoleStruct
{
    struct Point
    {
        public double X;
        public double Y;

        public override string ToString() {
            return "(" + X + ", " + Y + ")";
        }
    }
}
