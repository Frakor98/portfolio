using RestSharp;


namespace Messenger;


public interface IRequestService
{
    public RestClient Client {get;}

    public RestRequest CreateBaseRequest(string endpoint, Method method);
}