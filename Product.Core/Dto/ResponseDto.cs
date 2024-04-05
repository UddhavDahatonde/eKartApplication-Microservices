using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.Core.Dto
{
    public class ResponseDto
    {
        public string? Message { get; set; } = "";
        public object? Result { get; set; }
        public bool Status { get; set; } = true;
    }
}
