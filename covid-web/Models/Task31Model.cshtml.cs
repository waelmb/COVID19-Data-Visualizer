using System;  
using System.Collections.Generic;  
using System.Linq;  
using System.Threading.Tasks;  
using Microsoft.AspNetCore.Mvc;  
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data;

namespace program.Pages
{
    public class Task31Model : PageModel
    {
				public string Input { get; set; }
        public string Input2 { get; set; }
        public string Input3 { get; set; }
				public Exception EX { get; set; }
        public List<int> positiveIncreaseDataset1 { get; set; }
        public List<int> negativeIncreaseDataset1 { get; set; }
        public List<string> datesDataset1 { get; set; }
        public string stateName1 { get; set; }
        public int Count1 { get; set; }
        public List<int> positiveIncreaseDataset2 { get; set; }
        public List<int> negativeIncreaseDataset2 { get; set; }
        public List<string> datesDataset2 { get; set; }
        public string stateName2 { get; set; }
        public int Count2 { get; set; }
        public List<int> positiveIncreaseDataset3 { get; set; }
        public List<int> negativeIncreaseDataset3 { get; set; }
        public List<string> datesDataset3 { get; set; }
        public string stateName3 { get; set; }
        public int Count3 { get; set; }
        public List<string> datesDatasetAll { get; set; }
        public int CountAllDates { get; set; }
        
