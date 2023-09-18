using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_inc
{
    
    class RobotFly : RobotSpy
    {
        protected int ID;
        protected int dir;

        public RobotFly() : base("FlyRobot", DateTime.Now, 100) { }

        public override void MoveBackward()
        {
            for (int i = 0; i < 6; i++)
                this.MoveLeg(i, -1);
            SetBatteryStatus(GetBatteryStatus() - 2);
        }

        public override void MoveForward()
        {
            for (int i = 0; i < 6; i++)
                this.MoveLeg(i, 1);
            SetBatteryStatus(GetBatteryStatus() - 2);
        }

        public override void TurnLeft()
        {
            this.MoveLeg(0, -1);
            this.MoveLeg(1, 1);
            this.MoveLeg(2, -1);
            this.MoveLeg(3, 1);
            this.MoveLeg(4, -1);
            this.MoveLeg(5, 1);
            SetBatteryStatus(GetBatteryStatus() - 2);
        }

        public override void TurnRight()
        {
            this.MoveLeg(0, 1);
            this.MoveLeg(1, -1);
            this.MoveLeg(2, 1);
            this.MoveLeg(3, -1);
            this.MoveLeg(4, 1);
            this.MoveLeg(5, -1);
            SetBatteryStatus(GetBatteryStatus() - 2);
        }

        public void FlyForward()
        {
            for (int i = 0; i < 4; i++)
                this.MoveWing(i, 1);
            SetBatteryStatus(GetBatteryStatus() - 1.5);
        }

        public void FlyBackwards()
        {
            for (int i = 0; i < 4; i++)
                this.MoveWing(i, -1);
            SetBatteryStatus(GetBatteryStatus() - 1.5);
        }

        public void FlyLeft()
        {
            this.MoveWing(0,-1);
            this.MoveWing(1,1);
            this.MoveWing(2,-1);
            this.MoveWing(3,1);
            SetBatteryStatus(GetBatteryStatus() - 1.5);
        }

        public void FlyRight()
        {
            this.MoveWing(0, 1);
            this.MoveWing(1, -1);
            this.MoveWing(2, 1);
            this.MoveWing(3, -1);
            SetBatteryStatus(GetBatteryStatus() - 1.5);
        }

        private void MoveLeg(int Id, int dir)
        {
            this.ID = Id;
            this.dir = dir;
        }

        private void MoveWing(int Id, int dir)
        {
            this.ID = Id;
            this.dir = dir;
        }
    }
}
