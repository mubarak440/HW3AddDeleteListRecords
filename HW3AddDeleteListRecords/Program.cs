// See https://aka.ms/new-console-template for more information

using System.Diagnostics;
using Microsoft.EntityFrameworkCore;
using HW3AddDeleteListRecords.Db;

Console.WriteLine("Hello, World!");

//load and open class
var contexts = new HW3AddDeleteListRecords.Db.ContactsContext();//get access to the database



Contact UserContact = new Contact();
UserContact.ContactName = "Ali";
UserContact.ContactEmail = "Ali110@gmail.com";
UserContact.ContactPhoneNumber = "212-900-0000";
UserContact.ContactPhoneType = "Home";
UserContact.ContactAge = 39;
UserContact.ContactNotes = "text";
UserContact.ContactCreatedDate = DateTime.Now;

var results = contexts.Contacts.ToList();
int txt = results.Count();
results.Add(UserContact);

contexts.Add(UserContact);
contexts.SaveChanges();

Console.WriteLine("Added a Contact:");
foreach (var contact in results)
{
    Console.WriteLine(contact.ContactName);

    Console.WriteLine(contact.ContactEmail);
    Console.WriteLine(contact.ContactPhoneNumber);
    Console.WriteLine(contact.ContactPhoneType);
    Console.WriteLine(contact.ContactAge);
    Console.WriteLine(contact.ContactNotes);
    Console.WriteLine(contact.ContactCreatedDate);

}

contexts.Remove(UserContact);
contexts.SaveChanges();

Console.WriteLine("Removed a Contact "+ "Check database");





