using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        float answer;
        string temp1Str;
        string temp2Str;
        int whatOperator;
        bool answerMade = false;
        // 1 = plus
        // 2 = minus
        // 3 = *
        // 4 = /
        // 5 = MOD
        // 6 = power


        int opNo = 1;
        bool shiftTrue;
        bool alphaTrue;

        float aVal;
        float bVal;
        float xVal;
        float yVal;
        bool storeTrue;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void _1btn_Click(object sender, RoutedEventArgs e)
        {
            TextChange();
            Answertxt.Text = Answertxt.Text + "1";
            if(opNo == 2)
            {
                temp2Str += "1";
            }
            else
            {
                temp1Str += "1";
            }
        }

        private void _2btn_Click(object sender, RoutedEventArgs e)
        {
            TextChange();
            Answertxt.Text = Answertxt.Text + "2";
            if (opNo == 2)
            {
                temp2Str += "2";
            }
            else
            {
                temp1Str += "2";
            }
        }

        private void _3btn_Click(object sender, RoutedEventArgs e)
        {
            TextChange();
            Answertxt.Text = Answertxt.Text + "3";
            if (opNo == 2)
            {
                temp2Str += "3";
            }
            else
            {
                temp1Str += "3";
            }
        }

        private void _4btn_Click(object sender, RoutedEventArgs e)
        {
            TextChange();
            Answertxt.Text = Answertxt.Text + "4";
            if (opNo == 2)
            {
                temp2Str += "4";
            }
            else
            {
                temp1Str += "4";
            }
        }

        private void _5btn_Click(object sender, RoutedEventArgs e)
        {
            TextChange();
            Answertxt.Text = Answertxt.Text + "5";
            if (opNo == 2)
            {
                temp2Str += "5";
            }
            else
            {
                temp1Str += "5";
            }
        }

        private void _6btn_Click(object sender, RoutedEventArgs e)
        {
            TextChange();
            Answertxt.Text = Answertxt.Text + "6";
            if (opNo == 2)
            {
                temp2Str += "6";
            }
            else
            {
                temp1Str += "6";
            }
        }

        private void _7btn_Click(object sender, RoutedEventArgs e)
        {
            TextChange();
            Answertxt.Text = Answertxt.Text + "7";
            if (opNo == 2)
            {
                temp2Str += "7";
            }
            else
            {
                temp1Str += "7";
            }
        }

        private void _8btn_Click(object sender, RoutedEventArgs e)
        {
            TextChange();
            Answertxt.Text = Answertxt.Text + "8";
            if (opNo == 2)
            {
                temp2Str += "8";
            }
            else
            {
                temp1Str += "8";
            }
        }

        private void _9btn_Click(object sender, RoutedEventArgs e)
        {
            TextChange();
            Answertxt.Text = Answertxt.Text + "9";
            if (opNo == 2)
            {
                temp2Str += "9";
            }
            else
            {
                temp1Str += "9";
            }
        }

        private void _0btn_Click(object sender, RoutedEventArgs e)
        {
            TextChange();
            Answertxt.Text = Answertxt.Text + "0";
            if (opNo == 2)
            {
                temp2Str += "0";
            }
            else
            {
                temp1Str += "0";
            }
        }

        private void Equalsbtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                alphaTrue = false;
                shiftTrue = false;
                storeTrue = false;
                ChangeShiftAlpha();
                if (opNo == 1)
                {
                    //temp1 = float.Parse(Answertxt.Text);
                    AnswerBoxtxt.Text = temp1Str;
                    answer = float.Parse(temp1Str);
                    Answertxt.Text = "";
                    temp1Str = "";
                    temp2Str = "";
                }
                else
                {
                    Equals();
                }
            }
            catch
            {
                Answertxt.Text = "Syntax Error";
                ResetAll();
                answerMade = true;
            }
        }

        private void Clearbtn_Click(object sender, RoutedEventArgs e)
        {
            ResetAll();
            Answertxt.Text = "";
        }

        private void Minusbtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (Answertxt.Text == "")
                {
                    Answertxt.Text = answer.ToString();
                    temp1Str = answer.ToString();
                }
                if (opNo < 2)
                {
                    whatOperator = 2;
                    //if (opNo == 1)
                    //{
                    //    temp1 = float.Parse(Answertxt.Text);
                    //}
                    opNo += 1;
                    Answertxt.Text += " - ";
                    answerMade = false;
                }
                else
                {
                    temp1Str = (FindCalc(float.Parse(temp1Str), float.Parse(temp2Str))).ToString();
                    temp2Str = "";
                    Answertxt.Text = temp1Str;
                    opNo = 2;
                    whatOperator = 2;
                    Answertxt.Text += " - ";
                }
            }
            catch
            {
                Answertxt.Text = "Syntax Error";
                ResetAll();
                answerMade = true;
            }
        }

        private void Plusbtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (Answertxt.Text == "")
                {
                    temp1Str = answer.ToString();
                    Answertxt.Text = answer.ToString();
                }
                if (opNo < 2)
                {
                    whatOperator = 1;
                    opNo += 1;
                    Answertxt.Text += " + ";
                    answerMade = false;
                }
                else
                {
                    temp1Str = (FindCalc(float.Parse(temp1Str), float.Parse(temp2Str))).ToString();
                    temp2Str = "";
                    Answertxt.Text = temp1Str;
                    opNo = 2;
                    whatOperator = 1;
                    Answertxt.Text += " + ";
                }
            }
            catch
            {
                Answertxt.Text = "Syntax Error";
                ResetAll();
                answerMade = true;
            }
        }

        private void Decbtn_Click(object sender, RoutedEventArgs e)
        {
            Answertxt.Text += ".";
            if (opNo == 2)
            {
                temp2Str += ".";
            }
            else
            {
                temp1Str += ".";
            }
        }

        private void Equals()
        {
            try
            {
                switch(whatOperator)
                {
                    case 1:
                        temp1Str = (float.Parse(temp1Str) + float.Parse(temp2Str)).ToString();
                        AnswerBoxtxt.Text = temp1Str;
                        break;
                    case 2:
                        temp1Str = (float.Parse(temp1Str) - float.Parse(temp2Str)).ToString();
                        AnswerBoxtxt.Text = temp1Str;
                        break;
                    case 3:
                        temp1Str = (float.Parse(temp1Str) * float.Parse(temp2Str)).ToString();
                        AnswerBoxtxt.Text = temp1Str;
                        break;
                    case 4:
                        temp1Str = (float.Parse(temp1Str) / float.Parse(temp2Str)).ToString();
                        AnswerBoxtxt.Text = temp1Str;
                        break;
                    case 5:
                        temp1Str = (float.Parse(temp1Str) % float.Parse(temp2Str)).ToString();
                        AnswerBoxtxt.Text = temp1Str;
                        break;
                    case 6:
                        double tempDouble = double.Parse(temp1Str);
                        temp1Str = (Math.Pow(double.Parse(temp1Str), double.Parse(temp2Str))).ToString();
                        AnswerBoxtxt.Text = temp1Str;
                        break;
                    default:
                        break;
                }
                answer = float.Parse(temp1Str);
                Answertxt.Text = "";
                temp1Str = "";
                temp2Str = "";
                opNo = 1;
                answerMade = true;
            }
            catch
            {
                Answertxt.Text = "Syntax Error";
                ResetAll();
                answerMade = true;
            }
        }

        private void TextChange()
        {
            if(answerMade == true)
            {
                Answertxt.Text = "";
                answerMade = false;
            }
        }

        private void Timesbtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (Answertxt.Text == "")
                {
                    temp1Str = answer.ToString();
                    Answertxt.Text = answer.ToString();
                }
                if (opNo < 2)
                {
                    whatOperator = 3;
                    opNo += 1;
                    Answertxt.Text += " * ";
                    answerMade = false;
                }
                else
                {
                    temp1Str = (FindCalc(float.Parse(temp1Str), float.Parse(temp2Str))).ToString();
                    temp2Str = "";
                    Answertxt.Text = temp1Str;
                    opNo = 2;
                    whatOperator = 3;
                    Answertxt.Text += " * ";
                }
            }
            catch
            {
                Answertxt.Text = "Syntax Error";
                ResetAll();
                answerMade = true;
            }
        }

        private void Dividebtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (Answertxt.Text == "")
                {
                    Answertxt.Text = answer.ToString();
                    temp1Str = answer.ToString();
                }
                if (opNo < 2)
                {
                    whatOperator = 4;
                    opNo += 1;
                    Answertxt.Text += " / ";
                    answerMade = false;
                }
                else
                {
                    temp1Str = (FindCalc(float.Parse(temp1Str), float.Parse(temp2Str))).ToString();
                    temp2Str = "";
                    Answertxt.Text = temp1Str;
                    opNo = 2;
                    whatOperator = 4;
                    Answertxt.Text += " / ";
                }
            }
            catch
            {
                Answertxt.Text = "Syntax Error";
                ResetAll();
                answerMade = true;
            }
        }

        private void ResetAll()
        {
            storeTrue = false;
            shiftTrue = false;
            alphaTrue = false;
            ChangeShiftAlpha();
            temp1Str = "";
            temp2Str = "";
            opNo = 1;
            AnswerBoxtxt.Text = "";
            answerMade = true;
        }
        
        private void Ansbtn_Click(object sender, RoutedEventArgs e)
        {
            TextChange();
            if (opNo < 3)
            {
                Answertxt.Text += answer.ToString();
                if(opNo == 1)
                {
                    temp1Str = answer.ToString();
                }
                else
                {
                    temp2Str += answer.ToString();
                }
            }
            else
            {
                Answertxt.Text = "Syntax Error";
                ResetAll();
                answerMade = true;
            }
        }

        private void Modbtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if(Answertxt.Text == "")
                {
                    temp1Str = answer.ToString();
                    Answertxt.Text = answer.ToString();
                }
                if (opNo < 2)
                {
                    whatOperator = 5;
                    opNo += 1;
                    Answertxt.Text += " % ";
                }
                else
                {
                    temp1Str = (FindCalc(float.Parse(temp1Str), float.Parse(temp2Str))).ToString();
                    temp2Str = "";
                    Answertxt.Text = temp1Str;
                    opNo = 2;
                    whatOperator = 5;
                    Answertxt.Text += " % ";
                    //Answertxt.Text = "Syntax Error";
                    //ResetAll();
                }
            }
            catch
            {
                Answertxt.Text = "Syntax Error";
                ResetAll();
                answerMade = true;
            }
        }

        private float FindCalc(float No1, float No2)
        {
            float No3 = 0;
            switch(whatOperator)
            {
                case 1:
                    No3 = No1 + No2;
                    break;
                case 2:
                    No3 = No1 - No2;
                    break;
                case 3:
                    No3 = No1 * No2;
                    break;
                case 4:
                    No3 = No1 / No2;
                    break;
                case 5:
                    No3 = No1 % No2;
                    break;
                case 6:
                    double No1doub = No1;
                    double No2doub = No2;
                    No3 = (float)(Math.Pow(No1doub, No2doub));
                    break;
                default:
                    break;
            }
            return No3;
        }

        private void Recbtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (Answertxt.Text == "")
                {
                    temp1Str = answer.ToString();
                    Answertxt.Text = answer.ToString();
                }
                if (opNo == 1)
                {
                    temp1Str = (1 / float.Parse(temp1Str)).ToString();
                    Answertxt.Text = temp1Str;
                }
                else if (opNo == 2)
                {
                    temp2Str = (1 / (float.Parse(temp2Str))).ToString();
                    Answertxt.Text = temp1Str;
                    switch (whatOperator)
                    {
                        case 1:
                            Answertxt.Text += " + ";
                            break;
                        case 2:
                            Answertxt.Text += " - ";
                            break;
                        case 3:
                            Answertxt.Text += " * ";
                            break;
                        case 4:
                            Answertxt.Text += " / ";
                            break;
                        case 5:
                            Answertxt.Text += " % ";
                            break;
                        case 6:
                            Answertxt.Text += " ^ ";
                            break;
                        default:
                            break;
                    }
                    Answertxt.Text += temp2Str;
                }
                else
                {
                    Answertxt.Text = "Syntax Error";
                    ResetAll();
                    answerMade = true;
                }
            }
            catch
            {
                Answertxt.Text = "Syntax Error";
                ResetAll();
                answerMade = true;
            }
        }

        private void PlusMinus_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (Answertxt.Text == "")
                {
                    Answertxt.Text = answer.ToString();
                    temp1Str = answer.ToString();
                }
                if (opNo == 1)
                {
                    temp1Str = (-(float.Parse(temp1Str))).ToString();
                    Answertxt.Text = temp1Str;
                }
                else if (opNo == 2)
                {
                    temp2Str = (-(float.Parse(temp2Str))).ToString();
                    Answertxt.Text = temp1Str;
                    switch (whatOperator)
                    {
                        case 1:
                            Answertxt.Text += " + ";
                            break;
                        case 2:
                            Answertxt.Text += " - ";
                            break;
                        case 3:
                            Answertxt.Text += " * ";
                            break;
                        case 4:
                            Answertxt.Text += " / ";
                            break;
                        case 5:
                            Answertxt.Text += " % ";
                            break;
                        case 6:
                            Answertxt.Text += " ^ ";
                            break;
                        default:
                            break;
                    }
                    Answertxt.Text += temp2Str;
                }
                else
                {
                    Answertxt.Text = "Syntax Error";
                    ResetAll();
                    answerMade = true;
                }
            }
            catch{
                Answertxt.Text = "Syntax Error";
                ResetAll();
                answerMade = true;
            }
        }

        private void SquareRoot_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (alphaTrue)
                {
                    TextChange();
                    if (opNo == 1)
                    {
                        Answertxt.Text += yVal.ToString();
                    }
                    else
                    {
                        Answertxt.Text += yVal.ToString();
                        temp2Str += yVal.ToString();
                    }
                    alphaTrue = false;
                    ChangeShiftAlpha();
                }
                else if (storeTrue)
                {
                    yVal = answer;
                    storeTrue = false;
                    ChangeShiftAlpha();
                    Answertxt.Text = "Y --> " + yVal.ToString();
                    answerMade = true;
                }
                else
                {
                    if (Answertxt.Text == "")
                    {
                        temp1Str = answer.ToString();
                        Answertxt.Text = answer.ToString();
                    }
                    if (opNo == 1)
                    {
                        double tempDouble = double.Parse(temp1Str);
                        temp1Str = Math.Sqrt(tempDouble).ToString();
                        Answertxt.Text = temp1Str;
                    }
                    else if (opNo == 2)
                    {
                        temp2Str = Math.Sqrt(double.Parse(temp2Str)).ToString();
                        Answertxt.Text = temp1Str;
                        switch (whatOperator)
                        {
                            case 1:
                                Answertxt.Text += " + ";
                                break;
                            case 2:
                                Answertxt.Text += " - ";
                                break;
                            case 3:
                                Answertxt.Text += " * ";
                                break;
                            case 4:
                                Answertxt.Text += " / ";
                                break;
                            case 5:
                                Answertxt.Text += " % ";
                                break;
                            case 6:
                                Answertxt.Text += " ^ ";
                                break;
                            default:
                                break;
                        }
                        Answertxt.Text += temp2Str;
                    }
                    else
                    {
                        Answertxt.Text = "Syntax Error";
                        ResetAll();
                        answerMade = true;
                    }
                }
            }
            catch
            {
                Answertxt.Text = "Syntax Error";
                ResetAll();
                answerMade = true;
            }
        }

        private void Round_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (alphaTrue)
                {
                    TextChange();
                    if (opNo == 1)
                    {
                        Answertxt.Text += aVal.ToString();
                    }
                    else
                    {
                        Answertxt.Text += aVal.ToString();
                        temp2Str += aVal.ToString();
                    }
                    alphaTrue = false;
                    ChangeShiftAlpha();
                }
                else if (storeTrue)
                {
                    aVal = answer;
                    storeTrue = false;
                    ChangeShiftAlpha();
                    Answertxt.Text = "A --> " + aVal.ToString();
                    answerMade = true;
                }
                else
                {
                    if (Answertxt.Text == "")
                    {
                        temp1Str = answer.ToString();
                        Answertxt.Text = answer.ToString();
                    }
                    if (opNo == 1)
                    {
                        //Answertxt.Text = "√" + temp1.ToString();
                        double tempDouble = double.Parse(temp1Str);
                        temp1Str = Math.Round(tempDouble).ToString();
                        Answertxt.Text = temp1Str;
                    }
                    else if (opNo == 2)
                    {
                        //Answertxt.Text += "√" + temp2Str;
                        temp2Str = Math.Round(double.Parse(temp2Str)).ToString();
                        Answertxt.Text = temp1Str;
                        switch (whatOperator)
                        {
                            case 1:
                                Answertxt.Text += " + ";
                                break;
                            case 2:
                                Answertxt.Text += " - ";
                                break;
                            case 3:
                                Answertxt.Text += " * ";
                                break;
                            case 4:
                                Answertxt.Text += " / ";
                                break;
                            case 5:
                                Answertxt.Text += " % ";
                                break;
                            case 6:
                                Answertxt.Text += " ^ ";
                                break;
                            default:
                                break;
                        }
                        Answertxt.Text += temp2Str;
                    }
                    else
                    {
                        Answertxt.Text = "Syntax Error";
                        ResetAll();
                        answerMade = true;
                    }
                }
            }
            catch
            {
                Answertxt.Text = "Syntax Error";
                ResetAll();
                answerMade = true;
            }
        }

        private void Floor_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (alphaTrue)
                {
                    TextChange();
                    if (opNo == 1)
                    {
                        Answertxt.Text += bVal.ToString();
                    }
                    else
                    {
                        Answertxt.Text += bVal.ToString();
                        temp2Str += bVal.ToString();
                    }
                    alphaTrue = false;
                    ChangeShiftAlpha();
                }
                else if (storeTrue)
                {
                    bVal = answer;
                    storeTrue = false;
                    ChangeShiftAlpha();
                    Answertxt.Text = "B --> " + bVal.ToString();
                    answerMade = true;
                }
                else
                {
                    if (Answertxt.Text == "")
                    {
                        Answertxt.Text = answer.ToString();
                        temp1Str = answer.ToString();
                    }
                    if (opNo == 1)
                    {
                        //Answertxt.Text = "√" + temp1.ToString();
                        double tempDouble = double.Parse(temp1Str);
                        temp1Str = Math.Floor(tempDouble).ToString();
                        Answertxt.Text = temp1Str;
                    }
                    else if (opNo == 2)
                    {
                        //Answertxt.Text += "√" + temp2Str;
                        temp2Str = Math.Floor(double.Parse(temp2Str)).ToString();
                        Answertxt.Text = temp1Str;
                        switch (whatOperator)
                        {
                            case 1:
                                Answertxt.Text += " + ";
                                break;
                            case 2:
                                Answertxt.Text += " - ";
                                break;
                            case 3:
                                Answertxt.Text += " * ";
                                break;
                            case 4:
                                Answertxt.Text += " / ";
                                break;
                            case 5:
                                Answertxt.Text += " % ";
                                break;
                            case 6:
                                Answertxt.Text += " ^ ";
                                break;
                            default:
                                break;
                        }
                        Answertxt.Text += temp2Str;
                    }
                    else
                    {
                        Answertxt.Text = "Syntax Error";
                        ResetAll();
                        answerMade = true;
                    }
                }
            }
            catch
            {
                Answertxt.Text = "Syntax Error";
                ResetAll();
                answerMade = true;
            }
        }

        private void Shift_Click(object sender, RoutedEventArgs e)
        {
            storeTrue = false;
            if (shiftTrue)
            {
                shiftTrue = false;
                alphaTrue = false;
                storeTrue = false;
                ChangeShiftAlpha();
            }
            else
            {
                shiftTrue = true;
                alphaTrue = false;
                storeTrue = false;
                ChangeShiftAlpha();
            }
        }

        private void Alpha_Click(object sender, RoutedEventArgs e)
        {
            storeTrue = false;
            if (alphaTrue)
            {
                alphaTrue = false;
                shiftTrue = false;
                storeTrue = false;
                ChangeShiftAlpha();
            }
            else
            {
                alphaTrue = true;
                shiftTrue = false;
                storeTrue = false;
                ChangeShiftAlpha();
            }
        }

        private void ChangeShiftAlpha()
        {
            if (alphaTrue)
            {
                ShiftAlphalbl.Content = "A";
            }
            else if(shiftTrue)
            {
                ShiftAlphalbl.Content = "S";
            }
            else if(storeTrue)
            {
                ShiftAlphalbl.Content = "STO";
            }
            else
            {
                ShiftAlphalbl.Content = "";
            }
        }

        private void Store_Click(object sender, RoutedEventArgs e)
        {
            if (storeTrue)
            {
                storeTrue = false;
                alphaTrue = false;
                shiftTrue = false;
                ChangeShiftAlpha();
            }
            else if (shiftTrue)
            {
                Answertxt.Text = "A=" + aVal.ToString() + " , B=" + bVal.ToString() + " , X=" + xVal.ToString() + " , Y=" + yVal.ToString();
                AnswerBoxtxt.Text = "";
                shiftTrue = false;
                ChangeShiftAlpha();
                answerMade = true;
            }
            else
            {
                storeTrue = true;
                alphaTrue = false;
                shiftTrue = false;
                ChangeShiftAlpha();
            }
        }

        private void Power_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (Answertxt.Text == "")
                {
                    temp1Str = answer.ToString();
                    Answertxt.Text = answer.ToString();
                }
                if (opNo < 2)
                {
                    whatOperator = 6;
                    opNo += 1;
                    Answertxt.Text += " ^ ";
                    answerMade = false;
                }
                else
                {
                    temp1Str = (FindCalc(float.Parse(temp1Str), float.Parse(temp2Str))).ToString();
                    temp2Str = "";
                    Answertxt.Text = temp1Str;
                    opNo = 2;
                    whatOperator = 6;
                    Answertxt.Text += " ^ ";
                }
            }
            catch
            {
                Answertxt.Text = "Syntax Error";
                ResetAll();
                answerMade = true;
            }
        }

        private void Tan_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (shiftTrue)
                {
                    if (Answertxt.Text == "")
                    {
                        temp1Str = answer.ToString();
                        Answertxt.Text = answer.ToString();
                    }
                    if (opNo == 1)
                    {
                        double tempDouble = double.Parse(temp1Str);
                        temp1Str = (Math.Atan(tempDouble) * (float)(180 / Math.PI)).ToString();
                        Answertxt.Text = temp1Str;
                    }
                    else if (opNo == 2)
                    {
                        temp2Str = (Math.Atan(double.Parse(temp2Str)) * (180 / Math.PI)).ToString();
                        Answertxt.Text = temp1Str;
                        switch (whatOperator)
                        {
                            case 1:
                                Answertxt.Text += " + ";
                                break;
                            case 2:
                                Answertxt.Text += " - ";
                                break;
                            case 3:
                                Answertxt.Text += " * ";
                                break;
                            case 4:
                                Answertxt.Text += " / ";
                                break;
                            case 5:
                                Answertxt.Text += " % ";
                                break;
                            case 6:
                                Answertxt.Text += " ^ ";
                                break;
                            default:
                                break;
                        }
                        Answertxt.Text += temp2Str;
                    }
                    else
                    {
                        Answertxt.Text = "Syntax Error";
                        ResetAll();
                        answerMade = true;
                    }
                }
                else
                {
                    if (Answertxt.Text == "")
                    {
                        temp1Str = answer.ToString();
                        Answertxt.Text = answer.ToString();
                    }
                    if (opNo == 1)
                    {
                        double tempDouble = double.Parse(temp1Str);
                        tempDouble = tempDouble * Math.PI / 180;
                        temp1Str = Math.Tan(tempDouble).ToString();
                        Answertxt.Text = temp1Str;
                    }
                    else if (opNo == 2)
                    {
                        temp2Str = Math.Tan(double.Parse(temp2Str) * Math.PI / 180).ToString();
                        Answertxt.Text = temp1Str;
                        switch (whatOperator)
                        {
                            case 1:
                                Answertxt.Text += " + ";
                                break;
                            case 2:
                                Answertxt.Text += " - ";
                                break;
                            case 3:
                                Answertxt.Text += " * ";
                                break;
                            case 4:
                                Answertxt.Text += " / ";
                                break;
                            case 5:
                                Answertxt.Text += " % ";
                                break;
                            case 6:
                                Answertxt.Text += " ^ ";
                                break;
                            default:
                                break;
                        }
                        Answertxt.Text += temp2Str;
                    }
                    else
                    {
                        Answertxt.Text = "Syntax Error";
                        ResetAll();
                        answerMade = true;
                    }
                }
                shiftTrue = false;
                ChangeShiftAlpha();
            }
            catch
            {
                Answertxt.Text = "Syntax Error";
                ResetAll();
                answerMade = true;
            }
        }

        private void Sin_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (shiftTrue)
                {
                    if (Answertxt.Text == "")
                    {
                        temp1Str = answer.ToString();
                        Answertxt.Text = answer.ToString();
                    }
                    if (opNo == 1)
                    {
                        double tempDouble = double.Parse(temp1Str);
                        temp1Str = (Math.Asin(tempDouble) * (float)(180 / Math.PI)).ToString();
                        Answertxt.Text = temp1Str;
                    }
                    else if (opNo == 2)
                    {
                        temp2Str = (Math.Asin(double.Parse(temp2Str)) * (180 / Math.PI)).ToString();
                        Answertxt.Text = temp1Str;
                        switch (whatOperator)
                        {
                            case 1:
                                Answertxt.Text += " + ";
                                break;
                            case 2:
                                Answertxt.Text += " - ";
                                break;
                            case 3:
                                Answertxt.Text += " * ";
                                break;
                            case 4:
                                Answertxt.Text += " / ";
                                break;
                            case 5:
                                Answertxt.Text += " % ";
                                break;
                            case 6:
                                Answertxt.Text += " ^ ";
                                break;
                            default:
                                break;
                        }
                        Answertxt.Text += temp2Str;
                    }
                    else
                    {
                        Answertxt.Text = "Syntax Error";
                        ResetAll();
                        answerMade = true;
                    }
                }
                else
                {
                    if (Answertxt.Text == "")
                    {
                        temp1Str = answer.ToString();
                        Answertxt.Text = answer.ToString();
                    }
                    if (opNo == 1)
                    {
                        double tempDouble = double.Parse(temp1Str);
                        tempDouble = tempDouble * Math.PI / 180;
                        temp1Str = Math.Sin(tempDouble).ToString();
                        Answertxt.Text = temp1Str;
                    }
                    else if (opNo == 2)
                    {
                        temp2Str = Math.Sin(double.Parse(temp2Str) * Math.PI / 180).ToString();
                        Answertxt.Text = temp1Str;
                        switch (whatOperator)
                        {
                            case 1:
                                Answertxt.Text += " + ";
                                break;
                            case 2:
                                Answertxt.Text += " - ";
                                break;
                            case 3:
                                Answertxt.Text += " * ";
                                break;
                            case 4:
                                Answertxt.Text += " / ";
                                break;
                            case 5:
                                Answertxt.Text += " % ";
                                break;
                            case 6:
                                Answertxt.Text += " ^ ";
                                break;
                            default:
                                break;
                        }
                        Answertxt.Text += temp2Str;
                    }
                    else
                    {
                        Answertxt.Text = "Syntax Error";
                        ResetAll();
                        answerMade = true;
                    }
                }
                shiftTrue = false;
                ChangeShiftAlpha();
            }
            catch
            {
                Answertxt.Text = "Syntax Error";
                ResetAll();
                answerMade = true;
            }
        }

        private void Cos_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (shiftTrue)
                {
                    if (Answertxt.Text == "")
                    {
                        temp1Str = answer.ToString();
                        Answertxt.Text = answer.ToString();
                    }
                    if (opNo == 1)
                    {
                        double tempDouble = double.Parse(temp1Str);
                        temp1Str = (Math.Acos(tempDouble) * (float)(180 / Math.PI)).ToString();
                        Answertxt.Text = temp1Str;
                    }
                    else if (opNo == 2)
                    {
                        temp2Str = (Math.Acos(double.Parse(temp2Str)) * (180 / Math.PI)).ToString();
                        Answertxt.Text = temp1Str;
                        switch (whatOperator)
                        {
                            case 1:
                                Answertxt.Text += " + ";
                                break;
                            case 2:
                                Answertxt.Text += " - ";
                                break;
                            case 3:
                                Answertxt.Text += " * ";
                                break;
                            case 4:
                                Answertxt.Text += " / ";
                                break;
                            case 5:
                                Answertxt.Text += " % ";
                                break;
                            case 6:
                                Answertxt.Text += " ^ ";
                                break;
                            default:
                                break;
                        }
                        Answertxt.Text += temp2Str;
                    }
                    else
                    {
                        Answertxt.Text = "Syntax Error";
                        ResetAll();
                        answerMade = true;
                    }
                }
                else
                {
                    if (Answertxt.Text == "")
                    {
                        temp1Str = answer.ToString();
                        Answertxt.Text = answer.ToString();
                    }
                    if (opNo == 1)
                    {
                        double tempDouble = double.Parse(temp1Str);
                        tempDouble = tempDouble * Math.PI / 180;
                        temp1Str = Math.Cos(tempDouble).ToString();
                        Answertxt.Text = temp1Str;
                    }
                    else if (opNo == 2)
                    {
                        temp2Str = Math.Cos(double.Parse(temp2Str) * Math.PI / 180).ToString();
                        Answertxt.Text = temp1Str;
                        switch (whatOperator)
                        {
                            case 1:
                                Answertxt.Text += " + ";
                                break;
                            case 2:
                                Answertxt.Text += " - ";
                                break;
                            case 3:
                                Answertxt.Text += " * ";
                                break;
                            case 4:
                                Answertxt.Text += " / ";
                                break;
                            case 5:
                                Answertxt.Text += " % ";
                                break;
                            case 6:
                                Answertxt.Text += " ^ ";
                                break;
                            default:
                                break;
                        }
                        Answertxt.Text += temp2Str;
                    }
                    else
                    {
                        Answertxt.Text = "Syntax Error";
                        ResetAll();
                        answerMade = true;
                    }
                }
                shiftTrue = false;
                ChangeShiftAlpha();
            }
            catch
            {
                Answertxt.Text = "Syntax Error";
                ResetAll();
                answerMade = true;
            }
        }

        private void Factorial_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (alphaTrue)
                {
                    TextChange();
                    if (opNo == 1)
                    {
                        Answertxt.Text += xVal.ToString();
                    }
                    else
                    {
                        Answertxt.Text += xVal.ToString();
                        temp2Str += xVal.ToString();
                    }
                    alphaTrue = false;
                    ChangeShiftAlpha();
                }
                else if (storeTrue)
                {
                    xVal = answer;
                    storeTrue = false;
                    ChangeShiftAlpha();
                    Answertxt.Text = "X --> " + xVal.ToString();
                    answerMade = true;
                }
                else
                {
                    if(opNo == 1 && float.Parse(Answertxt.Text) > 20)
                    {
                        Answertxt.Text = "Error - Number Too High";
                        ResetAll();
                        answerMade = true;
                    }
                    else if (opNo == 2 && float.Parse(temp2Str) > 20)
                    {
                        Answertxt.Text = "Error - Number Too High";
                        ResetAll();
                        answerMade = true;
                    }
                    else
                    {
                        if (Answertxt.Text == "")
                        {
                            Answertxt.Text = answer.ToString();
                            temp1Str = answer.ToString();
                        }
                        if (opNo == 1)
                        {
                            float tempFact = 1;
                            for (int i = 1; i < float.Parse(temp1Str) + 1; i++)
                            {
                                tempFact *= i;
                            }
                            temp1Str = tempFact.ToString();
                            Answertxt.Text += "!";
                            //Answertxt.Text = temp1Str;
                        }
                        else if (opNo == 2)
                        {
                            float tempFact = 1;
                            for (int i = 1; i < float.Parse(temp2Str) + 1; i++)
                            {
                                tempFact *= i;
                            }
                            //temp2Str = Math.Floor(double.Parse(temp2Str)).ToString();
                            temp2Str = tempFact.ToString();
                            Answertxt.Text += "!";
                            //Answertxt.Text = temp1Str;
                            /*
                            switch (whatOperator)
                            {
                                case 1:
                                    Answertxt.Text += " + ";
                                    break;
                                case 2:
                                    Answertxt.Text += " - ";
                                    break;
                                case 3:
                                    Answertxt.Text += " * ";
                                    break;
                                case 4:
                                    Answertxt.Text += " / ";
                                    break;
                                case 5:
                                    Answertxt.Text += " % ";
                                    break;
                                case 6:
                                    Answertxt.Text += " ^ ";
                                    break;
                                default:
                                    break;
                            }
                             */
                            //Answertxt.Text += temp2Str;
                        }
                    }
                }
            }
            catch
            {
                Answertxt.Text = "Syntax Error";
                ResetAll();
                answerMade = true;
            }
        }
    }
}
