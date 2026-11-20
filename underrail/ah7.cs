using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Common.Data;
using Ouroboros.Playfield.Lightning;

// Token: 0x02000238 RID: 568
[eiz("LD")]
[Serializable]
public sealed class ah7 : c7t, a9q, dcm, bvq, ISerializable
{
	// Token: 0x06000FEA RID: 4074 RVA: 0x00041E9C File Offset: 0x0004009C
	private ah7(SerializationInfo A_0, StreamingContext A_1)
	{
		if (ell.b() != 0)
		{
			this.b = (Guid)A_0.GetValue("LD:I1", typeof(Guid));
			this.c = A_0.GetString("LD:N");
			this.d = A_0.GetInt32("LD:L");
			this.e = A_0.GetBoolean("LD:E");
			this.f = (ae8)A_0.GetValue("LD:L1", typeof(ae8));
			this.g = A_0.GetSingle("LD:LFR");
			this.h = A_0.GetSingle("LD:R");
			di7.ReadList<ExternalResolverReference<ok>>("LD:APP", ref this.i, A_0);
			di7.ReadList<ExternalResolverReference<aue>>("LD:AIP", ref this.j, A_0);
			di7.ReadList<bsf>("LD:I2", ref this.k, A_0);
			this.l = (c1a)A_0.GetValue("LD:Z", typeof(c1a));
			if (ell.b() >= 43)
			{
				this.m = (Vector2)A_0.GetValue("LD:D", typeof(Vector2));
				this.n = A_0.GetSingle("LD:A");
				return;
			}
		}
		else
		{
			if (base.GetType() == typeof(ah7))
			{
				this.b = (Guid)A_0.GetValue("_Id", typeof(Guid));
				this.c = A_0.GetString("_Name");
				this.d = A_0.GetInt32("_Layer");
				this.e = A_0.GetBoolean("_Enabled");
				this.f = (ae8)A_0.GetValue("_Light", typeof(ae8));
				this.g = A_0.GetSingle("_LightFadeRate");
				this.h = A_0.GetSingle("_Range");
				this.i = (List<ExternalResolverReference<ok>>)A_0.GetValue("_AdditionalPenetrationPredicates", typeof(List<ExternalResolverReference<ok>>));
				this.j = (List<ExternalResolverReference<aue>>)A_0.GetValue("_AdditionalImpactPredicates", typeof(List<ExternalResolverReference<aue>>));
				this.k = (List<bsf>)A_0.GetValue("_Instances", typeof(List<bsf>));
				this.l = (c1a)A_0.GetValue("_Zone", typeof(c1a));
				return;
			}
			this.b = (Guid)A_0.GetValue("LanternDefinition+_Id", typeof(Guid));
			this.c = A_0.GetString("LanternDefinition+_Name");
			this.d = A_0.GetInt32("LanternDefinition+_Layer");
			this.e = A_0.GetBoolean("LanternDefinition+_Enabled");
			this.f = (ae8)A_0.GetValue("LanternDefinition+_Light", typeof(ae8));
			this.g = A_0.GetSingle("LanternDefinition+_LightFadeRate");
			this.h = A_0.GetSingle("LanternDefinition+_Range");
			this.i = (List<ExternalResolverReference<ok>>)A_0.GetValue("LanternDefinition+_AdditionalPenetrationPredicates", typeof(List<ExternalResolverReference<ok>>));
			this.j = (List<ExternalResolverReference<aue>>)A_0.GetValue("LanternDefinition+_AdditionalImpactPredicates", typeof(List<ExternalResolverReference<aue>>));
			this.k = (List<bsf>)A_0.GetValue("LanternDefinition+_Instances", typeof(List<bsf>));
			this.l = (c1a)A_0.GetValue("LanternDefinition+_Zone", typeof(c1a));
		}
	}

