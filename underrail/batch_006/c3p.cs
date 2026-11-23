using System;

// Token: 0x02002011 RID: 8209
public sealed class c3p : bbk
{
	// Token: 0x0600C202 RID: 49666 RVA: 0x00433570 File Offset: 0x00431770
	private new void a(object A_0, c1 A_1)
	{
		this.wt();
	}

	// Token: 0x0600C203 RID: 49667 RVA: 0x00433578 File Offset: 0x00431778
	protected override void vb()
	{
		e3q e3q = base.k();
		if (e3q != null)
		{
			e3q e3q2 = e3q;
			int num = e3q2.g();
			e3q2.b(num - 1);
			base.vb();
		}
	}

	// Token: 0x0600C204 RID: 49668 RVA: 0x004335A8 File Offset: 0x004317A8
	protected override void vc()
	{
		e3q e3q = base.k();
		if (e3q != null)
		{
			e3q e3q2 = e3q;
			int num = e3q2.g();
			e3q2.b(num + 1);
			base.vc();
		}
	}

	// Token: 0x170002CC RID: 716
	// (get) Token: 0x0600C205 RID: 49669 RVA: 0x004335D8 File Offset: 0x004317D8
	protected override bool AllowIncrement
	{
		get
		{
			return this.a();
		}
	}

	// Token: 0x0600C206 RID: 49670 RVA: 0x004335E0 File Offset: 0x004317E0
	protected override void ve()
	{
		base.ve();
		if (base.j() != null)
		{
			e3q e3q = base.k();
			if (e3q != null)
			{
				this.a = new EventHandler<c1>(this.a);
				e3q.d(this.a);
			}
		}
	}

	// Token: 0x0600C207 RID: 49671 RVA: 0x0043362C File Offset: 0x0043182C
	protected override void vf()
	{
		base.vf();
		if (base.j() != null)
		{
			e3q e3q = base.k();
			if (this.a != null && this.a != null)
			{
				e3q.a(this.a);
			}
		}
	}

	// Token: 0x0600C208 RID: 49672 RVA: 0x00433674 File Offset: 0x00431874
	private new bool a()
	{
		e3q e3q = base.k();
		if (e3q == null)
		{
			return false;
		}
		if (base.j() is av8 && e3q.b(d8o.t))
		{
			return false;
		}
		int num;
		if (base.j().e().re().Level == 1)
		{
			num = aiy.x;
		}
		else
		{
			num = 99;
		}
		return base.j().f() < num && e3q.g() > 0;
	}

	// Token: 0x04004639 RID: 17977
	private new EventHandler<c1> a;
}
