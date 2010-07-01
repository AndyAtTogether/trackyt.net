﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Trackyourtasks.Core.DAL.DataModel
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="trackyourtasksdb")]
	public partial class TrackYourTasksDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertUser(User instance);
    partial void UpdateUser(User instance);
    partial void DeleteUser(User instance);
    #endregion
		
		public TrackYourTasksDataContext() : 
				base(global::Trackyourtasks.Core.Properties.Settings.Default.trackyourtasksdbConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public TrackYourTasksDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public TrackYourTasksDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public TrackYourTasksDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public TrackYourTasksDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<User> Users
		{
			get
			{
				return this.GetTable<User>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Users")]
	public partial class User : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id = default(int);
		
		private string _Email;
		
		private string _SecretPhrase;
		
		private string _Password;
		
		private System.Data.Linq.Binary _Timestamp;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    partial void OnSecretPhraseChanging(string value);
    partial void OnSecretPhraseChanged();
    partial void OnPasswordChanging(string value);
    partial void OnPasswordChanged();
    partial void OnTimestampChanging(System.Data.Linq.Binary value);
    partial void OnTimestampChanged();
    #endregion
		
		public User()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsDbGenerated=true, UpdateCheck=UpdateCheck.Never)]
		public int Id
		{
			get
			{
				return this._Id;
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false, IsPrimaryKey=true, UpdateCheck=UpdateCheck.Never)]
		public string Email
		{
			get
			{
				return this._Email;
			}
			set
			{
				if ((this._Email != value))
				{
					this.OnEmailChanging(value);
					this.SendPropertyChanging();
					this._Email = value;
					this.SendPropertyChanged("Email");
					this.OnEmailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SecretPhrase", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false, UpdateCheck=UpdateCheck.Never)]
		public string SecretPhrase
		{
			get
			{
				return this._SecretPhrase;
			}
			set
			{
				if ((this._SecretPhrase != value))
				{
					this.OnSecretPhraseChanging(value);
					this.SendPropertyChanging();
					this._SecretPhrase = value;
					this.SendPropertyChanged("SecretPhrase");
					this.OnSecretPhraseChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false, UpdateCheck=UpdateCheck.Never)]
		public string Password
		{
			get
			{
				return this._Password;
			}
			set
			{
				if ((this._Password != value))
				{
					this.OnPasswordChanging(value);
					this.SendPropertyChanging();
					this._Password = value;
					this.SendPropertyChanged("Password");
					this.OnPasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Timestamp", AutoSync=AutoSync.Always, DbType="rowversion", CanBeNull=true, IsDbGenerated=true, IsVersion=true, UpdateCheck=UpdateCheck.Never)]
		protected System.Data.Linq.Binary Timestamp
		{
			get
			{
				return this._Timestamp;
			}
			set
			{
				if ((this._Timestamp != value))
				{
					this.OnTimestampChanging(value);
					this.SendPropertyChanging();
					this._Timestamp = value;
					this.SendPropertyChanged("Timestamp");
					this.OnTimestampChanged();
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
