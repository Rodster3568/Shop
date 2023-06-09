﻿using Shop.Models;

namespace Shop.Data
{
    public class InquiryHeaderRepository : Repository<InquiryHeader>, IInquiryHeaderRepository
    {
        private readonly ApplicationDbContext _db;

        public InquiryHeaderRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        public void Update(InquiryHeader obj)
        {
            _db.InquiryHeader.Update(obj);
        }


    }
}
