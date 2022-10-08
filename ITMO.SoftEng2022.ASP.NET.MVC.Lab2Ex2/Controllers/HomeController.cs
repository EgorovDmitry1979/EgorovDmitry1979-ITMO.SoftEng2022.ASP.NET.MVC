using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebMVCR1.Models;
using static System.Web.Razor.Parser.SyntaxConstants;

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
            string res = ExeFactorial(5);
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
    }
}