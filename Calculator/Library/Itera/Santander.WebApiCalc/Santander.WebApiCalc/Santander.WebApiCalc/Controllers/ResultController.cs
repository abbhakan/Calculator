using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using Santander.WebApiCalc.Models;

namespace Santander.WebApiCalc.Controllers
{
    public class ResultController : ApiController
    {
        private IResultManager _resultManager;
        public ResultController()
        {
            this._resultManager = new ResultManager();
        }       
                       
        [System.Web.Http.HttpGet]
        public ResultModel Execute(double numA, double numB, string mathOp)
        {            
            var model = _resultManager.Execute(numA, numB, mathOp);
            return model;
        }

    }
}
