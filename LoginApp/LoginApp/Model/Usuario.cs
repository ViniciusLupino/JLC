﻿using SQLite;

namespace LoginApp.Model
{
    public class Usuario
    {
        [PrimaryKey]
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Data { get; set; }
        public string Endereco { get; set; }
        public string Fone { get; set; }
        public Usuario()
        {
            Id = Guid.NewGuid();
        }
    }
}
