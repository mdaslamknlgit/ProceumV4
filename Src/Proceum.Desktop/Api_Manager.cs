using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Proceum.Models;
using RestSharp;
using RestSharp.Authenticators;
using static Proceum.Models.MyModels;

namespace Proceum
{
    class Api_Manager
    {
        //public static string BASE_URL = "http://35.154.212.120/proceum/index.php/"; ////staging
        public static string S3_URL = "https://s3.ap-south-1.amazonaws.com/appsquadz.proceum.com/"; ////staging
                                                                                                    //public static string BASE_URL = "http://14.97.144.246/AppSquadz/index.php/"; ////staging

        //public static string BASE_URL = "https://qa.proceum.com/AppSquadz/index.php/"; ////staging
        public static string VIDEO_URL = "https://dev.medvizz3d.com/AppSquadz/index.php/";

        public static string BASE_URL = "https://dev.medvizz3d.com/AppSquadz/index.php/";

        //Production
        //https://uat.proceum.com/web-api/public/api/get-videos-list 
        public static string BASE_URL_PRODUCTION = "https://uat.proceum.com/web-api/public/api/get-videos-list"; ////staging


        //Development
        //https://dev.medvizz3d.com/web-api/public/api/get-videos-list
        public static string BASE_URL_DEVELOPMENT = "https://dev.medvizz3d.com/web-api/public/api/get-videos-list"; ////staging

        //curriculum-level-details
        //https://dev.medvizz3d.com/web-api/public/api/curriculum-level-details
        public static string BASE_URL_CURRICULUM_LEVEL_DETAILS_DEVELOPMENT = "https://dev.medvizz3d.com/web-api/public/api/curriculum-level-details";

        //Old URL
        //https://dev.medvizz3d.com/AppSquadz/index.php
        //http://14.97.144.246/AppSquadz/index.php/hls"

       public async static Task<WholeCoursePositiveResponseFromServer1> GetVideolistWUserNToken(String ID,string Token)
        {
            string api_URL = "data_model/courses/exam/get-videos-list";
            //string api_URL =
            //BASE_URL = BASE_URL_PRODUCTION;
            BASE_URL = BASE_URL_DEVELOPMENT;
            //var client = new RestClient(BASE_URL + api_URL);
            var client = new RestClient(BASE_URL);
            var request = new RestRequest(Method.POST);
            //string postData = "{\"user_id\":\"" + User_Id + "\"}";
            //postData = Crypto.Encrypt(postData) + ":" + Convert.ToBase64String(Encoding.UTF8.GetBytes(Crypto.IV));
            //request.AddParameter("text/plain", postData, ParameterType.RequestBody);
            //  request.AddParameter("name", Token);
            request.AddParameter("user_id", ID);
            request.AddParameter("video_token", Token);

            //request.AddParameter("layer", Layer);
            //request.AddParameter("topic_id", Topicid);
            //request.AddHeader("master", "ADMIN");


            IRestResponse response = client.Execute(request);



            string data = response.Content;

            if (data == null | data == "")
            {
                string text;
                var fileStream = new FileStream(@"D:\MdAslam\MyProjects\Proceum\OpenExeFromBrowsers\ResponseData.txt", FileMode.Open, FileAccess.Read);
                using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
                {
                    text = streamReader.ReadToEnd();
                }
                if (text != null)
                {
                    data = text;
                }

            }

            try
            {
                WholeCoursePositiveResponseFromServer1 res = new WholeCoursePositiveResponseFromServer1();
                try
                {
                    res = JsonConvert.DeserializeObject<WholeCoursePositiveResponseFromServer1>(data);
                }
                catch
                {
                    ServerNegetiveResponseType1 res2 = JsonConvert.DeserializeObject<ServerNegetiveResponseType1>(data);
                    res.status = res2.status;
                    res.message = res2.message;
                }
                if (res.status == "true") res.status = "success";
                else res.status = "fail";
                return res;
            }
            catch (Exception ex)
            {
                //ex.ReportException(ex, "Sending sms");
                return new WholeCoursePositiveResponseFromServer1
                {
                    status = "error",
                    message = "An error occured while sending request to server, please check your internet connection and try again."
                    //message = "Get Course\n\n" + data,
                };
            }
        }

