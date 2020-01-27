using System;
using System.Collections.Generic;

namespace PoeDashboard.Web.Models
{
    public class CurrencyPopoverModel
    {
        public CurrencyPopoverModel(string elementId, int valueInExalt, string currencyName)
        {
            ElementId = elementId;
            ValueInExalt = valueInExalt;
            CurrencyName = currencyName;
            FractionalValues = CalculateFractionalValues(valueInExalt);
        }
        public string ElementId { get; set; }
        public int ValueInExalt { get; set; }
        public string CurrencyName { get; set; }

        public List<(double fraction, int value)> FractionalValues { get; }

        private List<(double fraction, int value)> CalculateFractionalValues(int valuesInExalt)
        {
            List<(double fraction, int value)> tempDic = new List<(double fraction, int value)>();

            for (var i = 1; i < 10; i++)
            {
                double divided = (double)i / 10;
                tempDic.Add((divided, (int)Math.Ceiling(valuesInExalt * divided)));
            }

            return tempDic;
        }
    }
}
