using Ch06.Sub2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch06
{
    internal class _2_Interface
    {
        static void Main(string[] args)
        {
            // 인터페이스로 공동 클래스 구조설계
            LGRemocon      lg      = new LGRemocon();
            SamsungRemocon samsung = new SamsungRemocon();

            lg.PowerOn();
            lg.PowerOff();
            lg.SoundUp();
            lg.SoundDown();

            samsung.PowerOn();
            samsung.ChUp();
            samsung.SoundDown();
            samsung.PowerOff();

            // 인터페이스를 활용한 다중 상속
            TV tv = new TV();
            tv.PowerOn();
            tv.booting();
            tv.Access();


        }
    }
}
