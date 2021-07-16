using System.Collections.Generic;

namespace InertiaAdapter.Models
{
    public class Props
    {
        public object? Controller { get; set; }
        public IDictionary<string, object>? SharedProps { get; set; }
        public object? With { get; set; }
    }
}
