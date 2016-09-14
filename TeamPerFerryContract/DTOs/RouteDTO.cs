namespace TeamPerFerryContract
{
    public class RouteDTO
    {
        public long RouteId { get; set; }
        public string Name { get; set; }
        public DockDTO DepartureDock { get; set; }
        public DockDTO ArrivalDock { get; set; }
    }
}