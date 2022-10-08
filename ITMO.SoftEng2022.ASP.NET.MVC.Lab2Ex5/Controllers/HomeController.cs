using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using WebMVCR1.Models;
using static System.Web.Razor.Parser.SyntaxConstants;
using static WebMVCR1.Models.StudyCsharp;

namespace WebMVCR1.Controllers
{
    //public class HomeController : Controller 
    public class MyController : Controller
    {
        // GET: HomeController
        // п.5
        //public ActionResult Index()
        //{
        //    return View();
        //}

        //п.5
        //public string Index() //
        //public string Start() //  п.1.7, п.2.2
        public string Index(string hel) // п.2.2
        {
            //int hour = DateTime.Now.Hour; // 3.2
            //string Greeting = hour < 12 ? "Доброе утро" : "Добрый день"; // п.2.2
            //string Greeting = hour < 12 ? "Доброе утро" : "Добрый день" + ", " + hel; // п.3.2
            string Greeting = ModelClass.ModelHello() + ", " + hel; // п.3.2

            // Тестирование перечисления 
            //return Greeting;
            // Тестирование структуры п.2
            //string res = ExeEnum(); 

            //string res = ExeStruct(); // п.3
            // string res = StudyCsharp.SetStatus(3); // п.3
            //string res = StudyCsharp.ExeSwitch(StudyCsharp.SetStatus(3));
            // string res = StudyCsharp.GetFunction(0, 9);
            //string res = ExeFactorial(5); // Факториал
            //string res = ExeTriangle(); // Треугольник
            //string res = ExeCircle(); // Окружность
            //string res = ExePolim(); // Выхов полиморфа - фигуры
            string res = ExeCollection(); // Применение коллекций для группировки объектов типа Окружность
            //string res = ExeCollection1(); // Применение коллекций для группировки Треугольник (н.п)
            return res;
        }

        // п.3.1.2.
        public string ExeEnum()
        {
            AccountType goldAccount;
            AccountType platinumAccount;
            // п.3.1.3.
            goldAccount = AccountType.Checking;
            platinumAccount = AccountType.Deposit;
            // п.3.1.4.
            string res1 = String.Format("Тип банковского счета {0}", goldAccount);
            string res2 = String.Format("Тип банковского счета {0}", platinumAccount);
            string res = res1 + "<p>" + res2;
            return res;
        }
        // Создание и использование структуры 
        // п.2
        public string ExeStruct()
        {
            BankAccount goldBankAccount;
            // п.3
            goldBankAccount.accType = AccountType.Checking;
            goldBankAccount.accBal = (decimal)3200.00;
            goldBankAccount.accNo = 123;
            // п.4
            // string res = String.Format("Номер счета {0}, баланс {1}, тип {2}", goldBankAccount.accNo, goldBankAccount.accBal, goldBankAccount.accType);
            string res = String.Format("Информация о банковском счете: {0}", goldBankAccount);
            return res;
        }
        // Тестирование метода расчета факториала 
        public string ExeFactorial(int x)
        {
            // 2b
            int f;
            bool ok = StudyCsharp.Factorial(x, out f);
            // 3
            if (ok)
                return String.Format("Факториал числа {0} равен {1} ", x, f);
            else
                return "Невозможно вычислить факториал";

        }
        // Тестирование класса Треугольник
        // п.1
        public string ExeTriangle()
        {
            Triangle tr1 = new Triangle(3, 5, 6);
            // п.2
            string sq1 = String.Format("Площадь фигуры {0} равна: {1:0.##}", tr1.Name, tr1.Area);
            return sq1;
        }
        // Тестирование класса Окружность
        // п.3
        public string ExeCircle()
        {
            Circle cir1 = new Circle(3);
            string sq = String.Format("Площадь фигуры {0} равна: {1:0.##}", cir1.Name, cir1.Area);
            return sq;
        }
        // Тестирование полиморфизма (фигуры)

        public string ExePolim()
        {
            StringBuilder str = new StringBuilder(); // п.2
            // п.3
            Shape[] sh = {
                new Triangle(1,2,3),
                new Circle(5),
                new Triangle(5,6,8)
            };
            // п.4
            foreach (Shape item in sh)
            {
                str.AppendFormat("Это фигура {0}", item.Name + "<p>");
            }
            // п.5
            return str.ToString();
        }
        // Применение коллекций для группировки объектов типа Окружность
        // п.3
        public string ExeCollection()
        {
            // п.4
            List<Circle> cirs = new List<Circle>
            {
                new Circle(12),
                new Circle(5),
                new Circle(15),
                new Circle(6)
            };
            // п.5
            cirs.Add(new Circle(7));
            // п.6
            cirs.Sort();
            // п.7
            StringBuilder str = new StringBuilder();
            foreach (Shape item in cirs)
            {
                str.AppendFormat("Это фигура {0}", item.Name + "<p>");
            }
            return str.ToString();
        }

        // Применение коллекций для группировки объектов типа Треугольник - пока не получилось
        //public string ExeCollection1()
        //{
        //    // п.4
        //    List<Triangle> trg = new List<Triangle>
        //    {
        //        new Triangle(12),
        //        new Triangle(5),
        //        new Triangle(15),
        //        new Triangle(6)
        //    };
        //    // п.5
        //    trg.Add(new Triangle(7));
        //    // п.6
        //    trg.Sort();
        //    // п.7
        //    StringBuilder str = new StringBuilder();
        //    foreach (Shape item in trg)
        //    {
        //        str.AppendFormat("Это фигура {0}", item.Name + "<p>");
        //    }
        //    return str.ToString();
        //}

    }
}