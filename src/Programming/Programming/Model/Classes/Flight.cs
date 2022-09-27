namespace Programming.Model.Classes
{
    /// <summary>
    /// Хранение данные о рейсе.
    /// </summary>
    public class Flight
    {
        /// <summary>
        /// Пункт отправления.
        /// </summary>
        private string _departurePoint;

        /// <summary>
        /// Пункт прибытия.
        /// </summary>
        private string _destinationPoint;

        /// <summary>
        /// Время полёта в минутах. Должно быть положительным числом.
        /// </summary>
        private int _flightTime;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Flight"/>.
        /// </summary>
        public Flight()
        {

        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Flight"/>
        /// </summary>
        /// <param name="departurePoint"> Пункт отправления. </param>
        /// <param name="destinationPoint"> Пункт прибытия. </param>
        /// <param name="flightTime"> Время полёта в минутах. Должно быть положительным числом. </param>
        public Flight(string departurePoint, string destinationPoint, int flightTime)
        {
            DeparturePoint = departurePoint;
            DestinationPoint = destinationPoint;
            FlightTime = flightTime;
        }

        /// <summary>
        /// Возвращает и задаёт место отправления.
        /// </summary>
        public string DeparturePoint { get; set; }

        /// <summary>
        /// Возвращает и задаёт место прибытия.
        /// </summary>
        public string DestinationPoint { get; set; }

        /// <summary>
        /// Возвращает и задаёт время полёта в минутах. Должно быть положительным числом.
        /// </summary>
        public int FlightTime
        {
            get
            {
                return _flightTime;
            }
            set
            {
                Validator.AssertOnPositiveValue(nameof(FlightTime), value);
                _flightTime = value;
            }
        }
    }
}