        public async static Task<WholeCoursePositiveResponseFromServer1> GetVideolist(String ID)
        {
             string api_URL = "data_model/courses/exam/get_video_data";
            //string api_URL =
            //BASE_URL = BASE_URL_PRODUCTION;
            BASE_URL = BASE_URL_DEVELOPMENT;
            var client = new RestClient(BASE_URL + api_URL);
            var request = new RestRequest(Method.POST);
            //string postData = "{\"user_id\":\"" + User_Id + "\"}";
            //postData = Crypto.Encrypt(postData) + ":" + Convert.ToBase64String(Encoding.UTF8.GetBytes(Crypto.IV));
            //request.AddParameter("text/plain", postData, ParameterType.RequestBody);
            //  request.AddParameter("name", Token);
            request.AddParameter("user_id", ID);

            //request.AddParameter("layer", Layer);
            //request.AddParameter("topic_id", Topicid);
            request.AddHeader("master", "ADMIN");

            IRestResponse response = client.Execute(request);



            string data = response.Content;

            if (data == null | data=="")
            {
                string text;
                var fileStream = new FileStream(@"D:\MdAslam\MyProjects\Proceum\OpenExeFromBrowsers\ResponseData.txt", FileMode.Open, FileAccess.Read);
                using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
                {
                    text = streamReader.ReadToEnd();
                }
                if (text != null)
                {
                    data = text;
                }

            }

            try
            {
                WholeCoursePositiveResponseFromServer1 res = new WholeCoursePositiveResponseFromServer1();
                try
                {
                    res = JsonConvert.DeserializeObject<WholeCoursePositiveResponseFromServer1>(data);
                }
                catch
                {
                    ServerNegetiveResponseType1 res2 = JsonConvert.DeserializeObject<ServerNegetiveResponseType1>(data);
                    res.status = res2.status;
                    res.message = res2.message;
                }
                if (res.status == "true") res.status = "success";
                else res.status = "fail";
                return res;
            }
            catch (Exception ex)
            {
                //ex.ReportException(ex, "Sending sms");
                return new WholeCoursePositiveResponseFromServer1
                {
                    status = "error",
                    message = "An error occured while sending request to server, please check your internet connection and try again."
                    //message = "Get Course\n\n" + data,
                };
            }
        }

        public async static Task<MyCurriculumData> GetContentOfVideoById(String AuthentiCationTokenStr,JSONContent jSONContent)
        {
            string RetMessage = string.Empty;

            var client = new RestClient("https://dev.medvizz3d.com/web-api/public/api/curriculum-level-details");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("config", "{\"date_format\":\"d-m-Y\",\"date_format_time\":\"d-m-Y h:i:s A\",\"timezone\":\"Asia/Kolkata\",\"language\":\"en\",\"color\":\"thm_one\"}");
            request.AddHeader("Authorization", "Bearer " + AuthentiCationTokenStr);
            request.AddHeader("Content-Type", "application/json");

            var body1 = JsonConvert.SerializeObject(jSONContent);

            var body = @"{
                    " + "\n" +
                                @"    ""content_id"":0,
                    " + "\n" +
                                @"    ""curriculum_id"": 1,
                    " + "\n" +
                                @"    ""is_individual"":0,
                    " + "\n" +
                                @"    ""level_id"": 3,
                    " + "\n" +
                                @"    ""level_parent_id"":1107 
                    " + "\n" +
            @"}";
            request.AddParameter("application/json", body1, ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
            //Console.WriteLine(response.Content);
            var data = response.Content;

            RetMessage = data.ToString();
            MyCurriculumData res = new MyCurriculumData();
            try
            {
                
                try
                {
                    res = JsonConvert.DeserializeObject<MyCurriculumData>(data);
                }
                catch
                {
                    ServerNegetiveResponseType1 res2 = JsonConvert.DeserializeObject<ServerNegetiveResponseType1>(data);
                    //res.status = res2.status;
                    //res.message = res2.message;
                }
                //if (res.status == "true") res.status = "success";
                //else res.status = "fail";
                return res;
            }
            catch (Exception ex)
            {
                //ex.ReportException(ex, "Sending sms");
                //return new WholeCoursePositiveResponseFromServer1
                //{
                //    status = "error",
                //    message = "An error occured while sending request to server, please check your internet connection and try again."
                //    //message = "Get Course\n\n" + data,
                //};
            }

            return res;
            //return RetMessage;

        }

        public async static Task<string> GetCourses(String ID, string Token)
        {
            string RetMessage = string.Empty;

            //https://dev.medvizz3d.com/web-api/public/api/curriculum-level-details

            //BASE_URL
            //https://dev.medvizz3d.com/AppSquadz/index.php/

            //BASE_URL_DEVELOPMENT
            //https://dev.medvizz3d.com/web-api/public/api/get-videos-list

            string api_URL = "data_model/courses/exam/get_video_data";

            string Config_JSONData = @"{
	                        'date_format': 'd-m-Y',
	                        'date_format_time': 'd-m-Y h:i:s A',
	                        'timezone': 'Asia/Kolkata',
	                        'language': 'en',
	                        'color': 'thm_one'
                        }";

            string JSONBody = @"{
                            ""content_id"":0,
                            ""curriculum_id"": 1,
                            ""is_individual"":0,
                            ""level_id"": 3,
                            ""level_parent_id"":1107 
                        }";

