using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace notify_me
{
    public class CSV
    {
        public string filePath;
        public List<INotifier> list;

        public CSV(List<INotifier> list, string filePath)
        {
            this.list = list;
            this.filePath = filePath;
        }


        //used to save Notifier to file
        public void Save()
        {
            StreamWriter streamWriter = new StreamWriter(filePath, false);
            foreach (INotifier item in list)
            {
                streamWriter.WriteLine(item.ToCSV());
            }
            streamWriter.Close();
        }

        //used to retrive Notifier from file
        public void Read()
        {
            if (File.Exists(filePath))
            {
                StreamReader streamReader = new StreamReader(filePath);
                string line;
                //if line == null end of file
                while ((line = streamReader.ReadLine()) != null)
                {
                    //create object and add it to the list depend on the first value in the CSV line
                    switch(line.Split(',', 2)[0])
                    {
                        case "Bell":
                            list.Add(new Bell(line));
                            break;
                        case "Alarm":
                            list.Add(new Alarm(line));
                            break;
                        case "Calendar":
                            list.Add(new Calendar(line));
                            break;
                        default:
                            break;
                    }
                }
                streamReader.Close();
            }
        }
    }
}
