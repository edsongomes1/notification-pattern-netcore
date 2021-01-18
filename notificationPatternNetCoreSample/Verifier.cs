using FluentValidator;
using notificationPatternNetCoreSample.Entity;
using notificationPatternNetCoreSample.Result;
using System;
using System.Collections.Generic;
using System.Text;

namespace notificationPatternNetCoreSample
{
    public class Verifier: Notifiable
    {
        public NotificationResultDto Execute()
        {
            var person = new Person("Edson Gomes", "edsongomes1@gmail.com");
            return Verify(person);
        }

        private NotificationResultDto Verify(Person person)
        {
            //simulating validation of entity

            AddNotifications(person.Notifications);
            if(Invalid)
            {
                return new NotificationResultDto(
                    false, "Please validate following fileds: ", Notifications);
            }
            return new NotificationResultDto(true, "Validation success", null);

        }

    }
}
