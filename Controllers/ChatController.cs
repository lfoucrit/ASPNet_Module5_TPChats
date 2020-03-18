using Module5_TP_Chat.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Module5_TP_Chat.Controllers
{
    public class ChatController : Controller
    {
        private List<Chat> chats = new List<Chat>
            {
                new Chat{Id=1, Nom="Felix", Age=3, Couleur="Roux" },
                new Chat{Id=2, Nom="Minette", Age=1, Couleur="Noire" },
                new Chat{Id=3, Nom="Miss",Age=3, Couleur="Blanche" },
                new Chat{Id=4, Nom="Garfield",Age=3, Couleur="Gris" },
                new Chat{Id=5, Nom="Chatran",Age=3, Couleur="Fauve" },
                new Chat{Id=6, Nom="Minou",Age=3, Couleur="Blanc" },
                new Chat{Id=7, Nom="Bichette", Age=12, Couleur="Rousse" }
            };

        // GET: Chat
        public ActionResult Index()
        {
            return View(chats);
        }

        // GET: Chat/Details/5
        public ActionResult Details(int id)
        {
            Chat chat = chats.Where(c => c.Id == id).First();
            return View(chat);
        }

        // GET: Chat/Delete/5
        public ActionResult Delete(int id)
        {
            Chat chat = chats.Where(c => c.Id == id).First();
            return View(chat);
        }

        // POST: Chat/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                Chat chat = chats.Where(c => c.Id == id).First();
                chats.Remove(chat);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
