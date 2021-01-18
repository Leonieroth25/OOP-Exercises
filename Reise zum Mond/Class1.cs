public class Berechnung { 

    public Berechnung()
	{
            private int _result = 0;

        public int Result
        {
            get
            {
                return _result;
            }
    
            private set
            {
                _result = value;
            }
        }

        public void Eingabe(int eingabe)
        {
            _result = 384400/eingabe;
        }
    }
}