
class StoreFunctionImplementation : StoreFunctionInterface
{
    public bool Deletestore(int storeid, List<RegisterStoreClass> storedb)
    {
        var isstoreexisting = storedb.Contains(storedb.Where(r => r.StoreId == storeid).First());
        if (isstoreexisting)
        {
            storedb.Remove(storedb.Where(r => r.StoreId == storeid).First());
            return true;
        }
        else
        {
            return false;
        }
    }

    public List<RegisterStoreClass> Getallstores(List<RegisterStoreClass> storedb)
    {
        return storedb.ToList();
    }

    public RegisterStoreClass Getonestore(int storeid, List<RegisterStoreClass> storedb)
    {
        return storedb.Where(r => r.StoreId == storeid).FirstOrDefault();
    }

    public bool RegisterStore(RegisterStoreClass registerstore, List<RegisterStoreClass> storedb)
    {
        storedb.Add(registerstore);
        return true;
    }

    public bool Updatestore(RegisterStoreClass storeupdate, List<RegisterStoreClass> storedb)
    {
        var update = storedb.Where(r => r.MakerName == storeupdate.MakerName).First();
        if (update != null)
        {
            storedb.Remove(storedb.Where(r => r.MakerName == storeupdate.MakerName).First());
            update = storeupdate;
            storedb.Add(storeupdate);
            return true;
        }
        else
        {
            return false;
        }
    }
}