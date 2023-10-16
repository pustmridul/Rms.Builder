using MediatR;
using Rms.Builder.Application.Model;

namespace Rms.Builder.Application.Queries
{
    public class GetAllItemQuery : IRequest<ItemListVm>
    {
        public int Id { get; set; }
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
    }


    public class GetAllItemQueryHandler : IRequestHandler<GetAllItemQuery, ItemListVm>
    {
        private readonly IAppDbContext _context;
     
        public GetAllItemQueryHandler(IAppDbContext context)
        {
            _context = context;          
        }

        public async Task<ItemListVm> Handle(GetAllItemQuery request, CancellationToken cancellationToken)
        {
            var result = new ItemListVm();
            result.Messages.Add("GetAll");
           
            return result;
        }
    }
}
