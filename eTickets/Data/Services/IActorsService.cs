using eTickets.Models;

namespace eTickets.Data.Services
{
    public interface IActorsService
    {
        //here we define retun type, method, paramters 

                //Task is added cos we are using async to get all actors from the ActorsController.cs
        Task<IEnumerable<Actor>> GetAll();

               //method to get a single Actor with parameter int
        Actor GetById(int id);
                   
              //adding data to database and return nothing 
        void Add(Actor actor);

               //method to update data
        Actor Update(int id, Actor newActor);

              //last method delete
        void Delete(int id);
    }
}
