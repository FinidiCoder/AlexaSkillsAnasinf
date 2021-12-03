

using AlexaSkillsAnasinf.Utils;

namespace AlexaSkillsAnasinf.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AlexaController : ControllerBase
    {
        [HttpGet]
        public string TestMethod()
        {
            return "Hola Mundo!";
        }
        [HttpPost]
        public SkillResponse FunctionHandler(SkillRequest request)
        {
            try
            {
                var requestType = request.GetRequestType();
                if (requestType == typeof(LaunchRequest))
                {
                    return AlexaActions.AskSkillResponse("Dime Gorka, ¿que quieres hacer?");
                }

                if (requestType == typeof(IntentRequest))
                {
                    var intentRequest = request.Request as IntentRequest;
                    switch (intentRequest?.Intent.Name)
                    {
                        case "PresenciaIntent":
                            string slotValuesCombined;
                            var slotValue = intentRequest.Intent.Slots["persona"].SlotValue;

                            if (slotValue.Value != null)
                            {
                                slotValuesCombined = slotValue.Value;
                            }
                            else
                            {
                                var values = slotValue.Values;
                                var valueStrings = values.ToList().Select(sv => sv.Value).ToList();
                                slotValuesCombined = string.Join(",", valueStrings);
                            }
                            return AlexaActions.MakeSkillResponse($"Quieres hacer el fichaje de {slotValuesCombined}");
                        default:
                            return AlexaActions.MakeSkillResponse("Fallo al determinar el intent " + intentRequest?.Intent.Name);
                    }
                }
                else
                {
                    return AlexaActions.MakeSkillResponse("Fallo al determinar el intent " + requestType.Name);
                }
            }
            catch (Exception ex)
            {
                return AlexaActions.MakeSkillResponse("Algo ha ido mal: "+ ex.Message );
            }
        }
    }
}
