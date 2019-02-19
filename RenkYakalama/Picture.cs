using System;

namespace RenkYakalama
{
    class Picture
    {
        public int width, height;
        private byte[] data;
        private Object recordingObject;

        public Picture(int width, int height)
        {
            this.width = width;
            this.height = height;
        }


        public void updateImage(byte[] data)
        {
            this.data = data;
            updateCaptureObject();
        }

        private void updateCaptureObject()
        {
            int x1 = 0;
            int y1 = 0;
            int x2 = width;
            int y2 = height;


            if (recordingObject != null)
            {
                x1 = recordingObject.getX1() - recordingObject.getWidth();
                x1 = x1 > 0 ? x1 : 0;
                y1 = recordingObject.getY1() - recordingObject.getHeight();
                y1 = y1 > 0 ? y1 : 0;
                x2 = recordingObject.getX2() + recordingObject.getWidth();
                x2 = x2 < width ? x2 : width;
                y2 = recordingObject.getY2() + recordingObject.getHeight();
                y2 = y2 < height ? y2 : height;
            }

            bool found = false;
            int s = 0, j = 0, v = 0, z = 0;

            for (int y = y1; y < y2; y++)
            {
                for (int x = x1; x < x2; x++)
                {
                    byte r = getR(x, y);
                    byte g = getG(x, y);
                    byte b = getB(x, y);
                    byte c = ColorDefine.ChannelValue(r, g, b);
                    if (ColorDefine.SatisfiedColor(c))
                    {
                        if (!found)
                        {
                            s = y;
                            j = y;
                            v = x;
                            z = x;
                            found = true;
                        }
                        if (x < z) z = x;
                        if (x > v) v = x;
                        if (y < s) s = y;
                        if (y > j) j = y;
                    }
                }
            }

            if (found)
            {
                if (recordingObject == null)
                {
                    recordingObject = new ColorDefine(z, s, v, j);
                    Console.WriteLine("Found Object!");
                }
                else
                {
                    recordingObject.posun(z, s, v, j);
                }
            }
            else
            {
                if (recordingObject != null) // Objekt již v tomto snímku není, odstraním jeho sledování
                {
                    recordingObject = null;
                    Console.WriteLine("- Objekt ztracen!");
                }
            }
        }
        public Object getObject()
        {
            return recordingObject;
        }
        protected byte getR(int x, int y)
        {
            return data[data.Length - 1 - (width * 3 * y) - (x * 3)];
        }
        protected byte getG(int x, int y)
        {
            return data[data.Length - 1 - (width * 3 * y) - (x * 3) - 1];
        }
        protected byte getB(int x, int y)
        {
            return data[data.Length - 1 - (width * 3 * y) - (x * 3) - 2];
        } 
    }
}
