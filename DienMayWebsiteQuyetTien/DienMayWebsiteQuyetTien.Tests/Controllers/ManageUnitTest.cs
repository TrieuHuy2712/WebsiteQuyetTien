using System;
using DienMayWebsiteQuyetTien.Models;
using DienMayWebsiteQuyetTien.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace DienMayWebsiteQuyetTien.Tests.Controllers
{
    [TestClass]
    public class ManageUnitTest
    {
        [TestMethod]
        public void TestIndex()
        {
            var controller = new ManageController();
            var result = controller.Index() as ViewResult;
            var db = new CS4PEEntities();

            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(result.Model, typeof(List<BangSanPham>));
            Assert.AreEqual(db.BangSanPhams.Count(), ((List<BangSanPham>)result.Model).Count);
        }
    }
}
