using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Linq;

namespace WpfAppMarket
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public class Mallar
        {
            public string?_image { get; set; }
            public string? _name { get; set; }
            public string? Itarixi { get; set; }
            public string? Qiymeti { get; set; }
        }

        public List<Mallar> mallars { get; set; }
        public ObservableCollection<Mallar> sebet { get; set; }



        public MainWindow()
        {
            InitializeComponent();
            mallars = new()
            {
                new Mallar (){
                    _image=@"\Images\cola.jpg",
                    _name="Coca Cola",
                    Itarixi="15.6.2023",
                    Qiymeti="2.3 azn"
                },
                new Mallar()
                {
                    _image=@"\Images\Fanta.jpeg",
                    _name="Fanta",
                    Itarixi="15.6.2023",
                    Qiymeti="1.5 azn"
                },
                new Mallar()
                {
                    _image=@"Images\Sprite.jpeg",
                    _name="Sprite",
                    Itarixi="15.5.2023",
                    Qiymeti="1.0 azn"
                },
                new Mallar()
                {
                    _image=@"\Images\Cappy.jpeg",
                    _name="Cappy",
                    Itarixi="15.6.2023",
                    Qiymeti="1.7 azn"
                },
                new Mallar()
                {
                    _image=@"\Images\Hell.jpeg",
                    _name="Hell",
                    Itarixi="15.9.2023",
                    Qiymeti="1.0 azn"
                },
                 new Mallar()
                {
                    _image=@"\Images\Pepsi.jpeg",
                    _name="Pepsi",
                    Itarixi="10.9.2023",
                    Qiymeti="1.8 azn"
                },
                  new Mallar()
                {
                    _image=@"\Images\Redbul.jpeg",
                    _name="Redbul",
                    Itarixi="10.10.2023",
                    Qiymeti="2.5 azn"
                },
                   new Mallar()
                {
                    _image=@"\Images\Barjomi.jpeg",
                    _name="Barjomi",
                    Itarixi="1.10.2023",
                    Qiymeti="2.0 azn"
                },
                     new Mallar()
                {
                    _image=@"\Images\Jale.jpeg",
                    _name="Jale",
                    Itarixi="1.10.2023",
                    Qiymeti="3.0 azn"
                },
                      new Mallar()
                {
                    _image=@"\Images\Sirab.jpeg",
                    _name="Sirab",
                    Itarixi="1.10.2023",
                    Qiymeti="3.0 azn"
                }

            };
            DataContext = this;

            sebet = new();
         

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var btn=(sender as Button).DataContext as Mallar;
            sebet.Add(btn);

        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            var informasiya = (sender as Image).DataContext as Mallar;
          
            Melumat.Content = $"Adi : {informasiya._name}\n" +
                $"Istehsal tarixi : {informasiya.Itarixi}\n" +
                $"Qiymeti : {informasiya.Qiymeti}";

        }

       
       
    }
}
