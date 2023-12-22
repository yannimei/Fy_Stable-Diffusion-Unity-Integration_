using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using OpenAI;

public class ChatGptForPrompt : MonoBehaviour
{
    private OpenAIApi openAI = new OpenAIApi();
    private List<ChatMessage> messages = new List<ChatMessage>();

    public Text output;

    // Start is called before the first frame update
    public async void AskChatGPT(Text newText)
    {
        ChatMessage newMessage = new ChatMessage();
        newMessage.Content = newText.text;
        

        newMessage.Role = "user";

        messages.Add(newMessage);

        CreateChatCompletionRequest request = new CreateChatCompletionRequest();
        request.Messages = messages;
        request.Model = "gpt-3.5-turbo";

        var response = await openAI.CreateChatCompletion(request);

        if(response.Choices != null && response.Choices.Count > 0)
        {
            var chatResponse = response.Choices[0].Message;
            messages.Add(chatResponse);

            //Debug.Log(chatResponse.Content);
            output.text = chatResponse.Content;
        }
    }


}
