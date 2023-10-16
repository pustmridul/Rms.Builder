using MediatR;
using Rms.Builder.Application.Model;

namespace Rms.Builder.Application.Queries
{
    public class GetItemByIdQuery : IRequest<ItemVm>
    {
        public int Id { get; set; }
    }

    public class GetItemByIdQueryHandler : IRequestHandler<GetItemByIdQuery, ItemVm>
    {
        private readonly IAppDbContext _context;

        public GetItemByIdQueryHandler(IAppDbContext context)
        {
            _context = context;
        }

        public async Task<ItemVm> Handle(GetItemByIdQuery request, CancellationToken cancellationToken)
        {
            var result = new ItemVm();
            result.Messages.Add("Get by id");

            return result;
        }
    }
}
