using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListRecommendations
{
    class Logs
    {
        public string dataLogs; //Логи сохраняются по пути (Ваш диск:\Пользователи\Пользователь\AppData\Roaming\LOGS\logs.txt)
        string pathData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\LOGS";
        public string pathLogs = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\LOGS\logs.txt";
    }
}
