using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Ouroboros.Core.Logging;
using TimelapseVertigo.Rules.Effects;

// Token: 0x02000FB0 RID: 4016
[eiz("SE1")]
[Serializable]
public abstract class els : a9q, ISerializable
{
	// Token: 0x0600521D RID: 21021 RVA: 0x0024CCF0 File Offset: 0x0024AEF0
	protected els(SerializationInfo A_0, StreamingContext A_1)
	{
		this.a = (StatusEffectState)A_0.GetValue("SE1:S", typeof(StatusEffectState));
		this.c = A_0.GetString("SE1:C");
		this.d = A_0.GetString("SE1:N");
		this.e = A_0.GetInt32("SE1:D");
		this.f = A_0.GetInt32("SE1:TP");
		this.g = A_0.GetDouble("SE1:TC");
		this.h = A_0.GetDouble("SE1:TL");
		this.j = (ll)A_0.GetValue("SE1:C1", typeof(ll));
		di7.ReadList<d3e>("SE1:SE", ref this.k, A_0);
		di7.ReadList<wq>("SE1:DE", ref this.l, A_0);
		this.m = (axm)A_0.GetValue("SE1:S1", typeof(axm));
		this.n = A_0.GetInt32("SE1:S2");
		this.o = A_0.GetInt32("SE1:MS");
		this.q = (ci8)A_0.GetValue("SE1:N1", typeof(ci8));
		if (ell.a() >= 95)
		{
			this.r = A_0.GetString("SE1:O");
		}
		else
		{
			object value = A_0.GetValue("SE1:O", typeof(object));
			if (value != null)
			{
				this.r = value.ToString();
			}
		}
		this.s = A_0.GetString("SE1:EA");
		this.t = A_0.GetString("SE1:TA");
		this.ai = A_0.GetInt32("SE1:P");
		di7.ReadList<ud>("SE1:VE", ref this.aj, A_0);
		this.ak = A_0.GetString("SE1:VM");
		this.i = A_0.GetDouble("SE1:RT");
		if (ell.a() >= 78)
		{
			this.al = A_0.GetBoolean("SE1:S3");
		}
		if (ell.a() >= 94)
		{
			this.v = A_0.GetString("SE1:AA");
		}
		if (ell.a() >= 106)
		{
			this.w = A_0.GetString("SE1:I");
			this.x = A_0.GetString("SE1:U");
		}
		if (ell.a() >= 108)
		{
			this.am = A_0.GetString("SE1:CT");
		}
		if (ell.a() >= 188)
		{
			this.u = A_0.GetString("SE1:RA");
		}
		if (ell.a() >= 222)
		{
			this.y = A_0.GetString("SE1:EJ");
			this.z = A_0.GetString("SE1:TJ");
			this.aa = A_0.GetString("SE1:RJ");
			this.ab = A_0.GetString("SE1:AJ");
		}
		if (ell.a() >= 589)
		{
			this.ac = A_0.GetString("SE1:MJ");
		}
		if (ell.a() >= 626)
		{
			this.ad = A_0.GetString("SE1:HJ");
			this.ae = A_0.GetString("SE1:CAJ");
		}
		if (ell.a() >= 627)
		{
			this.af = A_0.GetString("SE1:CTDJ");
		}
		if (ell.a() >= 628)
		{
			this.b = (Guid)A_0.GetValue("SE1:ID", typeof(Guid));
		}
		else
		{
			this.b = Guid.NewGuid();
		}
		if (ell.a() >= 629)
		{
			this.ag = A_0.GetString("SE1:CDJ");
		}
		if (ell.a() >= 633)
		{
			this.p = A_0.GetBoolean("SE1:DS");
		}
		if (ell.a() >= 656)
		{
			this.ah = A_0.GetBoolean("SE1:TB");
		}
	}

