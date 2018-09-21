

namespace Module1
{
    public class AutoPilot
    {
        private readonly Airplane _airplane;
        private readonly SqlLogger _logger;

        public AutoPilot()
        {
            _airplane = new Airplane();
            _logger = new SqlLogger();
        }

        public void TakeOff()
        {
            _airplane.RunSystemCheck();

            _logger.Log("System OK");

            _airplane.SetFlaps(100);

            _airplane.SetThrust(100);

            if (_airplane.Speed == 400)
            {
                _airplane.SetPitch(35);
            }
        }
    }
}
