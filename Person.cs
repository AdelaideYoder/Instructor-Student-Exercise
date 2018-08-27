namespace Lightening
{
    public class Person
    {
        protected string _firstName;
        protected string _lastName;
        //Expression 
        public string Name { get => $"{_firstName} {_lastName}"; }
    }
}