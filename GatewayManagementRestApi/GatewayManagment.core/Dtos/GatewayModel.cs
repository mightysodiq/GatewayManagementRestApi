namespace GatewayManagementRestApi.GatewayManagment.core.Dtos
{
    public class GatewayModel
    {
        public string SerialNumber { get; set; }
        public string Name {  get; set; }
        public string IpV4Address { get; set; }
        public List<PeripheralDeviceModel> PeripheralDevices { get; set; }

    }
}
