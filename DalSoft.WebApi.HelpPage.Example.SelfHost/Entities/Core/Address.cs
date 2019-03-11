using GDIInterface.Models.Entities.Data;
using GDIInterface.Models.Entities.Web;

namespace GDIInterface.Models.Entities.Core
{
    public class Address
    {
        public Address()
        {

        }

        public Address(AddressDTO dto)
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
            this.newsletter = dto.newsletter;
        }

        public Address(AddressModel model)
        {
            this.adressid = model.adressid;
            this.firstname = model.firstname;
            this.lastname = model.lastname;
            this.phone = model.phone;
            this.phoneprivate = model.phoneprivate;
            this.street = model.street;
            this.city = model.city;
            this.postcode = model.postcode;
            this.email = model.email;
            this.country = model.country;
            this.name1 = model.name1;
            this.name2 = model.name2;
            this.name3 = model.name3;
            this.mobile = model.mobile;
            this.telefax = model.telefax;
            this.homepage = model.homepage;
            this.category = model.category;
            this.searchname = model.searchname;
            this.newsletter = model.newsletter;
        }


        public long adressid { get; set; } // StoredProcedure

        public string firstname { get; set; } // Extra Update

        public string lastname { get; set; } // Extra Update

        public string phone { get; set; } // StoredProcedure

        public string phoneprivate { get; set; } // Extra Update

        public string street { get; set; } // StoredProcedure

        public string city { get; set; } // StoredProcedure

        public string postcode { get; set; } // StoredProcedure

        public string email { get; set; } // StoredProcedure

        public string country { get; set; } // StoredProcedure

        public string name1 { get; set; } // StoredProcedure

        public string name2 { get; set; } // StoredProcedure

        public string name3 { get; set; } // StoredProcedure

        public string mobile { get; set; } // StoredProcedure

        public string telefax { get; set; } // StoredProcedure

        public string homepage { get; set; } // StoredProcedure

        public string category { get; set; } // Extra Update

        public string searchname { get; set; } // StoredProcedure

        public int newsletter { get; set; } // Extra Update

        public int getNewsletter()
        {
            if (this.newsletter < 0 || this.newsletter > 2)
            {
                return 0;
            }
            else
            {
                return this.newsletter;
            }

        }
    }
}