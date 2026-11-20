using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;

// Token: 0x02001FB2 RID: 8114
public sealed class bqr : dbi, IDisposable, eeg
{
	// Token: 0x0600BE9A RID: 48794 RVA: 0x00419480 File Offset: 0x00417680
	[CompilerGenerated]
	public void zw(EventHandler<by0> A_0)
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

	// Token: 0x0600BE9B RID: 48795 RVA: 0x004194B8 File Offset: 0x004176B8
	[CompilerGenerated]
	public void zx(EventHandler<by0> A_0)
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

	// Token: 0x0600BE9C RID: 48796 RVA: 0x004194F0 File Offset: 0x004176F0
	[CompilerGenerated]
	public void zy(EventHandler<by0> A_0)
	{
		EventHandler<by0> eventHandler = this.h;
		EventHandler<by0> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<by0> value = (EventHandler<by0>)Delegate.Combine(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<by0>>(ref this.h, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x0600BE9D RID: 48797 RVA: 0x00419528 File Offset: 0x00417728
	[CompilerGenerated]
	public void zz(EventHandler<by0> A_0)
	{
		EventHandler<by0> eventHandler = this.h;
		EventHandler<by0> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<by0> value = (EventHandler<by0>)Delegate.Remove(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<by0>>(ref this.h, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x0600BE9E RID: 48798 RVA: 0x00419560 File Offset: 0x00417760
	public eeg z0()
	{
		return this.f;
	}

	// Token: 0x0600BE9F RID: 48799 RVA: 0x00419568 File Offset: 0x00417768
	public void z1(eeg A_0)
	{
		this.f = A_0;
	}

	// Token: 0x0600BEA0 RID: 48800 RVA: 0x00419574 File Offset: 0x00417774
	public List<coh> z2()
	{
		if (!this.c || this.b == null)
		{
			if (this.d != null)
			{
				this.b = Enumerable.ToList<coh>(Enumerable.Where<coh>(this.a.z2(), new Func<coh, bool>(this.d.cx)));
			}
			else
			{
				this.b = new List<coh>(this.a.z2());
			}
			this.c = true;
		}
		return this.b;
	}

	// Token: 0x0600BEA1 RID: 48801 RVA: 0x004195F8 File Offset: 0x004177F8
	public bp2 c()
	{
		return this.d;
	}

	// Token: 0x0600BEA2 RID: 48802 RVA: 0x00419600 File Offset: 0x00417800
	public void a(bp2 A_0)
	{
		if (this.d != A_0)
		{
			this.d = A_0;
			this.b();
		}
	}

	// Token: 0x0600BEA3 RID: 48803 RVA: 0x0041961C File Offset: 0x0041781C
	public dbi a()
	{
		return this.a;
	}

	// Token: 0x0600BEA4 RID: 48804 RVA: 0x00419624 File Offset: 0x00417824
	public bqr(dbi A_0)
	{
		czh.a(A_0, "source");
		this.a = A_0;
		this.d();
	}

	// Token: 0x0600BEA5 RID: 48805 RVA: 0x00419644 File Offset: 0x00417844
	public void z3(coh A_0, bool A_1 = true)
	{
		this.a.z3(A_0, A_1);
	}

	// Token: 0x0600BEA6 RID: 48806 RVA: 0x00419654 File Offset: 0x00417854
	public void z4(int A_0, coh A_1)
	{
		this.a.z4(A_0, A_1);
	}

	// Token: 0x0600BEA7 RID: 48807 RVA: 0x00419664 File Offset: 0x00417864
	public bool z5(coh A_0)
	{
		return this.a.z5(A_0);
	}

	// Token: 0x0600BEA8 RID: 48808 RVA: 0x00419674 File Offset: 0x00417874
	public bool z6(int A_0)
	{
		throw new NotSupportedException();
	}

	// Token: 0x0600BEA9 RID: 48809 RVA: 0x0041967C File Offset: 0x0041787C
	public void z7()
	{
		this.a.z7();
	}

	// Token: 0x0600BEAA RID: 48810 RVA: 0x0041968C File Offset: 0x0041788C
	public void b()
	{
		this.c = false;
	}

	// Token: 0x0600BEAB RID: 48811 RVA: 0x00419698 File Offset: 0x00417898
	public int z8()
	{
		int num = 0;
		if (this.b != null)
		{
			foreach (coh coh in this.b)
			{
				num += coh.ItemValue;
			}
		}
		return num;
	}

	// Token: 0x0600BEAC RID: 48812 RVA: 0x00419704 File Offset: 0x00417904
	public int z9(HashSet<string> A_0, float A_1)
	{
		return e7a.a(this.b, A_0, A_1);
	}

	// Token: 0x0600BEAD RID: 48813 RVA: 0x00419714 File Offset: 0x00417914
	public void aaa(coh A_0)
	{
		this.a.aaa(A_0);
	}

	// Token: 0x0600BEAE RID: 48814 RVA: 0x00419724 File Offset: 0x00417924
	public void Dispose()
	{
		this.a(true);
		GC.SuppressFinalize(this);
	}

	// Token: 0x0600BEAF RID: 48815 RVA: 0x00419734 File Offset: 0x00417934
	public void d()
	{
		this.a.z1(this);
	}

	// Token: 0x0600BEB0 RID: 48816 RVA: 0x00419744 File Offset: 0x00417944
	public void e()
	{
		if (this.a.z0() == this)
		{
			this.a.z1(null);
		}
	}

	// Token: 0x0600BEB1 RID: 48817 RVA: 0x00419764 File Offset: 0x00417964
	public void aab(dbi A_0, coh A_1)
	{
		this.b();
	}

	// Token: 0x0600BEB2 RID: 48818 RVA: 0x0041976C File Offset: 0x0041796C
	public void aac(dbi A_0, coh A_1)
	{
		this.b();
	}

	// Token: 0x0600BEB3 RID: 48819 RVA: 0x00419774 File Offset: 0x00417974
	public void aad()
	{
		this.a.aad();
		e7a.a(ref this.b);
	}

	// Token: 0x0600BEB4 RID: 48820 RVA: 0x0041978C File Offset: 0x0041798C
	private void a(bool A_0)
	{
		if (!this.e)
		{
			if (A_0)
			{
				this.e();
			}
			this.e = true;
		}
	}

	// Token: 0x0400446F RID: 17519
	private dbi a;

	// Token: 0x04004470 RID: 17520
	private List<coh> b;

	// Token: 0x04004471 RID: 17521
	private bool c;

	// Token: 0x04004472 RID: 17522
	private bp2 d;

	// Token: 0x04004473 RID: 17523
	private bool e;

	// Token: 0x04004474 RID: 17524
	private eeg f;

	// Token: 0x04004475 RID: 17525
	[CompilerGenerated]
	private EventHandler<by0> g;

	// Token: 0x04004476 RID: 17526
	[CompilerGenerated]
	private EventHandler<by0> h;
}
