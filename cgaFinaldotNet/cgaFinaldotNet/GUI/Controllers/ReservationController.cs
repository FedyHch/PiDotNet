using Data.Models;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;

namespace GUI.Controllers
{
    public class ReservationController : Controller
    {
        EventUserService EUS = new EventUserService();
        EventService ES = new EventService();

        // GET: Reservation
        public ActionResult Index()
        {
            return View();
        }

        // GET: Reservation/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Reservation/Create
        public ActionResult Create()
        {
            return View();
        }
        public ActionResult SendMail()
        {
            user u = new user();
            UserService US = new UserService();
            u=US.GetById(2);

             MailMessage msg = new MailMessage();

            msg.From = new MailAddress("aymen.bessrour@esprit.tn");

            var toaddress = new MailAddress(u.mail);

            msg.To.Add(toaddress);
            msg.Subject = "Participate ! ";
            msg.Body = "Participation efectuee avec succes" ;
            SmtpClient client = new SmtpClient();
            client.UseDefaultCredentials = true;
            client.Host = "smtp.gmail.com";
            client.Port = 587;
            client.EnableSsl = true;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.Credentials = new NetworkCredential("aymen.bessrour@esprit.tn", "0021694490020");
            client.Timeout = 20000;
            try
            {
                client.Send(msg);

            }
            catch (Exception ex)
            {

            }
            finally
            {
                msg.Dispose();
            }

            return View();
        
    }

        // POST: Reservation/Create
        [HttpPost]
        public ActionResult Create(evenement_user e)
        {
           
            String id = Request.Url.AbsolutePath.Split('/').Last();
            evenement_user E= new evenement_user();
            //   Event e = ES.GetEventsByID();
            /* Lier l'entité du domaine  avec celle du Model */
            IEnumerable<evenement_user> EU = EUS.verifyBooking(E.participants_id, E.listEvents_EventID);
            foreach (evenement_user eu in EU)
            {

            }
            E.participants_id = 2;
            E.listEvents_EventID = int.Parse(id);
            int idevent = E.listEvents_EventID;
            evenement eve = ES.GetById(idevent);
            eve.places--;
            eve.booked++;
            ES.Update(eve);
            //  A.BookingID = BVM.BookingID;
            E.ReservDate = DateTime.Now;

            /* Ajout de l'entité dans la base de données */
            
            EUS.Add(E);
            /* Persister */
             EUS.Commit();
            ES.Commit();
            SendMail();
            // RedirectToRoute("/Event/List");
            return View();//RedirectToAction("Create", "Booking");
        }

        // GET: Reservation/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Reservation/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Reservation/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Reservation/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
