using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enerweb.FullStackTest.DomainEntities
{
    /// <summary>
    /// Persists data for the upload of a metering data file.
    /// </summary>
    public class MeterDataFile
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName="varchar(255)")]
        public string FileName { get; set; }
        
        public DateTime UploadedDate { get; set; }
        
        public byte[] FileContents { get; set; }

        protected MeterDataFile() { }

        public MeterDataFile(string fileName, DateTime uploadedDate, 
            byte[] fileContents)
        {
            this.FileName = fileName;
            this.UploadedDate = uploadedDate;
            this.FileContents = fileContents;
        }
    }
}
