using System.Collections.Generic;
using System.Linq;

namespace WindowsFormsCatamaran
{
    // Класс-коллекция парковок
    class PortCollection
    {
        readonly Dictionary<string, Port<Vehicle>> portStages; // Словарь (хранилище) с парковками
        public List<string> Keys => portStages.Keys.ToList(); // Возвращение списка названий праковок
        private readonly int pictureWidth; // Ширина окна отрисовки
        private readonly int pictureHeight; // Высота окна отрисовки

        // Конструктор 
        public PortCollection(int pictureWidth, int pictureHeight) 
        { 
            portStages = new Dictionary<string, Port<Vehicle>>(); 
            this.pictureWidth = pictureWidth; 
            this.pictureHeight = pictureHeight; 
        }

        // Добавление парковки
        public void AddParking(string name)         
        {
            if (portStages.ContainsKey(name)) 
                return;
            portStages.Add(name, new Port<Vehicle>(pictureWidth, pictureHeight));
        } 

        // Удаление парковки
        public void DelParking(string name)
        {
            if (portStages.ContainsKey(name))
                portStages.Remove(name);
        } 

        // Доступ к парковке
        public Port<Vehicle> this[string ind]
        {
            get 
            { 
                if (portStages.ContainsKey(ind)) 
                    return portStages[ind];
                else return null;
            }
        }

    }
}
