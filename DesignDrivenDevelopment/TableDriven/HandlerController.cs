using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableDriven
{
    public class HandlerController
    {
       
        public void Print(int contactProperty)
        {
            if (_handlers.ContainsKey(contactProperty))
                _handlers[contactProperty].PrintNumber(contactProperty);
        }
        private IDictionary<int, IHandler> _handlers = new Dictionary<int, IHandler>()
        {
            { 1, new HandlerOne()},
            { 2, new HandlerTwo()}
        };

    }
}
