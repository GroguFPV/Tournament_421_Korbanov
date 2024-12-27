using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Tournament_421_Korbanov.db;

namespace Tournament_421_Korbanov
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static Tournament_421_KorbanovEntities db = new Tournament_421_KorbanovEntities();
    }
}
