using RestSharp;
using System;

//This is not really a page object
public class jsonplaceholder
{
    public static IRestResponse GetUsersRequest()
    {
        var client = new RestClient("https://jsonplaceholder.typicode.com/posts/1");
        var request = new RestRequest(Method.GET);
        IRestResponse response = client.Execute(request);
        return response;
    }

    public static IRestResponse CreateUserRequest()
    {
        var client = new RestClient("https://jsonplaceholder.typicode.com/posts");
        var request = new RestRequest(Method.POST);
        request.AddHeader("Content-Type", "application/json");
        request.AddJsonBody("{\n  \"userId\": 1,\n  \"id\": 1,\n  \"title\": \"sunt aut facere repellat p" +
            "rovident occaecati excepturi optio reprehenderit\",\n  \"body\": \"quia et suscipit\\nsuscipit " +
            "recusandae consequuntur expedita et cum\\nreprehenderit molestiae ut ut quas totam\\nnostrum rerum " +
            "est autem sunt rem eveniet architecto\"\n}");
        IRestResponse response = client.Execute(request);
        return response;
    }

    public static IRestResponse DeleteUserRequest()
    {
        var client = new RestClient("https://jsonplaceholder.typicode.com/posts/1");
        var request = new RestRequest(Method.DELETE);
        IRestResponse response = client.Execute(request);
        return response;
    }

    public static IRestResponse EditUserRequest()
    {
        var client = new RestClient("https://jsonplaceholder.typicode.com/posts/1");
        var request = new RestRequest(Method.PUT);
        request.AddHeader("Content-Type", "application/json");
        request.AddJsonBody("{\n  \"userId\": 1,\n  \"id\": 1,\n  \"title\": \"sunt aut facere repellat p" +
            "rovident occaecati excepturi optio reprehenderit\",\n  \"body\": \"quia et suscipit\\nsuscipit " +
            "recusandae consequuntur expedita et cum\\nreprehenderit molestiae ut ut quas totam\\nnostrum rerum " +
            "est autem sunt rem eveniet architecto\"\n}");
        IRestResponse response = client.Execute(request);
        return response;
    }
}
