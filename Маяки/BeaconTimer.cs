namespace Маяки
{
    public class BeaconTimer
    {
        public int Duration { get; set; }
        public bool IsChanged { get; private set; } = false;

        private int _secondCount = 0;

        public BeaconTimer( int duration ) => Duration=duration;

        public bool CheckAndCountForChanged()
        {
            _secondCount++;

            if( _secondCount < Duration )
            {
                IsChanged = false;
                return false;
            }

            IsChanged = true;
            _secondCount = 0;
            return true;
        }
    }
}
