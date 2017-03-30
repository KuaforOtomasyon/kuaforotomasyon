﻿//------------------------------------------------------------------------------
// This is auto-generated code.
//------------------------------------------------------------------------------
// This code was generated by Entity Developer tool using LinqConnect template.
// Code is generated on: 31/03/2017 01:54:07
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------

using System;
using Devart.Data.Linq;
using Devart.Data.Linq.Mapping;
using System.Data;
using System.ComponentModel;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;
using System.Linq.Expressions;

namespace KuaforContext
{

    [DatabaseAttribute(Name = "kuafor")]
    [ProviderAttribute(typeof(Devart.Data.MySql.Linq.Provider.MySqlDataProvider))]
    public partial class musteri : Devart.Data.Linq.DataContext
    {
        public static CompiledQueryCache compiledQueryCache = CompiledQueryCache.RegisterDataContext(typeof(musteri));
        private static MappingSource mappingSource = new Devart.Data.Linq.Mapping.AttributeMappingSource();

        #region Extensibility Method Definitions
    
        partial void OnCreated();
        partial void OnSubmitError(Devart.Data.Linq.SubmitErrorEventArgs args);
        partial void InsertMusteri(Musteri instance);
        partial void UpdateMusteri(Musteri instance);
        partial void DeleteMusteri(Musteri instance);

        #endregion

        public musteri() :
        base(GetConnectionString("KuaforDataContextConnectionString"), mappingSource)
        {
            OnCreated();
        }

        public musteri(MappingSource mappingSource) :
        base(GetConnectionString("KuaforDataContextConnectionString"), mappingSource)
        {
            OnCreated();
        }

        private static string GetConnectionString(string connectionStringName)
        {
            System.Configuration.ConnectionStringSettings connectionStringSettings = System.Configuration.ConfigurationManager.ConnectionStrings[connectionStringName];
            if (connectionStringSettings == null)
                throw new InvalidOperationException("Connection string \"" + connectionStringName +"\" could not be found in the configuration file.");
            return connectionStringSettings.ConnectionString;
        }

        public musteri(string connection) :
            base(connection, mappingSource)
        {
          OnCreated();
        }

        public musteri(System.Data.IDbConnection connection) :
            base(connection, mappingSource)
        {
          OnCreated();
        }

        public musteri(string connection, MappingSource mappingSource) :
            base(connection, mappingSource)
        {
          OnCreated();
        }

        public musteri(System.Data.IDbConnection connection, MappingSource mappingSource) :
            base(connection, mappingSource)
        {
          OnCreated();
        }

        public Devart.Data.Linq.Table<Musteri> Musteris
        {
            get
            {
                return this.GetTable<Musteri>();
            }
        }
    }
}

namespace KuaforContext
{

    /// <summary>
    /// There are no comments for KuaforContext.Musteri in the schema.
    /// </summary>
    [Table(Name = @"kuafor.musteri")]
    public partial class Musteri : INotifyPropertyChanging, INotifyPropertyChanged
    {

        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(System.String.Empty);
        #pragma warning disable 0649

        private int _MusteriId;

        private string _MusteriAdi;

        private string _MusteriSoyadi;

        private string _Cinsiyet;

        private System.Nullable<System.DateTime> _DogumTarihi;

        private string _DogumYeri;

        private string _Adres;

        private string _CepTelefon;

        private string _EvTelefon;

        private System.Nullable<System.DateTime> _KayitTarihi;

        private string _EMail;

        private string _Kuafor;

        private string _Iptal;
        #pragma warning restore 0649
    
        #region Extensibility Method Definitions

        partial void OnLoaded();
        partial void OnValidate(ChangeAction action);
        partial void OnCreated();
        partial void OnMusteriIdChanging(int value);
        partial void OnMusteriIdChanged();
        partial void OnMusteriAdiChanging(string value);
        partial void OnMusteriAdiChanged();
        partial void OnMusteriSoyadiChanging(string value);
        partial void OnMusteriSoyadiChanged();
        partial void OnCinsiyetChanging(string value);
        partial void OnCinsiyetChanged();
        partial void OnDogumTarihiChanging(System.Nullable<System.DateTime> value);
        partial void OnDogumTarihiChanged();
        partial void OnDogumYeriChanging(string value);
        partial void OnDogumYeriChanged();
        partial void OnAdresChanging(string value);
        partial void OnAdresChanged();
        partial void OnCepTelefonChanging(string value);
        partial void OnCepTelefonChanged();
        partial void OnEvTelefonChanging(string value);
        partial void OnEvTelefonChanged();
        partial void OnKayitTarihiChanging(System.Nullable<System.DateTime> value);
        partial void OnKayitTarihiChanged();
        partial void OnEMailChanging(string value);
        partial void OnEMailChanged();
        partial void OnKuaforChanging(string value);
        partial void OnKuaforChanged();
        partial void OnIptalChanging(string value);
        partial void OnIptalChanged();
        #endregion

