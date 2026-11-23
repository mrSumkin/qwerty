using System;
using System.Runtime.CompilerServices;
using System.Threading;
using Ouroboros.Core.Logging;

// Token: 0x02000634 RID: 1588
public sealed class cv4 : bi3
{
	// Token: 0x060028AB RID: 10411 RVA: 0x000E9498 File Offset: 0x000E7698
	public eit aii()
	{
		return this.a;
	}

	// Token: 0x060028AC RID: 10412 RVA: 0x000E94A0 File Offset: 0x000E76A0
	public bad aij()
	{
		return this.c;
	}

	// Token: 0x060028AD RID: 10413 RVA: 0x000E94A8 File Offset: 0x000E76A8
	public lu aik()
	{
		if (this.a == eit.b)
		{
			return this.c.eg();
		}
		return null;
	}

	// Token: 0x060028AE RID: 10414 RVA: 0x000E94C4 File Offset: 0x000E76C4
	public cv4(aa8 A_0)
	{
		this.b = A_0;
	}

	// Token: 0x060028AF RID: 10415 RVA: 0x000E94D4 File Offset: 0x000E76D4
	[CompilerGenerated]
	public void f(EventHandler<dtl> A_0)
	{
		EventHandler<dtl> eventHandler = this.d;
		EventHandler<dtl> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<dtl> value = (EventHandler<dtl>)Delegate.Combine(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<dtl>>(ref this.d, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x060028B0 RID: 10416 RVA: 0x000E950C File Offset: 0x000E770C
	[CompilerGenerated]
	public void c(EventHandler<dtl> A_0)
	{
		EventHandler<dtl> eventHandler = this.d;
		EventHandler<dtl> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<dtl> value = (EventHandler<dtl>)Delegate.Remove(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<dtl>>(ref this.d, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x060028B1 RID: 10417 RVA: 0x000E9544 File Offset: 0x000E7744
	[CompilerGenerated]
	public void a(EventHandler<dtl> A_0)
	{
		EventHandler<dtl> eventHandler = this.e;
		EventHandler<dtl> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<dtl> value = (EventHandler<dtl>)Delegate.Combine(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<dtl>>(ref this.e, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x060028B2 RID: 10418 RVA: 0x000E957C File Offset: 0x000E777C
	[CompilerGenerated]
	public void d(EventHandler<dtl> A_0)
	{
		EventHandler<dtl> eventHandler = this.e;
		EventHandler<dtl> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<dtl> value = (EventHandler<dtl>)Delegate.Remove(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<dtl>>(ref this.e, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x060028B3 RID: 10419 RVA: 0x000E95B4 File Offset: 0x000E77B4
	[CompilerGenerated]
	public void b(EventHandler<dtl> A_0)
	{
		EventHandler<dtl> eventHandler = this.f;
		EventHandler<dtl> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<dtl> value = (EventHandler<dtl>)Delegate.Combine(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<dtl>>(ref this.f, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x060028B4 RID: 10420 RVA: 0x000E95EC File Offset: 0x000E77EC
	[CompilerGenerated]
	public void e(EventHandler<dtl> A_0)
	{
		EventHandler<dtl> eventHandler = this.f;
		EventHandler<dtl> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<dtl> value = (EventHandler<dtl>)Delegate.Remove(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<dtl>>(ref this.f, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x060028B5 RID: 10421 RVA: 0x000E9624 File Offset: 0x000E7824
	public bool a(Type A_0, params object[] A_1)
	{
		czh.a(A_0, "commandType");
		if (!typeof(bad).IsAssignableFrom(A_0))
		{
			dux.b(LogSeverity.Error, rz.m, new object[]
			{
				A_0.FullName
			});
			return false;
		}
		bad a_;
		try
		{
			a_ = (Activator.CreateInstance(A_0, A_1) as bad);
		}
		catch (Exception ex)
		{
			dux.b(LogSeverity.Error, rz.c, new object[]
			{
				A_0.FullName,
				A_1.Length.ToString(),
				ex.ToString()
			});
			return false;
		}
		return this.ail(a_);
	}

	// Token: 0x060028B6 RID: 10422 RVA: 0x000E96D4 File Offset: 0x000E78D4
	public bool ail(bad A_0)
	{
		this.aim();
		this.c = A_0;
		this.a = eit.b;
		if (this.d != null)
		{
			this.d(this, new dtl(this.c));
		}
		this.b();
		return true;
	}

	// Token: 0x060028B7 RID: 10423 RVA: 0x000E9714 File Offset: 0x000E7914
	public void aim()
	{
		if (this.c != null)
		{
			this.a();
			if (this.f != null)
			{
				this.f(this, new dtl(this.c));
			}
		}
	}

	// Token: 0x060028B8 RID: 10424 RVA: 0x000E974C File Offset: 0x000E794C
	public bool a(object A_0)
	{
		return this.a == eit.b && this.c.eg() != null && this.c.eg().cg(A_0);
	}

	// Token: 0x060028B9 RID: 10425 RVA: 0x000E9780 File Offset: 0x000E7980
	public bool ain(object A_0)
	{
		czh.a(A_0, "target");
		return this.a == eit.b && this.c.a(A_0) && this.b();
	}

	// Token: 0x060028BA RID: 10426 RVA: 0x000E97B4 File Offset: 0x000E79B4
	private bool b()
	{
		if (this.c.eg() == null || this.c.a() != null)
		{
			bad a_ = this.c;
			if (this.b != null)
			{
				this.b.lj(a_);
			}
			this.a();
			if (this.e != null)
			{
				this.e(this, new dtl(a_));
			}
			return true;
		}
		return false;
	}

	// Token: 0x060028BB RID: 10427 RVA: 0x000E9828 File Offset: 0x000E7A28
	private void a()
	{
		if (this.a == eit.b)
		{
			this.c = null;
			this.a = eit.a;
		}
	}

	// Token: 0x0400165C RID: 5724
	private eit a;

	// Token: 0x0400165D RID: 5725
	private aa8 b;

	// Token: 0x0400165E RID: 5726
	private bad c;

	// Token: 0x0400165F RID: 5727
	[CompilerGenerated]
	private EventHandler<dtl> d;

	// Token: 0x04001660 RID: 5728
	[CompilerGenerated]
	private EventHandler<dtl> e;

	// Token: 0x04001661 RID: 5729
	[CompilerGenerated]
	private EventHandler<dtl> f;
}
