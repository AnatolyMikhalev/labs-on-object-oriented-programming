﻿namespace GraphicsApp
{
    class Box
    {
        public int x1, y1;
        public int x2, y2;
        public int width;
        public int height;

        public Box(int x1, int y1, int x2, int y2)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
            this.width = this.x2 - this.x1;
            this.height = this.y2 - this.y1;
        }


    }
}
