using System.Diagnostics;

namespace NTscam;

public partial class MainPage : ContentPage
{
	int Test = 0;
	public MainPage()
	{
		InitializeComponent();
	}
    private void Køb_Clicked(System.Object sender, System.EventArgs e)
    {
		Test++;
    }
}

