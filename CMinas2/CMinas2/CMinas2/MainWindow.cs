using System;
using Gtk;
using System.Collections.Generic;

public partial class MainWindow: Gtk.Window
{
	private uint rows;
	private uint columns;
	private uint restantes;
	private List<Button> buttons = new List<Button>();
	private List<Button> bombas = new List<Button>();
	public MainWindow () : base (Gtk.WindowType.Toplevel)
	{
		Random rand = new Random ();
		uint bombs;
		uint noBombs;
		double random;
		Build ();
		button10.Clicked += delegate {			
			rows = 10;
			columns = 10;
			bombs = 1;
			noBombs = 99;
			restantes = noBombs;
			Table table10 = new Table (rows, columns, true);
			for (uint y = 0; y < rows; y++) {						
				for (uint x = 0; x < columns; x++) {
					random = rand.NextDouble();
					Button button = new Button (" ");
					buttons.Add(button);
					if(bombs>0 && noBombs>0){
						if(random > 0.65){
							bombas.Add(button);
							bombs-=1;
						}else{

							noBombs-=1;
						}
					}else if(bombs >0 && noBombs==0){
						bombas.Add(button);
						bombs-=1;
					}else if (bombs == 0 && noBombs>0){

						noBombs-=1;
					}
					button.Visible = true;
					button.Clicked += delegate {
						vecinos(button);
					};
					table10.Attach (button , x , (x + 1) , y , (y + 1));
				}
			}
			Hiden();
			table10.Visible = true;
			vbox1.Add (table10);


		};

		button20.Clicked += delegate {			
			rows = 20;
			columns = 20;
			bombs = 50;
			noBombs = 350;
			restantes = noBombs;
			Table table20 = new Table (rows, columns, true);
			for (uint y = 0; y < rows; y++) {						
				for (uint x = 0; x < columns; x++) {
					random = rand.NextDouble();
					Button button = new Button (" ");
					buttons.Add(button);
					if(bombs>0 && noBombs>0){
						if(random > 0.8){
							bombas.Add(button);
							bombs-=1;

						}else{
							button.Name = "NoBomb";
							noBombs-=1;
						}
					}else if(bombs >0 && noBombs==0){
						bombas.Add(button);
						bombs -=1;
					}else if (bombs == 0 && noBombs>0){
						button.Name = "NoBomb";
						noBombs -=1;
					}
					button.Visible = true;
					button.Clicked += delegate {
						vecinos(button);
					};
					table20.Attach (button , x , (x + 1) , y , (y + 1));
				}
			}
			Hiden();
			table20.Visible = true;
			vbox1.Add (table20);

		};



		button50.Clicked += delegate {
			rows = 25;
			columns = 50;
			bombs = 300;
			noBombs = 950;
			restantes = noBombs;
			Table table50 = new Table (rows, columns, true);
			for (uint y = 0; y < rows; y++) {						
				for (uint x = 0; x < columns; x++) {
					random = rand.NextDouble();
					Button button = new Button (" ");
					buttons.Add(button);
					if(bombs>0 && noBombs>0){

						if(random > 0.8){
							bombas.Add(button);
							bombs--;
						}else{
							button.Name = "NoBomb";
							noBombs--;
						}
					}else if(bombs >0 && noBombs==0){
						bombas.Add(button);
						bombs--;
					}else if (bombs == 0 && noBombs>0){
						button.Name = "NoBomb";
						noBombs--;
					}
					button.Visible = true;
					button.Clicked += delegate {
						vecinos(button);
					};
					table50.Attach (button , x , (x + 1) , y , (y + 1));
				}
			}
			Hiden();
			table50.Visible = true;
			vbox1.Add (table50);

		};



	}

	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}
	public void Hiden() {
		button10.Visible = false;
		button20.Visible = false;
		button50.Visible = false;

	}
	private void vecinos(Button button) {
		uint index = (uint)buttons.IndexOf (button);//valor a obtener del button
		if (bombas.Contains (button)) {
			Label label = new Label ();
			label.Text = "GAME OVER";
			label.Visible = true;
			for (int i = 0; i < buttons.Count; i++) {
				buttons[i].Visible = false;
			}
			vbox1.Add (label);
		} else {
			int bombasVecinos = 0;
			uint row = index / rows;
			uint column = index % columns;
			uint topRow = row == 0 ? 0 : row - 1;
			uint bottomRow = row == rows - 1 ? rows - 1 : row + 1;
			uint leftColumn = column == 0 ? 0 : column - 1;
			uint rightColumn = column == columns - 1 ? columns - 1 : column + 1;
			for (uint indexRow = topRow; indexRow <= bottomRow; indexRow++) {
				for (uint indexColumn = leftColumn; indexColumn <= rightColumn; indexColumn++) {
					uint indexButton = indexRow * columns + indexColumn;
					Button buttonVecino = buttons [(int)indexButton];
					if (bombas.Contains (buttonVecino)) {
						bombasVecinos++;
					}
					if (bombasVecinos == 0) {
						button.Label = "" + bombasVecinos;
					} else {
						button.Label = "" + bombasVecinos;
					}

				}
			}
			restantes--;
			if (restantes == 0) {
				Label label = new Label ();
				label.Text = "VICTORIA";
				label.Visible = true;
				for (int i = 0; i < buttons.Count; i++) {
					buttons[i].Visible = false;
				}
				vbox1.Add (label);
			}
		}
	}

}