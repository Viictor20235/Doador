namespace Doador.Service.Service
{
    public class Doador : IDoadorService
    {
        public Doador(IDoadorRepository repository)
        {
            repository = repository;
        }



        public Task<string> PostAsync(DoadorCommand command)
        {
            throw new NotImplementedException();
        }
    }

    public class DoadorCommand
    {
    }

    public interface IDoadorRepository
    {
    }

    public interface IDoadorService
    {
    }
}