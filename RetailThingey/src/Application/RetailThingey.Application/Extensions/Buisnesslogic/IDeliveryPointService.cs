using RetailThingey.Application.Models.Shop;

namespace RetailThingey.Application.Extensions.Buisnesslogic;

public interface IDeliveryPointService
{
    void AddDeliveryPoint(DeliveryPoint deliveryPoint);
    DeliveryPoint GetDeliveryPointById(int id);
    IList<DeliveryPoint> GetAllDeliveryPoints();
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

    public IList<DeliveryPoint> GetAllDeliveryPoints()
    {
        return _deliveryPointRepository.GetAll();
    }
}