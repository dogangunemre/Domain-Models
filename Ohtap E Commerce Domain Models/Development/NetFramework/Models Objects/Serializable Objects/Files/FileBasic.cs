using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ohtap.ECommerce.Domain.Models.Objects.Files;

namespace Ohtap.ECommerce.Domain.Models.Serializable.Objects.Files
{
    public class FileBasic : IFileData
    {
        public string ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public int Order { get; set; }
        public string Description { get; set; }
        public int State { get; set; }
        public decimal Size { get; set; }
        public string MIMEType { get; set; }
        public FilePathType PathType { get; set; }
        public string Path { get; set; }
    }
}
