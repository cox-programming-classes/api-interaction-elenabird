global using ErrorAction = System.Action<CS8_MessageAPI.Models.ErrorRecord>;
using CS8_MessageAPI.Services;

//this is postman analog
var apiService = new ApiService();

var loginSuccess = true;

await apiService.Login("elena.bird@winsor.edu", "*##EDDlvc278",
    err =>
    {
        Console.WriteLine(err);
        loginSuccess = false;
    });
    
if(!loginSuccess)
    return;

var myFreeBlocks = await apiService.SendAsync<FreeBlockCollection>(
    HttpMethod.Get, "api/schedule/free-blocks/for/m5qpXk0XQn2x",
    err =>
    {
        
    });