/*7.Write a class GSMTest to test the GSM class:
Create an array of few instances of the GSM class.
Display the information about the GSMs in the array.
Display the information about the static property IPhone4S.
12.Write a class GSMCallHistoryTest to test the call history functionality of the GSM class.
Create an instance of the GSM class.
Add few calls.
Display the information about the calls.
Assuming that the price per minute is 0.37 calculate and print the total price of the calls in the history.
Remove the longest call from the history and calculate the total price again.
Finally clear the call history and print it.*/

namespace MobileDevice
{
    using System;
    using System.Collections.Generic;

    public class GSMTest
    {
        public static void Main()
        {
            List<GSM> phones = new List<GSM>();
            Battery phoneBattery = new Battery("2200mAh", 10, 100, BatteryType.LiIon);
            Display phoneDisplay = new Display(112, 54, 650000);

            phones.Add(GSM.iPhone4S);
            phones.Add(new GSM("Experia U", "Sony"));
            phones.Add(new GSM("N95", "Nokia", phoneBattery, phoneDisplay));
            phones.Add(new GSM("N8", "Nokia", phoneBattery, phoneDisplay, 600m, "Me"));

            foreach (var phone in phones)
            {
                Console.WriteLine(phone);
                Console.WriteLine(new string('-',60));
            }

            //12.Write a class GSMCallHistoryTest to test the call history functionality of the GSM class.         
            //Create an instance of the GSM class.
            GSM testGSM = GSM.iPhone4S;
            Call firstCall = new Call(new DateTime(2014,02, 05, 20, 20, 26), "+359111222333", 20);
            Call secondCall = new Call(new DateTime(2014, 02, 06, 07, 05, 26), "+359222333444", 10);
            Call thirdCall = new Call(new DateTime(2014, 02, 06, 09, 10, 26), "+359333444555", 60);

            //Add few calls.
            testGSM.AddCall(firstCall);
            testGSM.AddCall(secondCall);
            testGSM.AddCall(thirdCall);

            //Display the information about the calls.
            Console.WriteLine("Call History : ");
            testGSM.ShowCallInfo(testGSM.callHistory);

            //Assuming that the price per minute is 0.37 calculate and print the total price of the calls in the history.
            decimal callCost = testGSM.CalculateCallCost(0.37m);
            Console.WriteLine("Cost of the call in the CallHistory : {0}",callCost);

            //Remove the longest call from the history and calculate the total price again.
            testGSM.DeleteCall(thirdCall);

            decimal callCostAfterDelete = testGSM.CalculateCallCost(0.37m);
            Console.WriteLine("Cost of the call after delete in the CallHistory : {0}", callCostAfterDelete);

            //Clear Call Histroy
            testGSM.ClearCallHistory();

            //Print History
            testGSM.ShowCallInfo(testGSM.callHistory);
        }
    }
}
