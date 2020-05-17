using System;  
using System.Collections.Generic;  
using System.Linq;  
using System.Threading.Tasks;  
using Microsoft.AspNetCore.Mvc;  
using Microsoft.AspNetCore.Mvc.RazorPages;  
using System.Data;
  
namespace program.Pages  
{  
    public class ActionsTaken : PageModel  
    {  
				public List<Models.ActionsTakenModel> NewsList { get; set; }
				public string Input { get; set; }
				public Exception EX { get; set; }
  
        public void OnGet(string input)  
        {  
				  NewsList = new List<Models.ActionsTakenModel>();
					
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
SELECT Country, StartDate, DescriptionOfMeasure 
FROM covid_Mitigation 
GROUP BY StartDate;
	", input);

							DataSet ds = DataAccessTier.DB.ExecuteNonScalarQuery(sql);

							foreach (DataRow row in ds.Tables[0].Rows)
							{
								Models.ActionsTakenModel s = new Models.ActionsTakenModel();
                
                s.StateName = Convert.ToString(row["Country"]);
								s.Date = Convert.ToString(row["StartDate"]);
								s.News = Convert.ToString(row["DescriptionOfMeasure"]);

								NewsList.Add(s);
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