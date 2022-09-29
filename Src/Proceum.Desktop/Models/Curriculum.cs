using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Proceum.Models.MyModels;

namespace Proceum.Models
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class AnswerImage
    {
        public string file_path { get; set; }
        public string path { get; set; }
    }

    public class Breadcome
    {
        public string name { get; set; }
        public string id { get; set; }
        public string level_id { get; set; }
    }

    public class Case
    {
        public int id { get; set; }
        public string question { get; set; }
        public string question_string { get; set; }
        public string explanation { get; set; }
        public int q_type { get; set; }
        public string q_source { get; set; }
        public string q_source_value { get; set; }
        public string s_no { get; set; }
        public List<string> correct_answers { get; set; }
        public List<Option> options { get; set; }
    }

    public class Content
    {
        public string title { get; set; }
        public string reading_time { get; set; }
        public object intro_videos { get; set; }
        public object main_videos { get; set; }
        public string main_content { get; set; }
        public List<object> attachments { get; set; }
        public List<object> images { get; set; }
        public string learning_obj_content { get; set; }
        public string learning_notes_content { get; set; }
        public string external_ref_content { get; set; }
        public string last_updated { get; set; }
    }

    public class ContentList
    {
        public int content_id { get; set; }
        public string content_title { get; set; }
        public int is_paid { get; set; }
        public int? reading_time { get; set; }
        public string updated_at { get; set; }
    }

    public class Curriculum
    {
        public int pk_id { get; set; }
        public string curriculumn_name { get; set; }
    }

    public class Data
    {
        public Curriculum curriculum { get; set; }
        public List<ContentList> content_list { get; set; }
        public int selected_content_id { get; set; }
        public List<object> statistics { get; set; }
        public List<Video> videos { get; set; }
        public List<LearningNote> learning_notes { get; set; }
        public List<Highyield> highyields { get; set; }
        public List<Mcq> mcqs { get; set; }
        public List<ShortAnswer> short_answers { get; set; }
        public List<Case> cases { get; set; }
        public Content content { get; set; }
        public string bucket_url { get; set; }
        public string xt { get; set; }
        public List<FlashCard> flash_cards { get; set; }
        public List<object> materials { get; set; }
        public List<HInt> h_int { get; set; }
        public List<VInt> v_int { get; set; }
        public Settings settings { get; set; }
    }

    public class FlashCard
    {
        public int pk_id { get; set; }
        public string question_text { get; set; }
        public string answer_text { get; set; }
        public List<QuestionImage> question_images { get; set; }
        public List<AnswerImage> answer_images { get; set; }
    }

    public class Highyield
    {
        public string heading_name { get; set; }
        public List<Note> notes { get; set; }
    }

    public class HInt
    {
        public int level_id { get; set; }
        public string level_code { get; set; }
        public int curriculum_id { get; set; }
        public int curriculum_label_id { get; set; }
    }

    public class LearningNote
    {
        public string heading_name { get; set; }
        public List<Note> notes { get; set; }
    }

    public class Mcq
    {
        public int id { get; set; }
        public string question_string { get; set; }
        public string question { get; set; }
        public string explanation { get; set; }
        public int q_type { get; set; }
        public string q_source { get; set; }
        public string q_source_value { get; set; }
        public string s_no { get; set; }
        public List<string> correct_answers { get; set; }
        public List<Option> options { get; set; }
    }

    public class Note
    {
        public int pk_id { get; set; }
        public string title { get; set; }
        public string learning_notes { get; set; }
        public int? heading_id { get; set; }
        public string heading_name { get; set; }
        public string highyield_notes { get; set; }
    }

    public class Option
    {
        public int pk_id { get; set; }
        public string option_text { get; set; }
        public string option_explanation { get; set; }
        public string option_image { get; set; }
        public object option_video { get; set; }
    }

    public class QuestionImage
    {
        public string file_path { get; set; }
        public string path { get; set; }
    }

    public class MyCurriculumData
    {
        public Data data { get; set; }
        public List<Breadcome> breadcome { get; set; }
        public bool error { get; set; }
    }

    public class Settings
    {
        public int user_id { get; set; }
        public int font_size { get; set; }
        public int view_type { get; set; }
        public bool buzz_words { get; set; }
    }

    public class ShortAnswer
    {
        public int id { get; set; }
        public string question { get; set; }
        public string question_string { get; set; }
        public string explanation { get; set; }
        public int q_type { get; set; }
        public string q_source { get; set; }
        public string q_source_value { get; set; }
        public string s_no { get; set; }
        public List<string> correct_answers { get; set; }
        public List<Option> options { get; set; }
    }

    public class Video
    {
        public int pk_id { get; set; }
        public string video_section { get; set; }
        public string module_title { get; set; }
        public string video_type { get; set; }
        public string video_source { get; set; }
        public int video_order { get; set; }
    }

    public class VInt
    {
        public int level_id { get; set; }
        public string level_code { get; set; }
        public int curriculum_id { get; set; }
        public int curriculum_label_id { get; set; }
    }



}
