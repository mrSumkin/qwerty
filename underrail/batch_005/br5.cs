using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Threading;
using TimelapseVertigo.Rules.Effects;

// Token: 0x02001DE5 RID: 7653
[eiz("CSE")]
[Serializable]
public sealed class br5 : ISerializable
{
	// Token: 0x0600A950 RID: 43344 RVA: 0x003F0CA0 File Offset: 0x003EEEA0
	private br5(SerializationInfo A_0, StreamingContext A_1)
	{
		if (ell.a() != 0)
		{
			this.a = (efk)A_0.GetValue("CSE:C", typeof(efk));
			this.b = (ll)A_0.GetValue("CSE:C1", typeof(ll));
			di7.ReadList<els>("CSE:SE", ref this.c, A_0);
			di7.ReadList<els>("CSE:ISE", ref this.d, A_0);
			di7.ReadList<ud>("CSE:VE", ref this.e, A_0);
			if (ell.b() >= 5)
			{
				di7.ReadEvent<dwu>("CSE:SER", ref this.f, A_0);
				di7.ReadEvent<dwu>("CSE:SET", ref this.g, A_0);
				di7.ReadEvent<dwu>("CSE:SEE", ref this.h, A_0);
				di7.ReadEvent<dwu>("CSE:SEA", ref this.i, A_0);
				di7.ReadEvent<dwu>("CSE:SESR", ref this.j, A_0);
				return;
			}
			this.f = (EventHandler<dwu>)A_0.GetValue("CSE:SER", typeof(EventHandler<dwu>));
			this.g = (EventHandler<dwu>)A_0.GetValue("CSE:SET", typeof(EventHandler<dwu>));
			this.h = (EventHandler<dwu>)A_0.GetValue("CSE:SEE", typeof(EventHandler<dwu>));
			this.i = (EventHandler<dwu>)A_0.GetValue("CSE:SEA", typeof(EventHandler<dwu>));
			this.j = (EventHandler<dwu>)A_0.GetValue("CSE:SESR", typeof(EventHandler<dwu>));
			return;
		}
		else
		{
			if (base.GetType() == typeof(br5))
			{
				this.a = (efk)A_0.GetValue("_Character", typeof(efk));
				this.b = (ll)A_0.GetValue("_Context", typeof(ll));
				this.c = (List<els>)A_0.GetValue("_StatusEffects", typeof(List<els>));
				this.d = (List<els>)A_0.GetValue("_IncapacitationStatusEffects", typeof(List<els>));
				this.e = (List<ud>)A_0.GetValue("VisualEffects", typeof(List<ud>));
				this.f = (EventHandler<dwu>)A_0.GetValue("StatusEffectRemoved", typeof(EventHandler<dwu>));
				this.g = (EventHandler<dwu>)A_0.GetValue("StatusEffectTick", typeof(EventHandler<dwu>));
				this.h = (EventHandler<dwu>)A_0.GetValue("StatusEffectExpired", typeof(EventHandler<dwu>));
				try
				{
					this.i = (EventHandler<dwu>)A_0.GetValue("StatusEffectApplied", typeof(EventHandler<dwu>));
				}
				catch
				{
				}
				this.j = (EventHandler<dwu>)A_0.GetValue("StatusEffectSoftRemoved", typeof(EventHandler<dwu>));
				return;
			}
			this.a = (efk)A_0.GetValue("CharacterStatusEffects+_Character", typeof(efk));
			this.b = (ll)A_0.GetValue("CharacterStatusEffects+_Context", typeof(ll));
			this.c = (List<els>)A_0.GetValue("CharacterStatusEffects+_StatusEffects", typeof(List<els>));
			this.d = (List<els>)A_0.GetValue("CharacterStatusEffects+_IncapacitationStatusEffects", typeof(List<els>));
			this.e = (List<ud>)A_0.GetValue("CharacterStatusEffects+VisualEffects", typeof(List<ud>));
			this.f = (EventHandler<dwu>)A_0.GetValue("CharacterStatusEffects+StatusEffectRemoved", typeof(EventHandler<dwu>));
			this.g = (EventHandler<dwu>)A_0.GetValue("CharacterStatusEffects+StatusEffectTick", typeof(EventHandler<dwu>));
			this.h = (EventHandler<dwu>)A_0.GetValue("CharacterStatusEffects+StatusEffectExpired", typeof(EventHandler<dwu>));
			try
			{
				this.i = (EventHandler<dwu>)A_0.GetValue("CharacterStatusEffects+StatusEffectApplied", typeof(EventHandler<dwu>));
			}
			catch
			{
			}
			this.j = (EventHandler<dwu>)A_0.GetValue("CharacterStatusEffects+StatusEffectSoftRemoved", typeof(EventHandler<dwu>));
			return;
		}
	}

