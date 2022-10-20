namespace TrattoriApi.Dal
{
    public interface IDal<T>
    {
        public void Read();
        public void Write();
    }
}
