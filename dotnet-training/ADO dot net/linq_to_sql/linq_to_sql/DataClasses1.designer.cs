﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace linq_to_sql
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="trainingdb")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void Insertclient(client instance);
    partial void Updateclient(client instance);
    partial void Deleteclient(client instance);
    partial void Insertdepartment(department instance);
    partial void Updatedepartment(department instance);
    partial void Deletedepartment(department instance);
    partial void Insertemployee(employee instance);
    partial void Updateemployee(employee instance);
    partial void Deleteemployee(employee instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::linq_to_sql.Properties.Settings.Default.trainingdbConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<client> clients
		{
			get
			{
				return this.GetTable<client>();
			}
		}
		
		public System.Data.Linq.Table<department> departments
		{
			get
			{
				return this.GetTable<department>();
			}
		}
		
		public System.Data.Linq.Table<employee> employees
		{
			get
			{
				return this.GetTable<employee>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.clients")]
	public partial class client : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _client_ID;
		
		private string _cname;
		
		private string _address;
		
		private string _email;
		
		private string _phone;
		
		private string _bussiness;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onclient_IDChanging(string value);
    partial void Onclient_IDChanged();
    partial void OncnameChanging(string value);
    partial void OncnameChanged();
    partial void OnaddressChanging(string value);
    partial void OnaddressChanged();
    partial void OnemailChanging(string value);
    partial void OnemailChanged();
    partial void OnphoneChanging(string value);
    partial void OnphoneChanged();
    partial void OnbussinessChanging(string value);
    partial void OnbussinessChanged();
    #endregion
		
		public client()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_client_ID", DbType="VarChar(4) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string client_ID
		{
			get
			{
				return this._client_ID;
			}
			set
			{
				if ((this._client_ID != value))
				{
					this.Onclient_IDChanging(value);
					this.SendPropertyChanging();
					this._client_ID = value;
					this.SendPropertyChanged("client_ID");
					this.Onclient_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_cname", DbType="VarChar(40) NOT NULL", CanBeNull=false)]
		public string cname
		{
			get
			{
				return this._cname;
			}
			set
			{
				if ((this._cname != value))
				{
					this.OncnameChanging(value);
					this.SendPropertyChanging();
					this._cname = value;
					this.SendPropertyChanged("cname");
					this.OncnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_address", DbType="VarChar(30)")]
		public string address
		{
			get
			{
				return this._address;
			}
			set
			{
				if ((this._address != value))
				{
					this.OnaddressChanging(value);
					this.SendPropertyChanging();
					this._address = value;
					this.SendPropertyChanged("address");
					this.OnaddressChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_email", DbType="VarChar(30)")]
		public string email
		{
			get
			{
				return this._email;
			}
			set
			{
				if ((this._email != value))
				{
					this.OnemailChanging(value);
					this.SendPropertyChanging();
					this._email = value;
					this.SendPropertyChanged("email");
					this.OnemailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_phone", DbType="VarChar(14)")]
		public string phone
		{
			get
			{
				return this._phone;
			}
			set
			{
				if ((this._phone != value))
				{
					this.OnphoneChanging(value);
					this.SendPropertyChanging();
					this._phone = value;
					this.SendPropertyChanged("phone");
					this.OnphoneChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_bussiness", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
		public string bussiness
		{
			get
			{
				return this._bussiness;
			}
			set
			{
				if ((this._bussiness != value))
				{
					this.OnbussinessChanging(value);
					this.SendPropertyChanging();
					this._bussiness = value;
					this.SendPropertyChanged("bussiness");
					this.OnbussinessChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.departments")]
	public partial class department : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _deptno;
		
		private string _dname;
		
		private string _location;
		
		private EntitySet<employee> _employees;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OndeptnoChanging(string value);
    partial void OndeptnoChanged();
    partial void OndnameChanging(string value);
    partial void OndnameChanged();
    partial void OnlocationChanging(string value);
    partial void OnlocationChanged();
    #endregion
		
		public department()
		{
			this._employees = new EntitySet<employee>(new Action<employee>(this.attach_employees), new Action<employee>(this.detach_employees));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_deptno", DbType="VarChar(9) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string deptno
		{
			get
			{
				return this._deptno;
			}
			set
			{
				if ((this._deptno != value))
				{
					this.OndeptnoChanging(value);
					this.SendPropertyChanging();
					this._deptno = value;
					this.SendPropertyChanged("deptno");
					this.OndeptnoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_dname", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
		public string dname
		{
			get
			{
				return this._dname;
			}
			set
			{
				if ((this._dname != value))
				{
					this.OndnameChanging(value);
					this.SendPropertyChanging();
					this._dname = value;
					this.SendPropertyChanged("dname");
					this.OndnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_location", DbType="VarChar(20)")]
		public string location
		{
			get
			{
				return this._location;
			}
			set
			{
				if ((this._location != value))
				{
					this.OnlocationChanging(value);
					this.SendPropertyChanging();
					this._location = value;
					this.SendPropertyChanged("location");
					this.OnlocationChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="department_employee", Storage="_employees", ThisKey="deptno", OtherKey="deptno")]
		public EntitySet<employee> employees
		{
			get
			{
				return this._employees;
			}
			set
			{
				this._employees.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_employees(employee entity)
		{
			this.SendPropertyChanging();
			entity.department = this;
		}
		
		private void detach_employees(employee entity)
		{
			this.SendPropertyChanging();
			entity.department = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.employees")]
	public partial class employee : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _empno;
		
		private string _ename;
		
		private string _job;
		
		private string _salary;
		
		private string _deptno;
		
		private EntityRef<department> _department;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnempnoChanging(string value);
    partial void OnempnoChanged();
    partial void OnenameChanging(string value);
    partial void OnenameChanged();
    partial void OnjobChanging(string value);
    partial void OnjobChanged();
    partial void OnsalaryChanging(string value);
    partial void OnsalaryChanged();
    partial void OndeptnoChanging(string value);
    partial void OndeptnoChanged();
    #endregion
		
		public employee()
		{
			this._department = default(EntityRef<department>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_empno", DbType="VarChar(5) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string empno
		{
			get
			{
				return this._empno;
			}
			set
			{
				if ((this._empno != value))
				{
					this.OnempnoChanging(value);
					this.SendPropertyChanging();
					this._empno = value;
					this.SendPropertyChanged("empno");
					this.OnempnoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ename", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
		public string ename
		{
			get
			{
				return this._ename;
			}
			set
			{
				if ((this._ename != value))
				{
					this.OnenameChanging(value);
					this.SendPropertyChanging();
					this._ename = value;
					this.SendPropertyChanged("ename");
					this.OnenameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_job", DbType="VarChar(20)")]
		public string job
		{
			get
			{
				return this._job;
			}
			set
			{
				if ((this._job != value))
				{
					this.OnjobChanging(value);
					this.SendPropertyChanging();
					this._job = value;
					this.SendPropertyChanged("job");
					this.OnjobChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_salary", DbType="VarChar(7)")]
		public string salary
		{
			get
			{
				return this._salary;
			}
			set
			{
				if ((this._salary != value))
				{
					this.OnsalaryChanging(value);
					this.SendPropertyChanging();
					this._salary = value;
					this.SendPropertyChanged("salary");
					this.OnsalaryChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_deptno", DbType="VarChar(9)")]
		public string deptno
		{
			get
			{
				return this._deptno;
			}
			set
			{
				if ((this._deptno != value))
				{
					if (this._department.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OndeptnoChanging(value);
					this.SendPropertyChanging();
					this._deptno = value;
					this.SendPropertyChanged("deptno");
					this.OndeptnoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="department_employee", Storage="_department", ThisKey="deptno", OtherKey="deptno", IsForeignKey=true)]
		public department department
		{
			get
			{
				return this._department.Entity;
			}
			set
			{
				department previousValue = this._department.Entity;
				if (((previousValue != value) 
							|| (this._department.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._department.Entity = null;
						previousValue.employees.Remove(this);
					}
					this._department.Entity = value;
					if ((value != null))
					{
						value.employees.Add(this);
						this._deptno = value.deptno;
					}
					else
					{
						this._deptno = default(string);
					}
					this.SendPropertyChanged("department");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591