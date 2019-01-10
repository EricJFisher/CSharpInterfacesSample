namespace PointOfSale.Interfaces
{
    public interface IRental
    {
        void Rent(int id);
        void Return(int id);
    }
}
