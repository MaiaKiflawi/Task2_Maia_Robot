using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_inc
{
    public class RobotWheels : RobotSpy
    {
        private int rightDir;
        private int leftDir;

        public RobotWheels(int rightDir, int leftDir) : base("Spyke", DateTime.Now, 100)
        {
            this.rightDir = rightDir;
            this.leftDir = leftDir;
        }


        public override void MoveForward() 
        {
            this.TurnWheels(1, 1);
            SetBatteryStatus(GetBatteryStatus() - 4.5);
        }
        public override void TurnRight() 
        {
            this.TurnWheels(-1, 1);
            SetBatteryStatus(GetBatteryStatus() - 4.5);
        }

        public override void MoveBackward()
        {
            this.TurnWheels(-1, -1);
            SetBatteryStatus(GetBatteryStatus() - 4.5);
        }

        public override void TurnLeft()
        {
            this.TurnWheels(1, -1);
            SetBatteryStatus(GetBatteryStatus() - 4.5);
        }

        private void TurnWheels(int rightDir, int leftDir)
        {
            this.rightDir = rightDir;
            this.leftDir = leftDir;
        }

        public void WaveHands()
        {
            SetBatteryStatus(GetBatteryStatus() - 2);
        }

    }
}
