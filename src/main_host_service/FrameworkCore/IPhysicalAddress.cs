namespace Framework.FrameworkCore
{
    public interface IPhysicalAddress
    {
        string Street1 { get; set; }
        string Street2 { get; set; }
        string City { get; set; }
        string State { get; set; }
        string ZipCode { get; set; }
    }
}