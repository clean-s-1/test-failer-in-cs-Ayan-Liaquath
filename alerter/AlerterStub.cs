namespace AlerterSpace
{
    public class AlerterStub : Alerter
    {
        public override int sendAlert(float celcius)
        {
            if (celcius > 200)
            {
                return 500;
            }

            return 200;
        }
    }
}
