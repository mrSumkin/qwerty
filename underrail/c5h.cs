using System;

// Token: 0x02000177 RID: 375
public abstract class c5h : cs9
{
	// Token: 0x060009B7 RID: 2487 RVA: 0x000280F8 File Offset: 0x000262F8
	public dak h()
	{
		return this.c;
	}

	// Token: 0x060009B8 RID: 2488 RVA: 0x00028100 File Offset: 0x00026300
	public dak f()
	{
		return this.d;
	}

	// Token: 0x060009B9 RID: 2489 RVA: 0x00028108 File Offset: 0x00026308
	protected bool g()
	{
		return this.e;
	}

	// Token: 0x060009BA RID: 2490 RVA: 0x00028114 File Offset: 0x00026314
	protected c5h()
	{
		this.a = new dak();
		this.a.IsPrivateComponent = true;
		this.a.b(new EventHandler<b25>(this.a));
		this.a.PropagateMouseScrollEvent = true;
		this.b = new dak();
		this.b.IsPrivateComponent = true;
		this.b.b(new EventHandler<b25>(this.b));
		this.b.PropagateMouseScrollEvent = true;
		this.c = new dak();
		this.c.IsPrivateComponent = true;
		this.c.PropagateMouseScrollEvent = true;
		this.d = new dak();
		this.d.IsPrivateComponent = true;
		this.d.m(new EventHandler<b25>(this.c));
		this.d.s(new EventHandler<b25>(this.jp));
		this.d.PropagateMouseScrollEvent = true;
		this.aox(this.a);
		this.aox(this.b);
		this.aox(this.c);
		this.aox(this.d);
	}

	// Token: 0x060009BB RID: 2491 RVA: 0x00028244 File Offset: 0x00026444
	protected override void jq(object A_0, c1 A_1)
	{
		base.jq(A_0, A_1);
		this.ju();
	}

	// Token: 0x060009BC RID: 2492 RVA: 0x00028254 File Offset: 0x00026454
	protected override void jr(object A_0, c1 A_1)
	{
		base.jr(A_0, A_1);
		this.ju();
	}

	// Token: 0x060009BD RID: 2493 RVA: 0x00028264 File Offset: 0x00026464
	protected override void js(object A_0, c1 A_1)
	{
		base.js(A_0, A_1);
		this.ju();
	}

	// Token: 0x060009BE RID: 2494 RVA: 0x00028274 File Offset: 0x00026474
	protected override void jt(object A_0, c1 A_1)
	{
		base.jt(A_0, A_1);
		this.ju();
	}

	// Token: 0x060009BF RID: 2495 RVA: 0x00028284 File Offset: 0x00026484
	protected virtual void jp(object A_0, b25 A_1)
	{
		this.e = false;
	}

	// Token: 0x060009C0 RID: 2496 RVA: 0x00028290 File Offset: 0x00026490
	private void c(object A_0, b25 A_1)
	{
		this.e = true;
	}

	// Token: 0x060009C1 RID: 2497 RVA: 0x0002829C File Offset: 0x0002649C
	private void b(object A_0, b25 A_1)
	{
		base.b(true);
	}

	// Token: 0x060009C2 RID: 2498 RVA: 0x000282A8 File Offset: 0x000264A8
	private void a(object A_0, b25 A_1)
	{
		base.b(false);
	}

	// Token: 0x060009C3 RID: 2499 RVA: 0x000282B4 File Offset: 0x000264B4
	protected override void it(object A_0, b25 A_1)
	{
		base.e(base.l() - base.m() * Math.Sign(A_1.c()));
	}

	// Token: 0x060009C4 RID: 2500
	protected abstract void ju();

	// Token: 0x0400062F RID: 1583
	protected new dak a;

	// Token: 0x04000630 RID: 1584
	protected new dak b;

	// Token: 0x04000631 RID: 1585
	protected new dak c;

	// Token: 0x04000632 RID: 1586
	protected new dak d;

	// Token: 0x04000633 RID: 1587
	private new bool e;
}
