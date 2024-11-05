interface ChatFunctionInterface
{
    public bool Newchat(RegisterChatClass newchat, List<RegisterChatClass> chatdb);

    public List<RegisterChatClass> Getallchats(List<RegisterChatClass> chatdb);

    public RegisterChatClass Getonechat(int chatid, List<RegisterChatClass> chatdb);

    public bool Editchat(RegisterChatClass Editchat, List<RegisterChatClass> chatdb);

    public bool Deletechat(int chatid, List<RegisterChatClass> chatdb);










}