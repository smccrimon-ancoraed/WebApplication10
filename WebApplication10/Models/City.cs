using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication10.Models
{
    public class City
    {


        /*
         * 
         * 

USE [World]
GO

***** Object:  Table [dbo].[city]    Script Date: 12/7/2019 10:45:50 AM ****
        SET ANSI_NULLS ON
        GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE[dbo].[city]
        (

   [ID][int] NOT NULL,
   [Name] [char](35) NOT NULL,
   [CountryCode] [char](3) NOT NULL,
   [District] [char](20) NOT NULL,
   [Population] [int] NOT NULL,


CREATE TABLE[dbo].[city]
        (

   [ID][int] IDENTITY(1,1) NOT NULL,   //AUTO_INCREMENT 

  [Name] [char](35) NOT NULL,

  [CountryCode] [char](3) NOT NULL,

  [District] [char](20) NOT NULL,

  [Population] [int] NOT NULL,
PRIMARY KEY CLUSTERED
(
  [ID] ASC
)WITH(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON[PRIMARY]
) ON[PRIMARY]
GO

ALTER TABLE[dbo].[city] ADD DEFAULT('') FOR[Name]
GO

ALTER TABLE[dbo].[city] ADD DEFAULT('') FOR[CountryCode]
GO

ALTER TABLE[dbo].[city] ADD DEFAULT('') FOR[District]
GO

ALTER TABLE[dbo].[city] ADD DEFAULT('0') FOR[Population]
GO


        */

        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string CountryCode { get; set; }
        public string District { get; set; }
        public int Population { get; set; }
    }
}
