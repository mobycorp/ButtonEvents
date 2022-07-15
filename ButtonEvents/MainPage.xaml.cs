namespace ButtonEvents;

public partial class MainPage : ContentPage {

	public MainPage () {

		InitializeComponent ();
	}

	private void Button_Pressed (object sender, EventArgs e) {

		if (sender is Button button) {
			button.BackgroundColor = Colors.Red;
		}
	}

	private void Button_Released (object sender, EventArgs e) {

		if (sender is Button button) {
			button.BackgroundColor = Colors.Green;
		}
	}
}