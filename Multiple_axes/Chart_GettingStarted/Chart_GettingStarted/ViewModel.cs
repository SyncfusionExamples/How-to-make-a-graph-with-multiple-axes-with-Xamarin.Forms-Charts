using System;
using System.Collections.Generic;
using System.Text;

namespace Chart_GettingStarted
{
    public class ViewModel
    {
        public List<Model> Data { get; set; }

        DateTime date;
        public ViewModel()
        {
            date = new DateTime(2020, 01, 01);
            Data = new List<Model>()
            {
                new Model { XValue = date, YValue1 = 387, YValue2 = 19 },
                new Model { XValue = date.AddMonths(1), YValue1 = 390, YValue2 = 20 },
                new Model { XValue = date.AddMonths(2), YValue1 = 385, YValue2 = 22 },
                new Model { XValue = date.AddMonths(3), YValue1 = 377, YValue2 = 18 },
                new Model { XValue = date.AddMonths(4), YValue1 = 385, YValue2 = 20 },
            };
        }
    }
}
