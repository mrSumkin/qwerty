using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Threading;
using TimelapseVertigo.Rules.Characters;

// Token: 0x0200067D RID: 1661
[eiz("PC1")]
[Serializable]
public class e3q : efk, ISerializable
{
	// Token: 0x06002A54 RID: 10836 RVA: 0x000EE6BC File Offset: 0x000EC8BC
	protected e3q(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetInt32("PC1:E");
		this.c = A_0.GetInt32("PC1:BAPC");
		this.d = A_0.GetInt32("PC1:SPC");
		this.e = A_0.GetInt32("PC1:FC");
		this.g = (SortedList<string, bdc>)A_0.GetValue("PC1:B", typeof(SortedList<string, bdc>));
		if (ell.b() >= 5)
		{
			di7.ReadEvent<c1>("PC1:BAPCC", ref this.i, A_0);
			di7.ReadEvent<c1>("PC1:SPCC", ref this.j, A_0);
			di7.ReadEvent<c1>("PC1:FCC", ref this.k, A_0);
		}
		else
		{
			this.i = (EventHandler<c1>)A_0.GetValue("PC1:BAPCC", typeof(EventHandler<c1>));
			this.j = (EventHandler<c1>)A_0.GetValue("PC1:SPCC", typeof(EventHandler<c1>));
			this.k = (EventHandler<c1>)A_0.GetValue("PC1:FCC", typeof(EventHandler<c1>));
		}
		if (ell.a() >= 194)
		{
			this.b = (ExperienceSystem)A_0.GetValue("PC1:ES", typeof(ExperienceSystem));
			di7.ReadDictionary<string, int>("PC1:O", ref this.h, A_0);
		}
		else
		{
			this.b = ExperienceSystem.Classic;
			this.h = new Dictionary<string, int>();
		}
		if (ell.a() >= 391)
		{
			this.f = A_0.GetInt32("PC1:SP");
			this.l = (EventHandler<c1>)A_0.GetValue("PC1:SCPC", typeof(EventHandler<c1>));
		}
	}

