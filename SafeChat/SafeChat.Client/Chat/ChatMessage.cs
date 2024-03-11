namespace SafeChat.Client.Chat
{
    public class ChatMessage
    {
        public ChatMessage(string user, string message) { 
        
            User = user;
            Message = message;
        
        }
        public string User { get; set; } = String.Empty;
        public string Message { get; set; } = String.Empty;
    }
}
