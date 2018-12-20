using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestfulClientXML.Models.XML
{

    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.datacontract.org/2004/07/VenueServiceASEECE.Models")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.datacontract.org/2004/07/VenueServiceASEECE.Models", IsNullable = false)]
    public partial class ArrayOfConcertEquipment
    {

        private List<ArrayOfConcertEquipmentConcertEquipment> concertEquipmentField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ConcertEquipment")]
        public List<ArrayOfConcertEquipmentConcertEquipment> Equipment
        {
            get
            {
                return this.concertEquipmentField;
            }
            set
            {
                this.concertEquipmentField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.datacontract.org/2004/07/VenueServiceASEECE.Models")]
    public partial class ArrayOfConcertEquipmentConcertEquipment
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

    //


    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.datacontract.org/2004/07/VenueServiceASEECE.Models")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.datacontract.org/2004/07/VenueServiceASEECE.Models", IsNullable = false)]
    public partial class ConcertEquipment
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

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.datacontract.org/2004/07/VenueServiceASEECE.Models")]
        public partial class ConcertHallConcertEquipment
        {

            private string belongsToConcertHallField;

            private string descriptionField;

            private long equipmentCountField;

            private long equipmentIdField;

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
            public long EquipmentCount
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
            public long EquipmentId
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





}
