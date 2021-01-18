using FluentValidator;
using FluentValidator.Validation;
using System;
using System.Collections.Generic;
using System.Text;

namespace notificationPatternNetCoreSample.Entity
{
    public class Person: Notifiable
    {
        public Person(string name, string emailAddress)
        {
            Name = name;
            EmailAddress = emailAddress;

            AddNotifications(new ValidationContract()
                    .HasMinLen(Name, 3, "Name", "Name Property must have at least 3 chars")
                    .HasMaxLen(Name, 3, "Name", "Name must not exceed 10 chars")
                    .IsEmail(EmailAddress, EmailAddress, "Email is not valid")
                );
        }

        public Guid Id { get; private set; }

        public string Name { get; private set; }

        public string EmailAddress { get; private set; }
    }
}
