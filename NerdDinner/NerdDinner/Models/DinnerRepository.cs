using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NerdDinner.Models
{
    public class DinnerRepository
    {
        private NerdDinnerDataContext db = new NerdDinnerDataContext();

        //
        // Query Methods

        public IQueryable<Dinners> FindAllDinners()
        {
            return db.Dinners;
        }

        public IQueryable<Dinners> FindUpcomingDinners()
        {
            return from dinner in db.Dinners
                   where dinner.EventDate > DateTime.Now
                   orderby dinner.EventDate
                   select dinner;
        }

        public Dinners GetDinner(int id)
        {
            return db.Dinners.SingleOrDefault(d => d.DinnerID == id);
        }

        //
        // Insert/Delete Methods

        public void Add(Dinners dinner)
        {
            db.Dinners.InsertOnSubmit(dinner);
        }

        public void Delete(Dinners dinner)
        {
            db.Rsvp.DeleteAllOnSubmit(dinner.Rsvp);
            db.Dinners.DeleteOnSubmit(dinner);
        }

        //
        // Persistence 

        public void Save()
        {
            db.SubmitChanges();
        }
    }
}