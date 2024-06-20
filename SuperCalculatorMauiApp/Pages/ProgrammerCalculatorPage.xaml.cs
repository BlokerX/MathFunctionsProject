using BlokMath.Functions;

namespace SuperCalculatorMauiApp.Pages;

public partial class ProgrammerCalculatorPage : ContentPage
{
    public ProgrammerCalculatorPage()
    {
        InitializeComponent();
    }

    private bool isChanging = false;

    private void bin_entry_TextChanged(object sender, TextChangedEventArgs e)
    {
        if (isChanging) return;

        isChanging = true;

        int number = 0;
        if (int.TryParse(((Entry)sender).Text, out number))
        {
            hex_entry.Text = NumberSystems.BinaryToHex(number.ToString());
            dec_entry.Text = NumberSystems.BinaryToDecimal(number.ToString()).ToString();
            oct_entry.Text = NumberSystems.BinaryToOctal(number.ToString());
        }
        else number = 0;

        isChanging = false;
    }

    private void oct_entry_TextChanged(object sender, TextChangedEventArgs e)
    {
        if (isChanging) return;

        isChanging = true;

        int number = 0;
        if (int.TryParse(((Entry)sender).Text, out number))
        {
            hex_entry.Text = NumberSystems.OctalToHex(number.ToString());
            dec_entry.Text = NumberSystems.OctalToDecimal(number.ToString()).ToString();
            bin_entry.Text = NumberSystems.OctalToBinary(number.ToString());
        }
        else number = 0;

        isChanging = false;
    }

    private void dec_entry_TextChanged(object sender, TextChangedEventArgs e)
    {
        if (isChanging) return;

        isChanging = true;

        int number = 0;
        if (int.TryParse(((Entry)sender).Text, out number))
        {
            hex_entry.Text = NumberSystems.DecimalToHex(number);
            oct_entry.Text = NumberSystems.DecimalToOctal(number);
            bin_entry.Text = NumberSystems.DecimalToBinary(number);
        }
        else number = 0;

        isChanging = false;
    }

    private void hex_entry_TextChanged(object sender, TextChangedEventArgs e)
    {
        if (isChanging) return;

        isChanging = true;

        int number = 0;
        if (int.TryParse(((Entry)sender).Text, out number))
        {
            dec_entry.Text = NumberSystems.HexToDecimal(number.ToString()).ToString();
            oct_entry.Text = NumberSystems.HexToOctal(number.ToString());
            bin_entry.Text = NumberSystems.HexToBinary(number.ToString());
        }
        else number = 0;

        isChanging = false;
    }
}