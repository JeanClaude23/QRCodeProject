using QRCoder;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QRCodeChallenge.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode("http://fnactvs.com/index.html?SystemDeviceID=WZVORA", QRCodeGenerator.ECCLevel.Q);
            QRCoder.QRCode qrCode = new QRCoder.QRCode(qrCodeData);
            Bitmap qrCodeImage = qrCode.GetGraphic(20);

            return View();
        }
    }
}