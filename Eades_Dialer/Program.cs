using System;
// Alexander Eades
// IT112
// NOTES: notes the instructor should read
// BEHAVIORS NOT IMPLIMENTED AND WHY: 
namespace Eades_Dialer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("dialing");

            CellPhone p1 = new CellPhone("CompuTest", "(303) 985 - 5060", 1);
            Console.WriteLine(p1.Company + " is being dialed using "+ p1.Number+"..." );
        }
    }
}
