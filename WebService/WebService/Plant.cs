using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebService
{
    public class Plant
    {
        int id;
        String genus;
        String species;
        String cultivar;
        String common;

        public int Id { get => id; set => id = value; }
        public string Genus { get => genus; set => genus = value; }
        public string Species { get => species; set => species = value; }
        public string Cultivar { get => cultivar; set => cultivar = value; }
        public string Common { get => common; set => common = value; }
    }
}