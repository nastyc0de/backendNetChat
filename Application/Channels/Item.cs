using System;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using Application.Errors;
using Domain;
using MediatR;
using Persistence;

namespace Application.Channels
{
    public class Item
    {
        public class Query: IRequest<Channel>
        {
            public Guid id { get; set; }
        }

        public class Handler : IRequestHandler<Query, Channel>
        {
            private DataContext _context;

            public Handler(DataContext context)
            {
                _context = context ?? throw new ArgumentNullException(nameof(context));
            }
            public async Task<Channel> Handle(Query request, CancellationToken cancellationToken)
            {
                var channel = await _context.Channels.FindAsync(request.id);       
                if (channel == null)
                {
                    throw new RestException(HttpStatusCode.NotFound, new {channel = "Not found"});
                }
                return channel;
            }
        }
    }
}