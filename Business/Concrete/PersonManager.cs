using Business.Abstract;
using Entities.Concrete;
using ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete;

public class PersonManager : IApplicantService
{

    public List<Person> GetList()
    {
        return null;
    }

    public async Task<bool> CheckPersonAsync(Person person)
    {
        KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
        var dogrulaResult = await client.TCKimlikNoDogrulaAsync
        (TCKimlikNo: person.NationalIdentity,
        Ad: person.FirstName,
        Soyad: person.LastName,
        DogumYili: person.DateOfBirthYear);
        return dogrulaResult.Body.TCKimlikNoDogrulaResult;
    }

    public void ApplyForMask(Person person)
    {

    }
}