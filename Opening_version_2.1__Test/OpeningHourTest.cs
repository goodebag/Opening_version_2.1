using Microsoft.VisualStudio.TestTools.UnitTesting;
using Opening_version_2._1.Models;

namespace Opening_version_2._1__Test
{
    [TestClass]
    public class OpeningHourTest
    {
        [TestMethod]
        public void Test_SetWorkingHours()
        {
            //Arrange section start
            //  initializing hours
            Hour[] Monday = new Hour[] { };
            Hour[] Tuesday = new Hour[] { new Hour { type = "open", value = 36000 }, new Hour { type = "close", value = 64800 } };
            Hour[] Wednesday = new Hour[] { };
            Hour[] Thursday = new Hour[] { new Hour { type = "open", value = 36000 }, new Hour { type = "close", value = 64800 } };
            Hour[] Friday = new Hour[] { new Hour { type = "open", value = 36000 } };
            Hour[] Saturday = new Hour[] { new Hour { type = "close", value = 36000 }, new Hour { type = "open", value = 36000 } };
            Hour[] Sunday = new Hour[] { new Hour { type = "close", value = 36000 }, new Hour { type = "open", value = 43200 }, new Hour { type = "open", value = 756000 } };
            // asigning it to week var
            week input = new week();
            input.Monday = Monday;
            input.Tuesday = Tuesday;
            input.wednesday = Wednesday;
            input.Thursday = Thursday;
            input.Friday = Friday;
            input.Saturday = Saturday;
            input.Sunday = Sunday;
            // Expected
            viewModel expectation = new viewModel();
            expectation.Monday = "Closed";
            expectation.Tuesday = "11:00 am - 7:00 pm";
            expectation.wednesday = "Closed";
            expectation.Thursday = "11:00 am - 7:00 pm";
            expectation.Friday = "11:00 am";
            expectation.Saturday = "2:00 am - 11:00 am";
            expectation.Sunday = "2:00 am - 1:00 pm - 10:00 pm";
            //Arrange section Ended

            //Act Section
            
          

        }
    }
}
