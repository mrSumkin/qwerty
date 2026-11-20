using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Threading;
using Ouroboros.Core.Logging;

// Token: 0x02000286 RID: 646
[eiz("A5")]
[Serializable]
public abstract class dvv : auv, ISerializable
{
	// Token: 0x060012C1 RID: 4801 RVA: 0x0004E1A8 File Offset: 0x0004C3A8
	protected dvv(SerializationInfo A_0, StreamingContext A_1)
	{
		if (ell.b() != 0)
		{
			this.a = (Guid)A_0.GetValue("A5:I", typeof(Guid));
			this.b = A_0.GetString("A5:N");
			this.c = (dc4)A_0.GetValue("A5:S", typeof(dc4));
			if (ell.b() >= 5)
			{
				di7.ReadEvent<EventArgs>("A5:I1", ref this.e, A_0);
				di7.ReadEvent<EventArgs>("A5:F", ref this.f, A_0);
				di7.ReadEvent<EventArgs>("A5:F1", ref this.g, A_0);
				di7.ReadEvent<EventArgs>("A5:C", ref this.h, A_0);
				return;
			}
			this.e = (EventHandler<EventArgs>)A_0.GetValue("A5:I1", typeof(EventHandler<EventArgs>));
			this.f = (EventHandler<EventArgs>)A_0.GetValue("A5:F", typeof(EventHandler<EventArgs>));
			this.g = (EventHandler<EventArgs>)A_0.GetValue("A5:F1", typeof(EventHandler<EventArgs>));
			this.h = (EventHandler<EventArgs>)A_0.GetValue("A5:C", typeof(EventHandler<EventArgs>));
			return;
		}
		else
		{
			if (base.GetType() == typeof(dvv))
			{
				this.a = (Guid)A_0.GetValue("_Id", typeof(Guid));
				this.b = A_0.GetString("_Name");
				this.c = (dc4)A_0.GetValue("_State", typeof(dc4));
				this.e = (EventHandler<EventArgs>)A_0.GetValue("Initialized", typeof(EventHandler<EventArgs>));
				this.f = (EventHandler<EventArgs>)A_0.GetValue("Finished", typeof(EventHandler<EventArgs>));
				this.g = (EventHandler<EventArgs>)A_0.GetValue("Failed", typeof(EventHandler<EventArgs>));
				this.h = (EventHandler<EventArgs>)A_0.GetValue("Cancelled", typeof(EventHandler<EventArgs>));
				return;
			}
			this.a = (Guid)A_0.GetValue("Action+_Id", typeof(Guid));
			this.b = A_0.GetString("Action+_Name");
			this.c = (dc4)A_0.GetValue("Action+_State", typeof(dc4));
			this.e = (EventHandler<EventArgs>)A_0.GetValue("Action+Initialized", typeof(EventHandler<EventArgs>));
			this.f = (EventHandler<EventArgs>)A_0.GetValue("Action+Finished", typeof(EventHandler<EventArgs>));
			this.g = (EventHandler<EventArgs>)A_0.GetValue("Action+Failed", typeof(EventHandler<EventArgs>));
			this.h = (EventHandler<EventArgs>)A_0.GetValue("Action+Cancelled", typeof(EventHandler<EventArgs>));
			return;
		}
	}

