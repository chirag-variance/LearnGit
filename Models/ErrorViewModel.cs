using System;

namespace LearnGit.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }
        /// <summary>
        /// Comment added in Sprint3
        /// </summary>
        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
