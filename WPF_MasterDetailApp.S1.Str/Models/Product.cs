using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_MasterDetailApp.Models
{
    public class Product : ObservableObject
    {
        #region ENUMS

        //public enum GenderType { none, male, female }

        #endregion

        #region FIELDS

        private int _id;
        private string _firstName;
        private string _lastName;
        private string _fullName;
        private string _imageFileName;
        private string _description;
        private DateTime _latestUpdate;
        private double _currentRank;
        private double _ppg;
        private double _rpg;
        private double _apg;
        private double _spg;
        private double _bpg;
        private double _topg;
        private double _fgpercent;
        private double _ftpercent;
        private double _threespergame;
        private string _position;
        private double _owned;

        #endregion

        #region PROPERTIES

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string FirstName
        {
            get { return _firstName; }
            set
            {
                _firstName = value;
                RaisePropertyChangedEvent("FullName"); // update items bound to the FullName property
            }
        }

        public string LastName
        {
            get { return _lastName; }
            set
            {
                _lastName = value;
                RaisePropertyChangedEvent("FullName"); // update items bound to the FullName property
            }
        }
        public string Position
        {
            get { return _position; }
            set { _position = value; }
        }


        public double Points
        {
            get { return _ppg; }
            set { _ppg = value; }
        }

        public double Rebounds
        {
            get { return _rpg; }
            set { _rpg = value; }
        }

        public double Assists
        {
            get { return _apg; }
            set { _apg = value; }
        }

        public double Steals
        {
            get { return _spg; }
            set { _spg = value; }
        }

        public double Blocks
        {
            get { return _bpg; }
            set { _bpg = value; }
        }

        public double Turnovers
        {
            get { return _topg; }
            set { _topg = value; }
        }

        public double Threes
        {
            get { return _threespergame; }
            set { _threespergame = value; }
        }

        public double FieldGoal
        {
            get { return _fgpercent; }
            set { _fgpercent = value; }
        }

        public double FreeThrow
        {
            get { return _ftpercent; }
            set { _ftpercent = value; }
        }

        public double Owned
        {
            get { return _owned; }
            set { _owned = value; }
        }

        public string ImageFileName
        {
            get { return _imageFileName; }
            set { _imageFileName = value; }
        }

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        public DateTime LatestUpdate
        {
            get { return _latestUpdate; }
            set { _latestUpdate = value; }
        }

        public double CurrentPlayerRank
        {
            get { return _currentRank; }
            set { _currentRank = value; }
        }

        public string FullName
        {
            get { return _fullName; }
            set { _fullName = value; }
        }


        public string ImageFilePath
        {
            get { return @"../Images/" + _imageFileName; }
        }

        #endregion

        #region CONSTRUCTORS

        public Product()
        {

        }

        #endregion

        #region METHODS


        #endregion

        #region EVENTS



        #endregion
    }
}
