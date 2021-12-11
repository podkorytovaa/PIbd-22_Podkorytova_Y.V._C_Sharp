using System;

namespace WindowsFormsCatamaran
{
    // Класс-ошибка "Если в гавани уже есть лодка с такими же характеристиками"
    class PortAlreadyHaveException : Exception
    {
        public PortAlreadyHaveException() : base("В гавани уже есть такая лодка") { }
    }
}
