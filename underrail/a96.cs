using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using Microsoft.Xna.Framework;
using Ouroboros.Events;
using TimelapseVertigo.Common;
using TimelapseVertigo.Common.Settings;

// Token: 0x0200055B RID: 1371
public sealed class a96 : GlobalEventHandler<c47>, aha
{
	// Token: 0x06002316 RID: 8982 RVA: 0x000C0B50 File Offset: 0x000BED50
	public Dictionary<string, yj> c()
	{
		return this.a;
	}

	// Token: 0x06002317 RID: 8983 RVA: 0x000C0B58 File Offset: 0x000BED58
	public int v6()
	{
		return this.b;
	}

	// Token: 0x06002318 RID: 8984 RVA: 0x000C0B60 File Offset: 0x000BED60
	public void v7(int A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06002319 RID: 8985 RVA: 0x000C0B6C File Offset: 0x000BED6C
	public int e()
	{
		return this.c;
	}

	// Token: 0x0600231A RID: 8986 RVA: 0x000C0B74 File Offset: 0x000BED74
	public void a(int A_0)
	{
		this.c = A_0;
	}

	// Token: 0x0600231B RID: 8987 RVA: 0x000C0B80 File Offset: 0x000BED80
	public string v8()
	{
		return this.d;
	}

	// Token: 0x0600231C RID: 8988 RVA: 0x000C0B88 File Offset: 0x000BED88
	public void v9(string A_0)
	{
		this.d = A_0;
	}

	// Token: 0x0600231D RID: 8989 RVA: 0x000C0B94 File Offset: 0x000BED94
	[CompilerGenerated]
	public void wa(EventHandler<an8> A_0)
	{
		EventHandler<an8> eventHandler = this.e;
		EventHandler<an8> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<an8> value = (EventHandler<an8>)Delegate.Combine(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<an8>>(ref this.e, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x0600231E RID: 8990 RVA: 0x000C0BCC File Offset: 0x000BEDCC
	[CompilerGenerated]
	public void wb(EventHandler<an8> A_0)
	{
		EventHandler<an8> eventHandler = this.e;
		EventHandler<an8> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<an8> value = (EventHandler<an8>)Delegate.Remove(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<an8>>(ref this.e, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x0600231F RID: 8991 RVA: 0x000C0C04 File Offset: 0x000BEE04
	public a96()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		this.d = this.wc(serviceOrThrow.aq1().b().p());
	}

	// Token: 0x06002320 RID: 8992 RVA: 0x000C0C58 File Offset: 0x000BEE58
	public string wc(InterfaceElementSize2 A_0)
	{
		if (A_0 == InterfaceElementSize2.Huge)
		{
			return egg.a4;
		}
		if (A_0 == InterfaceElementSize2.ExtraLarge)
		{
			return egg.au;
		}
		if (A_0 == InterfaceElementSize2.Large)
		{
			return egg.am;
		}
		return egg.ad;
	}

	// Token: 0x06002321 RID: 8993 RVA: 0x000C0C8C File Offset: 0x000BEE8C
	public void wd()
	{
		foreach (yj yj in this.a.Values)
		{
			yj.d().Clear();
			foreach (dl6 dl in yj.a())
			{
				foreach (bph bph in dl.a)
				{
					bph.a = new d22(this.v8(), bph.a.b);
				}
			}
			ecs ecs = Enumerable.FirstOrDefault<ecs>(new ecs(yj.a()).a(this.b, 0));
			yj.d().AddRange(ecs.a);
			if (yj.d().Count > this.c)
			{
				yj.d().RemoveRange(0, yj.d().Count - this.c);
			}
			if (yj.a().Count > this.c * 3)
			{
				yj.a().RemoveRange(0, yj.a().Count - this.c * 3);
			}
		}
	}

	// Token: 0x06002322 RID: 8994 RVA: 0x000C0E50 File Offset: 0x000BF050
	public void d()
	{
		bpo.GetServiceOrThrow<eta>().RegisterHandler<c47>(this);
		this.a();
	}

	// Token: 0x06002323 RID: 8995 RVA: 0x000C0E64 File Offset: 0x000BF064
	public void b()
	{
		bpo.GetServiceOrThrow<eta>().UnregisterHandler<c47>(this);
	}

	// Token: 0x06002324 RID: 8996 RVA: 0x000C0E74 File Offset: 0x000BF074
	public override void cr(c47 A_0)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		b2h b2h = A_0 as b2h;
		if (b2h != null)
		{
			eyx eyx = A_0 as eyx;
			if (eyx != null)
			{
				if (eyx.j().a(serviceOrThrow.aqw()))
				{
					this.a(b2h);
					return;
				}
			}
			else
			{
				this.a(b2h);
			}
		}
	}

	// Token: 0x06002325 RID: 8997 RVA: 0x000C0EC8 File Offset: 0x000BF0C8
	public yj we(string A_0)
	{
		czh.a(A_0, "feedId");
		yj result = null;
		this.a.TryGetValue(A_0, out result);
		return result;
	}

	// Token: 0x06002326 RID: 8998 RVA: 0x000C0EF4 File Offset: 0x000BF0F4
	private void a()
	{
		this.a.Add(TimelapseTextFeeds.Combat.ToString(), new yj(TimelapseTextFeeds.Combat.ToString()));
		this.a.Add(TimelapseTextFeeds.Chat.ToString(), new yj(TimelapseTextFeeds.Chat.ToString()));
	}

	// Token: 0x06002327 RID: 8999 RVA: 0x000C0F60 File Offset: 0x000BF160
	private void a(b2h A_0)
	{
		List<string> list = A_0.b();
		if (list != null && list.Count > 0)
		{
			ecs ecs = A_0.se();
			if (ecs == null || ecs.a == null || ecs.a.Count == 0)
			{
				return;
			}
			foreach (dl6 dl in ecs.a)
			{
				foreach (bph bph in dl.a)
				{
					bph.a = new d22(this.v8(), bph.a.b);
				}
			}
			ecs ecs2 = Enumerable.FirstOrDefault<ecs>(ecs.a(this.b, 0));
			if (ecs2 == null)
			{
				return;
			}
			foreach (string text in list)
			{
				if (text != null)
				{
					yj yj;
					this.a.TryGetValue(text, out yj);
					if (yj != null)
					{
						if (A_0.a() && yj.d().Count > 0 && !yj.d()[yj.d().Count - 1].a())
						{
							this.a(yj);
						}
						yj.a().AddRange(ecs.a);
						foreach (dl6 item in ecs2.a)
						{
							yj.d().Add(item);
						}
						if (A_0.a())
						{
							this.a(yj);
						}
						if (yj.d().Count > this.c)
						{
							yj.d().RemoveRange(0, yj.d().Count - this.c);
						}
						if (yj.a().Count > this.c * 3)
						{
							yj.a().RemoveRange(0, yj.a().Count - this.c * 3);
						}
						if (this.e != null)
						{
							this.e(this, new an8(yj.b()));
						}
					}
				}
			}
		}
	}

	// Token: 0x06002328 RID: 9000 RVA: 0x000C1254 File Offset: 0x000BF454
	private void a(yj A_0)
	{
		dl6 item = new dl6(new List<bph>
		{
			new bph(new d22(this.v8(), Color.White), null, null)
		});
		A_0.d().Add(item);
		dl6 item2 = new dl6(new List<bph>
		{
			new bph(new d22(this.v8(), Color.White), null, null)
		});
		A_0.a().Add(item2);
	}

	// Token: 0x040014A2 RID: 5282
	private Dictionary<string, yj> a = new Dictionary<string, yj>();

	// Token: 0x040014A3 RID: 5283
	private int b = 380;

	// Token: 0x040014A4 RID: 5284
	private int c = 100;

	// Token: 0x040014A5 RID: 5285
	private string d;

	// Token: 0x040014A6 RID: 5286
	[CompilerGenerated]
	private EventHandler<an8> e;
}
