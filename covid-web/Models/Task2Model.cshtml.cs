using System;  
using System.Collections.Generic;  
using System.Linq;  
using System.Threading.Tasks;  
using Microsoft.AspNetCore.Mvc;  
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data;

namespace program.Pages
{
    public class Task2Model : PageModel
    {
				public string Input { get; set; }
				public Exception EX { get; set; }
        public List<Models.StateCensus> StateList { get; set; }
        public List<int> hospitalizationDataset { get; set; }
        public List<int> deathsDataset { get; set; }
        public List<string> datesDataset { get; set; }
        public string stateName { get; set; }
        public int Count { get; set; }
  
        public void OnGet(string input)  
        {  
          hospitalizationDataset = new List<int>();
          deathsDataset = new List<int>();
          datesDataset = new List<string>();
          StateList = new List<Models.StateCensus>();
					Count = 0;
          
					// make input available to web page:
					Input = input;
					
					// clear exception:
					EX = null;
					
					try
					{
						//
						// Do we have an input argument?  If not, there's nothing to do:
						//
						if (input == null)
						{
							//
							// there's no page argument, perhaps user surfed to the page directly?  
							// In this case, nothing to do.
							//
						}
						else  
						{
							// 
							// Lookup movie(s) based on input, which could be id or a partial name:
							// 
							string sql;

						  // lookup station(s) by partial name match:
							input = input.Replace("'", "''");

							sql = string.Format(@"
SELECT date AS DATE, hospitalized AS HOSPITALIZED, state as STATE, death as deaths
FROM us_states_covid19_daily
WHERE state LIKE '{0}'
ORDER BY date;
", input);
              Console.WriteLine("Input: " + input);
              Console.WriteLine("Query: " + sql);
							DataSet ds = DataAccessTier.DB.ExecuteNonScalarQuery(sql);
              
							foreach (DataRow row in ds.Tables[0].Rows)
							{
                Count++;
                
                //Console.WriteLine("row: " + row["DATE"] + ". " + row["state"] + ". " + row["HOSPITALIZED"] + ". " + row["deaths"] + "."); 
                if(Convert.ToString(row["HOSPITALIZED"]).Equals("")) {
                  Console.WriteLine("is null");
                }
                //extract
                
                int hospitalized, deaths;
                if(Convert.ToString(row["HOSPITALIZED"]).Equals("")) {
                  Console.WriteLine("is null");
                  hospitalized = 0;
                }
                else {
                  hospitalized = Convert.ToInt32(row["hospitalized"]);
                  
                }
                
                if(Convert.ToString(row["deaths"]).Equals("")) {
                  Console.WriteLine("deaths is null");
                  deaths = 0;
                }
                else {
                  deaths = Convert.ToInt32(row["deaths"]);
                  
                }
                
                string dates = Convert.ToString(row["DATE"]);
                
                
                Models.StateCensus s = new Models.StateCensus();
                s.StateName = input;
								s.Year = hospitalized;
								s.Population = deaths;
                
                
                
                //print to console
                Console.WriteLine(dates + " " + hospitalized + " " + deaths);                              
                
                
                datesDataset.Add(dates);
                deathsDataset.Add(deaths);
                hospitalizationDataset.Add(hospitalized);
                
                stateName = input;
							}
						}//else
					}
					catch(Exception ex)
					{
					  EX = ex;
					}
					finally
					{
					  // nothing at the moment
				  }
				}
			
    }//class  
}//namespace