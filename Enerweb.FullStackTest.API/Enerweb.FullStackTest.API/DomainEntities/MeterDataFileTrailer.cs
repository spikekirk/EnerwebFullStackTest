using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Enerweb.FullStackTest.DomainEntities
{
    public class MeterDataFileTrailer
    {
        [Key]
        public int Id { get; set; }

        public int MeterDataFileId { get; set; }

        [Column(TypeName = "varchar(5)")]
        public string RecordType { get; set; }
        
        public int RecordCount { get; set; }

        public virtual MeterDataFile MeterDataFile { get; set; }

        protected MeterDataFileTrailer() { }

        /// <summary>
        /// Creates a new trailer record.
        /// </summary>
        /// <param name="meterDataFileId">
        /// The link to the uploaded file.
        /// </param>
        /// <param name="recordType">
        /// The record type of the header.
        /// </param>
        /// <param name="recordCount">
        /// The amount of records in the file excluding the header and trailier.
        /// </param>
        public MeterDataFileTrailer(int meterDataFileId, string recordType, int recordCount)
        {
            this.MeterDataFileId = meterDataFileId;
            this.RecordType = recordType;
            this.RecordCount = recordCount;
        }

    }
}
