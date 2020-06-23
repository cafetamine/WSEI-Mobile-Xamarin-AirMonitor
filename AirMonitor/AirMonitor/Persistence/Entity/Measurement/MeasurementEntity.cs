namespace AirMonitor.Persistence.Entity.Measurement
{
    public class MeasurementEntity
    {
        public long? Id { get; set; }
        public int CurrentDisplayValue { get; set; }
        private long InstallationRef { get; set;}

        public MeasurementEntity()
        {
            // for serialization
        }

        private MeasurementEntity(long? id,
                                 int currentDisplayValue,
                                 long installationRef)
        {
            Id = id;
            CurrentDisplayValue = currentDisplayValue;
            InstallationRef = installationRef;
        }
    }
}
