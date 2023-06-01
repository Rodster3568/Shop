using Shop.Models;

namespace Shop.Data
{
    public interface IInquiryHeaderRepository : IRepository<InquiryHeader>
    {
        void Update(InquiryHeader obj);


    }
}