            //string api_URL =
            //BASE_URL = BASE_URL_PRODUCTION;
            BASE_URL = "https://dev.medvizz3d.com/web-api/public/api/";

            var client = new RestClient(BASE_URL);
            var request = new RestRequest("curriculum-level-details", Method.POST);
            request.Parameters.Clear();
            request.AddHeader("config", Config_JSONData);



            string token1 = "eyJ0eXAiOiJKV1QiLCJhbGciOiJSUzI1NiJ9.eyJhdWQiOiIxIiwianRpIjoiMjdkYmViYmMwOGJmMGE2N2Q0MDhjMTE4MDZhOTkzNTE1N2NiZGEzMDRkNjdkMGMwOWFiNTZjNDYxYmQxMDI1NmYwYjY2N2JlN2NlZGIzOTMiLCJpYXQiOjE2NTk5NTYxOTUuOTgwNDcyLCJuYmYiOjE2NTk5NTYxOTUuOTgwNDc4LCJleHAiOjE2OTE0OTIxOTUuOTU2NzY5LCJzdWIiOiIxMCIsInNjb3BlcyI6W119.rQEZe8FtpJdsWkgTssM41i-fTqqtDjfiRXARejNOOOS6Ceig9t96L1NZfikGKdaPhDIPMI8GkSWfxMd1ogS-gdoPWmYMHPVIH0aBML4xnKu8Pc4PJLaBiYDTKN468fh9_H42tM7184_XVahTQK71VyxMxaYMDzpqbtNE68vobEQrgcDRwY66D_-6GmsKqoOb5Aapi9CeOxH3qppg3AHaZQOISkwMbEFOWuSXxj1JCT7XSWlGjmBIO36smBlYCJBylARp0JY-vhVgugUsxfQjq3hMyDDOxdwKDEkaK-vgVZGOcozOMzu3gChPVGBFbKWwOaHbxamh3K5DxJY40bro0ckH0RNXtpCV4JR35GN0jLRQOQr4gUTzbNqK7yXiUk9k7CerlN-qKvxLhcjAIRfxnUvqG5Rsyin51Ajr8YElNkynYtS-_RNznH_QXkDQRVm0GWTvyqLSf3XeIYNayssRhdY5absbmpJPIO6VkJkiq2wZbQ3cUu7RePS-p5KYKp25APmJCxZR76J3J7HD-RzKMwi6XI2XnE0Jy3o361-7v5EAZJjLyQg377gs-F9xVbqwEqOaSfXVzYWhCstKaHOdasmIFjnq7aIQvvQQp7jY80_t3DO98pgc8h5D3mec_8lK55bq1SUOC1Lo4OAWT1ToDWRkYw9SBGJtzSz_TplGc-Q";
            //Body
            //request.AddBody("content_id", "0");
            //request.AddBody("curriculum_id", "1");
            //request.AddBody("is_individual", "0");
            //request.AddBody("level_id", "3");
            //request.AddBody("level_parent_id", "1107");

            //request.AddJsonBody(JSONBody);
            //request.AddBody(JSONBody);
            //request.AddHeader("Content-Type", "application/json");

            request.RequestFormat = DataFormat.Json;

            //request.AddJsonBody(request.JsonSerializer.Serialize(new { content_id = "0", curriculum_id = "1", is_individual="0", level_id="3", level_parent_id="1107" }));
            //request.AddParameter("application/json", JSONBody, ParameterType.RequestBody);
            //request.AddParameter("user_id", ID);
            //request.AddParameter("video_token", Token);

            request.AddHeader("Authorization",  string.Format("Bearer {0}", token1));
            