	// Token: 0x0600A951 RID: 43345 RVA: 0x003F1120 File Offset: 0x003EF320
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		info.AddValue("CSE:C", this.a);
		info.AddValue("CSE:C1", this.b);
		di7.WriteList<els>("CSE:SE", this.c, info);
		di7.WriteList<els>("CSE:ISE", this.d, info);
		di7.WriteList<ud>("CSE:VE", this.e, info);
		di7.WriteEvent<dwu>("CSE:SER", this.f, info);
		di7.WriteEvent<dwu>("CSE:SET", this.g, info);
		di7.WriteEvent<dwu>("CSE:SEE", this.h, info);
		di7.WriteEvent<dwu>("CSE:SEA", this.i, info);
		di7.WriteEvent<dwu>("CSE:SESR", this.j, info);
	}

	// Token: 0x0600A952 RID: 43346 RVA: 0x003F11D8 File Offset: 0x003EF3D8
	public List<els> d()
	{
		return this.c;
	}

	// Token: 0x0600A953 RID: 43347 RVA: 0x003F11E0 File Offset: 0x003EF3E0
	public ll e()
	{
		return this.b;
	}

	// Token: 0x0600A954 RID: 43348 RVA: 0x003F11EC File Offset: 0x003EF3EC
	[CompilerGenerated]
	public void c(EventHandler<dwu> A_0)
	{
		EventHandler<dwu> eventHandler = this.f;
		EventHandler<dwu> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<dwu> value = (EventHandler<dwu>)Delegate.Combine(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<dwu>>(ref this.f, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x0600A955 RID: 43349 RVA: 0x003F1224 File Offset: 0x003EF424
	[CompilerGenerated]
	public void e(EventHandler<dwu> A_0)
	{
		EventHandler<dwu> eventHandler = this.f;
		EventHandler<dwu> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<dwu> value = (EventHandler<dwu>)Delegate.Remove(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<dwu>>(ref this.f, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x0600A956 RID: 43350 RVA: 0x003F125C File Offset: 0x003EF45C
	[CompilerGenerated]
	public void j(EventHandler<dwu> A_0)
	{
		EventHandler<dwu> eventHandler = this.g;
		EventHandler<dwu> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<dwu> value = (EventHandler<dwu>)Delegate.Combine(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<dwu>>(ref this.g, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x0600A957 RID: 43351 RVA: 0x003F1294 File Offset: 0x003EF494
	[CompilerGenerated]
	public void d(EventHandler<dwu> A_0)
	{
		EventHandler<dwu> eventHandler = this.g;
		EventHandler<dwu> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<dwu> value = (EventHandler<dwu>)Delegate.Remove(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<dwu>>(ref this.g, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x0600A958 RID: 43352 RVA: 0x003F12CC File Offset: 0x003EF4CC
	[CompilerGenerated]
	public void f(EventHandler<dwu> A_0)
	{
		EventHandler<dwu> eventHandler = this.h;
		EventHandler<dwu> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<dwu> value = (EventHandler<dwu>)Delegate.Combine(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<dwu>>(ref this.h, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x0600A959 RID: 43353 RVA: 0x003F1304 File Offset: 0x003EF504
	[CompilerGenerated]
	public void h(EventHandler<dwu> A_0)
	{
		EventHandler<dwu> eventHandler = this.h;
		EventHandler<dwu> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<dwu> value = (EventHandler<dwu>)Delegate.Remove(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<dwu>>(ref this.h, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x0600A95A RID: 43354 RVA: 0x003F133C File Offset: 0x003EF53C
	[CompilerGenerated]
	public void a(EventHandler<dwu> A_0)
	{
		EventHandler<dwu> eventHandler = this.i;
		EventHandler<dwu> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<dwu> value = (EventHandler<dwu>)Delegate.Combine(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<dwu>>(ref this.i, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x0600A95B RID: 43355 RVA: 0x003F1374 File Offset: 0x003EF574
	[CompilerGenerated]
	public void i(EventHandler<dwu> A_0)
	{
		EventHandler<dwu> eventHandler = this.i;
		EventHandler<dwu> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<dwu> value = (EventHandler<dwu>)Delegate.Remove(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<dwu>>(ref this.i, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x0600A95C RID: 43356 RVA: 0x003F13AC File Offset: 0x003EF5AC
	[CompilerGenerated]
	internal void g(EventHandler<dwu> A_0)
	{
		EventHandler<dwu> eventHandler = this.j;
		EventHandler<dwu> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<dwu> value = (EventHandler<dwu>)Delegate.Combine(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<dwu>>(ref this.j, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x0600A95D RID: 43357 RVA: 0x003F13E4 File Offset: 0x003EF5E4
	[CompilerGenerated]
	internal void b(EventHandler<dwu> A_0)
	{
		EventHandler<dwu> eventHandler = this.j;
		EventHandler<dwu> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<dwu> value = (EventHandler<dwu>)Delegate.Remove(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<dwu>>(ref this.j, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x0600A95E RID: 43358 RVA: 0x003F141C File Offset: 0x003EF61C
	public br5(efk A_0)
	{
		czh.a(A_0, "character");
		this.a = A_0;
		this.b = new ll(A_0);
	}

	// Token: 0x0600A95F RID: 43359 RVA: 0x003F1470 File Offset: 0x003EF670
	public ea4 a(els A_0, bool A_1 = false, bool A_2 = false, bool A_3 = false)
	{
		br5.b b = new br5.b();
		b.a = A_0;
		czh.a(b.a, "statusEffect");
		if (!A_2 && this.a.Dead)
		{
			return ea4.d;
		}
		if (b.a.Stacking != axm.a && b.a.Stacking != axm.b)
		{
			this.a(b.a, null, A_3);
			return ea4.a;
		}
		els els;
		if (b.a.Stacking == axm.b)
		{
			els = Enumerable.FirstOrDefault<els>(Enumerable.Where<els>(this.c, new Func<els, bool>(b.a)));
		}
		else
		{
			els = Enumerable.FirstOrDefault<els>(Enumerable.Where<els>(this.c, new Func<els, bool>(b.b)));
		}
		int num = 0;
		if (els != null)
		{
			if (!b.a.Refreshable && !A_1)
			{
				return ea4.d;
			}
			if (els.Power > b.a.Power)
			{
				return ea4.b;
			}
			num = els.Stacks;
			this.c(els);
			if (b.a.Duration != 0 && (els.TimeLeft > (double)b.a.Duration || !b.a.RefreshDuration))
			{
				b.a.Duration = (int)els.TimeLeft;
			}
		}
		if (b.a.MaxStacks > 1)
		{
			b.a.Stacks += num;
		}
		bool flag = false;
		if (b.a.Stacks > b.a.MaxStacks)
		{
			b.a.Stacks = b.a.MaxStacks;
			flag = true;
		}
		this.a(b.a, els, A_3);
		if (flag)
		{
			return ea4.c;
		}
		return ea4.a;
	}

	// Token: 0x0600A960 RID: 43360 RVA: 0x003F1638 File Offset: 0x003EF838
	public List<T> Get<T>() where T : els
	{
		return Enumerable.ToList<T>(Enumerable.OfType<T>(this.c));
	}

	// Token: 0x0600A961 RID: 43361 RVA: 0x003F164C File Offset: 0x003EF84C
	public bool a(string A_0)
	{
		br5.a a = new br5.a();
		a.a = A_0;
		return Enumerable.Any<els>(Enumerable.Where<els>(this.c, new Func<els, bool>(a.a)));
	}

	// Token: 0x0600A962 RID: 43362 RVA: 0x003F1684 File Offset: 0x003EF884
	public void a(double A_0, bool A_1)
	{
		List<els> list = new List<els>();
		for (int i = 0; i < this.c.Count; i++)
		{
			els els = this.c[i];
			els.d(A_0);
			if (!A_1 && (els.Code == amy.a || !this.a.SpecialStates.k))
			{
				if (els.e(A_0) && this.g != null)
				{
					this.g(this.a, new dwu(els, this.b, false));
				}
				list.Add(els);
			}
		}
		foreach (els els2 in list)
		{
			if (els2.State == StatusEffectState.Expired)
			{
				this.a(els2);
			}
		}
	}

	// Token: 0x0600A963 RID: 43363 RVA: 0x003F178C File Offset: 0x003EF98C
	public void b()
	{
		List<els> list = new List<els>();
		for (int i = 0; i < this.c.Count; i++)
		{
			els els = this.c[i];
			if (els.Code == amy.a || !this.a.SpecialStates.k)
			{
				els.o();
				if (this.g != null)
				{
					this.g(this.a, new dwu(els, this.b, false));
				}
				list.Add(els);
			}
		}
		foreach (els els2 in list)
		{
			if (els2.State == StatusEffectState.Expired)
			{
				this.a(els2);
			}
		}
	}

	// Token: 0x0600A964 RID: 43364 RVA: 0x003F187C File Offset: 0x003EFA7C
	public void d(els A_0)
	{
		if (this.c.Contains(A_0))
		{
			this.b(A_0);
		}
	}

	// Token: 0x0600A965 RID: 43365 RVA: 0x003F1898 File Offset: 0x003EFA98
	public void c()
	{
		for (int i = this.c.Count - 1; i >= 0; i--)
		{
			this.d(this.c[i]);
		}
	}

	// Token: 0x0600A966 RID: 43366 RVA: 0x003F18D4 File Offset: 0x003EFAD4
	public void a()
	{
		if (this.d.Count != 0)
		{
			foreach (els a_ in Enumerable.ToList<els>(this.d))
			{
				this.d(a_);
			}
		}
	}

	// Token: 0x0600A967 RID: 43367 RVA: 0x003F1944 File Offset: 0x003EFB44
	private void c(els A_0)
	{
		this.c.Remove(A_0);
		this.d.Remove(A_0);
		this.a.a(A_0.StaticEffects);
		if (A_0.VisualEffects != null)
		{
			foreach (ud item in A_0.VisualEffects)
			{
				this.e.Remove(item);
			}
		}
		if (this.j != null)
		{
			this.j(this.a, new dwu(A_0, this.b, false));
		}
		this.a.bl();
	}

	// Token: 0x0600A968 RID: 43368 RVA: 0x003F1A10 File Offset: 0x003EFC10
	private void b(els A_0)
	{
		this.c(A_0);
		if (this.f != null)
		{
			this.f(this.a, new dwu(A_0, this.b, false));
		}
	}

	// Token: 0x0600A969 RID: 43369 RVA: 0x003F1A44 File Offset: 0x003EFC44
	private void a(els A_0, els A_1, bool A_2 = false)
	{
		A_0.a(this.b, A_1);
		this.c.Add(A_0);
		if (Enumerable.Any<ax2>(Enumerable.OfType<ax2>(A_0.StaticEffects)))
		{
			this.d.Add(A_0);
		}
		if (A_0.VisualEffects != null)
		{
			this.e.AddRange(A_0.VisualEffects);
		}
		this.a.a(A_0.StaticEffects, null, null);
		this.a.bl();
		if (this.i != null)
		{
			this.i(this.a, new dwu(A_0, this.b, A_2));
		}
	}

	// Token: 0x0600A96A RID: 43370 RVA: 0x003F1AF0 File Offset: 0x003EFCF0
	private void a(els A_0)
	{
		this.c(A_0);
		if (this.h != null)
		{
			this.h(this.a, new dwu(A_0, this.b, false));
		}
	}

	// Token: 0x04003F75 RID: 16245
	private efk a;

	// Token: 0x04003F76 RID: 16246
	private ll b;

	// Token: 0x04003F77 RID: 16247
	private List<els> c = new List<els>();

	// Token: 0x04003F78 RID: 16248
	private List<els> d = new List<els>();

	// Token: 0x04003F79 RID: 16249
	public List<ud> e = new List<ud>();

	// Token: 0x04003F7A RID: 16250
	[CompilerGenerated]
	private EventHandler<dwu> f;

	// Token: 0x04003F7B RID: 16251
	[CompilerGenerated]
	private EventHandler<dwu> g;

	// Token: 0x04003F7C RID: 16252
	[CompilerGenerated]
	private EventHandler<dwu> h;

	// Token: 0x04003F7D RID: 16253
	[CompilerGenerated]
	private EventHandler<dwu> i;

	// Token: 0x04003F7E RID: 16254
	[CompilerGenerated]
	private EventHandler<dwu> j;

	// Token: 0x02001DE6 RID: 7654
	[CompilerGenerated]
	private sealed class b
	{
		// Token: 0x0600A96C RID: 43372 RVA: 0x003F1B2C File Offset: 0x003EFD2C
		internal bool a(els A_0)
		{
			return A_0.Code == this.a.Code;
		}

		// Token: 0x0600A96D RID: 43373 RVA: 0x003F1B44 File Offset: 0x003EFD44
		internal bool b(els A_0)
		{
			return A_0.Code == this.a.Code && A_0.Origin == this.a.Origin;
		}

		// Token: 0x04003F7F RID: 16255
		public els a;
	}

	// Token: 0x02001DE7 RID: 7655
	[CompilerGenerated]
	private sealed class a
	{
		// Token: 0x0600A96F RID: 43375 RVA: 0x003F1B84 File Offset: 0x003EFD84
		internal bool a(els A_0)
		{
			return A_0.Code == this.a;
		}

		// Token: 0x04003F80 RID: 16256
		public string a;
	}
}
