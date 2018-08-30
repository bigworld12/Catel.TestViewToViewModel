using Catel.Data;
using Catel.Fody;
using Catel.MVVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestViewToViewModel
{
    public class TestControlViewModel : ViewModelBase
    {
        [Expose(nameof(TestModel.SomeRandomNumber))]
        [Model]
        public TestModel SomeModelProperty { get; set; }



        protected override void OnPropertyChanged(AdvancedPropertyChangedEventArgs e)
        {
            if (e.IsNewValueMeaningful && e.IsOldValueMeaningful)
                Console.WriteLine($"ViewModel PropertyChanged, New Value : {e.NewValue}, Old Value : {e.OldValue}, Prop. Name : {e.PropertyName}");
        }
    }
}
