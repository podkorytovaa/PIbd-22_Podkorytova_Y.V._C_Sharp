using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace WindowsFormsCatamaran
{
    // Класс-коллекция гаваней
    class PortCollection
    {
        readonly Dictionary<string, Port<Vehicle>> portStages; // Словарь (хранилище) с гаванями
        public List<string> Keys => portStages.Keys.ToList(); // Возвращение списка названий гаваней
        private readonly int pictureWidth; // Ширина окна отрисовки
        private readonly int pictureHeight; // Высота окна отрисовки
        private readonly char separator = ':'; // Разделитель для записи информации в файл
        
        // Конструктор 
        public PortCollection(int pictureWidth, int pictureHeight) 
        { 
            portStages = new Dictionary<string, Port<Vehicle>>(); 
            this.pictureWidth = pictureWidth; 
            this.pictureHeight = pictureHeight; 
        }

        // Добавление гавани
        public void AddPort(string name)         
        {
            if (!portStages.ContainsKey(name))
            {
                portStages.Add(name, new Port<Vehicle>(pictureWidth, pictureHeight));
            }
        } 

        // Удаление гавани
        public void DelPort(string name)
        {
            if (portStages.ContainsKey(name))
            {
                portStages.Remove(name);
            }
        } 

        // Доступ к гавани
        public Port<Vehicle> this[string ind]
        {
            get 
            {
                if (portStages.ContainsKey(ind))
                {
                    return portStages[ind];
                }
                else return null;
            }
        }

        // Сохранение информации по лодкам в гаванях в файл
        public void SaveData(string filename)
        {
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }
            else
            {
                throw new FileNotFoundException();
            }
            using (StreamWriter sw = new StreamWriter(filename))
            {
                sw.Write($"PortCollection{Environment.NewLine}", sw);
                foreach (var level in portStages)
                {
                    sw.Write($"Port{separator}{level.Key}{Environment.NewLine}", sw);
                    ITransport boat = null;
                    for (int i = 0; (boat = level.Value.GetNext(i)) != null; i++)
                    {
                        if (boat != null)
                        {
                            if (boat.GetType().Name == "Boat")
                            {
                                sw.Write($"Boat{separator}", sw);
                            }
                            if (boat.GetType().Name == "Catamaran")
                            {
                                sw.Write($"Catamaran{separator}", sw);
                            }
                            sw.Write(boat + Environment.NewLine, sw);
                        }
                    }
                }
            }                   
        } 

        // Загрузка информации по транспорту в гаванях из файла 
        public void LoadData(string filename)         
        {             
            if (!File.Exists(filename))             
            {
                throw new FileNotFoundException();
            }
            using (StreamReader sr = new StreamReader(filename, Encoding.UTF8))
            {
                string line = sr.ReadLine();
                if (line.Contains("PortCollection"))
                {
                    portStages.Clear();
                }
                else
                {
                    throw new FormatException("Неверный формат файла");
                }
                Vehicle boat = null;
                string key = string.Empty;
                while ((line = sr.ReadLine()) != null)
                {
                    if (line.Contains("Port"))
                    {
                        key = line.Split(separator)[1];
                        portStages.Add(key, new Port<Vehicle>(pictureWidth, pictureHeight));
                        continue;
                    }

                    if (string.IsNullOrEmpty(line))
                    {
                        continue;
                    }

                    if (line.Split(separator)[0] == "Boat")
                    {
                        boat = new Boat(line.Split(separator)[1]);
                    }
                    else if (line.Split(separator)[0] == "Catamaran")
                    {
                        boat = new Catamaran(line.Split(separator)[1]);
                    }

                    var result = portStages[key] + boat;
                    if (result == -1)
                    {
                        throw new PortOverflowException();
                    }
                }
            }
        }
    } 
}
