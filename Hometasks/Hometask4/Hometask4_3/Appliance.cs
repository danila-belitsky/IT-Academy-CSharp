namespace Hometask4.Hometask4_3
{
    public abstract class Appliance
    {
        protected bool _isEnabled = false;

        public string Model { get; set; }

        public abstract void Launch();
        public abstract void Shutdown();

        public Appliance(string model)
        {
            Model = model;
        }
    }
}