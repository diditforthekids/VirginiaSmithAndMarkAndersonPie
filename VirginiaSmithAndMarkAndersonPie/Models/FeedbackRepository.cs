using System;

namespace VirginiaSmithAndMarkAndersonPie.Models
{
    public class FeedbackRepository : IFeedbackRepository
    {
        private readonly AppDbContext _appDbContext;

        public FeedbackRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public void AddFeedBack(Feedback feedback)
        {
            _appDbContext.Feedbacks.Add(feedback);
            _appDbContext.SaveChanges();
        }

        public void AddFeedback(Feedback feedback)
        {
            throw new NotImplementedException();
        }
    }
}