using RestSharp;

//This is not really a page object
public class Jsonplaceholder
{
    public static RestResponse GetUsersRequest()
    {
        var client = new RestClient("https://jsonplaceholder.typicode.com/posts/1");
        var request = new RestRequest();
        RestResponse response = client.Execute(request);
        return response;
    }

    public static RestResponse CreateUserRequest()
    {
        var client = new RestClient("https://jsonplaceholder.typicode.com/posts");
        var request = new RestRequest("", Method.Post);
        request.AddHeader("Content-Type", "application/json");
        request.AddJsonBody("{\n  \"userId\": 1,\n  \"id\": 1,\n  \"title\": \"sunt aut facere repellat p" +
            "rovident occaecati excepturi optio reprehenderit\",\n  \"body\": \"quia et suscipit\\nsuscipit " +
            "recusandae consequuntur expedita et cum\\nreprehenderit molestiae ut ut quas totam\\nnostrum rerum " +
            "est autem sunt rem eveniet architecto\"\n}");
        RestResponse response = client.Execute(request);
        return response;
    }

    public static RestResponse DeleteUserRequest()
    {
        var client = new RestClient("https://jsonplaceholder.typicode.com/posts/1");
        var request = new RestRequest("", Method.Delete);
        RestResponse response = client.Execute(request);
        return response;
    }

    public static RestResponse EditUserRequest()
    {
        var client = new RestClient("https://jsonplaceholder.typicode.com/posts/1");
        var request = new RestRequest("", Method.Put);
        request.AddHeader("Content-Type", "application/json");
        request.AddJsonBody("{\n  \"userId\": 1,\n  \"id\": 1,\n  \"title\": \"sunt aut facere repellat p" +
            "rovident occaecati excepturi optio reprehenderit\",\n  \"body\": \"quia et suscipit\\nsuscipit " +
            "recusandae consequuntur expedita et cum\\nreprehenderit molestiae ut ut quas totam\\nnostrum rerum " +
            "est autem sunt rem eveniet architecto\"\n}");
        RestResponse response = client.Execute(request);
        return response;
    }
}