            var response = client.Execute(request);
            var data = response.Content;
            RetMessage = data.ToString();
            return RetMessage;
            //try
            //{
            //    WholeCoursePositiveResponseFromServer1 res = new WholeCoursePositiveResponseFromServer1();
            //    try
            //    {
            //        res = JsonConvert.DeserializeObject<WholeCoursePositiveResponseFromServer1>(data);
            //    }
            //    catch
            //    {
            //        ServerNegetiveResponseType1 res2 = JsonConvert.DeserializeObject<ServerNegetiveResponseType1>(data);
            //        res.status = res2.status;
            //        res.message = res2.message;
            //    }
            //    if (res.status == "true") res.status = "success";
            //    else res.status = "fail";
            //    return res;
            //}
            //catch (Exception ex)
            //{
            //    //ex.ReportException(ex, "Sending sms");
            //    return new WholeCoursePositiveResponseFromServer1
            //    {
            //        status = "error",
            //        message = "An error occured while sending request to server, please check your internet connection and try again."
            //        //message = "Get Course\n\n" + data,
            //    };
            //}


        }
        public async static Task<WholeCoursePositiveResponseFromServer1> GetContentOfVideo(String ID, string Token)
        {
            //https://dev.medvizz3d.com/web-api/public/api/curriculum-level-details

            //BASE_URL
            //https://dev.medvizz3d.com/AppSquadz/index.php/

            //BASE_URL_DEVELOPMENT
            //https://dev.medvizz3d.com/web-api/public/api/get-videos-list

            string api_URL = "data_model/courses/exam/get_video_data";

            string Config_JSONData = @"{
	                        'date_format': 'd-m-Y',
	                        'date_format_time': 'd-m-Y h:i:s A',
	                        'timezone': 'Asia/Kolkata',
	                        'language': 'en',
	                        'color': 'thm_one'
                        }";


            //string api_URL =
            //BASE_URL = BASE_URL_PRODUCTION;
            BASE_URL = BASE_URL_CURRICULUM_LEVEL_DETAILS_DEVELOPMENT;
          
            var client = new RestClient(BASE_URL);
            var request = new RestRequest(Method.POST);

            request.AddHeader("config", Config_JSONData);

            string token = "eyJ0eXAiOiJKV1QiLCJhbGciOiJSUzI1NiJ9.eyJhdWQiOiIxIiwianRpIjoiMjdkYmViYmMwOGJmMGE2N2Q0MDhjMTE4MDZhOTkzNTE1N2NiZGEzMDRkNjdkMGMwOWFiNTZjNDYxYmQxMDI1NmYwYjY2N2JlN2NlZGIzOTMiLCJpYXQiOjE2NTk5NTYxOTUuOTgwNDcyLCJuYmYiOjE2NTk5NTYxOTUuOTgwNDc4LCJleHAiOjE2OTE0OTIxOTUuOTU2NzY5LCJzdWIiOiIxMCIsInNjb3BlcyI6W119.rQEZe8FtpJdsWkgTssM41i-fTqqtDjfiRXARejNOOOS6Ceig9t96L1NZfikGKdaPhDIPMI8GkSWfxMd1ogS-gdoPWmYMHPVIH0aBML4xnKu8Pc4PJLaBiYDTKN468fh9_H42tM7184_XVahTQK71VyxMxaYMDzpqbtNE68vobEQrgcDRwY66D_-6GmsKqoOb5Aapi9CeOxH3qppg3AHaZQOISkwMbEFOWuSXxj1JCT7XSWlGjmBIO36smBlYCJBylARp0JY-vhVgugUsxfQjq3hMyDDOxdwKDEkaK-vgVZGOcozOMzu3gChPVGBFbKWwOaHbxamh3K5DxJY40bro0ckH0RNXtpCV4JR35GN0jLRQOQr4gUTzbNqK7yXiUk9k7CerlN-qKvxLhcjAIRfxnUvqG5Rsyin51Ajr8YElNkynYtS-_RNznH_QXkDQRVm0GWTvyqLSf3XeIYNayssRhdY5absbmpJPIO6VkJkiq2wZbQ3cUu7RePS-p5KYKp25APmJCxZR76J3J7HD-RzKMwi6XI2XnE0Jy3o361-7v5EAZJjLyQg377gs-F9xVbqwEqOaSfXVzYWhCstKaHOdasmIFjnq7aIQvvQQp7jY80_t3DO98pgc8h5D3mec_8lK55bq1SUOC1Lo4OAWT1ToDWRkYw9SBGJtzSz_TplGc-Q";

