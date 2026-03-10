using System.Collections;
using static System.Console;

namespace ConsoleApp1
{
    internal class Program
    {
        static async void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
         
            //int a = 10;
            //a = 20;

            ////int b = a;
            ////b = 20;

            //ChangeNum(ref a);

            //Console.WriteLine(a);

            #region
            //Program program = new Program();
            //program.ChangeNum(a);

            //ChangeNum(a);

            //Console.WriteLine(a);

            Student student1 = new Student();
            //Student.Shangke();
            //student1.age = 15;
            //Console.WriteLine(student1.PassWord);
            //student1.PassWord = "4546541";

            Student student2 = new Student(15, 16);
            ////student2.Add(1, 3);
            //student2.ChangeAge(student2);
            //Console.WriteLine(student2.age);
            student2.TestDelegate();
            #endregion

            bool isnoe = true;
            char ischar = 'A';
            double dou = 3.1;

            

            //switch (dou)
            //{
            //    case 3.1:
            //        Console.WriteLine("成功匹配double");
            //        break;
            //    case 'd':
            //        break;
            //    default:
            //        break;
            //}

            //FileStream file = File.Create("");

            //try
            //{
            //    int a = 2;
            //    int b = 0;
            //    var result = a / b;
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.ToString());               
            //}
            //Console.WriteLine("TryCatch之后执行");

            String name1 = "abc";

            String name2 = new String("abc");    

            Console.WriteLine(name1 == name2);
            Console.WriteLine(object.ReferenceEquals(name1, name2));

            object water = new object();
            



        }

        public static void ChangeNum(ref int b)
        {           
            b = 20;
           
        }
    }

    public sealed class Student
    {
        public int banji = 0;
        public int age;
        public int length;

        public string passWord = string.Empty;

        #region 属性相关
        public string PassWord
        {
            get { return passWord; }
            set
            {
                if (value.Contains("4"))
                {
                    Console.WriteLine("账号不能包含4，请检查！");
                }
                else
                {
                    PassWord = value;
                }
            }
        }
        #endregion

        public Student()
        {
            Console.WriteLine("执行了构造函数");
          
        }

        public Student(int num1, int num2)
        {
            this.age = num1;
            this.length = num2;
        }


        public static void Shangke()
        {          
            Console.WriteLine("开始去上课！");
        }

        public void PaoCao()
        {
           
        }

        /// <summary>
        /// 计算连个数字的和
        /// </summary>
        /// <param name="a">参数1</param>
        /// <param name="b">参数2</param>
        /// <returns>返回一个int</returns>        
        public int Add(int a, int b)
        {
            if (a > 1)
            {               
                return 1;
            }
            else
            {
                return 3;
            }           
        }

        public void ChangeAge(Student student)
        {
            student.age = 20;
        }


        public void TestDelegate()
        {
            Animal animal1 = new Animal();
            animal1.Test2(Function);
        }

        public void Function()
        {
            Console.WriteLine("委托执行了！");
        }

    }//class_end

    /// <summary>
    /// 动物类
    /// </summary>
    public class Animal
    {
        public delegate void ChangeAge();

        public void Test1(int a, int b)
        {

        }

        public void Test1(int a, string c)
        {

        }

        public void Test2(ChangeAge changeAge)
        {
            changeAge();
        }



    }//class_end

   
}
