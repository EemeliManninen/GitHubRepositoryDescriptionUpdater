var client = new HttpClient();

var token = "";

var description = $"This description was updated by a bot at {DateTime.Now.ToString("F")}";

using (var requestMessage = new HttpRequestMessage(HttpMethod.Post, "https://api.github.com/repos/EemeliManninen/GitHubRepositoryDescriptionUpdater"))
{
    requestMessage.Headers.Add("Accept", "application/json");
    requestMessage.Headers.Add("User-Agent", "Other");
    requestMessage.Headers.Add("Authorization", "Bearer " + token);
    requestMessage.Content = new StringContent("{\"description\": \"" + description + "\"}");

    var result = client.SendAsync(requestMessage).Result;
}