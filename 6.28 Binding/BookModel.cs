using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._28_Binding
{
    public class BookModel:INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged( String propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        private String image;
        public String Image  {
            get { return image; }
            set {
                image = value;
                if (PropertyChanged != null) {
                    NotifyPropertyChanged();
                }
            }
        }

        private String title;
        public String Title  {
            get { return title; }
            set {
                title = value;
                if (PropertyChanged != null)
                {
                    NotifyPropertyChanged();
                }
            }
        }

        private String author;
        public String Author {
            get { return author; }
            set {
                author = value;
                if (PropertyChanged != null)
                {
                    NotifyPropertyChanged();
                }
            }
        } 
    }

    public class BookManager {
        public static ObservableCollection<BookModel> GetMyBooks()
        {
            ObservableCollection<BookModel> Books = new ObservableCollection<BookModel>();

            Books.Add(new BookModel { Image = "/Assets/meinv01.png",Title="苍井空",Author="苍老师"});
            Books.Add(new BookModel { Image = "/Assets/meinv02.png", Title = "小泽", Author = "泽" });
            Books.Add(new BookModel { Image = "/Assets/meinv03.jpg", Title = "藤原纪香", Author = "小腾" });

            return Books;
        }
    }
}
