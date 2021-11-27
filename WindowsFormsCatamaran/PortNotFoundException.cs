using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsCatamaran
{
    // Класс-ошибка "Если не найдена лодка по определенному месту"
    class PortNotFoundException : Exception
    {
        public PortNotFoundException(int i) : base("Не найдена лодка по месту " + i)
        { }
    }
}
