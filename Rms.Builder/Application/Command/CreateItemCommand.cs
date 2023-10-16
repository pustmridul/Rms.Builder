using MediatR;
using Rms.Builder.Application.Model;
using Rms.Builder.Entity;

namespace Rms.Builder.Application.Command
{
    public class CreateItemCommand : IRequest<ItemVm>
    {
        public ItemReq Model { get; set; } = new ItemReq();
    }

    public class CreateItemCommandHandler : IRequestHandler<CreateItemCommand, ItemVm>
    {
        private readonly IAppDbContext _context;

        public CreateItemCommandHandler(IAppDbContext context)
        {
            _context = context;
        }
        public async Task<ItemVm> Handle(CreateItemCommand request, CancellationToken cancellation)
        {
            var result= new ItemVm();
            result.Messages.Add("Created Item Success");
            return result;
        }
    }
}
