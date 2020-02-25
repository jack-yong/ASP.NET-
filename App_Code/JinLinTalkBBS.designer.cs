﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;



[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="JinLinTalkBBS")]
public partial class JinLinTalkBBSDataContext : System.Data.Linq.DataContext
{
	
	private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
	
  #region 可扩展性方法定义
  partial void OnCreated();
  partial void InsertFeedback(Feedback instance);
  partial void UpdateFeedback(Feedback instance);
  partial void DeleteFeedback(Feedback instance);
  partial void InsertReply(Reply instance);
  partial void UpdateReply(Reply instance);
  partial void DeleteReply(Reply instance);
  partial void InsertSection(Section instance);
  partial void UpdateSection(Section instance);
  partial void DeleteSection(Section instance);
  partial void InsertTopic(Topic instance);
  partial void UpdateTopic(Topic instance);
  partial void DeleteTopic(Topic instance);
  partial void Insertuser(user instance);
  partial void Updateuser(user instance);
  partial void Deleteuser(user instance);
  #endregion
	
	public JinLinTalkBBSDataContext() : 
			base(global::System.Configuration.ConfigurationManager.ConnectionStrings["JinLinTalkBBSConnectionString"].ConnectionString, mappingSource)
	{
		OnCreated();
	}
	
	public JinLinTalkBBSDataContext(string connection) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public JinLinTalkBBSDataContext(System.Data.IDbConnection connection) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public JinLinTalkBBSDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public JinLinTalkBBSDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public System.Data.Linq.Table<Feedback> Feedback
	{
		get
		{
			return this.GetTable<Feedback>();
		}
	}
	
	public System.Data.Linq.Table<Reply> Reply
	{
		get
		{
			return this.GetTable<Reply>();
		}
	}
	
	public System.Data.Linq.Table<Section> Section
	{
		get
		{
			return this.GetTable<Section>();
		}
	}
	
	public System.Data.Linq.Table<Topic> Topic
	{
		get
		{
			return this.GetTable<Topic>();
		}
	}
	
