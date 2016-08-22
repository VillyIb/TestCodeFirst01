using System.Data.Entity.ModelConfiguration;

namespace Model
{
    public class Person2Configuration : ComplexTypeConfiguration<Person2>
    {
        public Person2Configuration()
        {
            var order = 0;

            Property(p => p.Name).HasColumnOrder(order++).IsRequired().HasMaxLength(50);
            Property(p => p.Surname).HasColumnOrder(order++).IsRequired().HasMaxLength(50);
        }

    }

    public static class Person2Extension
    {
        public static Person2Configuration Configure(this Person2Configuration target)
        {

            var order = 0;

            target.Property(t => t.Name).HasColumnOrder(order++).IsRequired().HasMaxLength(50);
            target.Property(p => p.Surname).HasColumnOrder(order++).IsRequired().HasMaxLength(50);

            return target;
        } 
    }

}
