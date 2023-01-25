namespace BBSData
{
    public interface IDiscountData
    {
        Task<int> Add(Discount discount);
        Task<IEnumerable<Discount>> GetDiscounts();
    }
}
