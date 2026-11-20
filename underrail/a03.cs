using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;

// Token: 0x020001B2 RID: 434
public abstract class a03 : euz
{
	// Token: 0x06000C59 RID: 3161 RVA: 0x00032A00 File Offset: 0x00030C00
	protected List<object> h()
	{
		return this.a;
	}

	// Token: 0x06000C5A RID: 3162 RVA: 0x00032A08 File Offset: 0x00030C08
	public object l()
	{
		return this.b;
	}

	// Token: 0x06000C5B RID: 3163 RVA: 0x00032A10 File Offset: 0x00030C10
	public void b(object A_0)
	{
		if (this.b != A_0)
		{
			this.e(A_0);
		}
	}

	// Token: 0x06000C5C RID: 3164 RVA: 0x00032A28 File Offset: 0x00030C28
	public int j()
	{
		return this.a.IndexOf(this.b);
	}

	// Token: 0x06000C5D RID: 3165 RVA: 0x00032A3C File Offset: 0x00030C3C
	public bool k()
	{
		return this.c;
	}

	// Token: 0x06000C5E RID: 3166 RVA: 0x00032A44 File Offset: 0x00030C44
	public void a(bool A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06000C5F RID: 3167 RVA: 0x00032A50 File Offset: 0x00030C50
	[CompilerGenerated]
	public void b(EventHandler<a8t> A_0)
	{
		EventHandler<a8t> eventHandler = this.d;
		EventHandler<a8t> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<a8t> value = (EventHandler<a8t>)Delegate.Combine(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<a8t>>(ref this.d, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06000C60 RID: 3168 RVA: 0x00032A88 File Offset: 0x00030C88
	[CompilerGenerated]
	public void a(EventHandler<a8t> A_0)
	{
		EventHandler<a8t> eventHandler = this.d;
		EventHandler<a8t> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<a8t> value = (EventHandler<a8t>)Delegate.Remove(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<a8t>>(ref this.d, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06000C61 RID: 3169 RVA: 0x00032AC0 File Offset: 0x00030CC0
	[CompilerGenerated]
	public void d(EventHandler<a8t> A_0)
	{
		EventHandler<a8t> eventHandler = this.e;
		EventHandler<a8t> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<a8t> value = (EventHandler<a8t>)Delegate.Combine(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<a8t>>(ref this.e, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06000C62 RID: 3170 RVA: 0x00032AF8 File Offset: 0x00030CF8
	[CompilerGenerated]
	public void c(EventHandler<a8t> A_0)
	{
		EventHandler<a8t> eventHandler = this.e;
		EventHandler<a8t> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<a8t> value = (EventHandler<a8t>)Delegate.Remove(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<a8t>>(ref this.e, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06000C63 RID: 3171 RVA: 0x00032B30 File Offset: 0x00030D30
	[CompilerGenerated]
	public void a(EventHandler<c1> A_0)
	{
		EventHandler<c1> eventHandler = this.f;
		EventHandler<c1> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<c1> value = (EventHandler<c1>)Delegate.Combine(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<c1>>(ref this.f, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06000C64 RID: 3172 RVA: 0x00032B68 File Offset: 0x00030D68
	[CompilerGenerated]
	public void b(EventHandler<c1> A_0)
	{
		EventHandler<c1> eventHandler = this.f;
		EventHandler<c1> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<c1> value = (EventHandler<c1>)Delegate.Remove(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<c1>>(ref this.f, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06000C65 RID: 3173 RVA: 0x00032BA0 File Offset: 0x00030DA0
	protected a03()
	{
		this.b(new EventHandler<a8t>(this.sr));
		this.d(new EventHandler<a8t>(this.ss));
		this.a(new EventHandler<c1>(this.st));
	}

	// Token: 0x06000C66 RID: 3174 RVA: 0x00032BF8 File Offset: 0x00030DF8
	protected virtual void st(object A_0, c1 A_1)
	{
		base.e("SelectedItemChanged");
	}

	// Token: 0x06000C67 RID: 3175 RVA: 0x00032C08 File Offset: 0x00030E08
	protected virtual void ss(object A_0, a8t A_1)
	{
		base.e("ItemRemoved");
	}

	// Token: 0x06000C68 RID: 3176 RVA: 0x00032C18 File Offset: 0x00030E18
	protected virtual void sr(object A_0, a8t A_1)
	{
		base.e("ItemAdded");
	}

	// Token: 0x06000C69 RID: 3177 RVA: 0x00032C28 File Offset: 0x00030E28
	public void d(object A_0)
	{
		czh.a(A_0, "item");
		this.a.Add(A_0);
		if (this.d != null)
		{
			this.d(this, new a8t(A_0));
		}
	}

	// Token: 0x06000C6A RID: 3178 RVA: 0x00032C60 File Offset: 0x00030E60
	public void a(IEnumerable<object> A_0)
	{
		czh.a(A_0, "items");
		foreach (object a_ in A_0)
		{
			this.d(a_);
		}
	}

	// Token: 0x06000C6B RID: 3179 RVA: 0x00032CBC File Offset: 0x00030EBC
	public void c(object A_0)
	{
		czh.a(A_0, "item");
		if (this.a.Contains(A_0))
		{
			this.a.Remove(A_0);
			this.a(A_0);
		}
	}

	// Token: 0x06000C6C RID: 3180 RVA: 0x00032CF0 File Offset: 0x00030EF0
	public void a(int A_0)
	{
		if (this.a.Count > A_0)
		{
			object a_ = this.a[A_0];
			this.a.RemoveAt(A_0);
			this.a(a_);
		}
	}

	// Token: 0x06000C6D RID: 3181 RVA: 0x00032D30 File Offset: 0x00030F30
	public void i()
	{
		for (int i = this.a.Count - 1; i >= 0; i--)
		{
			this.a(i);
		}
	}

	// Token: 0x06000C6E RID: 3182 RVA: 0x00032D60 File Offset: 0x00030F60
	protected void e(object A_0)
	{
		object obj = this.b;
		if (A_0 == null || (!this.a.Contains(A_0) && !this.c))
		{
			this.b = null;
		}
		else
		{
			this.b = A_0;
		}
		if (obj != this.b && this.f != null)
		{
			this.f(this, new c1(obj, this.b));
		}
	}

	// Token: 0x06000C6F RID: 3183 RVA: 0x00032DD8 File Offset: 0x00030FD8
	protected void b(int A_0)
	{
		object obj = this.b;
		if (A_0 > 0 && this.a.Count > A_0)
		{
			this.b = this.a[A_0];
		}
		else
		{
			this.b = null;
		}
		if (obj != this.b && this.f != null)
		{
			this.f(this, new c1(obj, this.b));
		}
	}

	// Token: 0x06000C70 RID: 3184 RVA: 0x00032E54 File Offset: 0x00031054
	private void a(object A_0)
	{
		if (this.e != null)
		{
			this.e(this, new a8t(A_0));
		}
		if (this.b == A_0 && !this.a.Contains(A_0))
		{
			this.e(null);
		}
	}

	// Token: 0x04000754 RID: 1876
	private new List<object> a = new List<object>();

	// Token: 0x04000755 RID: 1877
	private new object b;

	// Token: 0x04000756 RID: 1878
	private new bool c;

	// Token: 0x04000757 RID: 1879
	[CompilerGenerated]
	private new EventHandler<a8t> d;

	// Token: 0x04000758 RID: 1880
	[CompilerGenerated]
	private new EventHandler<a8t> e;

	// Token: 0x04000759 RID: 1881
	[CompilerGenerated]
	private new EventHandler<c1> f;
}
