using BlokMath.Functions;
using System.Globalization;

namespace SuperCalculatorMauiApp.Pages;

public partial class ScientificCalculatorPage : ContentPage
{
    public ScientificCalculatorPage()
    {
        InitializeComponent();
    }

    private decimal firstNumber = 0, secondNumber = 0;
    private bool isSecondNumberDefault = true;
    private CalculatorOperationType operation = CalculatorOperationType.None;

    private void NumberButton_Clicked(object sender, EventArgs e)
    {
        var button = (Button)sender;
        string digit = button.Text;

        CalculatorDisplay.Text += digit;
        decimal d = decimal.Parse(CalculatorDisplay.Text);

        CalculatorDisplay.Text = d.ToString();

        // variables' update:
        if (operation == CalculatorOperationType.None)
        {
            firstNumber = decimal.Parse(CalculatorDisplay.Text);
            CalculatorDisplay.Text = firstNumber.ToString();
        }
        else
        {
            if (isSecondNumberDefault)
            {
                secondNumber = decimal.Parse(digit);
                CalculatorDisplay.Text = secondNumber.ToString();
                isSecondNumberDefault = false;
            }

            secondNumber = decimal.Parse(CalculatorDisplay.Text);
            CalculatorDisplay.Text = secondNumber.ToString();
        }
    }

    private void SetCurrentNumber(decimal value)
    {
        if (operation == CalculatorOperationType.None)
        {
            firstNumber = value;
        }
        else if (secondNumber != 0)
        {
            isSecondNumberDefault = false;
            secondNumber = value;
        }
        CalculatorDisplay.Text = value.ToString();
    }

    private void PlusMinusButton_Clicked(object sender, EventArgs e)
    {
        decimal displayValue = decimal.Parse(CalculatorDisplay.Text);
        if (displayValue < 0)
        {
            CalculatorDisplay.Text = CalculatorDisplay.Text[1..];
        }
        else if (displayValue > 0)
        {
            CalculatorDisplay.Text = "-" + CalculatorDisplay.Text;
        }

        SetCurrentNumber(decimal.Parse(CalculatorDisplay.Text));
    }

    private void OperationButton_Clicked(object sender, EventArgs e)
    {
        var button = (Button)sender;
        char opr = button.Text.FirstOrDefault();

        try
        {
            operation = (CalculatorOperationType)opr;
            secondNumber = firstNumber;
            isSecondNumberDefault = true;
        }
        catch
        {
            operation = CalculatorOperationType.None;
        }

        //switch (opr)
        //{
        //    case (char)CalculatorOperationType.Addition:
        //        operation = CalculatorOperationType.Addition;
        //        break;

        //    case (char)CalculatorOperationType.Subtraction:
        //        operation = CalculatorOperationType.Subtraction;
        //        break;

        //    case (char)CalculatorOperationType.Multiplication:
        //        operation = CalculatorOperationType.Multiplication;
        //        break;

        //    case (char)CalculatorOperationType.Division:
        //        operation = CalculatorOperationType.Division;
        //        break;

        //    default:
        //        return;
        //}
    }

    private void SqrtButton_Clicked(object sender, EventArgs e)
    {
        SetCurrentNumber(OtherFunctions.Sqrt(decimal.Parse(CalculatorDisplay.Text)));
    }

    private void EqualButton_Clicked(object sender, EventArgs e)
    {
        switch (operation)
        {
            case CalculatorOperationType.Addition:
                firstNumber += secondNumber;
                break;
            case CalculatorOperationType.Subtraction:
                firstNumber -= secondNumber;
                break;
            case CalculatorOperationType.Multiplication:
                firstNumber *= secondNumber;
                break;
            case CalculatorOperationType.Division:
                if (secondNumber == 0)
                {
                    firstNumber = 0;
                    secondNumber = 0;
                }
                else
                    firstNumber /= secondNumber;
                break;
            default:
                return;
        }
        CalculatorDisplay.Text = firstNumber.ToString();
        isSecondNumberDefault = true;
    }

    private void DecimalButton_Clicked(object sender, EventArgs e)
    {
        if (CalculatorDisplay.Text.Contains(CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator))
            return;

        if (operation != CalculatorOperationType.None && isSecondNumberDefault)
        {
            secondNumber = 0;
            CalculatorDisplay.Text = secondNumber.ToString();
            isSecondNumberDefault = false;
        }
        decimal d = decimal.Parse(CalculatorDisplay.Text);
        CalculatorDisplay.Text = d.ToString() + CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator;
    }

    private void ClearButton_Clicked(object sender, EventArgs e)
    {
        if (operation == CalculatorOperationType.None)
        {
            firstNumber = 0;
            CalculatorDisplay.Text = firstNumber.ToString();
        }
        else
        {
            secondNumber = 0;
            CalculatorDisplay.Text = secondNumber.ToString();
        }
    }

