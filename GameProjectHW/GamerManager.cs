using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectHW
{
    class GamerManager : IGamerService
    {
        IUserValidationService _userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer)==true)
            {
                Console.WriteLine("Kayıt edidli");
            }
            else
            {
                Console.WriteLine("Doğrulama başarısız, Kayıt Başarısız");
            }
            
        }

        public void Delete(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer) == true)
            {
                Console.WriteLine("Kayıt Silinidi");
            }
            else
            {
                Console.WriteLine("Doğrulama başarısız, Kayıt Silme Başarısız");
            }

        }

        public void Update(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer) == true)
            {
                Console.WriteLine("Kayıt Güncellendi");
            }
            else
            {
                Console.WriteLine("Doğrulama başarısız, Güncelleme Başarısız");
            }
            
        }
    }
}
