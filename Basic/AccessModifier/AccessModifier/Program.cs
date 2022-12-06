using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifier
{
    internal class Program
    {
        // c#中的访问修饰符
        // public : 公共的
        // private : 私有的, 只能在当前类的内部访问
        // protected : 受保护的, 只能在当前类的内部以及该类的子类中访问
        // internal : 当前程序集中访问, 只能在当前项目中访问.
        //            在同一个项目中. internal和public的权限是一样的
        // protected internal : protected + internal

        // 能够修饰类的访问修饰符只有两个: public, internal(默认)
        static void Main(string[] args)
        {

        }
    }

    internal class Person
    {
        protected string _name;
    }

    public class Student  
    {
       
    }
}
