﻿using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Data.Dtos.GerenteDto
{
    public class ReadGerenteDto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public object Cinemas { get; set; }
    }
}