        public void OnGet(string input, string input2, string input3)  
        {  
          positiveIncreaseDataset1 = new List<int>();
          negativeIncreaseDataset1 = new List<int>();
          datesDataset1 = new List<string>();
					Count1 = 0;
          positiveIncreaseDataset2 = new List<int>();
          negativeIncreaseDataset2 = new List<int>();
          datesDataset2 = new List<string>();
					Count2 = 0;
          positiveIncreaseDataset3 = new List<int>();
          negativeIncreaseDataset3 = new List<int>();
          datesDataset3 = new List<string>();
					Count3 = 0;
          datesDatasetAll = new List<string>();
          CountAllDates = 0;
          
					// make input available to web page:
					Input = input;
          Input2 = input2;
          Input3 = input3;
          Console.WriteLine("Input: " + Input);
          Console.WriteLine("Input2: " + Input2);
          Console.WriteLine("Input3: " + Input3);

          
					// clear exception:
					EX = null;
					
					try
					{
						//
						// Do we have an input argument?  If not, there's nothing to do:
						//
						if (input == null || input2 == null || input3 == null)
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
							string sqlDates, sql1, sql2, sql3;

						  sqlDates = string.Format(@"
SELECT date, state
FROM us_states_covid19_daily
WHERE state LIKE '{0}'
  OR state LIKE '{1}'
  OR state LIKE '{2}'
ORDER BY date;
", input, input2, input3);

							sql1 = string.Format(@"
SELECT date, state, positiveIncrease, negativeIncrease 
FROM us_states_covid19_daily
WHERE state LIKE '{0}'
ORDER BY date;
", input);
              sql2 = string.Format(@"
SELECT date, state, positiveIncrease, negativeIncrease 
FROM us_states_covid19_daily
WHERE state LIKE '{0}'
ORDER BY date;
", input2);
              sql3 = string.Format(@"
SELECT date, state, positiveIncrease, negativeIncrease 
FROM us_states_covid19_daily
WHERE state LIKE '{0}'
ORDER BY date;
", input3);
              
              Console.WriteLine("Query Dates: " + sqlDates);
              Console.WriteLine("Query1: " + sql1);
              Console.WriteLine("Query2: " + sql2);
              Console.WriteLine("Query3: " + sql3);
              
              DataSet dsDates = DataAccessTier.DB.ExecuteNonScalarQuery(sqlDates);
							DataSet ds1 = DataAccessTier.DB.ExecuteNonScalarQuery(sql1);
              DataSet ds2 = DataAccessTier.DB.ExecuteNonScalarQuery(sql2);
              DataSet ds3 = DataAccessTier.DB.ExecuteNonScalarQuery(sql3);
              
              foreach (DataRow row in dsDates.Tables[0].Rows)
							{
                Console.WriteLine("date: " + row["date"] + " state: " + row["state"]);
                //CountAllDates++; .Add(dates);
                string date = Convert.ToString(row["date"]);
                
                //add to all dates dataset
                if(datesDatasetAll.IndexOf(date) == -1) {
                  datesDatasetAll.Add(date);
                  CountAllDates++;
                }
              }
              
							foreach (DataRow row in ds1.Tables[0].Rows)
							{
                Count1++;
                
                Console.WriteLine("row: " + row["date"] + ". " + row["state"] + ". " + row["positiveIncrease"] + ". " + row["negativeIncrease"] + "."); 
                
                //extract
                int positiveIncrease, negativeIncrease;
                if(Convert.ToString(row["positiveIncrease"]).Equals("")) {
                  //Console.WriteLine("is null");
                  positiveIncrease = 0;
                }
                else {
                  positiveIncrease = Convert.ToInt32(row["positiveIncrease"]);
                  
                }
                
                if(Convert.ToString(row["negativeIncrease"]).Equals("")) {
                  //Console.WriteLine("deaths is null");
                  negativeIncrease = 0;
                }
                else {
                  negativeIncrease = Convert.ToInt32(row["negativeIncrease"]);
                  
                }
                
                string dates = Convert.ToString(row["date"]);
                
                //print to console
                //Console.WriteLine(positiveIncrease + " " + negativeIncrease);                              
                
                
                positiveIncreaseDataset1.Add(positiveIncrease);
                negativeIncreaseDataset1.Add(negativeIncrease);
                datesDataset1.Add(dates);
                
                stateName1 = input;
							}
              
              foreach (DataRow row in ds2.Tables[0].Rows)
							{
                Count2++;
                
                Console.WriteLine("row: " + row["date"] + ". " + row["state"] + ". " + row["positiveIncrease"] + ". " + row["negativeIncrease"] + "."); 
                
                //extract
                int positiveIncrease, negativeIncrease;
                if(Convert.ToString(row["positiveIncrease"]).Equals("")) {
                  //Console.WriteLine("is null");
                  positiveIncrease = 0;
                }
                else {
                  positiveIncrease = Convert.ToInt32(row["positiveIncrease"]);
                  
                }
                
                if(Convert.ToString(row["negativeIncrease"]).Equals("")) {
                  //Console.WriteLine("deaths is null");
                  negativeIncrease = 0;
                }
                else {
                  negativeIncrease = Convert.ToInt32(row["negativeIncrease"]);
                  
                }
                
                string dates = Convert.ToString(row["date"]);
                
                //print to console
                //Console.WriteLine(positiveIncrease + " " + negativeIncrease);                              
                
                
                positiveIncreaseDataset2.Add(positiveIncrease);
                negativeIncreaseDataset2.Add(negativeIncrease);
                datesDataset2.Add(dates);
                
                stateName2 = input2;
							}
              
              foreach (DataRow row in ds3.Tables[0].Rows)
							{
                Count3++;
                
                Console.WriteLine("row: " + row["date"] + ". " + row["state"] + ". " + row["positiveIncrease"] + ". " + row["negativeIncrease"] + "."); 
                
                //extract
                int positiveIncrease, negativeIncrease;
                if(Convert.ToString(row["positiveIncrease"]).Equals("")) {
                  //Console.WriteLine("is null");
                  positiveIncrease = 0;
                }
                else {
                  positiveIncrease = Convert.ToInt32(row["positiveIncrease"]);
                  
                }
                
                if(Convert.ToString(row["negativeIncrease"]).Equals("")) {
                  //Console.WriteLine("deaths is null");
                  negativeIncrease = 0;
                }
                else {
                  negativeIncrease = Convert.ToInt32(row["negativeIncrease"]);
                  
                }
                
                string dates = Convert.ToString(row["date"]);
                
                //print to console
                //Console.WriteLine(positiveIncrease + " " + negativeIncrease);                              
                
                
                positiveIncreaseDataset3.Add(positiveIncrease);
                negativeIncreaseDataset3.Add(negativeIncrease);
                datesDataset3.Add(dates);
                
                stateName3 = input3;
							}
              
              //foreach date in datesDatasetAll
              int index = 0;
              foreach(string date in datesDatasetAll)
              {
                  //check if date DOESN'T exists in dateDatasets
                  if(datesDataset1.IndexOf(date) == -1) {
                      //insert "0" to positiveIncreaseDataset and negativeIncreaseDataset at index
                      positiveIncreaseDataset1.Insert(index, 0);
                      negativeIncreaseDataset1.Insert(index, 0);
                  }
                  
                  if(datesDataset2.IndexOf(date) == -1) {
                      //insert "0" to positiveIncreaseDataset and negativeIncreaseDataset at index
                      positiveIncreaseDataset2.Insert(index, 0);
                      negativeIncreaseDataset2.Insert(index, 0);
                  }
                  
                  if(datesDataset3.IndexOf(date) == -1) {
                      //insert "0" to positiveIncreaseDataset and negativeIncreaseDataset at index
                      positiveIncreaseDataset3.Insert(index, 0);
                      negativeIncreaseDataset3.Insert(index, 0);
                  }
                  index++;
              }
              
              Console.WriteLine("index: " + index + "count1: " + positiveIncreaseDataset1.Count + "count2: " + positiveIncreaseDataset2.Count + "count3: " + positiveIncreaseDataset3.Count);
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