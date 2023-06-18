using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
     class Car
    {
        public string model { get; }
        public string year { get; }
        public string color { get; set; }

        private bool IsEngineRunning = false;
        public bool isDoorLocked = false;


        public string cacarrr(string model, string year, string color)
        {
            this.model = model;
            this.year = year;
            this.color = color;
        }

        public void LockBottemPressed()
        {
            isDoorLocked = true;
        }

        public void UnLockBottemPressed()
        {
            isDoorLocked = false;
        }

        public bool StartEngine()
        {
            IsEngineRunning = true;
            return IsEngineRunning;
        }

        public bool StopEngine()
        {
            IsEngineRunning = false;
            return IsEngineRunning;
        }

        public void MoveCar()
        {
            if(IsEngineRunning)
            {
                this.LockBottemPressed();
                Console.WriteLine("car is moving");
            }
            else
            {
                this.UnLockBottemPressed ();
                Console.WriteLine("car is not moving");
            }
        }
        
    }
}