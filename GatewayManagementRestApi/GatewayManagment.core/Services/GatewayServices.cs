using GatewayManagementRestApi.GatewayManagment.core.Dtos;

namespace GatewayManagementRestApi.GatewayManagment.core.Services
{
    public class GatewayServices
    {
        private List<GatewayModel> gateways = new List<GatewayModel>();

        public List<GatewayModel> GetGateways()
        {
            return gateways;
        }

        public GatewayModel GetGatewayBySerialNumber(string serialNumber)
        {
            return gateways.FirstOrDefault(g => g.SerialNumber == serialNumber);
        }

        public void AddGateway(GatewayModel gateway)
        {
            // Add validation logic here for IPv4Address and peripheral device count

            gateways.Add(gateway);
        }

        public void AddPeripheralDevice(string serialNumber, PeripheralDeviceModel device)
        {
            var gateway = GetGatewayBySerialNumber(serialNumber);
            if (gateway != null)
            {
                // Add validation logic here for peripheral device count

                gateway.PeripheralDevices.Add(device);
            }
        }

        public void RemovePeripheralDevice(string serialNumber, int uid)
        {
            var gateway = GetGatewayBySerialNumber(serialNumber);
            if (gateway != null)
            {
                var deviceToRemove = gateway.PeripheralDevices.FirstOrDefault(d => d.UID == uid);
                if (deviceToRemove != null)
                {
                    gateway.PeripheralDevices.Remove(deviceToRemove);
                }
            }
        }
    }
}
