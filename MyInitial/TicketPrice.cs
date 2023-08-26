using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ticketing
{
    public class TicketPrice
    {
        private int section;
        private int quantity;
        private bool discountSeniorStudent;
        private bool discountChild;
        private decimal amountDue;
        private decimal mPrice;

        const decimal mdecBalcony = 35.5m;
        const decimal mdecGeneral = 28.75m;
        const decimal mdecBox = 62.0m;
        const decimal mdecDiscountSeniorStudent = 5.0m;
        const decimal mdecDiscountChild = 10.0m;

        private int Section
        {
            get { return section; }
            set { section = value; }
        }

        private int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        private bool DiscountSeniorStudent
        {
            get { return discountSeniorStudent; }
            set { discountSeniorStudent = value; }
        }

        private bool DiscountChild
        {
            get { return discountChild; }
            set { discountChild = value; }
        }

        public decimal AmountDue
        {
            get { return amountDue; }
            set { amountDue = value; }
        }

        // Constructor for TcicketPrice
        public TicketPrice(int section, int quantity, bool discountSeniorStudent, bool discountChild)
        {
            Section = section;
            Quantity = quantity;
            DiscountSeniorStudent = discountSeniorStudent;
            DiscountChild = discountChild;
            AmountDue = amountDue;
        }

        public void calculatePrice()
        {

            switch (section)
            {
                case 1:
                    mPrice = mdecBalcony;
                    break;
                case 2:
                    mPrice = mdecGeneral;
                    break;
                case 3:
                    mPrice = mdecBox;
                    break;
            }
            if (discountSeniorStudent)
            { mPrice -= mdecDiscountSeniorStudent; }

            if (discountChild)
            { mPrice -= mdecDiscountChild; }

            AmountDue = mPrice * quantity;

        }
    }
}
