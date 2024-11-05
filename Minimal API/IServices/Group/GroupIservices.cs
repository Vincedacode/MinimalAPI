interface GroupFunctionInterface
{
    public bool RegisterGroup(RegisterGroupClass registernewgroup, List<RegisterGroupClass> groupdb);

    public List<RegisterGroupClass> Getallgroups(List<RegisterGroupClass> groupdb);

    public RegisterGroupClass Getonegroup(int groupid, List<RegisterGroupClass> groupdb);

    public bool Updategroup(RegisterGroupClass updategroup, List<RegisterGroupClass> groupdb);

    public bool DeleteGroup(int groupid, List<RegisterGroupClass> groupdb);








}