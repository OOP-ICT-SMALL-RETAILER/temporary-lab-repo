public interface IDeliveryPointService
{
    void AddDeliveryPoint(DeliveryPoint deliveryPoint);
    DeliveryPoint GetDeliveryPointById(int id);
    List<DeliveryPoint> GetAllDeliveryPoints();
}

public class DeliveryPointService : IDeliveryPointService
{
    private readonly IDeliveryPointRepository _deliveryPointRepository;

    public DeliveryPointService(IDeliveryPointRepository deliveryPointRepository)
    {
        _deliveryPointRepository = deliveryPointRepository;
    }

    public void AddDeliveryPoint(DeliveryPoint deliveryPoint)
    {
        _deliveryPointRepository.Add(deliveryPoint);
    }

    public DeliveryPoint GetDeliveryPointById(int id)
    {
        return _deliveryPointRepository.GetById(id);
    }

    public List<DeliveryPoint> GetAllDeliveryPoints()
    {
        return _deliveryPointRepository.GetAll();
    }
}

public interface IDeliveryPointRepository
{
    void Add(DeliveryPoint deliveryPoint);
    DeliveryPoint GetById(int id);
    List<DeliveryPoint> GetAll();
}

public class DeliveryPointRepository : IDeliveryPointRepository
{
    private readonly List<DeliveryPoint> _deliveryPoints;

    public DeliveryPointRepository()
    {
        _deliveryPoints = new List<DeliveryPoint>();
    }

    public void Add(DeliveryPoint deliveryPoint)
    {
        _deliveryPoints.Add(deliveryPoint);
    }

    public DeliveryPoint GetById(int id)
    {
        return _deliveryPoints.FirstOrDefault(dp => dp.Id == id);
    }

    public List<DeliveryPoint> GetAll()
    {
        return _deliveryPoints;
    }
}

public class DeliveryPoint
{
    public int Id { get; set; }
    public string Address { get; set; }
}