using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace RectangleOOP_V2
{
	class RectangleOOP_V2
	{
		private Point[] _Rect;

		public Point[] Rect
		{
			get { return _Rect; }
			set { _Rect = value; }
		}
		private float _size;

		public float Size
		{
			get { return _size; }
			set { _size = value; }
		}
		public RectangleOOP_V2()
		{
			Point[] rect = new Point[10];
			Rect = rect;
		}
		//public RectangleOOP_V2()
		//{
		//	Point[] rect = new Point[10];
		//	Console.WriteLine("Nhap toa do 9 diem:");
		//	for (int i = 1; i <= 9; i++)
		//	{
		//		Point pnt = new Point();
		//		Console.WriteLine("Point " + i + ":");
		//		Console.WriteLine("X:");
		//		pnt.X = float.Parse(Console.ReadLine());
		//		Console.WriteLine("Y:");
		//		pnt.Y = float.Parse(Console.ReadLine());
		//		rect[i] = pnt;
		//	}
		//	Rect = rect;
		//}
		public RectangleOOP_V2(float x, float y, float size)
		{
			Point[] rect = new Point[10];
			Point M5 = new Point();
			M5.X = x;
			M5.Y = y;
			GenerateSquare(M5, size, rect);
			Rect = rect;
		}
		public RectangleOOP_V2(string R)
		{
		}
		private void GenerateSquare(Point m5, float size, Point[] Rect)
		{
			//throw new NotImplementedException();
			float part = size / 2;
			Point pnt1 = new Point();
			pnt1.X = m5.X - part;
			pnt1.Y = m5.Y - part;
			Rect[1] = pnt1;

			Point pnt2 = new Point();
			pnt2.X = m5.X;
			pnt2.Y = m5.Y - part;
			Rect[2] = pnt2;

			Point pnt3 = new Point();
			pnt3.X = m5.X + part;
			pnt3.Y = m5.Y - part;
			Rect[3] = pnt3;

			Point pnt4 = new Point();
			pnt4.X = m5.X - part;
			pnt4.Y = m5.Y;
			Rect[4] = pnt4;

			Point pnt5 = new Point();
			pnt5.X = m5.X;
			pnt5.Y = m5.Y;
			Rect[5] = pnt5;

			Point pnt6 = new Point();
			pnt6.X = m5.X + part;
			pnt6.Y = m5.Y;
			Rect[6] = pnt6;

			Point pnt7 = new Point();
			pnt7.X = m5.X - part;
			pnt7.Y = m5.Y + part;
			Rect[7] = pnt7;

			Point pnt8 = new Point();
			pnt8.X = m5.X;
			pnt8.Y = m5.Y + part;
			Rect[8] = pnt8;

			Point pnt9 = new Point();
			pnt9.X = m5.X + part;
			pnt9.Y = m5.Y + part;
			Rect[9] = pnt9;
		}
		public  void Adjust()
		{
			float dmax = -1;
			float sizeM2 = -1;
			if (dmax < Distance(Rect[1], Rect[5]))
			{
				dmax = Distance(Rect[1], Rect[5]);
				sizeM2 = Math.Max(Math.Abs(Rect[1].X - Rect[5].X), Math.Abs(Rect[1].Y - Rect[5].Y));
			}
			if (dmax < Distance(Rect[3], Rect[5]))
			{
				dmax = Distance(Rect[3], Rect[5]);
				sizeM2 = Math.Max(Math.Abs(Rect[3].X - Rect[5].X), Math.Abs(Rect[3].Y - Rect[5].Y));
			}
			if (dmax < Distance(Rect[7], Rect[5]))
			{
				dmax = Distance(Rect[7], Rect[5]);
				sizeM2 = Math.Max(Math.Abs(Rect[7].X - Rect[5].X), Math.Abs(Rect[7].Y - Rect[5].Y));
			}
			if (dmax < Distance(Rect[9], Rect[5]))
			{
				dmax = Distance(Rect[9], Rect[5]);
				sizeM2 = Math.Max(Math.Abs(Rect[9].X - Rect[5].X), Math.Abs(Rect[9].Y - Rect[5].Y));
			}
			Size = sizeM2 * 2;
			Console.WriteLine(Size);
		}
		public void SetM()
		{
			this._Rect = new Point[10];
			this._Rect[1] = new Point(0, 0);
			this._Rect[2] = new Point(200, 0);
			this._Rect[3] = new Point(400, 0);
			this._Rect[4] = new Point(0, 200);
			this._Rect[5] = new Point(200, 200);
			this._Rect[6] = new Point(400, 200);
			this._Rect[7] = new Point(0, 400);
			this._Rect[8] = new Point(200, 400);
			this._Rect[9] = new Point(400, 400);
		}
		public void SetS()
		{
			this._Rect = new Point[10];
			this._Rect[1] = new Point(0, 0);
			this._Rect[2] = new Point(940, 0);
			this._Rect[3] = new Point(1280, 0);
			this._Rect[4] = new Point(0, 480);
			this._Rect[5] = new Point(940, 480);
			this._Rect[6] = new Point(1280, 480);
			this._Rect[7] = new Point(0, 960);
			this._Rect[8] = new Point(940, 960);
			this._Rect[9] = new Point(1280, 960);
		}
		private static float Distance(Point point1, Point point2)
		{
			//throw new NotImplementedException();
			return (float)Math.Sqrt((point1.X - point2.X) * (point1.X - point2.X) + (point1.Y - point2.Y) * (point1.Y - point2.Y));
		}

		public void MoveR(Point P5, Point M5)
		{
			//throw new NotImplementedException();
			for (int i = 1; i <= 9; i++)
			{
				Rect[i].X += P5.X - M5.X;
				Rect[i].Y += P5.Y - M5.Y;
			}
		}
		public void PrintResult()
		{
			//throw new NotImplementedException();
			for (int i = 1; i <= 9; i++)
			{
				Console.WriteLine("R" + i + " - X: " + Rect[i].X + "; " + "Y: " + Rect[i].Y);
			}
		}

		public void PreHandle(float sizeP, float sizeM, Point M5, RectangleOOP_V2 Rect)
		{
			//throw new NotImplementedException();
			float scale, top, left, right, bot, spaceH, spaceV;
			scale = sizeP / sizeM;
			left = Math.Abs(M5.X - Rect.Rect[1].X);
			left *= scale;
			bot = Math.Abs(M5.Y - Rect.Rect[1].Y);
			bot *= scale;
			right = Math.Abs(M5.X - Rect.Rect[9].X);
			right *= scale;
			top = Math.Abs(M5.Y - Rect.Rect[9].Y);
			top *= scale;
			spaceH = M5.X - Rect.Rect[5].X;
			spaceH *= scale;
			spaceV = M5.Y - Rect.Rect[5].Y;
			spaceV *= scale;

			Console.WriteLine("Left: " + left);
			Console.WriteLine("Top: " + top);
			Console.WriteLine("Right: " + right);
			Console.WriteLine("Bot: " + bot);
			Console.WriteLine("Scale: " + scale);
			Point pnt1 = new Point();
			pnt1.X = M5.X - left;
			pnt1.Y = M5.Y - bot;
			Rect.Rect[1] = pnt1;

			Point pnt2 = new Point();
			pnt2.Y = pnt1.Y;
			pnt2.X = M5.X - spaceH;
			Rect.Rect[2] = pnt2;

			Point pnt3 = new Point();
			pnt3.X = M5.X + right;
			pnt3.Y = pnt1.Y;
			Rect.Rect[3] = pnt3;

			Point pnt4 = new Point();
			pnt4.X = pnt1.X;
			pnt4.Y = M5.Y - spaceV;
			Rect.Rect[4] = pnt4;

			Point pnt5 = new Point();
			pnt5.X = pnt2.X;
			pnt5.Y = pnt4.Y;
			Rect.Rect[5] = pnt5;

			Point pnt6 = new Point();
			pnt6.X = pnt3.X;
			pnt6.Y = pnt4.Y;
			Rect.Rect[6] = pnt6;

			Point pnt7 = new Point();
			pnt7.X = pnt1.X;
			pnt7.Y = M5.Y + top;
			Rect.Rect[7] = pnt7;

			Point pnt8 = new Point();
			pnt8.X = pnt2.X;
			pnt8.Y = pnt7.Y;
			Rect.Rect[8] = pnt8;

			Point pnt9 = new Point();
			pnt9.X = pnt3.X;
			pnt9.Y = pnt7.Y;
			Rect.Rect[9] = pnt9;
		}
	}
}
