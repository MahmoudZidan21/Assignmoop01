using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignmoop01
{
    internal class Car
    {
		#region Attributes
		private int id;
		private int speed;
		private string model;
		#endregion

		#region Properties
		public string Model
		{
			get { return model; }
			set { model = value; }
		}


		public int Speed
		{
			get { return speed; }
			set { speed = value; }
		}


		public int Id
		{
			get { return id; }
			set { id = value; }
		}
		#endregion

		#region Class
		//public Car(int id, int speed, string model) : this(id, speed)
		//{
		//	Id = id;
		//	Speed = speed;
		//	Model = model;

		//}
		//public Car(int id)
		//{
		//	Id = id;

		//}
		//public Car(int id, int speed)
		//{
		//	Id = id;
		//	Speed = speed;
		//} 
		#endregion




	}
}
