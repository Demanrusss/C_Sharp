using System;

namespace EventHandlerProject
{
    internal class Person
    {
        // Delegate
        public delegate void NameChanged(Object sender, NameChangedEvent e);

        // Declaring events
        public event NameChanged FirstNameChanged;
        public event NameChanged LastNameChanged;
        public event EventHandler AgeChanged;

        // declaring variables
        string firstname;
        string lastname;
        int age;

        // Name properties
        public string Firstname
        {
            get { return firstname; }
            set 
            {
                if (FirstNameChanged != null)
                {
                    FirstNameChanged(this,
                        new NameChangedEvent(value,
                            NameChangedEvent.NameChangingKind.FirstName));
                }

                firstname = value; 
            }
        }

        // Surname properties
        public string Lastname
        {
            get { return lastname; }
            set 
            {
                if (LastNameChanged != null)
                {
                    NameChangedEvent changeevent = new NameChangedEvent(value,
                        NameChangedEvent.NameChangingKind.LastName);

                    LastNameChanged(this, changeevent);

                    if (changeevent.Canceled)
                        return;
                }

                lastname = value; 
            }
        }
        public int Age
        {
            get { return age; }
            set
            {
                if (value < 0)
                    throw new Exception("Age could not be the number below zero.");

                age = value;

                if (AgeChanged != null)
                    AgeChanged(this, new EventArgs());
            }
        }

        public Person(string firstname, string lastname)
        {
            this.firstname = firstname;
            this.lastname = lastname;
        }
    }
}
