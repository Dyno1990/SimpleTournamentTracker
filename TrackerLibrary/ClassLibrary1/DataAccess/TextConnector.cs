using System;
using System.Collections.Generic;
using System.Text;
using TrackerLibrary.Models;
using TrackerLibrary.DataAccess.TextHelpers;

namespace TrackerLibrary.DataAccess
{
    public class TextConnector : IDataConnection
    {
        //TODO - Make the CreatePrize method actually save to the text file

        /// <summary>
        /// Saves a new prize to the text file
        /// </summary>
        /// <param name="model"></param>
        /// <returns>The prize information, including the unique identifier.</returns>

        public PrizeModel CreatePrize(PrizeModel model)
        {
            // * Load the text file
            // * Convert the text to a List<PrizeModel>
            // Find the max ID
            // Add the new record with the new ID (max + 1)
            // Convert the prizes to lsit<string>
            // Save the list<string> to the text file
        }
    }
}
