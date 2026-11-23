using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Threading;

// Token: 0x0200194D RID: 6477
[eiz("IC")]
[Serializable]
public sealed class dcw : dbi, ISerializable
{
	// Token: 0x06008A29 RID: 35369 RVA: 0x0038C0D0 File Offset: 0x0038A2D0
	private dcw(SerializationInfo A_0, StreamingContext A_1)
	{
		if (ell.a() != 0)
		{
			di7.ReadList<coh>("IC:I", ref this.a, A_0);
			if (ell.b() < 5)
			{
				this.f = (EventHandler<by0>)A_0.GetValue("IC:IA", typeof(EventHandler<by0>));
				this.g = (EventHandler<by0>)A_0.GetValue("IC:IR", typeof(EventHandler<by0>));
				return;
			}
			di7.ReadEvent<by0>("IC:IA", ref this.f, A_0);
			di7.ReadEvent<by0>("IC:IR", ref this.g, A_0);
			if (ell.b() >= 52)
			{
				this.e = A_0.GetBoolean("IC:IX");
				this.b = (A_0.GetValue("IC:IBC", typeof(Dictionary<string, List<coh>>)) as Dictionary<string, List<coh>>);
				this.c = (A_0.GetValue("IC:IBI", typeof(Dictionary<Guid, List<coh>>)) as Dictionary<Guid, List<coh>>);
				return;
			}
		}
		else
		{
			if (base.GetType() == typeof(dcw))
			{
				this.a = (List<coh>)A_0.GetValue("_Items", typeof(List<coh>));
				this.f = (EventHandler<by0>)A_0.GetValue("ItemAdded", typeof(EventHandler<by0>));
				this.g = (EventHandler<by0>)A_0.GetValue("ItemRemoved", typeof(EventHandler<by0>));
				return;
			}
			this.a = (List<coh>)A_0.GetValue("ItemContainer+_Items", typeof(List<coh>));
			this.f = (EventHandler<by0>)A_0.GetValue("ItemContainer+ItemAdded", typeof(EventHandler<by0>));
			this.g = (EventHandler<by0>)A_0.GetValue("ItemContainer+ItemRemoved", typeof(EventHandler<by0>));
		}
	}

