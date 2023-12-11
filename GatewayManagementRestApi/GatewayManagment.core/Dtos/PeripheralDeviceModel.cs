namespace GatewayManagementRestApi.GatewayManagment.core.Dtos
{
    public class PeripheralDeviceModel
    {
        public int UID { get; set; }
        public string Vendor { get; set; }
        public DateTime DateCreated { get; set; }
        public bool Status { get; set; }
    }
}
