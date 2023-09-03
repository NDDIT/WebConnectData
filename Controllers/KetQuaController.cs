using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ConnectToData.Models;

namespace ConnectToData.Controllers
{
    public class KetQuaController : Controller
    {
        // GET: KetQua
        DataClasses1DataContext data = new DataClasses1DataContext("Data Source=MSI;Initial Catalog=QL_Sinh_Vien1;Integrated Security=True");
        public ActionResult Index()
        {
            var All_KetQua = from tt in data.KETQUAs select tt;
            return View(All_KetQua);
        }
    }
}