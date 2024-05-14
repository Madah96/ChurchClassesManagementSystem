using System.Net;

namespace ChurchClassesManagementSystem
{
    internal interface IRestResponse
    {
        HttpStatusCode StatusCode { get; }
        string Content { get; }
    }
}