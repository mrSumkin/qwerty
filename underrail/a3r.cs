using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules;

// Token: 0x02000674 RID: 1652
[eiz("SGI")]
[Serializable]
public sealed class a3r : ISerializable
{
	// Token: 0x060029EF RID: 10735 RVA: 0x000EDB14 File Offset: 0x000EBD14
	private a3r(SerializationInfo A_0, StreamingContext A_1)
	{
		this.c = A_0.GetString("SGI:CN");
		this.d = A_0.GetInt32("SGI:CL");
		this.e = A_0.GetString("SGI:L");
		this.f = A_0.GetDateTime("SGI:ST");
		if (ell.a() >= 138)
		{
			this.g = (A_0.GetValue("SGI:V", typeof(Version)) as Version);
		}
		else
		{
			this.g = new Version(0, 1, 5, 0);
		}
		if (ell.a() >= 139)
		{
			this.k = A_0.GetBoolean("SGI:T");
		}
		if (ell.a() >= 274)
		{
			this.h = (A_0.GetValue("SGI:P", typeof(TimeSpan?)) as TimeSpan?);
		}
		if (ell.a() >= 473)
		{
			di7.ReadList<string>("SGI:DL", ref this.l, A_0);
		}
		else
		{
			this.l = new List<string>();
		}
		if (ell.a() >= 337)
		{
			this.i = (A_0.GetValue("SGI:D", typeof(GameDifficulty?)) as GameDifficulty?);
		}
	}

	// Token: 0x060029F0 RID: 10736 RVA: 0x000EDC74 File Offset: 0x000EBE74
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		info.AddValue("SGI:CN", this.c);
		info.AddValue("SGI:CL", this.d);
		info.AddValue("SGI:L", this.e);
		info.AddValue("SGI:ST", this.f);
		info.AddValue("SGI:V", this.g);
		info.AddValue("SGI:T", this.k);
		info.AddValue("SGI:P", this.h);
		info.AddValue("SGI:D", this.i);
		di7.WriteList<string>("SGI:DL", this.l, info);
	}

	// Token: 0x1700011C RID: 284
	// (get) Token: 0x060029F1 RID: 10737 RVA: 0x000EDD24 File Offset: 0x000EBF24
	// (set) Token: 0x060029F2 RID: 10738 RVA: 0x000EDD2C File Offset: 0x000EBF2C
	public string Name
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

	// Token: 0x1700011D RID: 285
	// (get) Token: 0x060029F3 RID: 10739 RVA: 0x000EDD38 File Offset: 0x000EBF38
	// (set) Token: 0x060029F4 RID: 10740 RVA: 0x000EDD40 File Offset: 0x000EBF40
	public string FolderName
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

	// Token: 0x1700011E RID: 286
	// (get) Token: 0x060029F5 RID: 10741 RVA: 0x000EDD4C File Offset: 0x000EBF4C
	// (set) Token: 0x060029F6 RID: 10742 RVA: 0x000EDD54 File Offset: 0x000EBF54
	public string CharacterName
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

	// Token: 0x1700011F RID: 287
	// (get) Token: 0x060029F7 RID: 10743 RVA: 0x000EDD60 File Offset: 0x000EBF60
	// (set) Token: 0x060029F8 RID: 10744 RVA: 0x000EDD68 File Offset: 0x000EBF68
	public int CharacterLevel
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

	// Token: 0x17000120 RID: 288
	// (get) Token: 0x060029F9 RID: 10745 RVA: 0x000EDD74 File Offset: 0x000EBF74
	// (set) Token: 0x060029FA RID: 10746 RVA: 0x000EDD7C File Offset: 0x000EBF7C
	public string Location
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

	// Token: 0x17000121 RID: 289
	// (get) Token: 0x060029FB RID: 10747 RVA: 0x000EDD88 File Offset: 0x000EBF88
	// (set) Token: 0x060029FC RID: 10748 RVA: 0x000EDD90 File Offset: 0x000EBF90
	public DateTime SaveTime
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

	// Token: 0x17000122 RID: 290
	// (get) Token: 0x060029FD RID: 10749 RVA: 0x000EDD9C File Offset: 0x000EBF9C
	// (set) Token: 0x060029FE RID: 10750 RVA: 0x000EDDA4 File Offset: 0x000EBFA4
	public Version GameVersion
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

	// Token: 0x17000123 RID: 291
	// (get) Token: 0x060029FF RID: 10751 RVA: 0x000EDDB0 File Offset: 0x000EBFB0
	// (set) Token: 0x06002A00 RID: 10752 RVA: 0x000EDDB8 File Offset: 0x000EBFB8
	public bool New
	{
		get
		{
			return this.j;
		}
		set
		{
			this.j = value;
		}
	}

	// Token: 0x17000124 RID: 292
	// (get) Token: 0x06002A01 RID: 10753 RVA: 0x000EDDC4 File Offset: 0x000EBFC4
	// (set) Token: 0x06002A02 RID: 10754 RVA: 0x000EDDCC File Offset: 0x000EBFCC
	public bool Transitional
	{
		get
		{
			return this.k;
		}
		set
		{
			this.k = value;
		}
	}

	// Token: 0x17000125 RID: 293
	// (get) Token: 0x06002A03 RID: 10755 RVA: 0x000EDDD8 File Offset: 0x000EBFD8
	// (set) Token: 0x06002A04 RID: 10756 RVA: 0x000EDDE0 File Offset: 0x000EBFE0
	public TimeSpan? PlayTime
	{
		get
		{
			return this.h;
		}
		set
		{
			this.h = value;
		}
	}

	// Token: 0x17000126 RID: 294
	// (get) Token: 0x06002A05 RID: 10757 RVA: 0x000EDDEC File Offset: 0x000EBFEC
	// (set) Token: 0x06002A06 RID: 10758 RVA: 0x000EDDF4 File Offset: 0x000EBFF4
	public GameDifficulty? Difficulty
	{
		get
		{
			return this.i;
		}
		set
		{
			this.i = value;
		}
	}

	// Token: 0x17000127 RID: 295
	// (get) Token: 0x06002A07 RID: 10759 RVA: 0x000EDE00 File Offset: 0x000EC000
	// (set) Token: 0x06002A08 RID: 10760 RVA: 0x000EDE08 File Offset: 0x000EC008
	public List<string> DLCs
	{
		get
		{
			return this.l;
		}
		set
		{
			this.l = value;
		}
	}

	// Token: 0x06002A09 RID: 10761 RVA: 0x000EDE14 File Offset: 0x000EC014
	public a3r()
	{
		this.g = (Version)dm9.d.Clone();
		this.l.AddRange(dk2.b());
	}

	// Token: 0x040016D9 RID: 5849
	[NonSerialized]
	private string a;

	// Token: 0x040016DA RID: 5850
	[NonSerialized]
	private string b;

	// Token: 0x040016DB RID: 5851
	private string c;

	// Token: 0x040016DC RID: 5852
	private int d;

	// Token: 0x040016DD RID: 5853
	private string e;

	// Token: 0x040016DE RID: 5854
	private DateTime f;

	// Token: 0x040016DF RID: 5855
	private Version g;

	// Token: 0x040016E0 RID: 5856
	private TimeSpan? h;

	// Token: 0x040016E1 RID: 5857
	private GameDifficulty? i;

	// Token: 0x040016E2 RID: 5858
	[NonSerialized]
	private bool j;

	// Token: 0x040016E3 RID: 5859
	private bool k;

	// Token: 0x040016E4 RID: 5860
	private List<string> l = new List<string>();
}
