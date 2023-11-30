using TAG.Networking.Agent.Api;
using TAG.Networking.Agent.Client;
using TAG.Networking.Agent.Model;

namespace ApiUsageExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // In order to be able to call an endpoint we need an api object. Theses are diffrent depending on the path of the endpoint.
            //  e.g. the endpoint /Agent/Account/login is called with the AccountApi object.
            //  The AccountApi object is created using a Configuration, the configuration contains the base path (domain) and information such as default headers (authorization)
            var config = new Configuration { BasePath = "https://lab.tagroot.io" };
            var accountApi = new AccountApi(config);

            // Updating the configuration here, won't change the configuration in the accountApi object.
            // This is because the configuration is copied into the accountApi object when it is created.
            // If you want to change the configuration in the accountApi object, you need to set the configuration property.
            // accountApi.Configuration.DefaultHeaders.Add("Authorization", "Bearer 123");

            // A recommendation is to have a single configuration object that is used AuthenticationExampleto create all the api objects.
            // This way you can change the configuration in one place and to update existing api objects you can do the following 
            accountApi.Configuration = Configuration.MergeConfigurations(config, accountApi.Configuration);

            // Example of a simple API call (e.g., retrieving domain information)
            // All Api endpoints has a unique model for the response, in this case DomainInfoResponse
            // Endpoints of the type POST will also require a Body object as a parameter, this objects is also unique for each endpoint
            // e.g., if GetDomainInfo would be a post request you would have to pass a DomainInfoBody as a parameter to the function
            try
            {
                DomainInfoResponse accountInfo = accountApi.GetDomainInfo();

                Console.WriteLine("Domain Information: " + accountInfo.ToString());
            }
            catch (ApiException e)
            {
                //If something went wrong with the request an ApiException will be thrown
                Console.WriteLine(e.Message);
                Console.WriteLine("HTTP code: :" + e.ErrorCode);
            }

        }
    }
}