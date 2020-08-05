using city.Model;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace city
{
    public class Baza
    {

        public static Baza current = new Baza();

        public List<CityOde> City { get; set; }
        public List<CityInfo> CityInfo { get; set; }
        public Baza()
        {
            City = new List<CityOde>()
            {

                new CityOde()
                {
                    id = 1,
                    name = "dupa",

                    CityInfo = new List<CityInfo>()
                    {
                        new CityInfo()
                        {

                            id = 1,
                            name = "dupa1"
                        },
                        new CityInfo()
                        {
                            id = 2,
                            name = "dupa2"
                        },
                        new CityInfo()
                        {
                            id = 3,
                            name = "dupa3"
                        }
                    }
                },

                new CityOde()
                {
                    id = 2,
                    name = "dupadupa",
                    CityInfo = new List<CityInfo>()
                    {
                        new CityInfo()
                        {
                            id = 1,
                            name = "dupadupa1"
                        },
                        new CityInfo()
                        {
                            id = 2,
                            name = "dupadupa2"
                        },
                        new CityInfo()
                        {
                            id = 3,
                            name = "dupadupa3"
                        }
                    }
                },

                new CityOde()
                {
                    id = 3,
                    name = "dupadupadupa",
                    CityInfo = new List<CityInfo>()
                    {
                        new CityInfo()
                        {
                            id = 1,
                            name = "dupadupadupa1"
                        },
                        new CityInfo()
                        {
                            id = 2,
                            name = "dupadupadupa2"
                        },
                        new CityInfo()
                        {
                            id = 3,
                            name = "dupadupadupa3"
                        }
                    }
                }
            };


        }
    }
}
