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
    /// Persists the operating date of the meter data file.
    /// </summary>
    public class MeterDataFileOperatingDate
    {
        [Key]
        public int Id { get; set; }

        public int MeterDataFileHeaderId { get; set; }

        [Column(TypeName = "varchar(5)")]

        public string RecordType { get; set; }

        public DateTime OperatingDate { get; set; }

        public virtual MeterDataFileHeader MeterDataFileHeader { get; set; }

        protected MeterDataFileOperatingDate() { }

        /// <summary>
        /// Creates a new operating date record.
        /// </summary>
        /// <param name="meterDataFileHeaderId">
        /// The link to the file header.
        /// </param>
        /// <param name="recordType">
        /// The record type of the header.
        /// </param>
        /// <param name="operatingDate">
        /// The date the operating day.
        /// </param>
        public MeterDataFileOperatingDate(int meterDataFileHeaderId, string recordType, DateTime operatingDate)
        {
            this.MeterDataFileHeaderId = meterDataFileHeaderId;
            this.RecordType = recordType;
            this.OperatingDate = operatingDate;
        }
    }
}
