﻿#pragma warning disable 1591

namespace TripleS.v30 {
	//------------------------------------------------------------------------------
	// <auto-generated>
	//     This code was generated by a tool.
	//     Runtime Version:4.0.30319.42000
	//
	//     Changes to this file may cause incorrect behavior and will be lost if
	//     the code is regenerated.
	// </auto-generated>
	//------------------------------------------------------------------------------

	using System.Xml.Serialization;

	// 
	// This source code was auto-generated by xsd, Version=4.6.1055.0.
	// 


	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/sss_v30")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/sss_v30", IsNullable = false)]
	public partial class br {
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/sss_v30")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/sss_v30", IsNullable = false)]
	public partial class text {

		private br[] itemsField;

		private string[] textField;

		private string langField;

		private textMode modeField;

		private bool modeFieldSpecified;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("br")]
		public br[] Items {
			get {
				return this.itemsField;
			}
			set {
				this.itemsField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlTextAttribute()]
		public string[] Text {
			get {
				return this.textField;
			}
			set {
				this.textField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/XML/1998/namespace")]
		public string lang {
			get {
				return this.langField;
			}
			set {
				this.langField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public textMode mode {
			get {
				return this.modeField;
			}
			set {
				this.modeField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool modeSpecified {
			get {
				return this.modeFieldSpecified;
			}
			set {
				this.modeFieldSpecified = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/sss_v30")]
	public enum textMode {

		/// <remarks/>
		interview,

		/// <remarks/>
		analysis,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/sss_v30")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/sss_v30", IsNullable = false)]
	public partial class sss {

		private string dateField;

		private string timeField;

		private string originField;

		private string userField;

		private style[] styleField;

		private object itemField;

		private sssVersion versionField;

		private string langField;

		private string languagesField;

		private string modesField;

		/// <remarks/>
		public string date {
			get {
				return this.dateField;
			}
			set {
				this.dateField = value;
			}
		}

		/// <remarks/>
		public string time {
			get {
				return this.timeField;
			}
			set {
				this.timeField = value;
			}
		}

		/// <remarks/>
		public string origin {
			get {
				return this.originField;
			}
			set {
				this.originField = value;
			}
		}

		/// <remarks/>
		public string user {
			get {
				return this.userField;
			}
			set {
				this.userField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("style")]
		public style[] style {
			get {
				return this.styleField;
			}
			set {
				this.styleField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("hierarchy", typeof(hierarchy))]
		[System.Xml.Serialization.XmlElementAttribute("survey", typeof(survey))]
		public object Item {
			get {
				return this.itemField;
			}
			set {
				this.itemField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public sssVersion version {
			get {
				return this.versionField;
			}
			set {
				this.versionField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/XML/1998/namespace")]
		public string lang {
			get {
				return this.langField;
			}
			set {
				this.langField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute(DataType = "NMTOKENS")]
		public string languages {
			get {
				return this.languagesField;
			}
			set {
				this.languagesField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute(DataType = "NMTOKENS")]
		public string modes {
			get {
				return this.modesField;
			}
			set {
				this.modesField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/sss_v30")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/sss_v30", IsNullable = false)]
	public partial class style {

		private string hrefField;

		private string valueField;

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string href {
			get {
				return this.hrefField;
			}
			set {
				this.hrefField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlTextAttribute()]
		public string Value {
			get {
				return this.valueField;
			}
			set {
				this.valueField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/sss_v30")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/sss_v30", IsNullable = false)]
	public partial class hierarchy {

		private level[] levelField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("level")]
		public level[] level {
			get {
				return this.levelField;
			}
			set {
				this.levelField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/sss_v30")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/sss_v30", IsNullable = false)]
	public partial class level {

		private parent[] parentField;

		private string identField;

		private string hrefField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("parent")]
		public parent[] parent {
			get {
				return this.parentField;
			}
			set {
				this.parentField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string ident {
			get {
				return this.identField;
			}
			set {
				this.identField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string href {
			get {
				return this.hrefField;
			}
			set {
				this.hrefField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/sss_v30")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/sss_v30", IsNullable = false)]
	public partial class parent {

		private string levelField;

		private string linkvarField;

		private parentOrdered orderedField;

		private bool orderedFieldSpecified;

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string level {
			get {
				return this.levelField;
			}
			set {
				this.levelField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string linkvar {
			get {
				return this.linkvarField;
			}
			set {
				this.linkvarField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public parentOrdered ordered {
			get {
				return this.orderedField;
			}
			set {
				this.orderedField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool orderedSpecified {
			get {
				return this.orderedFieldSpecified;
			}
			set {
				this.orderedFieldSpecified = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/sss_v30")]
	public enum parentOrdered {

		/// <remarks/>
		yes,

		/// <remarks/>
		no,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/sss_v30")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/sss_v30", IsNullable = false)]
	public partial class survey {

		private string nameField;

		private string versionField;

		private title titleField;

		private sssRecord recordField;

		/// <remarks/>
		public string name {
			get {
				return this.nameField;
			}
			set {
				this.nameField = value;
			}
		}

		/// <remarks/>
		public string version {
			get {
				return this.versionField;
			}
			set {
				this.versionField = value;
			}
		}

		/// <remarks/>
		public title title {
			get {
				return this.titleField;
			}
			set {
				this.titleField = value;
			}
		}

		/// <remarks/>
		public sssRecord record {
			get {
				return this.recordField;
			}
			set {
				this.recordField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/sss_v30")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/sss_v30", IsNullable = false)]
	public partial class title {

		private object[] itemsField;

		private string[] textField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("br", typeof(br))]
		[System.Xml.Serialization.XmlElementAttribute("text", typeof(text))]
		public object[] Items {
			get {
				return this.itemsField;
			}
			set {
				this.itemsField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlTextAttribute()]
		public string[] Text {
			get {
				return this.textField;
			}
			set {
				this.textField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/sss_v30")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/sss_v30", IsNullable = false)]
	public partial class sssRecord {

		private variable[] variableField;

		private string identField;

		private string hrefField;

		private recordFormat formatField;

		private recordEncoding encodingField;

		private string skipField;

		public sssRecord() {
			this.formatField = recordFormat.@fixed;
			this.encodingField = recordEncoding.Windows1252;
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("variable")]
		public variable[] variable {
			get {
				return this.variableField;
			}
			set {
				this.variableField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string ident {
			get {
				return this.identField;
			}
			set {
				this.identField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string href {
			get {
				return this.hrefField;
			}
			set {
				this.hrefField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute(recordFormat.@fixed)]
		public recordFormat format {
			get {
				return this.formatField;
			}
			set {
				this.formatField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute(recordEncoding.Windows1252)]
		public recordEncoding encoding {
			get {
				return this.encodingField;
			}
			set {
				this.encodingField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string skip {
			get {
				return this.skipField;
			}
			set {
				this.skipField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/sss_v30")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/sss_v30", IsNullable = false)]
	public partial class variable {

		private string nameField;

		private label labelField;

		private position positionField;

		private string filterField;

		private object[] itemsField;

		private string identField;

		private variableType typeField;

		private variableUse useField;

		private bool useFieldSpecified;

		private variableFormat formatField;

		private bool formatFieldSpecified;

		/// <remarks/>
		public string name {
			get {
				return this.nameField;
			}
			set {
				this.nameField = value;
			}
		}

		/// <remarks/>
		public label label {
			get {
				return this.labelField;
			}
			set {
				this.labelField = value;
			}
		}

		/// <remarks/>
		public position position {
			get {
				return this.positionField;
			}
			set {
				this.positionField = value;
			}
		}

		/// <remarks/>
		public string filter {
			get {
				return this.filterField;
			}
			set {
				this.filterField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("size", typeof(string))]
		[System.Xml.Serialization.XmlElementAttribute("spread", typeof(spread))]
		[System.Xml.Serialization.XmlElementAttribute("values", typeof(values))]
		public object[] Items {
			get {
				return this.itemsField;
			}
			set {
				this.itemsField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string ident {
			get {
				return this.identField;
			}
			set {
				this.identField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public variableType type {
			get {
				return this.typeField;
			}
			set {
				this.typeField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public variableUse use {
			get {
				return this.useField;
			}
			set {
				this.useField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool useSpecified {
			get {
				return this.useFieldSpecified;
			}
			set {
				this.useFieldSpecified = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public variableFormat format {
			get {
				return this.formatField;
			}
			set {
				this.formatField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool formatSpecified {
			get {
				return this.formatFieldSpecified;
			}
			set {
				this.formatFieldSpecified = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/sss_v30")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/sss_v30", IsNullable = false)]
	public partial class label {

		private object[] itemsField;

		private string[] textField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("br", typeof(br))]
		[System.Xml.Serialization.XmlElementAttribute("text", typeof(text))]
		public object[] Items {
			get {
				return this.itemsField;
			}
			set {
				this.itemsField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlTextAttribute()]
		public string[] Text {
			get {
				return this.textField;
			}
			set {
				this.textField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/sss_v30")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/sss_v30", IsNullable = false)]
	public partial class position {

		private string startField;

		private string finishField;

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string start {
			get {
				return this.startField;
			}
			set {
				this.startField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string finish {
			get {
				return this.finishField;
			}
			set {
				this.finishField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/sss_v30")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/sss_v30", IsNullable = false)]
	public partial class spread {

		private string subfieldsField;

		private string widthField;

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string subfields {
			get {
				return this.subfieldsField;
			}
			set {
				this.subfieldsField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string width {
			get {
				return this.widthField;
			}
			set {
				this.widthField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/sss_v30")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/sss_v30", IsNullable = false)]
	public partial class values {

		private object[] itemsField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("range", typeof(range))]
		[System.Xml.Serialization.XmlElementAttribute("value", typeof(value))]
		public object[] Items {
			get {
				return this.itemsField;
			}
			set {
				this.itemsField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/sss_v30")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/sss_v30", IsNullable = false)]
	public partial class range {

		private string fromField;

		private string toField;

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string from {
			get {
				return this.fromField;
			}
			set {
				this.fromField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string to {
			get {
				return this.toField;
			}
			set {
				this.toField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/sss_v30")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/sss_v30", IsNullable = false)]
	public partial class value {

		private object[] itemsField;

		private string[] textField;

		private string codeField;

		private string scoreField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("br", typeof(br))]
		[System.Xml.Serialization.XmlElementAttribute("text", typeof(text))]
		public object[] Items {
			get {
				return this.itemsField;
			}
			set {
				this.itemsField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlTextAttribute()]
		public string[] Text {
			get {
				return this.textField;
			}
			set {
				this.textField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string code {
			get {
				return this.codeField;
			}
			set {
				this.codeField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string score {
			get {
				return this.scoreField;
			}
			set {
				this.scoreField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/sss_v30")]
	public enum variableType {

		/// <remarks/>
		single,

		/// <remarks/>
		multiple,

		/// <remarks/>
		quantity,

		/// <remarks/>
		character,

		/// <remarks/>
		logical,

		/// <remarks/>
		date,

		/// <remarks/>
		time,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/sss_v30")]
	public enum variableUse {

		/// <remarks/>
		serial,

		/// <remarks/>
		weight,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/sss_v30")]
	public enum variableFormat {

		/// <remarks/>
		literal,

		/// <remarks/>
		numeric,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/sss_v30")]
	public enum recordFormat {

		/// <remarks/>
		@fixed,

		/// <remarks/>
		csv,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/sss_v30")]
	public enum recordEncoding {

		/// <remarks/>
		[System.Xml.Serialization.XmlEnumAttribute("Windows-1252")]
		Windows1252,

		/// <remarks/>
		[System.Xml.Serialization.XmlEnumAttribute("UTF-8")]
		UTF8,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/sss_v30")]
	public enum sssVersion {

		/// <remarks/>
		[System.Xml.Serialization.XmlEnumAttribute("3.0")]
		Item30,
	}
}