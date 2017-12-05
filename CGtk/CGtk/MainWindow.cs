using System;
using Gtk;

public partial class MainWindow: Gtk.Window
{
	public MainWindow () : base (Gtk.WindowType.Toplevel)
	{

		Build ();

		buttonSuma.Clicked += delegate {
			int primero = int.Parse(entryNombre1.Text);
			int segundo = int.Parse(entry2.Text);
			labelResultado.Text = ""+(primero + segundo)+"";
		};
		buttonResta.Clicked += delegate {
			int primero = int.Parse(entryNombre1.Text);
			int segundo = int.Parse(entry2.Text);
			labelResultado.Text = ""+(primero - segundo)+"";
		};
		buttonMulti.Clicked += delegate {
			int primero = int.Parse(entryNombre1.Text);
			int segundo = int.Parse(entry2.Text);
			labelResultado.Text = ""+(primero * segundo)+"";
		};
		buttonDiv.Clicked += delegate {
			double primero = double.Parse(entryNombre1.Text);
			double segundo = double.Parse(entry2.Text);
			labelResultado.Text = ""+(primero / segundo)+"";
		};

	}

	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}
}
