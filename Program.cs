using System;
using System.Threading;

namespace Module_9_2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                throw new RankException("Сообщение об ошибке");
            }
            catch (RankException ex)
            {
                Console.WriteLine(ex.GetType());
            }
            finally
            {
                Console.Read();
            }
        }
    }
}