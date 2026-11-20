using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using TimelapseVertigo.Game.Fragments;

// Token: 0x020006AB RID: 1707
[eiz("DD")]
[Serializable]
public class vl : ISerializable
{
	// Token: 0x06002C32 RID: 11314 RVA: 0x000FD880 File Offset: 0x000FBA80
	protected vl(SerializationInfo A_0, StreamingContext A_1)
	{
		this.a = A_0.GetString("DD:I");
		this.b = (A_0.GetValue("DD:M", typeof(int?)) as int?);
		this.c = (A_0.GetValue("DD:X", typeof(int?)) as int?);
		this.d = A_0.GetInt32("DD:R");
		di7.ReadList<DungeonEntrance>("DD:E", ref this.e, A_0);
		di7.ReadList<string>("DD:C", ref this.f, A_0);
		if (ell.a() >= 537)
		{
			di7.ReadList<ap>("DD:P", ref this.g, A_0);
			return;
		}
		this.g = new List<ap>();
	}

	// Token: 0x06002C33 RID: 11315 RVA: 0x000FD978 File Offset: 0x000FBB78
	public virtual void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		info.AddValue("DD:I", this.a);
		info.AddValue("DD:M", this.b);
		info.AddValue("DD:X", this.c);
		info.AddValue("DD:R", this.d);
		di7.WriteList<DungeonEntrance>("DD:E", this.e, info);
		di7.WriteList<string>("DD:C", this.f, info);
		di7.WriteList<ap>("DD:P", this.g, info);
	}

	// Token: 0x1700017B RID: 379
	// (get) Token: 0x06002C34 RID: 11316 RVA: 0x000FDA08 File Offset: 0x000FBC08
	// (set) Token: 0x06002C35 RID: 11317 RVA: 0x000FDA10 File Offset: 0x000FBC10
	public string Id
	{
		get
		{
			return this.a;
		}
		set
		{
			this.a = value;
		}
	}

	// Token: 0x1700017C RID: 380
	// (get) Token: 0x06002C36 RID: 11318 RVA: 0x000FDA1C File Offset: 0x000FBC1C
	// (set) Token: 0x06002C37 RID: 11319 RVA: 0x000FDA24 File Offset: 0x000FBC24
	public int? MinLevel
	{
		get
		{
			return this.b;
		}
		set
		{
			this.b = value;
		}
	}

	// Token: 0x1700017D RID: 381
	// (get) Token: 0x06002C38 RID: 11320 RVA: 0x000FDA30 File Offset: 0x000FBC30
	// (set) Token: 0x06002C39 RID: 11321 RVA: 0x000FDA38 File Offset: 0x000FBC38
	public int? MaxLevel
	{
		get
		{
			return this.c;
		}
		set
		{
			this.c = value;
		}
	}

	// Token: 0x1700017E RID: 382
	// (get) Token: 0x06002C3A RID: 11322 RVA: 0x000FDA44 File Offset: 0x000FBC44
	// (set) Token: 0x06002C3B RID: 11323 RVA: 0x000FDA4C File Offset: 0x000FBC4C
	public int Rarity
	{
		get
		{
			return this.d;
		}
		set
		{
			this.d = value;
		}
	}

	// Token: 0x1700017F RID: 383
	// (get) Token: 0x06002C3C RID: 11324 RVA: 0x000FDA58 File Offset: 0x000FBC58
	// (set) Token: 0x06002C3D RID: 11325 RVA: 0x000FDA60 File Offset: 0x000FBC60
	public List<DungeonEntrance> AvailableEntrances
	{
		get
		{
			return this.e;
		}
		set
		{
			this.e = value;
		}
	}

	// Token: 0x17000180 RID: 384
	// (get) Token: 0x06002C3E RID: 11326 RVA: 0x000FDA6C File Offset: 0x000FBC6C
	// (set) Token: 0x06002C3F RID: 11327 RVA: 0x000FDA74 File Offset: 0x000FBC74
	public List<string> Categories
	{
		get
		{
			return this.f;
		}
		set
		{
			this.f = value;
		}
	}

	// Token: 0x17000181 RID: 385
	// (get) Token: 0x06002C40 RID: 11328 RVA: 0x000FDA80 File Offset: 0x000FBC80
	// (set) Token: 0x06002C41 RID: 11329 RVA: 0x000FDA88 File Offset: 0x000FBC88
	public List<ap> Properties
	{
		get
		{
			return this.g;
		}
		set
		{
			this.g = value;
		}
	}

	// Token: 0x06002C42 RID: 11330 RVA: 0x000FDA94 File Offset: 0x000FBC94
	public vl()
	{
	}

	// Token: 0x04001921 RID: 6433
	private string a;

	// Token: 0x04001922 RID: 6434
	private int? b;

	// Token: 0x04001923 RID: 6435
	private int? c;

	// Token: 0x04001924 RID: 6436
	private int d = 1;

	// Token: 0x04001925 RID: 6437
	private List<DungeonEntrance> e = new List<DungeonEntrance>();

	// Token: 0x04001926 RID: 6438
	private List<string> f = new List<string>();

	// Token: 0x04001927 RID: 6439
	private List<ap> g = new List<ap>();
}
