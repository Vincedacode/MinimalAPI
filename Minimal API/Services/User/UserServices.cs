
class Userfunctionimplementation : Userfunctioninterface
{
    public bool Deleteuser(int userid, List<Userregisterclass> deleteuser)
    {
        var isuserexisting = deleteuser.Contains(deleteuser.Where(r => r.Userid == userid).First());
        if (isuserexisting)
        {
            deleteuser.Remove(deleteuser.Where(r => r.Userid == userid).First());
            return true;
        }
        else
        {
            return false;
        }
    }

    public List<Userregisterclass> Getallusers(List<Userregisterclass> checkallusers)
    {
        return checkallusers.ToList();
    }

    public Userregisterclass Getoneuser(int userid, List<Userregisterclass> checkoneuser)
    {
        return checkoneuser.Where(r => r.Userid == userid).FirstOrDefault();
    }

    public bool Registeruser(Userregisterclass registernewuser, List<Userregisterclass> checkreg)
    {
        checkreg.Add(registernewuser);
        return true;
    }

    public bool Updateuser(Userregisterclass updatereg, List<Userregisterclass> updateuser)
    {
        var update = updateuser.Where(r => r.EmailAddress == updatereg.EmailAddress).First();
        if (update != null)
        {
            updateuser.Remove(updateuser.Where(r => r.EmailAddress == updatereg.EmailAddress).First());
            update = updatereg;
            updateuser.Add(updatereg);
            return true;
        }
        else
        {
            return false;
        }
    }
}