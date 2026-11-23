using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Threading;
using Microsoft.Xna.Framework;
using TimelapseVertigo.Common.Data;
using TimelapseVertigo.Rules.Characters;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001C02 RID: 7170
[eiz("CD1")]
[Serializable]
public sealed class nw : dzz, amr, ISerializable
{
	// Token: 0x06009C05 RID: 39941 RVA: 0x003D3D98 File Offset: 0x003D1F98
	private nw(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetBoolean("CD1:SO");
		this.b = A_0.GetInt32("CD1:D");
		this.c = A_0.GetInt32("CD1:E");
		this.d = A_0.GetInt32("CD1:F");
		this.e = A_0.GetInt32("CD1:R");
		if (ell.a() >= 91)
		{
			this.f = A_0.GetDouble("CD1:E1");
		}
		else
		{
			this.f = (double)A_0.GetSingle("CD1:E1");
		}
		if (ell.a() >= 88)
		{
			di7.ReadDictionary<DamageType, du2>("CD1:DR", ref this.h, A_0);
		}
		else
		{
			Dictionary<DamageType, int> dictionary = null;
			di7.ReadDictionary<DamageType, int>("CD1:DR", ref dictionary, A_0);
			if (dictionary != null)
			{
				this.h = new Dictionary<DamageType, du2>();
				foreach (KeyValuePair<DamageType, int> keyValuePair in dictionary)
				{
					this.h[keyValuePair.Key] = new du2(keyValuePair.Key, keyValuePair.Value, 0.0);
				}
			}
		}
		this.k = A_0.GetDouble("CD1:RTC");
		this.m = (IBoundVariable<float>)A_0.GetValue("CD1:H", typeof(IBoundVariable<float>));
		this.n = A_0.GetSingle("CD1:HR");
		this.o = A_0.GetSingle("CD1:HM");
		if (ell.b() >= 5)
		{
			di7.ReadEvent<c1>("CD1:ST", ref this.ab, A_0);
			di7.ReadEvent<EventArgs>("CD1:SH", ref this.ac, A_0);
			di7.ReadEvent<c1>("CD1:SVC", ref this.ad, A_0);
			di7.ReadEvent<EventArgs>("CD1:SC", ref this.ae, A_0);
			di7.ReadEvent<dj7>("CD1:CTD", ref this.af, A_0);
			di7.ReadEvent<dj7>("CD1:CRD", ref this.ag, A_0);
			di7.ReadEvent<dj7>("CD1:CED", ref this.ai, A_0);
			di7.ReadEvent<dj7>("CD1:CSD", ref this.aj, A_0);
			di7.ReadEvent<b8x>("CD1:CIM", ref this.ak, A_0);
			di7.ReadEvent<dsj>("CD1:CSR", ref this.al, A_0);
		}
		else
		{
			this.ab = (EventHandler<c1>)A_0.GetValue("CD1:ST", typeof(EventHandler<c1>));
			this.ac = (EventHandler<EventArgs>)A_0.GetValue("CD1:SH", typeof(EventHandler<EventArgs>));
			this.ad = (EventHandler<c1>)A_0.GetValue("CD1:SVC", typeof(EventHandler<c1>));
			this.ae = (EventHandler<EventArgs>)A_0.GetValue("CD1:SC", typeof(EventHandler<EventArgs>));
			this.af = (EventHandler<dj7>)A_0.GetValue("CD1:CTD", typeof(EventHandler<dj7>));
			this.ag = (EventHandler<dj7>)A_0.GetValue("CD1:CRD", typeof(EventHandler<dj7>));
			this.ai = (EventHandler<dj7>)A_0.GetValue("CD1:CED", typeof(EventHandler<dj7>));
			this.aj = (EventHandler<dj7>)A_0.GetValue("CD1:CSD", typeof(EventHandler<dj7>));
			this.ak = (EventHandler<b8x>)A_0.GetValue("CD1:CIM", typeof(EventHandler<b8x>));
			this.al = (EventHandler<dsj>)A_0.GetValue("CD1:CSR", typeof(EventHandler<dsj>));
		}
		if (ell.b() >= 19)
		{
			this.i = (A_0.GetValue("CD1:DTM", typeof(Dictionary<DamageType, double>)) as Dictionary<DamageType, double>);
		}
		else
		{
			this.a();
		}
		if (ell.b() >= 62)
		{
			di7.ReadEvent<zl>("CD1:CH", ref this.am, A_0);
		}
		if (ell.a() >= 265)
		{
			di7.ReadDictionary<c3e, cgk>("CD1:M", ref this.j, A_0);
		}
		else
		{
			this.j = new Dictionary<c3e, cgk>();
		}
		if (ell.a() >= 97)
		{
			this.g = A_0.GetInt32("CD1:MRS");
		}
		if (ell.a() >= 111)
		{
			this.s = A_0.GetSingle("CD1:M");
		}
		else
		{
			this.s = 1f;
		}
		if (ell.a() >= 112)
		{
			this.t = A_0.GetDouble("CD1:Q");
		}
		if (ell.a() >= 151)
		{
			this.v = A_0.GetDouble("CD1:HFX");
		}
		if (ell.a() >= 164)
		{
			di7.ReadEvent<dj7>("CD1:CBD", ref this.ah, A_0);
		}
		if (ell.a() >= 266)
		{
			this.w = A_0.GetDouble("CD1:ED");
		}
		else
		{
			this.w = 1.0;
		}
		if (ell.a() >= 284)
		{
			this.q = A_0.GetDouble("CD1:THM");
			this.r = A_0.GetInt32("CD1:THB");
		}
		if (ell.a() >= 379)
		{
			this.an = (EventHandler<dj7>)A_0.GetValue("CD1:VTD", typeof(EventHandler<dj7>));
			this.ao = (EventHandler<dj7>)A_0.GetValue("CD1:VRD", typeof(EventHandler<dj7>));
		}
		if (ell.a() >= 450)
		{
			this.u = A_0.GetDouble("CD1:PCM");
		}
		if (ell.a() >= 453)
		{
			this.x = A_0.GetDouble("CD1:AEF");
		}
		else
		{
			this.x = 1.0;
		}
		if (ell.a() >= 485)
		{
			this.y = A_0.GetDouble("CD1:PDT");
		}
		else
		{
			this.y = 1.0;
		}
		if (ell.a() >= 564)
		{
			this.p = (A_0.GetValue("CD1:CUH", typeof(int?)) as int?);
		}
		if (ell.a() >= 591)
		{
			this.l = A_0.GetDouble("CD1:SRT");
		}
		if (ell.a() >= 654)
		{
			this.z = (A_0.GetValue("CD1:SHS", typeof(List<z3>)) as List<z3>);
		}
		if (ell.a() >= 692)
		{
			this.aa = A_0.GetSingle("CD1:CAI");
		}
	}

