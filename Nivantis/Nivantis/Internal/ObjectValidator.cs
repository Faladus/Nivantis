using System;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Nivantis.Internal
{
    public static class ObjectValidator
    {
        public static T Validate<T>(T obj)    
        {
            Type type = typeof(T);
            var properties = type.GetProperties();

            if (properties.Any(x => x.CanRead))
            {
                foreach (var property in properties)
                {
                    if (property != null) continue;
                    else return default(T);
                }
            }
            return obj;
            
        }

    }
}
