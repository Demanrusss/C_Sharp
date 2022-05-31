using System;

namespace EventHandlerProject
{
    internal class NameChangedEvent : EventArgs
    {
        // Enumiration that define types of changes
        public enum NameChangingKind { FirstName, LastName}

        public string NewName { get; set; }
        public bool Canceled { get; set; }
        public NameChangingKind NameKind { get; set; }

        // Constructor
        public NameChangedEvent(string newName, NameChangingKind nameKind)
        {
            NewName = newName;
            NameKind = nameKind;
            Canceled = false;
        }
    }
}
