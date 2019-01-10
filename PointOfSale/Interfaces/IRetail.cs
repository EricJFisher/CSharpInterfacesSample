namespace PointOfSale.Interfaces
{
    interface IRetail
    {
        void Sale(int amount);
        void Return(int amount);
    }
}
