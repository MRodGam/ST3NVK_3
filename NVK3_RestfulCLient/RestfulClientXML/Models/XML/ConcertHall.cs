﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RestfulClientXML.Models.XML
{
    // post delete, put og get1 (id)
    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.datacontract.org/2004/07/VenueServiceASEECE.Models")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.datacontract.org/2004/07/VenueServiceASEECE.Models", IsNullable = false)]
    public partial class ConcertHall
    {

        private int concertHallIdField;

        private string concertHallNameField;

        private List<ConcertHallConcertEquipment> equipmentField;

        private string hallResponsibleField;

        private decimal hallsizeM2Field;

        private string isLocatatVenueField;

        private int maxNoAudienceField;

        private int noOfDoorsField;

        private decimal stagesizeM2Field;

        /// <remarks/>
        public int ConcertHallId
        {
            get
            {
                return this.concertHallIdField;
            }
            set
            {
                this.concertHallIdField = value;
            }
        }

        /// <remarks/>
        public string ConcertHallName
        {
            get
            {
                return this.concertHallNameField;
            }
            set
            {
                this.concertHallNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("ConcertEquipment", IsNullable = false)]
        public List<ConcertHallConcertEquipment> Equipment
        {
            get
            {
                return this.equipmentField;
            }
            set
            {
                this.equipmentField = value;
            }
        }

        /// <remarks/>
        public string HallResponsible
        {
            get
            {
                return this.hallResponsibleField;
            }
            set
            {
                this.hallResponsibleField = value;
            }
        }

        /// <remarks/>
        public decimal HallsizeM2
        {
            get
            {
                return this.hallsizeM2Field;
            }
            set
            {
                this.hallsizeM2Field = value;
            }
        }

        /// <remarks/>
        public string IsLocatatVenue
        {
            get
            {
                return this.isLocatatVenueField;
            }
            set
            {
                this.isLocatatVenueField = value;
            }
        }

        /// <remarks/>
        public int MaxNoAudience
        {
            get
            {
                return this.maxNoAudienceField;
            }
            set
            {
                this.maxNoAudienceField = value;
            }
        }

        /// <remarks/>
        public int NoOfDoors
        {
            get
            {
                return this.noOfDoorsField;
            }
            set
            {
                this.noOfDoorsField = value;
            }
        }

        /// <remarks/>
        public decimal StagesizeM2
        {
            get
            {
                return this.stagesizeM2Field;
            }
            set
            {
                this.stagesizeM2Field = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.datacontract.org/2004/07/VenueServiceASEECE.Models")]
    public partial class ConcertHallConcertEquipment
    {

        private string belongsToConcertHallField;

        private string descriptionField;

        private int equipmentCountField;

        private int equipmentIdField;

        private string equipmentNameField;

        private string factoryNameField;

        /// <remarks/>
        public string BelongsToConcertHall
        {
            get
            {
                return this.belongsToConcertHallField;
            }
            set
            {
                this.belongsToConcertHallField = value;
            }
        }

        /// <remarks/>
        public string Description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }

        /// <remarks/>
        public int EquipmentCount
        {
            get
            {
                return this.equipmentCountField;
            }
            set
            {
                this.equipmentCountField = value;
            }
        }

        /// <remarks/>
        public int EquipmentId
        {
            get
            {
                return this.equipmentIdField;
            }
            set
            {
                this.equipmentIdField = value;
            }
        }

        /// <remarks/>
        public string EquipmentName
        {
            get
            {
                return this.equipmentNameField;
            }
            set
            {
                this.equipmentNameField = value;
            }
        }

        /// <remarks/>
        public string FactoryName
        {
            get
            {
                return this.factoryNameField;
            }
            set
            {
                this.factoryNameField = value;
            }
        }
    }

    // ************************************************************* Get all model **************************************************


    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.datacontract.org/2004/07/VenueServiceASEECE.Models")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.datacontract.org/2004/07/VenueServiceASEECE.Models", IsNullable = false)]
    public partial class ArrayOfConcertHall
    {

        private ArrayOfConcertHallConcertHall[] concertHallField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ConcertHall")]
        public ArrayOfConcertHallConcertHall[] ConcertHall
        {
            get
            {
                return this.concertHallField;
            }
            set
            {
                this.concertHallField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.datacontract.org/2004/07/VenueServiceASEECE.Models")]
    public partial class ArrayOfConcertHallConcertHall
    {

        private int concertHallIdField;

        private string concertHallNameField;

        private List<ArrayOfConcertHallConcertHallConcertEquipment> equipmentField;

        private string hallResponsibleField;

        private decimal hallsizeM2Field;

        private string isLocatatVenueField;

        private int maxNoAudienceField;

        private int noOfDoorsField;

        private decimal stagesizeM2Field;

        /// <remarks/>
        public int ConcertHallId
        {
            get
            {
                return this.concertHallIdField;
            }
            set
            {
                this.concertHallIdField = value;
            }
        }

        /// <remarks/>
        public string ConcertHallName
        {
            get
            {
                return this.concertHallNameField;
            }
            set
            {
                this.concertHallNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("ConcertEquipment", IsNullable = false)]
        public List<ArrayOfConcertHallConcertHallConcertEquipment> Equipment
        {
            get
            {
                return this.equipmentField;
            }
            set
            {
                this.equipmentField = value;
            }
        }

        /// <remarks/>
        public string HallResponsible
        {
            get
            {
                return this.hallResponsibleField;
            }
            set
            {
                this.hallResponsibleField = value;
            }
        }

        /// <remarks/>
        public decimal HallsizeM2
        {
            get
            {
                return this.hallsizeM2Field;
            }
            set
            {
                this.hallsizeM2Field = value;
            }
        }

        /// <remarks/>
        public string IsLocatatVenue
        {
            get
            {
                return this.isLocatatVenueField;
            }
            set
            {
                this.isLocatatVenueField = value;
            }
        }

        /// <remarks/>
        public int MaxNoAudience
        {
            get
            {
                return this.maxNoAudienceField;
            }
            set
            {
                this.maxNoAudienceField = value;
            }
        }

        /// <remarks/>
        public int NoOfDoors
        {
            get
            {
                return this.noOfDoorsField;
            }
            set
            {
                this.noOfDoorsField = value;
            }
        }

        /// <remarks/>
        public decimal StagesizeM2
        {
            get
            {
                return this.stagesizeM2Field;
            }
            set
            {
                this.stagesizeM2Field = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.datacontract.org/2004/07/VenueServiceASEECE.Models")]
    public partial class ArrayOfConcertHallConcertHallConcertEquipment
    {

        private string belongsToConcertHallField;

        private string descriptionField;

        private int equipmentCountField;

        private int equipmentIdField;

        private string equipmentNameField;

        private string factoryNameField;

        /// <remarks/>
        public string BelongsToConcertHall
        {
            get
            {
                return this.belongsToConcertHallField;
            }
            set
            {
                this.belongsToConcertHallField = value;
            }
        }

        /// <remarks/>
        public string Description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }

        /// <remarks/>
        public int EquipmentCount
        {
            get
            {
                return this.equipmentCountField;
            }
            set
            {
                this.equipmentCountField = value;
            }
        }

        /// <remarks/>
        public int EquipmentId
        {
            get
            {
                return this.equipmentIdField;
            }
            set
            {
                this.equipmentIdField = value;
            }
        }

        /// <remarks/>
        public string EquipmentName
        {
            get
            {
                return this.equipmentNameField;
            }
            set
            {
                this.equipmentNameField = value;
            }
        }

        /// <remarks/>
        public string FactoryName
        {
            get
            {
                return this.factoryNameField;
            }
            set
            {
                this.factoryNameField = value;
            }
        }
    }


}
