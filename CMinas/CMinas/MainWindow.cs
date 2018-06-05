using System;
using Gtk;

public partial class MainWindow: Gtk.Window
{
	public MainWindow () : base (Gtk.WindowType.Toplevel)
	{
		Random rand = new Random ();
		uint rows ;
		uint columns ;
		uint bombs;
		uint noBombs;
		double random;
		Build ();

		button10.Clicked += delegate {			
			rows = 10;
			columns = 10;
			bombs = 20;
			noBombs = 80;
			Table table10 = new Table (rows, columns, true);
			for (uint y = 0; y < rows; y++) {						
				for (uint x = 0; x < columns; x++) {
					random = rand.NextDouble();
					Button button = new Button (" ");
					if(bombs>0 && noBombs>0){
						if(random > 0.65){
							button.Label = "Bomb";
							bombs-=1;
						}else{
							button.Label = "NoBomb";
							noBombs-=1;
						}
					}else if(bombs >0 && noBombs==0){
						button.Label = "Bomb";
						bombs-=1;
					}else if (bombs == 0 && noBombs>0){
						button.Label = "NoBomb";
						noBombs-=1;
					}
					button.Visible = true;
					table10.Attach (button , x , (x + 1) , y , (y + 1));
				}
			}
			Hide();
			table10.Visible = true;
			vbox3.Add (table10);
			LetsPlay(20);

		};

		button20.Clicked += delegate {			
			rows = 20;
			columns = 20;
			bombs = 50;
			noBombs = 350;
			Table table20 = new Table (rows, columns, true);
			for (uint y = 0; y < rows; y++) {						
				for (uint x = 0; x < columns; x++) {
					random = rand.NextDouble();
					Button button = new Button (" ");
					if(bombs>0 && noBombs>0){
						if(random > 0.8){
							button.Name = "Bomb";
							bombs-=1;
						}else{
							button.Name = "NoBomb";
							noBombs-=1;
						}
					}else if(bombs >0 && noBombs==0){
						button.Name = "Bomb";
						bombs -=1;
					}else if (bombs == 0 && noBombs>0){
						button.Name = "NoBomb";
						noBombs -=1;
					}
					button.Visible = true;
					table20.Attach (button , x , (x + 1) , y , (y + 1));
				}
			}
			Hide();
			table20.Visible = true;
			vbox3.Add (table20);
			LetsPlay(50);
		};



		button50.Clicked += delegate {
			rows = 25;
			columns = 50;
			bombs = 300;
			noBombs = 950;
			Table table50 = new Table (rows, columns, true);
			for (uint y = 0; y < rows; y++) {						
				for (uint x = 0; x < columns; x++) {
					random = rand.NextDouble();
					Button button = new Button (" ");
					if(bombs>0 && noBombs>0){
						
						if(random > 0.8){
							button.Name = "Bomb";
							bombs--;
						}else{
							button.Name = "NoBomb";
							noBombs--;
						}
					}else if(bombs >0 && noBombs==0){
						button.Name = "Bomb";
						bombs--;
					}else if (bombs == 0 && noBombs>0){
						button.Name = "NoBomb";
						noBombs--;
					}
					button.Visible = true;
					table50.Attach (button , x , (x + 1) , y , (y + 1));
				}
			}
			Hide();
			table50.Visible = true;
			vbox3.Add (table50);
			LetsPlay(300);
		};



	}

	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}
	public void Hide() {
		button10.Visible = false;
		button20.Visible = false;
		button50.Visible = false;
		button1.Visible = false;
	}
	protected void LetsPlay(int n){
		Label score = new Label();
		score.Text= "Hay "+ n +" bombas";
		score.Visible = true;
		vbox1.Add (score);
	}
	

}
