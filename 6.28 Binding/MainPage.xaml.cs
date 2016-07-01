using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace _6._28_Binding
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public ObservableCollection<BookModel> MyBooks { get; set; }
        public MainPage()
        {
            this.InitializeComponent();

            MyBooks = BookManager.GetMyBooks();


            //CollectionViewSource viewSource = new CollectionViewSource();
            //viewSource.Source = MyBooks;
            // BookListView.DataContext = MyBooks;


            BookListView.DataContext = MyBooks;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MyBooks.Add(new BookModel { Author = "dd", Title = "oo" });
        }

        private void BookListView_Tapped(object sender, TappedRoutedEventArgs e)
        {
            GridView gview = sender as GridView;
            BookModel model = gview.SelectedItem as BookModel;
            model.Title = "99999999999i";     
        }
    }
}
