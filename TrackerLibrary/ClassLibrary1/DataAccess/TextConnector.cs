using System;
using System.Collections.Generic;
using System.Text;
using TrackerLibrary.Models;
using TrackerLibrary.DataAccess.TextHelpers;
using System.Linq;

namespace TrackerLibrary.DataAccess
{
    public class TextConnector : IDataConnection
    {
        private const string PrizesFile = "PrizeModels.csv";

        //TODO - Make the CreatePrize method actually save to the text file

        /// <summary>
        /// Saves a new prize to the text file
        /// </summary>
        /// <param name="model"></param>
        /// <returns>The prize information, including the unique identifier.</returns>

        public PrizeModel CreatePrize(PrizeModel model)
        {
            // * Load the text file and Convert the text to a List<PrizeModel>
            List<PrizeModel> prizes = PrizesFile.FullFilePath().LoadFile().ConvertToPrizeModels();

            // * Find the max ID
            int currentId = 1;

            if (prizes.Count > 0)
            {
                currentId = prizes.OrderByDescending(x => x.id).First().id + 1;
            }
            model.id = currentId;

            // * Add the new record with the new ID (max + 1)
            prizes.Add(model);
            
            // * Convert the prizes to lsit<string> and Save the list<string> to the text file
            prizes.SaveToPrizeFile(PrizesFile);

            return model;
        }
    }
}
