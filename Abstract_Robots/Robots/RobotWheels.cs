using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_inc
{
    public class RobotWheels : RobotSpy
    {
        protected int rightDir;
        protected int leftDir;

        public RobotWheels() : base("Spyke", DateTime.Now, 100) { }

        public override void MoveForward() 
        {
            TurnWheels(1, 1);
            SetBatteryStatus(GetBatteryStatus() - 4.5);
        }
        public override void TurnRight() 
        {
            TurnWheels(-1, 1);
            SetBatteryStatus(GetBatteryStatus() - 4.5);
        }

        public override void MoveBackward()
        {
            TurnWheels(-1, -1);
            SetBatteryStatus(GetBatteryStatus() - 4.5);
        }

        public override void TurnLeft()
        {
            TurnWheels(1, -1);
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
