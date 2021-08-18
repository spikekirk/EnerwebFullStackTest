using Enerweb.FullStackTest.DomainEntities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Enerweb.FullStackTest.API.DomainEntities
{
    public class MeterDataContext : DbContext
    {

        public MeterDataContext(DbContextOptions<MeterDataContext> options)
            : base(options)
        {

        }

        public virtual DbSet<MeterDataFile> MeterDataFile { get; set; }
        public virtual DbSet<MeterDataFileHeader> MeterDataFileHeader { get; set; }
        public virtual DbSet<MeterDataFileOperatingDate> MeterDataFileOperatingDate { get; set; }
        public virtual DbSet<MeterDataFileServicePoint> MeterDataFileServicePoint { get; set; }
        public virtual DbSet<MeterDataFileDataPeriod> MeterDataFileDataPeriod { get; set; }
        public virtual DbSet<MeterDataFileTrailer> MeterDataFileTrailer { get; set; }


    }
}