	public System.Data.Linq.Table<user> user
	{
		get
		{
			return this.GetTable<user>();
		}
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Feedback")]
public partial class Feedback : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _OpinionID;
	
	private int _UserID;
	
	private string _Ftiele;
	
	private string _Opinion;
	
	private System.Nullable<System.DateTime> _Time;
	
	private string _IsSee;
	
    #region 可扩展性方法定义
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnOpinionIDChanging(int value);
    partial void OnOpinionIDChanged();
    partial void OnUserIDChanging(int value);
    partial void OnUserIDChanged();
    partial void OnFtieleChanging(string value);
    partial void OnFtieleChanged();
    partial void OnOpinionChanging(string value);
    partial void OnOpinionChanged();
    partial void OnTimeChanging(System.Nullable<System.DateTime> value);
    partial void OnTimeChanged();
    partial void OnIsSeeChanging(string value);
    partial void OnIsSeeChanged();
    #endregion
	
	public Feedback()
	{
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OpinionID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
	public int OpinionID
	{
		get
		{
			return this._OpinionID;
		}
		set
		{
			if ((this._OpinionID != value))
			{
				this.OnOpinionIDChanging(value);
				this.SendPropertyChanging();
				this._OpinionID = value;
				this.SendPropertyChanged("OpinionID");
				this.OnOpinionIDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserID", DbType="Int NOT NULL")]
	public int UserID
	{
		get
		{
			return this._UserID;
		}
		set
		{
			if ((this._UserID != value))
			{
				this.OnUserIDChanging(value);
				this.SendPropertyChanging();
				this._UserID = value;
				this.SendPropertyChanged("UserID");
				this.OnUserIDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Ftiele", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
	public string Ftiele
	{
		get
		{
			return this._Ftiele;
		}
		set
		{
			if ((this._Ftiele != value))
			{
				this.OnFtieleChanging(value);
				this.SendPropertyChanging();
				this._Ftiele = value;
				this.SendPropertyChanged("Ftiele");
				this.OnFtieleChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Opinion", DbType="NVarChar(500)")]
	public string Opinion
	{
		get
		{
			return this._Opinion;
		}
		set
		{
			if ((this._Opinion != value))
			{
				this.OnOpinionChanging(value);
				this.SendPropertyChanging();
				this._Opinion = value;
				this.SendPropertyChanged("Opinion");
				this.OnOpinionChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Time", DbType="DateTime")]
	public System.Nullable<System.DateTime> Time
	{
		get
		{
			return this._Time;
		}
		set
		{
			if ((this._Time != value))
			{
				this.OnTimeChanging(value);
				this.SendPropertyChanging();
				this._Time = value;
				this.SendPropertyChanged("Time");
				this.OnTimeChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IsSee", DbType="Char(6) NOT NULL", CanBeNull=false)]
	public string IsSee
	{
		get
		{
			return this._IsSee;
		}
		set
		{
			if ((this._IsSee != value))
			{
				this.OnIsSeeChanging(value);
				this.SendPropertyChanging();
				this._IsSee = value;
				this.SendPropertyChanged("IsSee");
				this.OnIsSeeChanged();
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

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Reply")]
public partial class Reply : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _Rid;
	
	private int _Ruid;
	
	private System.Nullable<int> _Rtid;
	
	private string _RStatement;
	
	private System.Nullable<System.DateTime> _Rtime;
	
	private EntityRef<Topic> _Topic;
	
    #region 可扩展性方法定义
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnRidChanging(int value);
    partial void OnRidChanged();
    partial void OnRuidChanging(int value);
    partial void OnRuidChanged();
    partial void OnRtidChanging(System.Nullable<int> value);
    partial void OnRtidChanged();
    partial void OnRStatementChanging(string value);
    partial void OnRStatementChanged();
    partial void OnRtimeChanging(System.Nullable<System.DateTime> value);
    partial void OnRtimeChanged();
    #endregion
	
	public Reply()
	{
		this._Topic = default(EntityRef<Topic>);
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Rid", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
	public int Rid
	{
		get
		{
			return this._Rid;
		}
		set
		{
			if ((this._Rid != value))
			{
				this.OnRidChanging(value);
				this.SendPropertyChanging();
				this._Rid = value;
				this.SendPropertyChanged("Rid");
				this.OnRidChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Ruid", DbType="Int NOT NULL")]
	public int Ruid
	{
		get
		{
			return this._Ruid;
		}
		set
		{
			if ((this._Ruid != value))
			{
				this.OnRuidChanging(value);
				this.SendPropertyChanging();
				this._Ruid = value;
				this.SendPropertyChanged("Ruid");
				this.OnRuidChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Rtid", DbType="Int")]
	public System.Nullable<int> Rtid
	{
		get
		{
			return this._Rtid;
		}
		set
		{
			if ((this._Rtid != value))
			{
				if (this._Topic.HasLoadedOrAssignedValue)
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnRtidChanging(value);
				this.SendPropertyChanging();
				this._Rtid = value;
				this.SendPropertyChanged("Rtid");
				this.OnRtidChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RStatement", DbType="NVarChar(1000)")]
	public string RStatement
	{
		get
		{
			return this._RStatement;
		}
		set
		{
			if ((this._RStatement != value))
			{
				this.OnRStatementChanging(value);
				this.SendPropertyChanging();
				this._RStatement = value;
				this.SendPropertyChanged("RStatement");
				this.OnRStatementChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Rtime", DbType="DateTime")]
	public System.Nullable<System.DateTime> Rtime
	{
		get
		{
			return this._Rtime;
		}
		set
		{
			if ((this._Rtime != value))
			{
				this.OnRtimeChanging(value);
				this.SendPropertyChanging();
				this._Rtime = value;
				this.SendPropertyChanged("Rtime");
				this.OnRtimeChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Topic_Reply", Storage="_Topic", ThisKey="Rtid", OtherKey="Tid", IsForeignKey=true)]
	public Topic Topic
	{
		get
		{
			return this._Topic.Entity;
		}
		set
		{
			Topic previousValue = this._Topic.Entity;
			if (((previousValue != value) 
						|| (this._Topic.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._Topic.Entity = null;
					previousValue.Reply.Remove(this);
				}
				this._Topic.Entity = value;
				if ((value != null))
				{
					value.Reply.Add(this);
					this._Rtid = value.Tid;
				}
				else
				{
					this._Rtid = default(Nullable<int>);
				}
				this.SendPropertyChanged("Topic");
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

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Section")]
public partial class Section : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _Sid;
	
	private string _Sname;
	
	private int _SmasterId;
	
	private string _Sstatement;
	
	private EntitySet<Topic> _Topic;
	
    #region 可扩展性方法定义
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnSidChanging(int value);
    partial void OnSidChanged();
    partial void OnSnameChanging(string value);
    partial void OnSnameChanged();
    partial void OnSmasterIdChanging(int value);
    partial void OnSmasterIdChanged();
    partial void OnSstatementChanging(string value);
    partial void OnSstatementChanged();
    #endregion
	
	public Section()
	{
		this._Topic = new EntitySet<Topic>(new Action<Topic>(this.attach_Topic), new Action<Topic>(this.detach_Topic));
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Sid", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
	public int Sid
	{
		get
		{
			return this._Sid;
		}
		set
		{
			if ((this._Sid != value))
			{
				this.OnSidChanging(value);
				this.SendPropertyChanging();
				this._Sid = value;
				this.SendPropertyChanged("Sid");
				this.OnSidChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Sname", DbType="NVarChar(80) NOT NULL", CanBeNull=false)]
	public string Sname
	{
		get
		{
			return this._Sname;
		}
		set
		{
			if ((this._Sname != value))
			{
				this.OnSnameChanging(value);
				this.SendPropertyChanging();
				this._Sname = value;
				this.SendPropertyChanged("Sname");
				this.OnSnameChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SmasterId", DbType="Int NOT NULL")]
	public int SmasterId
	{
		get
		{
			return this._SmasterId;
		}
		set
		{
			if ((this._SmasterId != value))
			{
				this.OnSmasterIdChanging(value);
				this.SendPropertyChanging();
				this._SmasterId = value;
				this.SendPropertyChanged("SmasterId");
				this.OnSmasterIdChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Sstatement", DbType="NVarChar(1000) NOT NULL", CanBeNull=false)]
	public string Sstatement
	{
		get
		{
			return this._Sstatement;
		}
		set
		{
			if ((this._Sstatement != value))
			{
				this.OnSstatementChanging(value);
				this.SendPropertyChanging();
				this._Sstatement = value;
				this.SendPropertyChanged("Sstatement");
				this.OnSstatementChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Section_Topic", Storage="_Topic", ThisKey="Sid", OtherKey="Tsid")]
	public EntitySet<Topic> Topic
	{
		get
		{
			return this._Topic;
		}
		set
		{
			this._Topic.Assign(value);
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
	
	private void attach_Topic(Topic entity)
	{
		this.SendPropertyChanging();
		entity.Section = this;
	}
	
	private void detach_Topic(Topic entity)
	{
		this.SendPropertyChanging();
		entity.Section = null;
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Topic")]
public partial class Topic : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _Tid;
	
	private int _Tsid;
	
	private int _Tuid;
	
	private string _Ttiele;
	
	private string _Tcontents;
	
	private System.Nullable<int> _BrowseCount;
	
	private System.Nullable<int> _ReplyCount;
	
	private string _IsClose;
	
	private System.Nullable<System.DateTime> _Ttime;
	
	private EntitySet<Reply> _Reply;
	
	private EntityRef<Section> _Section;
	
    #region 可扩展性方法定义
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnTidChanging(int value);
    partial void OnTidChanged();
    partial void OnTsidChanging(int value);
    partial void OnTsidChanged();
    partial void OnTuidChanging(int value);
    partial void OnTuidChanged();
    partial void OnTtieleChanging(string value);
    partial void OnTtieleChanged();
    partial void OnTcontentsChanging(string value);
    partial void OnTcontentsChanged();
    partial void OnBrowseCountChanging(System.Nullable<int> value);
    partial void OnBrowseCountChanged();
    partial void OnReplyCountChanging(System.Nullable<int> value);
    partial void OnReplyCountChanged();
    partial void OnIsCloseChanging(string value);
    partial void OnIsCloseChanged();
    partial void OnTtimeChanging(System.Nullable<System.DateTime> value);
    partial void OnTtimeChanged();
    #endregion
	
	public Topic()
	{
		this._Reply = new EntitySet<Reply>(new Action<Reply>(this.attach_Reply), new Action<Reply>(this.detach_Reply));
		this._Section = default(EntityRef<Section>);
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Tid", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
	public int Tid
	{
		get
		{
			return this._Tid;
		}
		set
		{
			if ((this._Tid != value))
			{
				this.OnTidChanging(value);
				this.SendPropertyChanging();
				this._Tid = value;
				this.SendPropertyChanged("Tid");
				this.OnTidChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Tsid", DbType="Int NOT NULL")]
	public int Tsid
	{
		get
		{
			return this._Tsid;
		}
		set
		{
			if ((this._Tsid != value))
			{
				if (this._Section.HasLoadedOrAssignedValue)
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnTsidChanging(value);
				this.SendPropertyChanging();
				this._Tsid = value;
				this.SendPropertyChanged("Tsid");
				this.OnTsidChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Tuid", DbType="Int NOT NULL")]
	public int Tuid
	{
		get
		{
			return this._Tuid;
		}
		set
		{
			if ((this._Tuid != value))
			{
				this.OnTuidChanging(value);
				this.SendPropertyChanging();
				this._Tuid = value;
				this.SendPropertyChanged("Tuid");
				this.OnTuidChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Ttiele", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
	public string Ttiele
	{
		get
		{
			return this._Ttiele;
		}
		set
		{
			if ((this._Ttiele != value))
			{
				this.OnTtieleChanging(value);
				this.SendPropertyChanging();
				this._Ttiele = value;
				this.SendPropertyChanged("Ttiele");
				this.OnTtieleChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Tcontents", DbType="NVarChar(1000) NOT NULL", CanBeNull=false)]
	public string Tcontents
	{
		get
		{
			return this._Tcontents;
		}
		set
		{
			if ((this._Tcontents != value))
			{
				this.OnTcontentsChanging(value);
				this.SendPropertyChanging();
				this._Tcontents = value;
				this.SendPropertyChanged("Tcontents");
				this.OnTcontentsChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BrowseCount", DbType="Int")]
	public System.Nullable<int> BrowseCount
	{
		get
		{
			return this._BrowseCount;
		}
		set
		{
			if ((this._BrowseCount != value))
			{
				this.OnBrowseCountChanging(value);
				this.SendPropertyChanging();
				this._BrowseCount = value;
				this.SendPropertyChanged("BrowseCount");
				this.OnBrowseCountChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ReplyCount", DbType="Int")]
	public System.Nullable<int> ReplyCount
	{
		get
		{
			return this._ReplyCount;
		}
		set
		{
			if ((this._ReplyCount != value))
			{
				this.OnReplyCountChanging(value);
				this.SendPropertyChanging();
				this._ReplyCount = value;
				this.SendPropertyChanged("ReplyCount");
				this.OnReplyCountChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IsClose", DbType="Char(6)")]
	public string IsClose
	{
		get
		{
			return this._IsClose;
		}
		set
		{
			if ((this._IsClose != value))
			{
				this.OnIsCloseChanging(value);
				this.SendPropertyChanging();
				this._IsClose = value;
				this.SendPropertyChanged("IsClose");
				this.OnIsCloseChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Ttime", DbType="DateTime")]
	public System.Nullable<System.DateTime> Ttime
	{
		get
		{
			return this._Ttime;
		}
		set
		{
			if ((this._Ttime != value))
			{
				this.OnTtimeChanging(value);
				this.SendPropertyChanging();
				this._Ttime = value;
				this.SendPropertyChanged("Ttime");
				this.OnTtimeChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Topic_Reply", Storage="_Reply", ThisKey="Tid", OtherKey="Rtid")]
	public EntitySet<Reply> Reply
	{
		get
		{
			return this._Reply;
		}
		set
		{
			this._Reply.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Section_Topic", Storage="_Section", ThisKey="Tsid", OtherKey="Sid", IsForeignKey=true)]
	public Section Section
	{
		get
		{
			return this._Section.Entity;
		}
		set
		{
			Section previousValue = this._Section.Entity;
			if (((previousValue != value) 
						|| (this._Section.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._Section.Entity = null;
					previousValue.Topic.Remove(this);
				}
				this._Section.Entity = value;
				if ((value != null))
				{
					value.Topic.Add(this);
					this._Tsid = value.Sid;
				}
				else
				{
					this._Tsid = default(int);
				}
				this.SendPropertyChanged("Section");
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
	
	private void attach_Reply(Reply entity)
	{
		this.SendPropertyChanging();
		entity.Topic = this;
	}
	
	private void detach_Reply(Reply entity)
	{
		this.SendPropertyChanging();
		entity.Topic = null;
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.[user]")]
public partial class user : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _UId;
	
	private string _Uname;
	
	private string _Upassword;
	
	private string _Udepartment;
	
	private string _Umajor;
	
	private string _USex;
	
	private string _HeadUrl;
	
	private System.Nullable<int> _TopicCount;
	
	private string _Enabled;
	
	private System.Nullable<System.DateTime> _RegistrationTime;
	
    #region 可扩展性方法定义
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnUIdChanging(int value);
    partial void OnUIdChanged();
    partial void OnUnameChanging(string value);
    partial void OnUnameChanged();
    partial void OnUpasswordChanging(string value);
    partial void OnUpasswordChanged();
    partial void OnUdepartmentChanging(string value);
    partial void OnUdepartmentChanged();
    partial void OnUmajorChanging(string value);
    partial void OnUmajorChanged();
    partial void OnUSexChanging(string value);
    partial void OnUSexChanged();
    partial void OnHeadUrlChanging(string value);
    partial void OnHeadUrlChanged();
    partial void OnTopicCountChanging(System.Nullable<int> value);
    partial void OnTopicCountChanged();
    partial void OnEnabledChanging(string value);
    partial void OnEnabledChanged();
    partial void OnRegistrationTimeChanging(System.Nullable<System.DateTime> value);
    partial void OnRegistrationTimeChanged();
    #endregion
	
	public user()
	{
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
	public int UId
	{
		get
		{
			return this._UId;
		}
		set
		{
			if ((this._UId != value))
			{
				this.OnUIdChanging(value);
				this.SendPropertyChanging();
				this._UId = value;
				this.SendPropertyChanged("UId");
				this.OnUIdChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Uname", DbType="NVarChar(80) NOT NULL", CanBeNull=false)]
	public string Uname
	{
		get
		{
			return this._Uname;
		}
		set
		{
			if ((this._Uname != value))
			{
				this.OnUnameChanging(value);
				this.SendPropertyChanging();
				this._Uname = value;
				this.SendPropertyChanged("Uname");
				this.OnUnameChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Upassword", DbType="NVarChar(80) NOT NULL", CanBeNull=false)]
	public string Upassword
	{
		get
		{
			return this._Upassword;
		}
		set
		{
			if ((this._Upassword != value))
			{
				this.OnUpasswordChanging(value);
				this.SendPropertyChanging();
				this._Upassword = value;
				this.SendPropertyChanged("Upassword");
				this.OnUpasswordChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Udepartment", DbType="NVarChar(80) NOT NULL", CanBeNull=false)]
	public string Udepartment
	{
		get
		{
			return this._Udepartment;
		}
		set
		{
			if ((this._Udepartment != value))
			{
				this.OnUdepartmentChanging(value);
				this.SendPropertyChanging();
				this._Udepartment = value;
				this.SendPropertyChanged("Udepartment");
				this.OnUdepartmentChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Umajor", DbType="NVarChar(80) NOT NULL", CanBeNull=false)]
	public string Umajor
	{
		get
		{
			return this._Umajor;
		}
		set
		{
			if ((this._Umajor != value))
			{
				this.OnUmajorChanging(value);
				this.SendPropertyChanging();
				this._Umajor = value;
				this.SendPropertyChanged("Umajor");
				this.OnUmajorChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_USex", DbType="NVarChar(10)")]
	public string USex
	{
		get
		{
			return this._USex;
		}
		set
		{
			if ((this._USex != value))
			{
				this.OnUSexChanging(value);
				this.SendPropertyChanging();
				this._USex = value;
				this.SendPropertyChanged("USex");
				this.OnUSexChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HeadUrl", DbType="NVarChar(800)")]
	public string HeadUrl
	{
		get
		{
			return this._HeadUrl;
		}
		set
		{
			if ((this._HeadUrl != value))
			{
				this.OnHeadUrlChanging(value);
				this.SendPropertyChanging();
				this._HeadUrl = value;
				this.SendPropertyChanged("HeadUrl");
				this.OnHeadUrlChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TopicCount", DbType="Int")]
	public System.Nullable<int> TopicCount
	{
		get
		{
			return this._TopicCount;
		}
		set
		{
			if ((this._TopicCount != value))
			{
				this.OnTopicCountChanging(value);
				this.SendPropertyChanging();
				this._TopicCount = value;
				this.SendPropertyChanged("TopicCount");
				this.OnTopicCountChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Enabled", DbType="Char(6)")]
	public string Enabled
	{
		get
		{
			return this._Enabled;
		}
		set
		{
			if ((this._Enabled != value))
			{
				this.OnEnabledChanging(value);
				this.SendPropertyChanging();
				this._Enabled = value;
				this.SendPropertyChanged("Enabled");
				this.OnEnabledChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RegistrationTime", DbType="DateTime")]
	public System.Nullable<System.DateTime> RegistrationTime
	{
		get
		{
			return this._RegistrationTime;
		}
		set
		{
			if ((this._RegistrationTime != value))
			{
				this.OnRegistrationTimeChanging(value);
				this.SendPropertyChanging();
				this._RegistrationTime = value;
				this.SendPropertyChanged("RegistrationTime");
				this.OnRegistrationTimeChanged();
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
#pragma warning restore 1591
