using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete;

public class PttManager : ISupplyService
{
    private readonly IApplicantService _applicantService;

    public PttManager(IApplicantService applicantService)
    {
        _applicantService = applicantService;
    }

    public async Task GiveMask(Person person)
    {
        var isPersonReal = await _applicantService.CheckPersonAsync(person);

        if (isPersonReal)
            Console.WriteLine("Kimlik doğrulaması Mernis SOAP Web Servisi sistemi üzerinden kontrol edildi, kimlik doğrulaması başarı ile yapıldı. " + person.FirstName + " için maske verildi");
        else
            Console.WriteLine("Girilen kullanıcı nüfusta kayıtlı değil ben ne bileyim senin gerçek T.C. vatandaşı olup olmadığını?");
    }
}