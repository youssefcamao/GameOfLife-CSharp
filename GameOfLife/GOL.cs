using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace GameOfLife
{
    public class GOL
    {
        public GOL(int width = 25, int height = 25)
        {
            Width = width;
            Height = height;
            mField = new List<bool>( new bool[Width * Height]);
        }

        public void SetCell(int x,int y, bool state)
        {
            if (InBounds(x, y))
            {
                mField[GetIndex(x, y)] = state;
            }
        }
        public bool GetCell(int x, int y)
        {
            if (InBounds(x, y))
            {
                return mField[GetIndex(x, y)];
            }
            return false;
        }

        public void Draw()
        {


            Console.SetCursorPosition(0, 0);
            for (int y = 0; y < Height; y++)
            {
                string a = string.Empty;
                for (int x = 0; x < Width; x++)
                {
                    a += GetCell(x, y) ? '█' : ' ';
                }

                Console.Write(a + '\n');
            }
        }

        public void Update()
        {
            
        }


        private int GetIndex(int x, int y)
        {
            return x + y * Width;
        }

        private bool InBounds(int x, int y)
        {
            return x >= 0 && y >= 0 && x < Width && y < Height;
        }

        public int Width { get; private set; }
        public int Height { get; private set; }

        private List<bool> mField;

    }
}
