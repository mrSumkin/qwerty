using System;

// Token: 0x02001FEC RID: 8172
public sealed class a53 : bbk
{
	// Token: 0x0600C005 RID: 49157 RVA: 0x00429450 File Offset: 0x00427650
	private new void b(object A_0, c1 A_1)
	{
		this.wt();
	}

	// Token: 0x0600C006 RID: 49158 RVA: 0x00429458 File Offset: 0x00427658
	private new void a(object A_0, c1 A_1)
	{
		this.wt();
	}

	// Token: 0x0600C008 RID: 49160 RVA: 0x00429468 File Offset: 0x00427668
	protected override void vb()
	{
		e3q e3q = base.k();
		if (e3q != null)
		{
			e3q e3q2 = e3q;
			int num = e3q2.f();
			e3q2.a(num - 1);
			base.vb();
		}
	}

	// Token: 0x0600C009 RID: 49161 RVA: 0x00429498 File Offset: 0x00427698
	protected override void vc()
	{
		e3q e3q = base.k();
		if (e3q != null)
		{
			e3q e3q2 = e3q;
			int num = e3q2.f();
			e3q2.a(num + 1);
			base.vc();
		}
	}

	// Token: 0x170002BC RID: 700
	// (get) Token: 0x0600C00A RID: 49162 RVA: 0x004294C8 File Offset: 0x004276C8
	protected override bool AllowIncrement
	{
		get
		{
			return this.a();
		}
	}

	// Token: 0x0600C00B RID: 49163 RVA: 0x004294D0 File Offset: 0x004276D0
	protected override void ve()
	{
		base.ve();
		if (base.j() != null)
		{
			base.j().c(new EventHandler<c1>(this.a));
			e3q e3q = base.k();
			if (e3q != null)
			{
				e3q.g(new EventHandler<c1>(this.b));
			}
		}
	}

	// Token: 0x0600C00C RID: 49164 RVA: 0x00429524 File Offset: 0x00427724
	protected override void vf()
	{
		base.vf();
		if (base.j() != null)
		{
			base.j().d(new EventHandler<c1>(this.a));
			e3q e3q = base.k();
			if (e3q != null)
			{
				e3q.h(new EventHandler<c1>(this.b));
			}
		}
	}

	// Token: 0x0600C00D RID: 49165 RVA: 0x00429578 File Offset: 0x00427778
	private new bool a()
	{
		e3q e3q = base.k();
		return e3q != null && (e3q.f() > 0 && base.j().f() < apq.a(e3q.Level)) && (base.j().atw() == null || base.j().f() < base.j().atw().Value);
	}
}
