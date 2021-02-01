using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace data
{
    public class API
    {
        public API()
        {
            Console.WriteLine(getTotalGoals("", 2011));
        }

        public static int getTotalGoals(string team, int year)
        {

            int count = 0;
            for (int i = 0; i < 10; i++)
            {
                score = 0;
                var output = GetDraws(year, pageId: 1);
                if (output != null && output.Data != null && output.Data.Count > 0)
                {
                    count = count + (output.per_page * (output.total_pages - 1)); // count + output.Data.Where(s => s.Draw == true).Count();
                    output.page = output.total_pages;
                    while (output.page == output.total_pages)
                    {
                        //  output.page = output.page + 1;
                        output = GetDraws(year, output.page);
                        if (output == null)
                            break;
                        count = count + output.Data.Where(s => s.Draw == true).Count();
                    }
                }
            }

            return count;
        }
        static int score = 0;
        static int prepage = 1;
        public static Response GetDraws(int year, int? pageId = null, int? detail = null)
        {

            HttpClient client = new HttpClient();
            string url = $"https://jsonmock.hackerrank.com/api/football_matches?year={year}&team1goals={score}&team2goals={score}";


            if (pageId.HasValue)
            {
                url = $"{url}&page={pageId.Value}";

            }
            var response = client.GetAsync(url).GetAwaiter().GetResult();
            response.EnsureSuccessStatusCode();


            return JsonConvert.DeserializeObject<Response>(response.Content.ReadAsStringAsync().GetAwaiter().GetResult());

        }
        public static Response GetResponse(string team, int year, int? pageId = null, int? detail = null)
        {
            HttpClient client = new HttpClient();
            string url = $"https://jsonmock.hackerrank.com/api/football_matches?year={year}&team1={team}";

            if (detail.HasValue)
                url = $"https://jsonmock.hackerrank.com/api/football_matches?year={year}&team2={team}";

            if (pageId.HasValue)
                url = $"{url}&page={pageId.Value}";

            var response = client.GetAsync(url).GetAwaiter().GetResult();
            response.EnsureSuccessStatusCode();

            return JsonConvert.DeserializeObject<Response>(response.Content.ReadAsStringAsync().GetAwaiter().GetResult());

        }
    }


    public class Details
    {
        public string competition { set; get; }
        public int year { set; get; }
        public string team1 { set; get; }
        public string team2 { set; get; }
        public string team1goals { set; get; }
        public string team2goals { set; get; }

        public bool Draw
        {
            get
            {
                return team1goals == team2goals;
            }
        }
    }
    public class Response
    {
        public int page { set; get; }
        public int per_page { set; get; }
        public int total_pages { set; get; }
        public List<Details> Data { get; set; }

    }
}
