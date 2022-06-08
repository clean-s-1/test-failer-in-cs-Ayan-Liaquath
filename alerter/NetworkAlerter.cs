namespace AlerterSpace
{
    using System;

    public class NetworkAlerter
    {
        public int AlertFailureCount = 0;

        public void AlertNetworkInCelcius(float farenheit, Func<float, int> sendAlert)
        {
            float celcius = ConvertFarenheitToCelcius(farenheit);
            int returnCode = sendAlert(celcius);

            if (returnCode != 200)
            {
                AlertFailureCount += 1;
            }
        }

        public float ConvertFarenheitToCelcius(float farenheit)
        {
            return (farenheit - 32) * 5 / 9;
        }
    }
}
