using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleOOP_V2
{
	class Point
	{
		private float _x;

		public float X
		{
			get { return _x; }
			set { _x = value; }
		}
		private float _y;

		public float Y
		{
			get { return _y; }
			set { _y = value; }
		}

		public Point(float x, float y)
		{
			X = x;
			Y = y;
		}
		public Point() { }
	}
}
