// ------------------------------------------------------------------------------
//  <auto-generated>
//    Generated by Xsd2Code. Version 3.4.0.37595
//    <NameSpace>csharp_openapi</NameSpace><Collection>List</Collection><codeType>CSharp</codeType><EnableDataBinding>False</EnableDataBinding><EnableLazyLoading>False</EnableLazyLoading><TrackingChangesEnable>False</TrackingChangesEnable><GenTrackingClasses>False</GenTrackingClasses><HidePrivateFieldInIDE>False</HidePrivateFieldInIDE><EnableSummaryComment>False</EnableSummaryComment><VirtualProp>False</VirtualProp><IncludeSerializeMethod>False</IncludeSerializeMethod><UseBaseClass>False</UseBaseClass><GenBaseClass>False</GenBaseClass><GenerateCloneMethod>False</GenerateCloneMethod><GenerateDataContracts>False</GenerateDataContracts><CodeBaseTag>Net40</CodeBaseTag><SerializeMethodName>Serialize</SerializeMethodName><DeserializeMethodName>Deserialize</DeserializeMethodName><SaveToFileMethodName>SaveToFile</SaveToFileMethodName><LoadFromFileMethodName>LoadFromFile</LoadFromFileMethodName><GenerateXMLAttributes>True</GenerateXMLAttributes><EnableEncoding>False</EnableEncoding><AutomaticProperties>False</AutomaticProperties><GenerateShouldSerialize>False</GenerateShouldSerialize><DisableDebug>False</DisableDebug><PropNameSpecified>Default</PropNameSpecified><Encoder>UTF8</Encoder><CustomUsings></CustomUsings><ExcludeIncludedTypes>False</ExcludeIncludedTypes><EnableInitializeFields>True</EnableInitializeFields>
//  </auto-generated>
// ------------------------------------------------------------------------------
namespace MasterCard.SDK.Services.PartnerWallet.Domain
{
    using System;
    using System.Diagnostics;
    using System.Xml.Serialization;
    using System.Collections;
    using System.Xml.Schema;
    using System.ComponentModel;
    using System.Collections.Generic;


    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class WalletPrecheckoutDataRequest
    {

        private string oauthTokenField;

        private int consumerWalletIdField;

        private long precheckoutTransactionIdField;

        private WalletPrecheckoutDataRequestPairingDataTypes pairingDataTypesField;

        private string walletIdField;

        public WalletPrecheckoutDataRequest()
        {
            this.pairingDataTypesField = new WalletPrecheckoutDataRequestPairingDataTypes();
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string OauthToken
        {
            get
            {
                return this.oauthTokenField;
            }
            set
            {
                this.oauthTokenField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public int ConsumerWalletId
        {
            get
            {
                return this.consumerWalletIdField;
            }
            set
            {
                this.consumerWalletIdField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public long PrecheckoutTransactionId
        {
            get
            {
                return this.precheckoutTransactionIdField;
            }
            set
            {
                this.precheckoutTransactionIdField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public WalletPrecheckoutDataRequestPairingDataTypes PairingDataTypes
        {
            get
            {
                return this.pairingDataTypesField;
            }
            set
            {
                this.pairingDataTypesField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public string WalletId
        {
            get
            {
                return this.walletIdField;
            }
            set
            {
                this.walletIdField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class WalletPrecheckoutDataRequestPairingDataTypes
    {

        private WalletPrecheckoutDataRequestPairingDataTypesPairingDataType pairingDataTypeField;

        public WalletPrecheckoutDataRequestPairingDataTypes()
        {
            this.pairingDataTypeField = new WalletPrecheckoutDataRequestPairingDataTypesPairingDataType();
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public WalletPrecheckoutDataRequestPairingDataTypesPairingDataType PairingDataType
        {
            get
            {
                return this.pairingDataTypeField;
            }
            set
            {
                this.pairingDataTypeField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class WalletPrecheckoutDataRequestPairingDataTypesPairingDataType
    {

        private string typeField;

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
    }
}