	// Token: 0x0600521E RID: 21022 RVA: 0x0024D114 File Offset: 0x0024B314
	public virtual void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		info.AddValue("SE1:S", this.a);
		info.AddValue("SE1:C", this.c);
		info.AddValue("SE1:N", this.d);
		info.AddValue("SE1:D", this.e);
		info.AddValue("SE1:TP", this.f);
		info.AddValue("SE1:TC", this.g);
		info.AddValue("SE1:TL", this.h);
		info.AddValue("SE1:C1", this.j);
		di7.WriteList<d3e>("SE1:SE", this.k, info);
		di7.WriteList<wq>("SE1:DE", this.l, info);
		info.AddValue("SE1:S1", this.m);
		info.AddValue("SE1:S2", this.n);
		info.AddValue("SE1:MS", this.o);
		info.AddValue("SE1:N1", this.q);
		info.AddValue("SE1:O", this.r);
		info.AddValue("SE1:EA", this.s);
		info.AddValue("SE1:TA", this.t);
		info.AddValue("SE1:RA", this.u);
		info.AddValue("SE1:P", this.ai);
		di7.WriteList<ud>("SE1:VE", this.aj, info);
		info.AddValue("SE1:VM", this.ak);
		info.AddValue("SE1:RT", this.i);
		info.AddValue("SE1:S3", this.al);
		info.AddValue("SE1:AA", this.v);
		info.AddValue("SE1:I", this.w);
		info.AddValue("SE1:U", this.x);
		info.AddValue("SE1:CT", this.am);
		info.AddValue("SE1:EJ", this.y);
		info.AddValue("SE1:TJ", this.z);
		info.AddValue("SE1:RJ", this.aa);
		info.AddValue("SE1:AJ", this.ab);
		info.AddValue("SE1:MJ", this.ac);
		info.AddValue("SE1:HJ", this.ad);
		info.AddValue("SE1:CAJ", this.ae);
		info.AddValue("SE1:CTDJ", this.af);
		info.AddValue("SE1:CDJ", this.ag);
		info.AddValue("SE1:ID", this.b);
		info.AddValue("SE1:DS", this.p);
		info.AddValue("SE1:TB", this.ah);
	}

	// Token: 0x1700018E RID: 398
	// (get) Token: 0x0600521F RID: 21023 RVA: 0x0024D3CC File Offset: 0x0024B5CC
	public Guid Id
	{
		get
		{
			return this.b;
		}
	}

	// Token: 0x1700018F RID: 399
	// (get) Token: 0x06005220 RID: 21024 RVA: 0x0024D3D4 File Offset: 0x0024B5D4
	public string Name
	{
		get
		{
			return this.d;
		}
	}

	// Token: 0x17000190 RID: 400
	// (get) Token: 0x06005221 RID: 21025 RVA: 0x0024D3DC File Offset: 0x0024B5DC
	public string LocalizedName
	{
		get
		{
			if (aji.a == null)
			{
				return this.d;
			}
			string text = qv.b("StatusEffectNames/" + this.d);
			if (!string.IsNullOrEmpty(text))
			{
				return text;
			}
			return this.d;
		}
	}

	// Token: 0x17000191 RID: 401
	// (get) Token: 0x06005222 RID: 21026 RVA: 0x0024D424 File Offset: 0x0024B624
	public string Code
	{
		get
		{
			return this.c;
		}
	}

	// Token: 0x17000192 RID: 402
	// (get) Token: 0x06005223 RID: 21027 RVA: 0x0024D42C File Offset: 0x0024B62C
	public StatusEffectState State
	{
		get
		{
			return this.a;
		}
	}

	// Token: 0x17000193 RID: 403
	// (get) Token: 0x06005224 RID: 21028 RVA: 0x0024D434 File Offset: 0x0024B634
	// (set) Token: 0x06005225 RID: 21029 RVA: 0x0024D43C File Offset: 0x0024B63C
	public string Icon
	{
		get
		{
			return this.ak;
		}
		protected set
		{
			this.ak = value;
		}
	}

	// Token: 0x17000194 RID: 404
	// (get) Token: 0x06005226 RID: 21030 RVA: 0x0024D448 File Offset: 0x0024B648
	public List<ud> VisualEffects
	{
		get
		{
			return this.aj;
		}
	}

	// Token: 0x17000195 RID: 405
	// (get) Token: 0x06005227 RID: 21031 RVA: 0x0024D450 File Offset: 0x0024B650
	public List<d3e> StaticEffects
	{
		get
		{
			return this.k;
		}
	}

	// Token: 0x17000196 RID: 406
	// (get) Token: 0x06005228 RID: 21032 RVA: 0x0024D458 File Offset: 0x0024B658
	public List<wq> DynamicEffects
	{
		get
		{
			return this.l;
		}
	}

	// Token: 0x17000197 RID: 407
	// (get) Token: 0x06005229 RID: 21033 RVA: 0x0024D460 File Offset: 0x0024B660
	protected ll Context
	{
		get
		{
			return this.j;
		}
	}

	// Token: 0x17000198 RID: 408
	// (get) Token: 0x0600522A RID: 21034 RVA: 0x0024D468 File Offset: 0x0024B668
	// (set) Token: 0x0600522B RID: 21035 RVA: 0x0024D470 File Offset: 0x0024B670
	public axm Stacking
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

	// Token: 0x17000199 RID: 409
	// (get) Token: 0x0600522C RID: 21036 RVA: 0x0024D47C File Offset: 0x0024B67C
	public virtual bool Refreshable
	{
		get
		{
			return true;
		}
	}

	// Token: 0x1700019A RID: 410
	// (get) Token: 0x0600522D RID: 21037 RVA: 0x0024D480 File Offset: 0x0024B680
	public virtual bool RefreshDuration
	{
		get
		{
			return true;
		}
	}

	// Token: 0x1700019B RID: 411
	// (get) Token: 0x0600522E RID: 21038 RVA: 0x0024D484 File Offset: 0x0024B684
	// (set) Token: 0x0600522F RID: 21039 RVA: 0x0024D48C File Offset: 0x0024B68C
	public int Stacks
	{
		get
		{
			return this.n;
		}
		set
		{
			if (this.n != value)
			{
				this.n = value;
				this.c8();
			}
		}
	}

	// Token: 0x1700019C RID: 412
	// (get) Token: 0x06005230 RID: 21040 RVA: 0x0024D4A8 File Offset: 0x0024B6A8
	// (set) Token: 0x06005231 RID: 21041 RVA: 0x0024D4B0 File Offset: 0x0024B6B0
	public int MaxStacks
	{
		get
		{
			return this.o;
		}
		protected set
		{
			this.o = value;
		}
	}

	// Token: 0x1700019D RID: 413
	// (get) Token: 0x06005232 RID: 21042 RVA: 0x0024D4BC File Offset: 0x0024B6BC
	public ci8 Nature
	{
		get
		{
			return this.q;
		}
	}

	// Token: 0x1700019E RID: 414
	// (get) Token: 0x06005233 RID: 21043 RVA: 0x0024D4C4 File Offset: 0x0024B6C4
	// (set) Token: 0x06005234 RID: 21044 RVA: 0x0024D4CC File Offset: 0x0024B6CC
	public string Origin
	{
		get
		{
			return this.r;
		}
		set
		{
			this.r = value;
		}
	}

	// Token: 0x1700019F RID: 415
	// (get) Token: 0x06005235 RID: 21045 RVA: 0x0024D4D8 File Offset: 0x0024B6D8
	// (set) Token: 0x06005236 RID: 21046 RVA: 0x0024D4E0 File Offset: 0x0024B6E0
	public string ExpiredAction
	{
		get
		{
			return this.s;
		}
		set
		{
			this.s = value;
		}
	}

	// Token: 0x170001A0 RID: 416
	// (get) Token: 0x06005237 RID: 21047 RVA: 0x0024D4EC File Offset: 0x0024B6EC
	// (set) Token: 0x06005238 RID: 21048 RVA: 0x0024D4F4 File Offset: 0x0024B6F4
	public string TickAction
	{
		get
		{
			return this.t;
		}
		set
		{
			this.t = value;
		}
	}

	// Token: 0x170001A1 RID: 417
	// (get) Token: 0x06005239 RID: 21049 RVA: 0x0024D500 File Offset: 0x0024B700
	// (set) Token: 0x0600523A RID: 21050 RVA: 0x0024D508 File Offset: 0x0024B708
	public string RemovedAction
	{
		get
		{
			return this.u;
		}
		set
		{
			this.u = value;
		}
	}

	// Token: 0x170001A2 RID: 418
	// (get) Token: 0x0600523B RID: 21051 RVA: 0x0024D514 File Offset: 0x0024B714
	// (set) Token: 0x0600523C RID: 21052 RVA: 0x0024D51C File Offset: 0x0024B71C
	public string AppliedAction
	{
		get
		{
			return this.v;
		}
		set
		{
			this.v = value;
		}
	}

	// Token: 0x170001A3 RID: 419
	// (get) Token: 0x0600523D RID: 21053 RVA: 0x0024D528 File Offset: 0x0024B728
	// (set) Token: 0x0600523E RID: 21054 RVA: 0x0024D530 File Offset: 0x0024B730
	public int Power
	{
		get
		{
			return this.ai;
		}
		set
		{
			this.ai = value;
		}
	}

	// Token: 0x170001A4 RID: 420
	// (get) Token: 0x0600523F RID: 21055 RVA: 0x0024D53C File Offset: 0x0024B73C
	// (set) Token: 0x06005240 RID: 21056 RVA: 0x0024D544 File Offset: 0x0024B744
	public int Duration
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

	// Token: 0x170001A5 RID: 421
	// (get) Token: 0x06005241 RID: 21057 RVA: 0x0024D550 File Offset: 0x0024B750
	// (set) Token: 0x06005242 RID: 21058 RVA: 0x0024D558 File Offset: 0x0024B758
	public double TimeLeft
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

	// Token: 0x170001A6 RID: 422
	// (get) Token: 0x06005243 RID: 21059 RVA: 0x0024D564 File Offset: 0x0024B764
	// (set) Token: 0x06005244 RID: 21060 RVA: 0x0024D56C File Offset: 0x0024B76C
	public int TickPeriod
	{
		get
		{
			return this.f;
		}
		protected set
		{
			this.f = value;
		}
	}

	// Token: 0x170001A7 RID: 423
	// (get) Token: 0x06005245 RID: 21061 RVA: 0x0024D578 File Offset: 0x0024B778
	// (set) Token: 0x06005246 RID: 21062 RVA: 0x0024D580 File Offset: 0x0024B780
	public bool Silent
	{
		get
		{
			return this.al;
		}
		set
		{
			this.al = value;
		}
	}

	// Token: 0x170001A8 RID: 424
	// (get) Token: 0x06005247 RID: 21063 RVA: 0x0024D58C File Offset: 0x0024B78C
	// (set) Token: 0x06005248 RID: 21064 RVA: 0x0024D594 File Offset: 0x0024B794
	public string ControllerName
	{
		get
		{
			return this.am;
		}
		set
		{
			this.am = value;
		}
	}

	// Token: 0x170001A9 RID: 425
	// (get) Token: 0x06005249 RID: 21065 RVA: 0x0024D5A0 File Offset: 0x0024B7A0
	// (set) Token: 0x0600524A RID: 21066 RVA: 0x0024D5A8 File Offset: 0x0024B7A8
	public bool ControllerActivated
	{
		get
		{
			return this.an;
		}
		set
		{
			this.an = value;
		}
	}

	// Token: 0x170001AA RID: 426
	// (get) Token: 0x0600524B RID: 21067 RVA: 0x0024D5B4 File Offset: 0x0024B7B4
	// (set) Token: 0x0600524C RID: 21068 RVA: 0x0024D5BC File Offset: 0x0024B7BC
	public object Controller
	{
		get
		{
			return this.ao;
		}
		set
		{
			this.ao = value;
		}
	}

	// Token: 0x170001AB RID: 427
	// (get) Token: 0x0600524D RID: 21069 RVA: 0x0024D5C8 File Offset: 0x0024B7C8
	public virtual bool Visible
	{
		get
		{
			return true;
		}
	}

	// Token: 0x0600524E RID: 21070 RVA: 0x0024D5CC File Offset: 0x0024B7CC
	protected els(string A_0, string A_1, ci8 A_2)
	{
		czh.a(A_0, "code");
		czh.a(A_1, "name");
		this.b = Guid.NewGuid();
		this.c = A_0;
		this.d = A_1;
		this.q = A_2;
		this.k = new List<d3e>();
		this.l = new List<wq>();
	}

	// Token: 0x0600524F RID: 21071 RVA: 0x0024D65C File Offset: 0x0024B85C
	public void a(ll A_0, els A_1)
	{
		czh.a(A_0, "context");
		this.j = A_0;
		this.h = (double)this.e;
		if (A_1 != null)
		{
			this.g = A_1.g;
		}
		else
		{
			this.g = (double)this.f;
		}
		this.a = StatusEffectState.Executing;
		this.dp();
	}

	// Token: 0x06005250 RID: 21072 RVA: 0x0024D6BC File Offset: 0x0024B8BC
	public void d(double A_0)
	{
		this.i += A_0;
	}

	// Token: 0x06005251 RID: 21073 RVA: 0x0024D6CC File Offset: 0x0024B8CC
	public void c(double A_0)
	{
		this.e(A_0);
	}

	// Token: 0x06005252 RID: 21074 RVA: 0x0024D6D8 File Offset: 0x0024B8D8
	public bool e(double A_0)
	{
		bool result = false;
		if (this.a == StatusEffectState.Executing)
		{
			if (this.f > 0)
			{
				this.g -= A_0;
				if (this.g <= 0.0)
				{
					this.g = (double)this.f + this.g;
					foreach (wq wq in this.l)
					{
						wq.dk(this.j, this.Stacks);
					}
					result = true;
				}
			}
			if (this.e > 0)
			{
				this.h -= A_0;
				if (this.h <= 0.0)
				{
					if (this.p && this.n > 1)
					{
						int num = this.Stacks;
						this.Stacks = num - 1;
						this.h = (double)this.e;
					}
					else
					{
						this.a = StatusEffectState.Expired;
					}
				}
			}
		}
		else
		{
			dux.b(LogSeverity.Error, "Status effect cannot be updated while in '{0}' state. Code: '{1}', name: '{2}'.", new object[]
			{
				this.a.ToString(),
				this.c,
				this.d
			});
		}
		return result;
	}

	// Token: 0x06005253 RID: 21075 RVA: 0x0024D838 File Offset: 0x0024BA38
	public void o()
	{
		if (this.a == StatusEffectState.Executing)
		{
			if (this.f > 0)
			{
				foreach (wq wq in this.l)
				{
					wq.dl(this.j, this.Stacks);
				}
			}
			if (this.e > 0)
			{
				this.h -= (double)d0u.b;
				if (this.h <= 0.0)
				{
					if (this.p && this.n > 1)
					{
						this.n--;
						this.h = (double)this.e;
						return;
					}
					this.a = StatusEffectState.Expired;
					return;
				}
			}
		}
		else
		{
			dux.b(LogSeverity.Error, "Status effect cannot be updated while in '{0}' state. Code: '{1}', name: '{2}'.", new object[]
			{
				this.a.ToString(),
				this.c,
				this.d
			});
		}
	}

	// Token: 0x06005254 RID: 21076
	public abstract string cb(ll A_0);

	// Token: 0x06005255 RID: 21077 RVA: 0x0024D958 File Offset: 0x0024BB58
	public void ad()
	{
		this.h = (double)this.e;
	}

	// Token: 0x06005256 RID: 21078 RVA: 0x0024D968 File Offset: 0x0024BB68
	protected virtual void c8()
	{
	}

	// Token: 0x06005257 RID: 21079 RVA: 0x0024D96C File Offset: 0x0024BB6C
	protected virtual void dp()
	{
	}

	// Token: 0x04002199 RID: 8601
	private StatusEffectState a;

	// Token: 0x0400219A RID: 8602
	private Guid b;

	// Token: 0x0400219B RID: 8603
	private string c;

	// Token: 0x0400219C RID: 8604
	private string d;

	// Token: 0x0400219D RID: 8605
	private int e;

	// Token: 0x0400219E RID: 8606
	private int f;

	// Token: 0x0400219F RID: 8607
	private double g;

	// Token: 0x040021A0 RID: 8608
	private double h;

	// Token: 0x040021A1 RID: 8609
	public double i;

	// Token: 0x040021A2 RID: 8610
	private ll j;

	// Token: 0x040021A3 RID: 8611
	private List<d3e> k = new List<d3e>();

	// Token: 0x040021A4 RID: 8612
	private List<wq> l = new List<wq>();

	// Token: 0x040021A5 RID: 8613
	private axm m;

	// Token: 0x040021A6 RID: 8614
	private int n = 1;

	// Token: 0x040021A7 RID: 8615
	private int o = 1;

	// Token: 0x040021A8 RID: 8616
	public bool p;

	// Token: 0x040021A9 RID: 8617
	private ci8 q;

	// Token: 0x040021AA RID: 8618
	private string r;

	// Token: 0x040021AB RID: 8619
	private string s;

	// Token: 0x040021AC RID: 8620
	private string t;

	// Token: 0x040021AD RID: 8621
	private string u;

	// Token: 0x040021AE RID: 8622
	private string v;

	// Token: 0x040021AF RID: 8623
	public string w;

	// Token: 0x040021B0 RID: 8624
	public string x;

	// Token: 0x040021B1 RID: 8625
	public string y;

	// Token: 0x040021B2 RID: 8626
	public string z;

	// Token: 0x040021B3 RID: 8627
	public string aa;

	// Token: 0x040021B4 RID: 8628
	public string ab;

	// Token: 0x040021B5 RID: 8629
	public string ac;

	// Token: 0x040021B6 RID: 8630
	public string ad;

	// Token: 0x040021B7 RID: 8631
	public string ae;

	// Token: 0x040021B8 RID: 8632
	public string af;

	// Token: 0x040021B9 RID: 8633
	public string ag;

	// Token: 0x040021BA RID: 8634
	public bool ah;

	// Token: 0x040021BB RID: 8635
	private int ai;

	// Token: 0x040021BC RID: 8636
	private List<ud> aj = new List<ud>();

	// Token: 0x040021BD RID: 8637
	private string ak;

	// Token: 0x040021BE RID: 8638
	private bool al;

	// Token: 0x040021BF RID: 8639
	private string am;

	// Token: 0x040021C0 RID: 8640
	[NonSerialized]
	private bool an;

	// Token: 0x040021C1 RID: 8641
	[NonSerialized]
	private object ao;
}
