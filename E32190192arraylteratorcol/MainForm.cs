/*
 * Created by SharpDevelop.
 * User: lenovo
 * Date: 25/03/2020
 * Time: 04.39
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.ObjectModel;

namespace E32190192arraylteratorcol
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		ObjectHandler[] boxArray = new ObjectHandler[25];
		Collection<ObjectHandler> boxCollection = new Collection<ObjectHandler>();
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			CreateBox();
			
			button1.Text="Array: fot-next";
			button2.Text="Array: foreach";
			button3.Text="Collection: for-next";
			button4.Text="collection: foreach";
			button5.Text="array: while";
			button6.Text="array: do-while";
			
		}
		
		private void CreateBox(){
			int i=0;
			for (int x = 0; x<5; x++){
				for (int y = 0; y < 5; y++) {
					boxArray[i] = new ObjectHandler(new PictureBox(),
					                                this, 32 + x * 30, 110 + y * 30);
					boxCollection.Add(boxArray[i]);
					i++;
				}
			}
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			for (int i = 0; i < 25; i++) {
				boxCollection[i].RandomColor();
			}
		}
		void Button1Click(object sender, EventArgs e)
		{
			for (int i = 0; i < 25; i++) {
				boxArray[i].RandomColor();
			}
		}
		void Button2Click(object sender, EventArgs e)
		{
			foreach (var box in boxArray){
				box.RandomColor();
			}
		}
		void Button4Click(object sender, EventArgs e)
		{
			foreach (var box in boxCollection){
				box.RandomColor();
			}
		}
		void Button5Click(object sender, EventArgs e)
		{
			int i = 0;
			while (i<25) {
				boxArray[i].RandomColor();
				i++;
			}
		}
		void Button6Click(object sender, EventArgs e)
		{
			int i = 0;
			do{
				boxArray[i].RandomColor();
				i++;
			}while (i<25);
		}
	}
}
