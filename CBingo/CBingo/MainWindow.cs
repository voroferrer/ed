using System;
using Gtk;

public partial class MainWindow: Gtk.Window
{
	public MainWindow () : base (Gtk.WindowType.Toplevel)
	{
		Build ();
		Table table = new Table (9, 10, true);
		for (int x = 0; x < 10; x++) {
			for (int i = 0; i < 10; i++) {
				Button button = new Button ();
				button.Label = x + "" + i;
				button.Visible = true;

				table.Attach (button, (uint)i, (uint)(i + 1), (uint)x, (uint)x+1);

			}
		}
		table.Visible = true;
		vBoxMain.Add (table);
	}

	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}
}
