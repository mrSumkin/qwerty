using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Threading;

// Token: 0x02001E1F RID: 7711
[eiz("F")]
[Serializable]
public class an2 : xx, IEnumerable<ai8>, ISerializable
{
	// Token: 0x0600AAD2 RID: 43730 RVA: 0x003F4C98 File Offset: 0x003F2E98
	protected an2(SerializationInfo A_0, StreamingContext A_1)
	{
		if (ell.a() != 0)
		{
			this.a = (efk)A_0.GetValue("F:C", typeof(efk));
			di7.ReadList<ctu>("F:F", ref this.b, A_0);
			if (ell.b() >= 5)
			{
				di7.ReadEvent<EventArgs>("F:FA", ref this.c, A_0);
				di7.ReadEvent<EventArgs>("F:FR", ref this.d, A_0);
				return;
			}
			this.c = (EventHandler<EventArgs>)A_0.GetValue("F:FA", typeof(EventHandler<EventArgs>));
			this.d = (EventHandler<EventArgs>)A_0.GetValue("F:FR", typeof(EventHandler<EventArgs>));
			return;
		}
		else
		{
			if (base.GetType() == typeof(an2))
			{
				this.a = (efk)A_0.GetValue("_Character", typeof(efk));
				this.b = (List<ctu>)A_0.GetValue("_Feats", typeof(List<ctu>));
				this.c = (EventHandler<EventArgs>)A_0.GetValue("FeatAdded", typeof(EventHandler<EventArgs>));
				this.d = (EventHandler<EventArgs>)A_0.GetValue("FeatRemoved", typeof(EventHandler<EventArgs>));
				return;
			}
			this.a = (efk)A_0.GetValue("Feats+_Character", typeof(efk));
			this.b = (List<ctu>)A_0.GetValue("Feats+_Feats", typeof(List<ctu>));
			this.c = (EventHandler<EventArgs>)A_0.GetValue("Feats+FeatAdded", typeof(EventHandler<EventArgs>));
			this.d = (EventHandler<EventArgs>)A_0.GetValue("Feats+FeatRemoved", typeof(EventHandler<EventArgs>));
			return;
		}
	}

