using System;

namespace RenkYakalama
{

    abstract class Object
    {
        protected int x1, y1, x2, y2;


        public int getX1()
        {
            return x1;
        }

        public int getY1()
        {
            return y1;
        }

        public int getX2()
        {
            return x2;
        }

        public int getY2()
        {
            return y2;
        }

        public int getWidth() 
        {
            return getX2()-getX1();
        }


        public int getHeight() 
        {
            return getY2()-getY1();
        }


        public void posun(int x1, int y1, int x2, int y2)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
        }


        public int getStredX()
        {
            return getWidth() / 2 + getX1();
        }


        public int getStredY()
        {
            return getHeight() / 2 + getY1();
        }
    }


    class ColorDefine : Object
    {
        private static byte define = 0;


        public static byte redSensistivty = 120;
        public static byte greenSensitivty = 100;
        public static byte blueSensitivty = 140;
        public static byte defaultSensitivy = redSensistivty;

        public ColorDefine(int x1, int y1, int x2, int y2)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
        }

        public static byte ChannelValue(byte r, byte g, byte b)
        {
            int f = 0;
            if (define == 0)
                f = r * r - g * g - b * b;
            else if (define == 1)
                f = g*g - r*r - b*b;
            else if (define == 2)
                f = b*b - g*g - r*r;
            byte c = f > 0 ? (byte)Math.Sqrt(f) : (byte)0;
            return c;
        }

        public static bool SatisfiedColor(byte channelValue)
        {
            return (channelValue > defaultSensitivy);
        }

        public static void redRecognition()
        {
            define = 0;
            defaultSensitivy = redSensistivty;
        }

        public static void greenRecognition()
        {
            define = 1;
            defaultSensitivy = redSensistivty;
        }
        public static void blueRecognition()
        {
            define = 2;
            defaultSensitivy = greenSensitivty;
        }

        public static void setSensitivity(byte red, byte green, byte blue)
        {
            redSensistivty = red;
            greenSensitivty = green;
            blueSensitivty = blue;
            switch (define)
            {
                case 0: defaultSensitivy = red; break;
                case 1: defaultSensitivy = green; break;
                case 2: defaultSensitivy = blue; break;
            }
        }
    }
    
}