            request.AddHeader("Authorization", "Bearer {"+ token + "}");

            //Body
            request.AddBody("content_id", "0");
            request.AddBody("curriculum_id", "1");
            request.AddBody("is_individual", "0");
            request.AddBody("level_id", "3");
            request.AddBody("level_parent_id", "1107");

            request.AddParameter("user_id", ID);
            request.AddParameter("video_token", Token);
            //request.AddParameter("layer", Layer);
            //request.AddParameter("topic_id", Topicid);
            //request.AddHeader("master", "ADMIN");

            //httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", "Your Oauth token");
            //httpClient.DefaultRequestHeaders.Authorization =  new AuthenticationHeaderValue("Bearer", "Your Oauth token");
            //request.AddHeader("Authorization", string.Format("Bearer {0}", token));
            //request.AddHeader("Authorization", string.Format("Bearer {0}", token));

            //client.Authenticator= new HttpBasicAuthenticator();
            //client.AddDefaultHeader("Authorization", string.Format("Bearer {0}", token));

            request.AddHeader("Authorization", token);

            //request.AddHeader("authorization", string.Format("Bearer {0}", token));

            //client.Authenticator = new OAuth2AuthorizationRequestHeaderAuthenticator(token, "Bearer");

            IRestResponse response = client.Execute(request);

            

            string data = response.Content;

            if (data == null | data == "")
            {
                string text;
                var fileStream = new FileStream(@"D:\MdAslam\MyProjects\Proceum\OpenExeFromBrowsers\ResponseData.txt", FileMode.Open, FileAccess.Read);
                using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
                {
                    text = streamReader.ReadToEnd();
                }
                if (text != null)
                {
                    data = text;
                }

            }

            try
            {
                WholeCoursePositiveResponseFromServer1 res = new WholeCoursePositiveResponseFromServer1();
                try
                {
                    res = JsonConvert.DeserializeObject<WholeCoursePositiveResponseFromServer1>(data);
                }
                catch
                {
                    ServerNegetiveResponseType1 res2 = JsonConvert.DeserializeObject<ServerNegetiveResponseType1>(data);
                    res.status = res2.status;
                    res.message = res2.message;
                }
                if (res.status == "true") res.status = "success";
                else res.status = "fail";
                return res;
            }
            catch (Exception ex)
            {
                //ex.ReportException(ex, "Sending sms");
                return new WholeCoursePositiveResponseFromServer1
                {
                    status = "error",
                    message = "An error occured while sending request to server, please check your internet connection and try again."
                    //message = "Get Course\n\n" + data,
                };
            }
        }

        public async static Task<WholeCoursePositiveResponseFromServer1> UpdateRemainingTimeOfVideo(string user_id, string V_id, string view_time, string remaining_time, string start_date, string end_date)
        {


            string api_URL = "data_model/courses/course/update_video_view_time";
            //BASE_URL = BASE_URL_PRODUCTION;
            BASE_URL = BASE_URL_DEVELOPMENT;
            var client = new RestClient(BASE_URL + api_URL);
            var request = new RestRequest(Method.POST);

            request.AddParameter("user_id", user_id);
            request.AddParameter("video_id", V_id);
            request.AddParameter("watch_time", view_time);
            request.AddParameter("remaining_time", remaining_time);
            request.AddParameter("start_date", start_date);

            request.AddParameter("end_date", end_date);
            request.AddParameter("platform", "3"); //for Window => 3 
            request.AddHeader("master", "ADMIN");

            IRestResponse response = client.Execute(request);

            string data = response.Content;


            try
            {
                WholeCoursePositiveResponseFromServer1 res = new WholeCoursePositiveResponseFromServer1();
                try
                {
                    res = JsonConvert.DeserializeObject<WholeCoursePositiveResponseFromServer1>(data);
                }
                catch
                {
                    ServerNegetiveResponseType1 res2 = JsonConvert.DeserializeObject<ServerNegetiveResponseType1>(data);
                    res.status = res2.status;
                    res.message = res2.message;
                }
                if (res.status == "true") res.status = "success";
                else res.status = "fail";
                return res;
            }
            catch (Exception ex)
            {

                return new WholeCoursePositiveResponseFromServer1
                {
                    status = "error",
                    message = "An error occured while sending request to server, please check your internet connection and try again."

                };
            }
        }
    }
}