	// Token: 0x0600AAD3 RID: 43731 RVA: 0x003F4E7C File Offset: 0x003F307C
	public virtual void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		info.AddValue("F:C", this.a);
		di7.WriteList<ctu>("F:F", this.b, info);
		di7.WriteEvent<EventArgs>("F:FA", this.c, info);
		di7.WriteEvent<EventArgs>("F:FR", this.d, info);
	}

	// Token: 0x0600AAD4 RID: 43732 RVA: 0x003F4ED0 File Offset: 0x003F30D0
	public efk re()
	{
		return this.a;
	}

	// Token: 0x0600AAD5 RID: 43733 RVA: 0x003F4ED8 File Offset: 0x003F30D8
	protected List<ctu> b()
	{
		return this.b;
	}

	// Token: 0x0600AAD6 RID: 43734 RVA: 0x003F4EE0 File Offset: 0x003F30E0
	public an2()
	{
	}

	// Token: 0x0600AAD7 RID: 43735 RVA: 0x003F4EF4 File Offset: 0x003F30F4
	public an2(efk A_0) : this()
	{
		this.a = A_0;
	}

	// Token: 0x0600AAD8 RID: 43736 RVA: 0x003F4F04 File Offset: 0x003F3104
	[CompilerGenerated]
	public void b(EventHandler<EventArgs> A_0)
	{
		EventHandler<EventArgs> eventHandler = this.c;
		EventHandler<EventArgs> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<EventArgs> value = (EventHandler<EventArgs>)Delegate.Combine(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs>>(ref this.c, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x0600AAD9 RID: 43737 RVA: 0x003F4F3C File Offset: 0x003F313C
	[CompilerGenerated]
	public void c(EventHandler<EventArgs> A_0)
	{
		EventHandler<EventArgs> eventHandler = this.c;
		EventHandler<EventArgs> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<EventArgs> value = (EventHandler<EventArgs>)Delegate.Remove(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs>>(ref this.c, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x0600AADA RID: 43738 RVA: 0x003F4F74 File Offset: 0x003F3174
	[CompilerGenerated]
	public void a(EventHandler<EventArgs> A_0)
	{
		EventHandler<EventArgs> eventHandler = this.d;
		EventHandler<EventArgs> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<EventArgs> value = (EventHandler<EventArgs>)Delegate.Combine(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs>>(ref this.d, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x0600AADB RID: 43739 RVA: 0x003F4FAC File Offset: 0x003F31AC
	[CompilerGenerated]
	public void d(EventHandler<EventArgs> A_0)
	{
		EventHandler<EventArgs> eventHandler = this.d;
		EventHandler<EventArgs> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<EventArgs> value = (EventHandler<EventArgs>)Delegate.Remove(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs>>(ref this.d, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x0600AADC RID: 43740 RVA: 0x003F4FE4 File Offset: 0x003F31E4
	public bool a(ai8 A_0)
	{
		an2.b b = new an2.b();
		b.a = A_0;
		czh.a(b.a, "feat");
		return Enumerable.Any<ctu>(this.b, new Func<ctu, bool>(b.a));
	}

	// Token: 0x0600AADD RID: 43741 RVA: 0x003F5028 File Offset: 0x003F3228
	public bool Contains<T>() where T : ai8
	{
		return Enumerable.Any<ctu>(this.b, new Func<ctu, bool>(an2.<>c__17<T>.a.a));
	}

	// Token: 0x0600AADE RID: 43742 RVA: 0x003F5058 File Offset: 0x003F3258
	public bool c(Type A_0)
	{
		an2.c c = new an2.c();
		c.a = A_0;
		czh.a(c.a, "featType");
		return Enumerable.Any<ctu>(this.b, new Func<ctu, bool>(c.a));
	}

	// Token: 0x0600AADF RID: 43743 RVA: 0x003F509C File Offset: 0x003F329C
	public bool d(Type A_0)
	{
		czh.a(A_0, "featType");
		ai8 ai = ck.b(A_0);
		if (ai != null && !this.c(A_0))
		{
			this.b.Add(ai.e());
			ai.ar(this.re());
			if (this.c != null)
			{
				this.c(ai, new EventArgs());
			}
			return true;
		}
		return false;
	}

	// Token: 0x0600AAE0 RID: 43744 RVA: 0x003F510C File Offset: 0x003F330C
	public bool b(Type A_0)
	{
		czh.a(A_0, "featType");
		ctu ctu = this.a(A_0);
		bool flag = this.b.Remove(ctu);
		if (flag)
		{
			ctu.ao().@as(this.re());
			if (this.d != null)
			{
				this.d(ctu.ao(), new EventArgs());
			}
		}
		return flag;
	}

	// Token: 0x0600AAE1 RID: 43745 RVA: 0x003F5170 File Offset: 0x003F3370
	public an2 c()
	{
		return (an2)this.a();
	}

	// Token: 0x0600AAE2 RID: 43746 RVA: 0x003F5180 File Offset: 0x003F3380
	public object a()
	{
		an2 an = new an2(this.re());
		foreach (ai8 ai in this)
		{
			an.b().Add(ai.e());
		}
		return an;
	}

	// Token: 0x0600AAE3 RID: 43747 RVA: 0x003F51E8 File Offset: 0x003F33E8
	private ctu a(Type A_0)
	{
		an2.a a = new an2.a();
		a.a = A_0;
		return Enumerable.FirstOrDefault<ctu>(Enumerable.Where<ctu>(this.b, new Func<ctu, bool>(a.a)));
	}

	// Token: 0x0600AAE4 RID: 43748 RVA: 0x003F5220 File Offset: 0x003F3420
	public IEnumerator<ai8> GetEnumerator()
	{
		return Enumerable.Select<ctu, ai8>(Enumerable.Where<ctu>(this.b, new Func<ctu, bool>(an2.d.a.b)), new Func<ctu, ai8>(an2.d.a.a)).GetEnumerator();
	}

	// Token: 0x0600AAE5 RID: 43749 RVA: 0x003F5288 File Offset: 0x003F3488
	IEnumerator IEnumerable.d()
	{
		return this.b.GetEnumerator();
	}

	// Token: 0x04003FCE RID: 16334
	private efk a;

	// Token: 0x04003FCF RID: 16335
	private List<ctu> b = new List<ctu>();

	// Token: 0x04003FD0 RID: 16336
	[CompilerGenerated]
	private EventHandler<EventArgs> c;

	// Token: 0x04003FD1 RID: 16337
	[CompilerGenerated]
	private EventHandler<EventArgs> d;

	// Token: 0x02001E20 RID: 7712
	[CompilerGenerated]
	[Serializable]
	private sealed class d
	{
		// Token: 0x0600AAE8 RID: 43752 RVA: 0x003F52B0 File Offset: 0x003F34B0
		internal bool b(ctu A_0)
		{
			return A_0.ao() != null;
		}

		// Token: 0x0600AAE9 RID: 43753 RVA: 0x003F52BC File Offset: 0x003F34BC
		internal ai8 a(ctu A_0)
		{
			return A_0.ao();
		}

		// Token: 0x04003FD2 RID: 16338
		public static readonly an2.d a = new an2.d();

		// Token: 0x04003FD3 RID: 16339
		public static Func<ctu, bool> b;

		// Token: 0x04003FD4 RID: 16340
		public static Func<ctu, ai8> c;
	}

	// Token: 0x02001E22 RID: 7714
	[CompilerGenerated]
	private sealed class b
	{
		// Token: 0x0600AAEE RID: 43758 RVA: 0x003F530C File Offset: 0x003F350C
		internal bool a(ctu A_0)
		{
			return A_0.ao() != null && A_0.ao() == this.a;
		}

		// Token: 0x04003FD7 RID: 16343
		public ai8 a;
	}

	// Token: 0x02001E23 RID: 7715
	[CompilerGenerated]
	private sealed class c
	{
		// Token: 0x0600AAF0 RID: 43760 RVA: 0x003F5334 File Offset: 0x003F3534
		internal bool a(ctu A_0)
		{
			return A_0.ao() != null && A_0.ao().GetType() == this.a;
		}

		// Token: 0x04003FD8 RID: 16344
		public Type a;
	}

	// Token: 0x02001E24 RID: 7716
	[CompilerGenerated]
	private sealed class a
	{
		// Token: 0x0600AAF2 RID: 43762 RVA: 0x003F5364 File Offset: 0x003F3564
		internal bool a(ctu A_0)
		{
			return A_0.ao() != null && A_0.ao().GetType() == this.a;
		}

		// Token: 0x04003FD9 RID: 16345
		public Type a;
	}
}
