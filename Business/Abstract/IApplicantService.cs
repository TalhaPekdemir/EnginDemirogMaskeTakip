using Entities.Concrete;
using Entities.Abstract;

namespace Business.Abstract;

public interface IApplicantService
{
    void ApplyForMask(Person person);

    List<Citizen> GetAll();

    bool CheckPerson(Person person);
}