	// Token: 0x06000FEB RID: 4075 RVA: 0x00042270 File Offset: 0x00040470
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		info.AddValue("LD:I1", this.b);
		info.AddValue("LD:N", this.c);
		info.AddValue("LD:L", this.d);
		info.AddValue("LD:E", this.e);
		info.AddValue("LD:L1", this.f);
		info.AddValue("LD:LFR", this.g);
		info.AddValue("LD:R", this.h);
		di7.WriteList<ExternalResolverReference<ok>>("LD:APP", this.i, info);
		di7.WriteList<ExternalResolverReference<aue>>("LD:AIP", this.j, info);
		di7.WriteList<bsf>("LD:I2", this.k, info);
		info.AddValue("LD:Z", this.l);
		info.AddValue("LD:D", this.m);
		info.AddValue("LD:A", this.n);
	}

	// Token: 0x17000093 RID: 147
	// (get) Token: 0x06000FEC RID: 4076 RVA: 0x0004236C File Offset: 0x0004056C
	[Category("System")]
	public Guid Id
	{
		get
		{
			return this.b;
		}
	}

	// Token: 0x17000094 RID: 148
	// (get) Token: 0x06000FED RID: 4077 RVA: 0x00042374 File Offset: 0x00040574
	// (set) Token: 0x06000FEE RID: 4078 RVA: 0x0004237C File Offset: 0x0004057C
	[Category("System")]
	public string Name
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

	// Token: 0x17000095 RID: 149
	// (get) Token: 0x06000FEF RID: 4079 RVA: 0x00042388 File Offset: 0x00040588
	// (set) Token: 0x06000FF0 RID: 4080 RVA: 0x00042390 File Offset: 0x00040590
	[Category("Meta")]
	public int Layer
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

	// Token: 0x17000096 RID: 150
	// (get) Token: 0x06000FF1 RID: 4081 RVA: 0x0004239C File Offset: 0x0004059C
	// (set) Token: 0x06000FF2 RID: 4082 RVA: 0x000423A4 File Offset: 0x000405A4
	[Category("Behavior")]
	public bool Enabled
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

	// Token: 0x17000097 RID: 151
	// (get) Token: 0x06000FF3 RID: 4083 RVA: 0x000423B0 File Offset: 0x000405B0
	// (set) Token: 0x06000FF4 RID: 4084 RVA: 0x000423B8 File Offset: 0x000405B8
	[Category("Behavior")]
	public ae8 Light
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

	// Token: 0x17000098 RID: 152
	// (get) Token: 0x06000FF5 RID: 4085 RVA: 0x000423C4 File Offset: 0x000405C4
	// (set) Token: 0x06000FF6 RID: 4086 RVA: 0x000423CC File Offset: 0x000405CC
	[Category("Behavior")]
	public float LightFadeRate
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

	// Token: 0x17000099 RID: 153
	// (get) Token: 0x06000FF7 RID: 4087 RVA: 0x000423D8 File Offset: 0x000405D8
	// (set) Token: 0x06000FF8 RID: 4088 RVA: 0x000423E0 File Offset: 0x000405E0
	[Category("Behavior")]
	public float Range
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

	// Token: 0x1700009A RID: 154
	// (get) Token: 0x06000FF9 RID: 4089 RVA: 0x000423EC File Offset: 0x000405EC
	// (set) Token: 0x06000FFA RID: 4090 RVA: 0x000423F4 File Offset: 0x000405F4
	[Category("Behavior")]
	public Vector2 Direction
	{
		get
		{
			return this.m;
		}
		set
		{
			this.m = value;
		}
	}

	// Token: 0x1700009B RID: 155
	// (get) Token: 0x06000FFB RID: 4091 RVA: 0x00042400 File Offset: 0x00040600
	// (set) Token: 0x06000FFC RID: 4092 RVA: 0x00042408 File Offset: 0x00040608
	[Category("Behavior")]
	public float Angle
	{
		get
		{
			return this.n;
		}
		set
		{
			this.n = value;
		}
	}

	// Token: 0x1700009C RID: 156
	// (get) Token: 0x06000FFD RID: 4093 RVA: 0x00042414 File Offset: 0x00040614
	[Browsable(false)]
	public List<ExternalResolverReference<ok>> AdditionalPenetrationPredicates
	{
		get
		{
			return this.i;
		}
	}

	// Token: 0x1700009D RID: 157
	// (get) Token: 0x06000FFE RID: 4094 RVA: 0x0004241C File Offset: 0x0004061C
	[Browsable(false)]
	public List<ExternalResolverReference<aue>> AdditionalImpactPredicates
	{
		get
		{
			return this.j;
		}
	}

	// Token: 0x1700009E RID: 158
	// (get) Token: 0x06000FFF RID: 4095 RVA: 0x00042424 File Offset: 0x00040624
	[Browsable(false)]
	internal v8 UpdateManager
	{
		get
		{
			if (this.Playfield == null)
			{
				return null;
			}
			return this.Playfield.LightProcessor;
		}
	}

	// Token: 0x1700009F RID: 159
	// (get) Token: 0x06001000 RID: 4096 RVA: 0x00042440 File Offset: 0x00040640
	[Browsable(false)]
	private e3h Playfield
	{
		get
		{
			return this.l.Playfield;
		}
	}

	// Token: 0x170000A0 RID: 160
	// (get) Token: 0x06001001 RID: 4097 RVA: 0x00042450 File Offset: 0x00040650
	[Browsable(false)]
	public ReadOnlyCollection<bsf> Instances
	{
		get
		{
			return this.k.AsReadOnly();
		}
	}

	// Token: 0x170000A1 RID: 161
	// (get) Token: 0x06001002 RID: 4098 RVA: 0x00042460 File Offset: 0x00040660
	// (set) Token: 0x06001003 RID: 4099 RVA: 0x00042468 File Offset: 0x00040668
	[Bindable(false)]
	internal c1a Zone
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

	// Token: 0x06001004 RID: 4100 RVA: 0x00042474 File Offset: 0x00040674
	public ah7(string A_0, c1a A_1)
	{
		czh.a(A_0, "name");
		this.b = Guid.NewGuid();
		this.c = A_0;
		this.bc(true);
	}

	// Token: 0x06001005 RID: 4101 RVA: 0x000424F8 File Offset: 0x000406F8
	public bsf g()
	{
		bsf bsf = new bsf(this);
		this.k.Add(bsf);
		return bsf;
	}

	// Token: 0x06001006 RID: 4102 RVA: 0x0004251C File Offset: 0x0004071C
	public void n()
	{
		for (int i = this.k.Count - 1; i >= 0; i--)
		{
			this.k[i].ig();
		}
		if (this.l != null)
		{
			this.l.b(this);
		}
	}

	// Token: 0x06001007 RID: 4103 RVA: 0x00042570 File Offset: 0x00040770
	public void d()
	{
		foreach (bsf bsf in this.k)
		{
			if (bsf.Initialized)
			{
				bsf.b();
			}
		}
	}

	// Token: 0x06001008 RID: 4104 RVA: 0x000425D4 File Offset: 0x000407D4
	internal void a(bsf A_0)
	{
		this.k.Remove(A_0);
	}

	// Token: 0x170000A2 RID: 162
	// (get) Token: 0x06001009 RID: 4105 RVA: 0x000425E4 File Offset: 0x000407E4
	[Browsable(false)]
	public bool Initialized
	{
		get
		{
			return this.a;
		}
	}

	// Token: 0x0600100A RID: 4106 RVA: 0x000425F0 File Offset: 0x000407F0
	public bool bc(bool A_0)
	{
		if (this.a)
		{
			return false;
		}
		foreach (bsf bsf in Enumerable.ToList<bsf>(this.k))
		{
			if (bsf.Carrier == null || bsf.Carrier.Layer != this.Layer || bsf.Carrier.Area == null || bsf.Carrier.Zone == null || bsf.Carrier.Playfield == null)
			{
				this.k.Remove(bsf);
			}
			else
			{
				bsf.bc(true);
			}
		}
		this.a = true;
		return true;
	}

	// Token: 0x0600100B RID: 4107 RVA: 0x000426C8 File Offset: 0x000408C8
	public bool bd(bool A_0)
	{
		if (!this.a)
		{
			return false;
		}
		foreach (bsf bsf in this.k)
		{
			bsf.bd(true);
		}
		this.a = false;
		return true;
	}

	// Token: 0x04000959 RID: 2393
	[NonSerialized]
	private bool a;

	// Token: 0x0400095A RID: 2394
	private Guid b;

	// Token: 0x0400095B RID: 2395
	private string c;

	// Token: 0x0400095C RID: 2396
	private int d;

	// Token: 0x0400095D RID: 2397
	private bool e = true;

	// Token: 0x0400095E RID: 2398
	private ae8 f = new ae8(Color.White, 1f, LightType.Increment);

	// Token: 0x0400095F RID: 2399
	private float g = 0.05f;

	// Token: 0x04000960 RID: 2400
	private float h;

	// Token: 0x04000961 RID: 2401
	private List<ExternalResolverReference<ok>> i = new List<ExternalResolverReference<ok>>();

	// Token: 0x04000962 RID: 2402
	private List<ExternalResolverReference<aue>> j = new List<ExternalResolverReference<aue>>();

	// Token: 0x04000963 RID: 2403
	private List<bsf> k = new List<bsf>();

	// Token: 0x04000964 RID: 2404
	private c1a l;

	// Token: 0x04000965 RID: 2405
	public Vector2 m;

	// Token: 0x04000966 RID: 2406
	public float n;
}
