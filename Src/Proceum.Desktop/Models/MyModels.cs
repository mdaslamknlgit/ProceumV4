using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proceum.Models
{
    class MyModels
    {
        public class WholeCoursePositiveResponseFromServer1
        {
            public string status { get; set; }
            public string message { get; set; }
            // public WholeCourseData1 data { get; set; }
            public List<Datum> data { get; set; }
        }
        public class Datum
        {
            public string id { get; set; }
            public string title { get; set; }
            public string thumbnail_url { get; set; }
            public string actual_video_time { get; set; }
            public string remaining_time { get; set; } 
            public string total_watch_time { get; set; }
            public string token { get; set; }
            public string original_video_url { get; set; }

            public string user_name { get; set; }
        }
        public class WholeCourseData1
        {

            public List<StreamList> list { get; set; }
        }
        public class StreamList
        {
            public string id { get; set; }
            public string delivery_type { get; set; }
            public string file_url { get; set; }
            public string is_vod { get; set; }
            public string token { get; set; }
            public string thumbnail_url { get; set; }
            public List<VODFileDownloadInfo> encrypted_urls { get; set; }
            public string title { get; set; }
            public string description { get; set; }
            public string file_type { get; set; }
            public string video_type { get; set; }
            public string is_locked { get; set; }
            public string is_live { get; set; }
            public string chat_node { get; set; }
            public string live_status { get; set; }
            public string playtime { get; set; }
            public string remaining_time { get; set; }
            public string live_on { get; set; }
            public string decrypt_video_url { get; set; }
            public string size { get; set; }
            public List<BookmarkData> bookmark { get; set; }

        }
        public class VODFileDownloadInfo
        {
            public string url { get; set; }
            public string name { get; set; }
            public string size { get; set; }
        }
        public class BookmarkData
        {
            public string id { get; set; }
            public string time { get; set; }
            public string info { get; set; }
        }

        public class ServerNegetiveResponseType1
        {
            public string status { get; set; }
            public string message { get; set; }
            public List<object> data { get; set; }
        }
    }
}
