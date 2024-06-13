using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe10
{
    internal class Invoice
    {

        public uint Code { get; set; }
        public string Desc { get; set; }

        private int _qtd = 0;

        private double _price =0.0;


        public int Qtd
        {   
            get 
            { 
                return _qtd; 
            } 
            set 
            { 
                _qtd = value; 
            } 
        }

        public double Price
        {
            get
            {
                return _price;
            }
            set
            {
                if (value >= 0)
                    _price = value;
                else
                    _price = 0;
            }
        }

        public Invoice(uint code, string desc, int qtd, double price)
        {
            Code = code;
            Desc = desc;
            Qtd = qtd;
            Price = price;
        }

        public double GetInvoiceAmount()
        {
            return _qtd * _price;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("code: ");
            sb.AppendLine(Code.ToString());
            sb.Append("desc: ");
            sb.AppendLine(Desc.ToString());
            sb.Append("qtd: ");
            sb.AppendLine(Qtd.ToString());
            sb.Append("price: ");
            sb.AppendLine(Price.ToString("F2", CultureInfo.InvariantCulture));
            sb.Append("total: ");
            sb.Append(GetInvoiceAmount().ToString("F2", CultureInfo.InvariantCulture));

            return sb.ToString();
        }




    }
}
