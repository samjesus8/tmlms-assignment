using Newtonsoft.Json.Linq;

namespace TmLms.QuizAnswerManager
{
    public class QuizManager
    {
        public string QuestionName { get; set; }

        //Single Answer Variables
        public string QuestionAnswerS { get; set; }

        //Multiple Choice Variables
        public string QuestionAnswerMC1 { get; set; }
        public string QuestionAnswerMC2 { get; set; }
        public string QuestionAnswerMC3 { get; set; }
        public string QuestionAnswerMC4 { get; set; }

        //Multi Answer Variables
        public string[] MultiAnswers { get; set; }

        //True or False Variables
        public bool isTrue { get; set; }
        public bool isFalse { get; set; }

        //Error Return variables
        public string Error { get; set; }

        public QuizManager() { }

        public bool StoreQuestion(QuizManager quizObject)
        {
            try 
            {
                string path = System.AppDomain.CurrentDomain.BaseDirectory + "/QuizAnswerManager/Answers.json"; //Getting the path to the JSON file in bin folder
                var json = File.ReadAllText(path);

                var jsonObject = JObject.Parse(json); //Parsing using newtonsoft
                var members = jsonObject["members"].ToObject<List<QuizManager>>(); //Converting members array into list

                members.Add(quizObject); //Adding our question/answers to this list

                jsonObject["members"] = JArray.FromObject(members); //Compiling everything together and writing back to the JSON file
                File.WriteAllText(path, jsonObject.ToString());
                return true;
            }
            catch (Exception ex) 
            {
                Error = ex.Message;
                return false;
            }
        }
    }

    class JSONObject 
    {
        public string answersCategory { get; set; }
        public Member[] members { get; set; }
    }
    class Member 
    {
        public string QuestionName { get; set; }
        public string QuestionAnswerS { get; set; }
        public string QuestionAnswerMC1 { get; set; }
        public string QuestionAnswerMC2 { get; set; }
        public string QuestionAnswerMC3 { get; set; }
        public string QuestionAnswerMC4 { get; set; }
        public string[] MultiAnswers { get; set; }
        public bool isTrue { get; set; }
        public bool isFalse { get; set; }
    }
}
