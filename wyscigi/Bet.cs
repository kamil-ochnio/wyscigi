namespace wyscigi
{
    public class Bet
    {
        public int Amount;
        public int Dog;
        public Guy Bettor;

        public string GetDescription()
        {
            string label;
            if (Amount == 0)
            {
                label = string.Format("{0} nie zawarł zakładu", Bettor.Name);
            }
            else
            {
                label = string.Format("{0} postawił {1} zł na psa numer {2}", Bettor.Name, Amount, Dog+1);

            }
            return label;
        }

        public int PayOut(int Winner)
        {
            return 0;//TODO: parametrem jest zwyciezca wyscigu, jeli wygrał zwróc wartosć postawioną jeśli przegrał ze znakiem minus
        }
    }
}