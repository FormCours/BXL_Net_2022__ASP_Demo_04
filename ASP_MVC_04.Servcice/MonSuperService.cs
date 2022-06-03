namespace ASP_MVC_04.Servcice
{
    public class MonSuperService
    {
        #region Counter static (for demo)
        private static int count = 0;
        #endregion

        public int InstanceId { get; set; }


        public MonSuperService()
        {
            count++;

            InstanceId = count;
        }

        public string GetMessage()
        {
            return $"L'instance de service est {InstanceId}";
        }
    }
}