using BlokMath.Functions;
using System.Globalization;

namespace SuperCalculatorMauiApp.Pages;

public partial class StandardCalculatorPage : ContentPage
{
    private decimal firstNumber = 0, secondNumber = 0;
    private bool isSecondNumberDefault = true;
    private CalculatorOperationType operation = CalculatorOperationType.None;

    public StandardCalculatorPage()
    {
        InitializeComponent();
    }

    private void NumberButton_Clicked(string digit)
    {
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

    #region Number buttons

    private void ZeroNumberButton_Clicked(object sender, EventArgs e)
    {
        NumberButton_Clicked("0");
    }

    private void OneNumberButton_Clicked(object sender, EventArgs e)
    {
        NumberButton_Clicked("1");
    }

    private void TwoNumberButton_Clicked(object sender, EventArgs e)
    {
        NumberButton_Clicked("2");
    }

    private void ThreeNumberButton_Clicked(object sender, EventArgs e)
    {
        NumberButton_Clicked("3");
    }

    private void FourNumberButton_Clicked(object sender, EventArgs e)
    {
        NumberButton_Clicked("4");
    }

    private void FiveNumberButton_Clicked(object sender, EventArgs e)
    {
        NumberButton_Clicked("5");
    }

    private void SixNumberButton_Clicked(object sender, EventArgs e)
    {
        NumberButton_Clicked("6");
    }

    private void SevenNumberButton_Clicked(object sender, EventArgs e)
    {
        NumberButton_Clicked("7");
    }

    private void EightNumberButton_Clicked(object sender, EventArgs e)
    {
        NumberButton_Clicked("8");
    }

    private void NineNumberButton_Clicked(object sender, EventArgs e)
    {
        NumberButton_Clicked("9");
    }

    #endregion

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

        if (isSecondNumberDefault && firstNumber != secondNumber && firstNumber != 0)
        {
            firstNumber = decimal.Parse(CalculatorDisplay.Text);
        }
        else if (secondNumber != 0)
        {
            secondNumber = decimal.Parse(CalculatorDisplay.Text);
        }
    }

    private void OperationButton_Clicked(char opr)
    {
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

    #region Operator buttons

    private void AdditionOperationButton_Clicked(object sender, EventArgs e)
    {
        OperationButton_Clicked('+');
    }

    private void SubstractionOperationButton_Clicked(object sender, EventArgs e)
    {
        OperationButton_Clicked('-');
    }

    private void MultiplicationOperationButton_Clicked(object sender, EventArgs e)
    {
        OperationButton_Clicked('*');
    }

    private void DivisionOperationButton_Clicked(object sender, EventArgs e)
    {
        OperationButton_Clicked('/');
    }

    #endregion

    private void SqrtButton_Clicked(object sender, EventArgs e)
    {
        if (operation == CalculatorOperationType.None)
        {
            firstNumber = OtherFunctions.SquareRoot(decimal.Parse(CalculatorDisplay.Text));
            CalculatorDisplay.Text = firstNumber.ToString();
        }
        else
        {
            secondNumber = OtherFunctions.SquareRoot(decimal.Parse(CalculatorDisplay.Text));
            CalculatorDisplay.Text = secondNumber.ToString();
        }
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