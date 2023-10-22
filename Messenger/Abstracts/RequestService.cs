using RestSharp;


namespace Messenger;


public abstract class RequestService : IRequestService
{
    public RestClient Client => _restClient;
    private readonly RestClient _restClient;


    public RequestService()
    {
        _restClient = new RestClient("https://api-dbw.stat.gov.pl/api/1.1.0/");
    }


    public RestRequest CreateBaseRequest(string endpoint, Method method) =>
        new(endpoint,method);
}