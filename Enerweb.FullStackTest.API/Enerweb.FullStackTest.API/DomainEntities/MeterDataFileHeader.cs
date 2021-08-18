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
    /// Persists the header record of the metering data file
    /// </summary>
    public class MeterDataFileHeader
    {
        [Key]
        public int Id { get; set; }

        public int MeterDataFileId { get; set; }

        [Column(TypeName = "varchar(5)")]
        public string RecordType { get; set; }

        [Column(TypeName = "varchar(12)")]
        public string UserId { get; set; }

        [Column(TypeName = "varchar(5)")]
        public string FileType { get; set; }

        public DateTime CreationDateTime { get; set; }

        public virtual MeterDataFile MeterDataFile { get; set; }

        protected MeterDataFileHeader() { }

        /// <summary>
        /// Creates a new header record.
        /// </summary>
        /// <param name="meterDataFileId">
        /// The link to the uploaded file.
        /// </param>
        /// <param name="recordType">
        /// The record type of the header.
        /// </param>
        /// <param name="userId">
        /// The user id.
        /// </param>
        /// <param name="fileType">
        /// The file type.
        /// </param>
        /// <param name="creationDateTime">
        /// The date and time the file was created.
        /// </param>
        public MeterDataFileHeader(int meterDataFileId, string recordType, string userId,
            string fileType, DateTime creationDateTime)
        {
            this.MeterDataFileId = meterDataFileId;
            this.RecordType = recordType;
            this.UserId = userId;
            this.FileType = fileType;
            this.CreationDateTime = creationDateTime;
        }

    }
}
