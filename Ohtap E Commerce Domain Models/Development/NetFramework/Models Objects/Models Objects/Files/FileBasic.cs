using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohtap.ECommerce.Domain.Models.Objects.Files
{
    public class FileBasic : IFileData
    {
        public virtual string ID { get; set; }
        public virtual string Code { get; set; }
        public virtual string Name { get; set; }
        public virtual int Order { get; set; }
        public virtual string Description { get; set; }
        public virtual int State { get; set; }
        public virtual decimal Size { get; set; }
        public virtual string MIMEType { get; set; }
        public virtual FilePathType PathType { get; set; }
        public virtual string Path { get; set; }
    }
}
