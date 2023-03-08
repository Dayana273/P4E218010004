using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace P4E218010004.Models
{
    public class Ubicacion : ContentPage
    {
       
        
            [PrimaryKey, AutoIncrement]
            public int id { get; set; }
            public double latitud { get; set; }
            public double longitud { get; set; }
            [MaxLength(200)]
            public string descripcion { get; set; }
            [MaxLength(200)]
            public string descripcionCorta { get; set; }

        
    }
    }
