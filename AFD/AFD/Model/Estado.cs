namespace AFD.Model
{
    public class Estado
    {
        public int Id { get; set; }

        public string Nome
        { 
            get
            {
                return "q" + Id.ToString();
            }
        }
    }
}
