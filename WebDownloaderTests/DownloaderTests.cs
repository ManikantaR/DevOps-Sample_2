using Microsoft.VisualStudio.TestTools.UnitTesting;
using DevOps_Sample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDownloader.Tests
{
    [TestClass()]
    public class DownloaderTests
    {
        private WebDowloader downloader;

        [TestMethod()]
        public void GetModels()
        {
            downloader = new WebDowloader();
            var models = downloader.GetModels();

            Assert.IsTrue(models.Count== 1);

            //Assert.Fail();
        }
    }
}