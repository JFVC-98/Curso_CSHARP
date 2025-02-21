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
                if (method.DeclaringType.Namespace != "System")
                {
                    Console.WriteLine("Tipo metodo: " + method.ReturnType.Name);
                    Console.WriteLine("Nombre metodo: "+method.Name);
                    foreach (var param in method.GetParameters())
                    {
                        Console.WriteLine("Parametro: "+param);
                    }
                    //method.Invoke(item.Value, new object[] { 1 });
                    /*if (method.Name != "Imprimir")
                    {
                        //item.Value.GetType().GetMethod(method.Name).Invoke(item.Value, new object[] { 1 });
                        method.Invoke(item,new object[] { Convert.ToInt32(Console.ReadLine()) });
                    }*/
                    Console.WriteLine("Clase: "+method.DeclaringType.Name);
                    Console.WriteLine("\n");

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