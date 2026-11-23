using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;

// Token: 0x02001FB0 RID: 8112
public sealed class ezc : Collection<cvh>
{
	// Token: 0x0600BE8C RID: 48780 RVA: 0x004191D8 File Offset: 0x004173D8
	public ezc(dpg A_0)
	{
		czh.a(A_0, "tabControl");
		this.a = A_0;
	}

	// Token: 0x0600BE8D RID: 48781 RVA: 0x004191F4 File Offset: 0x004173F4
	[CompilerGenerated]
	public void f(EventHandler<ListChangedEventArgs> A_0)
	{
		EventHandler<ListChangedEventArgs> eventHandler = this.b;
		EventHandler<ListChangedEventArgs> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<ListChangedEventArgs> value = (EventHandler<ListChangedEventArgs>)Delegate.Combine(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<ListChangedEventArgs>>(ref this.b, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x0600BE8E RID: 48782 RVA: 0x0041922C File Offset: 0x0041742C
	[CompilerGenerated]
	public void a(EventHandler<ListChangedEventArgs> A_0)
	{
		EventHandler<ListChangedEventArgs> eventHandler = this.b;
		EventHandler<ListChangedEventArgs> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<ListChangedEventArgs> value = (EventHandler<ListChangedEventArgs>)Delegate.Remove(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<ListChangedEventArgs>>(ref this.b, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x0600BE8F RID: 48783 RVA: 0x00419264 File Offset: 0x00417464
	[CompilerGenerated]
	public void c(EventHandler<ListChangedEventArgs> A_0)
	{
		EventHandler<ListChangedEventArgs> eventHandler = this.c;
		EventHandler<ListChangedEventArgs> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<ListChangedEventArgs> value = (EventHandler<ListChangedEventArgs>)Delegate.Combine(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<ListChangedEventArgs>>(ref this.c, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x0600BE90 RID: 48784 RVA: 0x0041929C File Offset: 0x0041749C
	[CompilerGenerated]
	public void d(EventHandler<ListChangedEventArgs> A_0)
	{
		EventHandler<ListChangedEventArgs> eventHandler = this.c;
		EventHandler<ListChangedEventArgs> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<ListChangedEventArgs> value = (EventHandler<ListChangedEventArgs>)Delegate.Remove(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<ListChangedEventArgs>>(ref this.c, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x0600BE91 RID: 48785 RVA: 0x004192D4 File Offset: 0x004174D4
	[CompilerGenerated]
	public void a(EventHandler A_0)
	{
		EventHandler eventHandler = this.d;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Combine(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.d, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x0600BE92 RID: 48786 RVA: 0x0041930C File Offset: 0x0041750C
	[CompilerGenerated]
	public void b(EventHandler A_0)
	{
		EventHandler eventHandler = this.d;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Remove(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.d, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x0600BE93 RID: 48787 RVA: 0x00419344 File Offset: 0x00417544
	[CompilerGenerated]
	public void b(EventHandler<ListChangedEventArgs> A_0)
	{
		EventHandler<ListChangedEventArgs> eventHandler = this.e;
		EventHandler<ListChangedEventArgs> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<ListChangedEventArgs> value = (EventHandler<ListChangedEventArgs>)Delegate.Combine(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<ListChangedEventArgs>>(ref this.e, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x0600BE94 RID: 48788 RVA: 0x0041937C File Offset: 0x0041757C
	[CompilerGenerated]
	public void e(EventHandler<ListChangedEventArgs> A_0)
	{
		EventHandler<ListChangedEventArgs> eventHandler = this.e;
		EventHandler<ListChangedEventArgs> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<ListChangedEventArgs> value = (EventHandler<ListChangedEventArgs>)Delegate.Remove(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<ListChangedEventArgs>>(ref this.e, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x0600BE95 RID: 48789 RVA: 0x004193B4 File Offset: 0x004175B4
	protected override void InsertItem(int index, cvh item)
	{
		base.InsertItem(index, item);
		if (this.b != null)
		{
			this.b(item, new ListChangedEventArgs(ListChangedType.ItemAdded, index));
		}
	}

	// Token: 0x0600BE96 RID: 48790 RVA: 0x004193E0 File Offset: 0x004175E0
	protected override void RemoveItem(int index)
	{
		cvh sender = base[index];
		base.RemoveItem(index);
		if (this.c != null)
		{
			this.c(sender, new ListChangedEventArgs(ListChangedType.ItemDeleted, index, index));
		}
	}

	// Token: 0x0600BE97 RID: 48791 RVA: 0x0041941C File Offset: 0x0041761C
	protected override void ClearItems()
	{
		base.ClearItems();
		if (this.d != null)
		{
			this.d(this, new EventArgs());
		}
	}

	// Token: 0x0600BE98 RID: 48792 RVA: 0x00419440 File Offset: 0x00417640
	protected override void SetItem(int index, cvh item)
	{
		base.SetItem(index, item);
		if (this.e != null)
		{
			this.e(item, new ListChangedEventArgs(ListChangedType.ItemChanged, index));
		}
	}

	// Token: 0x0400446A RID: 17514
	private dpg a;

	// Token: 0x0400446B RID: 17515
	[CompilerGenerated]
	private EventHandler<ListChangedEventArgs> b;

	// Token: 0x0400446C RID: 17516
	[CompilerGenerated]
	private EventHandler<ListChangedEventArgs> c;

	// Token: 0x0400446D RID: 17517
	[CompilerGenerated]
	private EventHandler d;

	// Token: 0x0400446E RID: 17518
	[CompilerGenerated]
	private EventHandler<ListChangedEventArgs> e;
}
