using System;  
using System.Collections.Generic;  
using System.Linq;  
using System.Threading.Tasks;  
using Microsoft.AspNetCore.Mvc;  
using Microsoft.AspNetCore.Mvc.RazorPages;  
using System.Data;
  
namespace program.Pages  
{  
    public class StateInfoModel : PageModel  
    {  
				public List<Models.StateCensus> StateList { get; set; }
				public string Input { get; set; }
				public Exception EX { get; set; }
        
        public List<int> populationDataset { get; set; }
        public List<int> yearDataset { get; set; }
        public string stateName { get; set; }
  
        public void OnGet(string input)  
        {  
				  StateList = new List<Models.StateCensus>();
          populationDataset = new List<int>();
          yearDataset = new List<int>();
					
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
  SELECT year, population
  FROM census
  WHERE state LIKE '{0}'
  ORDER BY Year;
	", input);
              Console.WriteLine("Input: " + input);
              Console.WriteLine("Query: " + sql);
							DataSet ds = DataAccessTier.DB.ExecuteNonScalarQuery(sql);

							foreach (DataRow row in ds.Tables[0].Rows)
							{
                
								Models.StateCensus s = new Models.StateCensus();
                
                s.StateName = input;
								s.Year = Convert.ToInt32(row["year"]);
								s.Population = Convert.ToInt32(row["population"]);

								StateList.Add(s);
                populationDataset.Add(s.Population);
                yearDataset.Add(s.Year);
                stateName = input;
                
                Console.WriteLine(input + " " + s.Population +  " " + s.Year);
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