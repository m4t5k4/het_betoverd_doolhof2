using het_betoverd_doolhof.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace het_betoverd_doolhof
{
    class ViewModelLocator
    {
        private static MainViewModel mainViewModel = new MainViewModel();

        public static MainViewModel MainViewModel
        {
            get { return mainViewModel;  }
        }
    }
}
