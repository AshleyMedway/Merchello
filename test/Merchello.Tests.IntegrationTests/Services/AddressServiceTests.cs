﻿using Merchello.Core.Services;
using Merchello.Tests.Base.SqlSyntax;
using NUnit.Framework;

namespace Merchello.Tests.IntegrationTests.Services
{
    [TestFixture]
    [Category("Service Integration")]
    public class AddressServiceTests : ServiceIntegrationTestBase
    {

        //[Test]
        //public void Can_Create_New_Address()
        //{
            
        //}

        [Test]
        public void CacheDebug()
        {

            var service = new AddressService();

            var address = service.GetById(0);

            var addresses = service.GetAll();


        }


    }
}
