using Shop.Models;

namespace Shop.Data
{
    public interface IInquiryDetailRepository : IRepository<InquiryDetail>
    {
        void Update(InquiryDetail obj);


    }
}
