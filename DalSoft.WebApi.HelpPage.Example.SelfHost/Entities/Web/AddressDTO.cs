using GDIInterface.Models.Entities.Core;

namespace GDIInterface.Models.Entities.Web
{
    /// <summary>
    /// User Daten.
    /// </summary>
    public class AddressDTO
    {
        public AddressDTO()
        {

        }

        public AddressDTO(Address address)
        {
            this.adressid = address.adressid;
            this.firstname = address.firstname;
            this.lastname = address.lastname;
            this.phone = address.phone;
            this.phoneprivate = address.phoneprivate;
            this.street = address.street;
            this.city = address.city;
            this.postcode = address.postcode;
            this.email = address.email;
            this.country = address.country;
            this.name1 = address.name1;
            this.name2 = address.name2;
            this.name3 = address.name3;
            this.mobile = address.mobile;
            this.telefax = address.telefax;
            this.homepage = address.homepage;
            this.category = address.category;
            this.searchname = address.searchname;
            this.newsletter = address.newsletter;
        }


        /// <summary>
        /// AdressID.
        /// </summary>
        public long adressid { get; set; } // StoredProcedure

        /// <summary>
        /// Vorname.
        /// </summary>
        public string firstname { get; set; } // Extra Update

        /// <summary>
        /// Nachname.
        /// </summary>
        public string lastname { get; set; } // Extra Update

        /// <summary>
        /// Telefonnummer.
        /// </summary>
        public string phone { get; set; } // StoredProcedure
        
        /// <summary>
        /// Private Telefonnummer.
        /// </summary>
        public string phoneprivate { get; set; } // Extra Update

        /// <summary>
        /// Strasse.
        /// </summary>
        public string street { get; set; } // StoredProcedure

        /// <summary>
        /// city.
        /// </summary>
        public string city { get; set; } // StoredProcedure

        /// <summary>
        /// Postleitzahl.
        /// </summary>
        public string postcode { get; set; } // StoredProcedure

        /// <summary>
        /// EMail.
        /// </summary>
        public string email { get; set; } // StoredProcedure

        /// <summary>
        /// Land.
        /// </summary>
        public string country { get; set; } // StoredProcedure

        /// <summary>
        /// Name1.
        /// </summary>
        public string name1 { get; set; } // StoredProcedure

        /// <summary>
        /// Name2.
        /// </summary>
        public string name2 { get; set; } // StoredProcedure

        /// <summary>
        /// Name3.
        /// </summary>
        public string name3 { get; set; } // StoredProcedure

        /// <summary>
        /// Handy.
        /// </summary>
        public string mobile { get; set; } // StoredProcedure

        /// <summary>
        /// Telefax.
        /// </summary>
        public string telefax { get; set; } // StoredProcedure

        /// <summary>
        /// Homepage.
        /// </summary>
        public string homepage { get; set; } // StoredProcedure

        /// <summary>
        /// Kategorie.
        /// </summary>
        public string category { get; set; } // Extra Update

        /// <summary>
        /// Suchname.
        /// </summary>
        public string searchname { get; set; } // StoredProcedure

        /// <summary>
        /// Newsletter.
        /// </summary>
        public int newsletter { get; set; } // Extra Update
    }
}