using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlastiQQAChallenge.TestClient
{
    public class TestClientFactory
    {
        public static ITestClient GetInstance(string clientType)
        {
            ITestClient returnValue = null;

            switch (clientType)
            {
                case "Selenium":
                    returnValue = new SeleniumClient();
                break;
            }
            return returnValue;
        }
    }
}
