using System;  
using System.Collections.Generic;  
using System.Linq;  
using System.Threading.Tasks;  
using Microsoft.AspNetCore.Mvc;  
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data;

namespace program.Pages
{
    public class Task4Model : PageModel
    {
				public string Input { get; set; }
				public Exception EX { get; set; }
        public List<int> totalsDataset { get; set; }
        //public List<string> datesDataset { get; set; }
        public List<string> step2FormattedDates { get; set; }
        public List<string> step3StartDatesRaw { get; set; }
        public List<string> newsDataset { get; set; }
        public List<List<string>> eventsDataStructure { get; set; }
        public List<List<string>> testDataset { get; set; }
        public string stateName { get; set; }
        public string stateAbbr { get; set; }
        public int CountDates { get; set; }
        public int CountNews { get; set; }
        public int CountNewsWithin { get; set; }
  
        public void OnGet(string input)  
        {  
          stateName = "None";
          stateAbbr = "N/A";
					CountDates = 0;
          CountNews = 0;
          CountNewsWithin = 0;
          step2FormattedDates = new List<string>();
          totalsDataset = new List<int>();
          step3StartDatesRaw = new List<string>();
          newsDataset = new List<string>();
          testDataset = new List<List<string>>();
          eventsDataStructure = new List<List<string>>();
          
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
							
              //STEP1: get state name and abbreviation
              string sqlStateName;
              
              sqlStateName = string.Format(@"
SELECT * FROM states WHERE State LIKE '%{0}%';
", input);
              Console.WriteLine("sqlStateName Query: " + sqlStateName);
              
              DataSet dsStateName = DataAccessTier.DB.ExecuteNonScalarQuery(sqlStateName);
              
              foreach (DataRow row in dsStateName.Tables[0].Rows)
							{
                stateName = Convert.ToString(row["State"]);
                stateAbbr = Convert.ToString(row["Abbreviation"]);
                
              }
              
              Console.WriteLine("stateName: " + stateName + ". stateAbbr: " + stateAbbr + ".");
              
              //STEP2 get state dates and totals from covid19_daily
              string sql2 = string.Format(@"
SELECT date, total
FROM us_states_covid19_daily
WHERE state LIKE '%{0}%'
ORDER BY date;
", stateAbbr);
            Console.WriteLine("sql2 Query: " + sql2);
            
            DataSet ds2 = DataAccessTier.DB.ExecuteNonScalarQuery(sql2);
            
            foreach (DataRow row in ds2.Tables[0].Rows)
						{
                CountDates++;
                
                //extract
                int total;
                string date, rawDate;
                if(Convert.ToString(row["total"]).Equals("")) {
                  Console.WriteLine("total is null");
                  total = 0;
                }
                else {
                  total = Convert.ToInt32(row["total"]);
                }
                
                //manipulate date
                rawDate = Convert.ToString(row["date"]);
                date = Convert.ToString(rawDate[0]) + Convert.ToString(rawDate[1]) + Convert.ToString(rawDate[2]) + Convert.ToString(rawDate[3]) + "/" + Convert.ToString(rawDate[4]) + Convert.ToString(rawDate[5]) + "/" + Convert.ToString(rawDate[6]) + Convert.ToString(rawDate[7]);
                
                Console.WriteLine("date: " + date + " total: " + total);
                
                //add to lists
                step2FormattedDates.Add(date);
                totalsDataset.Add(total);
                
            }
            
            //STEP3: get StartDate and DescriptionOfMeasure from covid_mitigation_usa
            string sql3 = string.Format(@"
SELECT Country, StartDate, DescriptionOfMeasure
FROM covid_mitigation_usa
WHERE Country LIKE '%{0}%'
ORDER BY StartDate;
", stateName);
            Console.WriteLine("sql3 Query: " + sql3);
            
            DataSet ds3 = DataAccessTier.DB.ExecuteNonScalarQuery(sql3);
            
            foreach (DataRow row in ds3.Tables[0].Rows)
						{
                CountNews++;
                
                //Console.WriteLine("row: " + row["StartDate"] + row["EndDate"]  + row["StartDate"]);
                
                //extract
                string start, news;
                if(Convert.ToString(row["StartDate"]).Equals("")) {
                  //Console.WriteLine("StartDate is null");
                  start = "Jan 11, 2019";
                }
                else {
                  start = Convert.ToString(row["StartDate"]);
                }

                
                if(Convert.ToString(row["DescriptionOfMeasure"]).Equals("")) {
                  Console.WriteLine("DescriptionOfMeasure is null");
                  news = "No news for this date.";
                }
                else {
                  news = Convert.ToString(row["DescriptionOfMeasure"]);
                }
                                
                Console.WriteLine("start: " + start + " news: " + news);
                
                //add to lists
                step3StartDatesRaw.Add(start);
                newsDataset.Add(news);
            }
            
            List<string> testEvents = new List<string>();
            testEvents.Add("test event 1");
            testEvents.Add("test event 2");
            testDataset.Add(testEvents);
            List<string> testEvents2 = new List<string>();
            testEvents2.Add("test event 3");
            testEvents2.Add("test event 4");
            testDataset.Add(testEvents2);
            
            //STEP4: convert step3StartDatesRaw to TimeDate objects, then to strings
            List<DateTime> eventsDatesObjects = new List<DateTime>();
            foreach (string rawDate in step3StartDatesRaw)
            {
                //Console.WriteLine("rawDate: " + rawDate);
                
                //create TimeDate object and parse
                DateTime dateObjects = DateTime.Parse(rawDate);
                
                //Console.WriteLine(dateObjects.ToString("MM/dd/yyyy"));
                
                eventsDatesObjects.Add(dateObjects);
            }
            
            //STEP5: convert step2FormattedDates to TimeDate objects, then to strings
            List<DateTime> allDatesObjects = new List<DateTime>();
            foreach (string rawDate in step2FormattedDates)
            {
                //Console.WriteLine("rawDate: " + rawDate);
                
                //create TimeDate object and parse
                DateTime dateObjects = DateTime.Parse(rawDate);
                
                //Console.WriteLine(dateObjects.ToString("yyyy/MM/dd"));
                
                allDatesObjects.Add(dateObjects);
            }
            
            //STEP6: Initialize eventsDataStructure and add empty messages for all allDatesObjects
            foreach (DateTime allDate in allDatesObjects)
            {
                List<string> element = new List<string>();
                //element.Add("No news for this date.");
                eventsDataStructure.Add(element);
            }  
						//Console.WriteLine("eventsDataStructure count: " + eventsDataStructure.Count);
            
            //STEP7: for each eventsDatesObjects, get index of the date, then add to eventsDataStructure
            foreach (DateTime date in eventsDatesObjects)
            {
                //get index
                int index = step2FormattedDates.IndexOf(date.ToString("yyyy/MM/dd"));
                Console.WriteLine("index: " + index);
                
                //if found, add
                if(index != -1) {
                    CountNewsWithin++;
                    
                    //add event to eventsDataStructure
                    eventsDataStructure[index].Add(newsDataset[0]);
                  
                }
                
                //delete the first element from newsDataset
                newsDataset.RemoveAt(0);
            }
            
            Console.WriteLine("CountNewsWithin: " + CountNewsWithin);
            
            //STEP8: for each eventsDataStructure, add a message if empty.
            foreach (List<string> element in eventsDataStructure)
            {
              if(element.Count == 0) {
                 element.Add("No news for this date.");
              }
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