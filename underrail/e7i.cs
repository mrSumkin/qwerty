using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Threading;

// Token: 0x020018B4 RID: 6324
[eiz("SWC")]
[Serializable]
public sealed class e7i : ISerializable
{
	// Token: 0x06008631 RID: 34353 RVA: 0x00378C5C File Offset: 0x00376E5C
	private e7i(SerializationInfo A_0, StreamingContext A_1)
	{
		if (ell.a() != 0)
		{
			this.a = (ai)A_0.GetValue("SWC:W", typeof(ai));
			this.b = (atk)A_0.GetValue("SWC:WS", typeof(atk));
			if (ell.b() >= 5)
			{
				di7.ReadEvent<EventArgs>("SWC:WS1", ref this.c, A_0);
				di7.ReadEvent<EventArgs>("SWC:WS2", ref this.d, A_0);
				di7.ReadEvent<EventArgs>("SWC:WC", ref this.e, A_0);
				di7.ReadEvent<EventArgs>("SWC:WF", ref this.f, A_0);
				di7.ReadEvent<EventArgs>("SWC:WP", ref this.g, A_0);
				di7.ReadEvent<EventArgs>("SWC:WR", ref this.h, A_0);
				return;
			}
			this.c = (EventHandler<EventArgs>)A_0.GetValue("SWC:WS1", typeof(EventHandler<EventArgs>));
			this.d = (EventHandler<EventArgs>)A_0.GetValue("SWC:WS2", typeof(EventHandler<EventArgs>));
			this.e = (EventHandler<EventArgs>)A_0.GetValue("SWC:WC", typeof(EventHandler<EventArgs>));
			this.f = (EventHandler<EventArgs>)A_0.GetValue("SWC:WF", typeof(EventHandler<EventArgs>));
			this.g = (EventHandler<EventArgs>)A_0.GetValue("SWC:WP", typeof(EventHandler<EventArgs>));
			this.h = (EventHandler<EventArgs>)A_0.GetValue("SWC:WR", typeof(EventHandler<EventArgs>));
			return;
		}
		else
		{
			if (base.GetType() == typeof(e7i))
			{
				this.a = (ai)A_0.GetValue("_Workflow", typeof(ai));
				this.b = (atk)A_0.GetValue("_WorkflowState", typeof(atk));
				this.c = (EventHandler<EventArgs>)A_0.GetValue("WorkflowStarted", typeof(EventHandler<EventArgs>));
				this.d = (EventHandler<EventArgs>)A_0.GetValue("WorkflowStopped", typeof(EventHandler<EventArgs>));
				this.e = (EventHandler<EventArgs>)A_0.GetValue("WorkflowCompleted", typeof(EventHandler<EventArgs>));
				this.f = (EventHandler<EventArgs>)A_0.GetValue("WorkflowFailed", typeof(EventHandler<EventArgs>));
				this.g = (EventHandler<EventArgs>)A_0.GetValue("WorkflowPaused", typeof(EventHandler<EventArgs>));
				this.h = (EventHandler<EventArgs>)A_0.GetValue("WorkflowResumed", typeof(EventHandler<EventArgs>));
				return;
			}
			this.a = (ai)A_0.GetValue("StandaloneWorkflowContainer+_Workflow", typeof(ai));
			this.b = (atk)A_0.GetValue("StandaloneWorkflowContainer+_WorkflowState", typeof(atk));
			this.c = (EventHandler<EventArgs>)A_0.GetValue("StandaloneWorkflowContainer+WorkflowStarted", typeof(EventHandler<EventArgs>));
			this.d = (EventHandler<EventArgs>)A_0.GetValue("StandaloneWorkflowContainer+WorkflowStopped", typeof(EventHandler<EventArgs>));
			this.e = (EventHandler<EventArgs>)A_0.GetValue("StandaloneWorkflowContainer+WorkflowCompleted", typeof(EventHandler<EventArgs>));
			this.f = (EventHandler<EventArgs>)A_0.GetValue("StandaloneWorkflowContainer+WorkflowFailed", typeof(EventHandler<EventArgs>));
			this.g = (EventHandler<EventArgs>)A_0.GetValue("StandaloneWorkflowContainer+WorkflowPaused", typeof(EventHandler<EventArgs>));
			this.h = (EventHandler<EventArgs>)A_0.GetValue("StandaloneWorkflowContainer+WorkflowResumed", typeof(EventHandler<EventArgs>));
			return;
		}
	}

