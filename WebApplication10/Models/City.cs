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


        */

        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string CountryCode { get; set; }
        public string District { get; set; }
        public int Population { get; set; }
    }
}
