using Business.Concrete;
using Entities.Concrete;

Person person1 = new Person()
{
    FirstName = "Hüseyin",
    LastName = "Aydın",
    DateOfBirthYear = 1994,
    NationalIdentity = 00000000000 //Yok yok (-:
};

PttManager pttManager = new PttManager(new PersonManager());
await pttManager.GiveMask(person1);