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

namespace MarksDal
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="MarkDB")]
	public partial class ContextDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertMark(Mark instance);
    partial void UpdateMark(Mark instance);
    partial void DeleteMark(Mark instance);
    partial void InsertMarkRequest(MarkRequest instance);
    partial void UpdateMarkRequest(MarkRequest instance);
    partial void DeleteMarkRequest(MarkRequest instance);
    partial void InsertUser(User instance);
    partial void UpdateUser(User instance);
    partial void DeleteUser(User instance);
    #endregion
		
		public ContextDataContext() : 
				base(global::MarksDal.Properties.Settings.Default.MarkDBConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public ContextDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ContextDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ContextDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ContextDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Mark> Marks
		{
			get
			{
				return this.GetTable<Mark>();
			}
		}
		
		public System.Data.Linq.Table<MarkRequest> MarkRequests
		{
			get
			{
				return this.GetTable<MarkRequest>();
			}
		}
		
		public System.Data.Linq.Table<User> Users
		{
			get
			{
				return this.GetTable<User>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Mark")]
	public partial class Mark : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private System.DateTime _DateTime;
		
		private string _json;
		
		private int _FromId;
		
		private int _ToId;
		
		private EntitySet<MarkRequest> _MarkRequests;
		
		private EntityRef<User> _User11;
		
		private EntityRef<User> _User12;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnDateTimeChanging(System.DateTime value);
    partial void OnDateTimeChanged();
    partial void OnMark1Changing(string value);
    partial void OnMark1Changed();
    partial void OnFromIdChanging(int value);
    partial void OnFromIdChanged();
    partial void OnToIdChanging(int value);
    partial void OnToIdChanged();
    #endregion
		
		public Mark()
		{
			this._MarkRequests = new EntitySet<MarkRequest>(new Action<MarkRequest>(this.attach_MarkRequests), new Action<MarkRequest>(this.detach_MarkRequests));
			this._User11 = default(EntityRef<User>);
			this._User12 = default(EntityRef<User>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DateTime", DbType="DateTime NOT NULL")]
		public System.DateTime DateTime
		{
			get
			{
				return this._DateTime;
			}
			set
			{
				if ((this._DateTime != value))
				{
					this.OnDateTimeChanging(value);
					this.SendPropertyChanging();
					this._DateTime = value;
					this.SendPropertyChanged("DateTime");
					this.OnDateTimeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="Mark", Storage="_json", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string Json
		{
			get
			{
				return this._json;
			}
			set
			{
				if ((this._json != value))
				{
					this.OnMark1Changing(value);
					this.SendPropertyChanging();
					this._json = value;
					this.SendPropertyChanged("Json");
					this.OnMark1Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FromId", DbType="Int NOT NULL")]
		public int FromId
		{
			get
			{
				return this._FromId;
			}
			set
			{
				if ((this._FromId != value))
				{
					if (this._User11.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnFromIdChanging(value);
					this.SendPropertyChanging();
					this._FromId = value;
					this.SendPropertyChanged("FromId");
					this.OnFromIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ToId", DbType="Int NOT NULL")]
		public int ToId
		{
			get
			{
				return this._ToId;
			}
			set
			{
				if ((this._ToId != value))
				{
					if (this._User12.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnToIdChanging(value);
					this.SendPropertyChanging();
					this._ToId = value;
					this.SendPropertyChanged("ToId");
					this.OnToIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Mark_MarkRequest", Storage="_MarkRequests", ThisKey="Id", OtherKey="MarkId")]
		public EntitySet<MarkRequest> MarkRequests
		{
			get
			{
				return this._MarkRequests;
			}
			set
			{
				this._MarkRequests.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="User_Mark", Storage="_User11", ThisKey="FromId", OtherKey="Id", IsForeignKey=true)]
		public User From
		{
			get
			{
				return this._User11.Entity;
			}
			set
			{
				User previousValue = this._User11.Entity;
				if (((previousValue != value) 
							|| (this._User11.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._User11.Entity = null;
						previousValue.Marks.Remove(this);
					}
					this._User11.Entity = value;
					if ((value != null))
					{
						value.Marks.Add(this);
						this._FromId = value.Id;
					}
					else
					{
						this._FromId = default(int);
					}
					this.SendPropertyChanged("From");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="User_Mark1", Storage="_User12", ThisKey="ToId", OtherKey="Id", IsForeignKey=true)]
		public User To
		{
			get
			{
				return this._User12.Entity;
			}
			set
			{
				User previousValue = this._User12.Entity;
				if (((previousValue != value) 
							|| (this._User12.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._User12.Entity = null;
						previousValue.Marks1.Remove(this);
					}
					this._User12.Entity = value;
					if ((value != null))
					{
						value.Marks1.Add(this);
						this._ToId = value.Id;
					}
					else
					{
						this._ToId = default(int);
					}
					this.SendPropertyChanged("To");
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
		
		private void attach_MarkRequests(MarkRequest entity)
		{
			this.SendPropertyChanging();
			entity.Mark = this;
		}
		
		private void detach_MarkRequests(MarkRequest entity)
		{
			this.SendPropertyChanging();
			entity.Mark = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.MarkRequest")]
	public partial class MarkRequest : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private int _AuthorId;
		
		private int _MarkId;
		
		private System.DateTime _Date;
		
		private string _Comment;
		
		private EntityRef<Mark> _Mark;
		
		private EntityRef<User> _User;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnAuthorIdChanging(int value);
    partial void OnAuthorIdChanged();
    partial void OnMarkIdChanging(int value);
    partial void OnMarkIdChanged();
    partial void OnDateChanging(System.DateTime value);
    partial void OnDateChanged();
    partial void OnCommentChanging(string value);
    partial void OnCommentChanged();
    #endregion
		
		public MarkRequest()
		{
			this._Mark = default(EntityRef<Mark>);
			this._User = default(EntityRef<User>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AuthorId", DbType="Int NOT NULL")]
		public int AuthorId
		{
			get
			{
				return this._AuthorId;
			}
			set
			{
				if ((this._AuthorId != value))
				{
					if (this._User.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnAuthorIdChanging(value);
					this.SendPropertyChanging();
					this._AuthorId = value;
					this.SendPropertyChanged("AuthorId");
					this.OnAuthorIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MarkId", DbType="Int NOT NULL")]
		public int MarkId
		{
			get
			{
				return this._MarkId;
			}
			set
			{
				if ((this._MarkId != value))
				{
					if (this._Mark.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMarkIdChanging(value);
					this.SendPropertyChanging();
					this._MarkId = value;
					this.SendPropertyChanged("MarkId");
					this.OnMarkIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Date", DbType="DateTime NOT NULL")]
		public System.DateTime Date
		{
			get
			{
				return this._Date;
			}
			set
			{
				if ((this._Date != value))
				{
					this.OnDateChanging(value);
					this.SendPropertyChanging();
					this._Date = value;
					this.SendPropertyChanged("Date");
					this.OnDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Comment", DbType="NVarChar(MAX)")]
		public string Comment
		{
			get
			{
				return this._Comment;
			}
			set
			{
				if ((this._Comment != value))
				{
					this.OnCommentChanging(value);
					this.SendPropertyChanging();
					this._Comment = value;
					this.SendPropertyChanged("Comment");
					this.OnCommentChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Mark_MarkRequest", Storage="_Mark", ThisKey="MarkId", OtherKey="Id", IsForeignKey=true)]
		public Mark Mark
		{
			get
			{
				return this._Mark.Entity;
			}
			set
			{
				Mark previousValue = this._Mark.Entity;
				if (((previousValue != value) 
							|| (this._Mark.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Mark.Entity = null;
						previousValue.MarkRequests.Remove(this);
					}
					this._Mark.Entity = value;
					if ((value != null))
					{
						value.MarkRequests.Add(this);
						this._MarkId = value.Id;
					}
					else
					{
						this._MarkId = default(int);
					}
					this.SendPropertyChanged("Mark");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="User_MarkRequest", Storage="_User", ThisKey="AuthorId", OtherKey="Id", IsForeignKey=true)]
		public User User
		{
			get
			{
				return this._User.Entity;
			}
			set
			{
				User previousValue = this._User.Entity;
				if (((previousValue != value) 
							|| (this._User.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._User.Entity = null;
						previousValue.MarkRequests.Remove(this);
					}
					this._User.Entity = value;
					if ((value != null))
					{
						value.MarkRequests.Add(this);
						this._AuthorId = value.Id;
					}
					else
					{
						this._AuthorId = default(int);
					}
					this.SendPropertyChanged("User");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.[User]")]
	public partial class User : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _ActiveDirectoryId;
		
		private string _FirstName;
		
		private string _LastName;
		
		private string _MiddleName;
		
		private System.Nullable<bool> _ParentId;
		
		private EntitySet<Mark> _Marks;
		
		private EntitySet<Mark> _Marks1;
		
		private EntitySet<MarkRequest> _MarkRequests;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnActiveDirectoryIdChanging(string value);
    partial void OnActiveDirectoryIdChanged();
    partial void OnFirstNameChanging(string value);
    partial void OnFirstNameChanged();
    partial void OnLastNameChanging(string value);
    partial void OnLastNameChanged();
    partial void OnMiddleNameChanging(string value);
    partial void OnMiddleNameChanged();
    partial void OnIsManagerChanging(System.Nullable<bool> value);
    partial void OnIsManagerChanged();
    #endregion
		
		public User()
		{
			this._Marks = new EntitySet<Mark>(new Action<Mark>(this.attach_Marks), new Action<Mark>(this.detach_Marks));
			this._Marks1 = new EntitySet<Mark>(new Action<Mark>(this.attach_Marks1), new Action<Mark>(this.detach_Marks1));
			this._MarkRequests = new EntitySet<MarkRequest>(new Action<MarkRequest>(this.attach_MarkRequests), new Action<MarkRequest>(this.detach_MarkRequests));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ActiveDirectoryId", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string ActiveDirectoryId
		{
			get
			{
				return this._ActiveDirectoryId;
			}
			set
			{
				if ((this._ActiveDirectoryId != value))
				{
					this.OnActiveDirectoryIdChanging(value);
					this.SendPropertyChanging();
					this._ActiveDirectoryId = value;
					this.SendPropertyChanged("ActiveDirectoryId");
					this.OnActiveDirectoryIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FirstName", DbType="NChar(255) NOT NULL", CanBeNull=false)]
		public string FirstName
		{
			get
			{
				return this._FirstName;
			}
			set
			{
				if ((this._FirstName != value))
				{
					this.OnFirstNameChanging(value);
					this.SendPropertyChanging();
					this._FirstName = value;
					this.SendPropertyChanged("FirstName");
					this.OnFirstNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LastName", DbType="NChar(255) NOT NULL", CanBeNull=false)]
		public string LastName
		{
			get
			{
				return this._LastName;
			}
			set
			{
				if ((this._LastName != value))
				{
					this.OnLastNameChanging(value);
					this.SendPropertyChanging();
					this._LastName = value;
					this.SendPropertyChanged("LastName");
					this.OnLastNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MiddleName", DbType="NChar(255) NOT NULL", CanBeNull=false)]
		public string MiddleName
		{
			get
			{
				return this._MiddleName;
			}
			set
			{
				if ((this._MiddleName != value))
				{
					this.OnMiddleNameChanging(value);
					this.SendPropertyChanging();
					this._MiddleName = value;
					this.SendPropertyChanged("MiddleName");
					this.OnMiddleNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ParentId", DbType="Int")]
		public System.Nullable<bool> IsManager
		{
			get
			{
				return this._ParentId;
			}
			set
			{
				if ((this._ParentId != value))
				{
					this.OnIsManagerChanging(value);
					this.SendPropertyChanging();
					this._ParentId = value;
					this.SendPropertyChanged("IsManager");
					this.OnIsManagerChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="User_Mark", Storage="_Marks", ThisKey="Id", OtherKey="FromId")]
		public EntitySet<Mark> Marks
		{
			get
			{
				return this._Marks;
			}
			set
			{
				this._Marks.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="User_Mark1", Storage="_Marks1", ThisKey="Id", OtherKey="ToId")]
		public EntitySet<Mark> Marks1
		{
			get
			{
				return this._Marks1;
			}
			set
			{
				this._Marks1.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="User_MarkRequest", Storage="_MarkRequests", ThisKey="Id", OtherKey="AuthorId")]
		public EntitySet<MarkRequest> MarkRequests
		{
			get
			{
				return this._MarkRequests;
			}
			set
			{
				this._MarkRequests.Assign(value);
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
		
		private void attach_Marks(Mark entity)
		{
			this.SendPropertyChanging();
			entity.From = this;
		}
		
		private void detach_Marks(Mark entity)
		{
			this.SendPropertyChanging();
			entity.From = null;
		}
		
		private void attach_Marks1(Mark entity)
		{
			this.SendPropertyChanging();
			entity.To = this;
		}
		
		private void detach_Marks1(Mark entity)
		{
			this.SendPropertyChanging();
			entity.To = null;
		}
		
		private void attach_MarkRequests(MarkRequest entity)
		{
			this.SendPropertyChanging();
			entity.User = this;
		}
		
		private void detach_MarkRequests(MarkRequest entity)
		{
			this.SendPropertyChanging();
			entity.User = null;
		}
	}
}
#pragma warning restore 1591