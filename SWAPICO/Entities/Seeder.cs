using System.Linq;
using System.Threading.Tasks;

namespace SWAPICO.Entities
{
    public class Seeder
    {
        public static void SeedData(AppDbContext context)
        {
            #region tblPlanets - Планети
            SeedPlanet(context, new DbPlanet
            {
                Name = "Tatooine",
                RotationPeriod = "23",
                OrbitalPeriod = "304",
                Diameter = "10465",
                Climate = "arid",
                Gravity = "1 standard",
                Terrain = "desert",
                SurfaceWater = "1",
                Population = "200000",
                URL = "http://localhost:57299/api/planets/1/"
            });

            SeedPlanet(context, new DbPlanet
            {
                Name = "Alderaan",
                RotationPeriod = "24",
                OrbitalPeriod = "364",
                Diameter = "12500",
                Climate = "temperate",
                Gravity = "1 standard",
                Terrain = "grasslands, mountains",
                SurfaceWater = "40",
                Population = "2000000000",
                URL = "http://localhost:57299/api/planets/2/"
            });

            SeedPlanet(context, new DbPlanet
            {
                Name = "Yavin IV",
                RotationPeriod = "24",
                OrbitalPeriod = "4818",
                Diameter = "10200",
                Climate = "temperate, tropical",
                Gravity = "1 standard",
                Terrain = "jumgle, rainforests",
                SurfaceWater = "8",
                Population = "1000",
                URL = "http://localhost:57299/api/planets/3/"
            });

            SeedPlanet(context, new DbPlanet
            {
                Name = "Hoth",
                RotationPeriod = "23",
                OrbitalPeriod = "549",
                Diameter = "7200",
                Climate = "frozen",
                Gravity = "11",
                Terrain = "tundra, ice caves, mountain ranges",
                SurfaceWater = "100",
                Population = "unknown",
                URL = "http://localhost:57299/api/planets/4/"
            });

            SeedPlanet(context, new DbPlanet
            {
                Name = "Dagobah",
                RotationPeriod = "23",
                OrbitalPeriod = "341",
                Diameter = "8900",
                Climate = "murky",
                Gravity = "n/a",
                Terrain = "swamp, jungles",
                SurfaceWater = "8",
                Population = "unknown",
                URL = "http://localhost:57299/api/planets/5/"
            });

            SeedPlanet(context, new DbPlanet
            {
                Name = "Bespin",
                RotationPeriod = "12",
                OrbitalPeriod = "5110",
                Diameter = "118000",
                Climate = "temperate",
                Gravity = "1.5 (surface), 1 standard (cloud city)",
                Terrain = "gas giant",
                SurfaceWater = "0",
                Population = "6000000",
                URL = "http://localhost:57299/api/planets/6/"
            });

            SeedPlanet(context, new DbPlanet
            {
                Name = "Endor",
                RotationPeriod = "18",
                OrbitalPeriod = "402",
                Diameter = "4900",
                Climate = "temperate",
                Gravity = "0.85 standart",
                Terrain = "forests, mountains, lakes",
                SurfaceWater = "8",
                Population = "30000000",
                URL = "http://localhost:57299/api/planets/7/"
            });

            SeedPlanet(context, new DbPlanet
            {
                Name = "Naboo",
                RotationPeriod = "26",
                OrbitalPeriod = "312",
                Diameter = "12120",
                Climate = "temperate",
                Gravity = "1 standart",
                Terrain = "grassy hills, swamps, forests, mountains",
                SurfaceWater = "12",
                Population = "45000000000",
                URL = "http://localhost:57299/api/planets/8/"
            });

            SeedPlanet(context, new DbPlanet
            {
                Name = "Coruscant",
                RotationPeriod = "24",
                OrbitalPeriod = "368",
                Diameter = "12240",
                Climate = "temperate",
                Gravity = "1 standart",
                Terrain = "cityscape, mountains",
                SurfaceWater = "unknown",
                Population = "1000000000000",
                URL = "http://localhost:57299/api/planets/9/"
            });

            SeedPlanet(context, new DbPlanet
            {
                Name = "Kamino",
                RotationPeriod = "27",
                OrbitalPeriod = "463",
                Diameter = "19720",
                Climate = "temperate",
                Gravity = "1 standart",
                Terrain = "ocean",
                SurfaceWater = "100",
                Population = "1000000000",
                URL = "http://localhost:57299/api/planets/10/"
            });

            SeedPlanet(context, new DbPlanet
            {
                Name = "Geonosis",
                RotationPeriod = "30",
                OrbitalPeriod = "256",
                Diameter = "11370",
                Climate = "temperate, arid",
                Gravity = "0.9 standart",
                Terrain = "rock, desert, mountain, barren",
                SurfaceWater = "5",
                Population = "100000000000",
                URL = "http://localhost:57299/api/planets/11/"
            });

            SeedPlanet(context, new DbPlanet
            {
                Name = "Utapau",
                RotationPeriod = "27",
                OrbitalPeriod = "351",
                Diameter = "12900",
                Climate = "temperate, arid, windy",
                Gravity = "1 standart",
                Terrain = "scrublands, savanna, canyons, sinkholes",
                SurfaceWater = "0.9",
                Population = "95000000",
                URL = "http://localhost:57299/api/planets/12/"
            });

            SeedPlanet(context, new DbPlanet
            {
                Name = "Mustafar",
                RotationPeriod = "36",
                OrbitalPeriod = "412",
                Diameter = "4200",
                Climate = "hot",
                Gravity = "1 standart",
                Terrain = "volcanoes, lava rivers, mountains, caves",
                SurfaceWater = "0",
                Population = "20000",
                URL = "http://localhost:57299/api/planets/13/"
            });

            SeedPlanet(context, new DbPlanet
            {
                Name = "Kashyyyk",
                RotationPeriod = "26",
                OrbitalPeriod = "381",
                Diameter = "12765",
                Climate = "tropical",
                Gravity = "1 standart",
                Terrain = "jungle, forests, lakes, rivers",
                SurfaceWater = "60",
                Population = "45000000",
                URL = "http://localhost:57299/api/planets/14/"
            });

            SeedPlanet(context, new DbPlanet
            {
                Name = "Polis Massa",
                RotationPeriod = "24",
                OrbitalPeriod = "590",
                Diameter = "0",
                Climate = "artificial temperate",
                Gravity = "0.56 standart",
                Terrain = "airless asteroid",
                SurfaceWater = "0",
                Population = "1000000",
                URL = "http://localhost:57299/api/planets/15/"
            });

            SeedPlanet(context, new DbPlanet
            {
                Name = "Mygeeto",
                RotationPeriod = "12",
                OrbitalPeriod = "167",
                Diameter = "10088",
                Climate = "frigid",
                Gravity = "1 standart",
                Terrain = "glaciers, mountains, ice canyons",
                SurfaceWater = "unknown",
                Population = "19000000",
                URL = "http://localhost:57299/api/planets/16/"
            });

            SeedPlanet(context, new DbPlanet
            {
                Name = "Felucia",
                RotationPeriod = "34",
                OrbitalPeriod = "231",
                Diameter = "9100",
                Climate = "hot, humid",
                Gravity = "0.75 standard",
                Terrain = "fungus forests",
                SurfaceWater = "unknown",
                Population = "8500000",
                URL = "http://localhost:57299/api/planets/17/"
            });

            SeedPlanet(context, new DbPlanet
            {
                Name = "Cato Neimoidia",
                RotationPeriod = "25",
                OrbitalPeriod = "278",
                Diameter = "0",
                Climate = "temperate, moist",
                Gravity = "1 standard",
                Terrain = "mountains, fields, forests, rock arches",
                SurfaceWater = "unknown",
                Population = "10000000",
                URL = "http://localhost:57299/api/planets/18/"
            });

            SeedPlanet(context, new DbPlanet
            {
                Name = "Saleucami",
                RotationPeriod = "26",
                OrbitalPeriod = "392",
                Diameter = "14920",
                Climate = "hot",
                Gravity = "unknown",
                Terrain = "caves, desert, mountains, volcanoes",
                SurfaceWater = "unknown",
                Population = "1400000000",
                URL = "http://localhost:57299/api/planets/19/"
            });

            SeedPlanet(context, new DbPlanet
            {
                Name = "Stewjon",
                RotationPeriod = "unknown",
                OrbitalPeriod = "unknown",
                Diameter = "0",
                Climate = "temperate",
                Gravity = "1 standard",
                Terrain = "grass",
                SurfaceWater = "unknown",
                Population = "unknown",
                URL = "http://localhost:57299/api/planets/20/"
            });
            #endregion

            #region tblPeople - Персонажі
            SeedPerson(context, new DbPerson
            {
                Name = "Luke Skywalker",
                Height = "172",
                Mass = "77",
                HairColor = "blond",
                SkinColor = "fair",
                EyeColor = "blue",
                BirthYear = "19BBY",
                Gender = "male",
                Homeworld = "http://localhost:57299/api/planets/1/",
                URL = "http://localhost:57299/api/people/1/"
            });

            SeedPerson(context, new DbPerson
            {
                Name = "C-3PO",
                Height = "167",
                Mass = "75",
                HairColor = "n/a",
                SkinColor = "gold",
                EyeColor = "yellow",
                BirthYear = "112BBY",
                Gender = "n/a",
                Homeworld = "http://localhost:57299/api/planets/1/",
                URL = "http://localhost:57299/api/people/2/"
            });

            SeedPerson(context, new DbPerson
            {
                Name = "R2-D2",
                Height = "96",
                Mass = "32",
                HairColor = "n/a",
                SkinColor = "white, blue",
                EyeColor = "red",
                BirthYear = "33BBY",
                Gender = "n/a",
                Homeworld = "http://localhost:57299/api/planets/8/",
                URL = "http://localhost:57299/api/people/3/"
            });

            SeedPerson(context, new DbPerson
            {
                Name = "Darth Vader",
                Height = "202",
                Mass = "136",
                HairColor = "none",
                SkinColor = "white",
                EyeColor = "yellow",
                BirthYear = "41.9BBY",
                Gender = "male",
                Homeworld = "http://localhost:57299/api/planets/1/",
                URL = "http://localhost:57299/api/people/4/"
            });

            SeedPerson(context, new DbPerson
            {
                Name = "Leia Organa",
                Height = "150",
                Mass = "49",
                HairColor = "brown",
                SkinColor = "light",
                EyeColor = "brown",
                BirthYear = "19BBY",
                Gender = "female",
                Homeworld = "http://localhost:57299/api/planets/2/",
                URL = "http://localhost:57299/api/people/5/"
            });

            SeedPerson(context, new DbPerson
            {
                Name = "Owen Lars",
                Height = "178",
                Mass = "120",
                HairColor = "brown, grey",
                SkinColor = "light",
                EyeColor = "blue",
                BirthYear = "52BBY",
                Gender = "male",
                Homeworld = "http://localhost:57299/api/planets/1/",
                URL = "http://localhost:57299/api/people/6/"
            });

            SeedPerson(context, new DbPerson
            {
                Name = "Beru Whitesun lars",
                Height = "165",
                Mass = "75",
                HairColor = "brown",
                SkinColor = "light",
                EyeColor = "blue",
                BirthYear = "47BBY",
                Gender = "female",
                Homeworld = "http://localhost:57299/api/planets/1/",
                URL = "http://localhost:57299/api/people/7/"
            });

            SeedPerson(context, new DbPerson
            {
                Name = "R5-D4",
                Height = "97",
                Mass = "32",
                HairColor = "n/a",
                SkinColor = "white, red",
                EyeColor = "red",
                BirthYear = "unknown",
                Gender = "n/a",
                Homeworld = "http://localhost:57299/api/planets/1/",
                URL = "http://localhost:57299/api/people/8/"
            });

            SeedPerson(context, new DbPerson
            {
                Name = "Biggs Darklighter",
                Height = "183",
                Mass = "84",
                HairColor = "black",
                SkinColor = "light",
                EyeColor = "brown",
                BirthYear = "24BBY",
                Gender = "male",
                Homeworld = "http://localhost:57299/api/planets/1/",
                URL = "http://localhost:57299/api/people/9/"
            });

            SeedPerson(context, new DbPerson
            {
                Name = "Obi-Wan Kenobi",
                Height = "182",
                Mass = "77",
                HairColor = "auburn, white",
                SkinColor = "fair",
                EyeColor = "blue-gray",
                BirthYear = "57BBY",
                Gender = "male",
                Homeworld = "http://localhost:57299/api/planets/20/",
                URL = "http://localhost:57299/api/people/10/"
            });

            SeedPerson(context, new DbPerson
            {
                Name = "Anakin Skywalker",
                Height = "188",
                Mass = "84",
                HairColor = "blond",
                SkinColor = "fair",
                EyeColor = "blue",
                BirthYear = "41.9BBY",
                Gender = "male",
                Homeworld = "http://localhost:57299/api/planets/1/",
                URL = "http://localhost:57299/api/people/11/"
            });

            SeedPerson(context, new DbPerson
            {
                Name = "Wilhuff Tarkin",
                Height = "180",
                Mass = "unknown",
                HairColor = "auburn, grey",
                SkinColor = "fair",
                EyeColor = "blue",
                BirthYear = "64BBY",
                Gender = "male",
                Homeworld = "http://localhost:57299/api/planets/21/",
                URL = "http://localhost:57299/api/people/12/"
            });

            SeedPerson(context, new DbPerson
            {
                Name = "Chewbacca",
                Height = "228",
                Mass = "112",
                HairColor = "brown",
                SkinColor = "unknown",
                EyeColor = "blue",
                BirthYear = "200BBY",
                Gender = "male",
                Homeworld = "http://localhost:57299/api/planets/14/",
                URL = "http://localhost:57299/api/people/13/"
            });

            SeedPerson(context, new DbPerson
            {
                Name = "Han Solo",
                Height = "180",
                Mass = "80",
                HairColor = "brown",
                SkinColor = "fair",
                EyeColor = "brown",
                BirthYear = "29BBY",
                Gender = "male",
                Homeworld = "http://localhost:57299/api/planets/22/",
                URL = "http://localhost:57299/api/people/14/"
            });

            SeedPerson(context, new DbPerson
            {
                Name = "Greedo",
                Height = "173",
                Mass = "74",
                HairColor = "n/a",
                SkinColor = "green",
                EyeColor = "black",
                BirthYear = "44BBY",
                Gender = "male",
                Homeworld = "http://localhost:57299/api/planets/23/",
                URL = "http://localhost:57299/api/people/15/"
            });

            SeedPerson(context, new DbPerson
            {
                Name = "Jabba Desilijic Tiure",
                Height = "175",
                Mass = "1,358",
                HairColor = "n/a",
                SkinColor = "green-tan, brown",
                EyeColor = "orange",
                BirthYear = "600BBY",
                Gender = "hermaphrodite",
                Homeworld = "http://localhost:57299/api/planets/24/",
                URL = "http://localhost:57299/api/people/16/"
            });

            SeedPerson(context, new DbPerson
            {
                Name = "Wedge Antilles",
                Height = "170",
                Mass = "77",
                HairColor = "brown",
                SkinColor = "fair",
                EyeColor = "hazel",
                BirthYear = "21BBY",
                Gender = "male",
                Homeworld = "http://localhost:57299/api/planets/22/",
                URL = "http://localhost:57299/api/people/18/"
            });

            SeedPerson(context, new DbPerson
            {
                Name = "Jek Tono Porkins",
                Height = "180",
                Mass = "110",
                HairColor = "brown",
                SkinColor = "fair",
                EyeColor = "blue",
                BirthYear = "unknown",
                Gender = "male",
                Homeworld = "http://localhost:57299/api/planets/26/",
                URL = "http://localhost:57299/api/people/19/"
            });

            SeedPerson(context, new DbPerson
            {
                Name = "Yoda",
                Height = "66",
                Mass = "17",
                HairColor = "white",
                SkinColor = "green",
                EyeColor = "brown",
                BirthYear = "896BBY",
                Gender = "male",
                Homeworld = "http://localhost:57299/api/planets/28/",
                URL = "http://localhost:57299/api/people/20/"
            });
            #endregion

            #region tblStarships - Кораблі
            SeedStarship(context, new DbStarship
            {
                Name = "CR90 corvette",
                Model = "CR90 corvette",
                Manufacturer = "Corellian Engineering Corporation",
                CostInCredits = "3500000",
                Length = "150",
                MaxAtmospheringSpeed = "950",
                Crew = "30-165",
                Passengers = "600",
                URL = "http://localhost:57299/api/starships/2/"
            });

            SeedStarship(context, new DbStarship
            {
               Name = "Star Destroyer",
               Model = "Imperial I-class Star Destroyer",
               Manufacturer = "Kuat Drive Yards",
               CostInCredits = "150000000",
               Length = "1,600",
               MaxAtmospheringSpeed = "975",
               Crew = "30-165",
               Passengers = "n/a",
               URL = "http://localhost:57299/api/starships/3/"
            });

            SeedStarship(context, new DbStarship
            {
                Name = "Sentinel-class landing craft",
                Model = "Sentinel-class landing craft",
                Manufacturer = "Sienar Fleet Systems, Cyngus Spaceworks",
                CostInCredits = "240000",
                Length = "38",
                MaxAtmospheringSpeed = "1000",
                Crew = "5",
                Passengers = "75",
                URL = "http://localhost:57299/api/starships/5/"
            });

            SeedStarship(context, new DbStarship
            {
                Name = "Death Star",
                Model = "DS-1 Orbital Battle Station",
                Manufacturer = "Imperial Department of Military Research, Sienar Fleet Systems",
                CostInCredits = "1000000000000",
                Length = "120000",
                MaxAtmospheringSpeed = "n/a",
                Crew = "342,953",
                Passengers = "843,342",
                URL = "http://localhost:57299/api/starships/9/"
            });

            SeedStarship(context, new DbStarship
            {
                Name = "Millennium Falcon",
                Model = "YT-1300 light freighter",
                Manufacturer = "Corellian Engineering Corporation",
                CostInCredits = "100000",
                Length = "34.37",
                MaxAtmospheringSpeed = "1050",
                Crew = "4",
                Passengers = "6",
                URL = "http://localhost:57299/api/starships/10/"
            });
            #endregion
        }

