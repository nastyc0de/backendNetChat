using System;
using System.Threading;
using System.Threading.Tasks;
using Domain;
using MediatR;
using Persistence;

namespace Application.Channels
{
    public class Create
    {
         public class Command : IRequest
        {
            public Guid id { get; set; }
            public string name { get; set; }
            public string description { get; set; }
        }
        public class Handler : IRequestHandler<Command>
        {
            private DataContext _context;

            public Handler(DataContext context)
            {
                _context = context ?? throw new ArgumentNullException(nameof(context));
            }
            public async Task<Unit> Handle(Command request, CancellationToken cancellationToken)
            {
                var newChannel = new Channel
                {
                    id = request.id,
                    name = request.name,
                    description = request.description
                };
                _context.Channels.Add(newChannel);
                var success = await _context.SaveChangesAsync() > 0;
                if (success)
                {
                    return Unit.Value; 
                }
                 throw new Exception("Ocurrio un problema al guardar los datos");  
            }
        }
    }
}