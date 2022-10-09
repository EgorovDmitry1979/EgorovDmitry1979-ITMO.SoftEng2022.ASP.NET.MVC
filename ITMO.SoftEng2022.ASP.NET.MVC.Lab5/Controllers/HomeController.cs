using System;
using System.Linq;
using System.Web.Mvc;
using MvcCreditApp1.Models; // п.2

// Упражнение 2. Настройка работы с данными 
// Настройка контроллера 

namespace MvcCreditApp1.Controllers
{
    public class HomeController : Controller
    {
        private CreditContext db = new CreditContext(); // п.3 экземпляр контекста данных

        public ActionResult Index()
        {
            //var allCredits = db.Credits.ToList<Credit>(); // п.2 перенесено в GiveCredits()
            //ViewBag.Credits = allCredits; // п.2 перенесено в GiveCredits()
            GiveCredits(); // п.2 вызов метода GiveCredits()
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        // Реализация подачи заявки 
        // п.1 - это взяли из метода Index()
        private void GiveCredits()
        {
            var allCredits = db.Credits.ToList<Credit>(); 
            ViewBag.Credits = allCredits;
        }
        // п.3а
        [HttpGet]
        public ActionResult CreateBid()
        {
            GiveCredits();
            var allBids = db.Bids.ToList<Bid>();
            ViewBag.Bids = allBids;
            return View();
        }
        // п.3b
        [HttpPost]
        public string CreateBid(Bid newBid)
        {
            newBid.bidDate = DateTime.Now;
            // Добавляем новую заявку в БД
            db.Bids.Add(newBid);
            // Сохраняем в БД все изменения
            db.SaveChanges();
            return "Спасибо, <b>" + newBid.Name + "</b>, за выбор нашего банка. Ваша заявка будет рассмотрена в течении 10 дней.";
        }
    }
}