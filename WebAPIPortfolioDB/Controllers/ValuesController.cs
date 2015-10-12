using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Reflection;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.UI.WebControls;
using System.Xml;
using System.Xml.Linq;
using WebAPIPortfolioDB.Models.Entities;
using ClienteRepository = WebAPIPortfolioDB.Data.Repositories.ClienteRepository;

namespace WebAPIPortfolioDB.Controllers
{
    [EnableCors(origins: "http://localhost:3821", headers: "*", methods: "*")]
    public class ValuesController : ApiController
    {
        ClienteRepository clienteRepository = new ClienteRepository();
        // GET api/values
        public List<Cliente> Get()
        {
            var l = clienteRepository.Listar();

            return (List<Cliente>) l;
        }

        // GET api/values/5
        public Cliente Get(int id)
        {
            return clienteRepository.Buscar(id);
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
