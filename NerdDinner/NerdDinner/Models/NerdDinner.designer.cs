﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     O código foi gerado por uma ferramenta.
//     Versão de Tempo de Execução:4.0.30319.42000
//
//     As alterações ao arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NerdDinner.Models
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="NerdDinner")]
	public partial class NerdDinnerDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertDinners(Dinners instance);
    partial void UpdateDinners(Dinners instance);
    partial void DeleteDinners(Dinners instance);
    partial void InsertRsvp(Rsvp instance);
    partial void UpdateRsvp(Rsvp instance);
    partial void DeleteRsvp(Rsvp instance);
    #endregion
		
		public NerdDinnerDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["NerdDinnerConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public NerdDinnerDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public NerdDinnerDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public NerdDinnerDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public NerdDinnerDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Dinners> Dinners
		{
			get
			{
				return this.GetTable<Dinners>();
			}
		}
		
		public System.Data.Linq.Table<Rsvp> Rsvp
		{
			get
			{
				return this.GetTable<Rsvp>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Dinners")]
	public partial class Dinners : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _DinnerID;
		
		private string _Title;
		
		private System.DateTime _EventDate;
		
		private string _Description;
		
		private string _HostedBy;
		
		private string _ContactPhone;
		
		private string _Address;
		
		private string _Country;
		
		private System.Nullable<double> _Latitude;
		
		private System.Nullable<double> _Longitude;
		
		private EntitySet<Rsvp> _Rsvp;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnDinnerIDChanging(int value);
    partial void OnDinnerIDChanged();
    partial void OnTitleChanging(string value);
    partial void OnTitleChanged();
    partial void OnEventDateChanging(System.DateTime value);
    partial void OnEventDateChanged();
    partial void OnDescriptionChanging(string value);
    partial void OnDescriptionChanged();
    partial void OnHostedByChanging(string value);
    partial void OnHostedByChanged();
    partial void OnContactPhoneChanging(string value);
    partial void OnContactPhoneChanged();
    partial void OnAddressChanging(string value);
    partial void OnAddressChanged();
    partial void OnCountryChanging(string value);
    partial void OnCountryChanged();
    partial void OnLatitudeChanging(System.Nullable<double> value);
    partial void OnLatitudeChanged();
    partial void OnLongitudeChanging(System.Nullable<double> value);
    partial void OnLongitudeChanged();
    #endregion
		
		public Dinners()
		{
			this._Rsvp = new EntitySet<Rsvp>(new Action<Rsvp>(this.attach_Rsvp), new Action<Rsvp>(this.detach_Rsvp));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DinnerID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int DinnerID
		{
			get
			{
				return this._DinnerID;
			}
			set
			{
				if ((this._DinnerID != value))
				{
					this.OnDinnerIDChanging(value);
					this.SendPropertyChanging();
					this._DinnerID = value;
					this.SendPropertyChanged("DinnerID");
					this.OnDinnerIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Title", DbType="NChar(50) NOT NULL", CanBeNull=false)]
		public string Title
		{
			get
			{
				return this._Title;
			}
			set
			{
				if ((this._Title != value))
				{
					this.OnTitleChanging(value);
					this.SendPropertyChanging();
					this._Title = value;
					this.SendPropertyChanged("Title");
					this.OnTitleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EventDate", DbType="DateTime NOT NULL")]
		public System.DateTime EventDate
		{
			get
			{
				return this._EventDate;
			}
			set
			{
				if ((this._EventDate != value))
				{
					this.OnEventDateChanging(value);
					this.SendPropertyChanging();
					this._EventDate = value;
					this.SendPropertyChanged("EventDate");
					this.OnEventDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Description", DbType="NChar(256)")]
		public string Description
		{
			get
			{
				return this._Description;
			}
			set
			{
				if ((this._Description != value))
				{
					this.OnDescriptionChanging(value);
					this.SendPropertyChanging();
					this._Description = value;
					this.SendPropertyChanged("Description");
					this.OnDescriptionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HostedBy", DbType="NChar(20)")]
		public string HostedBy
		{
			get
			{
				return this._HostedBy;
			}
			set
			{
				if ((this._HostedBy != value))
				{
					this.OnHostedByChanging(value);
					this.SendPropertyChanging();
					this._HostedBy = value;
					this.SendPropertyChanged("HostedBy");
					this.OnHostedByChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ContactPhone", DbType="NChar(20)")]
		public string ContactPhone
		{
			get
			{
				return this._ContactPhone;
			}
			set
			{
				if ((this._ContactPhone != value))
				{
					this.OnContactPhoneChanging(value);
					this.SendPropertyChanging();
					this._ContactPhone = value;
					this.SendPropertyChanged("ContactPhone");
					this.OnContactPhoneChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Address", DbType="NChar(50)")]
		public string Address
		{
			get
			{
				return this._Address;
			}
			set
			{
				if ((this._Address != value))
				{
					this.OnAddressChanging(value);
					this.SendPropertyChanging();
					this._Address = value;
					this.SendPropertyChanged("Address");
					this.OnAddressChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Country", DbType="NChar(30)")]
		public string Country
		{
			get
			{
				return this._Country;
			}
			set
			{
				if ((this._Country != value))
				{
					this.OnCountryChanging(value);
					this.SendPropertyChanging();
					this._Country = value;
					this.SendPropertyChanged("Country");
					this.OnCountryChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Latitude", DbType="Float")]
		public System.Nullable<double> Latitude
		{
			get
			{
				return this._Latitude;
			}
			set
			{
				if ((this._Latitude != value))
				{
					this.OnLatitudeChanging(value);
					this.SendPropertyChanging();
					this._Latitude = value;
					this.SendPropertyChanged("Latitude");
					this.OnLatitudeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Longitude", DbType="Float")]
		public System.Nullable<double> Longitude
		{
			get
			{
				return this._Longitude;
			}
			set
			{
				if ((this._Longitude != value))
				{
					this.OnLongitudeChanging(value);
					this.SendPropertyChanging();
					this._Longitude = value;
					this.SendPropertyChanged("Longitude");
					this.OnLongitudeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Dinners_Rsvp", Storage="_Rsvp", ThisKey="DinnerID", OtherKey="DinnerID")]
		public EntitySet<Rsvp> Rsvp
		{
			get
			{
				return this._Rsvp;
			}
			set
			{
				this._Rsvp.Assign(value);
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
		
		private void attach_Rsvp(Rsvp entity)
		{
			this.SendPropertyChanging();
			entity.Dinners = this;
		}
		
		private void detach_Rsvp(Rsvp entity)
		{
			this.SendPropertyChanging();
			entity.Dinners = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Rsvp")]
	public partial class Rsvp : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _RsvpId;
		
		private int _DinnerID;
		
		private string _AttendeeName;
		
		private EntityRef<Dinners> _Dinners;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnRsvpIdChanging(int value);
    partial void OnRsvpIdChanged();
    partial void OnDinnerIDChanging(int value);
    partial void OnDinnerIDChanged();
    partial void OnAttendeeNameChanging(string value);
    partial void OnAttendeeNameChanged();
    #endregion
		
		public Rsvp()
		{
			this._Dinners = default(EntityRef<Dinners>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RsvpId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int RsvpId
		{
			get
			{
				return this._RsvpId;
			}
			set
			{
				if ((this._RsvpId != value))
				{
					this.OnRsvpIdChanging(value);
					this.SendPropertyChanging();
					this._RsvpId = value;
					this.SendPropertyChanged("RsvpId");
					this.OnRsvpIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DinnerID", DbType="Int NOT NULL")]
		public int DinnerID
		{
			get
			{
				return this._DinnerID;
			}
			set
			{
				if ((this._DinnerID != value))
				{
					if (this._Dinners.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnDinnerIDChanging(value);
					this.SendPropertyChanging();
					this._DinnerID = value;
					this.SendPropertyChanged("DinnerID");
					this.OnDinnerIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AttendeeName", DbType="NVarChar(30) NOT NULL", CanBeNull=false)]
		public string AttendeeName
		{
			get
			{
				return this._AttendeeName;
			}
			set
			{
				if ((this._AttendeeName != value))
				{
					this.OnAttendeeNameChanging(value);
					this.SendPropertyChanging();
					this._AttendeeName = value;
					this.SendPropertyChanged("AttendeeName");
					this.OnAttendeeNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Dinners_Rsvp", Storage="_Dinners", ThisKey="DinnerID", OtherKey="DinnerID", IsForeignKey=true)]
		public Dinners Dinners
		{
			get
			{
				return this._Dinners.Entity;
			}
			set
			{
				Dinners previousValue = this._Dinners.Entity;
				if (((previousValue != value) 
							|| (this._Dinners.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Dinners.Entity = null;
						previousValue.Rsvp.Remove(this);
					}
					this._Dinners.Entity = value;
					if ((value != null))
					{
						value.Rsvp.Add(this);
						this._DinnerID = value.DinnerID;
					}
					else
					{
						this._DinnerID = default(int);
					}
					this.SendPropertyChanged("Dinners");
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