	// Token: 0x06008632 RID: 34354 RVA: 0x00379008 File Offset: 0x00377208
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		info.AddValue("SWC:W", this.a);
		info.AddValue("SWC:WS", this.b);
		di7.WriteEvent<EventArgs>("SWC:WS1", this.c, info);
		di7.WriteEvent<EventArgs>("SWC:WS2", this.d, info);
		di7.WriteEvent<EventArgs>("SWC:WC", this.e, info);
		di7.WriteEvent<EventArgs>("SWC:WF", this.f, info);
		di7.WriteEvent<EventArgs>("SWC:WP", this.g, info);
		di7.WriteEvent<EventArgs>("SWC:WR", this.h, info);
	}

	// Token: 0x06008633 RID: 34355 RVA: 0x003790A4 File Offset: 0x003772A4
	public ai b()
	{
		return this.a;
	}

	// Token: 0x06008634 RID: 34356 RVA: 0x003790AC File Offset: 0x003772AC
	public atk a()
	{
		return this.b;
	}

	// Token: 0x06008635 RID: 34357 RVA: 0x003790B4 File Offset: 0x003772B4
	public e7i()
	{
	}

	// Token: 0x06008636 RID: 34358 RVA: 0x003790C0 File Offset: 0x003772C0
	[CompilerGenerated]
	public void f(EventHandler<EventArgs> A_0)
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

	// Token: 0x06008637 RID: 34359 RVA: 0x003790F8 File Offset: 0x003772F8
	[CompilerGenerated]
	public void l(EventHandler<EventArgs> A_0)
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

	// Token: 0x06008638 RID: 34360 RVA: 0x00379130 File Offset: 0x00377330
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

	// Token: 0x06008639 RID: 34361 RVA: 0x00379168 File Offset: 0x00377368
	[CompilerGenerated]
	public void c(EventHandler<EventArgs> A_0)
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

	// Token: 0x0600863A RID: 34362 RVA: 0x003791A0 File Offset: 0x003773A0
	[CompilerGenerated]
	public void b(EventHandler<EventArgs> A_0)
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

	// Token: 0x0600863B RID: 34363 RVA: 0x003791D8 File Offset: 0x003773D8
	[CompilerGenerated]
	public void k(EventHandler<EventArgs> A_0)
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

	// Token: 0x0600863C RID: 34364 RVA: 0x00379210 File Offset: 0x00377410
	[CompilerGenerated]
	public void j(EventHandler<EventArgs> A_0)
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

	// Token: 0x0600863D RID: 34365 RVA: 0x00379248 File Offset: 0x00377448
	[CompilerGenerated]
	public void h(EventHandler<EventArgs> A_0)
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

	// Token: 0x0600863E RID: 34366 RVA: 0x00379280 File Offset: 0x00377480
	[CompilerGenerated]
	public void g(EventHandler<EventArgs> A_0)
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

	// Token: 0x0600863F RID: 34367 RVA: 0x003792B8 File Offset: 0x003774B8
	[CompilerGenerated]
	public void d(EventHandler<EventArgs> A_0)
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

	// Token: 0x06008640 RID: 34368 RVA: 0x003792F0 File Offset: 0x003774F0
	[CompilerGenerated]
	public void e(EventHandler<EventArgs> A_0)
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

	// Token: 0x06008641 RID: 34369 RVA: 0x00379328 File Offset: 0x00377528
	[CompilerGenerated]
	public void i(EventHandler<EventArgs> A_0)
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

	// Token: 0x06008642 RID: 34370 RVA: 0x00379360 File Offset: 0x00377560
	public bool c()
	{
		if (this.b == atk.d || this.b == atk.c)
		{
			this.b = atk.b;
			if (this.d != null)
			{
				this.d(this, new EventArgs());
			}
			return true;
		}
		return false;
	}

	// Token: 0x06008643 RID: 34371 RVA: 0x003793A4 File Offset: 0x003775A4
	public bool b(e6d A_0)
	{
		if (this.a != null && this.b != atk.c && this.b != atk.d)
		{
			this.a.d(A_0);
			this.b = atk.c;
			if (this.c != null)
			{
				this.c(this, new EventArgs());
			}
			return true;
		}
		return false;
	}

	// Token: 0x06008644 RID: 34372 RVA: 0x00379408 File Offset: 0x00377608
	public void a(ai A_0)
	{
		czh.a(A_0, "workflow");
		this.c();
		this.a = A_0;
		this.b = atk.b;
	}

	// Token: 0x06008645 RID: 34373 RVA: 0x00379430 File Offset: 0x00377630
	public bool a(e6d A_0)
	{
		if (this.b == atk.c && this.a != null)
		{
			cdv cdv = this.a.f(A_0);
			if (cdv == cdv.c)
			{
				this.b = atk.b;
				if (this.f != null)
				{
					this.f(this, new EventArgs());
				}
			}
			else if (cdv == cdv.b)
			{
				this.b = atk.b;
				if (this.e != null)
				{
					this.e(this, new EventArgs());
				}
			}
			return true;
		}
		return false;
	}

	// Token: 0x06008646 RID: 34374 RVA: 0x003794C0 File Offset: 0x003776C0
	public bool e()
	{
		if (this.b == atk.d && this.a != null)
		{
			this.a.e(null);
			this.b = atk.c;
			if (this.h != null)
			{
				this.h(this, new EventArgs());
			}
			return true;
		}
		return false;
	}

	// Token: 0x06008647 RID: 34375 RVA: 0x00379518 File Offset: 0x00377718
	public bool d()
	{
		if (this.b == atk.c && this.a != null)
		{
			this.a.g(null);
			this.b = atk.d;
			if (this.g != null)
			{
				this.g(this, new EventArgs());
			}
			return true;
		}
		return false;
	}

	// Token: 0x0400335B RID: 13147
	private ai a;

	// Token: 0x0400335C RID: 13148
	private atk b;

	// Token: 0x0400335D RID: 13149
	[CompilerGenerated]
	private EventHandler<EventArgs> c;

	// Token: 0x0400335E RID: 13150
	[CompilerGenerated]
	private EventHandler<EventArgs> d;

	// Token: 0x0400335F RID: 13151
	[CompilerGenerated]
	private EventHandler<EventArgs> e;

	// Token: 0x04003360 RID: 13152
	[CompilerGenerated]
	private EventHandler<EventArgs> f;

	// Token: 0x04003361 RID: 13153
	[CompilerGenerated]
	private EventHandler<EventArgs> g;

	// Token: 0x04003362 RID: 13154
	[CompilerGenerated]
	private EventHandler<EventArgs> h;
}
