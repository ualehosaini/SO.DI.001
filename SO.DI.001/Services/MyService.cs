using SO.DI._001.Exceptions;

namespace SO.DI._001.Services
{
    public class MyService : IMyService
    {
        public void DoSomething()
        {
            throw new SomeCustomException();
        }
    }
}
