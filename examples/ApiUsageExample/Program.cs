using Neuron.Agent.Api;
using Neuron.Agent.Client;
using Neuron.Agent.Model;

namespace ApiUsageExample
{
    class Program
    {
        static async Task Main(string[] args)
        {
            // In order to be able to call an endpoint we need an api object. Theses are diffrent depending on the path of the endpoint.
            //  e.g. the endpoint /Agent/Account/login is called with the AccountApi object.
            //  The AccountApi object is created using a Configuration, the configuration contains the base path (domain) and information such as default headers (authorization)
            var config = new Configuration { BasePath = "http://localhost" };
            var accountApi = new AccountApi(config);

            // Updating the configuration here, won't change the configuration in the accountApi object.
            // This is because the configuration is copied into the accountApi object when it is created.
            // If you want to change the configuration in the accountApi object directly, you need to set the configuration property.
            // e.x. accountApi.Configuration.DefaultHeaders.Add("Authorization", "Bearer 123");

            // A recommendation is to have a single configuration object that is used to create all the api objects.
            // This way you can change the configuration and forward the changes to both existing and new api objects.
            // To merge the changes in the configuration object with the configuration within an api instance you can do the following
            accountApi.Configuration = Configuration.MergeConfigurations(config, accountApi.Configuration);

            // Example of a simple API call (retrieving domain information)
            // Most Api endpoints has a unique model for the response object, in this case DomainInfoResponse
            // Endpoints of the type POST will also require a Body object as a parameter, this objects is also unique for each endpoint
            // e.g., if GetDomainInfo would be a post request you would have to pass a DomainInfoBody as a parameter to the function
            try
            {
                DomainInfoResponse accountInfo = await accountApi.GetDomainInfoAsync(); //There also exists GetDomainInfo() which is not async

                Console.WriteLine("Domain Information: " + accountInfo.ToString());
            }
            catch (ApiException e)
            {
                //If something went wrong with the request an ApiException will be thrown
                Console.WriteLine(e.Message);
                Console.WriteLine("HTTP code: :" + e.ErrorCode);
            }

            //Each endpoint also has a ...WithHttpInfo variant, that returns an ApiResponse object containing the body, status code and headers.
            try
            {
                ApiResponse<DomainInfoResponse> accountInfo = await accountApi.GetDomainInfoWithHttpInfoAsync();
                Console.WriteLine("Domain Information: " + accountInfo.Data.ToString());
                Console.WriteLine("HTTP code: :" + accountInfo.StatusCode);
            }
            catch (ApiException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("HTTP code: :" + e.ErrorCode);
            }
        }
    }
}