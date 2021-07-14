using System;

namespace n10482652
{
    class Tool : iTool
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public int AvailableQuantity { get; set; }
        public int NoBorrowings { get; set; }
        public iMemberCollection GetBorrowers => throw new NotImplementedException();

        public void addBorrower(iMember aMember)
        {
            throw new NotImplementedException();
        }

        public void deleteBorrower(iMember aMember)
        {
            throw new NotImplementedException();
        }
    }
}
