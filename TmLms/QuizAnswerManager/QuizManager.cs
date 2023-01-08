using Newtonsoft.Json.Linq;

namespace TmLms.QuizAnswerManager
{
    public class QuizManager
    {
        public string QuestionName { get; set; }
        public string QuestionType { get; set; } //TOF - True or False, MA - Multi Answer, S - Short Answer, MC - Multiple Choice

        //Single Answer Variables
        public string QuestionAnswerS { get; set; }

        //Multiple Choice Variables
        public string QuestionAnswerMC1 { get; set; }
        public string QuestionAnswerMC2 { get; set; }
        public string QuestionAnswerMC3 { get; set; }
        public string QuestionAnswerMC4 { get; set; }

        //Multiple Choice Boolean Variables
        public bool MC1 { get; set; }
        public bool MC2 { get; set; }
        public bool MC3 { get; set; }
        public bool MC4 { get; set; }

        //Multi Answer Variables
        public bool[] MultiAnswers { get; set; } //[0] - OPTION 1, [1] - OPTION 2, [2] - OPTION 3, [3] - OPTION 4

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

        public (Dictionary<int, QuizManager>, bool) LoadQuestions() //Returns Dictionary of Questions + True/False to make sure operation was successful
        {
            using (StreamReader sr = new StreamReader(System.AppDomain.CurrentDomain.BaseDirectory + "/QuizAnswerManager/Answers.json")) 
            {
                var json = sr.ReadToEnd();
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
        public bool MC1 { get; set; }
        public bool MC2 { get; set; }
        public bool MC3 { get; set; }
        public bool MC4 { get; set; }
        public bool[] MultiAnswers { get; set; }
        public bool isTrue { get; set; }
        public bool isFalse { get; set; }
    }
}
