using System;
using Gtk;
using System.Collections.Generic;
using Gdk;

public partial class MainWindow: Gtk.Window
{
	private static Color COLOR_GREEN = new Color(0,255,0);
	public MainWindow () : base (Gtk.WindowType.Toplevel)
	{
		Build ();


		uint rows = 9;
		uint columns = 10;
		List<Button> buttons = new List<Button>();
		Table table = new Table (rows, columns, true);
/*		for (uint y = 0; y < rows; y++) {
			for (uint x = 0; x < columns; x++) {
				Button button = new Button ();
				button.Label = ((y * 10) + (x+1)).ToString();
				button.Visible = true;
				table.Attach (button , x , (x + 1) , y , (y + 1));


			}
		}
		*/
		//buttonAdelante.ModifyBg(StateType.Normal, COLOR_GREEN);



		for (uint y = 0; y < 90; y++) {			
			Button button = new Button ();
			button.Label = (y+1).ToString();
			button.Visible = true;
			uint row = y/10;
			uint column = y%10;
			table.Attach (button , column , (column + 1) , row , (row+ 1));
			buttons.Add (button);
			}
		List<int> bolas = new List<int> ();	
		for (int bola=1; bola<=90; bola++)
			bolas.Add(bola);



		table.Visible = true;
		vBoxMain.Add (table);
		Random rand = new Random ();
		buttonAdelante.Clicked += delegate {
			
			int index = rand.Next(bolas.Count);
			int bola = bolas[index];
			bolas.Remove(bola);
			int i = bola-1;
			buttons[i].ModifyBg(StateType.Normal, COLOR_GREEN);
			if(bolas.Count == 0){
				buttonAdelante.Hide();
			}
		};
	}

	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}
}
