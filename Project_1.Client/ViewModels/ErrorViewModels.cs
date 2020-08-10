using System;

namespace Project_1.Client.ViewModels
{
    public class ErrorViewModels
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
