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
    /// Persists the data period of the metering data file.
    /// </summary>
    public class MeterDataFileDataPeriod
    {
        [Key]
        public int Id { get; set; }

        public int MeterDataFileOperatingDateId { get; set; }

        public int MeterDataFileServicePointId { get; set; }

        [Column(TypeName = "varchar(5)")]
        public string RecordType { get; set; }

        public int Period { get; set; }

        [Column(TypeName = "decimal(7,4)")]
        public decimal ImportEnergy { get; set; }

        [Column(TypeName = "decimal(7,4)")]
        public decimal ExportEnergy { get; set; }

        [Column(TypeName = "decimal(7,4)")]
        public decimal ReadingFlag { get; set; }

        public virtual MeterDataFileOperatingDate MeterDataFileOperatingDate { get; set; }
        public virtual MeterDataFileServicePoint MeterDataFileServicePoint { get; set; }
        
        protected MeterDataFileDataPeriod() { }

        /// <summary>
        /// Creates a new data period record.
        /// </summary>
        /// <param name="meterDataFileOperatingDateId">
        /// The link to the operating date.
        /// </param>
        /// <param name="meterDataFileServicePointId">
        /// The link to the service point.
        /// </param>
        /// <param name="recordType">
        /// The record type of the header.
        /// </param>
        /// <param name="importEnergy">
        /// The Import Energy value in kWh Q2/Q3 kWh.
        /// </param>
        /// <param name="exportEnergy">
        /// Export Energy value in kWh Q1/Q4 kWh.
        /// </param>
        /// <param name="readingFlag">
        /// Official (1) or Actual (0).
        /// </param>
        public MeterDataFileDataPeriod(int meterDataFileOperatingDateId, int meterDataFileServicePointId,  
            string recordType, decimal importEnergy, decimal exportEnergy, decimal readingFlag)
        {
            this.MeterDataFileOperatingDateId = meterDataFileOperatingDateId;
            this.MeterDataFileServicePointId = meterDataFileServicePointId;
            this.RecordType = recordType;
            this.ImportEnergy = importEnergy;
            this.ExportEnergy = exportEnergy;
            this.ReadingFlag = readingFlag;
        }
    }
}
