using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    internal class Zametka
    {
        public string Name { get; set; }
        public string Tip { get; set; }
        public string Date; // Изменили тип переменной Date на string
        public int Money { get; set; }
        public bool Action { get; set; }

        public Zametka(string name, string tip, string date, int money, bool action) // Изменили тип параметра date на string
        {
            Name = name;
            Tip = tip;
            Date = date;
            Money = Math.Abs(money);
            Action = action;
        }
    }
}
