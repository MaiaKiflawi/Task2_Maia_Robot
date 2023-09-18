using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_inc
{
    public class RobotQuad : RobotSpy
    {
        protected int legID;
        protected int dir;

        //1. עדכנו את הפעולה הבונה כך שתתאים לפעולת במחלקת העל
        public RobotQuad() : base("QuadSpy", DateTime.Now, 100) { }

        public override void MoveBackward()
        {
            for (int i = 0; i < 4; i++)
                this.MoveLeg(i, -1);
            SetBatteryStatus(GetBatteryStatus() - 3);
        }

        public override void MoveForward()
        {
            for (int i = 0; i < 4; i++)
                this.MoveLeg(i, 1);
            SetBatteryStatus(GetBatteryStatus() - 3);
        }

        public override void TurnLeft()
        {
            this.MoveLeg(0,-1);
            this.MoveLeg(1,1);
            this.MoveLeg(2,-1);
            this.MoveLeg(3,1);
            SetBatteryStatus(GetBatteryStatus() - 3);
        }

        public override void TurnRight()
        {
            this.MoveLeg(0, 1);
            this.MoveLeg(1, -1);
            this.MoveLeg(2, 1);
            this.MoveLeg(3, -1);
            SetBatteryStatus(GetBatteryStatus() - 3);
        }


        private void MoveLeg(int legId, int dir) 
        {
            this.legID = legId;
            this.dir = dir;
        }

    }

}
