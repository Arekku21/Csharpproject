using System;
using System.Collections.Generic;

namespace pt78
{
    /// <summary>
    /// UserProfile is a class that is needed to make user profiles for IDs, Names, Contact NOs., Year, Status and transanctions for each user. 
    /// </summary>
    class UserProfile
    {
        //*Fields
        /// <summary>
        /// ID number of the user
        /// </summary>
        private int _id; //*id

        /// <summary>
        /// Name of the user
        /// </summary>
        private string _name; //*name

        /// <summary>
        /// Contact number of the user
        /// </summary>
        private string _contactno; //*contact no

        /// <summary>
        /// Year number of the user
        /// </summary>
        private int _year; //*year

        /// <summary>
        /// Status of the user in an enum. There are 3 set values - Normal(default value), Platinum and gold. 
        /// </summary>
        private UserProfileStatus _status; //*Status
        public enum UserProfileStatus
        {
            Normal,
            Platinum,
            Gold
        }

        /// <summary>
        /// List of transactions using the general list
        /// </summary>
        private List<Transaction> _transactionsmade;

        //*Properties
        /// <summary>
        /// Public property of the private _id field
        /// </summary>
        /// <value></value>
        public int ID{ //*id 
            get{ return _id;}
            set{ _id = value;}
        }

        /// <summary>
        /// Public property of the private _name field
        /// </summary>
        /// <value></value>
        public string Name{ //*name
            get{return _name;}
            set{_name = value;}
        }

        /// <summary>
        /// Public property of the private Contact no  field
        /// </summary>
        /// <value></value>
        public string Contactno{ //*contact no
            get{return _contactno;}
            set{_contactno = value;}
        }
        
        /// <summary>
        /// Public property of the private Year field
        /// </summary>
        /// <value></value>
        public int Year{ //*year
            get{return _year;}
            set{_year = value;}
        }

        /// <summary>
        /// Public property of the private enum _status
        /// </summary>
        /// <value></value>
        public UserProfileStatus Status{ //*status
            get{ return _status;}
            set{ _status = value;}
        }

        //*Constructors
        /// <summary>
        /// This the constructor for the class it creates the user as objects.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="contactno"></param>
        /// <param name="year"></param>
        /// <param name="status"></param>
        public UserProfile(int id, string name, string contactno, int year, UserProfileStatus status = UserProfileStatus.Normal){
            _id = id;
            _name = name;
            _contactno = contactno;
            _year = year;
            _status = status;
            _transactionsmade = new List<Transaction>(); //*creates the new list
        }

        //*Methods
        /// <summary>
        /// Method for updating the User Status if they are elgible or not.
        /// </summary>
        public void StatusUpdate(){ 
            int total = 0;
            foreach (Transaction var in _transactionsmade){
                total = total + var.Amounts;
            }
            if ( _year <= 2018 && total>= 10000)
            {
                _status = UserProfileStatus.Platinum;
            }
            else if ( _year <= 2016 && total>= 30000)
            {
                _status = UserProfileStatus.Gold;
            }
            else
            {
                _status = UserProfileStatus.Normal;
            }
        }

        /// <summary>
        /// Method for adding transaction into a general list.
        /// </summary>
        public void AddTransaction(Transaction item){
            _transactionsmade.Add(item);
        }

        /// <summary>
        /// Method for removing transaction from a general list.
        /// </summary>
        public void DeleteTransaction(Transaction item){
            _transactionsmade.Remove(item);
        }

        public int ListofTransactions(){
            int totaltransactions = 0;

            foreach(Transaction var in _transactionsmade){
                var.UpdatePoints();
                Console.Write("\nTransaction No: " + var.TransNo + "\n");
                Console.WriteLine("Transaction Date: " + var.Date);
                Console.WriteLine("TRansaction Amount(s): " + var.Amounts);
                Console.WriteLine("Points " + var.Points);
                Console.WriteLine("Transaction mode: " + var.Mode);
                Console.WriteLine(var.PrintInfo());
                totaltransactions +=1;
            }

            return totaltransactions;
        }

        public Transaction this[int i]{ //*returns transactions in a list with an index
            get{ return _transactionsmade[i];}
        }
    }
}
