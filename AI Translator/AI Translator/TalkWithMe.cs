using OpenAI_API;
using System;
using System.Threading.Tasks;

namespace AI_Translator
{
    internal class TalkWithMe
    {
        OpenAIAPI openAI;
        string result;
        public string prompt;
        async public Task<string> talkToMe(string inputData)
        {
            prompt = inputData;
            return await executeAI();
        }
        async private Task<string> executeAI()
        {
            openAI = new OpenAIAPI("Tutaj należy wprowadzić klucz API"); //Niestety nie można udostepnić klucza wrzucając projekt na GITHUB

            try
            {
                var completion = await openAI.Completions.CreateCompletionAsync(
                    model: "text-davinci-003",
                    prompt: prompt,
                    max_tokens: 200,
                    temperature: 0.2
                );
                result = completion.ToString();
            }
            catch (Exception ex)
            {
                result = ex.Message;
            }
            return result;
        }
    }
}
