
class Groupfunctionimplementation : GroupFunctionInterface
{
    public bool DeleteGroup(int groupid, List<RegisterGroupClass> groupdb)
    {
        var isgroupexisting = groupdb.Contains(groupdb.Where(r => r.GroupId == groupid).First());
        if (isgroupexisting)
        {
            groupdb.Remove(groupdb.Where(r => r.GroupId == groupid).First());
            return true;
        }
        return false;
    }

    public List<RegisterGroupClass> Getallgroups(List<RegisterGroupClass> groupdb)
    {
        return groupdb.ToList();
    }

    public RegisterGroupClass Getonegroup(int groupid, List<RegisterGroupClass> groupdb)
    {
        return groupdb.Where(r => r.GroupId == groupid).FirstOrDefault();
    }

    public bool RegisterGroup(RegisterGroupClass registernewgroup, List<RegisterGroupClass> groupdb)
    {
        groupdb.Add(registernewgroup);
        return true;
    }

    public bool Updategroup(RegisterGroupClass updategroup, List<RegisterGroupClass> groupdb)
    {
        var update = groupdb.Where(r => r.GroupOwner == updategroup.GroupOwner).First();
        if (update != null)
        {
            groupdb.Remove(groupdb.Where(r => r.GroupOwner == updategroup.GroupOwner).First());
            update = updategroup;
            groupdb.Add(updategroup);
            return true;
        }
        else
        {
            return false;
        }
    }
}