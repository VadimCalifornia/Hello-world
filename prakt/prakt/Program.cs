using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Text;
using System.IO;
using prakt;

/*using (ApplicationContext db = new ApplicationContext())
{
        var Clients = db.Client.ToArray();
        Console.WriteLine("Список объектов");
        foreach (Client u in Clients)
        {
            Console.WriteLine(u.ID + " - " + u.ClientsName + " - " + u.IdOfClient);
        }
}*/
/*using (ApplicationContext db = new ApplicationContext())
{
    Client test = new Client { ID = 33, ClientsName = "Сидоров", IdOfClient = 1 };
    db.Client.Add(test);
    db.SaveChanges();
    var Clients = db.Client.ToArray();
    Console.WriteLine("Список объектов");
    foreach (Client u in Clients)
    {
        Console.WriteLine(u.ID + " - " + u.ClientsName + " - " + u.IdOfClient);
    }

}*/

/*using (ApplicationContext db = new ApplicationContext())
{
    Client? upduser = (from Client in db.Client where Client.ID == 33 select Client).First();
    if (upduser != null)
    {
        upduser.ClientsName = upduser.ClientsName = "Петров";
        db.SaveChanges();
    }
    var сlients = db.Client.ToArray();
    Console.WriteLine("Список объектов");
    foreach (Client u in сlients)
    {
        Console.WriteLine(u.ID + " - " + u.ClientsName + " - " + u.IdOfClient);
    }

}*/

/*using (ApplicationContext db = new ApplicationContext())
{
    Client? deluser = (from Client in db.Client where Client.ID == 33 select Client).First();
    if (deluser != null)
    {
        db.Client.Remove(deluser);
        db.SaveChanges();
    }
    var clients = db.Client.ToArray();
    Console.WriteLine("Список объектов");
    foreach (Client u in clients)
    {
        Console.WriteLine(u.ID + " - " + u.ClientsName + " - " + u.IdOfClient);
    }

}*/
 using (ApplicationContext db = new ApplicationContext())
{
    var mechanics = db.Mechanics.ToArray();
    var client = db.Client.Where(c => c.ID == 33).FirstOrDefault();
    Mechanic mechanic = new Mechanic { ID = 16, MechanicsName = "Васин", Clients = client };


    db.Mechanics.Add(mechanic);

    db.SaveChanges();
}

