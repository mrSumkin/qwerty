using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Threading;
using TimelapseVertigo.Common.Data;
using TimelapseVertigo.Rules.Characters;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001C05 RID: 7173
[eiz("CO1")]
[Serializable]
public sealed class dcu : dzz, ISerializable
{
	// Token: 0x06009C8B RID: 40075 RVA: 0x003D84A0 File Offset: 0x003D66A0
	private dcu(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (cd1)A_0.GetValue("CO1:CW", typeof(cd1));
		if (ell.a() >= 210)
		{
			this.b = A_0.GetDouble("CO1:CDB");
		}
		else
		{
			this.b = (double)A_0.GetSingle("CO1:CDB");
		}
		if (ell.a() >= 101)
		{
			this.c = A_0.GetDouble("CO1:CC");
		}
		else
		{
			this.c = Math.Round((double)A_0.GetSingle("CO1:CC"), 2);
		}
		this.d = (WeaponKey)A_0.GetValue("CO1:CWK", typeof(WeaponKey));
		this.e = A_0.GetDouble("CO1:TTNS");
		di7.ReadDictionary<PsiSchool, bas>("CO1:PO", ref this.g, A_0);
		this.h = (IBoundVariable<float>)A_0.GetValue("CO1:P", typeof(IBoundVariable<float>));
		this.l = A_0.GetSingle("CO1:WAS");
		this.p = (ahx)A_0.GetValue("CO1:II", typeof(ahx));
		this.q = A_0.GetDouble("CO1:RTC");
		this.al = (EventHandler<EventArgs>)A_0.GetValue("CO1:CWS", typeof(EventHandler<EventArgs>));
		if (ell.a() >= 61)
		{
			this.m = A_0.GetInt32("CO1:A");
		}
		if (ell.a() >= 62)
		{
			di7.ReadEvent<ax0>("CO1:PA", ref this.am, A_0);
		}
		if (ell.a() >= 75)
		{
			this.j = A_0.GetInt32("CO1:NMP");
		}
		if (ell.a() >= 87)
		{
			this.f = A_0.GetDouble("CO1:F");
		}
		if (ell.a() >= 110)
		{
			this.r = A_0.GetDouble("CO1:X");
		}
		else
		{
			this.r = 1.0;
		}
		if (ell.a() >= 115)
		{
			this.k = A_0.GetDouble("CO1:PRM");
		}
		else
		{
			this.k = 1.0;
		}
		if (ell.a() >= 118)
		{
			this.ab = A_0.GetInt32("CO1:PR");
		}
		if (ell.a() >= 134)
		{
			this.ac = A_0.GetInt32("CO1:B");
		}
		if (ell.a() >= 135)
		{
			this.ad = A_0.GetDouble("CO1:H");
		}
		if (ell.a() >= 166)
		{
			this.af = A_0.GetDouble("CO1:SAB");
		}
		if (ell.a() >= 617)
		{
			this.n = A_0.GetDouble("CO1:WM");
		}
		else
		{
			this.n = 1.0;
		}
		if (ell.a() >= 183)
		{
			this.ag = A_0.GetInt32("CO1:I");
		}
		if (ell.a() >= 255)
		{
			this.y = A_0.GetInt32("CO1:PB");
			this.z = A_0.GetInt32("CO1:PRB");
		}
		if (ell.a() >= 269)
		{
			this.aa = A_0.GetInt32("CO1:TPB");
		}
		if (ell.a() >= 280)
		{
			this.ae = A_0.GetDouble("CO1:TH");
		}
		if (ell.a() >= 358)
		{
			di7.ReadDictionary<string, eax>("CO1:CM", ref this.ah, A_0);
		}
		else
		{
			this.ah = new Dictionary<string, eax>();
		}
		if (ell.a() >= 362)
		{
			this.s = A_0.GetDouble("CO1:Y");
		}
		else
		{
			this.s = 1.0;
		}
		if (ell.a() >= 422)
		{
			this.t = A_0.GetDouble("CO1:Z");
		}
		else
		{
			this.t = 1.0;
		}
		if (ell.a() >= 561)
		{
			this.i = (IBoundVariable<float>)A_0.GetValue("CO1:R", typeof(IBoundVariable<float>));
		}
		else
		{
			this.i = new BoundVariable<float>(0f, 0f);
		}
		if (ell.a() >= 562)
		{
			di7.ReadEvent<ax0>("CO1:PRA", ref this.an, A_0);
		}
		if (ell.a() >= 687)
		{
			this.ai = (A_0.GetValue("CO1:MMP", typeof(string[])) as string[]);
		}
		else if (ell.a() >= 563)
		{
			this.ai = new string[aiy.au];
			string[] array = A_0.GetValue("CO1:MMP", typeof(string[])) as string[];
			Array.Copy(array, this.ai, array.Length);
		}
		else
		{
			this.ai = new string[aiy.au];
		}
		if (ell.a() >= 582)
		{
			di7.ReadDictionary<object, cmn>("CO1:WAM", ref this.ak, A_0);
		}
		else
		{
			this.ak = new Dictionary<object, cmn>();
		}
		if (ell.a() >= 594)
		{
			this.aj = A_0.GetInt32("CO1:PSM");
		}
		if (ell.a() >= 622)
		{
			this.o = A_0.GetDouble("CO1:MWA");
		}
		else
		{
			this.o = 1.0;
		}
		if (ell.a() >= 666)
		{
			this.u = A_0.GetDouble("CO1:1");
			return;
		}
		this.u = 1.0;
	}

