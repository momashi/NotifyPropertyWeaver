using System.ComponentModel;
using NotifyPropertyWeaver;

public class ClassWithTernary : INotifyPropertyChanged
{
    decimal? property1;
    public event PropertyChangedEventHandler PropertyChanged;

    [NotifyProperty]
    public decimal? Property1
    {
        get { return property1; }
        set
        {
            var newValue = value == 0.0m ? null : value;
            if (property1 != newValue)
            {
                property1 = newValue;
            }
        }
    }
}