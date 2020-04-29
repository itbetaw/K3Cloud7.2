using System;
using System.Collections.Generic;
using System.Text;

namespace Middleware.Target.Core.Models.K3Cloud7_2.FormOperationResult.View
{
    public class SalOrder_ViewResult
    {
        public int Id { get; set; }
        public string BillNo { get; set; }
        public int CustId_Id { get; set; }
        public Custid CustId { get; set; }

        public Saleorderentry[] SaleOrderEntry { get; set; }
        public class Custid
        {
            public int Id { get; set; }
            public int msterID { get; set; }
            public string Number { get; set; }
        }

        public class Saleorderentry
        {
            public Materialid MaterialId { get; set; }
            public Unitid UnitId { get; set; }
            public decimal Price { get; set; }
            public decimal TaxPrice { get; set; }
            public decimal TaxRate { get; set; }
            public decimal TaxAmount { get; set; }
            public decimal Qty { get; set; }
            public decimal AllAmount { get; set; }

        }

        public class Materialid
        {
            public int Id { get; set; }
            public int msterID { get; set; }
            public string Number { get; set; }
        }
        public class Unitid
        {
            public int Id { get; set; }
            public Name[] Name { get; set; }
            public string Number { get; set; }

        }
        public class Name
        {
            public int Key { get; set; }
            public string Value { get; set; }
        }
    }
}
