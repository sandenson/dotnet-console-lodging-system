namespace LodgingProjectChallenge.Models
{
    public class Reservation
    {
        public List<Person> Guests { get; set; }
        public Suite Suite { get; set; }
        public int ReservedDays { get; set; }

        public Reservation() { }

        public Reservation(int reservedDays)
        {
            ReservedDays = reservedDays;
        }

        public void RegisterGuests(List<Person> guests)
        {
            if (guests.Count <= Suite.Capacity)
            {
                Guests = guests;
            }
            else
            {
                throw new ArgumentException(
                    $"It's not possible to reserve this suite for {guests.Count} guests, "
                    + $"as the suite can only accommodate a maximum of {Suite.Capacity} guests."
                );
            }
        }

        public void RegisterSuite(Suite suite)
        {
            Suite = suite;
        }

        public int GetGuestsCount()
        {
            return Guests.Count;
        }

        public decimal CalculateFinalRate()
        {
            decimal rate = ReservedDays * Suite.DailyRate;

            if (ReservedDays >= 10)
            {
                return rate * 0.9M;
            }

            return rate;
        }
    }
}