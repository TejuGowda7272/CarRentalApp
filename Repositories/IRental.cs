using CarRentalApp.Models;

namespace CarRentalApp.Repositories
{
    public interface IRental
    {
        //CRUD
        Task<IEnumerable<Rental>> GetAllAsync();
        Task<Rental?> GetByIdAsync(int id);

        Task AddAsync(Rental rental);

        Task UpdateAsync(Rental rental);

        Task DeleteAsync(int id);

        //Queries

        Task<Rental> BookAsync(int carId, int CustomerId, DateTime start, DateTime end);

        Task<Rental> CheckInAsync(int rentalId);

        Task<Rental> CheckOutAsync(int rentalId);

        Task<Rental> CancelAsync(int rentalId);
    }
}
