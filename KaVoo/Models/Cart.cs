using KaVoo.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KaVoo.Models
{
    public class Cart
    {
        private List<CartLine> _cardLines = new List<CartLine>();

        public List<CartLine> CartLines
        {
            get { return _cardLines; }
        }

        public void AddPsikolog(Psikolog psikolog, int quantity)
        {
            var line = _cardLines.FirstOrDefault(i => i.Psikolog.Id == psikolog.Id);
            if (line == null)
            {
                _cardLines.Add(new CartLine() { Psikolog = psikolog, Quantity = quantity });
            }
            else
            {
                line.Quantity += quantity;
            }
        }

        public void DeletePsikolog(Psikolog psikolog)
        {
            _cardLines.RemoveAll(i => i.Psikolog.Id == psikolog.Id);
        }

        public double Total()
        {
            return _cardLines.Sum(i => i.Psikolog.Price * i.Quantity);
        }

        public void Clear()
        {
            _cardLines.Clear();
        }
    }

    public class CartLine
    {
        public Psikolog Psikolog { get; set; }
        public int Quantity { get; set; }
    }
}