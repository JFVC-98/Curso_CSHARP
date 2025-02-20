using Modulo_1;
using System.Collections;
using System.Data;
using System.Reflection;
using System.Runtime.InteropServices;
internal class Program
{
    private static void Main(string[] args)
    {
        List<object> lista = new List<object>();
        lista.Add(new Clase_1());
        lista.Add(new Clase_2());
        foreach (var item in lista)
        {

            //item.Value.GetType().GetMethod("Escoge").Invoke(item.Value, new object[] { 1 });
            //Console.WriteLine(item.Value.GetType().GetMethods(BindingFlags.Public));
            MethodInfo[] info = item.GetType().GetMethods();
            foreach (var method in info)
            {
                if (method.ReturnType == typeof(void))
                {
                    Console.WriteLine(method.Name);
                    //method.Invoke(item.Value, new object[] { 1 });
                    /*if (method.Name != "Imprimir")
                    {
                        //item.Value.GetType().GetMethod(method.Name).Invoke(item.Value, new object[] { 1 });
                        method.Invoke(item,new object[] { Convert.ToInt32(Console.ReadLine()) });
                    }*/
                    Console.WriteLine(method.DeclaringType);

                }
            }
            /*if (Console.ReadLine()=="1")
            {
                ((Clase_1)item.Value).Escoge(1);
            }
            else
            {
                ((Clase_2)item.Value).Escoge(2);
            }*/
        }
    }
}