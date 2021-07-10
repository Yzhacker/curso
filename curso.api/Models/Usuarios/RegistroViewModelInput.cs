using System.ComponentModel.DataAnnotations;
using Xunit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace curso.api.Models.Usuarios


{
    public class RegistroViewModelInput
    {

        [Requided(ErrorMessage = "O Login é obrigatorio")]
        public string Login { get; set; }

        [Requided(ErrorMessage = "O E-mail é obrigatorio")]
        public string Email { get; set; }

        [Requided(ErrorMessage = "A Senha é obrigatorio")]
        public string Senha { get; set; }
    }
}




