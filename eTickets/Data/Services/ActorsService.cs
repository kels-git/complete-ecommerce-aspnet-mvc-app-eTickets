using eTickets.Models;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Data.Services
{
    public class ActorsService : IActorsService
    {

        private readonly AppDBContext _context;

        //inject the AppDBContext in the constructor created
        public ActorsService(AppDBContext context)
        {
            _context = context;       
        }
        public async Task AddAsync(Actor actor)
        {
          await  _context.Actors.AddAsync(actor);
          await  _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            //throw new NotImplementedException();
            var result = await _context.Actors.FirstOrDefaultAsync(n => n.ActorId == id);
               _context.Actors.Remove(result);
                await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Actor>> GetAllAsync()
        {
            //throw new NotImplementedException();
            var result = await _context.Actors.ToListAsync();
            return result;
        }

        public async Task<Actor> GetByIdAsync(int id)
        {
            //throw new NotImplementedException();
                var result = await _context.Actors.FirstOrDefaultAsync(n => n.ActorId == id);
                return result;
        }

        public async Task<Actor> UpdateAsync(int id, Actor newActor)
        {
            //throw new NotImplementedException();
             _context.Update(newActor);
            await _context.SaveChangesAsync();
            return newActor;
        }

    }
}
