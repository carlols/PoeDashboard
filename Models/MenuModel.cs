namespace PoeDashboard.Web.Models
{
    public class MenuModel
    {
        public MenuModel(string clientIp)
        {
            ClientIp = clientIp;
        }
        public string ClientIp { get; set; }
    }
}