using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeApi.Data.Queries
{
    /// <summary>
    /// Класс для передачи дополнительных параметров при обновлении устройства
    /// </summary>
    public class UpdateDeviceAllDataQuery
    {
        public string NewName { get; }
        public string NewModel { get; }
        public string NewManufacturer { get; }
        public string NewSerial { get; }
        public int NewCurrentVolts  { get; }
        public bool NewGasUsage { get; }
        public string NewLocation { get; }

        public UpdateDeviceAllDataQuery(string newName = null, string newModel = null, string newManufacturer = null, string newSerial = null, int newCurrentVolts = 220, bool newGasUsage = false, string newLocation = null)
        {
            NewName = newName;
            NewModel = newModel;
            NewManufacturer = newManufacturer;
            NewSerial = newSerial;
            NewCurrentVolts = newCurrentVolts;
            NewGasUsage = newGasUsage;
            NewLocation = newLocation;
        }
    }
}
