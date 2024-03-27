using RetailThingey.Application.Models.Shop;

namespace RetailThingey.Application.Extensions.Buisnesslogic;

public interface IDeliveryPointRepository
{
    void Add(DeliveryPoint deliveryPoint);
    DeliveryPoint GetById(int id);
    IList<DeliveryPoint> GetAll();
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
        return _deliveryPoints.FirstOrDefault(dp => dp.Id == id)!;
    }

    public IList<DeliveryPoint> GetAll()
    {
        return _deliveryPoints;
    }
}