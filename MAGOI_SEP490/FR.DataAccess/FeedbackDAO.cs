using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FR.BusinessObjects.DataContext;
using FR.BusinessObjects.Models;

namespace FR.DataAccess
{
    public class FeedbackDAO
    {
        private readonly DBContext _context;
        public FeedbackDAO(DBContext context)
        {
            _context = context;
        }

        public void AddFeedback(Feedback feedback)
        {
            try
            {
                _context.Feedbacks.Add(feedback);
                _context.SaveChanges();
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
