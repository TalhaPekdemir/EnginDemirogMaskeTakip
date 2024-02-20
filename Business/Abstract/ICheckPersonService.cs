using Entities.Abstract;

namespace Business.Abstract;

public interface ICheckPersonService
{
    bool CheckIfPersonExists(Person person);
}
