namespace MobileDevice
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// 1.Define a class that holds information about a mobile phone device: model, manufacturer, price, owner
    /// </summary>
    public class GSM
    {
        //6.Add a static field IPhone4S in the GSM class to hold the information about iPhone 4S.
        static public GSM iPhone4S = new GSM("iPhone4S", "Apple");

        //property IPhone4S in the GSM class to hold the information about iPhone 4S.
        public static GSM IPhone4S
        {
            get { return iPhone4S; }
        }

        private string model;
        private string manufacturer;    
        private decimal price;
        private string owner;

        //instances of the classes Battery and Display
        private Battery battery;
        private Display display;

        //constructors for the defined classes that take different sets of arguments

        public GSM(string phoneModel, string phoneManufacturer)
            : this(phoneModel, phoneManufacturer, null, null, 0, null)
        {

        }

        public GSM(string phoneModel, string phoneManufacturer, Battery phoneBattery, Display phoneDisplay)
            : this(phoneModel, phoneManufacturer, phoneBattery, phoneDisplay, 0, null)
        {

        }

        public GSM(string phoneModel, string phoneManufacturer, Battery phoneBattery, Display phoneDisplay,decimal phonePrice,string phoneOwner)
        {
            this.model = phoneModel;
            this.manufacturer = phoneManufacturer;
            this.battery = phoneBattery;
            this.display = phoneDisplay;
            this.price = phonePrice;
            this.owner = phoneOwner;
        }

        //5.Use properties to encapsulate the data fields inside the GSM, Battery and Display classes.
        //Ensure all fields hold correct data at any given time.
        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                if (value.Length <= 0)
                {
                    throw new ArgumentException("Model cannot be null!");
                }
                this.model = value;
            }
        }

        public string Manufacturer
        {
            get
            {
                return this.manufacturer;
            }
            set
            {
                if (value.Length <= 0)
                    throw new ArgumentOutOfRangeException("Manufacturer cannot be empty!");
                else
                    value = this.manufacturer;
            }
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("The price should be a positive number");
                else
                    value = this.price;
            }
        }

        public string Owner
        {
            get
            {
                return this.owner;
            }
            set
            {
                if (!char.IsUpper(value[0]))
                    throw new ArgumentOutOfRangeException("Names begin with capital letter!");
                else
                    value = this.owner;
            }
        }

        //9.Add a property CallHistory in the GSM class to hold a list of the performed calls. 
        //Try to use the system class List<Call>.
        public List<Call> callHistory = new List<Call>();

        //Add a method in the GSM class for displaying all information about it. Try to override ToString()
        public override string ToString()
        {
            string batteryStr = null;
            if (battery != null)
            {
                batteryStr = string.Format("Battery - model: {0}, type: {1}, idle: {2}h, talk: {3}h",
                battery.Model, battery.BatteryType, battery.HoursIdle, battery.HoursTalk);
            }

            string displayStr = null;
            if (display != null)
            {
                displayStr = string.Format("Display - Width : {0}, Height : {1} , Colors {2}",
                    display.Width, display.Height, display.Colors);
            }

            return string.Format("GSM Model : {0}, Manufacturer : {1} , price : ${2}\n{3}\n{4}",
                this.model, this.manufacturer, this.price, batteryStr, displayStr);
        }

        //10.Add methods in the GSM class for adding and deleting calls from the calls history. 
        //Add a method to clear the call history.
        public void AddCall(Call call)
        {
            this.callHistory.Add(call);
        }

        //remove a call from the call history
        public void DeleteCall(Call call)
        {
            this.callHistory.Remove(call);
        }

        //clear call history
        public void ClearCallHistory()
        {
            this.callHistory.Clear();
        }


        //11.Add a method that calculates the total price of the calls in the call history. 
        //Assume the price per minute is fixed and is provided as a parameter
        public decimal CalculateCallCost(decimal pricePerMinute)
        {
            decimal callTime = 0;
            for (int i = 0; i < this.callHistory.Count; i++)
            {
                callTime = callTime + this.callHistory[i].Duration;
            }
            decimal callCost = pricePerMinute * (callTime / 60);
            return callCost;
        }

        //print call history
        public void ShowCallInfo(List<Call> callHistory)
        {
            for (int i = 0; i < this.callHistory.Count; i++)
            {
                Console.WriteLine(this.callHistory[i].CallDate + " " +
                    this.callHistory[i].DialedNumber + " " + this.callHistory[i].Duration + "s");
            }
        }
    }
}
