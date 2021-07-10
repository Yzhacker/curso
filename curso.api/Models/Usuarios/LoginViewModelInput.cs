
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace curso.api.Models.Usuarios
{
    public class LoginViewModelInput
    {
        [Requided(ErrorMessage = "O Login é obrigatorio")]
        public string Login { get; set; }

        [Requided(ErrorMessage = "A senha é obrigatoria")]
        public string Senha { get; set; }
    }
}
