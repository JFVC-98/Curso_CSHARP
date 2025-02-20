using Modulo_1;
using System.Collections;
using System.Data;
using System.Reflection;
using System.Runtime.InteropServices;
internal class Program
{
    private static void Main(string[] args)
    {
        Dictionary<int,object> lista = new Dictionary<int,object>();
        lista.Add(1, new Clase_1());
        lista.Add(2, new Clase_2());
        foreach (var item in lista)
        {
            
            //item.Value.GetType().GetMethod("Escoge").Invoke(item.Value, new object[] { 1 });
            //Console.WriteLine(item.Value.GetType().GetMethods(BindingFlags.Public));
            MethodInfo[] info = item.Value.GetType().GetMethods();
            foreach (var method in info)
            {
                if (method.ReturnType == typeof(void))
                {
                    Console.WriteLine(method.Name);
                    //method.Invoke(item.Value, new object[] { 1 });
                    if (method.Name!= "Imprimir") { 
                        //item.Value.GetType().GetMethod(method.Name).Invoke(item.Value, new object[] { 1 });
                        method.Invoke(item.Value, new object[] { 1 });
                    }
                    
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