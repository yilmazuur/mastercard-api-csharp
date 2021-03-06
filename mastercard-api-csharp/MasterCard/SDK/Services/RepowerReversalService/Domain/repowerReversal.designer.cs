// ------------------------------------------------------------------------------
//  <auto-generated>
//    Generated by Xsd2Code. Version 3.4.0.37595
//    <NameSpace>RepowerReversal</NameSpace><Collection>List</Collection><codeType>CSharp</codeType><EnableDataBinding>False</EnableDataBinding><EnableLazyLoading>False</EnableLazyLoading><TrackingChangesEnable>False</TrackingChangesEnable><GenTrackingClasses>False</GenTrackingClasses><HidePrivateFieldInIDE>False</HidePrivateFieldInIDE><EnableSummaryComment>False</EnableSummaryComment><VirtualProp>False</VirtualProp><IncludeSerializeMethod>False</IncludeSerializeMethod><UseBaseClass>False</UseBaseClass><GenBaseClass>False</GenBaseClass><GenerateCloneMethod>False</GenerateCloneMethod><GenerateDataContracts>False</GenerateDataContracts><CodeBaseTag>Net40</CodeBaseTag><SerializeMethodName>Serialize</SerializeMethodName><DeserializeMethodName>Deserialize</DeserializeMethodName><SaveToFileMethodName>SaveToFile</SaveToFileMethodName><LoadFromFileMethodName>LoadFromFile</LoadFromFileMethodName><GenerateXMLAttributes>True</GenerateXMLAttributes><EnableEncoding>False</EnableEncoding><AutomaticProperties>False</AutomaticProperties><GenerateShouldSerialize>False</GenerateShouldSerialize><DisableDebug>False</DisableDebug><PropNameSpecified>Default</PropNameSpecified><Encoder>UTF8</Encoder><CustomUsings></CustomUsings><ExcludeIncludedTypes>False</ExcludeIncludedTypes><EnableInitializeFields>True</EnableInitializeFields>
//  </auto-generated>
// ------------------------------------------------------------------------------
namespace MasterCard.SDK.Services.RepowerReversalService.Domain
{
    using System;
    using System.Diagnostics;
    using System.Xml.Serialization;
    using System.Collections;
    using System.Xml.Schema;
    using System.ComponentModel;
    using System.Collections.Generic;


    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18060")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class RepowerReversal
    {

        private int requestIdField;

        private string originalRequestIdField;

        private string transactionReferenceField;

        private RepowerReversalTransactionHistory transactionHistoryField;

        public RepowerReversal()
        {
            this.transactionHistoryField = new RepowerReversalTransactionHistory();
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public int RequestId
        {
            get
            {
                return this.requestIdField;
            }
            set
            {
                this.requestIdField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer", Order = 1)]
        public string OriginalRequestId
        {
            get
            {
                return this.originalRequestIdField;
            }
            set
            {
                this.originalRequestIdField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string TransactionReference
        {
            get
            {
                return this.transactionReferenceField;
            }
            set
            {
                this.transactionReferenceField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public RepowerReversalTransactionHistory TransactionHistory
        {
            get
            {
                return this.transactionHistoryField;
            }
            set
            {
                this.transactionHistoryField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18060")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RepowerReversalTransactionHistory
    {

        private RepowerReversalTransactionHistoryTransaction transactionField;

        public RepowerReversalTransactionHistory()
        {
            this.transactionField = new RepowerReversalTransactionHistoryTransaction();
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public RepowerReversalTransactionHistoryTransaction Transaction
        {
            get
            {
                return this.transactionField;
            }
            set
            {
                this.transactionField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18060")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RepowerReversalTransactionHistoryTransaction
    {

        private string typeField;

        private int systemTraceAuditNumberField;

        private string networkReferenceNumberField;

        private string settlementDateField;

        private RepowerReversalTransactionHistoryTransactionResponse responseField;

        private System.DateTime submitDateTimeField;

        public RepowerReversalTransactionHistoryTransaction()
        {
            this.responseField = new RepowerReversalTransactionHistoryTransactionResponse();
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string Type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public int SystemTraceAuditNumber
        {
            get
            {
                return this.systemTraceAuditNumberField;
            }
            set
            {
                this.systemTraceAuditNumberField = value;
            }
        }

        /**[XmlIgnore]
        public int NetworkReferenceNumber { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        [XmlElement(ElementName = "NetworkReferenceNumber")]
        public string NetworkReferenceNumberString
        {
            get
            {
                return this.networkReferenceNumberField.ToString();
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    this.networkReferenceNumberField = 0;
                }
                else
                {
                    this.networkReferenceNumberField = int.Parse(value);
                }
            }
        }**/

        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string NetworkReferenceNumber
        {
            get
            {
                if (string.IsNullOrEmpty(this.networkReferenceNumberField))
                {
                    return string.Empty;
                }
                else
                {
                    return this.networkReferenceNumberField;
                }
            }
            set
            {
                if (value == null)
                {
                    this.networkReferenceNumberField = "";
                }
                else
                {
                    this.networkReferenceNumberField = value;
                }
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string SettlementDate
        {
            get
            {
                return this.settlementDateField;
            }
            set
            {
                this.settlementDateField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public RepowerReversalTransactionHistoryTransactionResponse Response
        {
            get
            {
                return this.responseField;
            }
            set
            {
                this.responseField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public System.DateTime SubmitDateTime
        {
            get
            {
                return this.submitDateTimeField;
            }
            set
            {
                this.submitDateTimeField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18060")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RepowerReversalTransactionHistoryTransactionResponse
    {

        private string codeField;

        private string descriptionField;

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string Code
        {
            get
            {
                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
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
    }
}
