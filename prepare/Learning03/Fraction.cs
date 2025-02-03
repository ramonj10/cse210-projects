class Fraction
    {
        private int _top;
        private int _bottom;


        public Fraction()  // Constructor without parameteres
        {
            _top = 1;
            _bottom = 1;
        }

        public Fraction(int top)  // Constructor with one parameter
        {
            _top = top;
            _bottom = 1;
        }

        public Fraction(int top, int bottom)  // Constructor with two parameteres
        {
            _top = top;
            _bottom = bottom;
        }

        public int GetTop()
        {
            return _top;
        }
        public void SetTop(int top)
        {
            _top = top;
        }

        public int GetBottom()
        {
            return _bottom;
        }

        public void SetBottom(int bottom)
        {
            _bottom = bottom;
        }

        public string GetFractionString()
        {
           string fraction = $"{_top}/{_bottom}";
            return fraction;
        }

        public double GetDecimalValue()
        {
            double decimalValue = (double)_top/(double)_bottom;
            return decimalValue;
        }
    }