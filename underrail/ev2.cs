using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;
using Ouroboros.Common.Events;

// Token: 0x02000235 RID: 565
[eiz("ED")]
[Serializable]
public class ev2 : a9q, c7t, bvq, ISerializable
{
	// Token: 0x06000FCC RID: 4044 RVA: 0x000417A8 File Offset: 0x0003F9A8
	protected ev2(SerializationInfo A_0, StreamingContext A_1)
	{
		if (ell.b() != 0)
		{
			this.b = (Guid)A_0.GetValue("ED:I", typeof(Guid));
			this.c = A_0.GetString("ED:N");
			this.d = A_0.GetInt32("ED:L");
			di7.ReadList<ok>("ED:APP", ref this.e, A_0);
			di7.ReadList<aue>("ED:AIP", ref this.f, A_0);
			this.g = (IEventSubscriber<a8f>)A_0.GetValue("ED:CS", typeof(IEventSubscriber<a8f>));
			this.h = A_0.GetBoolean("ED:DDES");
			this.i = A_0.GetBoolean("ED:DDPP");
			this.j = A_0.GetBoolean("ED:DDIP");
			this.k = A_0.GetSingle("ED:R");
			return;
		}
		if (base.GetType() == typeof(ev2))
		{
			this.b = (Guid)A_0.GetValue("_Id", typeof(Guid));
			this.c = A_0.GetString("_Name");
			this.d = A_0.GetInt32("_Layer");
			this.e = (List<ok>)A_0.GetValue("_AdditionalPenetrationPredicates", typeof(List<ok>));
			this.f = (List<aue>)A_0.GetValue("_AdditionalImpactPredicates", typeof(List<aue>));
			this.g = (IEventSubscriber<a8f>)A_0.GetValue("_CustomSubscriber", typeof(IEventSubscriber<a8f>));
			this.h = A_0.GetBoolean("_DisableDefaultEventSubscriber");
			this.i = A_0.GetBoolean("_DisableDefaultPenetrationPredicate");
			this.j = A_0.GetBoolean("_DisableDefaultImpactPredicate");
			this.k = A_0.GetSingle("_Range");
			return;
		}
		this.b = (Guid)A_0.GetValue("EyeDefinition+_Id", typeof(Guid));
		this.c = A_0.GetString("EyeDefinition+_Name");
		this.d = A_0.GetInt32("EyeDefinition+_Layer");
		this.e = (List<ok>)A_0.GetValue("EyeDefinition+_AdditionalPenetrationPredicates", typeof(List<ok>));
		this.f = (List<aue>)A_0.GetValue("EyeDefinition+_AdditionalImpactPredicates", typeof(List<aue>));
		this.g = (IEventSubscriber<a8f>)A_0.GetValue("EyeDefinition+_CustomSubscriber", typeof(IEventSubscriber<a8f>));
		this.h = A_0.GetBoolean("EyeDefinition+_DisableDefaultEventSubscriber");
		this.i = A_0.GetBoolean("EyeDefinition+_DisableDefaultPenetrationPredicate");
		this.j = A_0.GetBoolean("EyeDefinition+_DisableDefaultImpactPredicate");
		this.k = A_0.GetSingle("EyeDefinition+_Range");
	}

