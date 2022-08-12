/// this class is unnecessary, just for demo

using PropertyChanged;
using System.ComponentModel;

namespace WpfTreeView
{
    [AddINotifyPropertyChangedInterface]
    public class Class1 : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler? PropertyChanged = (sender, e) => { };

        public string Test { get; set; }

 

       
    }
}
