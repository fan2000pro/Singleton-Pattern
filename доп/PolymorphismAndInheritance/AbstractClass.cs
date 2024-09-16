using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismAndInheritance
{
    internal abstract class AbstractClass
    {
        internal abstract string GetInfo();
    }
    internal class SimpleClass
    {
        internal string GetInfo()
        {
            return "I am SimpleClass";
        }
        internal virtual string GetVirtualInfo()
        {
            return "This is virtual method to get information about class";
        }
    }
    internal class SimpleInheritor : SimpleClass
    {
        internal new string GetInfo() //Сокрытие наследуемого члена
        {
            return "I am SimpleInheritor";
        }
        internal override string GetVirtualInfo() //Переопределение наследуемого члена
        {
            return "This is overrided method to get information about class";
        }
    }
    internal class ConcreteClass1 : AbstractClass
    {
        internal override string GetInfo()
        {
            return "I am ConcreteClass1";
        }
    }
    internal class ConcreteClass2 : AbstractClass
    {
        internal override string GetInfo()
        {
            return "I am ConcreteClass2";
        }
    }
}
