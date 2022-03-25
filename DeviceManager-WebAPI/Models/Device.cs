namespace DeviceManager_WebAPI.Models {
    public class Device 
    {
        public Device() {}

        public Device(int Id, string Name, string Status, string Type, string Info, decimal Temperature)
        {
            this.Id = Id;
            this.Name = Name;
            this.Status = Status;
            this.Type = Type;
            this.Info = Info;
            this.Temperature = Temperature;
        }
        
        public int Id { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
        public string Type { get; set; }
        public string Info { get; set; }
        public decimal Temperature { get; set; }
    }
}
