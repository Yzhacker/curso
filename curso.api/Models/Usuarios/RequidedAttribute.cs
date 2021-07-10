using System;

namespace curso.api.Models.Usuarios
{
    internal class RequidedAttribute : Attribute
    {
        public string ErrorMessage { get; set; }
    }
}