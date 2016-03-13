namespace thrownewexception.com.domain
{
    using System;

    public abstract class Identity : IEquatable<Identity>, IIdentity
    {
        public Identity()
        {
            this.Id = Guid.NewGuid().ToString();
        }
        
        public Identity(string id)
        {
            this.Id = id;
        }

        public string Id { get; }

        public bool Equals(Identity other)
        {
            if (Object.ReferenceEquals(null, other)) return false;
            if (Object.ReferenceEquals(this, other)) return true;
            return this.Id.Equals(other.Id);
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            return Equals(obj as Identity);
        }

        public override int GetHashCode()
        {
            return (this.GetType().GetHashCode() * 907) + this.Id.GetHashCode();
        }

        public override string ToString()
        {
            return $"{this.GetType().Name} [Id={this.Id}]";
        }
    }
}