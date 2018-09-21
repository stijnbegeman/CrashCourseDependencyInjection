using System;

namespace Module1
{
    public class Airplane
    {

        public Wing LeftWing { get; private set; }

        public Wing RightWing { get; private set; }

        public int Speed { get; internal set; }

        public Airplane()
        {

        }

        public void HardwareCheck()
        {

        }

        public void RunSystemCheck()
        {
            throw new NotImplementedException();
        }

        public void SetFlapsInStartingPosition()
        {
            throw new NotImplementedException();
        }

        public void SetThrust(int thrustVector)
        {
            throw new NotImplementedException();
        }

        public void SetPitch(int pitch)
        {
            throw new NotImplementedException();
        }

        public void SetFlaps(int flaps)
        {
            throw new NotImplementedException();
        }
    }
}
