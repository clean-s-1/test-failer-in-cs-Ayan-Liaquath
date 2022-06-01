namespace AlerterSpace
{
    using System;

    public class Alerter
    {
        public int alertFailureCount = 0;

        public virtual int sendAlert(float celcius)
        {
            Console.WriteLine("Production code");

            // Return 200 for ok
            // Return 500 for not-ok
            return 200;
        }

        public void alertInCelcius(float farenheit) {
            float celcius = (farenheit - 32) * 5 / 9;
            int returnCode = sendAlert(celcius);
            if (returnCode != 200) {
                // non-ok response is not an error! Issues happen in life!
                // let us keep a count of failures to report
                // However, this code doesn't count failures!
                // Add a test below to catch this bug. Alter the stub above, if needed.
                alertFailureCount += 0;
            }
        }
    }
}