	// Token: 0x06008A2A RID: 35370 RVA: 0x0038C2B0 File Offset: 0x0038A4B0
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		di7.WriteList<coh>("IC:I", this.a, info);
		di7.WriteEvent<by0>("IC:IA", this.f, info);
		di7.WriteEvent<by0>("IC:IR", this.g, info);
		info.AddValue("IC:IX", this.e);
		info.AddValue("IC:IBC", this.b);
		info.AddValue("IC:IBI", this.c);
	}

	// Token: 0x06008A2B RID: 35371 RVA: 0x0038C324 File Offset: 0x0038A524
	public List<coh> z2()
	{
		return this.a;
	}

	// Token: 0x06008A2C RID: 35372 RVA: 0x0038C32C File Offset: 0x0038A52C
	public bool b()
	{
		return this.e;
	}

	// Token: 0x06008A2D RID: 35373 RVA: 0x0038C334 File Offset: 0x0038A534
	public eeg z0()
	{
		return this.d;
	}

	// Token: 0x06008A2E RID: 35374 RVA: 0x0038C33C File Offset: 0x0038A53C
	public void z1(eeg A_0)
	{
		this.d = A_0;
	}

	// Token: 0x06008A2F RID: 35375 RVA: 0x0038C348 File Offset: 0x0038A548
	public dcw()
	{
	}

	// Token: 0x06008A30 RID: 35376 RVA: 0x0038C35C File Offset: 0x0038A55C
	public dcw(bool A_0)
	{
		this.e = A_0;
		if (this.e)
		{
			this.b = new Dictionary<string, List<coh>>();
			this.c = new Dictionary<Guid, List<coh>>();
		}
	}

	// Token: 0x06008A31 RID: 35377 RVA: 0x0038C39C File Offset: 0x0038A59C
	[CompilerGenerated]
	public void zw(EventHandler<by0> A_0)
	{
		EventHandler<by0> eventHandler = this.f;
		EventHandler<by0> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<by0> value = (EventHandler<by0>)Delegate.Combine(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<by0>>(ref this.f, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06008A32 RID: 35378 RVA: 0x0038C3D4 File Offset: 0x0038A5D4
	[CompilerGenerated]
	public void zx(EventHandler<by0> A_0)
	{
		EventHandler<by0> eventHandler = this.f;
		EventHandler<by0> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<by0> value = (EventHandler<by0>)Delegate.Remove(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<by0>>(ref this.f, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06008A33 RID: 35379 RVA: 0x0038C40C File Offset: 0x0038A60C
	[CompilerGenerated]
	public void zy(EventHandler<by0> A_0)
	{
		EventHandler<by0> eventHandler = this.g;
		EventHandler<by0> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<by0> value = (EventHandler<by0>)Delegate.Combine(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<by0>>(ref this.g, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06008A34 RID: 35380 RVA: 0x0038C444 File Offset: 0x0038A644
	[CompilerGenerated]
	public void zz(EventHandler<by0> A_0)
	{
		EventHandler<by0> eventHandler = this.g;
		EventHandler<by0> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<by0> value = (EventHandler<by0>)Delegate.Remove(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<by0>>(ref this.g, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06008A35 RID: 35381 RVA: 0x0038C47C File Offset: 0x0038A67C
	public bool h(coh A_0)
	{
		if (A_0 == null)
		{
			return false;
		}
		if (this.e)
		{
			coh coh = this.a(A_0.Id);
			if (coh == null)
			{
				return false;
			}
			if (coh == A_0)
			{
				return true;
			}
		}
		return this.a.Contains(A_0);
	}

	// Token: 0x06008A36 RID: 35382 RVA: 0x0038C4C8 File Offset: 0x0038A6C8
	public void z3(coh A_0, bool A_1 = true)
	{
		dcw.a a = new dcw.a();
		a.a = A_0;
		if (a.a != null)
		{
			if (A_1 && !string.IsNullOrEmpty(a.a.Definition.a5()) && a.a.Definition.be() > 1)
			{
				coh coh = a.a.fy();
				IEnumerable<coh> enumerable;
				if (this.e)
				{
					List<coh> list;
					this.b.TryGetValue(this.a(a.a), out list);
					enumerable = (list ?? new List<coh>());
				}
				else
				{
					enumerable = Enumerable.Where<coh>(this.a, new Func<coh, bool>(a.a));
				}
				using (IEnumerator<coh> enumerator = enumerable.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						coh coh2 = enumerator.Current;
						int num = Math.Min(coh.Stacks, coh2.Definition.be() - coh2.Stacks);
						if (num > 0)
						{
							coh.Stacks -= num;
							coh2.Stacks += num;
							coh coh3 = coh.fy();
							coh3.Stacks = num;
							this.aaa(coh3);
							if (coh.Stacks == 0)
							{
								break;
							}
						}
					}
					goto IL_1A0;
				}
				IL_151:
				coh coh4 = coh.fy();
				coh4.Stacks = Math.Min(coh.Stacks, Math.Max(1, coh.Definition.be()));
				this.e(coh4);
				this.g(coh4);
				coh.Stacks -= coh4.Stacks;
				IL_1A0:
				if (coh.Stacks <= 0)
				{
					return;
				}
				goto IL_151;
			}
			else
			{
				this.e(a.a);
				this.g(a.a);
			}
		}
	}

	// Token: 0x06008A37 RID: 35383 RVA: 0x0038C6A8 File Offset: 0x0038A8A8
	public void z4(int A_0, coh A_1)
	{
		if (A_1 != null)
		{
			if (A_0 >= 0 && this.a.Count >= A_0)
			{
				this.a(A_0, A_1);
			}
			else
			{
				this.e(A_1);
			}
			this.g(A_1);
		}
	}

	// Token: 0x06008A38 RID: 35384 RVA: 0x0038C6E4 File Offset: 0x0038A8E4
	public bool z5(coh A_0)
	{
		czh.a(A_0, "item");
		bool flag = this.d(A_0);
		if (flag)
		{
			this.f(A_0);
		}
		return flag;
	}

	// Token: 0x06008A39 RID: 35385 RVA: 0x0038C708 File Offset: 0x0038A908
	public bool z6(int A_0)
	{
		if (A_0 >= 0 && A_0 < this.a.Count)
		{
			coh coh = this.a[A_0];
			if (coh != null)
			{
				this.d(coh);
			}
			this.f(coh);
			return true;
		}
		return false;
	}

	// Token: 0x06008A3A RID: 35386 RVA: 0x0038C754 File Offset: 0x0038A954
	public void z7()
	{
		for (int i = this.a.Count - 1; i >= 0; i--)
		{
			this.z6(i);
		}
	}

	// Token: 0x06008A3B RID: 35387 RVA: 0x0038C784 File Offset: 0x0038A984
	public int z8()
	{
		int num = 0;
		if (this.a != null)
		{
			foreach (coh coh in this.a)
			{
				num += coh.ItemValue;
			}
		}
		return num;
	}

	// Token: 0x06008A3C RID: 35388 RVA: 0x0038C7F0 File Offset: 0x0038A9F0
	public int z9(HashSet<string> A_0, float A_1)
	{
		return e7a.a(this.a, A_0, A_1);
	}

	// Token: 0x06008A3D RID: 35389 RVA: 0x0038C800 File Offset: 0x0038AA00
	public void aaa(coh A_0)
	{
		if (A_0 != null)
		{
			if (A_0.Stacks > 0)
			{
				this.g(A_0);
				return;
			}
			if (A_0.Stacks < 0)
			{
				this.f(A_0);
			}
		}
	}

	// Token: 0x06008A3E RID: 35390 RVA: 0x0038C834 File Offset: 0x0038AA34
	public coh a(Guid A_0)
	{
		dcw.c c = new dcw.c();
		c.a = A_0;
		if (!this.e)
		{
			return Enumerable.FirstOrDefault<coh>(Enumerable.Where<coh>(this.a, new Func<coh, bool>(c.a)));
		}
		List<coh> list;
		this.c.TryGetValue(c.a, out list);
		if (list != null)
		{
			return Enumerable.FirstOrDefault<coh>(list);
		}
		return null;
	}

	// Token: 0x06008A3F RID: 35391 RVA: 0x0038C898 File Offset: 0x0038AA98
	public IEnumerable<coh> b(string A_0)
	{
		dcw.b b = new dcw.b();
		b.a = A_0;
		if (!this.e)
		{
			return Enumerable.Where<coh>(this.a, new Func<coh, bool>(b.a));
		}
		List<coh> list;
		this.b.TryGetValue(this.a(b.a), out list);
		if (list != null)
		{
			return list;
		}
		return new List<coh>();
	}

	// Token: 0x06008A40 RID: 35392 RVA: 0x0038C8FC File Offset: 0x0038AAFC
	public void aad()
	{
		e7a.a(ref this.a);
	}

	// Token: 0x06008A41 RID: 35393 RVA: 0x0038C90C File Offset: 0x0038AB0C
	public double a()
	{
		double num = 0.0;
		foreach (coh coh in this.a)
		{
			num += coh.Weight;
		}
		return num;
	}

	// Token: 0x06008A42 RID: 35394 RVA: 0x0038C974 File Offset: 0x0038AB74
	private void g(coh A_0)
	{
		if (this.d != null)
		{
			this.d.aab(this, A_0);
		}
		if (this.f != null)
		{
			this.f(this, new by0(A_0));
		}
	}

	// Token: 0x06008A43 RID: 35395 RVA: 0x0038C9AC File Offset: 0x0038ABAC
	private void f(coh A_0)
	{
		if (this.d != null)
		{
			this.d.aac(this, A_0);
		}
		if (this.g != null)
		{
			this.g(this, new by0(A_0));
		}
	}

	// Token: 0x06008A44 RID: 35396 RVA: 0x0038C9E4 File Offset: 0x0038ABE4
	private void e(coh A_0)
	{
		this.a.Add(A_0);
		if (this.e)
		{
			this.c(A_0);
		}
	}

	// Token: 0x06008A45 RID: 35397 RVA: 0x0038CA04 File Offset: 0x0038AC04
	private void a(int A_0, coh A_1)
	{
		this.a.Insert(A_0, A_1);
		if (this.e)
		{
			this.c(A_1);
		}
	}

	// Token: 0x06008A46 RID: 35398 RVA: 0x0038CA28 File Offset: 0x0038AC28
	private bool d(coh A_0)
	{
		if (this.a.Remove(A_0))
		{
			if (this.e)
			{
				this.b(A_0);
			}
			return true;
		}
		return false;
	}

	// Token: 0x06008A47 RID: 35399 RVA: 0x0038CA54 File Offset: 0x0038AC54
	private void c(coh A_0)
	{
		string key = this.a(A_0);
		List<coh> list;
		this.b.TryGetValue(key, out list);
		if (list == null)
		{
			list = new List<coh>();
			this.b[key] = list;
		}
		list.Add(A_0);
		this.c.TryGetValue(A_0.Id, out list);
		if (list == null)
		{
			list = new List<coh>();
			this.c[A_0.Id] = list;
		}
		list.Add(A_0);
	}

	// Token: 0x06008A48 RID: 35400 RVA: 0x0038CAD4 File Offset: 0x0038ACD4
	private void b(coh A_0)
	{
		string key = this.a(A_0);
		List<coh> list;
		this.b.TryGetValue(key, out list);
		if (list != null)
		{
			list.Remove(A_0);
			if (list.Count == 0)
			{
				this.b.Remove(key);
			}
		}
		this.c.TryGetValue(A_0.Id, out list);
		if (list != null)
		{
			list.Remove(A_0);
			if (list.Count == 0)
			{
				this.c.Remove(A_0.Id);
			}
		}
	}

	// Token: 0x06008A49 RID: 35401 RVA: 0x0038CB60 File Offset: 0x0038AD60
	private string a(string A_0)
	{
		if (string.IsNullOrWhiteSpace(A_0))
		{
			return string.Empty;
		}
		return A_0;
	}

	// Token: 0x06008A4A RID: 35402 RVA: 0x0038CB74 File Offset: 0x0038AD74
	private string a(coh A_0)
	{
		if (string.IsNullOrWhiteSpace(A_0.Definition.a5()))
		{
			return string.Empty;
		}
		return A_0.Definition.a5();
	}

	// Token: 0x040036F8 RID: 14072
	private List<coh> a = new List<coh>();

	// Token: 0x040036F9 RID: 14073
	private Dictionary<string, List<coh>> b;

	// Token: 0x040036FA RID: 14074
	private Dictionary<Guid, List<coh>> c;

	// Token: 0x040036FB RID: 14075
	[NonSerialized]
	private eeg d;

	// Token: 0x040036FC RID: 14076
	private bool e;

	// Token: 0x040036FD RID: 14077
	[CompilerGenerated]
	private EventHandler<by0> f;

	// Token: 0x040036FE RID: 14078
	[CompilerGenerated]
	private EventHandler<by0> g;

	// Token: 0x0200194E RID: 6478
	[CompilerGenerated]
	private sealed class a
	{
		// Token: 0x06008A4C RID: 35404 RVA: 0x0038CBA8 File Offset: 0x0038ADA8
		internal bool a(coh A_0)
		{
			return A_0.Definition.a5() == this.a.Definition.a5();
		}

		// Token: 0x040036FF RID: 14079
		public coh a;
	}

	// Token: 0x0200194F RID: 6479
	[CompilerGenerated]
	private sealed class c
	{
		// Token: 0x06008A4E RID: 35406 RVA: 0x0038CBE0 File Offset: 0x0038ADE0
		internal bool a(coh A_0)
		{
			return A_0.Id == this.a;
		}

		// Token: 0x04003700 RID: 14080
		public Guid a;
	}

	// Token: 0x02001950 RID: 6480
	[CompilerGenerated]
	private sealed class b
	{
		// Token: 0x06008A50 RID: 35408 RVA: 0x0038CBFC File Offset: 0x0038ADFC
		internal bool a(coh A_0)
		{
			return A_0.Definition != null && A_0.Definition.a5() == this.a;
		}

		// Token: 0x04003701 RID: 14081
		public string a;
	}
}
