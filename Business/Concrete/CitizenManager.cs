using Business.Abstract;
using Entities.Abstract;
using Entities.Concrete;
using MernisServiceReference;

namespace Business.Concrete;

public class CitizenManager : IApplicantService
{
    private ICheckPersonService _checkPersonService;

    public CitizenManager(ICheckPersonService checkPersonService)
    {
        _checkPersonService = checkPersonService;
    }

    public void ApplyForMask(Person person)
    {
        throw new NotImplementedException();
    }

    public bool CheckPerson(Person person)
    {
        return _checkPersonService.CheckIfPersonExists(person);
    }

    public List<Citizen> GetAll()
    {
        throw new NotImplementedException();
    }
}
