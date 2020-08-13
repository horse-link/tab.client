using System;
using System.Threading.Tasks;

namespace tab.client
{
    public interface IAuthenticationClient
    {
        String Token { get; }

        Task Authenticate(Int32 accountNumber, String password);
    }
}