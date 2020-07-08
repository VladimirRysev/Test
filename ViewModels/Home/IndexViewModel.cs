using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Test.ViewModels.Home
{
    public class IndexViewModel
    {
        [Display(Name ="Выбрать все")]
        public bool SelectAll { get; set; }
        public List<RowDto> Rows { get; set; }
        public void Init(int rowCount)
        {
            Rows = new List<RowDto>();

            for (int i = 0; i < rowCount; i++)
            {
                Rows.Add(new RowDto());
            }
        }
    }

    public class RowDto
    {
        public bool Douwnload { get; set; }
        public bool Delete { get; set; }
        public bool Change { get; set; }
        public bool Create { get; set; }
        public bool Read { get; set; }
    }
}
