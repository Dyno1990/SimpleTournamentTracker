using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary
{
    public class SQLConnector : IDataConnection
    {
        /// <summary>
        /// Saves a new prize to the database
        /// </summary>
        /// <param name="model"></param>
        /// <returns>The prize information, including the unique identifier.</returns>

        public PrizeModel CreatePrize(PrizeModel model)
        {
            model.id = 1;

            return model;
        }
    }
}
