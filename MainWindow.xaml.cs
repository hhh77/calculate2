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

namespace calculate1
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        string Number1="", Number2="";//初始值无
        Operator flag = Operator.none;//flag为操作符
        enum Operator {add,sub,mul,div,none };//指定枚举的类型名称
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button7_Click(object sender, RoutedEventArgs e)
        {
            if (flag==Operator.none)//对输入数字进行判断，枚举列表中的每个符号代表一个整数值，一个比它前面的符号大的整数值。
            {
                Number1 = Number1 + "7";//输入number1中的其他数字加一个7或着没有7，即为输入的第一个要计算的数
                label1.Content = Number1;//显示内容
            }
            else
            {
                Number2 = Number2 + "7";//意义同上
                label1.Content = Number2;
            }
        }
        private void Button8_Click(object sender, RoutedEventArgs e)
        {
            if (flag==Operator.none)
            {
                Number1 = Number1 + "8";
                label1.Content = Number1;
            }
            else
            {
                Number2 = Number2 + "8";
                label1.Content = Number2;
            }
        }
        private void Button9_Click(object sender, RoutedEventArgs e)
        {
            if (flag==Operator.none)
            {
                Number1 = Number1 + "9";
                label1.Content = Number1;
            }
            else
            {
                Number2 = Number2 + "9";
                label1.Content = Number2;
            }
        }
        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            if (flag==Operator.none)
            {
                Number1 = Number1 + "4";
                label1.Content = Number1;
            }
            else
            {
                Number2 = Number2 + "4";
                label1.Content = Number2;
            }
        }
        private void Button5_Click(object sender, RoutedEventArgs e)
        {
            if (flag==Operator.none)
            {
                Number1 = Number1 + "5";
                label1.Content = Number1;
            }
            else
            {
                Number2 = Number2 + "5";
                label1.Content = Number2;
            }
        }
        private void Button6_Click(object sender, RoutedEventArgs e)
        {
            if (flag==Operator.none)
            {
                Number1 = Number1 + "6";
                label1.Content = Number1;
            }
            else
            {
                Number2 = Number2 + "6";
                label1.Content = Number2;
            }
        }
        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            if (flag==Operator.none)
            {
                Number1 = Number1 + "1";
                label1.Content = Number1;
            }
            else
            {
                Number2 = Number2 + "1";
                label1.Content = Number2;
            }
        }
        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            if (flag==Operator.none)
            {
                Number1 = Number1 + "2";
                label1.Content = Number1;
            }
            else
            {
                Number2 = Number2 + "2";
                label1.Content = Number2;
            }
        }
        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            if (flag==Operator.none)
            {
                Number1 = Number1 + "3";
                label1.Content = Number1;
            }
            else
            {
                Number2 = Number2 + "3";
                label1.Content = Number2;
            }
        }
        private void Button0_Click(object sender, RoutedEventArgs e)
        {
            if (flag==Operator.none)
            {
                Number1 = Number1 + "0";
                label1.Content = Number1;
            }
            else
            {
                Number2 = Number2 + "0";
                label1.Content = Number2;
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (flag==Operator.none)
            {
                Number1 = Number1 + ".";//小数点同上
                label1.Content = Number1;
            }
            else
            {
                Number2 = Number2 + ".";
                label1.Content = Number2;
            }
        }
        private void Button_add_Click(object sender, RoutedEventArgs e)
        {
            flag =Operator.add;//赋值枚举类型的数到+，以下加减乘除运算同理
        }
        private void Button_sub_Click(object sender, RoutedEventArgs e)
        {
            flag = Operator.sub;
        }
        private void Button_mul_Click(object sender, RoutedEventArgs e)
        {
            flag = Operator.mul;
        }
        private void Button_div_Click(object sender, RoutedEventArgs e)
        {
            flag = Operator.div;
        }
        private void Button_DEL_Click(object sender, RoutedEventArgs e)
        {
            if (flag == Operator.none)//判断number1和number2
            {
                if (Number1.Length > 0)//length：在当前的 String 对象中获取字符数。判断长度是否大于0
                {
                    Number1 = Number1.Remove(Number1.Length - 1);//Remove：移除当前实例中的所有字符，从指定位置开始，一直到最后一个位置为止，并返回字符串。括号中意义为number1长度减1（某个数字删去最后一个数字）
                    label1.Content = Number1;
                }
            }
            else
            {
                if (Number2.Length > 0)
                {
                    Number2 = Number2.Remove(Number2.Length - 1);
                    label1.Content = Number2;
                }
            }
        }
        private void Button_clear_Click(object sender, RoutedEventArgs e)
        {
            Number1 = "";
            Number2 = "";
            flag = Operator.none;
            label1.Content = "0";//label1归零
        }
        private void Button_equ_Click(object sender, RoutedEventArgs e)
        {
            if (Number1 == "" || Number2 == "")//判断两个数未输入前是否为空
            {
                Number1 = "";
                Number2 = "";
                flag = Operator.none;
                return;//返回跳出
            }
            switch (flag)
            {
                case Operator.add://判断运算符
                    label1.Content = Convert.ToString(Convert.ToDouble(Number1) + Convert.ToDouble(Number2));
                    break;
                case Operator.sub:
                    label1.Content = Convert.ToString(Convert.ToDouble(Number1) - Convert.ToDouble(Number2));
                    break;
                case Operator.mul:
                    label1.Content = Convert.ToString(Convert.ToDouble(Number1) * Convert.ToDouble(Number2));
                    break;
                case Operator.div:
                    label1.Content = Convert.ToString(Convert.ToDouble(Number1) / Convert.ToDouble(Number2));
                    break;
            }
            Number1 = "";
            Number2 = "";
            flag = Operator.none;
        }
    }
}
