namespace Framework.FrameworkCore
{
    public interface IScheduleContact : ISchedulableResource
    {
        IContact Contact { get; set; }
        bool Primary { get; set; }
    }
}
