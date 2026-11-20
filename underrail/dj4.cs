using System;
using System.Runtime.CompilerServices;
using System.Threading;

// Token: 0x02000340 RID: 832
public abstract class dj4 : ot
{
	// Token: 0x06001782 RID: 6018 RVA: 0x00077098 File Offset: 0x00075298
	[CompilerGenerated]
	public void akj(EventHandler<EventArgs> A_0)
	{
		EventHandler<EventArgs> eventHandler = this.a;
		EventHandler<EventArgs> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<EventArgs> value = (EventHandler<EventArgs>)Delegate.Combine(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs>>(ref this.a, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06001783 RID: 6019 RVA: 0x000770D0 File Offset: 0x000752D0
	[CompilerGenerated]
	public void akk(EventHandler<EventArgs> A_0)
	{
		EventHandler<EventArgs> eventHandler = this.a;
		EventHandler<EventArgs> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<EventArgs> value = (EventHandler<EventArgs>)Delegate.Remove(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs>>(ref this.a, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06001784 RID: 6020 RVA: 0x00077108 File Offset: 0x00075308
	public virtual bool abf()
	{
		return false;
	}

	// Token: 0x06001785 RID: 6021 RVA: 0x0007710C File Offset: 0x0007530C
	public virtual bool abg()
	{
		return false;
	}

	// Token: 0x06001786 RID: 6022 RVA: 0x00077110 File Offset: 0x00075310
	public virtual bool abh()
	{
		return false;
	}

	// Token: 0x06001787 RID: 6023 RVA: 0x00077114 File Offset: 0x00075314
	public virtual bool akl()
	{
		return false;
	}

	// Token: 0x06001788 RID: 6024 RVA: 0x00077118 File Offset: 0x00075318
	public virtual bool akm()
	{
		return false;
	}

	// Token: 0x06001789 RID: 6025
	public abstract void abi(cte A_0, TimeSpan A_1, TimeSpan A_2);

	// Token: 0x0600178A RID: 6026 RVA: 0x0007711C File Offset: 0x0007531C
	public virtual void age(cte A_0, TimeSpan A_1, TimeSpan A_2)
	{
	}

	// Token: 0x0600178B RID: 6027 RVA: 0x00077120 File Offset: 0x00075320
	public virtual void akn(cte A_0, ak1 A_1)
	{
	}

	// Token: 0x0600178C RID: 6028 RVA: 0x00077124 File Offset: 0x00075324
	public virtual void abj(cte A_0, b0b A_1)
	{
	}

	// Token: 0x0600178D RID: 6029 RVA: 0x00077128 File Offset: 0x00075328
	public virtual void agf(cte A_0, TimeSpan A_1, TimeSpan A_2)
	{
	}

	// Token: 0x0600178E RID: 6030 RVA: 0x0007712C File Offset: 0x0007532C
	public virtual void ako(cte A_0)
	{
	}

	// Token: 0x0600178F RID: 6031 RVA: 0x00077130 File Offset: 0x00075330
	public virtual void akp(cte A_0, ak1 A_1)
	{
	}

	// Token: 0x06001790 RID: 6032 RVA: 0x00077134 File Offset: 0x00075334
	public virtual void akq(cte A_0, b0b A_1)
	{
	}

	// Token: 0x06001791 RID: 6033 RVA: 0x00077138 File Offset: 0x00075338
	public virtual void akr(cte A_0)
	{
	}

	// Token: 0x06001792 RID: 6034 RVA: 0x0007713C File Offset: 0x0007533C
	public virtual void aks(cte A_0)
	{
	}

	// Token: 0x06001793 RID: 6035 RVA: 0x00077140 File Offset: 0x00075340
	public virtual void akt(cte A_0)
	{
	}

	// Token: 0x06001794 RID: 6036 RVA: 0x00077144 File Offset: 0x00075344
	protected void a()
	{
		if (this.a != null)
		{
			this.a(this, new EventArgs());
		}
	}

	// Token: 0x04000E05 RID: 3589
	[CompilerGenerated]
	private EventHandler<EventArgs> a;
}
