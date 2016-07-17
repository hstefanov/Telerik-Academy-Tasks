namespace MobileDevice
{
    using System;

    /// <summary>
    /// 3.Add an enumeration BatteryType (Li-Ion, NiMH, NiCd, …) and use it as a new field for the batteries.
    /// </summary>

    //Enumeration
    public enum BatteryType
    {
        Null,
        LiPol, 
        LiIon, 
        NiMH, 
        NiCd 
    }

    public class Battery
    {
        private string model;
        private int hoursIdle;
        private int hoursTalk;
        private BatteryType batteryType;

        //default constructor
        public Battery()
            : this(null, 0, 0, BatteryType.Null)
        {
        }

        //constructor with parameters
        public Battery(string batteryModel,int batteryIdle,int batteryTalk,BatteryType typeBattery)
        {
            this.model = batteryModel;
            this.hoursIdle = batteryIdle;
            this.hoursTalk = batteryTalk;
            this.batteryType = typeBattery;
        }

        /// <summary>
        ///5.Use properties to encapsulate the data fields inside the GSM, Battery and Display classes. 
        ///Ensure all fields hold correct data at any given time.
        /// </summary>
        
        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                if (value.Length < 6)
                {
                    throw new ArgumentException("The model should be at least 6 signs");
                }
                this.model = value;
            }
        }

        public int HoursIdle
        {
            get
            {
                return this.hoursIdle;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Idle hours cannot be negative number!");
                }
                this.hoursIdle = value;
            }
        }

        public int HoursTalk
        {
            get
            {
                return this.hoursTalk;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Talked hours cannot be negative number!");
                }
                this.hoursTalk = value;
            }
        }

        public BatteryType BatteryType
        {
            get
            {
                return this.batteryType;
            }
            set
            {
                if (value != BatteryType.LiIon || value != BatteryType.LiPol ||
                    value != BatteryType.NiCd || value != BatteryType.NiMH || value != BatteryType.Null)
                {
                    throw new ArgumentException("The type should be LiPol, LiIon, NiMH or NiCd");
                }
                this.batteryType = value;
            }
        }
    }
}