	// Token: 0x060012C2 RID: 4802 RVA: 0x0004E4A4 File Offset: 0x0004C6A4
	public virtual void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		info.AddValue("A5:I", this.a);
		info.AddValue("A5:N", this.b);
		info.AddValue("A5:S", this.c);
		di7.WriteEvent<EventArgs>("A5:I1", this.e, info);
		di7.WriteEvent<EventArgs>("A5:F", this.f, info);
		di7.WriteEvent<EventArgs>("A5:F1", this.g, info);
		di7.WriteEvent<EventArgs>("A5:C", this.h, info);
	}

	// Token: 0x060012C3 RID: 4803 RVA: 0x0004E534 File Offset: 0x0004C734
	public Guid s()
	{
		return this.a;
	}

	// Token: 0x060012C4 RID: 4804 RVA: 0x0004E53C File Offset: 0x0004C73C
	public string w()
	{
		return this.b;
	}

	// Token: 0x060012C5 RID: 4805 RVA: 0x0004E544 File Offset: 0x0004C744
	public dc4 x()
	{
		return this.c;
	}

	// Token: 0x060012C6 RID: 4806 RVA: 0x0004E54C File Offset: 0x0004C74C
	public cix y()
	{
		return this.d;
	}

	// Token: 0x060012C7 RID: 4807 RVA: 0x0004E554 File Offset: 0x0004C754
	protected dvv()
	{
		this.a = Guid.NewGuid();
	}

	// Token: 0x060012C8 RID: 4808 RVA: 0x0004E568 File Offset: 0x0004C768
	protected dvv(string A_0) : this()
	{
		this.b = A_0;
	}

	// Token: 0x060012C9 RID: 4809 RVA: 0x0004E578 File Offset: 0x0004C778
	[CompilerGenerated]
	public void t(EventHandler<EventArgs> A_0)
	{
		EventHandler<EventArgs> eventHandler = this.e;
		EventHandler<EventArgs> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<EventArgs> value = (EventHandler<EventArgs>)Delegate.Combine(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs>>(ref this.e, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x060012CA RID: 4810 RVA: 0x0004E5B0 File Offset: 0x0004C7B0
	[CompilerGenerated]
	public void u(EventHandler<EventArgs> A_0)
	{
		EventHandler<EventArgs> eventHandler = this.e;
		EventHandler<EventArgs> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<EventArgs> value = (EventHandler<EventArgs>)Delegate.Remove(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs>>(ref this.e, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x060012CB RID: 4811 RVA: 0x0004E5E8 File Offset: 0x0004C7E8
	[CompilerGenerated]
	public void q(EventHandler<EventArgs> A_0)
	{
		EventHandler<EventArgs> eventHandler = this.f;
		EventHandler<EventArgs> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<EventArgs> value = (EventHandler<EventArgs>)Delegate.Combine(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs>>(ref this.f, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x060012CC RID: 4812 RVA: 0x0004E620 File Offset: 0x0004C820
	[CompilerGenerated]
	public void r(EventHandler<EventArgs> A_0)
	{
		EventHandler<EventArgs> eventHandler = this.f;
		EventHandler<EventArgs> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<EventArgs> value = (EventHandler<EventArgs>)Delegate.Remove(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs>>(ref this.f, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x060012CD RID: 4813 RVA: 0x0004E658 File Offset: 0x0004C858
	[CompilerGenerated]
	public void o(EventHandler<EventArgs> A_0)
	{
		EventHandler<EventArgs> eventHandler = this.g;
		EventHandler<EventArgs> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<EventArgs> value = (EventHandler<EventArgs>)Delegate.Combine(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs>>(ref this.g, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x060012CE RID: 4814 RVA: 0x0004E690 File Offset: 0x0004C890
	[CompilerGenerated]
	public void p(EventHandler<EventArgs> A_0)
	{
		EventHandler<EventArgs> eventHandler = this.g;
		EventHandler<EventArgs> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<EventArgs> value = (EventHandler<EventArgs>)Delegate.Remove(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs>>(ref this.g, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x060012CF RID: 4815 RVA: 0x0004E6C8 File Offset: 0x0004C8C8
	[CompilerGenerated]
	public void l(EventHandler<EventArgs> A_0)
	{
		EventHandler<EventArgs> eventHandler = this.h;
		EventHandler<EventArgs> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<EventArgs> value = (EventHandler<EventArgs>)Delegate.Combine(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs>>(ref this.h, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x060012D0 RID: 4816 RVA: 0x0004E700 File Offset: 0x0004C900
	[CompilerGenerated]
	public void m(EventHandler<EventArgs> A_0)
	{
		EventHandler<EventArgs> eventHandler = this.h;
		EventHandler<EventArgs> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<EventArgs> value = (EventHandler<EventArgs>)Delegate.Remove(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs>>(ref this.h, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x060012D1 RID: 4817 RVA: 0x0004E738 File Offset: 0x0004C938
	protected virtual dc4 dt()
	{
		return dc4.b;
	}

	// Token: 0x060012D2 RID: 4818
	protected abstract dc4 fr(TimeSpan A_0, TimeSpan A_1);

	// Token: 0x060012D3 RID: 4819 RVA: 0x0004E73C File Offset: 0x0004C93C
	protected virtual void j4()
	{
	}

	// Token: 0x060012D4 RID: 4820 RVA: 0x0004E740 File Offset: 0x0004C940
	protected virtual void agp()
	{
	}

	// Token: 0x060012D5 RID: 4821 RVA: 0x0004E744 File Offset: 0x0004C944
	public bool v(cix A_0)
	{
		this.d = A_0;
		this.c = this.dt();
		this.a(this.c);
		return this.c == dc4.b;
	}

	// Token: 0x060012D6 RID: 4822 RVA: 0x0004E770 File Offset: 0x0004C970
	public dc4 n(TimeSpan A_0, TimeSpan A_1)
	{
		dc4 dc = this.fr(A_0, A_1);
		if (this.c != dc4.d)
		{
			if (dc == dc4.a || dc == dc4.d)
			{
				cvq service = bpo.GetService<cvq>();
				if (service != null && service.n8() && service.n9(LogSeverity.Warning, 112))
				{
					string a_ = string.Format("[Playfield] - Action (id: {0}, Name: {1}) returned invalid state on executing: {2}. State will default to failed.", this.a, this.b, dc);
					service.n7(LogSeverity.Warning, 112, a_);
				}
				this.a();
			}
			else if (this.c != dc)
			{
				this.c = dc;
				if (this.c == dc4.c)
				{
					this.b();
				}
				else if (this.c == dc4.e)
				{
					this.a();
				}
			}
		}
		return this.c;
	}

	// Token: 0x060012D7 RID: 4823 RVA: 0x0004E840 File Offset: 0x0004CA40
	public void k()
	{
		this.j4();
		this.c = dc4.d;
		if (this.h != null)
		{
			this.h(this, new EventArgs());
		}
	}

	// Token: 0x060012D8 RID: 4824 RVA: 0x0004E86C File Offset: 0x0004CA6C
	public void j()
	{
		if (this.c == dc4.b && this.d != null)
		{
			this.d.ha(this);
		}
	}

	// Token: 0x060012D9 RID: 4825 RVA: 0x0004E894 File Offset: 0x0004CA94
	public virtual void z(cix A_0)
	{
		this.d = A_0;
	}

	// Token: 0x060012DA RID: 4826 RVA: 0x0004E8A0 File Offset: 0x0004CAA0
	public void a(atp A_0)
	{
		if (this.y() != null)
		{
			this.y().hd(this, A_0);
		}
	}

	// Token: 0x060012DB RID: 4827 RVA: 0x0004E8C0 File Offset: 0x0004CAC0
	private void a(dc4 A_0)
	{
		if (A_0 == dc4.b)
		{
			if (this.e != null)
			{
				this.e(this, new EventArgs());
				return;
			}
		}
		else
		{
			if (A_0 == dc4.c)
			{
				this.b();
				return;
			}
			if (A_0 == dc4.e)
			{
				this.a();
			}
		}
	}

	// Token: 0x060012DC RID: 4828 RVA: 0x0004E90C File Offset: 0x0004CB0C
	private void b()
	{
		if (this.c == dc4.c && this.f != null)
		{
			this.f(this, new EventArgs());
		}
	}

	// Token: 0x060012DD RID: 4829 RVA: 0x0004E938 File Offset: 0x0004CB38
	private void a()
	{
		this.agp();
		this.c = dc4.e;
		if (this.g != null)
		{
			this.g(this, new EventArgs());
		}
	}

	// Token: 0x04000A54 RID: 2644
	private Guid a;

	// Token: 0x04000A55 RID: 2645
	private string b;

	// Token: 0x04000A56 RID: 2646
	private dc4 c;

	// Token: 0x04000A57 RID: 2647
	[NonSerialized]
	private cix d;

	// Token: 0x04000A58 RID: 2648
	[CompilerGenerated]
	private EventHandler<EventArgs> e;

	// Token: 0x04000A59 RID: 2649
	[CompilerGenerated]
	private EventHandler<EventArgs> f;

	// Token: 0x04000A5A RID: 2650
	[CompilerGenerated]
	private EventHandler<EventArgs> g;

	// Token: 0x04000A5B RID: 2651
	[CompilerGenerated]
	private EventHandler<EventArgs> h;
}
