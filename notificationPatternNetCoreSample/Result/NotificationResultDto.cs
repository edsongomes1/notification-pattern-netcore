using System;
using System.Collections.Generic;
using System.Text;

namespace notificationPatternNetCoreSample.Result
{
    public class NotificationResultDto
    {
        public NotificationResultDto(bool sucess, string message, object data)
        {
            Sucess = sucess;
            Message = message;
            Data = data;
        }

        public bool Sucess { get; private set; }

        public string Message { get; private set; }

        public object Data { get; private set; }
    }
}
