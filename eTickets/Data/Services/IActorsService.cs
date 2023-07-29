using eTickets.Models;

namespace eTickets.Data.Services
{
    public interface IActorsService
    {
        //here we define retun type, method, paramters 

                //Task is added cos we are using async to get all actors from the ActorsController.cs
        Task<IEnumerable<Actor>> GetAllAsync();

               //method to get a single Actor with parameter int
        Task <Actor> GetByIdAsync(int id);
                   
              //adding data to database and return nothing 
        Task AddAsync(Actor actor);

               //method to update data
        Task <Actor> UpdateAsync(int id, Actor newActor);

        //last method delete
        Task DeleteAsync(int id);
    }
}
