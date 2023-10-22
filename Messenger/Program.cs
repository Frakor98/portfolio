using System.Security.Cryptography.X509Certificates;

namespace Messenger;

public static class Program
{
    public static void Main()
    {
        IRequestService requestService = new BasicRequestService();
    }
}