	// Token: 0x06000FCD RID: 4045 RVA: 0x00041A8C File Offset: 0x0003FC8C
	public virtual void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		info.AddValue("ED:I", this.b);
		info.AddValue("ED:N", this.c);
		info.AddValue("ED:L", this.d);
		di7.WriteList<ok>("ED:APP", this.e, info);
		di7.WriteList<aue>("ED:AIP", this.f, info);
		info.AddValue("ED:CS", this.g);
		info.AddValue("ED:DDES", this.h);
		info.AddValue("ED:DDPP", this.i);
		info.AddValue("ED:DDIP", this.j);
		info.AddValue("ED:R", this.k);
	}

	// Token: 0x17000089 RID: 137
	// (get) Token: 0x06000FCE RID: 4046 RVA: 0x00041B48 File Offset: 0x0003FD48
	// (set) Token: 0x06000FCF RID: 4047 RVA: 0x00041B50 File Offset: 0x0003FD50
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

	// Token: 0x1700008A RID: 138
	// (get) Token: 0x06000FD0 RID: 4048 RVA: 0x00041B5C File Offset: 0x0003FD5C
	public List<ok> AdditionalPenetrationPredicates
	{
		get
		{
			return this.e;
		}
	}

	// Token: 0x1700008B RID: 139
	// (get) Token: 0x06000FD1 RID: 4049 RVA: 0x00041B64 File Offset: 0x0003FD64
	public List<aue> AdditionalImpactPredicates
	{
		get
		{
			return this.f;
		}
	}

	// Token: 0x1700008C RID: 140
	// (get) Token: 0x06000FD2 RID: 4050 RVA: 0x00041B6C File Offset: 0x0003FD6C
	// (set) Token: 0x06000FD3 RID: 4051 RVA: 0x00041B74 File Offset: 0x0003FD74
	public IEventSubscriber<a8f> CustomSubscriber
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

	// Token: 0x1700008D RID: 141
	// (get) Token: 0x06000FD4 RID: 4052 RVA: 0x00041B80 File Offset: 0x0003FD80
	// (set) Token: 0x06000FD5 RID: 4053 RVA: 0x00041B88 File Offset: 0x0003FD88
	public bool DisableDefaultEventSubscriber
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

	// Token: 0x1700008E RID: 142
	// (get) Token: 0x06000FD6 RID: 4054 RVA: 0x00041B94 File Offset: 0x0003FD94
	// (set) Token: 0x06000FD7 RID: 4055 RVA: 0x00041B9C File Offset: 0x0003FD9C
	public bool DisableDefaultPenetrationPredicate
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

	// Token: 0x1700008F RID: 143
	// (get) Token: 0x06000FD8 RID: 4056 RVA: 0x00041BA8 File Offset: 0x0003FDA8
	// (set) Token: 0x06000FD9 RID: 4057 RVA: 0x00041BB0 File Offset: 0x0003FDB0
	public bool DisableDefaultImpactPredicate
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

	// Token: 0x17000090 RID: 144
	// (get) Token: 0x06000FDA RID: 4058 RVA: 0x00041BBC File Offset: 0x0003FDBC
	// (set) Token: 0x06000FDB RID: 4059 RVA: 0x00041BC4 File Offset: 0x0003FDC4
	public float Range
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

	// Token: 0x17000091 RID: 145
	// (get) Token: 0x06000FDC RID: 4060 RVA: 0x00041BD0 File Offset: 0x0003FDD0
	public Guid Id
	{
		get
		{
			return this.b;
		}
	}

	// Token: 0x17000092 RID: 146
	// (get) Token: 0x06000FDD RID: 4061 RVA: 0x00041BD8 File Offset: 0x0003FDD8
	public string Name
	{
		get
		{
			return this.c;
		}
	}

	// Token: 0x06000FDE RID: 4062 RVA: 0x00041BE0 File Offset: 0x0003FDE0
	public ev2() : this("AnonymousEyeDefinition")
	{
	}

	// Token: 0x06000FDF RID: 4063 RVA: 0x00041BF0 File Offset: 0x0003FDF0
	public ev2(string A_0) : this(Guid.NewGuid(), A_0)
	{
	}

	// Token: 0x06000FE0 RID: 4064 RVA: 0x00041C00 File Offset: 0x0003FE00
	public ev2(Guid A_0, string A_1)
	{
		czh.a(A_1, "name");
		this.b = A_0;
		this.c = A_1;
	}

	// Token: 0x04000949 RID: 2377
	private const string a = "AnonymousEyeDefinition";

	// Token: 0x0400094A RID: 2378
	private Guid b;

	// Token: 0x0400094B RID: 2379
	private string c;

	// Token: 0x0400094C RID: 2380
	private int d;

	// Token: 0x0400094D RID: 2381
	private List<ok> e = new List<ok>();

	// Token: 0x0400094E RID: 2382
	private List<aue> f = new List<aue>();

	// Token: 0x0400094F RID: 2383
	private IEventSubscriber<a8f> g;

	// Token: 0x04000950 RID: 2384
	private bool h;

	// Token: 0x04000951 RID: 2385
	private bool i;

	// Token: 0x04000952 RID: 2386
	private bool j;

	// Token: 0x04000953 RID: 2387
	private float k;
}
