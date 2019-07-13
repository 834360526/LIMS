﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by a tool.
//     Runtime Version: 1.1.4322.2300
//
//     Changes to this file may cause incorrect behavior and will be lost if 
//     the code is regenerated.
// </autogenerated>
//------------------------------------------------------------------------------

namespace LIMS.User {
    using System;
    using System.Data;
    using System.Xml;
    using System.Runtime.Serialization;
    
    
    [Serializable()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.ToolboxItem(true)]
    public class User : DataSet {
        
        private 科室DataTable table科室;
        
        public User() {
            this.InitClass();
            System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            this.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
        protected User(SerializationInfo info, StreamingContext context) {
            string strSchema = ((string)(info.GetValue("XmlSchema", typeof(string))));
            if ((strSchema != null)) {
                DataSet ds = new DataSet();
                ds.ReadXmlSchema(new XmlTextReader(new System.IO.StringReader(strSchema)));
                if ((ds.Tables["科室"] != null)) {
                    this.Tables.Add(new 科室DataTable(ds.Tables["科室"]));
                }
                this.DataSetName = ds.DataSetName;
                this.Prefix = ds.Prefix;
                this.Namespace = ds.Namespace;
                this.Locale = ds.Locale;
                this.CaseSensitive = ds.CaseSensitive;
                this.EnforceConstraints = ds.EnforceConstraints;
                this.Merge(ds, false, System.Data.MissingSchemaAction.Add);
                this.InitVars();
            }
            else {
                this.InitClass();
            }
            this.GetSerializationData(info, context);
            System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            this.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
        [System.ComponentModel.Browsable(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Content)]
        public 科室DataTable 科室 {
            get {
                return this.table科室;
            }
        }
        
        public override DataSet Clone() {
            User cln = ((User)(base.Clone()));
            cln.InitVars();
            return cln;
        }
        
        protected override bool ShouldSerializeTables() {
            return false;
        }
        
        protected override bool ShouldSerializeRelations() {
            return false;
        }
        
        protected override void ReadXmlSerializable(XmlReader reader) {
            this.Reset();
            DataSet ds = new DataSet();
            ds.ReadXml(reader);
            if ((ds.Tables["科室"] != null)) {
                this.Tables.Add(new 科室DataTable(ds.Tables["科室"]));
            }
            this.DataSetName = ds.DataSetName;
            this.Prefix = ds.Prefix;
            this.Namespace = ds.Namespace;
            this.Locale = ds.Locale;
            this.CaseSensitive = ds.CaseSensitive;
            this.EnforceConstraints = ds.EnforceConstraints;
            this.Merge(ds, false, System.Data.MissingSchemaAction.Add);
            this.InitVars();
        }
        
        protected override System.Xml.Schema.XmlSchema GetSchemaSerializable() {
            System.IO.MemoryStream stream = new System.IO.MemoryStream();
            this.WriteXmlSchema(new XmlTextWriter(stream, null));
            stream.Position = 0;
            return System.Xml.Schema.XmlSchema.Read(new XmlTextReader(stream), null);
        }
        
        internal void InitVars() {
            this.table科室 = ((科室DataTable)(this.Tables["科室"]));
            if ((this.table科室 != null)) {
                this.table科室.InitVars();
            }
        }
        
        private void InitClass() {
            this.DataSetName = "User";
            this.Prefix = "";
            this.Namespace = "http://www.tempuri.org/User.xsd";
            this.Locale = new System.Globalization.CultureInfo("zh-CN");
            this.CaseSensitive = false;
            this.EnforceConstraints = true;
            this.table科室 = new 科室DataTable();
            this.Tables.Add(this.table科室);
        }
        
        private bool ShouldSerialize科室() {
            return false;
        }
        
        private void SchemaChanged(object sender, System.ComponentModel.CollectionChangeEventArgs e) {
            if ((e.Action == System.ComponentModel.CollectionChangeAction.Remove)) {
                this.InitVars();
            }
        }
        
        public delegate void 科室RowChangeEventHandler(object sender, 科室RowChangeEvent e);
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class 科室DataTable : DataTable, System.Collections.IEnumerable {
            
            private DataColumn columnOffic;
            
            private DataColumn columnID;
            
            internal 科室DataTable() : 
                    base("科室") {
                this.InitClass();
            }
            
            internal 科室DataTable(DataTable table) : 
                    base(table.TableName) {
                if ((table.CaseSensitive != table.DataSet.CaseSensitive)) {
                    this.CaseSensitive = table.CaseSensitive;
                }
                if ((table.Locale.ToString() != table.DataSet.Locale.ToString())) {
                    this.Locale = table.Locale;
                }
                if ((table.Namespace != table.DataSet.Namespace)) {
                    this.Namespace = table.Namespace;
                }
                this.Prefix = table.Prefix;
                this.MinimumCapacity = table.MinimumCapacity;
                this.DisplayExpression = table.DisplayExpression;
            }
            
            [System.ComponentModel.Browsable(false)]
            public int Count {
                get {
                    return this.Rows.Count;
                }
            }
            
            internal DataColumn OfficColumn {
                get {
                    return this.columnOffic;
                }
            }
            
            internal DataColumn IDColumn {
                get {
                    return this.columnID;
                }
            }
            
            public 科室Row this[int index] {
                get {
                    return ((科室Row)(this.Rows[index]));
                }
            }
            
            public event 科室RowChangeEventHandler 科室RowChanged;
            
            public event 科室RowChangeEventHandler 科室RowChanging;
            
            public event 科室RowChangeEventHandler 科室RowDeleted;
            
            public event 科室RowChangeEventHandler 科室RowDeleting;
            
            public void Add科室Row(科室Row row) {
                this.Rows.Add(row);
            }
            
            public 科室Row Add科室Row(string Offic) {
                科室Row row科室Row = ((科室Row)(this.NewRow()));
                row科室Row.ItemArray = new object[] {
                        Offic,
                        null};
                this.Rows.Add(row科室Row);
                return row科室Row;
            }
            
            public 科室Row FindByID(int ID) {
                return ((科室Row)(this.Rows.Find(new object[] {
                            ID})));
            }
            
            public System.Collections.IEnumerator GetEnumerator() {
                return this.Rows.GetEnumerator();
            }
            
            public override DataTable Clone() {
                科室DataTable cln = ((科室DataTable)(base.Clone()));
                cln.InitVars();
                return cln;
            }
            
            protected override DataTable CreateInstance() {
                return new 科室DataTable();
            }
            
            internal void InitVars() {
                this.columnOffic = this.Columns["Offic"];
                this.columnID = this.Columns["ID"];
            }
            
            private void InitClass() {
                this.columnOffic = new DataColumn("Offic", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnOffic);
                this.columnID = new DataColumn("ID", typeof(int), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnID);
                this.Constraints.Add(new UniqueConstraint("Constraint1", new DataColumn[] {
                                this.columnID}, true));
                this.columnID.AutoIncrement = true;
                this.columnID.AllowDBNull = false;
                this.columnID.ReadOnly = true;
                this.columnID.Unique = true;
            }
            
            public 科室Row New科室Row() {
                return ((科室Row)(this.NewRow()));
            }
            
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder) {
                return new 科室Row(builder);
            }
            
            protected override System.Type GetRowType() {
                return typeof(科室Row);
            }
            
            protected override void OnRowChanged(DataRowChangeEventArgs e) {
                base.OnRowChanged(e);
                if ((this.科室RowChanged != null)) {
                    this.科室RowChanged(this, new 科室RowChangeEvent(((科室Row)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowChanging(DataRowChangeEventArgs e) {
                base.OnRowChanging(e);
                if ((this.科室RowChanging != null)) {
                    this.科室RowChanging(this, new 科室RowChangeEvent(((科室Row)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleted(DataRowChangeEventArgs e) {
                base.OnRowDeleted(e);
                if ((this.科室RowDeleted != null)) {
                    this.科室RowDeleted(this, new 科室RowChangeEvent(((科室Row)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleting(DataRowChangeEventArgs e) {
                base.OnRowDeleting(e);
                if ((this.科室RowDeleting != null)) {
                    this.科室RowDeleting(this, new 科室RowChangeEvent(((科室Row)(e.Row)), e.Action));
                }
            }
            
            public void Remove科室Row(科室Row row) {
                this.Rows.Remove(row);
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class 科室Row : DataRow {
            
            private 科室DataTable table科室;
            
            internal 科室Row(DataRowBuilder rb) : 
                    base(rb) {
                this.table科室 = ((科室DataTable)(this.Table));
            }
            
            public string Offic {
                get {
                    try {
                        return ((string)(this[this.table科室.OfficColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("无法获取值，因为它是 DBNull。", e);
                    }
                }
                set {
                    this[this.table科室.OfficColumn] = value;
                }
            }
            
            public int ID {
                get {
                    return ((int)(this[this.table科室.IDColumn]));
                }
                set {
                    this[this.table科室.IDColumn] = value;
                }
            }
            
            public bool IsOfficNull() {
                return this.IsNull(this.table科室.OfficColumn);
            }
            
            public void SetOfficNull() {
                this[this.table科室.OfficColumn] = System.Convert.DBNull;
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class 科室RowChangeEvent : EventArgs {
            
            private 科室Row eventRow;
            
            private DataRowAction eventAction;
            
            public 科室RowChangeEvent(科室Row row, DataRowAction action) {
                this.eventRow = row;
                this.eventAction = action;
            }
            
            public 科室Row Row {
                get {
                    return this.eventRow;
                }
            }
            
            public DataRowAction Action {
                get {
                    return this.eventAction;
                }
            }
        }
    }
}
