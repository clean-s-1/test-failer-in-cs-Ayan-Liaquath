namespace AlerterSpace
{
    using System.Diagnostics;

    class AlerterTester
    {
        static void Main()
        {
            var alerterStub = new AlerterStub();

            alerterStub.alertInCelcius(303.6f);
            Debug.Assert(alerterStub.alertFailureCount == 0);
            alerterStub.alertInCelcius(400.5f);
            Debug.Assert(alerterStub.alertFailureCount == 1);
        }
    }
}
