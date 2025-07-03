using System.ComponentModel;
using System.Globalization;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Fraction And Discard

            //float number1 = 15.23456789F; //4Byte 15.234568
            //Console.WriteLine(number1);

            //double number2 = 15.123456789F; //8 Byte 15.123456954956055
            //Console.WriteLine(number2);

            //decimal number3 = 1.123456789123456789123456789M; //16 Byte 1.123456789123456789123456789
            //Console.WriteLine(number3);

            //long number4 = 20_000_000_000;
            //Console.WriteLine($"{number4:c}");//$20,000,000,000.00

            //CultureInfo convert = new CultureInfo("ar-EG"); //Suidi Arabia
            //Console.WriteLine(number4.ToString("c", convert));//20?000?000?000?00 ?.?.? Not understand Arabic => ?

            #endregion

            #region Casting

            //implicit casting convert from small to large type
            //Explicit casting convert from large to small type and may lose data
            //int X = 10000; //4Byte
            //long Y = X; //8Byte implicit casting
            //Console.WriteLine(Y); //10000

            //long Z = 10000000000; //8 Byte

            //checked //System.OverflowException: 'Arithmetic operation resulted in an overflow.'
            //{
            //      int A = (int)Z;//Explicit Casting with using [(int)] and unsafe is lose data
            //    unchecked
            //    {
            //      Console.WriteLine(A); //1410065408
            //    }

            //}

            //protective code

            //long k = 10000000000;
            //if (k > int.MaxValue || k< int.MinValue)
            //{
            //    Console.WriteLine("Exception Will Be Thrown");//Exception Will Be Thrown
            //}
            //else
            //{
            //    int N = (int)k;
            //    Console.WriteLine(N);
            //}

            //long K = 10000000000;
            //Console.WriteLine(K.GetType());//System.Int64

            //object num = 1000000000;
            //Console.WriteLine(num.GetType());//System.Int32

            //int Y = num.GetType() == typeof(int) ? (int)num : 0;

            #region Example 2

            //int X = 5;// 4Byte
            //float Y = X;
            //Console.WriteLine(Y);

            //decimal W = 16.165m ;
            //int Z = (int) W ;// Explicit Casting And Lose Data -un safe Casting
            //Console.WriteLine(Z);

            #endregion




            #endregion

            #region Casting2 
            //Convert handle null by converting 0
            //Parse String that reprisent number to number type
            //TryParse Protective version from parse

            //Console.WriteLine("Hello PLeease enter your data");
            //Console.Write("Name : ");
            //string name = Console.ReadLine() ?? ""; //deafauilt Null

            ////? //nullable type in new version
            ////?? ""
            //Console.Write("Age : ");
            //int age = Convert.ToInt32(Console.ReadLine());



            //Console.WriteLine("Salary: ");
            //decimal salary = Convert.ToDecimal(Console.ReadLine());
            //Console.Clear();
            //Console.WriteLine("===================");
            //Console.WriteLine("Employee Data : ");
            //Console.WriteLine("===================");
            //Console.WriteLine("Name is "+ name);
            //Console.WriteLine("age is " + age);
            //Console.WriteLine("Salary is " + salary);


            #region Parse

            //Console.WriteLine("Hello PLeease enter your data");
            //Console.Write("Name : ");

            //string name = Console.ReadLine() ?? ""; //deafauilt Null

            ////? //nullable type in new version
            ////?? ""
            //Console.Write("Age : ");
            //int age = int.Parse(Console.ReadLine() ?? "0");



            //Console.WriteLine("Salary: ");
            //decimal salary = decimal.Parse(Console.ReadLine() ?? "0");

            //Console.Clear();

            //Console.WriteLine("===================");
            //Console.WriteLine("Employee Data : ");
            //Console.WriteLine("===================");
            //Console.WriteLine("Name is " + name);
            //Console.WriteLine("age is " + age);
            //Console.WriteLine("Salary is " + salary);



            #endregion

            #region Try parse()

            //string number02 = "100";
            //bool isparsed = int.TryParse(number02, out int X02);
            //Console.WriteLine(X02);// 0
            //Console.WriteLine(isparsed); // false





            //Console.WriteLine("Hello PLeease enter your data");
            //Console.Write("Name : ");

            //string name = Console.ReadLine() ?? ""; //deafauilt Null

            ////? //nullable type in new version
            ////?? ""
            //Console.Write("Age : ");
            //int.TryParse(Console.ReadLine(), out int age);



            //Console.WriteLine("Salary: ");
            //decimal.TryParse(Console.ReadLine(), out decimal salary);

            //Console.Clear();

            //Console.WriteLine("===================");
            //Console.WriteLine("Employee Data : ");
            //Console.WriteLine("===================");
            //Console.WriteLine("Name is " + name);
            //Console.WriteLine("age is " + age);
            //Console.WriteLine("Salary is " + salary);



            #endregion


            #endregion

            #region Operators
            #region Operators [++ , --]

            //int X = 10;


            //// 1 . ++
            ////1.1 PreFix [Increament and Then Print]
            //Console.WriteLine(++X); //11
            //Console.WriteLine(X); // 11
            ////1.2 PostFix [Print and Then Increament]
            //Console.WriteLine(X++); //10
            //Console.WriteLine(X); // 11


            ////2.1 prefix [Decreament and then print]
            //Console.WriteLine(--X); //9
            //Console.WriteLine(X); //9

            //// 2 .2 PostFix [Print and then Decreament]





            #endregion

            #region Binary | Arithmatic Operators [+ , - , * , /, %]
            //int SumResult, SubResult, MulResult, divResult, ModResult;
            //int X = 10, Y = 2;

            //SumResult = X + Y; //12
            //SubResult = X - Y; //8
            //MulResult = X * Y; //20
            //divResult = X / Y; //5
            //ModResult = X % Y; //0

            #endregion

            #region Operators [ = , += , -= , *= , /= , %=]

            //int X;
            //X = 4;
            //X += 2; X = X+ 2
            //X += 3; X = X+6
            //X -= 6; X = X-6
            //X *= 2; X = X*6
            //X /= 5;  X = X/6
            //X %= 9;   X = X%6






            #endregion

            #region Relational | Comparsion Operators [== ,!= ,< ,> ,<=,>=]

            //int X = 10 , Y = 10;

            //Console.WriteLine(X == Y); //True
            //Console.WriteLine(X != Y); //False
            //Console.WriteLine(X > Y); //False
            //Console.WriteLine(X < Y); //False
            //Console.WriteLine(X >= Y);//True
            //Console.WriteLine(X <= Y);//True


            #endregion

            #region Logical Operators [! , && , ||]
            //Short circuit 

            //Console.WriteLine(!true);
            //Console.WriteLine(false && true);
            //Console.WriteLine(false || true);

            //Console.WriteLine(4 < 5 && 7<9);
            //Console.WriteLine(4 < 5 && 7>9);
            //Console.WriteLine(4 > 5 && 7<9);

            //true || true = true
            // true || false = true
            // false || False = false
            // true || fase = true


            //true && true = true
            // true && false = false
            // false && False = false
            // true || fase = false
            #endregion

            #region Bitwise Operators [& , | , ^ , ~ ,<< ,>>]
            //// long Circit 
            //Console.WriteLine(false & true);
            //Console.WriteLine(true | false);
            //Console.WriteLine( false ^ true);


            //int X = 5, Y = 3; X =0101 , Y = 0011;
            //Console.WriteLine(X & Y);
            //Console.WriteLine(X | Y);
            //Console.WriteLine(X ^ Y);
            //Console.WriteLine(~X);
            //Console.WriteLine(X << 1 );
            //Console.WriteLine(X >> 1);
            #endregion

            #region Ternary Operator [Coditional Operator] [?:]

            // int X = 10 , Y =5 ;
            //string Message = X > Y ? "X > Y" : "Y > X" ;

            //Console.WriteLine(Message);


            #endregion


            #endregion

            #region Operators Priority And Associativity
            //int A = 20;
            //int B = 30;
            //int C = 40;
            //int D = 40;

            //int Result = (A + B) * C / D; //70
            //Result = (A + B) * C / D; //70
            //Result = ((A + B) * C) / D;//70
            //Result = (A + B) * (C / D);//50
            //Result = A + B * C / D;

            //Result = A + ++B 
            #endregion

            #region String Formating
            //Equation : 10 + 5 = 15

            //Console.WriteLine("Equation : 10 + 5 = 15");//Equation : 10 + 5 = 15

            //int C = 10, Y = 5;
            //int Result = C + Y;
            //string message;

            //1. String Interpolation

            //message = $"Equation : {C} + {Y} = Result "; //Expression
            //Console.WriteLine(message);

            //2.String.Format Method

            //message = string.Format("Equation : {0} + {1} = {2}" , C , Y , Result);
            //Console.WriteLine(message);

            //3. Composite Formating

            //Console.WriteLine(string.Format("Equation : {0} + {1} = {2}" , C , Y , Result);

            //4. String Concatenation +
            //Equation: 10 + 5 = 15;
            //message = "Equation:" + C + Y + "=" + Result; 


            // /t space
            // /n newline
            // / Escabe character

            #endregion

            #region Control Statements
            //make DESCION
            //Loop list collection or array
            



            #endregion
        }
    }
}
