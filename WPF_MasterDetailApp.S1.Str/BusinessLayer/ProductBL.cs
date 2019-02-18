using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using WPF_MasterDetailApp;
using WPF_MasterDetailApp.Models;

namespace WPF_MasterDetailApp.BusinessLayer
{
    public class ProductBL
    {
        #region ENUMS



        #endregion

        #region FIELDS

        ProductWindowPresenter _productWindowPresenter;
        ProductWindowView _productWindowView;

        #endregion

        #region PROPERTIES

        #endregion

        #region CONSTRUCTORS

        public ProductBL()
        {
            //
            // instantiate the view model and initialize the data set
            //

            _productWindowPresenter = new ProductWindowPresenter(GetCompanyData(), GetProductData());

            //
            // instantiate, set the data context, and show the Main Window
            //
            _productWindowView = new ProductWindowView(_productWindowPresenter);
            _productWindowView.DataContext = _productWindowPresenter;
            _productWindowView.Show();
        }

        private Product GetProductData()
        {
            return 
                new Product()
                {
                    Id = 0,
                    LastName = "Isaac",
                    FirstName = "Jonathan",
                    FullName = "Jonathan Isaac",
                    CurrentPlayerRank = 34,
                    LatestUpdate = DateTime.Parse("2/17/19"),
                    Description = "Jonathan Isaac had another strong showing in 27 minutes during a 127-89 blowout win over the Hornets, making 6-of-9 from the field for 16 points with six rebounds, one steal, one block and two 3-pointers in 27 minutes. Make it 12 straight games for Isaac being on a roll, averaging 12.9 points, 7.2 boards, 1.1 dimes, 1.2 steals, 2.4 blocks and 1.5 treys in his previous 11.His strong play coincides with the Magic winning seven of their last eight games as he continues to make impacts on both ends of the floor.Isaac has been a second - round player over the last dozen games, so clearly patience is paying off in a big way.",
                    ImageFileName = "isaac.jpg",
                    Points = 15.5,
                    Rebounds = 5.3,
                    Assists = 0.7,
                    Steals = 1.0,
                    Blocks = 2.7,
                    Threes = 1.8,
                    FieldGoal = 50.7,
                    FreeThrow = 100,
                    Turnovers = 0.8,
                    Owned = 56,
                    Position = "SF, PF"
                };
        }

        private Company GetCompanyData()
        {
            return new Company()
            {
                TeamName = "Orlando Magic",
        };

            
            
        }



        #endregion

        #region METHODS



        #endregion

        #region EVENTS


        #endregion

    }
}
