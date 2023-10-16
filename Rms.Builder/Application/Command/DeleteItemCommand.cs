using MediatR;

namespace Rms.Builder.Application.Command
{
    public class DeleteItemCommand : IRequest<Result>
    {
        public int Id { get; set; }
    }


    public class DeleteCollegeCommandHandler : IRequestHandler<DeleteItemCommand, Result>
    {
        private readonly IAppDbContext _context;
    
        public DeleteCollegeCommandHandler(IAppDbContext context)
        {
            _context = context;
           
        }

        public async Task<Result> Handle(DeleteItemCommand request, CancellationToken cancellationToken)
        {
          var result= new Result();
            result.Messages.Add("Remove Success");
            return result;
        }
    }
}
