using System.Net;
using RestSharp;


namespace Messenger;


public class BasicRequestService : RequestService
{
    public BasicRequestService()
    {
        var request = CreateBaseRequest("/version/",Method.Get);


        var response = Client.Execute(request);
        if(response.StatusCode != HttpStatusCode.OK)
            throw new Exception("ailed to retrieve the API version");
    }
}