        public Musteri()
        {
            OnCreated();
        }

    
        /// <summary>
        /// There are no comments for MusteriId in the schema.
        /// </summary>
        [Column(Name = @"musteriId", Storage = "_MusteriId", CanBeNull = false, DbType = "INT(11) NOT NULL", IsPrimaryKey = true)]
        public int MusteriId
        {
            get
            {
                return this._MusteriId;
            }
            set
            {
                if (this._MusteriId != value)
                {
                    this.OnMusteriIdChanging(value);
                    this.SendPropertyChanging();
                    this._MusteriId = value;
                    this.SendPropertyChanged("MusteriId");
                    this.OnMusteriIdChanged();
                }
            }
        }

    
        /// <summary>
        /// There are no comments for MusteriAdi in the schema.
        /// </summary>
        [Column(Name = @"musteriAdi", Storage = "_MusteriAdi", DbType = "VARCHAR(50) NULL", UpdateCheck = UpdateCheck.Never)]
        public string MusteriAdi
        {
            get
            {
                return this._MusteriAdi;
            }
            set
            {
                if (this._MusteriAdi != value)
                {
                    this.OnMusteriAdiChanging(value);
                    this.SendPropertyChanging();
                    this._MusteriAdi = value;
                    this.SendPropertyChanged("MusteriAdi");
                    this.OnMusteriAdiChanged();
                }
            }
        }

    
        /// <summary>
        /// There are no comments for MusteriSoyadi in the schema.
        /// </summary>
        [Column(Name = @"musteriSoyadi", Storage = "_MusteriSoyadi", DbType = "VARCHAR(50) NULL", UpdateCheck = UpdateCheck.Never)]
        public string MusteriSoyadi
        {
            get
            {
                return this._MusteriSoyadi;
            }
            set
            {
                if (this._MusteriSoyadi != value)
                {
                    this.OnMusteriSoyadiChanging(value);
                    this.SendPropertyChanging();
                    this._MusteriSoyadi = value;
                    this.SendPropertyChanged("MusteriSoyadi");
                    this.OnMusteriSoyadiChanged();
                }
            }
        }

    
        /// <summary>
        /// There are no comments for Cinsiyet in the schema.
        /// </summary>
        [Column(Name = @"cinsiyet", Storage = "_Cinsiyet", DbType = "ENUM NULL", UpdateCheck = UpdateCheck.Never)]
        public string Cinsiyet
        {
            get
            {
                return this._Cinsiyet;
            }
            set
            {
                if (this._Cinsiyet != value)
                {
                    this.OnCinsiyetChanging(value);
                    this.SendPropertyChanging();
                    this._Cinsiyet = value;
                    this.SendPropertyChanged("Cinsiyet");
                    this.OnCinsiyetChanged();
                }
            }
        }

    
        /// <summary>
        /// There are no comments for DogumTarihi in the schema.
        /// </summary>
        [Column(Name = @"dogumTarihi", Storage = "_DogumTarihi", DbType = "DATETIME NULL", UpdateCheck = UpdateCheck.Never)]
        public System.Nullable<System.DateTime> DogumTarihi
        {
            get
            {
                return this._DogumTarihi;
            }
            set
            {
                if (this._DogumTarihi != value)
                {
                    this.OnDogumTarihiChanging(value);
                    this.SendPropertyChanging();
                    this._DogumTarihi = value;
                    this.SendPropertyChanged("DogumTarihi");
                    this.OnDogumTarihiChanged();
                }
            }
        }

    
        /// <summary>
        /// There are no comments for DogumYeri in the schema.
        /// </summary>
        [Column(Name = @"dogumYeri", Storage = "_DogumYeri", DbType = "VARCHAR(255) NULL", UpdateCheck = UpdateCheck.Never)]
        public string DogumYeri
        {
            get
            {
                return this._DogumYeri;
            }
            set
            {
                if (this._DogumYeri != value)
                {
                    this.OnDogumYeriChanging(value);
                    this.SendPropertyChanging();
                    this._DogumYeri = value;
                    this.SendPropertyChanged("DogumYeri");
                    this.OnDogumYeriChanged();
                }
            }
        }

    
        /// <summary>
        /// There are no comments for Adres in the schema.
        /// </summary>
        [Column(Name = @"adres", Storage = "_Adres", DbType = "TEXT NULL", UpdateCheck = UpdateCheck.Never)]
        public string Adres
        {
            get
            {
                return this._Adres;
            }
            set
            {
                if (this._Adres != value)
                {
                    this.OnAdresChanging(value);
                    this.SendPropertyChanging();
                    this._Adres = value;
                    this.SendPropertyChanged("Adres");
                    this.OnAdresChanged();
                }
            }
        }

    
        /// <summary>
        /// There are no comments for CepTelefon in the schema.
        /// </summary>
        [Column(Name = @"cepTelefon", Storage = "_CepTelefon", DbType = "VARCHAR(50) NULL", UpdateCheck = UpdateCheck.Never)]
        public string CepTelefon
        {
            get
            {
                return this._CepTelefon;
            }
            set
            {
                if (this._CepTelefon != value)
                {
                    this.OnCepTelefonChanging(value);
                    this.SendPropertyChanging();
                    this._CepTelefon = value;
                    this.SendPropertyChanged("CepTelefon");
                    this.OnCepTelefonChanged();
                }
            }
        }

    
        /// <summary>
        /// There are no comments for EvTelefon in the schema.
        /// </summary>
        [Column(Name = @"evTelefon", Storage = "_EvTelefon", DbType = "VARCHAR(50) NULL", UpdateCheck = UpdateCheck.Never)]
        public string EvTelefon
        {
            get
            {
                return this._EvTelefon;
            }
            set
            {
                if (this._EvTelefon != value)
                {
                    this.OnEvTelefonChanging(value);
                    this.SendPropertyChanging();
                    this._EvTelefon = value;
                    this.SendPropertyChanged("EvTelefon");
                    this.OnEvTelefonChanged();
                }
            }
        }

    
        /// <summary>
        /// There are no comments for KayitTarihi in the schema.
        /// </summary>
        [Column(Name = @"kayitTarihi", Storage = "_KayitTarihi", DbType = "DATE NULL", UpdateCheck = UpdateCheck.Never)]
        public System.Nullable<System.DateTime> KayitTarihi
        {
            get
            {
                return this._KayitTarihi;
            }
            set
            {
                if (this._KayitTarihi != value)
                {
                    this.OnKayitTarihiChanging(value);
                    this.SendPropertyChanging();
                    this._KayitTarihi = value;
                    this.SendPropertyChanged("KayitTarihi");
                    this.OnKayitTarihiChanged();
                }
            }
        }

    
        /// <summary>
        /// There are no comments for EMail in the schema.
        /// </summary>
        [Column(Name = @"eMail", Storage = "_EMail", DbType = "VARCHAR(100) NULL", UpdateCheck = UpdateCheck.Never)]
        public string EMail
        {
            get
            {
                return this._EMail;
            }
            set
            {
                if (this._EMail != value)
                {
                    this.OnEMailChanging(value);
                    this.SendPropertyChanging();
                    this._EMail = value;
                    this.SendPropertyChanged("EMail");
                    this.OnEMailChanged();
                }
            }
        }

    
        /// <summary>
        /// There are no comments for Kuafor in the schema.
        /// </summary>
        [Column(Name = @"kuafor", Storage = "_Kuafor", DbType = "VARCHAR(100) NULL", UpdateCheck = UpdateCheck.Never)]
        public string Kuafor
        {
            get
            {
                return this._Kuafor;
            }
            set
            {
                if (this._Kuafor != value)
                {
                    this.OnKuaforChanging(value);
                    this.SendPropertyChanging();
                    this._Kuafor = value;
                    this.SendPropertyChanged("Kuafor");
                    this.OnKuaforChanged();
                }
            }
        }

    
        /// <summary>
        /// There are no comments for Iptal in the schema.
        /// </summary>
        [Column(Name = @"iptal", Storage = "_Iptal", DbType = "ENUM NULL", UpdateCheck = UpdateCheck.Never)]
        public string Iptal
        {
            get
            {
                return this._Iptal;
            }
            set
            {
                if (this._Iptal != value)
                {
                    this.OnIptalChanging(value);
                    this.SendPropertyChanging();
                    this._Iptal = value;
                    this.SendPropertyChanged("Iptal");
                    this.OnIptalChanged();
                }
            }
        }
   
        public event PropertyChangingEventHandler PropertyChanging;

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void SendPropertyChanging()
        {
		        var handler = this.PropertyChanging;
            if (handler != null)
                handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanging(System.String propertyName) 
        {    
		        var handler = this.PropertyChanging;
            if (handler != null)
                handler(this, new PropertyChangingEventArgs(propertyName));
        }

        protected virtual void SendPropertyChanged(System.String propertyName)
        {    
		        var handler = this.PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }

}
