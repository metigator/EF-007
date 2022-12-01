namespace EF007.ConfigurationByConvention.Entities
{
    public class User
    {
        // Primary key convention [Id, id , ID] , [{Class}Id]
        public int UserId { get; set; }
        public string Username { get; set; }
    }
}
