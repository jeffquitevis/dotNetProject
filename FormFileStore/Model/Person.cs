namespace FormFileStore.Model
{
  
        public class Person
        {

            private string firstName;
            private string lastName;
            private long id;
         

            public Person(long id,string firstName, string lastName)
            {
                this.firstName = firstName;
                this.lastName = lastName;
                this.id = id;
            }


            public string FirstName
            {
                get { return firstName; }
                set { firstName = value; }
            }

            public string LastName
            {
                get { return lastName; }
                set { lastName = value; }

            }

            public long Id
            {
                get { return id; }
                set { id = value; }
            }

        public override string ToString()
        {
            return FirstName + "\n" + LastName;
        }

    }
}
