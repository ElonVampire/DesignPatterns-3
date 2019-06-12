using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter_Pattern.Client
{
    class DataRenderer
    {
        private IInformationAdapter _dataAdapter;
        public string _information { get; set; }

        public DataRenderer(IInformationAdapter infoAdapter)
        {
            _dataAdapter = infoAdapter;
            _information = GetMyInformation();
        }

        private string GetMyInformation()
        {
            return _dataAdapter.GetDataOperation();
        }



    }
}
