using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GDIInterface.Models.Entities.Core;

namespace GDIInterface.Models.Entities.Data
{
    public class AddressModel
    {
        public AddressModel()
        {

        }

        public AddressModel(Address dto)
        {
            this.adressid = dto.adressid;
            this.firstname = dto.firstname;
            this.lastname = dto.lastname;
            this.phone = dto.phone;
            this.phoneprivate = dto.phoneprivate;
            this.street = dto.street;
            this.city = dto.city;
            this.postcode = dto.postcode;
            this.email = dto.email;
            this.country = dto.country;
            this.name1 = dto.name1;
            this.name2 = dto.name2;
            this.name3 = dto.name3;
            this.mobile = dto.mobile;
            this.telefax = dto.telefax;
            this.homepage = dto.homepage;
            this.category = dto.category;
            this.searchname = dto.searchname;
            this.newsletter = dto.getNewsletter();
        }

        public long adressid { get; set; }

        public string firstname { get; set; }

        public string lastname { get; set; }

        public string phone { get; set; }

        public string phoneprivate { get; set; }

        public string street { get; set; } 

        public string city { get; set; }

        public string postcode { get; set; }

        public string email { get; set; }

        public string country { get; set; } 

        public string name1 { get; set; }

        public string name2 { get; set; } 

        public string name3 { get; set; } 

        public string mobile { get; set; } 

        public string telefax { get; set; }

        public string homepage { get; set; }

        public string category { get; set; } 

        public string searchname { get; set; } 

        public int newsletter { get; set; } 

      
    }
}