    private void ClearEntryButton_Clicked(object sender, EventArgs e)
    {
        firstNumber = 0;
        secondNumber = 0;
        isSecondNumberDefault = true;
        operation = CalculatorOperationType.None;
        CalculatorDisplay.Text = firstNumber.ToString();
    }

    private void PIButton_Clicked(object sender, EventArgs e)
    {
        SetCurrentNumber(OtherFunctions.PI);
    }

    private void EulerNumberButton_Clicked(object sender, EventArgs e)
    {
        SetCurrentNumber(OtherFunctions.EulerNumber);
    }

    private void AbsoluteButton_Clicked(object sender, EventArgs e)
    {
        // |x|
        SetCurrentNumber(OtherFunctions.AbsoluteValue(decimal.Parse(CalculatorDisplay.Text)));
    }

    private void FactorialButton_Clicked(object sender, EventArgs e)
    {
        //!n
        if (uint.TryParse(CalculatorDisplay.Text, out uint result))
            SetCurrentNumber(OtherFunctions.Factorial(result));
        //todo else ThrowAlert("nan"); // liczba nie jest liczbą naturalną
    }

    private void InversionButton_Clicked(object sender, EventArgs e)
    {
        // 1/x
        if (decimal.TryParse(CalculatorDisplay.Text, out decimal result) && result != 0)
            SetCurrentNumber(1 / result);
    }

    private void SquareButton_Clicked(object sender, EventArgs e)
    {
        if (decimal.TryParse(CalculatorDisplay.Text, out decimal result))
            SetCurrentNumber(OtherFunctions.Pow(result, 2));
    }

    private void CubeButton_Clicked(object sender, EventArgs e)
    {
        if (decimal.TryParse(CalculatorDisplay.Text, out decimal result))
            SetCurrentNumber(OtherFunctions.Pow(result, 3));
    }

    private void SquareRootButton_Clicked(object sender, EventArgs e)
    {
        if (decimal.TryParse(CalculatorDisplay.Text, out decimal result))
            SetCurrentNumber(OtherFunctions.Sqrt(result));
    }

    private void CubeRootButton_Clicked(object sender, EventArgs e)
    {
        //todo cube root
        //if (decimal.TryParse(CalculatorDisplay.Text, out decimal result))
        //    SetCurrentNumber(OtherFunctions.Sqrt(result));
    }

    private void LogButton_Clicked(object sender, EventArgs e)
    {
        // todo log
    }

    private void LogxYButton_Clicked(object sender, EventArgs e)
    {
        // todo log2
    }

    private void LogNaturalButton_Clicked(object sender, EventArgs e)
    {
        // todo ln
    }

    private void XToYPowButton_Clicked(object sender, EventArgs e)
    {
        // todo pow
        //decimal x, y;
        //SetCurrentNumber(OtherFunctions.Pow(x,y);
    }

    private void PierwiastekStopniaY_z_X_Button_Clicked(object sender, EventArgs e)
    {
        // y√x
        // todo pierwiastek
    }

    private void EulerNumberToXPowButton_Clicked(object sender, EventArgs e)
    {
        if (decimal.TryParse(CalculatorDisplay.Text, out decimal result))
            SetCurrentNumber(OtherFunctions.Pow(OtherFunctions.EulerNumber, result));
    }

    /* Trigonometry */

    private void SinButton_Clicked(object sender, EventArgs e)
    {
        decimal? result = null;
        if (decimal.TryParse(CalculatorDisplay.Text, out decimal x) && (result = TrigonometricFunctions.Sinus(x))!=null)
            SetCurrentNumber(decimal.Parse(result.ToString()));
    }

    private void CosButton_Clicked(object sender, EventArgs e)
    {
        decimal? result = null;
        if (decimal.TryParse(CalculatorDisplay.Text, out decimal x) && (result = TrigonometricFunctions.Cosinus(x)) != null)
            SetCurrentNumber(decimal.Parse(result.ToString()));
    }

    private void TgButton_Clicked(object sender, EventArgs e)
    {
        decimal? result = null;
        if (decimal.TryParse(CalculatorDisplay.Text, out decimal x) && (result = TrigonometricFunctions.Tangens(x)) != null)
            SetCurrentNumber(decimal.Parse(result.ToString()));
    }

    private void CtgButton_Clicked(object sender, EventArgs e)
    {
        decimal? result = null;
        if (decimal.TryParse(CalculatorDisplay.Text, out decimal x) && (result = TrigonometricFunctions.Cotangens(x)) != null)
            SetCurrentNumber(decimal.Parse(result.ToString()));
    }

    private void HypButton_Clicked(object sender, EventArgs e)
    {
        // todo
    }

    private enum CalculatorOperationType
    {
        None = char.MinValue,

        /* Types: */
        Addition = '+',
        Subtraction = '-',
        Multiplication = '*',
        Division = '/',
    }
}