namespace GraphicsApp
{
    class Circle
    {
        public int x, y;
        public int radius;
        public int x1, y1; //coords of the left up corner
        public int width;
        public int height;


        public Circle(int x, int y, int radius)
        {
            this.x = x;
            this.y = y;
            this.radius = radius;
            this.x1 = this.x - this.radius;
            this.y1 = this.y - this.radius;
            this.width = this.height = this.radius * 2;
        }






    }
}