        public static void SeedPlanet(AppDbContext context, DbPlanet model)
        {
            var planet = context.Planets.SingleOrDefault(t => t.Name == model.Name);
            if (planet == null)
            {
                planet = new DbPlanet
                {
                    Name = model.Name,
                    RotationPeriod = model.RotationPeriod,
                    OrbitalPeriod = model.OrbitalPeriod,
                    Diameter = model.Diameter,
                    Climate = model.Climate,
                    Gravity = model.Gravity,
                    Terrain = model.Terrain,
                    SurfaceWater = model.SurfaceWater,
                    Population = model.Population,
                    URL = model.URL
                };
                context.Planets.Add(planet);
                context.SaveChanges();
            }
        }

        public static void SeedPerson(AppDbContext context, DbPerson model)
        {
            var person = context.People.SingleOrDefault(t => t.Name == model.Name);
            if (person == null)
            {
                person = new DbPerson
                {
                    Name = model.Name,
                    Height = model.Height,
                    Mass = model.Mass,
                    HairColor = model.HairColor,
                    SkinColor = model.SkinColor,
                    EyeColor = model.EyeColor,
                    BirthYear = model.BirthYear,
                    Gender = model.Gender,
                    Homeworld = model.Homeworld,
                    URL = model.URL
                };
                context.People.Add(person);
                context.SaveChanges();
            }
        }

        public static void SeedStarship(AppDbContext context, DbStarship model)
        {
            var starship = context.Starships.SingleOrDefault(t => t.Name == model.Name);
            if (starship == null)
            {
                starship = new DbStarship
                {
                    Name = model.Name,
                    Model = model.Model,
                    Manufacturer = model.Manufacturer,
                    CostInCredits = model.CostInCredits,
                    Length = model.Length,
                    MaxAtmospheringSpeed = model.MaxAtmospheringSpeed,
                    Crew = model.Crew,
                    Passengers = model.Passengers,
                    URL = model.URL
                };
                context.Starships.Add(starship);
                context.SaveChanges();
            }
            }
        }
}
