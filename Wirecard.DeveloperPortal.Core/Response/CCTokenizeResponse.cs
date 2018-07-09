using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wirecard.DeveloperPortal.Core.Response
{
    public class CCTokenizeResponse
    {
        public string StatusCode { get; set; }
        public string ResultCode { get; set; }
        public string ResultMessage { get; set; }
        public string TokenId { get; set; }
        public string MaskedCCNo { get; set; }
        public string CustomerId { get; set; }
    }
}
