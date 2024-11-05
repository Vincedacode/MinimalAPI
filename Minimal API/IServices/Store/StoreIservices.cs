interface StoreFunctionInterface
{
    public bool RegisterStore(RegisterStoreClass registerstore, List<RegisterStoreClass> storedb);

    public List<RegisterStoreClass> Getallstores(List<RegisterStoreClass> storedb);

    public RegisterStoreClass Getonestore(int storeid, List<RegisterStoreClass> storedb);

    public bool Updatestore(RegisterStoreClass storeupdate, List<RegisterStoreClass> storedb);

    public bool Deletestore(int storeid, List<RegisterStoreClass> storedb);










}