using System;

namespace AirMonitor.Client.Airly
{
    public class AirlyApiClientFunction
    {
        private const string ApiGetInstallationsPrefix = "installations/nearest";
        private const string ApiGetMeasurementsPrefix = "measurements/installation";

        private readonly AirlyClientApiFunctionType _type;

        public AirlyApiClientFunction(AirlyClientApiFunctionType type)
        {
            _type = type;
        }

        public enum AirlyClientApiFunctionType
        {
            GetInstallations,
            GetMeasurements
        }

        public string ApiPath
        {
            get
            {
                switch (_type)
                {
                    case AirlyClientApiFunctionType.GetInstallations:
                        return ApiGetInstallationsPrefix;
                    case AirlyClientApiFunctionType.GetMeasurements:
                        return ApiGetMeasurementsPrefix;
                    default:
                        throw new ArgumentException($"Unsupported Airly api function={_type}");
                }
            }
        }

        public static AirlyApiClientFunction GetInstallations => new AirlyApiClientFunction(AirlyClientApiFunctionType.GetInstallations);
             
        public static AirlyApiClientFunction GetMeasurements => new AirlyApiClientFunction(AirlyClientApiFunctionType.GetMeasurements);
    }
}
