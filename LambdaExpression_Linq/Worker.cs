namespace LambdaExpression_Linq
{
    public class Worker
    {
        public string LastName { get; private set; }
        public string FirstName { get; private set; }
        public string Position { get; private set; }

        public Worker(string fname, string lname, string position)
        {
            FirstName = fname;
            LastName = lname;
            Position = position;
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }
}