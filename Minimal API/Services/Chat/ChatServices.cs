
class ChatFunctionImplementation : ChatFunctionInterface
{
    public bool Deletechat(int chatid, List<RegisterChatClass> chatdb)
    {
        var delchat = chatdb.Contains(chatdb.Where(r => r.ChatId == chatid).First());
        if (delchat)
        {
            chatdb.Remove(chatdb.Where(r => r.ChatId == chatid).First());
            return true;
        }
        else
        {
            return false;
        }
    }

    public bool Editchat(RegisterChatClass Editchat, List<RegisterChatClass> chatdb)
    {
        var update = chatdb.Where(r => r.SenderId == Editchat.SenderId).First();
        if (update != null)
        {
            chatdb.Remove(chatdb.Where(r => r.SenderId == Editchat.SenderId).First());
            update = Editchat;
            chatdb.Add(Editchat);
            return true;
        }
        else
        {
            return false;
        }
    }

    public List<RegisterChatClass> Getallchats(List<RegisterChatClass> chatdb)
    {
        return chatdb.ToList();
    }

    public RegisterChatClass Getonechat(int chatid, List<RegisterChatClass> chatdb)
    {
        return chatdb.Where(r => r.ChatId == chatid).FirstOrDefault();
    }

    public bool Newchat(RegisterChatClass newchat, List<RegisterChatClass> chatdb)
    {
        chatdb.Add(newchat);
        return true;
    }
}