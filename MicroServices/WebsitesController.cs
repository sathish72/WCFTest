using System;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Cors;

namespace MicroServices
{
    public class Website
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }

    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class WebsitesController: ApiController
    {
        Website[] websites = new Website[]
        {
            new Website {Id = 1, Name = "BirdMMO.com", Description = "Bird flapping game for everybody" },
            new Website {Id = 2, Name ="SpiderMMO.com", Description = "Spider versus spider death match" },
            new Website {Id = 3, Name ="LiveAutoWheel.com", Description = "Random number generator" },
            new Website {Id = 4, Name ="SeanWasEre.com", Description = "A Blog of Trivial Things" }
        };


        public IEnumerable<Website> Get()
        {
            return websites;
        }

        public Website Get(int id)
        {
            try
            {
                return websites[id];
            }
            catch(Exception e1)
            {
                return new Website();
            }
        }

        public void Post([FromBody]string value)
        {
            Console.WriteLine("Post method called with value = " + value);
        }

        public void Post(int id, [FromBody]string value)
        {
            Console.WriteLine("Post method called with value = " + value);
        }

    }
}
