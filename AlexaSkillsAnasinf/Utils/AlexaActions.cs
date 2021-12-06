using Alexa.NET;

namespace AlexaSkillsAnasinf.Utils;

public class AlexaActions
{
    public static SkillResponse MakeSkillResponse(string responseText)
    {
        return ResponseBuilder.Tell(responseText);
    }

    public static SkillResponse AskSkillResponse(string responseText)
    {
        var reprompt = new Reprompt("No he encontrado nada");
        return ResponseBuilder.Ask(responseText, reprompt);
    }
}