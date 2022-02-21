using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APSFizzBuzz.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        //Holds the number and relevent output terms (Fizz, Buzz
        public IEnumerable<string> Numbers { get; private set; }
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
            Numbers = InitializeNumbers();
        }


        //Sets this result base of the conditions
        //Multiple of 3 and 5 -> FizzBuzz
        //Multiple of 3 -> Fizz
        //Multiple of 5 -> Buzz
        private IEnumerable<string> InitializeNumbers()
        {
            IList<string> tempNumbers = new List<string>();
            for(int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                    tempNumbers.Add("FizzBuzz");
                else if (i % 3 == 0)
                    tempNumbers.Add("Fizz");
                else if (i % 5 == 0)
                    tempNumbers.Add("Buzz");
                else
                    tempNumbers.Add(i.ToString());
            }
            return tempNumbers;
        }
        public string GetCardClass(string result)
        {
            if (result.Equals("FizzBuzz"))
            {
                return "fizz-buzz";
            }

            if (result.Equals("Buzz"))
            {
                return "buzz";
            }

            if (result.Equals("Fizz"))
            {
                return "fizz";
            }

            return "";
        }
        public void OnGet()
        {

        }

    }
}
