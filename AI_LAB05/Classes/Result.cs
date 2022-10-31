using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AI_LAB05.Classes
{
    internal class Result : Category
    {
        public float _result;
        public Result(int category_num, string category_name, float result) : base(category_num, category_name)
        {
            _result = result;
        }
        override public String ToString()
        {
            return _category_num + " - " + _category_name + ": " + String.Format("{0:P}", _result);
        }
    }
}
