namespace ContactStorageDiskService
{
    using Abstractions;

    public class Storage
    {
        private IContact[] contacts;
        private int size;
        private int growthFactor;

        public Storage(int size, int growthFactor)
        {
            this.size = size;
            this.growthFactor = growthFactor;

        }
    }
}
