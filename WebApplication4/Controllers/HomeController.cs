using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using WebApplication4.Models;

namespace WebApplication4.Controllers
{
    public class HomeController : Controller
    {
        private PersonContext db = new PersonContext();
        // GET: People
        public ActionResult Index()
        {
            return View(db.Persons.Include(a => a.ContactInformation).ToList());
        }
        // GET: People/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: People/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Person person)
        {
            if (ModelState.IsValid)
            {
                db.Persons.Add(person);
                ContactInformation contact = new ContactInformation
                {
                    ContactInformationId = person.PersonId,
                    Phone = person.ContactInformation.Phone,
                    Email = person.ContactInformation.Email,
                    Skype = person.ContactInformation.Skype,
                    Person = person
                };
                db.ContactInformations.Add(contact);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(person);
        }

        // GET: People/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Person person = db.Persons.Find(id);
            if (person == null)
            {
                return HttpNotFound();
            }
            return View(person);
        }

        // POST: People/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Person person)
        {
            if (ModelState.IsValid)
            {
                var pers = db.Persons.Find(person.PersonId);

                pers.Birthday = person.Birthday;
                pers.Corporation = person.Corporation;
                pers.FirstName = person.FirstName;
                pers.LastName = person.LastName;
                pers.MiddleName = person.MiddleName;
                pers.EmployeePosition = person.EmployeePosition;
                pers.ContactInformation.Email = person.ContactInformation.Email;
                pers.ContactInformation.Phone = person.ContactInformation.Phone;
                pers.ContactInformation.Skype = person.ContactInformation.Skype;

                db.Entry(pers).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(person);
        }

        // GET: People/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Person person = db.Persons.Find(id);
            if (person == null)
            {
                return HttpNotFound();
            }
            return View(person);
        }

        // POST: People/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Person person = db.Persons.Find(id);
            ContactInformation contact = db.ContactInformations.Find(person.ContactInformation.ContactInformationId);
            db.Entry(person).State = EntityState.Deleted;
            db.Entry(contact).State = EntityState.Deleted;
            /*db.Persons.Remove(person);
            db.ContactInformations.Remove(contact);*/
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}