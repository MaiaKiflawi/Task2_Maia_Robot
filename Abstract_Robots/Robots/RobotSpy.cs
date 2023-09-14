using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Robots_inc
{
	public abstract class RobotSpy
	{
		private string model;
		private DateTime creationDate;
		private double batteryStatus;


		public RobotSpy(string model, DateTime creationDate, double BatteryStatus)
		{
			this.model = model;
			this.creationDate = creationDate;
			this.batteryStatus = BatteryStatus;
		}
		public string GetModel() { return this.model; }
		public DateTime GetCreationDate() { return this.creationDate; }
		public double GetBatteryStatus() { return this.batteryStatus; }
		public void SetBatteryStatus(double battery) { this.batteryStatus = battery; }


		public abstract void MoveForward();
		public abstract void MoveBackward();
		public abstract void TurnLeft();
		public abstract void TurnRight();

		public void TakePicture()
		{
			Console.WriteLine("click");
			this.batteryStatus -= 5;
		}
		public void ChargeBattery()
		{
			this.batteryStatus = 100;
		}
	}
}
