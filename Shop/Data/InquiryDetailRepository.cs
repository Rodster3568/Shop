using Shop.Models;

namespace Shop.Data
{
    public class InquiryDetailRepository : Repository<InquiryDetail>, IInquiryDetailRepository
    {
        private readonly ApplicationDbContext _db;


        public void Update(InquiryDetail obj)
        {
            _db.InquiryDetail.Update(obj);
        }

        public InquiryDetailRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
    }
}
