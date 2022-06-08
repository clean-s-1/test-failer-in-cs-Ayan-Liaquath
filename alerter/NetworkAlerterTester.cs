namespace AlerterSpace
{
    using System.Diagnostics;

    class NetworkAlerterTester
    {
        static void Main()
        {
            var networkAlerter = new NetworkAlerter();

            networkAlerter.AlertNetworkInCelcius(303.6f, SendAlertStub);
            Debug.Assert(networkAlerter.AlertFailureCount == 0);

            networkAlerter.AlertNetworkInCelcius(400.5f, SendAlertStub);
            Debug.Assert(networkAlerter.AlertFailureCount == 1);
        }

        private static int SendAlertStub(float temperatureInCelcius)
        {
            if (temperatureInCelcius > 200)
            {
                return 500;
            }

            return 200;
        }
    }
}
