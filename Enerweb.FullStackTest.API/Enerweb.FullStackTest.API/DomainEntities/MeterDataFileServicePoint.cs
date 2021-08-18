using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Enerweb.FullStackTest.DomainEntities
{
    /// <summary>
    /// Persista the service point of the metering data file.
    /// </summary>
    public class MeterDataFileServicePoint
    {
        [Key]
        public int Id { get; set; }

        public int MeterDataFileHeaderId { get; set; }

        [Column(TypeName = "varchar(5)")]
        public string RecordType { get; set; }

        [Column(TypeName = "varchar(20)")]
        public string MeterId { get; set; }

        [Column(TypeName = "varchar(25)")]
        public string MeterSerialNumber { get; set; }

        public virtual MeterDataFileHeader MeterDataFileHeader { get; set; }

        protected MeterDataFileServicePoint() { }

        /// <summary>
        /// Creates a new service point record.
        /// </summary>
        /// <param name="meterDataFileId">
        /// The link to the file header.
        /// </param>
        /// <param name="recordType">
        /// The record type of the header.
        /// </param>
        /// <param name="meterId">
        /// The id of the meter.
        /// </param>
        /// <param name="meterSerialNumber">
        /// The serial number of the meter.
        /// </param>
        public MeterDataFileServicePoint(int meterDataFileHeaderId, string recordType, 
            string meterId, string meterSerialNumber)
        {
            this.MeterDataFileHeaderId = meterDataFileHeaderId;
            this.RecordType = recordType;
            this.MeterId = meterId;
            this.MeterSerialNumber = meterSerialNumber;
        }
    }
}
