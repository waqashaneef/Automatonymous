// Copyright 2011-2015 Chris Patterson, Dru Sellers
// 
// Licensed under the Apache License, Version 2.0 (the "License"); you may not use 
// this file except in compliance with the License. You may obtain a copy of the 
// License at 
// 
//     http://www.apache.org/licenses/LICENSE-2.0 
// 
// Unless required by applicable law or agreed to in writing, software distributed 
// under the License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR 
// CONDITIONS OF ANY KIND, either express or implied. See the License for the 
// specific language governing permissions and limitations under the License.
namespace Automatonymous.NHibernateIntegration.Tests
{
    using System;
    using System.Diagnostics;
    using System.IO;
    using log4net;
    using log4net.Config;
    using NUnit.Framework;


    [SetUpFixture]
    public class ContextSetup
    {
        [SetUp]
        public void Before_any()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory;

            string file = Path.Combine(path, "tests.log4net.xml");

            XmlConfigurator.Configure(new FileInfo(file));

            Trace.WriteLine("Loading Log4net: " + file);
        }

        [TearDown]
        public void After_all()
        {
            LogManager.Shutdown();
        }
    }
}