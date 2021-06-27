using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Persistence;

namespace API.Controllers
{
    [ApiController]
    [Route("api/channels")]
    public class ChannelsController: ControllerBase
    {
        private DataContext _context;

        public ChannelsController(DataContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }
        public IActionResult Get()
        {
            var channels = _context.Channels.ToList();
            return Ok(channels);
        }
        [HttpGet("{Id}")]
        public IActionResult GetItem(Guid Id)
        {
            var channel = _context.Channels.FirstOrDefault(channel => channel.id == Id);
            return Ok(channel);
        }
    }
}