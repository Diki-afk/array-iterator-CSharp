/*
 * Created by SharpDevelop.
 * User: lenovo
 * Date: 25/03/2020
 * Time: 04.40
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace E32190192arraylteratorcol
{
	/// <summary>
	/// Description of Class1.
	/// </summary>
	public class ObjectHandler
	{
		private Color color = Color.Blue;
		private PictureBox box;
		private static Random rnd = new Random();
		
		public ObjectHandler(PictureBox picbox,Form parent, int x, int y)
		{
			box= picbox;
			box.Parent = parent;
			box.Width= 16;
			box.Height=15;
			box.Location= new Point(x,y);
			box.BackColor=color;
		}
		public void RandomColor(){
			int r = rnd.NextDouble()>0.5d?255:0;
			int g = rnd.NextDouble()>0.5d?255:0;
			int b = rnd.NextDouble()>0.5d? 255:0;
			color= Color.FromArgb(r, g, b);
			box.BackColor=color;
		}
	}
}
