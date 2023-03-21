using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApp13
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {

        public List<Lada> lada { get; set; } = new List<Lada>()
        {
            new Lada()
            {
                Model="2107",
                Year=2007,
                Color="White",
                ImagePath="C:\\Users\\HP\\source\\repos\\WpfApp13\\WpfApp13\\nolyeddi.jpg"
            },
            new Lada()
            {
                Model="Priora",
                Year=2013,
                Color="White",
                ImagePath="C:\\Users\\HP\\source\\repos\\WpfApp13\\WpfApp13\\priora.jpg"
            }
        }; 
        public List<Mercedes> mercedes { get; set; } = new List<Mercedes>()
        {
            new Mercedes()
            {
                Model="E class",
                Year=2020,
                Color="Gray",
                ImagePath="C:\\Users\\HP\\source\\repos\\WpfApp13\\WpfApp13\\mercedeseclass.png"

            },
            new Mercedes()
            {
                Model="G 63",
                Year=2020,
                Color="Black",
                ImagePath="C:\\Users\\HP\\source\\repos\\WpfApp13\\WpfApp13\\glk.jpg"

            }
        };
        public List<BMW> bmw { get; set; } = new List<BMW>()
        {
            new BMW()
            {
                Model="X5",
                Year=2019,
                Color="DarkBlue",
                ImagePath="C:\\Users\\HP\\source\\repos\\WpfApp13\\WpfApp13\\x5.jpg"
            },
            new BMW()
            {
                Model="M3",
                Year=2019,
                Color="White",
                ImagePath="C:\\Users\\HP\\source\\repos\\WpfApp13\\WpfApp13\\m3.png"
            }
        };
        public List<Hyundai> hyundai { get; set; } = new List<Hyundai>()
        {
            new Hyundai()
            {
                Model="Sonata",
                Year=2022,
                Color="Black",
                ImagePath="C:\\Users\\HP\\source\\repos\\WpfApp13\\WpfApp13\\sonata.jpg"
            },
            new Hyundai()
            {
                Model="X5",
                Year=2014,
                Color="White",
                ImagePath="C:\\Users\\HP\\source\\repos\\WpfApp13\\WpfApp13\\elantra.jfif"
            }

        };
        public Window1()
        {
            InitializeComponent();

            DataContext = this;
        }

        
    }
}
