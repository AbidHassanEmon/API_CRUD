using CRUD_ANG.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CRUD_ANG.Controllers
{
    public class testController : ApiController
    {
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DB"].ConnectionString);


    [Route("api/test/ALL")]
    [HttpGet]
    public IList<Product> GetProducts()
    {
      SqlDataAdapter s = new SqlDataAdapter("All_Product", con);
      s.SelectCommand.CommandType = CommandType.StoredProcedure;
      DataTable dt = new DataTable();
      s.Fill(dt);

      IList<Product> products = new List<Product>();

      if (dt.Rows.Count > 0)
      {
        for (int i = 0; i < dt.Rows.Count; i++)
        {
          Product p = new Product();
          p.ID = Convert.ToInt32(dt.Rows[i]["ID"]);
          p.Name = dt.Rows[i]["Name"].ToString();
          p.Price = Convert.ToInt32(dt.Rows[i]["Price"]);
          p.Description = dt.Rows[i]["Description"].ToString();
          p.Quantity = Convert.ToInt32(dt.Rows[i]["Quantity"]);
          products.Add(p);
        }
      }

      return products;
    }
  }
}