	// Token: 0x06009C06 RID: 39942 RVA: 0x003D44AC File Offset: 0x003D26AC
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("CD1:SO", this.a);
		info.AddValue("CD1:D", this.b);
		info.AddValue("CD1:E", this.c);
		info.AddValue("CD1:F", this.d);
		info.AddValue("CD1:R", this.e);
		info.AddValue("CD1:E1", this.f);
		di7.WriteDictionary<DamageType, du2>("CD1:DR", this.h, info);
		info.AddValue("CD1:RTC", this.k);
		info.AddValue("CD1:H", this.m);
		info.AddValue("CD1:HR", this.n);
		info.AddValue("CD1:HM", this.o);
		di7.WriteEvent<c1>("CD1:ST", this.ab, info);
		di7.WriteEvent<EventArgs>("CD1:SH", this.ac, info);
		di7.WriteEvent<c1>("CD1:SVC", this.ad, info);
		di7.WriteEvent<EventArgs>("CD1:SC", this.ae, info);
		di7.WriteEvent<dj7>("CD1:CTD", this.af, info);
		di7.WriteEvent<dj7>("CD1:CRD", this.ag, info);
		di7.WriteEvent<dj7>("CD1:CBD", this.ah, info);
		di7.WriteEvent<dj7>("CD1:CED", this.ai, info);
		di7.WriteEvent<dj7>("CD1:CSD", this.aj, info);
		di7.WriteEvent<b8x>("CD1:CIM", this.ak, info);
		di7.WriteEvent<dsj>("CD1:CSR", this.al, info);
		di7.WriteEvent<zl>("CD1:CH", this.am, info);
		info.AddValue("CD1:DTM", this.i);
		di7.WriteDictionary<c3e, cgk>("CD1:M", this.j, info);
		info.AddValue("CD1:MRS", this.g);
		info.AddValue("CD1:M", this.s);
		info.AddValue("CD1:Q", this.t);
		info.AddValue("CD1:HFX", this.v);
		info.AddValue("CD1:ED", this.w);
		info.AddValue("CD1:THM", this.q);
		info.AddValue("CD1:THB", this.r);
		di7.WriteEvent<dj7>("CD1:VTD", this.an, info);
		di7.WriteEvent<dj7>("CD1:VRD", this.ao, info);
		info.AddValue("CD1:PCM", this.u);
		info.AddValue("CD1:AEF", this.x);
		info.AddValue("CD1:PDT", this.y);
		info.AddValue("CD1:CUH", this.p);
		info.AddValue("CD1:SRT", this.l);
		info.AddValue("CD1:SHS", this.z);
		info.AddValue("CD1:CAI", this.aa);
	}

	// Token: 0x06009C07 RID: 39943 RVA: 0x003D4780 File Offset: 0x003D2980
	public double o()
	{
		return this.y;
	}

	// Token: 0x06009C08 RID: 39944 RVA: 0x003D4788 File Offset: 0x003D2988
	public void j(double A_0)
	{
		this.y = Math.Max(0.0, A_0);
	}

	// Token: 0x06009C09 RID: 39945 RVA: 0x003D47A0 File Offset: 0x003D29A0
	public double k()
	{
		return this.q;
	}

	// Token: 0x06009C0A RID: 39946 RVA: 0x003D47A8 File Offset: 0x003D29A8
	public void g(double A_0)
	{
		this.q = A_0;
	}

	// Token: 0x06009C0B RID: 39947 RVA: 0x003D47B4 File Offset: 0x003D29B4
	public int ai()
	{
		return this.r;
	}

	// Token: 0x06009C0C RID: 39948 RVA: 0x003D47BC File Offset: 0x003D29BC
	public void f(int A_0)
	{
		this.r = A_0;
	}

	// Token: 0x06009C0D RID: 39949 RVA: 0x003D47C8 File Offset: 0x003D29C8
	public double aa()
	{
		return this.v;
	}

	// Token: 0x06009C0E RID: 39950 RVA: 0x003D47D0 File Offset: 0x003D29D0
	public void h(double A_0)
	{
		this.v = Math.Max(A_0, aiy.a5);
	}

	// Token: 0x06009C0F RID: 39951 RVA: 0x003D47E4 File Offset: 0x003D29E4
	public bool i4()
	{
		return this.a;
	}

	// Token: 0x06009C10 RID: 39952 RVA: 0x003D47F0 File Offset: 0x003D29F0
	public void a(bool A_0)
	{
		if (this.a != A_0 && (!A_0 || (int)this.i5() > 0))
		{
			bool flag = this.a;
			this.a = A_0;
			if (!this.a)
			{
				base.a1().Cooldowns.a(new List<cfd>
				{
					d7f.f
				});
			}
			if (flag != A_0 && this.ab != null)
			{
				this.ab(this, new c1(flag, A_0));
			}
		}
	}

	// Token: 0x06009C11 RID: 39953 RVA: 0x003D4884 File Offset: 0x003D2A84
	public int v()
	{
		return this.b;
	}

	// Token: 0x06009C12 RID: 39954 RVA: 0x003D488C File Offset: 0x003D2A8C
	public void c(int A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06009C13 RID: 39955 RVA: 0x003D4898 File Offset: 0x003D2A98
	public int z()
	{
		return this.c;
	}

	// Token: 0x06009C14 RID: 39956 RVA: 0x003D48A0 File Offset: 0x003D2AA0
	public void a(int A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06009C15 RID: 39957 RVA: 0x003D48AC File Offset: 0x003D2AAC
	public int ab()
	{
		return this.d;
	}

	// Token: 0x06009C16 RID: 39958 RVA: 0x003D48B4 File Offset: 0x003D2AB4
	public void d(int A_0)
	{
		this.d = A_0;
	}

	// Token: 0x06009C17 RID: 39959 RVA: 0x003D48C0 File Offset: 0x003D2AC0
	public int ae()
	{
		return this.e;
	}

	// Token: 0x06009C18 RID: 39960 RVA: 0x003D48C8 File Offset: 0x003D2AC8
	public void b(int A_0)
	{
		this.e = A_0;
	}

	// Token: 0x06009C19 RID: 39961 RVA: 0x003D48D4 File Offset: 0x003D2AD4
	public Dictionary<DamageType, du2> af()
	{
		return this.h;
	}

	// Token: 0x06009C1A RID: 39962 RVA: 0x003D48DC File Offset: 0x003D2ADC
	public Dictionary<DamageType, double> m()
	{
		return this.i;
	}

	// Token: 0x06009C1B RID: 39963 RVA: 0x003D48E4 File Offset: 0x003D2AE4
	public IBoundVariable<float> q()
	{
		return this.m;
	}

	// Token: 0x06009C1C RID: 39964 RVA: 0x003D48EC File Offset: 0x003D2AEC
	public double i5()
	{
		if (base.a1().Gear.h().Item != null)
		{
			return base.a1().Gear.h().Item.Battery * this.y();
		}
		return 0.0;
	}

	// Token: 0x06009C1D RID: 39965 RVA: 0x003D4940 File Offset: 0x003D2B40
	public void c(double A_0)
	{
		if (base.a1().Gear.h().Item != null && base.a1().Gear.h().Item.Battery != A_0)
		{
			double num = base.a1().Gear.h().Item.Battery * this.y();
			base.a1().Gear.h().Item.Battery = d05.b(0.0, A_0 / this.y(), (double)base.a1().Gear.h().Item.MaxBattery);
			if (this.ad != null)
			{
				this.ad(base.a1(), new c1(num, A_0));
			}
		}
	}

	// Token: 0x06009C1E RID: 39966 RVA: 0x003D4A24 File Offset: 0x003D2C24
	public double y()
	{
		if (base.a1().Gear.h().Item != null)
		{
			return base.a1().Gear.h().Item.TypedDefinition.e();
		}
		return as3.g;
	}

	// Token: 0x06009C1F RID: 39967 RVA: 0x003D4A70 File Offset: 0x003D2C70
	public int p()
	{
		if (base.a1().Gear.h().Item != null)
		{
			return (int)((double)base.a1().Gear.h().Item.MaxBattery * this.y());
		}
		return 0;
	}

	// Token: 0x06009C20 RID: 39968 RVA: 0x003D4ABC File Offset: 0x003D2CBC
	public Color? i6()
	{
		if (base.a1().Gear.h().Item != null)
		{
			return new Color?(base.a1().Gear.h().Item.TypedDefinition.f());
		}
		return null;
	}

	// Token: 0x06009C21 RID: 39969 RVA: 0x003D4B14 File Offset: 0x003D2D14
	public Color? i7()
	{
		if (base.a1().Gear.h().Item != null)
		{
			return new Color?(base.a1().Gear.h().Item.TypedDefinition.d());
		}
		return null;
	}

	// Token: 0x06009C22 RID: 39970 RVA: 0x003D4B6C File Offset: 0x003D2D6C
	public string i8()
	{
		if (base.a1().Gear.h().Item != null)
		{
			return base.a1().Gear.h().Item.TypedDefinition.c();
		}
		return null;
	}

	// Token: 0x06009C23 RID: 39971 RVA: 0x003D4BB4 File Offset: 0x003D2DB4
	public float s()
	{
		return this.n;
	}

	// Token: 0x06009C24 RID: 39972 RVA: 0x003D4BBC File Offset: 0x003D2DBC
	public void b(float A_0)
	{
		this.n = A_0;
	}

	// Token: 0x06009C25 RID: 39973 RVA: 0x003D4BC8 File Offset: 0x003D2DC8
	public float ad()
	{
		return this.o;
	}

	// Token: 0x06009C26 RID: 39974 RVA: 0x003D4BD0 File Offset: 0x003D2DD0
	public void a(float A_0)
	{
		this.o = A_0;
	}

	// Token: 0x06009C27 RID: 39975 RVA: 0x003D4BDC File Offset: 0x003D2DDC
	public double aj()
	{
		return this.f;
	}

	// Token: 0x06009C28 RID: 39976 RVA: 0x003D4BE4 File Offset: 0x003D2DE4
	public void b(double A_0)
	{
		this.f = Math.Round(A_0, 2);
	}

	// Token: 0x06009C29 RID: 39977 RVA: 0x003D4BF4 File Offset: 0x003D2DF4
	public int i()
	{
		return this.g;
	}

	// Token: 0x06009C2A RID: 39978 RVA: 0x003D4BFC File Offset: 0x003D2DFC
	public Dictionary<c3e, cgk> j()
	{
		return this.j;
	}

	// Token: 0x06009C2B RID: 39979 RVA: 0x003D4C04 File Offset: 0x003D2E04
	public float ah()
	{
		return this.s;
	}

	// Token: 0x06009C2C RID: 39980 RVA: 0x003D4C0C File Offset: 0x003D2E0C
	public void c(float A_0)
	{
		this.s = A_0;
	}

	// Token: 0x06009C2D RID: 39981 RVA: 0x003D4C18 File Offset: 0x003D2E18
	public double w()
	{
		return this.t;
	}

	// Token: 0x06009C2E RID: 39982 RVA: 0x003D4C20 File Offset: 0x003D2E20
	public void f(double A_0)
	{
		this.t = A_0;
	}

	// Token: 0x06009C2F RID: 39983 RVA: 0x003D4C2C File Offset: 0x003D2E2C
	public double ac()
	{
		return this.u;
	}

	// Token: 0x06009C30 RID: 39984 RVA: 0x003D4C34 File Offset: 0x003D2E34
	public void e(double A_0)
	{
		this.u = A_0;
	}

	// Token: 0x06009C31 RID: 39985 RVA: 0x003D4C40 File Offset: 0x003D2E40
	public double l()
	{
		return this.w;
	}

	// Token: 0x06009C32 RID: 39986 RVA: 0x003D4C48 File Offset: 0x003D2E48
	public void i(double A_0)
	{
		this.w = Math.Max(aiy.b7, A_0);
	}

	// Token: 0x06009C33 RID: 39987 RVA: 0x003D4C5C File Offset: 0x003D2E5C
	public double ag()
	{
		return this.x;
	}

	// Token: 0x06009C34 RID: 39988 RVA: 0x003D4C64 File Offset: 0x003D2E64
	public void d(double A_0)
	{
		this.x = Math.Max(0.0, A_0);
	}

	// Token: 0x06009C35 RID: 39989 RVA: 0x003D4C80 File Offset: 0x003D2E80
	[CompilerGenerated]
	public void i9(EventHandler<c1> A_0)
	{
		EventHandler<c1> eventHandler = this.ab;
		EventHandler<c1> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<c1> value = (EventHandler<c1>)Delegate.Combine(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<c1>>(ref this.ab, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06009C36 RID: 39990 RVA: 0x003D4CB8 File Offset: 0x003D2EB8
	[CompilerGenerated]
	public void ja(EventHandler<c1> A_0)
	{
		EventHandler<c1> eventHandler = this.ab;
		EventHandler<c1> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<c1> value = (EventHandler<c1>)Delegate.Remove(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<c1>>(ref this.ab, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06009C37 RID: 39991 RVA: 0x003D4CF0 File Offset: 0x003D2EF0
	[CompilerGenerated]
	public void jb(EventHandler<EventArgs> A_0)
	{
		EventHandler<EventArgs> eventHandler = this.ac;
		EventHandler<EventArgs> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<EventArgs> value = (EventHandler<EventArgs>)Delegate.Combine(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs>>(ref this.ac, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06009C38 RID: 39992 RVA: 0x003D4D28 File Offset: 0x003D2F28
	[CompilerGenerated]
	public void jc(EventHandler<EventArgs> A_0)
	{
		EventHandler<EventArgs> eventHandler = this.ac;
		EventHandler<EventArgs> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<EventArgs> value = (EventHandler<EventArgs>)Delegate.Remove(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs>>(ref this.ac, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06009C39 RID: 39993 RVA: 0x003D4D60 File Offset: 0x003D2F60
	[CompilerGenerated]
	public void jd(EventHandler<c1> A_0)
	{
		EventHandler<c1> eventHandler = this.ad;
		EventHandler<c1> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<c1> value = (EventHandler<c1>)Delegate.Combine(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<c1>>(ref this.ad, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06009C3A RID: 39994 RVA: 0x003D4D98 File Offset: 0x003D2F98
	[CompilerGenerated]
	public void je(EventHandler<c1> A_0)
	{
		EventHandler<c1> eventHandler = this.ad;
		EventHandler<c1> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<c1> value = (EventHandler<c1>)Delegate.Remove(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<c1>>(ref this.ad, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06009C3B RID: 39995 RVA: 0x003D4DD0 File Offset: 0x003D2FD0
	[CompilerGenerated]
	public void jf(EventHandler<EventArgs> A_0)
	{
		EventHandler<EventArgs> eventHandler = this.ae;
		EventHandler<EventArgs> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<EventArgs> value = (EventHandler<EventArgs>)Delegate.Combine(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs>>(ref this.ae, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06009C3C RID: 39996 RVA: 0x003D4E08 File Offset: 0x003D3008
	[CompilerGenerated]
	public void jg(EventHandler<EventArgs> A_0)
	{
		EventHandler<EventArgs> eventHandler = this.ae;
		EventHandler<EventArgs> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<EventArgs> value = (EventHandler<EventArgs>)Delegate.Remove(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs>>(ref this.ae, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06009C3D RID: 39997 RVA: 0x003D4E40 File Offset: 0x003D3040
	[CompilerGenerated]
	public void b(EventHandler<dj7> A_0)
	{
		EventHandler<dj7> eventHandler = this.af;
		EventHandler<dj7> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<dj7> value = (EventHandler<dj7>)Delegate.Combine(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<dj7>>(ref this.af, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06009C3E RID: 39998 RVA: 0x003D4E78 File Offset: 0x003D3078
	[CompilerGenerated]
	public void c(EventHandler<dj7> A_0)
	{
		EventHandler<dj7> eventHandler = this.af;
		EventHandler<dj7> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<dj7> value = (EventHandler<dj7>)Delegate.Remove(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<dj7>>(ref this.af, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06009C3F RID: 39999 RVA: 0x003D4EB0 File Offset: 0x003D30B0
	[CompilerGenerated]
	public void g(EventHandler<dj7> A_0)
	{
		EventHandler<dj7> eventHandler = this.ag;
		EventHandler<dj7> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<dj7> value = (EventHandler<dj7>)Delegate.Combine(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<dj7>>(ref this.ag, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06009C40 RID: 40000 RVA: 0x003D4EE8 File Offset: 0x003D30E8
	[CompilerGenerated]
	public void f(EventHandler<dj7> A_0)
	{
		EventHandler<dj7> eventHandler = this.ag;
		EventHandler<dj7> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<dj7> value = (EventHandler<dj7>)Delegate.Remove(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<dj7>>(ref this.ag, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06009C41 RID: 40001 RVA: 0x003D4F20 File Offset: 0x003D3120
	[CompilerGenerated]
	public void l(EventHandler<dj7> A_0)
	{
		EventHandler<dj7> eventHandler = this.ah;
		EventHandler<dj7> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<dj7> value = (EventHandler<dj7>)Delegate.Combine(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<dj7>>(ref this.ah, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06009C42 RID: 40002 RVA: 0x003D4F58 File Offset: 0x003D3158
	[CompilerGenerated]
	public void m(EventHandler<dj7> A_0)
	{
		EventHandler<dj7> eventHandler = this.ah;
		EventHandler<dj7> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<dj7> value = (EventHandler<dj7>)Delegate.Remove(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<dj7>>(ref this.ah, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06009C43 RID: 40003 RVA: 0x003D4F90 File Offset: 0x003D3190
	[CompilerGenerated]
	public void j(EventHandler<dj7> A_0)
	{
		EventHandler<dj7> eventHandler = this.ai;
		EventHandler<dj7> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<dj7> value = (EventHandler<dj7>)Delegate.Combine(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<dj7>>(ref this.ai, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06009C44 RID: 40004 RVA: 0x003D4FC8 File Offset: 0x003D31C8
	[CompilerGenerated]
	public void i(EventHandler<dj7> A_0)
	{
		EventHandler<dj7> eventHandler = this.ai;
		EventHandler<dj7> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<dj7> value = (EventHandler<dj7>)Delegate.Remove(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<dj7>>(ref this.ai, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06009C45 RID: 40005 RVA: 0x003D5000 File Offset: 0x003D3200
	[CompilerGenerated]
	public void d(EventHandler<dj7> A_0)
	{
		EventHandler<dj7> eventHandler = this.aj;
		EventHandler<dj7> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<dj7> value = (EventHandler<dj7>)Delegate.Combine(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<dj7>>(ref this.aj, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06009C46 RID: 40006 RVA: 0x003D5038 File Offset: 0x003D3238
	[CompilerGenerated]
	public void k(EventHandler<dj7> A_0)
	{
		EventHandler<dj7> eventHandler = this.aj;
		EventHandler<dj7> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<dj7> value = (EventHandler<dj7>)Delegate.Remove(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<dj7>>(ref this.aj, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06009C47 RID: 40007 RVA: 0x003D5070 File Offset: 0x003D3270
	[CompilerGenerated]
	public void b(EventHandler<b8x> A_0)
	{
		EventHandler<b8x> eventHandler = this.ak;
		EventHandler<b8x> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<b8x> value = (EventHandler<b8x>)Delegate.Combine(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<b8x>>(ref this.ak, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06009C48 RID: 40008 RVA: 0x003D50A8 File Offset: 0x003D32A8
	[CompilerGenerated]
	public void a(EventHandler<b8x> A_0)
	{
		EventHandler<b8x> eventHandler = this.ak;
		EventHandler<b8x> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<b8x> value = (EventHandler<b8x>)Delegate.Remove(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<b8x>>(ref this.ak, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06009C49 RID: 40009 RVA: 0x003D50E0 File Offset: 0x003D32E0
	[CompilerGenerated]
	public void b(EventHandler<dsj> A_0)
	{
		EventHandler<dsj> eventHandler = this.al;
		EventHandler<dsj> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<dsj> value = (EventHandler<dsj>)Delegate.Combine(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<dsj>>(ref this.al, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06009C4A RID: 40010 RVA: 0x003D5118 File Offset: 0x003D3318
	[CompilerGenerated]
	public void a(EventHandler<dsj> A_0)
	{
		EventHandler<dsj> eventHandler = this.al;
		EventHandler<dsj> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<dsj> value = (EventHandler<dsj>)Delegate.Remove(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<dsj>>(ref this.al, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06009C4B RID: 40011 RVA: 0x003D5150 File Offset: 0x003D3350
	[CompilerGenerated]
	public void b(EventHandler<zl> A_0)
	{
		EventHandler<zl> eventHandler = this.am;
		EventHandler<zl> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<zl> value = (EventHandler<zl>)Delegate.Combine(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<zl>>(ref this.am, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06009C4C RID: 40012 RVA: 0x003D5188 File Offset: 0x003D3388
	[CompilerGenerated]
	public void a(EventHandler<zl> A_0)
	{
		EventHandler<zl> eventHandler = this.am;
		EventHandler<zl> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<zl> value = (EventHandler<zl>)Delegate.Remove(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<zl>>(ref this.am, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06009C4D RID: 40013 RVA: 0x003D51C0 File Offset: 0x003D33C0
	[CompilerGenerated]
	public void n(EventHandler<dj7> A_0)
	{
		EventHandler<dj7> eventHandler = this.an;
		EventHandler<dj7> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<dj7> value = (EventHandler<dj7>)Delegate.Combine(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<dj7>>(ref this.an, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06009C4E RID: 40014 RVA: 0x003D51F8 File Offset: 0x003D33F8
	[CompilerGenerated]
	public void h(EventHandler<dj7> A_0)
	{
		EventHandler<dj7> eventHandler = this.an;
		EventHandler<dj7> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<dj7> value = (EventHandler<dj7>)Delegate.Remove(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<dj7>>(ref this.an, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06009C4F RID: 40015 RVA: 0x003D5230 File Offset: 0x003D3430
	[CompilerGenerated]
	public void e(EventHandler<dj7> A_0)
	{
		EventHandler<dj7> eventHandler = this.ao;
		EventHandler<dj7> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<dj7> value = (EventHandler<dj7>)Delegate.Combine(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<dj7>>(ref this.ao, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06009C50 RID: 40016 RVA: 0x003D5268 File Offset: 0x003D3468
	[CompilerGenerated]
	public void a(EventHandler<dj7> A_0)
	{
		EventHandler<dj7> eventHandler = this.ao;
		EventHandler<dj7> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<dj7> value = (EventHandler<dj7>)Delegate.Remove(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<dj7>>(ref this.ao, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06009C51 RID: 40017 RVA: 0x003D52A0 File Offset: 0x003D34A0
	public nw(efk A_0) : base(A_0)
	{
		this.a();
		this.g();
	}

	// Token: 0x06009C52 RID: 40018 RVA: 0x003D532C File Offset: 0x003D352C
	public void n()
	{
		foreach (object obj in Enum.GetValues(typeof(DamageType)))
		{
			DamageType key = (DamageType)obj;
			this.i[key] = 1.0;
		}
		this.s = 1f;
		this.t = 0.0;
		this.u = 0.0;
		this.j.Clear();
		this.f = 0.0;
		this.v = 1.0;
		this.w = 1.0;
		this.q = 1.0;
		this.r = 0;
		this.y = 1.0;
		this.aa = 0f;
	}

	// Token: 0x06009C53 RID: 40019 RVA: 0x003D5438 File Offset: 0x003D3638
	public void a(ll A_0, SortedList<d3e, RequirementRestrictedElementContainer<d3e>> A_1)
	{
		this.h();
		this.f();
		this.e();
		if (A_0 != null && A_0.a() != null)
		{
			foreach (RequirementRestrictedElementContainer<d3e> a_ in A_1.Values)
			{
				A_0.a().a(a_, A_0);
			}
		}
		this.d();
		this.c();
	}

	// Token: 0x06009C54 RID: 40020 RVA: 0x003D54C4 File Offset: 0x003D36C4
	public void r()
	{
		this.f = d05.b(0.0, this.f, aiy.az);
		this.e = Math.Max(0, this.e);
		this.d = Math.Max(0, this.d);
		this.b = Math.Max(0, this.b);
		this.c = Math.Max(0, this.c);
	}

	// Token: 0x06009C55 RID: 40021 RVA: 0x003D5538 File Offset: 0x003D3738
	public void a(du2 A_0)
	{
		du2 value = this.h[A_0.b()];
		value.a(A_0);
		if (base.a1() is e3q && A_0.b() == DamageType.Mechanical)
		{
			if (value.c() > as3.br)
			{
				value.a(as3.br);
			}
		}
		else if (value.c() > 1.0)
		{
			value.a(1.0);
		}
		this.h[A_0.b()] = value;
	}

	// Token: 0x06009C56 RID: 40022 RVA: 0x003D55D8 File Offset: 0x003D37D8
	public void a(double A_0, bool A_1)
	{
		if (this.i4() && (int)this.i5() <= 0)
		{
			this.a(false);
		}
		if (!A_1)
		{
			if ((this.l += A_0) > (double)as3.f)
			{
				this.a((double)as3.f / (double)d0u.b);
				this.l = 0.0;
			}
			if ((this.k -= A_0) <= 0.0)
			{
				if (!base.a1().Passive)
				{
					this.b();
				}
				this.k = (double)as3.e;
			}
		}
	}

	// Token: 0x06009C57 RID: 40023 RVA: 0x003D568C File Offset: 0x003D388C
	public void t()
	{
		this.a(1.0);
		this.l = 0.0;
	}

	// Token: 0x06009C58 RID: 40024 RVA: 0x003D56B0 File Offset: 0x003D38B0
	public void a(float A_0, bool A_1)
	{
		if (A_0 > 0f && base.a1().Gear.h().Value != null)
		{
			int num = (int)this.i5();
			this.c(this.i5() + (double)A_0);
			int num2 = (int)this.i5() - num;
			if (num2 > 0)
			{
				this.a(num2, A_1);
			}
		}
	}

	// Token: 0x06009C59 RID: 40025 RVA: 0x003D5714 File Offset: 0x003D3914
	public cru a(cwt A_0)
	{
		cru cru = new cru();
		if (!base.a1().Dead && A_0 != null)
		{
			if (A_0.j == null)
			{
				A_0.j = new ap9(base.a1());
			}
			bool flag = false;
			List<csk> list = null;
			List<csk> list2 = null;
			List<csk> list3 = null;
			List<csk> list4 = null;
			List<csk> list5 = null;
			List<csk> list6 = null;
			List<csk> list7 = null;
			List<csk> list8 = null;
			List<csk> list9 = null;
			List<csk> list10 = null;
			List<csk> list11 = null;
			List<csk> list12 = null;
			List<csk> list13 = null;
			List<csk> list14 = null;
			List<csk> list15 = new List<csk>();
			if (A_0.b)
			{
				cn5 cn = bgg.b(A_0.x);
				if (A_0.q)
				{
					list5 = this.a(A_0.f, out list6, A_0.ak);
					list5 = this.b(list5, out list4);
					if (base.a1().Vehicle != null)
					{
						if (base.a1().SpecialStates.k)
						{
							List<csk> a_ = new List<csk>();
							list2 = new List<csk>();
							list = new List<csk>();
							list3 = new List<csk>(list5);
						}
						else
						{
							List<csk> a_ = this.a(list5, out list);
							list2 = this.a(a_, cn, A_0.m, out list3);
						}
						list5 = list;
					}
				}
				else
				{
					if (base.a1().Vehicle != null && A_0.c == null)
					{
						A_0.c = new bool?(cuo.a.NextDouble() < base.a1().Vehicle.ad());
					}
					List<csk> list16 = new List<csk>(A_0.f);
					list16 = this.b(list16, out list4);
					if (cn != null && cn.a != null)
					{
						cn.a(base.a1(), A_0, list16);
					}
					if (base.a1().Vehicle != null && !A_0.p && !A_0.r && A_0.c.GetValueOrDefault())
					{
						if (base.a1().SpecialStates.k)
						{
							list3 = new List<csk>(list16);
							list2 = new List<csk>();
							list5 = new List<csk>();
						}
						else
						{
							list2 = this.a(list16, cn, A_0.m, out list3);
							list5 = new List<csk>();
						}
					}
					else
					{
						list5 = new List<csk>(list16);
					}
				}
				if (!A_0.l && A_0.n < 1.0 && this.i4() && (int)this.i5() > 0)
				{
					list7 = this.a(list5, A_0.h, out list9, A_0.n);
				}
				else
				{
					list7 = new List<csk>(list5);
				}
				if (list7 != null && !A_0.p && list7.Count > 0)
				{
					if (base.a1().SpecialStates.k)
					{
						list13 = new List<csk>(list7);
						list8 = new List<csk>();
					}
					else
					{
						this.a(list7);
						if (A_0.z)
						{
							if (Enumerable.Any<csk>(list7, new Func<csk, bool>(nw.b.a.b)))
							{
								list10 = this.a(A_0, list7, out list12, ref cru);
								goto IL_339;
							}
						}
						list10 = new List<csk>(list7);
						IL_339:
						Dictionary<DamageType, du2> dictionary = new Dictionary<DamageType, du2>(this.h);
						if (A_0.o > 0.0)
						{
							double num = Math.Max(0.0, 1.0 - A_0.o);
							foreach (DamageType key in Enumerable.ToList<DamageType>(dictionary.Keys))
							{
								du2 du = dictionary[key];
								if (du.c() < 1.0)
								{
									dictionary[key] = new du2(du.b(), (int)((double)du.a() * num), du.c() * num);
								}
							}
						}
						foreach (KeyValuePair<c3e, cgk> keyValuePair in this.j)
						{
							ani ani = keyValuePair.Key as ani;
							if (ani != null)
							{
								ani.ah7(dictionary, A_0, keyValuePair.Value, base.a1());
							}
						}
						if (cn.e != null)
						{
							cn.e(base.a1(), dictionary);
						}
						if (this.w != 1.0 && A_0.ad.GetPrimitivePropertyValue<bool>("IsExplosion", new bool?(false)).Value)
						{
							list11 = new List<csk>();
							using (List<csk>.Enumerator enumerator3 = list10.GetEnumerator())
							{
								while (enumerator3.MoveNext())
								{
									csk csk = enumerator3.Current;
									int num2 = (int)((1.0 - this.w) * (double)csk.Amount);
									if (num2 != 0)
									{
										list11.Add(new csk(csk.DamageType, Math.Max(1, csk.Amount - num2)));
										if (num2 > 0)
										{
											list15.Add(new csk(csk.DamageType, num2));
										}
									}
									else
									{
										list11 = new List<csk>(list10);
									}
								}
								goto IL_574;
							}
						}
						list11 = new List<csk>(list10);
						IL_574:
						if (A_0.e)
						{
							b8c b8c = Enumerable.FirstOrDefault<b8c>(Enumerable.OfType<b8c>(this.j.Keys));
							if (b8c != null && b8c.xt(A_0))
							{
								for (int i = list11.Count - 1; i >= 0; i--)
								{
									int num3 = (int)((double)list11[i].Amount * b8c.Reduction);
									if (num3 > 0)
									{
										list15.Add(new csk(list11[i].DamageType, num3));
										if (num3 == list11[i].Amount)
										{
											list11.RemoveAt(i);
										}
										else
										{
											list11[i] = new csk(list11[i].DamageType, list11[i].Amount - num3);
										}
									}
								}
							}
						}
						list8 = this.a(list11, dictionary, cn, A_0.m, out list13);
					}
				}
				else if (base.a1().SpecialStates.k)
				{
					if (list7 == null)
					{
						list13 = new List<csk>();
					}
					else
					{
						list13 = new List<csk>(list7);
					}
					list8 = new List<csk>();
				}
				else if (list7 == null)
				{
					list8 = new List<csk>();
				}
				else
				{
					list8 = new List<csk>(list7);
				}
				if (list4 != null && list4.Count > 0)
				{
					euf.a(list13, list4);
				}
				if (list8 != null && list8.Count > 0)
				{
					if (cn.b != null)
					{
						cn.b(base.a1(), list8);
					}
					list14 = this.a(A_0, list8, ref list13);
					if (!A_0.ah)
					{
						flag = this.a(A_0, list14);
					}
					this.b(list14, A_0.ah);
				}
				if (list2 != null && list2.Count > 0)
				{
					this.a(list2, A_0.ah);
				}
				if (list15.Count > 0)
				{
					foreach (csk item in list15)
					{
						bool flag2 = false;
						for (int j = 0; j < list13.Count; j++)
						{
							if (list13[j].DamageType == item.DamageType)
							{
								csk value = list13[j];
								value.Amount += item.Amount;
								list13[j] = value;
								flag2 = true;
								break;
							}
						}
						if (!flag2)
						{
							list13.Add(item);
						}
					}
				}
				if (!A_0.w)
				{
					base.a1().StatusEffects.a();
				}
				if (base.a1().Vehicle != null && base.a1().Vehicle.ag() == 0.0 && list2 != null && list2.Count > 0)
				{
					cru.c = true;
				}
				else if (flag)
				{
					cru.c = true;
				}
				else if (list14 != null && list14.Count > 0 && this.m.zo() <= 0f)
				{
					cru.c = true;
				}
			}
			if (A_0.ab != null && A_0.ab.Count > 0)
			{
				foreach (d09 d in A_0.ab)
				{
					d.ao0(A_0, base.a1(), list14);
				}
			}
			cru.a = list14;
			cru.b = list7;
			if (list12 != null && list12.Count > 0)
			{
				cru.e = Enumerable.Sum<csk>(list12, new Func<csk, int>(nw.b.a.d));
			}
			if (A_0.b)
			{
				if (list2 != null && list2.Count > 0)
				{
					this.a(A_0, cru, list2);
				}
				if (list3 != null && list3.Count > 0)
				{
					this.a(A_0, cru, list3, list3);
				}
				if (list14 != null && list14.Count > 0)
				{
					this.b(A_0, cru, list14);
				}
				if (list6 != null && list6.Count > 0)
				{
					this.c(A_0, cru, list6, list5);
				}
				if (list9 != null && list9.Count > 0)
				{
					this.e(A_0, cru, list9, list7);
				}
				if (list12 != null && list12.Count > 0)
				{
					this.d(A_0, cru, list12, list10);
				}
				if (list13 != null && list13.Count > 0)
				{
					this.b(A_0, cru, list13, list8);
				}
				if (cru.c)
				{
					base.a1().a(A_0, cru, flag);
				}
			}
			else
			{
				this.a(A_0, cru);
			}
		}
		return cru;
	}

	// Token: 0x06009C5A RID: 40026 RVA: 0x003D6210 File Offset: 0x003D4410
	private List<csk> b(List<csk> A_0, out List<csk> A_1)
	{
		if (!base.a1().SpecialStates.k)
		{
			A_1 = new List<csk>();
			return new List<csk>(A_0);
		}
		amy amy = Enumerable.FirstOrDefault<amy>(base.a1().StatusEffects.Get<amy>());
		if (amy == null)
		{
			A_1 = new List<csk>();
			return new List<csk>(A_0);
		}
		A_1 = new List<csk>();
		List<csk> list = new List<csk>(A_0);
		while (amy.b > 0 && list.Count > 0)
		{
			int val = Math.Max(1, amy.b / list.Count);
			for (int i = list.Count - 1; i >= 0; i--)
			{
				csk value = list[i];
				int num = Math.Min(val, value.Amount);
				value.Amount -= num;
				if (value.Amount <= 0)
				{
					list.RemoveAt(i);
				}
				else
				{
					list[i] = value;
				}
				amy.b -= num;
				euf.a(A_1, new csk(value.DamageType, num));
				if (amy.b <= 0)
				{
					base.a1().StatusEffects.d(amy);
					break;
				}
			}
		}
		return list;
	}

	// Token: 0x06009C5B RID: 40027 RVA: 0x003D6354 File Offset: 0x003D4554
	private void a(List<csk> A_0)
	{
		if (A_0 != null)
		{
			int num = Enumerable.Sum<csk>(A_0, new Func<csk, int>(nw.b.a.e));
			if (num > 0)
			{
				List<cgk> list = new List<cgk>();
				foreach (cgk cgk in new cgk[]
				{
					base.a1().Gear.l().Item,
					base.a1().Gear.l().Item,
					base.a1().Gear.g().Item,
					base.a1().Gear.f().Item
				})
				{
					if (cgk != null && cgk.Definition != null)
					{
						list.Add(cgk);
					}
				}
				if (list.Count > 0)
				{
					cgk cgk2 = list[cuo.a.Next(list.Count)];
					if (!cgk2.Definition.a9() && cgk2.MaxDurability > 0)
					{
						double num2 = (double)Math.Min(dwh.p, num) * (dwh.o + dwh.n * (double)cgk2.MaxDurability) * (double)euf.b().ItemDegradationRate;
						cgk2.Durability = Math.Max(0.0, cgk2.Durability - num2);
						base.a1().c(cgk2);
						base.a1().bl();
					}
				}
			}
		}
	}

	// Token: 0x06009C5C RID: 40028 RVA: 0x003D64E4 File Offset: 0x003D46E4
	private bool a(cwt A_0, List<csk> A_1)
	{
		if (!A_0.r && !A_0.w && !base.a1().Passive && !base.a1().b(d8o.v))
		{
			List<a2> list = base.a1().StatusEffects.Get<a2>();
			if (list != null)
			{
				double? num = null;
				foreach (a2 a in list)
				{
					if (a.ShatteringThreshold != null && (num == null || num.Value > a.ShatteringThreshold.Value))
					{
						num = a.ShatteringThreshold;
					}
				}
				if (num != null)
				{
					return (double)Enumerable.Sum<csk>(Enumerable.Where<csk>(A_1, new Func<csk, bool>(nw.b.a.f)), new Func<csk, int>(nw.b.a.a)) > (double)this.m.zo() * num.Value;
				}
			}
		}
		return false;
	}

	// Token: 0x06009C5D RID: 40029 RVA: 0x003D6644 File Offset: 0x003D4844
	private List<csk> a(cwt A_0, List<csk> A_1, ref List<csk> A_2)
	{
		if (A_1 != null)
		{
			List<csk> list = new List<csk>();
			for (int i = 0; i < A_1.Count; i++)
			{
				csk csk = A_1[i];
				double num = this.i[csk.DamageType];
				kl.a(ref num, csk, base.a1());
				if (A_0.ag && this.y != 1.0)
				{
					num *= this.y;
				}
				if (num != 1.0)
				{
					int num2 = (int)Math.Ceiling((double)csk.Amount * num);
					if (num2 > 0)
					{
						list.Add(new csk(csk.DamageType, num2));
					}
					int num3 = csk.Amount - num2;
					if (num3 > 0)
					{
						int num4 = -1;
						if (A_2 == null)
						{
							A_2 = new List<csk>();
						}
						else if (i < A_2.Count && A_2[i].DamageType == csk.DamageType)
						{
							num4 = i;
						}
						if (num4 != -1 && num4 < A_2.Count)
						{
							csk value = A_2[num4];
							value.Amount += num3;
							A_2[num4] = value;
						}
						else
						{
							A_2.Add(new csk(csk.DamageType, num3));
						}
					}
				}
				else
				{
					list.Add(csk);
				}
			}
			return list;
		}
		return null;
	}

	// Token: 0x06009C5E RID: 40030 RVA: 0x003D67C0 File Offset: 0x003D49C0
	private void b(List<csk> A_0, bool A_1)
	{
		if (base.a1().Dead || base.a1().b(d8o.v))
		{
			return;
		}
		if (A_0 != null && A_0.Count > 0)
		{
			if (Enumerable.Sum<csk>(A_0, new Func<csk, int>(nw.b.a.c)) > 0)
			{
				base.a1().CustomProperties[ddm.g] = new List<csk>(A_0);
			}
			foreach (csk csk in A_0)
			{
				int num;
				if (A_1)
				{
					num = Math.Min((int)(this.m.zo() - 1f), csk.Amount);
					if (num == 0)
					{
						break;
					}
				}
				else
				{
					num = csk.Amount;
				}
				IBoundVariable<float> boundVariable = this.m;
				boundVariable.zp(boundVariable.zo() - (float)num);
				this.m.zp((float)((int)this.m.zo()));
			}
		}
	}

	// Token: 0x06009C5F RID: 40031 RVA: 0x003D68F4 File Offset: 0x003D4AF4
	private void a(List<csk> A_0, bool A_1)
	{
		if (base.a1().Vehicle != null)
		{
			if (A_0 != null && A_0.Count > 0)
			{
				foreach (csk csk in A_0)
				{
					int num;
					if (A_1)
					{
						num = Math.Min((int)(base.a1().Vehicle.ag() - 1.0), csk.Amount);
						if (num == 0)
						{
							break;
						}
					}
					else
					{
						num = csk.Amount;
					}
					base.a1().Vehicle.b(num);
				}
			}
			base.a1().Vehicle.k();
		}
	}

	// Token: 0x06009C60 RID: 40032 RVA: 0x003D69C8 File Offset: 0x003D4BC8
	public void u()
	{
		this.a = false;
	}

	// Token: 0x06009C61 RID: 40033 RVA: 0x003D69D4 File Offset: 0x003D4BD4
	public void a(int A_0, efk A_1, object A_2, bool A_3, bool A_4 = false, bool A_5 = false, float? A_6 = null)
	{
		float num = this.q().zm();
		if (A_6 != null && A_6.Value > 0f && A_6.Value < 1f)
		{
			num = A_6.Value * this.q().zm();
		}
		if (A_0 > 0 && this.q().zo() < num)
		{
			int num2;
			if (A_4)
			{
				num2 = A_0;
			}
			else
			{
				num2 = (int)((double)A_0 * this.v);
			}
			float num3;
			if ((float)num2 > num - this.q().zo())
			{
				num3 = num - this.q().zo();
			}
			else
			{
				num3 = (float)num2;
			}
			IBoundVariable<float> boundVariable = this.q();
			boundVariable.zp(boundVariable.zo() + num3);
			if (A_3 && this.am != null)
			{
				this.am(base.a1(), new zl((int)Math.Ceiling((double)num3), (A_1 != null) ? new ap9(A_1) : null, A_2, A_5));
			}
		}
	}

	// Token: 0x06009C62 RID: 40034 RVA: 0x003D6AE4 File Offset: 0x003D4CE4
	public bool x()
	{
		if (base.a1().IsInCombat || base.a1().Passive || base.a1().b(d8o.e) || this.m.zm() <= 0f || this.m.zo() >= this.m.zm())
		{
			return false;
		}
		float num = Convert.ToSingle(Math.Ceiling((double)(this.m.zo() / this.m.zm() * 100f))) / 100f;
		if (base.a1().Feats.Contains<bze>())
		{
			return (double)num >= bze.a;
		}
		return num >= aiy.a4;
	}

	// Token: 0x06009C63 RID: 40035 RVA: 0x003D6BB4 File Offset: 0x003D4DB4
	public void e(int A_0)
	{
		float num = 1f;
		this.m.zm();
		if (this.m.zm() > 0f)
		{
			num = this.m.zo() / this.m.zm();
		}
		this.m.zn((float)A_0);
		if (num == 1f)
		{
			this.m.zp(this.m.zm());
			return;
		}
		this.m.zp(num * this.m.zm());
	}

	// Token: 0x06009C64 RID: 40036 RVA: 0x003D6C4C File Offset: 0x003D4E4C
	private void h()
	{
		bool flag = base.a1().Dead || this.m.zo() <= 0f;
		float num = 1f;
		float num2 = this.m.zm();
		if (this.m.zm() > 0f)
		{
			num = this.m.zo() / this.m.zm();
		}
		axa axa = base.a1().BaseAbilities.Get<axa>();
		if (this.o == 0f)
		{
			this.o = 1f;
		}
		if (base.a1() is e3q)
		{
			this.o = euf.b().PlayerHealthModifier;
		}
		float num3 = this.o;
		if (base.a1() is e3q)
		{
			if (base.a1().Feats.Contains<c3v>())
			{
				double num4 = c3v.a;
				if (base.a1().Feats.Contains<eh3>())
				{
					num4 += eh3.a;
				}
				num3 *= (float)(1.0 - num4);
			}
		}
		else if (base.a1().b(d8o.o))
		{
			num3 *= euf.b().NpcBossHealthModifier;
		}
		else
		{
			num3 *= euf.b().NpcHealthModifier;
		}
		float num5 = (float)((int)((double)(((float)aiy.a0 + (float)axa.g() * aiy.a2 + (float)c2h.d(base.a1()) * (aiy.a1 + aiy.a3 * (float)axa.g())) * num3) * this.q) + this.r);
		if (num5 > 15f && !(base.a1() is e3q))
		{
			num5 = c2h.a(num5, 10);
		}
		if (this.p != null)
		{
			num5 = (float)this.p.Value;
		}
		this.m.zn(Math.Max(1f, num5));
		if (num2 != this.m.zm())
		{
			this.m.zp((float)((int)(num * this.m.zm())));
		}
		if (!flag && this.m.zo() <= 0f)
		{
			this.m.zp(1f);
		}
		this.n = 2f;
	}

	// Token: 0x06009C65 RID: 40037 RVA: 0x003D6EB0 File Offset: 0x003D50B0
	private void g()
	{
		base.a1().Gear.h().pm(new EventHandler<c1>(this.a));
	}

	// Token: 0x06009C66 RID: 40038 RVA: 0x003D6EE0 File Offset: 0x003D50E0
	private void f()
	{
		this.h = new Dictionary<DamageType, du2>();
		foreach (object obj in Enum.GetValues(typeof(DamageType)))
		{
			DamageType key = (DamageType)obj;
			this.h[key] = default(du2);
		}
		this.g = 0;
		this.a(base.a1().Gear.g().Item);
		this.a(base.a1().Gear.l().Item);
		this.a(base.a1().Gear.f().Item);
	}

	// Token: 0x06009C67 RID: 40039 RVA: 0x003D6FBC File Offset: 0x003D51BC
	private void e()
	{
		e74 e = base.a1().Skills.Get<e74>();
		if (e != null)
		{
			this.b = e.g();
		}
		else
		{
			this.b = 0;
		}
		erc erc = base.a1().Skills.Get<erc>();
		if (erc != null)
		{
			this.c = erc.g();
		}
		else
		{
			this.c = 0;
		}
		this.d = c2h.a(base.a1()) + base.a1().GetSpecializationValue<e8z>(true) * e8z.a;
		this.e = c2h.b(base.a1().BaseAbilities.Will, c2h.d(base.a1()));
	}

	// Token: 0x06009C68 RID: 40040 RVA: 0x003D7074 File Offset: 0x003D5274
	private void d()
	{
		this.z = new List<z3>(5);
		if (base.a1().Gear.h().Item != null && base.a1().Gear.h().Item.TypedDefinition != null)
		{
			foreach (z3 item in base.a1().Gear.h().Item.TypedDefinition.a())
			{
				this.z.Add(item);
			}
		}
	}

	// Token: 0x06009C69 RID: 40041 RVA: 0x003D7130 File Offset: 0x003D5330
	private void c()
	{
		this.b = (int)((double)this.b * (1.0 - Math.Max(0.0, this.f)));
		this.c = (int)((double)this.c * (1.0 - Math.Max(0.0, this.f)));
		base.a1().Skills.Get<a2n>().b((int)((double)base.a1().Skills.Get<a2n>().g() * (1.0 - Math.Max(0.0, this.f))));
	}

	// Token: 0x06009C6A RID: 40042 RVA: 0x003D71E4 File Offset: 0x003D53E4
	private void a(cgk A_0)
	{
		if (A_0 == null)
		{
			return;
		}
		if (A_0.fu() == null)
		{
			return;
		}
		this.b(this.aj() + A_0.fu().h());
		this.g = Math.Max(this.g, A_0.fu().g());
		double num = 1.0 + euf.a(A_0);
		if (num > 0.0 && A_0.fu().i() != null)
		{
			foreach (du2 a_ in A_0.fu().i())
			{
				if (num != 1.0)
				{
					int num2 = (int)((double)a_.a() * num);
					double num3 = a_.c() * num;
					if (num3 < 0.01)
					{
						num3 = 0.0;
					}
					if (num2 != 0 || num3 != 0.0)
					{
						du2 a_2 = new du2(a_.b(), num2, num3);
						this.a(a_2);
					}
				}
				else
				{
					this.a(a_);
				}
			}
		}
		if (A_0.fu().f() != null && A_0.fu().f() != null && A_0.fu().f().Count > 0)
		{
			foreach (c3e c3e in A_0.fu().f())
			{
				bool flag = false;
				if (c3e is y3)
				{
					foreach (KeyValuePair<c3e, cgk> keyValuePair in this.j)
					{
						y3 y = keyValuePair.Value as y3;
						if (y != null && y.ao2(c3e))
						{
							y.ao1(c3e);
							flag = true;
							break;
						}
					}
				}
				if (!flag)
				{
					this.j[c3e.xr()] = A_0;
				}
			}
		}
	}

	// Token: 0x06009C6B RID: 40043 RVA: 0x003D7454 File Offset: 0x003D5654
	private void a(double A_0 = 1.0)
	{
		if (base.a1().Gear.h().Item != null && this.i4())
		{
			int num = (int)((double)this.p() * base.a1().Gear.h().Item.TypedDefinition.b());
			if (num > 0)
			{
				num = (int)Math.Max(1.0, (double)num * A_0);
			}
			if (num > 0)
			{
				this.c((double)Math.Max(0, (int)(this.i5() - (double)num)));
			}
			if ((int)this.i5() <= 0)
			{
				this.a(false);
			}
		}
	}

	// Token: 0x06009C6C RID: 40044 RVA: 0x003D74FC File Offset: 0x003D56FC
	private void b()
	{
		if (this.x())
		{
			IBoundVariable<float> boundVariable = this.m;
			boundVariable.zp(boundVariable.zo() + this.n);
		}
	}

	// Token: 0x06009C6D RID: 40045 RVA: 0x003D7524 File Offset: 0x003D5724
	private List<csk> a(List<csk> A_0, out List<csk> A_1, double A_2 = 0.0)
	{
		if (this.x == 0.0)
		{
			A_1 = new List<csk>();
			return new List<csk>(A_0);
		}
		double num = 0.0;
		if (base.a1().Feats.Contains<cek>())
		{
			num += cek.a;
		}
		double num2 = euf.a(base.a1(), num, this.x * (1.0 - A_2));
		List<csk> list = new List<csk>();
		A_1 = new List<csk>();
		if (A_0 != null)
		{
			foreach (csk csk in A_0)
			{
				int num3 = (int)((double)csk.Amount * num2);
				if (num3 > 0)
				{
					A_1.Add(new csk(csk.DamageType, num3));
				}
				list.Add(new csk(csk.DamageType, csk.Amount - num3));
			}
		}
		return list;
	}

	// Token: 0x06009C6E RID: 40046 RVA: 0x003D7634 File Offset: 0x003D5834
	private List<csk> a(List<csk> A_0, out List<csk> A_1)
	{
		List<csk> list = new List<csk>();
		A_1 = new List<csk>();
		if (base.a1().Vehicle != null)
		{
			if (A_0 == null)
			{
				return list;
			}
			double num = base.a1().Vehicle.ad();
			using (List<csk>.Enumerator enumerator = A_0.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					csk csk = enumerator.Current;
					int num2 = (int)((double)csk.Amount * num);
					if (num2 > 0)
					{
						A_1.Add(new csk(csk.DamageType, num2));
					}
					if (num2 < csk.Amount)
					{
						list.Add(new csk(csk.DamageType, csk.Amount - num2));
					}
				}
				return list;
			}
		}
		if (A_0 != null)
		{
			list.AddRange(A_0);
		}
		return list;
	}

	// Token: 0x06009C6F RID: 40047 RVA: 0x003D7718 File Offset: 0x003D5918
	private List<csk> a(cwt A_0, List<csk> A_1, out List<csk> A_2, ref cru A_3)
	{
		List<csk> list = new List<csk>();
		A_2 = new List<csk>();
		int num = 0;
		if (A_0.d && base.a1().Gear.l().Item != null && base.a1().Gear.l().Item.fu() != null)
		{
			num = euf.b(base.a1());
		}
		if (!base.a1().IsDisabled && base.a1().Feats.Contains<dyn>() && cuo.a.NextDouble() < dyn.a + (double)base.a1().GetSpecializationValue<ee6>(true) * ee6.a)
		{
			num += (int)((double)base.a1().BaseAbilities.Strength * (2.0 + (double)base.a1().GetSpecializationValue<dk4>(true) * dk4.a));
		}
		if (!base.a1().IsDisabled)
		{
			List<ep3> microfeats = base.a1().GetMicrofeats<ep3>();
			if (microfeats != null && microfeats.Count > 0)
			{
				int a_ = base.a1().Skills.Get<jk>().g();
				foreach (ep3 ep in microfeats)
				{
					double num2;
					int num3;
					ep.a(a_, out num2, out num3);
					if (cuo.a.NextDouble() < num2)
					{
						num += num3;
					}
				}
			}
		}
		if (!base.a1().IsDisabled && base.a1().Feats.Contains<du9>() && (euf.g(base.a1().Offense.u()) || euf.f(base.a1().Offense.u())))
		{
			double num4 = du9.b + du9.c * (double)Math.Max(0, base.a1().BaseAbilities.Dexterity - du9.a) + (double)base.a1().GetSpecializationValue<awf>(true) * awf.a;
			if (cuo.a.NextDouble() < num4)
			{
				double num5 = euf.b(base.a1().Offense.u());
				if (euf.f(base.a1().Offense.u()))
				{
					num5 *= 2.0;
				}
				double num6 = num5;
				double num7 = 1.0 + (double)base.a1().GetSpecializationValue<eiy>(true) * eiy.a;
				dwd microfeat = base.a1().GetMicrofeat<dwd>();
				if (microfeat != null)
				{
					num7 += microfeat.a();
				}
				num6 *= Math.Max(0.0, num7);
				num += (int)num6;
			}
		}
		a3w a3w = Enumerable.FirstOrDefault<a3w>(base.a1().StatusEffects.Get<a3w>());
		if (a3w != null && cuo.a.NextDouble() < a9.d)
		{
			num += a3w.BlockAmount;
			if (a3w.Stacks > 1)
			{
				a3w a3w2 = a3w;
				int num8 = a3w2.Stacks;
				a3w2.Stacks = num8 - 1;
			}
			else
			{
				base.a1().StatusEffects.d(a3w);
			}
			A_3.d = true;
		}
		if (!base.a1().IsDisabled && euf.d(base.a1().Offense.u().TypedDefinition).GetValueOrDefault() == WeaponSubtype.Spear)
		{
			ar3 ar = Enumerable.FirstOrDefault<ar3>(base.a1().StatusEffects.Get<ar3>());
			if (ar != null && cuo.a.NextDouble() < ar.b)
			{
				num += ar.c;
			}
		}
		int num9 = 0;
		foreach (csk item in A_1)
		{
			if (num > 0 && item.DamageType == DamageType.Mechanical && item.Amount > 0)
			{
				int num10 = Math.Min(item.Amount, num);
				if (num10 < item.Amount)
				{
					list.Add(new csk(DamageType.Mechanical, item.Amount - num10));
				}
				num9 += num10;
				num -= num10;
			}
			else
			{
				list.Add(item);
			}
		}
		if (num9 > 0)
		{
			A_2.Add(new csk(DamageType.Mechanical, num9));
			if (base.a1().Feats.Contains<u3>() && euf.g(base.a1().Offense.u()))
			{
				int a_2 = 0;
				c6e microfeat2 = base.a1().GetMicrofeat<c6e>();
				if (microfeat2 != null)
				{
					a_2 = microfeat2.a();
				}
				base.a1().StatusEffects.a(new edz(a_2), false, false, false);
			}
		}
		return list;
	}

	// Token: 0x06009C70 RID: 40048 RVA: 0x003D7C14 File Offset: 0x003D5E14
	private List<csk> a(List<csk> A_0, ImpactSpeed A_1, out List<csk> A_2, double A_3)
	{
		A_2 = new List<csk>();
		List<csk> list = new List<csk>();
		if (A_0 == null)
		{
			return null;
		}
		int num = (int)((double)this.a(A_1) * (1.0 - A_3));
		for (int i = 0; i < A_0.Count; i++)
		{
			csk csk = A_0[i];
			int num3;
			if (num > 0)
			{
				int num2 = Math.Min(csk.Amount, num / (A_0.Count - i));
				if (num2 > 0)
				{
					A_2.Add(new csk(csk.DamageType, num2));
					this.c(this.i5() - (double)num2);
				}
				num3 = csk.Amount - num2;
				num -= num2;
			}
			else
			{
				num3 = csk.Amount;
			}
			if (num3 > 0)
			{
				list.Add(new csk(csk.DamageType, num3));
			}
		}
		if (A_2.Count > 0 && this.ac != null)
		{
			this.ac(base.a1(), new EventArgs());
		}
		if ((int)this.i5() <= 0)
		{
			this.a(false);
		}
		return list;
	}

	// Token: 0x06009C71 RID: 40049 RVA: 0x003D7D38 File Offset: 0x003D5F38
	private List<csk> a(List<csk> A_0, cn5 A_1, bool A_2, out List<csk> A_3)
	{
		A_3 = new List<csk>();
		if (A_0 == null)
		{
			return null;
		}
		List<csk> list = new List<csk>();
		if (base.a1().Vehicle != null)
		{
			Dictionary<DamageType, du2> dictionary = base.a1().Vehicle.j();
			foreach (csk item in A_0)
			{
				if (dictionary.ContainsKey(item.DamageType))
				{
					int val;
					if (!A_2)
					{
						val = Convert.ToInt32((double)dictionary[item.DamageType].a() * A_1.c[item.DamageType]);
					}
					else
					{
						val = 0;
					}
					int val2;
					if (dictionary[item.DamageType].c() >= 1.0)
					{
						val2 = item.Amount;
					}
					else
					{
						val2 = Convert.ToInt32((double)item.Amount * Math.Min(0.95, dictionary[item.DamageType].c() * A_1.d[item.DamageType]));
					}
					int val3 = Math.Min(item.Amount, Math.Max(val, val2));
					int num = Math.Min(item.Amount, val3);
					if (num > 0)
					{
						csk item2 = new csk(item.DamageType, num);
						A_3.Add(item2);
					}
					list.Add(new csk(item.DamageType, item.Amount - num));
				}
				else
				{
					list.Add(item);
				}
			}
		}
		return list;
	}

	// Token: 0x06009C72 RID: 40050 RVA: 0x003D7F08 File Offset: 0x003D6108
	private List<csk> a(List<csk> A_0, Dictionary<DamageType, du2> A_1, cn5 A_2, bool A_3, out List<csk> A_4)
	{
		A_4 = new List<csk>();
		if (A_0 == null)
		{
			return null;
		}
		if (base.a1().b(d8o.v))
		{
			A_4.AddRange(A_0);
			return null;
		}
		List<csk> list = new List<csk>();
		foreach (csk item in A_0)
		{
			if (A_1.ContainsKey(item.DamageType))
			{
				int val;
				if (!A_3)
				{
					val = Convert.ToInt32((double)A_1[item.DamageType].a() * A_2.c[item.DamageType]);
				}
				else
				{
					val = 0;
				}
				int val2;
				if (A_1[item.DamageType].c() >= 1.0 && !A_2.f[item.DamageType])
				{
					val2 = item.Amount;
				}
				else
				{
					val2 = Convert.ToInt32((double)item.Amount * Math.Min(0.95, A_1[item.DamageType].c() * A_2.d[item.DamageType]));
				}
				int val3 = Math.Min(item.Amount, Math.Max(val, val2));
				int num = Math.Min(item.Amount, val3);
				if (num > 0)
				{
					csk item2 = new csk(item.DamageType, num);
					A_4.Add(item2);
				}
				list.Add(new csk(item.DamageType, item.Amount - num));
			}
			else
			{
				list.Add(item);
			}
		}
		return list;
	}

	// Token: 0x06009C73 RID: 40051 RVA: 0x003D80EC File Offset: 0x003D62EC
	private int a(ImpactSpeed A_0)
	{
		nw.a a = new nw.a();
		a.a = A_0;
		if (this.z != null)
		{
			return (int)Math.Min((double)Enumerable.FirstOrDefault<z3>(Enumerable.Where<z3>(this.z, new Func<z3, bool>(a.a))).Value, this.i5());
		}
		return 0;
	}

	// Token: 0x06009C74 RID: 40052 RVA: 0x003D8144 File Offset: 0x003D6344
	private void a(cwt A_0, cru A_1)
	{
		if (this.ak != null)
		{
			this.ak(base.a1(), new b8x(A_0, A_1, false));
		}
	}

	// Token: 0x06009C75 RID: 40053 RVA: 0x003D816C File Offset: 0x003D636C
	private void a(int A_0, bool A_1)
	{
		if (this.al != null)
		{
			this.al(base.a1(), new dsj(A_0, A_1));
		}
	}

	// Token: 0x06009C76 RID: 40054 RVA: 0x003D8194 File Offset: 0x003D6394
	private void b(cwt A_0, cru A_1, List<csk> A_2)
	{
		if (this.af != null)
		{
			this.af(base.a1(), new dj7(A_0, A_1, A_2, null));
		}
	}

	// Token: 0x06009C77 RID: 40055 RVA: 0x003D81C8 File Offset: 0x003D63C8
	private void e(cwt A_0, cru A_1, List<csk> A_2, List<csk> A_3)
	{
		if (this.aj != null)
		{
			this.aj(base.a1(), new dj7(A_0, A_1, A_2, A_3));
		}
	}

	// Token: 0x06009C78 RID: 40056 RVA: 0x003D81FC File Offset: 0x003D63FC
	private void d(cwt A_0, cru A_1, List<csk> A_2, List<csk> A_3)
	{
		if (this.ah != null)
		{
			this.ah(base.a1(), new dj7(A_0, A_1, A_2, A_3));
		}
	}

	// Token: 0x06009C79 RID: 40057 RVA: 0x003D8230 File Offset: 0x003D6430
	private void c(cwt A_0, cru A_1, List<csk> A_2, List<csk> A_3)
	{
		if (this.ai != null)
		{
			this.ai(base.a1(), new dj7(A_0, A_1, A_2, A_3));
		}
	}

	// Token: 0x06009C7A RID: 40058 RVA: 0x003D8264 File Offset: 0x003D6464
	private void b(cwt A_0, cru A_1, List<csk> A_2, List<csk> A_3)
	{
		if (this.ag != null)
		{
			this.ag(base.a1(), new dj7(A_0, A_1, A_2, A_3));
		}
	}

	// Token: 0x06009C7B RID: 40059 RVA: 0x003D8298 File Offset: 0x003D6498
	private void a(cwt A_0, cru A_1, List<csk> A_2, List<csk> A_3)
	{
		if (this.ao != null)
		{
			this.ao(base.a1(), new dj7(A_0, A_1, A_2, A_3));
		}
	}

	// Token: 0x06009C7C RID: 40060 RVA: 0x003D82CC File Offset: 0x003D64CC
	private void a(cwt A_0, cru A_1, List<csk> A_2)
	{
		if (this.an != null)
		{
			this.an(base.a1(), new dj7(A_0, A_1, A_2, null));
		}
	}

	// Token: 0x06009C7D RID: 40061 RVA: 0x003D8300 File Offset: 0x003D6500
	private void a()
	{
		this.i = new Dictionary<DamageType, double>();
		foreach (object obj in Enum.GetValues(typeof(DamageType)))
		{
			DamageType key = (DamageType)obj;
			this.i[key] = 1.0;
		}
	}

	// Token: 0x06009C7E RID: 40062 RVA: 0x003D8384 File Offset: 0x003D6584
	[dcc("CD1:mSVC")]
	private void b(object A_0, c1 A_1)
	{
	}

	// Token: 0x06009C7F RID: 40063 RVA: 0x003D8388 File Offset: 0x003D6588
	[dcc("CD1:mSEIC")]
	private void a(object A_0, c1 A_1)
	{
		if (this.ae != null)
		{
			this.ae(base.a1(), new EventArgs());
		}
	}

	// Token: 0x06009C80 RID: 40064 RVA: 0x003D83B0 File Offset: 0x003D65B0
	public void a(DamageType A_0, double A_1)
	{
		double val = 0.0;
		if (A_0 == DamageType.Mechanical && base.a1() is e3q)
		{
			val = 0.1;
		}
		this.i[A_0] = Math.Max(val, this.i[A_0] + A_1);
	}

	// Token: 0x04003C5E RID: 15454
	private bool a;

	// Token: 0x04003C5F RID: 15455
	private int b;

	// Token: 0x04003C60 RID: 15456
	private int c;

	// Token: 0x04003C61 RID: 15457
	private int d;

	// Token: 0x04003C62 RID: 15458
	private int e;

	// Token: 0x04003C63 RID: 15459
	private double f;

	// Token: 0x04003C64 RID: 15460
	private int g;

	// Token: 0x04003C65 RID: 15461
	private Dictionary<DamageType, du2> h = new Dictionary<DamageType, du2>();

	// Token: 0x04003C66 RID: 15462
	private Dictionary<DamageType, double> i = new Dictionary<DamageType, double>();

	// Token: 0x04003C67 RID: 15463
	private Dictionary<c3e, cgk> j = new Dictionary<c3e, cgk>();

	// Token: 0x04003C68 RID: 15464
	private double k = (double)as3.e;

	// Token: 0x04003C69 RID: 15465
	private double l;

	// Token: 0x04003C6A RID: 15466
	private IBoundVariable<float> m = new BoundVariable<float>(0f, 0f);

	// Token: 0x04003C6B RID: 15467
	private float n;

	// Token: 0x04003C6C RID: 15468
	private float o;

	// Token: 0x04003C6D RID: 15469
	public int? p;

	// Token: 0x04003C6E RID: 15470
	private double q;

	// Token: 0x04003C6F RID: 15471
	private int r;

	// Token: 0x04003C70 RID: 15472
	private float s;

	// Token: 0x04003C71 RID: 15473
	private double t;

	// Token: 0x04003C72 RID: 15474
	private double u;

	// Token: 0x04003C73 RID: 15475
	private double v;

	// Token: 0x04003C74 RID: 15476
	private double w;

	// Token: 0x04003C75 RID: 15477
	private double x = 1.0;

	// Token: 0x04003C76 RID: 15478
	private double y = 1.0;

	// Token: 0x04003C77 RID: 15479
	public List<z3> z = new List<z3>(5);

	// Token: 0x04003C78 RID: 15480
	public float aa;

	// Token: 0x04003C79 RID: 15481
	[CompilerGenerated]
	private EventHandler<c1> ab;

	// Token: 0x04003C7A RID: 15482
	[CompilerGenerated]
	private EventHandler<EventArgs> ac;

	// Token: 0x04003C7B RID: 15483
	[CompilerGenerated]
	private EventHandler<c1> ad;

	// Token: 0x04003C7C RID: 15484
	[CompilerGenerated]
	private EventHandler<EventArgs> ae;

	// Token: 0x04003C7D RID: 15485
	[CompilerGenerated]
	private EventHandler<dj7> af;

	// Token: 0x04003C7E RID: 15486
	[CompilerGenerated]
	private EventHandler<dj7> ag;

	// Token: 0x04003C7F RID: 15487
	[CompilerGenerated]
	private EventHandler<dj7> ah;

	// Token: 0x04003C80 RID: 15488
	[CompilerGenerated]
	private EventHandler<dj7> ai;

	// Token: 0x04003C81 RID: 15489
	[CompilerGenerated]
	private EventHandler<dj7> aj;

	// Token: 0x04003C82 RID: 15490
	[CompilerGenerated]
	private EventHandler<b8x> ak;

	// Token: 0x04003C83 RID: 15491
	[CompilerGenerated]
	private EventHandler<dsj> al;

	// Token: 0x04003C84 RID: 15492
	[CompilerGenerated]
	private EventHandler<zl> am;

	// Token: 0x04003C85 RID: 15493
	[CompilerGenerated]
	private EventHandler<dj7> an;

	// Token: 0x04003C86 RID: 15494
	[CompilerGenerated]
	private EventHandler<dj7> ao;

	// Token: 0x02001C03 RID: 7171
	[CompilerGenerated]
	[Serializable]
	private sealed class b
	{
		// Token: 0x06009C83 RID: 40067 RVA: 0x003D841C File Offset: 0x003D661C
		internal bool b(csk A_0)
		{
			return A_0.DamageType == DamageType.Mechanical && A_0.Amount > 0;
		}

		// Token: 0x06009C84 RID: 40068 RVA: 0x003D8438 File Offset: 0x003D6638
		internal int d(csk A_0)
		{
			return A_0.Amount;
		}

		// Token: 0x06009C85 RID: 40069 RVA: 0x003D8444 File Offset: 0x003D6644
		internal int e(csk A_0)
		{
			return A_0.Amount;
		}

		// Token: 0x06009C86 RID: 40070 RVA: 0x003D8450 File Offset: 0x003D6650
		internal bool f(csk A_0)
		{
			return A_0.DamageType == DamageType.Cold || A_0.DamageType == DamageType.Mechanical;
		}

		// Token: 0x06009C87 RID: 40071 RVA: 0x003D846C File Offset: 0x003D666C
		internal int a(csk A_0)
		{
			return A_0.Amount;
		}

		// Token: 0x06009C88 RID: 40072 RVA: 0x003D8478 File Offset: 0x003D6678
		internal int c(csk A_0)
		{
			return A_0.Amount;
		}

		// Token: 0x04003C87 RID: 15495
		public static readonly nw.b a = new nw.b();

		// Token: 0x04003C88 RID: 15496
		public static Func<csk, bool> b;

		// Token: 0x04003C89 RID: 15497
		public static Func<csk, int> c;

		// Token: 0x04003C8A RID: 15498
		public static Func<csk, int> d;

		// Token: 0x04003C8B RID: 15499
		public static Func<csk, bool> e;

		// Token: 0x04003C8C RID: 15500
		public static Func<csk, int> f;

		// Token: 0x04003C8D RID: 15501
		public static Func<csk, int> g;
	}

	// Token: 0x02001C04 RID: 7172
	[CompilerGenerated]
	private sealed class a
	{
		// Token: 0x06009C8A RID: 40074 RVA: 0x003D848C File Offset: 0x003D668C
		internal bool a(z3 A_0)
		{
			return A_0.ImpactSpeed == this.a;
		}

		// Token: 0x04003C8E RID: 15502
		public ImpactSpeed a;
	}
}
