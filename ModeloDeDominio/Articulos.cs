﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.ComponentModel;

namespace ModeloDeDominio
{
    public class Articulos
    {

        public int Id { get; set; }
        [DisplayName("Código")]
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        [DisplayName("Descripción")]
        public string Descripcion { get; set; }

        public string ImagenUrl { get; set; }
        public decimal Precio { get; set; }
        [DisplayName("Id Marca")]
        public int IdMarca { get; set; }
        [DisplayName("Id Categoria")]
        public int IdCategoria { get; set; }
        public Categorias Categoria { get; set; }

      
        public Marcas Marca { get; set; }
    }
}