	// Token: 0x06009C8C RID: 40076 RVA: 0x003D8B38 File Offset: 0x003D6D38
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("CO1:CW", this.a);
		info.AddValue("CO1:CDB", this.b);
		info.AddValue("CO1:CC", this.c);
		info.AddValue("CO1:CWK", this.d);
		info.AddValue("CO1:TTNS", this.e);
		info.AddValue("CO1:F", this.f);
		di7.WriteDictionary<PsiSchool, bas>("CO1:PO", this.g, info);
		info.AddValue("CO1:P", this.h);
		info.AddValue("CO1:WAS", this.l);
		info.AddValue("CO1:II", this.p);
		info.AddValue("CO1:RTC", this.q);
		info.AddValue("CO1:CWS", this.al);
		info.AddValue("CO1:A", this.m);
		info.AddValue("CO1:NMP", this.j);
		info.AddValue("CO1:TH", this.ae);
		di7.WriteEvent<ax0>("CO1:PA", this.am, info);
		info.AddValue("CO1:X", this.r);
		info.AddValue("CO1:PRM", this.k);
		info.AddValue("CO1:PB", this.y);
		info.AddValue("CO1:PRB", this.z);
		info.AddValue("CO1:PR", this.ab);
		info.AddValue("CO1:B", this.ac);
		info.AddValue("CO1:H", this.ad);
		info.AddValue("CO1:SAB", this.af);
		info.AddValue("CO1:WM", this.n);
		info.AddValue("CO1:I", this.ag);
		info.AddValue("CO1:TPB", this.aa);
		di7.WriteDictionary<string, eax>("CO1:CM", this.ah, info);
		info.AddValue("CO1:Y", this.s);
		info.AddValue("CO1:Z", this.t);
		info.AddValue("CO1:R", this.i);
		di7.WriteEvent<ax0>("CO1:PRA", this.an, info);
		info.AddValue("CO1:MMP", this.ai);
		di7.WriteDictionary<object, cmn>("CO1:WAM", this.ak, info);
		info.AddValue("CO1:PSM", this.aj);
		info.AddValue("CO1:MWA", this.o);
		info.AddValue("CO1:1", this.u);
	}

	// Token: 0x06009C8D RID: 40077 RVA: 0x003D8DC8 File Offset: 0x003D6FC8
	[CompilerGenerated]
	public void b(EventHandler<EventArgs> A_0)
	{
		EventHandler<EventArgs> eventHandler = this.al;
		EventHandler<EventArgs> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<EventArgs> value = (EventHandler<EventArgs>)Delegate.Combine(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs>>(ref this.al, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06009C8E RID: 40078 RVA: 0x003D8E00 File Offset: 0x003D7000
	[CompilerGenerated]
	public void a(EventHandler<EventArgs> A_0)
	{
		EventHandler<EventArgs> eventHandler = this.al;
		EventHandler<EventArgs> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<EventArgs> value = (EventHandler<EventArgs>)Delegate.Remove(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs>>(ref this.al, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06009C8F RID: 40079 RVA: 0x003D8E38 File Offset: 0x003D7038
	[CompilerGenerated]
	public void d(EventHandler<ax0> A_0)
	{
		EventHandler<ax0> eventHandler = this.am;
		EventHandler<ax0> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<ax0> value = (EventHandler<ax0>)Delegate.Combine(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<ax0>>(ref this.am, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06009C90 RID: 40080 RVA: 0x003D8E70 File Offset: 0x003D7070
	[CompilerGenerated]
	public void a(EventHandler<ax0> A_0)
	{
		EventHandler<ax0> eventHandler = this.am;
		EventHandler<ax0> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<ax0> value = (EventHandler<ax0>)Delegate.Remove(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<ax0>>(ref this.am, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06009C91 RID: 40081 RVA: 0x003D8EA8 File Offset: 0x003D70A8
	[CompilerGenerated]
	public void c(EventHandler<ax0> A_0)
	{
		EventHandler<ax0> eventHandler = this.an;
		EventHandler<ax0> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<ax0> value = (EventHandler<ax0>)Delegate.Combine(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<ax0>>(ref this.an, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06009C92 RID: 40082 RVA: 0x003D8EE0 File Offset: 0x003D70E0
	[CompilerGenerated]
	public void b(EventHandler<ax0> A_0)
	{
		EventHandler<ax0> eventHandler = this.an;
		EventHandler<ax0> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<ax0> value = (EventHandler<ax0>)Delegate.Remove(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<ax0>>(ref this.an, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06009C93 RID: 40083 RVA: 0x003D8F18 File Offset: 0x003D7118
	public cd1 u()
	{
		return this.b(this.d);
	}

	// Token: 0x06009C94 RID: 40084 RVA: 0x003D8F28 File Offset: 0x003D7128
	public cd1 q()
	{
		if (this.d == WeaponKey.Primary)
		{
			return this.b(WeaponKey.Secondary);
		}
		return this.b(WeaponKey.Primary);
	}

	// Token: 0x06009C95 RID: 40085 RVA: 0x003D8F44 File Offset: 0x003D7144
	public double a0()
	{
		return this.c;
	}

	// Token: 0x06009C96 RID: 40086 RVA: 0x003D8F4C File Offset: 0x003D714C
	public void c(double A_0)
	{
		this.c = Math.Max(0.0, A_0);
	}

	// Token: 0x06009C97 RID: 40087 RVA: 0x003D8F64 File Offset: 0x003D7164
	public double ar()
	{
		return this.ad;
	}

	// Token: 0x06009C98 RID: 40088 RVA: 0x003D8F6C File Offset: 0x003D716C
	public void h(double A_0)
	{
		this.ad = A_0;
	}

	// Token: 0x06009C99 RID: 40089 RVA: 0x003D8F78 File Offset: 0x003D7178
	public double aw()
	{
		return this.ae;
	}

	// Token: 0x06009C9A RID: 40090 RVA: 0x003D8F80 File Offset: 0x003D7180
	public void j(double A_0)
	{
		this.ae = A_0;
	}

	// Token: 0x06009C9B RID: 40091 RVA: 0x003D8F8C File Offset: 0x003D718C
	public double am()
	{
		return this.b;
	}

	// Token: 0x06009C9C RID: 40092 RVA: 0x003D8F94 File Offset: 0x003D7194
	public void g(double A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06009C9D RID: 40093 RVA: 0x003D8FA0 File Offset: 0x003D71A0
	public WeaponKey au()
	{
		return this.d;
	}

	// Token: 0x06009C9E RID: 40094 RVA: 0x003D8FAC File Offset: 0x003D71AC
	public void a(WeaponKey A_0)
	{
		if (this.d != A_0)
		{
			this.d = A_0;
			base.a1().c(this.u());
			base.a1().c(this.q());
			base.a1().bl();
		}
	}

	// Token: 0x06009C9F RID: 40095 RVA: 0x003D8FFC File Offset: 0x003D71FC
	public bool ap()
	{
		return this.e <= 0.0;
	}

	// Token: 0x06009CA0 RID: 40096 RVA: 0x003D9014 File Offset: 0x003D7214
	public double i()
	{
		return this.e;
	}

	// Token: 0x06009CA1 RID: 40097 RVA: 0x003D901C File Offset: 0x003D721C
	public double l()
	{
		return this.f;
	}

	// Token: 0x06009CA2 RID: 40098 RVA: 0x003D9024 File Offset: 0x003D7224
	public bool af()
	{
		return this.f > 0.95;
	}

	// Token: 0x06009CA3 RID: 40099 RVA: 0x003D9038 File Offset: 0x003D7238
	public Dictionary<PsiSchool, bas> ag()
	{
		if (!this.g.ContainsKey(PsiSchool.TemporalManipulation))
		{
			this.g.Add(PsiSchool.TemporalManipulation, new bas(base.a1(), PsiSchool.TemporalManipulation));
		}
		return this.g;
	}

	// Token: 0x06009CA4 RID: 40100 RVA: 0x003D906C File Offset: 0x003D726C
	public Dictionary<string, eax> @as()
	{
		return this.ah;
	}

	// Token: 0x06009CA5 RID: 40101 RVA: 0x003D9074 File Offset: 0x003D7274
	public IBoundVariable<float> aa()
	{
		return this.h;
	}

	// Token: 0x06009CA6 RID: 40102 RVA: 0x003D907C File Offset: 0x003D727C
	public IBoundVariable<float> ab()
	{
		return this.i;
	}

	// Token: 0x06009CA7 RID: 40103 RVA: 0x003D9084 File Offset: 0x003D7284
	public double ah()
	{
		return this.k;
	}

	// Token: 0x06009CA8 RID: 40104 RVA: 0x003D908C File Offset: 0x003D728C
	public void d(double A_0)
	{
		this.k = Math.Max(0.0, A_0);
	}

	// Token: 0x06009CA9 RID: 40105 RVA: 0x003D90A4 File Offset: 0x003D72A4
	public float ax()
	{
		return this.l;
	}

	// Token: 0x06009CAA RID: 40106 RVA: 0x003D90AC File Offset: 0x003D72AC
	public void a(float A_0)
	{
		if (this.l != A_0)
		{
			this.l = A_0;
			if (this.l < as3.q)
			{
				this.l = as3.q;
			}
		}
	}

	// Token: 0x06009CAB RID: 40107 RVA: 0x003D90DC File Offset: 0x003D72DC
	public int j()
	{
		return this.m;
	}

	// Token: 0x06009CAC RID: 40108 RVA: 0x003D90E4 File Offset: 0x003D72E4
	public void e(int A_0)
	{
		this.m = A_0;
	}

	// Token: 0x06009CAD RID: 40109 RVA: 0x003D90F0 File Offset: 0x003D72F0
	public double ak()
	{
		return this.n;
	}

	// Token: 0x06009CAE RID: 40110 RVA: 0x003D90F8 File Offset: 0x003D72F8
	public void k(double A_0)
	{
		this.n = Math.Max(0.0, A_0);
	}

	// Token: 0x06009CAF RID: 40111 RVA: 0x003D9114 File Offset: 0x003D7314
	public float p()
	{
		if (this.u().TypedDefinition != null)
		{
			return this.u().TypedDefinition.an() * this.l;
		}
		return 0f;
	}

	// Token: 0x06009CB0 RID: 40112 RVA: 0x003D9150 File Offset: 0x003D7350
	private double h()
	{
		double result = 1.0;
		if (base.a1().BaseAbilities.Dexterity > aiy.k)
		{
			euf.d(this.u().TypedDefinition);
			if (euf.a(this.u()))
			{
				result = 1.0 - (double)(base.a1().BaseAbilities.Dexterity - aiy.k) * aiy.l;
			}
		}
		return result;
	}

	// Token: 0x06009CB1 RID: 40113 RVA: 0x003D91CC File Offset: 0x003D73CC
	public int av()
	{
		if (this.u().TypedDefinition != null)
		{
			int val = (int)(((double)this.u().TypedDefinition.v() * Math.Max(0.1, this.h() * this.n) + (double)this.m) * this.o);
			return Math.Max(as3.r, val);
		}
		return 0;
	}

	// Token: 0x06009CB2 RID: 40114 RVA: 0x003D9234 File Offset: 0x003D7434
	public ahx v()
	{
		return this.p;
	}

	// Token: 0x06009CB3 RID: 40115 RVA: 0x003D923C File Offset: 0x003D743C
	public int n()
	{
		return this.w;
	}

	// Token: 0x06009CB4 RID: 40116 RVA: 0x003D9244 File Offset: 0x003D7444
	private void b(int A_0)
	{
		this.w = Math.Min(aiy.n, Math.Max(aiy.m, A_0));
	}

	// Token: 0x06009CB5 RID: 40117 RVA: 0x003D9264 File Offset: 0x003D7464
	public int m()
	{
		return this.x;
	}

	// Token: 0x06009CB6 RID: 40118 RVA: 0x003D926C File Offset: 0x003D746C
	private void a(int A_0)
	{
		this.x = d05.a(aiy.p, A_0, aiy.o);
		this.s();
	}

	// Token: 0x06009CB7 RID: 40119 RVA: 0x003D928C File Offset: 0x003D748C
	public int x()
	{
		return this.j;
	}

	// Token: 0x06009CB8 RID: 40120 RVA: 0x003D9294 File Offset: 0x003D7494
	public void h(int A_0)
	{
		this.j = A_0;
	}

	// Token: 0x06009CB9 RID: 40121 RVA: 0x003D92A0 File Offset: 0x003D74A0
	public double y()
	{
		return this.r;
	}

	// Token: 0x06009CBA RID: 40122 RVA: 0x003D92A8 File Offset: 0x003D74A8
	public void i(double A_0)
	{
		double a_ = 0.0;
		this.r = A_0;
		d05.b(a_, A_0, 2.0);
	}

	// Token: 0x06009CBB RID: 40123 RVA: 0x003D92D8 File Offset: 0x003D74D8
	public double at()
	{
		return this.s;
	}

	// Token: 0x06009CBC RID: 40124 RVA: 0x003D92E4 File Offset: 0x003D74E4
	public void a(double A_0)
	{
		double a_ = 0.0;
		this.s = A_0;
		d05.b(a_, A_0, 2.0);
	}

	// Token: 0x06009CBD RID: 40125 RVA: 0x003D9314 File Offset: 0x003D7514
	public double ad()
	{
		return this.t;
	}

	// Token: 0x06009CBE RID: 40126 RVA: 0x003D9320 File Offset: 0x003D7520
	public void b(double A_0)
	{
		double a_ = 0.0;
		this.t = A_0;
		d05.b(a_, A_0, 2.0);
	}

	// Token: 0x06009CBF RID: 40127 RVA: 0x003D9350 File Offset: 0x003D7550
	public double ac()
	{
		return this.u;
	}

	// Token: 0x06009CC0 RID: 40128 RVA: 0x003D9358 File Offset: 0x003D7558
	public void f(double A_0)
	{
		this.u = A_0;
	}

	// Token: 0x06009CC1 RID: 40129 RVA: 0x003D9364 File Offset: 0x003D7564
	public int w()
	{
		return this.y;
	}

	// Token: 0x06009CC2 RID: 40130 RVA: 0x003D936C File Offset: 0x003D756C
	public void d(int A_0)
	{
		this.y = A_0;
	}

	// Token: 0x06009CC3 RID: 40131 RVA: 0x003D9378 File Offset: 0x003D7578
	public int t()
	{
		return this.aa;
	}

	// Token: 0x06009CC4 RID: 40132 RVA: 0x003D9380 File Offset: 0x003D7580
	public void c(int A_0)
	{
		this.aa = A_0;
	}

	// Token: 0x06009CC5 RID: 40133 RVA: 0x003D938C File Offset: 0x003D758C
	public int aj()
	{
		return this.z;
	}

	// Token: 0x06009CC6 RID: 40134 RVA: 0x003D9394 File Offset: 0x003D7594
	public void i(int A_0)
	{
		this.z = A_0;
	}

	// Token: 0x06009CC7 RID: 40135 RVA: 0x003D93A0 File Offset: 0x003D75A0
	public int ai()
	{
		return this.ab;
	}

	// Token: 0x06009CC8 RID: 40136 RVA: 0x003D93A8 File Offset: 0x003D75A8
	public void j(int A_0)
	{
		this.ab = A_0;
	}

	// Token: 0x06009CC9 RID: 40137 RVA: 0x003D93B4 File Offset: 0x003D75B4
	public int ao()
	{
		return (int)Math.Ceiling((double)this.ab * this.k);
	}

	// Token: 0x06009CCA RID: 40138 RVA: 0x003D93CC File Offset: 0x003D75CC
	public int al()
	{
		return this.ac;
	}

	// Token: 0x06009CCB RID: 40139 RVA: 0x003D93D4 File Offset: 0x003D75D4
	public void g(int A_0)
	{
		this.ac = A_0;
	}

	// Token: 0x06009CCC RID: 40140 RVA: 0x003D93E0 File Offset: 0x003D75E0
	public double an()
	{
		return this.af;
	}

	// Token: 0x06009CCD RID: 40141 RVA: 0x003D93E8 File Offset: 0x003D75E8
	public void e(double A_0)
	{
		this.af = A_0;
	}

	// Token: 0x06009CCE RID: 40142 RVA: 0x003D93F4 File Offset: 0x003D75F4
	public int ay()
	{
		return this.ag;
	}

	// Token: 0x06009CCF RID: 40143 RVA: 0x003D93FC File Offset: 0x003D75FC
	public void f(int A_0)
	{
		this.ag = A_0;
	}

	// Token: 0x06009CD0 RID: 40144 RVA: 0x003D9408 File Offset: 0x003D7608
	public dcu(efk A_0) : base(A_0)
	{
		this.g.Add(PsiSchool.ThoughtControl, new bas(A_0, PsiSchool.ThoughtControl));
		this.g.Add(PsiSchool.Psychokinesis, new bas(A_0, PsiSchool.Psychokinesis));
		this.g.Add(PsiSchool.Metathermics, new bas(A_0, PsiSchool.Metathermics));
		this.g.Add(PsiSchool.TemporalManipulation, new bas(A_0, PsiSchool.TemporalManipulation));
	}

	// Token: 0x06009CD1 RID: 40145 RVA: 0x003D9534 File Offset: 0x003D7734
	public void o()
	{
		this.w = aiy.g;
		this.x = aiy.h + this.j;
		this.l = 1f;
		this.m = 0;
		this.n = 1.0;
		this.o = 1.0;
		this.p.a();
		this.r = 1.0;
		this.s = 1.0;
		this.t = 1.0;
		this.u = 1.0;
		this.k = 1.0;
		this.ab = 0;
		this.aj = 0;
		this.b = 1.0;
		this.ad = 0.0;
		this.ae = 0.0;
		this.af = 0.0;
		this.aa = 0;
		this.ah.Clear();
		this.ak.Clear();
	}

	// Token: 0x06009CD2 RID: 40146 RVA: 0x003D964C File Offset: 0x003D784C
	public void r()
	{
		this.v = new bool?(this.af());
		cd1 cd = this.b(this.d);
		if (cd != this.a)
		{
			bool flag = !this.a(cd, this.a);
			this.a = cd;
			if (flag)
			{
				this.f();
			}
		}
		this.c = this.a.TypedDefinition.ai() + euf.a(base.a1(), this.a.TypedDefinition.e());
		this.b = this.u().TypedDefinition.y();
		this.ag = 5 + base.a1().BaseAbilities.Dexterity + base.a1().BaseAbilities.Agility;
		this.e();
		if (!this.g.ContainsKey(PsiSchool.TemporalManipulation))
		{
			this.g.Add(PsiSchool.TemporalManipulation, new bas(base.a1(), PsiSchool.TemporalManipulation));
		}
		double a_ = c2h.a(base.a1(), this.ai);
		foreach (KeyValuePair<PsiSchool, bas> keyValuePair in this.g)
		{
			keyValuePair.Value.d();
			if (dm9.f)
			{
				keyValuePair.Value.a(a_);
			}
		}
		this.d();
		this.c();
		this.b();
	}

	// Token: 0x06009CD3 RID: 40147 RVA: 0x003D97D4 File Offset: 0x003D79D4
	public void a(double A_0, bool A_1)
	{
		if (A_1)
		{
			this.e = 0.0;
			return;
		}
		if (this.e > 0.0)
		{
			this.e -= A_0;
		}
		if (this.f < 1.0)
		{
			this.f += A_0 * as3.l;
			if (this.f > 1.0)
			{
				this.f = 1.0;
			}
		}
		if ((this.q -= A_0) <= 0.0)
		{
			this.a();
			this.q = (double)as3.e;
		}
		if (this.v == null || this.v.Value != this.af())
		{
			base.a1().bl();
		}
	}

	// Token: 0x06009CD4 RID: 40148 RVA: 0x003D98C8 File Offset: 0x003D7AC8
	public void z()
	{
		this.f = 1.0;
		this.a();
	}

	// Token: 0x06009CD5 RID: 40149 RVA: 0x003D98E4 File Offset: 0x003D7AE4
	public cd1 b(WeaponKey A_0)
	{
		if (base.a1().Gear.j()[A_0].Item != null)
		{
			return base.a1().Gear.j()[A_0].Item;
		}
		return base.a1().DefaultWeapons[A_0];
	}

	// Token: 0x06009CD6 RID: 40150 RVA: 0x003D9940 File Offset: 0x003D7B40
	public void az()
	{
		this.g();
	}

	// Token: 0x06009CD7 RID: 40151 RVA: 0x003D9948 File Offset: 0x003D7B48
	public void ae()
	{
		this.f = 0.0;
	}

	// Token: 0x06009CD8 RID: 40152 RVA: 0x003D995C File Offset: 0x003D7B5C
	public void aq()
	{
		this.f = 1.0;
	}

	// Token: 0x06009CD9 RID: 40153 RVA: 0x003D9970 File Offset: 0x003D7B70
	public float d(int A_0, bool A_1)
	{
		if (A_0 != 0 && base.a1().Feats.Contains<c3v>())
		{
			float num;
			if (A_0 < 0)
			{
				if ((float)Math.Abs(A_0) > this.aa().zo())
				{
					num = -this.aa().zo();
				}
				else
				{
					num = (float)A_0;
				}
			}
			else
			{
				float num2 = (float)Math.Ceiling((double)A_0 * this.k);
				if (num2 > this.aa().zm() - this.aa().zo())
				{
					num = this.aa().zm() - this.aa().zo();
				}
				else
				{
					num = num2;
				}
			}
			IBoundVariable<float> boundVariable = this.aa();
			boundVariable.zp(boundVariable.zo() + num);
			if (num != 0f && A_1 && this.am != null)
			{
				this.am(this, new ax0(num));
			}
			return num;
		}
		return 0f;
	}

	// Token: 0x06009CDA RID: 40154 RVA: 0x003D9A68 File Offset: 0x003D7C68
	public float b(int A_0, bool A_1)
	{
		if (A_0 != 0 && base.a1().Feats.Contains<c3v>())
		{
			float num;
			if (A_0 < 0)
			{
				if ((float)Math.Abs(A_0) > this.ab().zo())
				{
					num = -this.ab().zo();
				}
				else
				{
					num = (float)A_0;
				}
			}
			else if ((float)A_0 > this.ab().zm() - this.ab().zo())
			{
				num = this.ab().zm() - this.ab().zo();
			}
			else
			{
				num = (float)A_0;
			}
			IBoundVariable<float> boundVariable = this.ab();
			boundVariable.zp(boundVariable.zo() + num);
			if (num != 0f && A_1 && this.an != null)
			{
				this.an(this, new ax0(num));
			}
			return num;
		}
		return 0f;
	}

	// Token: 0x06009CDB RID: 40155 RVA: 0x003D9B50 File Offset: 0x003D7D50
	public void s()
	{
		if (base.a1().SpecialStates.g)
		{
			this.x = Math.Min(this.x, e5b.a(base.a1()));
		}
	}

	// Token: 0x06009CDC RID: 40156 RVA: 0x003D9B84 File Offset: 0x003D7D84
	public void k()
	{
		if (this.d == WeaponKey.Primary)
		{
			this.a(WeaponKey.Secondary);
			return;
		}
		this.a(WeaponKey.Primary);
	}

	// Token: 0x06009CDD RID: 40157 RVA: 0x003D9BA4 File Offset: 0x003D7DA4
	public bool a(string A_0)
	{
		bool result = false;
		for (int i = 0; i < this.ai.Length; i++)
		{
			if (this.ai[i] == A_0)
			{
				result = true;
				break;
			}
		}
		return result;
	}

	// Token: 0x06009CDE RID: 40158 RVA: 0x003D9BE8 File Offset: 0x003D7DE8
	public void a(object A_0, cmn A_1)
	{
		if (A_0 != null && A_1 != null)
		{
			cmn a_;
			if (this.ak.TryGetValue(A_0, out a_))
			{
				this.ak[A_0] = cmn.a(a_, A_1);
				return;
			}
			this.ak[A_0] = A_1;
		}
	}

	// Token: 0x06009CDF RID: 40159 RVA: 0x003D9C38 File Offset: 0x003D7E38
	public cmn a(params object[] A_0)
	{
		cmn cmn = new cmn();
		if (A_0 != null && A_0.Length != 0)
		{
			foreach (object obj in A_0)
			{
				cmn a_;
				if (obj != null && this.ak.TryGetValue(obj, out a_))
				{
					cmn.a(a_);
				}
			}
		}
		return cmn;
	}

	// Token: 0x06009CE0 RID: 40160 RVA: 0x003D9C94 File Offset: 0x003D7E94
	private void g()
	{
		this.e = (double)(this.p() * 1000f);
	}

	// Token: 0x06009CE1 RID: 40161 RVA: 0x003D9CAC File Offset: 0x003D7EAC
	private void f()
	{
		this.g();
		if (this.al != null)
		{
			this.al(this, new EventArgs());
		}
	}

	// Token: 0x06009CE2 RID: 40162 RVA: 0x003D9CD4 File Offset: 0x003D7ED4
	private void e()
	{
		bool flag = this.h.zm() == 0f;
		float num = (float)Math.Max(1, aiy.ap + this.w() + this.aa);
		if (num != this.h.zm())
		{
			this.h.zn(num);
			if (flag)
			{
				this.h.zp(this.h.zm());
			}
		}
		float num2 = this.h.zm() * aiy.at;
		if (base.a1().Feats.Contains<eqt>())
		{
			num2 = (float)((1.0 + eqt.a + (double)base.a1().GetSpecializationValue<gd>(true) * gd.a) * (double)num2);
		}
		if (num2 != this.i.zm())
		{
			bool flag2 = this.i.zm() != 0f;
			this.i.zn(num2);
			if (!flag2)
			{
				this.i.zp(this.i.zm());
			}
		}
		int num3 = aiy.aq + (base.a1().BaseAbilities.Intelligence + base.a1().BaseAbilities.Will) / 2;
		if (!(base.a1() is e3q))
		{
			num3 = Math.Max(num3, aiy.ar);
		}
		this.ab += num3 + this.z;
		if (base.a1().Feats.Contains<eqt>())
		{
			this.ab += Convert.ToInt32((double)this.i.zm() * eqt.b);
		}
		for (int i = c2h.b(base.a1()) + this.aj; i < aiy.au; i++)
		{
			this.ai[i] = null;
		}
	}

	// Token: 0x06009CE3 RID: 40163 RVA: 0x003D9EB0 File Offset: 0x003D80B0
	private void d()
	{
		if (base.a1().BaseAbilities.Agility > aiy.i)
		{
			this.a(this.m() + (base.a1().BaseAbilities.Agility - aiy.i) * aiy.j);
		}
		if (base.a1().Feats.Contains<cns>() && (double)euf.f(base.a1()) < cns.a)
		{
			this.a(this.m() + cns.b);
		}
		this.a((int)((double)this.m() * (1.0 - Math.Max(0.0, base.a1().Defense.aj()))));
		this.s();
	}

	// Token: 0x06009CE4 RID: 40164 RVA: 0x003D9F7C File Offset: 0x003D817C
	public void c(int A_0, bool A_1)
	{
		if (A_0 > 0 && A_1)
		{
			this.a(this.m() + (int)((double)A_0 * (1.0 - Math.Max(0.0, base.a1().Defense.aj()))));
			return;
		}
		this.a(this.m() + A_0);
	}

	// Token: 0x06009CE5 RID: 40165 RVA: 0x003D9FE0 File Offset: 0x003D81E0
	private void c()
	{
		if (base.a1().Defense.i() > 0 && base.a1().Defense.i() > base.a1().BaseAbilities.Strength)
		{
			double num = (double)(base.a1().Defense.i() - base.a1().BaseAbilities.Strength) / (double)base.a1().Defense.i();
			this.b((int)((double)this.n() * (1.0 - num)));
		}
		if (base.a1().Feats.Contains<cuk>() && (double)euf.f(base.a1()) < cuk.a)
		{
			this.b(this.n() + cuk.b);
		}
	}

	// Token: 0x06009CE6 RID: 40166 RVA: 0x003DA0B4 File Offset: 0x003D82B4
	public void a(int A_0, bool A_1)
	{
		if (A_0 > 0 && A_1)
		{
			double num = 0.0;
			if (base.a1().Defense.i() > base.a1().BaseAbilities.Strength)
			{
				num = (double)(base.a1().Defense.i() - base.a1().BaseAbilities.Strength) / (double)base.a1().Defense.i();
			}
			this.b(this.n() + (int)((double)A_0 * (1.0 - num)));
			return;
		}
		this.b(this.n() + A_0);
	}

	// Token: 0x06009CE7 RID: 40167 RVA: 0x003DA15C File Offset: 0x003D835C
	private void b()
	{
		int num = aiy.co[base.a1().EncumbranceLevel];
		if (num > 0)
		{
			if (base.a1().Vehicle == null)
			{
				this.a(this.m() - num);
			}
			int num2 = Math.Max(0, num - this.m());
			if (num2 > 0)
			{
				this.b(this.n() - num2);
			}
		}
		if (base.a1().Vehicle == null && base.a1().EncumbranceLevel == db9.d)
		{
			base.a1().SpecialStates.b = true;
		}
	}

	// Token: 0x06009CE8 RID: 40168 RVA: 0x003DA1FC File Offset: 0x003D83FC
	private bool a(cd1 A_0, cd1 A_1)
	{
		return A_0 != null && A_0.TypedDefinition != null && A_0.TypedDefinition.a5() != null && A_1 != null && A_1.TypedDefinition != null && A_1.TypedDefinition.a5() != null && (A_0.TypedDefinition.a5() == A_1.TypedDefinition.a5() && A_0.TypedDefinition.a5().StartsWith("sp:")) && A_1.TypedDefinition.a5().StartsWith("sp:");
	}

	// Token: 0x06009CE9 RID: 40169 RVA: 0x003DA2A0 File Offset: 0x003D84A0
	private void a()
	{
		if (!base.a1().SpecialStates.d)
		{
			int num = this.ab;
			if (num > 0)
			{
				if (dm9.f && base.a1() is e3q)
				{
					num = Math.Min(this.ab, (int)this.i.zo());
				}
				float num2 = this.d(num, false);
				if (dm9.f && base.a1() is e3q && num2 >= 1f)
				{
					IBoundVariable<float> boundVariable = this.i;
					boundVariable.zp(boundVariable.zo() - (float)((int)num2));
					return;
				}
			}
			else if (num < 0)
			{
				float value = this.d(num, false);
				if (Math.Abs(value) < (float)Math.Abs(num))
				{
					int num3 = (int)Math.Min((float)((int)this.i.zo()), (float)Math.Abs(num) - Math.Abs(value));
					if (num3 > 0)
					{
						IBoundVariable<float> boundVariable2 = this.i;
						boundVariable2.zp(boundVariable2.zo() - (float)num3);
					}
				}
			}
		}
	}

	// Token: 0x04003C8F RID: 15503
	private cd1 a;

	// Token: 0x04003C90 RID: 15504
	private double b;

	// Token: 0x04003C91 RID: 15505
	private double c;

	// Token: 0x04003C92 RID: 15506
	private WeaponKey d;

	// Token: 0x04003C93 RID: 15507
	private double e;

	// Token: 0x04003C94 RID: 15508
	private double f;

	// Token: 0x04003C95 RID: 15509
	private Dictionary<PsiSchool, bas> g = new Dictionary<PsiSchool, bas>();

	// Token: 0x04003C96 RID: 15510
	private IBoundVariable<float> h = new BoundVariable<float>(0f, 0f);

	// Token: 0x04003C97 RID: 15511
	private IBoundVariable<float> i = new BoundVariable<float>(0f, 0f);

	// Token: 0x04003C98 RID: 15512
	private int j;

	// Token: 0x04003C99 RID: 15513
	private double k;

	// Token: 0x04003C9A RID: 15514
	private float l;

	// Token: 0x04003C9B RID: 15515
	private int m;

	// Token: 0x04003C9C RID: 15516
	private double n = 1.0;

	// Token: 0x04003C9D RID: 15517
	public double o = 1.0;

	// Token: 0x04003C9E RID: 15518
	private ahx p = new ahx();

	// Token: 0x04003C9F RID: 15519
	private double q = (double)as3.e;

	// Token: 0x04003CA0 RID: 15520
	private double r = 1.0;

	// Token: 0x04003CA1 RID: 15521
	private double s = 1.0;

	// Token: 0x04003CA2 RID: 15522
	private double t = 1.0;

	// Token: 0x04003CA3 RID: 15523
	private double u = 1.0;

	// Token: 0x04003CA4 RID: 15524
	[NonSerialized]
	private bool? v;

	// Token: 0x04003CA5 RID: 15525
	[NonSerialized]
	public int w;

	// Token: 0x04003CA6 RID: 15526
	[NonSerialized]
	public int x;

	// Token: 0x04003CA7 RID: 15527
	private int y;

	// Token: 0x04003CA8 RID: 15528
	private int z;

	// Token: 0x04003CA9 RID: 15529
	private int aa;

	// Token: 0x04003CAA RID: 15530
	private int ab;

	// Token: 0x04003CAB RID: 15531
	private int ac;

	// Token: 0x04003CAC RID: 15532
	private double ad;

	// Token: 0x04003CAD RID: 15533
	private double ae;

	// Token: 0x04003CAE RID: 15534
	private double af;

	// Token: 0x04003CAF RID: 15535
	private int ag;

	// Token: 0x04003CB0 RID: 15536
	private Dictionary<string, eax> ah = new Dictionary<string, eax>();

	// Token: 0x04003CB1 RID: 15537
	public string[] ai = new string[aiy.au];

	// Token: 0x04003CB2 RID: 15538
	public int aj;

	// Token: 0x04003CB3 RID: 15539
	private Dictionary<object, cmn> ak = new Dictionary<object, cmn>();

	// Token: 0x04003CB4 RID: 15540
	[CompilerGenerated]
	private EventHandler<EventArgs> al;

	// Token: 0x04003CB5 RID: 15541
	[CompilerGenerated]
	private EventHandler<ax0> am;

	// Token: 0x04003CB6 RID: 15542
	[CompilerGenerated]
	private EventHandler<ax0> an;
}