	// Token: 0x06002A55 RID: 10837 RVA: 0x000EE88C File Offset: 0x000ECA8C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("PC1:E", this.a);
		info.AddValue("PC1:BAPC", this.c);
		info.AddValue("PC1:SPC", this.d);
		info.AddValue("PC1:FC", this.e);
		info.AddValue("PC1:B", this.g);
		di7.WriteEvent<c1>("PC1:BAPCC", this.i, info);
		di7.WriteEvent<c1>("PC1:SPCC", this.j, info);
		di7.WriteEvent<c1>("PC1:FCC", this.k, info);
		info.AddValue("PC1:ES", this.b);
		di7.WriteDictionary<string, int>("PC1:O", this.h, info);
		info.AddValue("PC1:SP", this.f);
		info.AddValue("PC1:SCPC", this.l);
	}

	// Token: 0x06002A56 RID: 10838 RVA: 0x000EE974 File Offset: 0x000ECB74
	public int i()
	{
		return this.a;
	}

	// Token: 0x06002A57 RID: 10839 RVA: 0x000EE97C File Offset: 0x000ECB7C
	public void e(int A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06002A58 RID: 10840 RVA: 0x000EE988 File Offset: 0x000ECB88
	public ExperienceSystem e()
	{
		return this.b;
	}

	// Token: 0x06002A59 RID: 10841 RVA: 0x000EE990 File Offset: 0x000ECB90
	public void a(ExperienceSystem A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06002A5A RID: 10842 RVA: 0x000EE99C File Offset: 0x000ECB9C
	public int g()
	{
		return this.c;
	}

	// Token: 0x06002A5B RID: 10843 RVA: 0x000EE9A4 File Offset: 0x000ECBA4
	public void b(int A_0)
	{
		int num = this.c;
		this.c = A_0;
		if (num != A_0 && this.i != null)
		{
			this.i(this, new c1(num, A_0));
		}
	}

	// Token: 0x06002A5C RID: 10844 RVA: 0x000EE9F0 File Offset: 0x000ECBF0
	public int h()
	{
		return this.d;
	}

	// Token: 0x06002A5D RID: 10845 RVA: 0x000EE9FC File Offset: 0x000ECBFC
	public void d(int A_0)
	{
		int num = this.d;
		this.d = A_0;
		if (num != A_0 && this.j != null)
		{
			this.j(this, new c1(num, A_0));
		}
	}

	// Token: 0x06002A5E RID: 10846 RVA: 0x000EEA48 File Offset: 0x000ECC48
	public int f()
	{
		return this.f;
	}

	// Token: 0x06002A5F RID: 10847 RVA: 0x000EEA54 File Offset: 0x000ECC54
	public void a(int A_0)
	{
		int num = this.f;
		this.f = A_0;
		if (num != A_0 && this.l != null)
		{
			this.l(this, new c1(num, A_0));
		}
	}

	// Token: 0x06002A60 RID: 10848 RVA: 0x000EEAA0 File Offset: 0x000ECCA0
	public int j()
	{
		return this.e;
	}

	// Token: 0x06002A61 RID: 10849 RVA: 0x000EEAAC File Offset: 0x000ECCAC
	public void f(int A_0)
	{
		if (A_0 != this.e)
		{
			object a_ = this.e;
			this.e = A_0;
			if (this.k != null)
			{
				this.k(this, new c1(a_, A_0));
			}
		}
	}

	// Token: 0x06002A62 RID: 10850 RVA: 0x000EEAFC File Offset: 0x000ECCFC
	public IList<bdc> d()
	{
		return this.g.Values;
	}

	// Token: 0x06002A63 RID: 10851 RVA: 0x000EEB0C File Offset: 0x000ECD0C
	public e3q()
	{
	}

	// Token: 0x06002A64 RID: 10852 RVA: 0x000EEB34 File Offset: 0x000ECD34
	[CompilerGenerated]
	public void d(EventHandler<c1> A_0)
	{
		EventHandler<c1> eventHandler = this.i;
		EventHandler<c1> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<c1> value = (EventHandler<c1>)Delegate.Combine(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<c1>>(ref this.i, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06002A65 RID: 10853 RVA: 0x000EEB6C File Offset: 0x000ECD6C
	[CompilerGenerated]
	public void a(EventHandler<c1> A_0)
	{
		EventHandler<c1> eventHandler = this.i;
		EventHandler<c1> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<c1> value = (EventHandler<c1>)Delegate.Remove(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<c1>>(ref this.i, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06002A66 RID: 10854 RVA: 0x000EEBA4 File Offset: 0x000ECDA4
	[CompilerGenerated]
	public void b(EventHandler<c1> A_0)
	{
		EventHandler<c1> eventHandler = this.j;
		EventHandler<c1> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<c1> value = (EventHandler<c1>)Delegate.Combine(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<c1>>(ref this.j, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06002A67 RID: 10855 RVA: 0x000EEBDC File Offset: 0x000ECDDC
	[CompilerGenerated]
	public void c(EventHandler<c1> A_0)
	{
		EventHandler<c1> eventHandler = this.j;
		EventHandler<c1> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<c1> value = (EventHandler<c1>)Delegate.Remove(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<c1>>(ref this.j, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06002A68 RID: 10856 RVA: 0x000EEC14 File Offset: 0x000ECE14
	[CompilerGenerated]
	public void f(EventHandler<c1> A_0)
	{
		EventHandler<c1> eventHandler = this.k;
		EventHandler<c1> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<c1> value = (EventHandler<c1>)Delegate.Combine(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<c1>>(ref this.k, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06002A69 RID: 10857 RVA: 0x000EEC4C File Offset: 0x000ECE4C
	[CompilerGenerated]
	public void e(EventHandler<c1> A_0)
	{
		EventHandler<c1> eventHandler = this.k;
		EventHandler<c1> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<c1> value = (EventHandler<c1>)Delegate.Remove(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<c1>>(ref this.k, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06002A6A RID: 10858 RVA: 0x000EEC84 File Offset: 0x000ECE84
	[CompilerGenerated]
	public void g(EventHandler<c1> A_0)
	{
		EventHandler<c1> eventHandler = this.l;
		EventHandler<c1> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<c1> value = (EventHandler<c1>)Delegate.Combine(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<c1>>(ref this.l, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06002A6B RID: 10859 RVA: 0x000EECBC File Offset: 0x000ECEBC
	[CompilerGenerated]
	public void h(EventHandler<c1> A_0)
	{
		EventHandler<c1> eventHandler = this.l;
		EventHandler<c1> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<c1> value = (EventHandler<c1>)Delegate.Remove(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<c1>>(ref this.l, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06002A6C RID: 10860 RVA: 0x000EECF4 File Offset: 0x000ECEF4
	[CompilerGenerated]
	public void c(EventHandler A_0)
	{
		EventHandler eventHandler = this.m;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Combine(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.m, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06002A6D RID: 10861 RVA: 0x000EED2C File Offset: 0x000ECF2C
	[CompilerGenerated]
	public void b(EventHandler A_0)
	{
		EventHandler eventHandler = this.m;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Remove(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.m, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06002A6E RID: 10862 RVA: 0x000EED64 File Offset: 0x000ECF64
	[CompilerGenerated]
	public void d(EventHandler A_0)
	{
		EventHandler eventHandler = this.n;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Combine(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.n, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06002A6F RID: 10863 RVA: 0x000EED9C File Offset: 0x000ECF9C
	[CompilerGenerated]
	public void a(EventHandler A_0)
	{
		EventHandler eventHandler = this.n;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Remove(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.n, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06002A70 RID: 10864 RVA: 0x000EEDD4 File Offset: 0x000ECFD4
	public int c(int A_0)
	{
		if (this.b == ExperienceSystem.Classic)
		{
			float num = c2h.a(base.BaseAbilities.Get<av8>().f());
			A_0 = Convert.ToInt32((float)A_0 * num);
		}
		this.a += A_0;
		return A_0;
	}

	// Token: 0x06002A71 RID: 10865 RVA: 0x000EEE1C File Offset: 0x000ED01C
	public dnj k()
	{
		dnj dnj = new dnj();
		dnj.a(base.BaseAbilities.c());
		dnj.a(base.Skills.b());
		dnj.a(base.Feats.c());
		dnj.a(this.a(base.Specializations));
		dnj.a(base.Level);
		dnj.b(this.i());
		int num = base.Level + 1;
		base.Level = num;
		if (num == 1)
		{
			this.b();
			return dnj;
		}
		this.a();
		return dnj;
	}

	// Token: 0x06002A72 RID: 10866 RVA: 0x000EEEB0 File Offset: 0x000ED0B0
	public void b(Type A_0)
	{
		bdc bdc = new bdc(A_0);
		if (bdc.ao() != null && bdc.ao().Name != null && !this.g.ContainsKey(bdc.ao().Name))
		{
			this.g.Add(bdc.ao().Name, bdc);
			if (this.m != null)
			{
				this.m(bdc, new EventArgs());
			}
		}
	}

	// Token: 0x06002A73 RID: 10867 RVA: 0x000EEF30 File Offset: 0x000ED130
	public void a(Type A_0)
	{
		bdc bdc = new bdc(A_0);
		if (bdc.ao() != null && bdc.ao().Name != null && this.g.ContainsKey(bdc.ao().Name) && this.g.Remove(bdc.ao().Name) && this.n != null)
		{
			this.n(bdc, new EventArgs());
		}
	}

	// Token: 0x06002A74 RID: 10868 RVA: 0x000EEFB4 File Offset: 0x000ED1B4
	public void a(dnj A_0)
	{
		if (A_0 != null)
		{
			this.b(0);
			this.d(0);
			this.f(0);
			this.a(0);
			base.Level = A_0.e();
			this.e(A_0.c());
			foreach (to to in A_0.d())
			{
				base.BaseAbilities.b(to.Name).a(to.f());
			}
			foreach (csn csn in A_0.b())
			{
				base.Skills.b(csn.Name).a(csn.f());
			}
			List<ai8> list = new List<ai8>();
			foreach (ai8 ai in base.Feats)
			{
				if (!A_0.a().a(ai))
				{
					list.Add(ai);
				}
			}
			foreach (ai8 ai2 in list)
			{
				base.Feats.b(ai2.GetType());
			}
			foreach (to to2 in A_0.d())
			{
				base.BaseAbilities.b(to2.Name).a(to2.f());
			}
			Dictionary<string, f> dictionary = this.a(A_0.f());
			base.Specializations.Clear();
			foreach (KeyValuePair<string, f> keyValuePair in dictionary)
			{
				base.Specializations[keyValuePair.Key] = keyValuePair.Value;
			}
		}
		base.bl();
	}

	// Token: 0x06002A75 RID: 10869 RVA: 0x000EF23C File Offset: 0x000ED43C
	public int a(string A_0)
	{
		int result;
		this.h.TryGetValue(A_0, out result);
		return result;
	}

	// Token: 0x06002A76 RID: 10870 RVA: 0x000EF25C File Offset: 0x000ED45C
	public int b(string A_0)
	{
		int num;
		this.h.TryGetValue(A_0, out num);
		num = (this.h[A_0] = num + 1);
		return num;
	}

	// Token: 0x06002A77 RID: 10871 RVA: 0x000EF28C File Offset: 0x000ED48C
	private void b()
	{
		this.c += aiy.t;
		this.d += aiy.ak * aiy.ai;
		this.e += aiy.al;
	}

	// Token: 0x06002A78 RID: 10872 RVA: 0x000EF2CC File Offset: 0x000ED4CC
	private void a()
	{
		if (base.Level < aiy.bk && base.Level % aiy.u == 0)
		{
			this.c++;
		}
		this.d += aiy.ai;
		if (base.Feats.Contains<eij>())
		{
			this.d += aiy.aj;
		}
		if (base.Level % aiy.am == 0)
		{
			this.e++;
		}
		if (dk2.f() && base.Level > aiy.an)
		{
			int num = 0;
			foreach (KeyValuePair<string, f> keyValuePair in base.Specializations)
			{
				apq apq = ac8.a(keyValuePair.Key);
				if (apq != null && keyValuePair.Value.Value > apq.e6())
				{
					num += keyValuePair.Value.Value - apq.e6();
					keyValuePair.Value.Value = apq.e6();
				}
			}
			if (Enumerable.Sum<KeyValuePair<string, f>>(base.Specializations, new Func<KeyValuePair<string, f>, int>(e3q.a.a.a)) == 0)
			{
				int num2 = (base.Level - aiy.an) * aiy.ao;
				int num3 = Enumerable.Sum<f>(base.Specializations.Values, new Func<f, int>(e3q.a.a.a));
				int val = num2 - num3 + num;
				this.f = Math.Max(0, val);
			}
			else if (base.Level > aiy.an)
			{
				this.f = 1;
			}
			if (base.Feats.Contains<a0v>())
			{
				this.f++;
			}
		}
		this.a -= c2h.a(base.Level, this.b, base.BaseAbilities.Get<av8>().f());
	}

	// Token: 0x06002A79 RID: 10873 RVA: 0x000EF504 File Offset: 0x000ED704
	private Dictionary<string, f> a(Dictionary<string, f> A_0)
	{
		Dictionary<string, f> dictionary = new Dictionary<string, f>();
		foreach (KeyValuePair<string, f> keyValuePair in A_0)
		{
			dictionary[keyValuePair.Key] = keyValuePair.Value.a();
		}
		return dictionary;
	}

	// Token: 0x04001703 RID: 5891
	private new int a;

	// Token: 0x04001704 RID: 5892
	private new ExperienceSystem b = ExperienceSystem.Oddity;

	// Token: 0x04001705 RID: 5893
	private new int c;

	// Token: 0x04001706 RID: 5894
	private new int d;

	// Token: 0x04001707 RID: 5895
	private int e;

	// Token: 0x04001708 RID: 5896
	private new int f;

	// Token: 0x04001709 RID: 5897
	private SortedList<string, bdc> g = new SortedList<string, bdc>();

	// Token: 0x0400170A RID: 5898
	private Dictionary<string, int> h = new Dictionary<string, int>();

	// Token: 0x0400170B RID: 5899
	[CompilerGenerated]
	private new EventHandler<c1> i;

	// Token: 0x0400170C RID: 5900
	[CompilerGenerated]
	private new EventHandler<c1> j;

	// Token: 0x0400170D RID: 5901
	[CompilerGenerated]
	private EventHandler<c1> k;

	// Token: 0x0400170E RID: 5902
	[CompilerGenerated]
	private EventHandler<c1> l;

	// Token: 0x0400170F RID: 5903
	[CompilerGenerated]
	[NonSerialized]
	private EventHandler m;

	// Token: 0x04001710 RID: 5904
	[CompilerGenerated]
	[NonSerialized]
	private EventHandler n;

	// Token: 0x02001E2C RID: 7724
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x0600AB2B RID: 43819 RVA: 0x003F5D8C File Offset: 0x003F3F8C
		internal int a(KeyValuePair<string, f> A_0)
		{
			return A_0.Value.Value;
		}

		// Token: 0x0600AB2C RID: 43820 RVA: 0x003F5D9C File Offset: 0x003F3F9C
		internal int a(f A_0)
		{
			return A_0.Value;
		}

		// Token: 0x04003FE7 RID: 16359
		public static readonly e3q.a a = new e3q.a();

		// Token: 0x04003FE8 RID: 16360
		public static Func<KeyValuePair<string, f>, int> b;

		// Token: 0x04003FE9 RID: 16361
		public static Func<f, int> c;
	}
}
