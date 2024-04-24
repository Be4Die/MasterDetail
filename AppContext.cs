using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace MasterDetail
{
    public static class AppContext
    {
        public static BindingList<ConcertHallModel> ConcerteHalls { get; } = new();

        public static ConcertHallModel AddEmptyHall()
        {
            var model = new ConcertHallModel();
            ConcerteHalls.Add(model);
            return model;
        }
        public static void RemoveHall(ConcertHallModel concertHall) => ConcerteHalls.Remove(concertHall);

        public static void SaveData(string path)
        {
            var serializer = new XmlSerializer(typeof(List<ConcertHallModel>));
            using (var fileStream = new FileStream(path, FileMode.Create))
            {
                using (var writer = XmlWriter.Create(fileStream))
                {
                    serializer.Serialize(writer, AppContext.ConcerteHalls.ToList());
                }
            }
        }

        public static bool LoadData(string path)
        {
            var serializer = new XmlSerializer(typeof(List<ConcertHallModel>));
            using (var fileStream = new FileStream(path, FileMode.Open))
            {
                using (var reader = XmlReader.Create(fileStream))
                {
                    if (!serializer.CanDeserialize(reader))
                        return false;
                    var data = serializer.Deserialize(reader) as List<ConcertHallModel>;
                    if (data == null)
                        return false;

                    ConcerteHalls.Clear();
                    foreach (var item in data)
                    {
                        ConcerteHalls.Add(item);
                    }
                }
            }
            return true;
        }

        public static void Initialize()
        {
            var ticket1 = new TicketModel();
            ticket1.Price = 123;
            ticket1.EventName = "cool event";
            ticket1.PlaceName = "dream place";
            ticket1.Number = 111;
            var ticket2 = new TicketModel();
            ticket2.Price = 321;
            ticket2.EventName = "cool event 2";
            ticket2.PlaceName = "dream place 2";
            ticket2.Number = 222;

            var hall = new ConcertHallModel();
            hall.Adress = "cool adress";
            hall.OpeningDate = DateTime.Now;
            hall.Name = "best hall";
            hall.Capacity = 1111;
            hall.Tickets.Add(ticket1);
            hall.Tickets.Add(ticket2);
            ConcerteHalls.Add(hall);

            var ticket3 = new TicketModel();
            ticket3.Price = 123;
            ticket3.EventName = "cool event";
            ticket3.PlaceName = "dream place";
            ticket3.Number = 3332;
            var ticket4 = new TicketModel();
            ticket4.Price = 321;
            ticket4.EventName = "cool event 2";
            ticket4.PlaceName = "dream place 2";
            ticket4.Number = 4442;

            var hall2 = new ConcertHallModel();
            hall2.Adress = "cool adress";
            hall2.OpeningDate = DateTime.Now;
            hall2.Name = "best hall 2";
            hall2.Capacity = 1111;
            hall2.Tickets.Add(ticket3);
            hall2.Tickets.Add(ticket4);
            ConcerteHalls.Add(hall2);
        }

    }
}
