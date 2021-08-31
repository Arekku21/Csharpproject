using System;
using SplashKitSDK;

namespace pt78
{   
    /// <summary>
    /// This class is the transaction class for passtask 3. It has fields, construcor, properties and methods. This class is 
    /// is responsible for making a transaction to know its date, transaction no., amount, points and mode. It will also calculate
    /// the points per amount and print different messages per mode.
    /// </summary>
    
    public abstract class Transaction
    {
        
        //fields
        private int _transNo; //transaction number
        private string _date; //transaction date
        private int _amounts; //transaction amount
        private int _points; //transaction points
        private TransactionMode _mode; 
        public enum TransactionMode{ //transaction mode enum
            Online,
            Offline
        }

        //properties
        /// <summary>
        /// Transaction number property it allows the transaction number to be accessed and set the date to a private field.
        /// </summary>
        /// <value></value>
        public  int TransNo{ //transaction number propety
            get{ return _transNo;}
            set{ _transNo = value;}
        }
        /// <summary>
        /// Date property allows the trasaction date to be set and taken from a private field.
        /// </summary>
        /// <value></value>
        public string Date{ //transaction date property
            get{ return _date;}
            set{_date = value;}
        }
        /// <summary>
        /// Amount property allows the transaction amount to be set and taken from a private field.
        /// </summary>
        /// <value></value>
        public int Amounts{// transaction amount property
            get{ return _amounts;}
            set{_amounts = value;}
        }
        /// <summary>
        /// Points property allows the transactions points to be accessed from a private field.
        /// </summary>
        /// <value></value>
        public int Points{ //transaction points property
            get{ return _points;}
            set{_points = value;}
        }
        /// <summary>
        /// TransactionMode property allows the enum values to be accessed and set.
        /// </summary>
        /// <value></value>
        public TransactionMode Mode{
            get{return _mode;}
            set{_mode = value;}
        }

        //constructors
        /// <summary>
        /// This is the construcor to set the values and make new objects from this class with transaction number, date, amount and mode.
        /// </summary>
        /// <param name="transNo"></param>
        /// <param name="date"></param>
        /// <param name="amounts"></param>
        /// <param name="mode"></param>
        public Transaction(int transNo, string date, int amounts, TransactionMode mode){
            _transNo = transNo;
            _date = date;
            _amounts = amounts;
            _mode = mode;
        }

        //methods
        /// <summary>
        /// UpdatePoints is a method thatcalculate the number of points per 10Rm. It will divide the number points by 10 to get the amount of points.
        /// </summary>
        /// <returns>it gives the number of points per 10rm</returns>
        public void UpdatePoints(){
            _points = _amounts/10; //updates the points and gives the bumber of points
        }
        /// <summary>
        /// PrintInfo is the menthod that will check if the transaction method is offline of online and returns a message.
        /// </summary>
        /// <returns>You have secured some points or Thats a wise choice with more rewards.</returns>
        public string PrintInfo(){ //returns online or offline depending on the transaction mode
            if (_mode == TransactionMode.Offline)
            {
                string msg1 = "You have secured some points";
                return msg1;
            }
            else if( _mode == TransactionMode.Online)
            {
                string msg2 = "That's a wise choice with more rewards";
                return msg2;
            }
            else
            {
                return "You fucked up your code";
            }
        }
    }
}