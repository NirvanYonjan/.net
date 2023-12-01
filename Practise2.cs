namespace Generic
{
    public class Practice2<T, U>
    {
        public T model;

        public U color;
        public U company;
        public Practice2(T ModelName, U ColorName, U CompanyName)
        {
            model = ModelName;
            color = ColorName;
            company = CompanyName;
        }
    }
}