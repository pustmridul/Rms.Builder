namespace Rms.Builder.Application.Model
{
    public class ItemModel
    {
    }
    public class ItemReq
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
    }
    public class ItemVm : Result<ItemReq>
    {

    }
    public class ItemListVm : ListResult<ItemReq>
    {

    }

}
