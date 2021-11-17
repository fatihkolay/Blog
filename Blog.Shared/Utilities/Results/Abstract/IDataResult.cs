using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Shared.Utilities.Results.Abstract
{
    public interface IDataResult<out T>:IResult //out diyince ya liste ya entiti tasınabiliyor
    {
        public T Data { get; }

    }
}
