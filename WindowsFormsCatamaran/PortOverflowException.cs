using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsCatamaran
{
    // Класс-ошибка "Если в гавани уже заняты все места" 
    class PortOverflowException : Exception
    {
        public PortOverflowException() : base("В гавани нет свободных мест")
        { }
    }
}
