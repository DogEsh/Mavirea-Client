using System;

namespace Mavirea.GameInfo
{
    [Serializable]
    public class SimplusHP : ISimplusHP
    {
        private int _cur;
        private int _max;
        private int _bonusCapture;
        public int Cur { get { return _cur; } }
        public int Max { get { return _max; } }

        public SimplusHP(int cur, int max = 100, int bonusCapture = 10)
        {
            _cur = cur;
            _max = max;
            _bonusCapture = bonusCapture;
        }
 
        private void Limit()
        {
            if (_cur > _max)
            {
                _cur = _max;
            }
        }

        public bool Inc(int HP, bool isCapture)
        {
            if(isCapture)
            {
                _cur += HP;
                bool captured = _cur < 0;
                if (captured)
                {
                    _cur *= -1;
                    _cur += _bonusCapture;
                }
                _cur += HP;
                Limit();
                return captured;
            }
            else
            {
                _cur += HP;
                return false;
            }
        }
    }
}
