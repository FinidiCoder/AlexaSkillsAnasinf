

namespace AlexaSkillsAnasinf.Utils
{
    public class AlexaActions
    {
        public static SkillResponse MakeSkillResponse(string responseText)
        {
            return Alexa.NET.ResponseBuilder.Tell(responseText);
        }
        public static SkillResponse AskSkillResponse(string responseText)
        {
            var reprompt = new Reprompt("No he encontrado nada");
            return Alexa.NET.ResponseBuilder.Ask(responseText, reprompt);
        }
    }
}
