interface Userfunctioninterface
{
    public bool Registeruser(Userregisterclass registernewuser, List<Userregisterclass> checkreg);

    public List<Userregisterclass> Getallusers(List<Userregisterclass> checkallusers);

    public Userregisterclass Getoneuser(int userid, List<Userregisterclass> checkoneuser);

    public bool Updateuser(Userregisterclass updatereg, List<Userregisterclass> updateuser);

    public bool Deleteuser(int userid, List<Userregisterclass> deleteuser);










}