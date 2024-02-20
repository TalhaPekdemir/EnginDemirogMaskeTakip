using Business.Abstract;
using Entities.Abstract;
using Entities.Concrete;
using MernisServiceReference;

namespace Business.Adapter;

public class MernisServiceAdapter : ICheckPersonService
{
    public bool CheckIfPersonExists(Person person)
    {
        // TC vatandaşları için mernis doğrulaması endpointi
        KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);

        return client.TCKimlikNoDogrulaAsync(
            new TCKimlikNoDogrulaRequest(
                new TCKimlikNoDogrulaRequestBody(person.NationalIdentity, person.FirstName, person.LastName, person.DateOfBirthYear)))
            .Result.Body.TCKimlikNoDogrulaResult;
    }
}
