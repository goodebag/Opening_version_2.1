using Microsoft.AspNetCore.Mvc;
using Opening_version_2._1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Opening_version_2._1.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class DaysController : ControllerBase
    {
        
        //[HttpGet]
        //public ActionResult<viewModel> GetWorkingHours()
        //{
        //    if (delivery !=null)
        //    {
        //        return Ok(delivery);
        //    }
        //    else
        //        return NotFound();
        //}
        [HttpPost]
        public ActionResult SetWorkingHours([FromBody] week model)
        {
            //List<(string, string)> deliveries = new List<(string, string)>();
            viewModel deliveries = new viewModel();
            string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };


            for (int j = 0; j < days.Length; j++)
            {

                string day = days[j];
                // var testing = model.GetType().GetProperty(day).GetValue()
                //Hour[] checking = (Hour[])testing;
                //var propType = typeof(model)
                if (days[j] == "Monday")
                {

                    for (int i = 0; i < model.Monday.Length; i++)
                    {
                        if (i > 0)
                        {
                            deliveries.Monday += ConvertMethod(model.Monday[i], i);
                        }
                        else
                        {
                            deliveries.Monday = ConvertMethod(model.Monday[i], i);
                        }
                    
                    }

                }

                if (days[j] == "Tuesday")
                {
                    for (int i = 0; i < model.Tuesday.Length; i++)
                    {
                        if (i > 0)
                        {
                            deliveries.Tuesday += ConvertMethod(model.Tuesday[i], i);
                        }
                        else
                        {
                            deliveries.Tuesday = ConvertMethod(model.Tuesday[i], i);
                        }
                    }
                }
                if (days[j] == "Wednesday")
                {
                    for (int i = 0; i < model.wednesday.Length; i++)
                    {
                        if (i > 0)
                        {
                            deliveries.wednesday += ConvertMethod(model.wednesday[i], i);
                        }
                        else
                        {
                            deliveries.wednesday = ConvertMethod(model.wednesday[i], i);
                        }
                    }

                }
                if (days[j] == "Thursday")
                {
                    for (int i = 0; i < model.Thursday.Length; i++)
                    {
                        if (i > 0)
                        {
                            deliveries.Thursday += ConvertMethod(model.Thursday[i], i);
                        }
                        else
                        {
                            deliveries.Thursday = ConvertMethod(model.Thursday[i], i);
                        }
                    }

                }
                if (days[j] == "Friday")
                {
                    for (int i = 0; i < model.Friday.Length; i++)
                    {
                        if (i > 0)
                        {
                            deliveries.Friday += ConvertMethod(model.Friday[i], i);
                        }
                        else
                        {
                            deliveries.Friday = ConvertMethod(model.Friday[i], i);
                        }
                    }

                }
                if (days[j] == "Saturday")
                {
                    for (int i = 0; i < model.Saturday.Length; i++)
                    {
                        if (i >0 )
                        {
                            deliveries.Saturday += ConvertMethod(model.Saturday[i], i);
                        }
                        else
                        {
                            deliveries.Saturday = ConvertMethod(model.Saturday[i], i);
                        }
                    }

                }
                if (days[j] == "Sunday")
                {
                    for (int i = 0; i < model.Sunday.Length; i++)
                    {
                        if (i > 0)
                        {
                            deliveries.Sunday += ConvertMethod(model.Sunday[i], i);
                        }
                        else
                        {
                            deliveries.Sunday = ConvertMethod(model.Sunday[i], i);
                        }
                    }

                }
            }
                return Ok(deliveries);
        }

        private string ConvertMethod(Hour hours,int i)
        {
            //First make a System.DateTime equivalent to the UNIX Epoch.
            DateTime dateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0);
            dateTime = dateTime.AddSeconds(hours.value).ToLocalTime();
            if (i > 0)
            {
                return ( " - " + dateTime.ToShortTimeString());
                //delivery += (" - " + dateTime.ToShortTimeString());
            }
            else
            {
                return (dateTime.ToShortTimeString());
                //delivery.Sunday = dateTime.ToShortTimeString();
            }
        }
    }
}
