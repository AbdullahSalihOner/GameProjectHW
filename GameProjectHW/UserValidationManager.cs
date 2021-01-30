using ServiceReference1;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectHW
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrulaAsync(new TCKimlikNoDogrulaRequest(new TCKimlikNoDogrulaRequestBody(gamer.NationlityId,gamer.FirstName,gamer.LastName,gamer.BirthYear)))
                .Result.Body.TCKimlikNoDogrulaResult;
            
        }
    }
}
