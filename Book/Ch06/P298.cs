using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch06
{
    internal class P298
    {
        class Box
        {
            private int width;
            public int Width
            {
                get { return Width; }
                set
                {
                    if (value > 0) { Width = value; }
                    else { Console.WriteLine("너비는 자연수를 입력해주세요"); }
                }
            }

            private int height;
            public int Height
            {
                get { return Height; }
                set
                {
                    if (value > 0) { height = value; }
                    else { Console.WriteLine("높이는 자연수를 입력해주세요"); }
                }
            }

            // 생성자
            public Box(int width, int height)
            {
                Width = width;
                Height = height;
            }

            // 인스턴스 메서드
            public int Area() { return this.width * this.height; }
        }

        static void Main1(string[] args)
        {
            Box box = new Box(-10, -20);

            box.Width = -200;
            box.Height = -100;
        }
    }
}
