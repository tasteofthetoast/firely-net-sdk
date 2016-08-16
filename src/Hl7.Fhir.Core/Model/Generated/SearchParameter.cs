﻿using System;
using System.Collections.Generic;
using Hl7.Fhir.Introspection;
using Hl7.Fhir.Validation;
using System.Linq;
using System.Runtime.Serialization;
using System.ComponentModel;

/*
  Copyright (c) 2011+, HL7, Inc.
  All rights reserved.
  
  Redistribution and use in source and binary forms, with or without modification, 
  are permitted provided that the following conditions are met:
  
   * Redistributions of source code must retain the above copyright notice, this 
     list of conditions and the following disclaimer.
   * Redistributions in binary form must reproduce the above copyright notice, 
     this list of conditions and the following disclaimer in the documentation 
     and/or other materials provided with the distribution.
   * Neither the name of HL7 nor the names of its contributors may be used to 
     endorse or promote products derived from this software without specific 
     prior written permission.
  
  THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND 
  ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED 
  WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED. 
  IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, 
  INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT 
  NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR 
  PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, 
  WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) 
  ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE 
  POSSIBILITY OF SUCH DAMAGE.
  

*/

//
// Generated for FHIR v1.6.0
//
namespace Hl7.Fhir.Model
{
    /// <summary>
    /// Search Parameter for a resource
    /// </summary>
    [FhirType("SearchParameter", IsResource=true)]
    [DataContract]
    public partial class SearchParameter : Hl7.Fhir.Model.DomainResource, System.ComponentModel.INotifyPropertyChanged
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.SearchParameter; } }
        [NotMapped]
        public override string TypeName { get { return "SearchParameter"; } }
        
        /// <summary>
        /// How a search parameter relates to the set of elements returned by evaluating its xpath query.
        /// (url: http://hl7.org/fhir/ValueSet/search-xpath-usage)
        /// </summary>
        [FhirEnumeration("XPathUsageType")]
        public enum XPathUsageType
        {
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/search-xpath-usage)
            /// </summary>
            [EnumLiteral("normal"), Description("Normal")]
            Normal,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/search-xpath-usage)
            /// </summary>
            [EnumLiteral("phonetic"), Description("Phonetic")]
            Phonetic,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/search-xpath-usage)
            /// </summary>
            [EnumLiteral("nearby"), Description("Nearby")]
            Nearby,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/search-xpath-usage)
            /// </summary>
            [EnumLiteral("distance"), Description("Distance")]
            Distance,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/search-xpath-usage)
            /// </summary>
            [EnumLiteral("other"), Description("Other")]
            Other,
        }

        [FhirType("ContactComponent")]
        [DataContract]
        public partial class ContactComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "ContactComponent"; } }
            
            /// <summary>
            /// Name of an individual to contact
            /// </summary>
            [FhirElement("name", InSummary=true, Order=40)]
            [DataMember]
            public Hl7.Fhir.Model.FhirString NameElement
            {
                get { return _NameElement; }
                set { _NameElement = value; OnPropertyChanged("NameElement"); }
            }
            
            private Hl7.Fhir.Model.FhirString _NameElement;
            
            /// <summary>
            /// Name of an individual to contact
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string Name
            {
                get { return NameElement != null ? NameElement.Value : null; }
                set
                {
                if (value == null)
                      NameElement = null; 
                    else
                        NameElement = new Hl7.Fhir.Model.FhirString(value);
                    OnPropertyChanged("Name");
                }
            }
            
            /// <summary>
            /// Contact details for individual or publisher
            /// </summary>
            [FhirElement("telecom", InSummary=true, Order=50)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.ContactPoint> Telecom
            {
                get { if(_Telecom==null) _Telecom = new List<Hl7.Fhir.Model.ContactPoint>(); return _Telecom; }
                set { _Telecom = value; OnPropertyChanged("Telecom"); }
            }
            
            private List<Hl7.Fhir.Model.ContactPoint> _Telecom;
            
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as ContactComponent;
                
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(NameElement != null) dest.NameElement = (Hl7.Fhir.Model.FhirString)NameElement.DeepCopy();
                    if(Telecom != null) dest.Telecom = new List<Hl7.Fhir.Model.ContactPoint>(Telecom.DeepCopy());
                    return dest;
                }
                else
                	throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                return CopyTo(new ContactComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as ContactComponent;
                if(otherT == null) return false;
                
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(NameElement, otherT.NameElement)) return false;
                if( !DeepComparable.Matches(Telecom, otherT.Telecom)) return false;
                
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ContactComponent;
                if(otherT == null) return false;
                
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(NameElement, otherT.NameElement)) return false;
                if( !DeepComparable.IsExactly(Telecom, otherT.Telecom)) return false;
                
                return true;
            }
            
        }
        
        
        /// <summary>
        /// Absolute URL used to reference this search parameter
        /// </summary>
        [FhirElement("url", InSummary=true, Order=90)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Hl7.Fhir.Model.FhirUri UrlElement
        {
            get { return _UrlElement; }
            set { _UrlElement = value; OnPropertyChanged("UrlElement"); }
        }
        
        private Hl7.Fhir.Model.FhirUri _UrlElement;
        
        /// <summary>
        /// Absolute URL used to reference this search parameter
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public string Url
        {
            get { return UrlElement != null ? UrlElement.Value : null; }
            set
            {
                if (value == null)
                  UrlElement = null; 
                else
                  UrlElement = new Hl7.Fhir.Model.FhirUri(value);
                OnPropertyChanged("Url");
            }
        }
        
        /// <summary>
        /// Informal name for this search parameter
        /// </summary>
        [FhirElement("name", InSummary=true, Order=100)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Hl7.Fhir.Model.FhirString NameElement
        {
            get { return _NameElement; }
            set { _NameElement = value; OnPropertyChanged("NameElement"); }
        }
        
        private Hl7.Fhir.Model.FhirString _NameElement;
        
        /// <summary>
        /// Informal name for this search parameter
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public string Name
        {
            get { return NameElement != null ? NameElement.Value : null; }
            set
            {
                if (value == null)
                  NameElement = null; 
                else
                  NameElement = new Hl7.Fhir.Model.FhirString(value);
                OnPropertyChanged("Name");
            }
        }
        
        /// <summary>
        /// draft | active | retired
        /// </summary>
        [FhirElement("status", InSummary=true, Order=110)]
        [DataMember]
        public Code<Hl7.Fhir.Model.ConformanceResourceStatus> StatusElement
        {
            get { return _StatusElement; }
            set { _StatusElement = value; OnPropertyChanged("StatusElement"); }
        }
        
        private Code<Hl7.Fhir.Model.ConformanceResourceStatus> _StatusElement;
        
        /// <summary>
        /// draft | active | retired
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public Hl7.Fhir.Model.ConformanceResourceStatus? Status
        {
            get { return StatusElement != null ? StatusElement.Value : null; }
            set
            {
                if (!value.HasValue)
                  StatusElement = null; 
                else
                  StatusElement = new Code<Hl7.Fhir.Model.ConformanceResourceStatus>(value);
                OnPropertyChanged("Status");
            }
        }
        
        /// <summary>
        /// If for testing purposes, not real usage
        /// </summary>
        [FhirElement("experimental", InSummary=true, Order=120)]
        [DataMember]
        public Hl7.Fhir.Model.FhirBoolean ExperimentalElement
        {
            get { return _ExperimentalElement; }
            set { _ExperimentalElement = value; OnPropertyChanged("ExperimentalElement"); }
        }
        
        private Hl7.Fhir.Model.FhirBoolean _ExperimentalElement;
        
        /// <summary>
        /// If for testing purposes, not real usage
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public bool? Experimental
        {
            get { return ExperimentalElement != null ? ExperimentalElement.Value : null; }
            set
            {
                if (!value.HasValue)
                  ExperimentalElement = null; 
                else
                  ExperimentalElement = new Hl7.Fhir.Model.FhirBoolean(value);
                OnPropertyChanged("Experimental");
            }
        }
        
        /// <summary>
        /// Publication Date(/time)
        /// </summary>
        [FhirElement("date", InSummary=true, Order=130)]
        [DataMember]
        public Hl7.Fhir.Model.FhirDateTime DateElement
        {
            get { return _DateElement; }
            set { _DateElement = value; OnPropertyChanged("DateElement"); }
        }
        
        private Hl7.Fhir.Model.FhirDateTime _DateElement;
        
        /// <summary>
        /// Publication Date(/time)
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public string Date
        {
            get { return DateElement != null ? DateElement.Value : null; }
            set
            {
                if (value == null)
                  DateElement = null; 
                else
                  DateElement = new Hl7.Fhir.Model.FhirDateTime(value);
                OnPropertyChanged("Date");
            }
        }
        
        /// <summary>
        /// Name of the publisher (Organization or individual)
        /// </summary>
        [FhirElement("publisher", InSummary=true, Order=140)]
        [DataMember]
        public Hl7.Fhir.Model.FhirString PublisherElement
        {
            get { return _PublisherElement; }
            set { _PublisherElement = value; OnPropertyChanged("PublisherElement"); }
        }
        
        private Hl7.Fhir.Model.FhirString _PublisherElement;
        
        /// <summary>
        /// Name of the publisher (Organization or individual)
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public string Publisher
        {
            get { return PublisherElement != null ? PublisherElement.Value : null; }
            set
            {
                if (value == null)
                  PublisherElement = null; 
                else
                  PublisherElement = new Hl7.Fhir.Model.FhirString(value);
                OnPropertyChanged("Publisher");
            }
        }
        
        /// <summary>
        /// Contact details of the publisher
        /// </summary>
        [FhirElement("contact", InSummary=true, Order=150)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.SearchParameter.ContactComponent> Contact
        {
            get { if(_Contact==null) _Contact = new List<Hl7.Fhir.Model.SearchParameter.ContactComponent>(); return _Contact; }
            set { _Contact = value; OnPropertyChanged("Contact"); }
        }
        
        private List<Hl7.Fhir.Model.SearchParameter.ContactComponent> _Contact;
        
        /// <summary>
        /// Content intends to support these contexts
        /// </summary>
        [FhirElement("useContext", InSummary=true, Order=160)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.CodeableConcept> UseContext
        {
            get { if(_UseContext==null) _UseContext = new List<Hl7.Fhir.Model.CodeableConcept>(); return _UseContext; }
            set { _UseContext = value; OnPropertyChanged("UseContext"); }
        }
        
        private List<Hl7.Fhir.Model.CodeableConcept> _UseContext;
        
        /// <summary>
        /// Why this search parameter is defined
        /// </summary>
        [FhirElement("requirements", Order=170)]
        [DataMember]
        public Hl7.Fhir.Model.Markdown Requirements
        {
            get { return _Requirements; }
            set { _Requirements = value; OnPropertyChanged("Requirements"); }
        }
        
        private Hl7.Fhir.Model.Markdown _Requirements;
        
        /// <summary>
        /// Code used in URL
        /// </summary>
        [FhirElement("code", InSummary=true, Order=180)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Hl7.Fhir.Model.Code CodeElement
        {
            get { return _CodeElement; }
            set { _CodeElement = value; OnPropertyChanged("CodeElement"); }
        }
        
        private Hl7.Fhir.Model.Code _CodeElement;
        
        /// <summary>
        /// Code used in URL
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public string Code
        {
            get { return CodeElement != null ? CodeElement.Value : null; }
            set
            {
                if (value == null)
                  CodeElement = null; 
                else
                  CodeElement = new Hl7.Fhir.Model.Code(value);
                OnPropertyChanged("Code");
            }
        }
        
        /// <summary>
        /// The resource type this search parameter applies to
        /// </summary>
        [FhirElement("base", InSummary=true, Order=190)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Code<Hl7.Fhir.Model.ResourceType> BaseElement
        {
            get { return _BaseElement; }
            set { _BaseElement = value; OnPropertyChanged("BaseElement"); }
        }
        
        private Code<Hl7.Fhir.Model.ResourceType> _BaseElement;
        
        /// <summary>
        /// The resource type this search parameter applies to
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public Hl7.Fhir.Model.ResourceType? Base
        {
            get { return BaseElement != null ? BaseElement.Value : null; }
            set
            {
                if (!value.HasValue)
                  BaseElement = null; 
                else
                  BaseElement = new Code<Hl7.Fhir.Model.ResourceType>(value);
                OnPropertyChanged("Base");
            }
        }
        
        /// <summary>
        /// number | date | string | token | reference | composite | quantity | uri
        /// </summary>
        [FhirElement("type", InSummary=true, Order=200)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Code<Hl7.Fhir.Model.SearchParamType> TypeElement
        {
            get { return _TypeElement; }
            set { _TypeElement = value; OnPropertyChanged("TypeElement"); }
        }
        
        private Code<Hl7.Fhir.Model.SearchParamType> _TypeElement;
        
        /// <summary>
        /// number | date | string | token | reference | composite | quantity | uri
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public Hl7.Fhir.Model.SearchParamType? Type
        {
            get { return TypeElement != null ? TypeElement.Value : null; }
            set
            {
                if (!value.HasValue)
                  TypeElement = null; 
                else
                  TypeElement = new Code<Hl7.Fhir.Model.SearchParamType>(value);
                OnPropertyChanged("Type");
            }
        }
        
        /// <summary>
        /// Documentation for  search parameter
        /// </summary>
        [FhirElement("description", InSummary=true, Order=210)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Hl7.Fhir.Model.Markdown Description
        {
            get { return _Description; }
            set { _Description = value; OnPropertyChanged("Description"); }
        }
        
        private Hl7.Fhir.Model.Markdown _Description;
        
        /// <summary>
        /// FluentPath expression that extracts the values
        /// </summary>
        [FhirElement("expression", Order=220)]
        [DataMember]
        public Hl7.Fhir.Model.FhirString ExpressionElement
        {
            get { return _ExpressionElement; }
            set { _ExpressionElement = value; OnPropertyChanged("ExpressionElement"); }
        }
        
        private Hl7.Fhir.Model.FhirString _ExpressionElement;
        
        /// <summary>
        /// FluentPath expression that extracts the values
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public string Expression
        {
            get { return ExpressionElement != null ? ExpressionElement.Value : null; }
            set
            {
                if (value == null)
                  ExpressionElement = null; 
                else
                  ExpressionElement = new Hl7.Fhir.Model.FhirString(value);
                OnPropertyChanged("Expression");
            }
        }
        
        /// <summary>
        /// XPath that extracts the values
        /// </summary>
        [FhirElement("xpath", Order=230)]
        [DataMember]
        public Hl7.Fhir.Model.FhirString XpathElement
        {
            get { return _XpathElement; }
            set { _XpathElement = value; OnPropertyChanged("XpathElement"); }
        }
        
        private Hl7.Fhir.Model.FhirString _XpathElement;
        
        /// <summary>
        /// XPath that extracts the values
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public string Xpath
        {
            get { return XpathElement != null ? XpathElement.Value : null; }
            set
            {
                if (value == null)
                  XpathElement = null; 
                else
                  XpathElement = new Hl7.Fhir.Model.FhirString(value);
                OnPropertyChanged("Xpath");
            }
        }
        
        /// <summary>
        /// normal | phonetic | nearby | distance | other
        /// </summary>
        [FhirElement("xpathUsage", Order=240)]
        [DataMember]
        public Code<Hl7.Fhir.Model.SearchParameter.XPathUsageType> XpathUsageElement
        {
            get { return _XpathUsageElement; }
            set { _XpathUsageElement = value; OnPropertyChanged("XpathUsageElement"); }
        }
        
        private Code<Hl7.Fhir.Model.SearchParameter.XPathUsageType> _XpathUsageElement;
        
        /// <summary>
        /// normal | phonetic | nearby | distance | other
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public Hl7.Fhir.Model.SearchParameter.XPathUsageType? XpathUsage
        {
            get { return XpathUsageElement != null ? XpathUsageElement.Value : null; }
            set
            {
                if (!value.HasValue)
                  XpathUsageElement = null; 
                else
                  XpathUsageElement = new Code<Hl7.Fhir.Model.SearchParameter.XPathUsageType>(value);
                OnPropertyChanged("XpathUsage");
            }
        }
        
        /// <summary>
        /// Types of resource (if a resource reference)
        /// </summary>
        [FhirElement("target", Order=250)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Code<Hl7.Fhir.Model.ResourceType>> TargetElement
        {
            get { if(_TargetElement==null) _TargetElement = new List<Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ResourceType>>(); return _TargetElement; }
            set { _TargetElement = value; OnPropertyChanged("TargetElement"); }
        }
        
        private List<Code<Hl7.Fhir.Model.ResourceType>> _TargetElement;
        
        /// <summary>
        /// Types of resource (if a resource reference)
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public IEnumerable<Hl7.Fhir.Model.ResourceType?> Target
        {
            get { return TargetElement != null ? TargetElement.Select(elem => elem.Value) : null; }
            set
            {
                if (value == null)
                  TargetElement = null; 
                else
                  TargetElement = new List<Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ResourceType>>(value.Select(elem=>new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ResourceType>(elem)));
                OnPropertyChanged("Target");
            }
        }
        
        /// <summary>
        /// For Composite resources to define the parts
        /// </summary>
        [FhirElement("component", Order=260)]
        [References("SearchParameter")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.ResourceReference> Component
        {
            get { if(_Component==null) _Component = new List<Hl7.Fhir.Model.ResourceReference>(); return _Component; }
            set { _Component = value; OnPropertyChanged("Component"); }
        }
        
        private List<Hl7.Fhir.Model.ResourceReference> _Component;
        

        public static ElementDefinition.ConstraintComponent SearchParameter_SPD_1 = new ElementDefinition.ConstraintComponent()
        {
            Expression = "xpath.empty() or xpathUsage.exists()",
            Key = "spd-1",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "If an xpath is present, there SHALL be an xpathUsage",
            Xpath = "not(exists(f:xpath)) or exists(f:xpathUsage)"
        };

        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as SearchParameter;
            
            if (dest != null)
            {
                base.CopyTo(dest);
                if(UrlElement != null) dest.UrlElement = (Hl7.Fhir.Model.FhirUri)UrlElement.DeepCopy();
                if(NameElement != null) dest.NameElement = (Hl7.Fhir.Model.FhirString)NameElement.DeepCopy();
                if(StatusElement != null) dest.StatusElement = (Code<Hl7.Fhir.Model.ConformanceResourceStatus>)StatusElement.DeepCopy();
                if(ExperimentalElement != null) dest.ExperimentalElement = (Hl7.Fhir.Model.FhirBoolean)ExperimentalElement.DeepCopy();
                if(DateElement != null) dest.DateElement = (Hl7.Fhir.Model.FhirDateTime)DateElement.DeepCopy();
                if(PublisherElement != null) dest.PublisherElement = (Hl7.Fhir.Model.FhirString)PublisherElement.DeepCopy();
                if(Contact != null) dest.Contact = new List<Hl7.Fhir.Model.SearchParameter.ContactComponent>(Contact.DeepCopy());
                if(UseContext != null) dest.UseContext = new List<Hl7.Fhir.Model.CodeableConcept>(UseContext.DeepCopy());
                if(Requirements != null) dest.Requirements = (Hl7.Fhir.Model.Markdown)Requirements.DeepCopy();
                if(CodeElement != null) dest.CodeElement = (Hl7.Fhir.Model.Code)CodeElement.DeepCopy();
                if(BaseElement != null) dest.BaseElement = (Code<Hl7.Fhir.Model.ResourceType>)BaseElement.DeepCopy();
                if(TypeElement != null) dest.TypeElement = (Code<Hl7.Fhir.Model.SearchParamType>)TypeElement.DeepCopy();
                if(Description != null) dest.Description = (Hl7.Fhir.Model.Markdown)Description.DeepCopy();
                if(ExpressionElement != null) dest.ExpressionElement = (Hl7.Fhir.Model.FhirString)ExpressionElement.DeepCopy();
                if(XpathElement != null) dest.XpathElement = (Hl7.Fhir.Model.FhirString)XpathElement.DeepCopy();
                if(XpathUsageElement != null) dest.XpathUsageElement = (Code<Hl7.Fhir.Model.SearchParameter.XPathUsageType>)XpathUsageElement.DeepCopy();
                if(TargetElement != null) dest.TargetElement = new List<Code<Hl7.Fhir.Model.ResourceType>>(TargetElement.DeepCopy());
                if(Component != null) dest.Component = new List<Hl7.Fhir.Model.ResourceReference>(Component.DeepCopy());
                return dest;
            }
            else
            	throw new ArgumentException("Can only copy to an object of the same type", "other");
        }
        
        public override IDeepCopyable DeepCopy()
        {
            return CopyTo(new SearchParameter());
        }
        
        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as SearchParameter;
            if(otherT == null) return false;
            
            if(!base.Matches(otherT)) return false;
            if( !DeepComparable.Matches(UrlElement, otherT.UrlElement)) return false;
            if( !DeepComparable.Matches(NameElement, otherT.NameElement)) return false;
            if( !DeepComparable.Matches(StatusElement, otherT.StatusElement)) return false;
            if( !DeepComparable.Matches(ExperimentalElement, otherT.ExperimentalElement)) return false;
            if( !DeepComparable.Matches(DateElement, otherT.DateElement)) return false;
            if( !DeepComparable.Matches(PublisherElement, otherT.PublisherElement)) return false;
            if( !DeepComparable.Matches(Contact, otherT.Contact)) return false;
            if( !DeepComparable.Matches(UseContext, otherT.UseContext)) return false;
            if( !DeepComparable.Matches(Requirements, otherT.Requirements)) return false;
            if( !DeepComparable.Matches(CodeElement, otherT.CodeElement)) return false;
            if( !DeepComparable.Matches(BaseElement, otherT.BaseElement)) return false;
            if( !DeepComparable.Matches(TypeElement, otherT.TypeElement)) return false;
            if( !DeepComparable.Matches(Description, otherT.Description)) return false;
            if( !DeepComparable.Matches(ExpressionElement, otherT.ExpressionElement)) return false;
            if( !DeepComparable.Matches(XpathElement, otherT.XpathElement)) return false;
            if( !DeepComparable.Matches(XpathUsageElement, otherT.XpathUsageElement)) return false;
            if( !DeepComparable.Matches(TargetElement, otherT.TargetElement)) return false;
            if( !DeepComparable.Matches(Component, otherT.Component)) return false;
            
            return true;
        }
        
        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as SearchParameter;
            if(otherT == null) return false;
            
            if(!base.IsExactly(otherT)) return false;
            if( !DeepComparable.IsExactly(UrlElement, otherT.UrlElement)) return false;
            if( !DeepComparable.IsExactly(NameElement, otherT.NameElement)) return false;
            if( !DeepComparable.IsExactly(StatusElement, otherT.StatusElement)) return false;
            if( !DeepComparable.IsExactly(ExperimentalElement, otherT.ExperimentalElement)) return false;
            if( !DeepComparable.IsExactly(DateElement, otherT.DateElement)) return false;
            if( !DeepComparable.IsExactly(PublisherElement, otherT.PublisherElement)) return false;
            if( !DeepComparable.IsExactly(Contact, otherT.Contact)) return false;
            if( !DeepComparable.IsExactly(UseContext, otherT.UseContext)) return false;
            if( !DeepComparable.IsExactly(Requirements, otherT.Requirements)) return false;
            if( !DeepComparable.IsExactly(CodeElement, otherT.CodeElement)) return false;
            if( !DeepComparable.IsExactly(BaseElement, otherT.BaseElement)) return false;
            if( !DeepComparable.IsExactly(TypeElement, otherT.TypeElement)) return false;
            if( !DeepComparable.IsExactly(Description, otherT.Description)) return false;
            if( !DeepComparable.IsExactly(ExpressionElement, otherT.ExpressionElement)) return false;
            if( !DeepComparable.IsExactly(XpathElement, otherT.XpathElement)) return false;
            if( !DeepComparable.IsExactly(XpathUsageElement, otherT.XpathUsageElement)) return false;
            if( !DeepComparable.IsExactly(TargetElement, otherT.TargetElement)) return false;
            if( !DeepComparable.IsExactly(Component, otherT.Component)) return false;
            
            return true;
        }
        
    }
    
}