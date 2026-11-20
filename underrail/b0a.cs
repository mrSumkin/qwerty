using System;
using Microsoft.Xna.Framework;

// Token: 0x02002020 RID: 8224
public sealed class b0a : bbk
{
	// Token: 0x0600C2AC RID: 49836 RVA: 0x004364F8 File Offset: 0x004346F8
	private new void b(object A_0, c1 A_1)
	{
		this.wt();
	}

	// Token: 0x0600C2AD RID: 49837 RVA: 0x00436500 File Offset: 0x00434700
	private new void a(object A_0, c1 A_1)
	{
		this.wt();
	}

	// Token: 0x0600C2AE RID: 49838 RVA: 0x00436508 File Offset: 0x00434708
	public override void ag5(e6d A_0)
	{
		base.ag5(A_0);
		csn csn = base.j() as csn;
		if (csn != null && csn.c)
		{
			base.b(Color.Yellow);
			base.a(Color.Black);
			return;
		}
		base.b(Color.White);
		base.a(Color.Black);
	}

	// Token: 0x0600C2AF RID: 49839 RVA: 0x00436568 File Offset: 0x00434768
	protected override void vb()
	{
		e3q e3q = base.k();
		if (e3q != null)
		{
			e3q e3q2 = e3q;
			int num = e3q2.h();
			e3q2.d(num - 1);
			base.vb();
		}
	}

	// Token: 0x0600C2B0 RID: 49840 RVA: 0x00436598 File Offset: 0x00434798
	protected override void vc()
	{
		e3q e3q = base.k();
		if (e3q != null)
		{
			e3q e3q2 = e3q;
			int num = e3q2.h();
			e3q2.d(num + 1);
			base.vc();
		}
	}

	// Token: 0x0600C2B1 RID: 49841 RVA: 0x004365C8 File Offset: 0x004347C8
	protected override bool vd()
	{
		return this.a();
	}

	// Token: 0x0600C2B2 RID: 49842 RVA: 0x004365D0 File Offset: 0x004347D0
	protected override void ve()
	{
		base.ve();
		if (base.j() != null)
		{
			base.j().c(new EventHandler<c1>(this.a));
			e3q e3q = base.k();
			if (e3q != null)
			{
				e3q.b(new EventHandler<c1>(this.b));
			}
		}
	}

	// Token: 0x0600C2B3 RID: 49843 RVA: 0x00436624 File Offset: 0x00434824
	protected override void vf()
	{
		base.vf();
		if (base.j() != null)
		{
			base.j().d(new EventHandler<c1>(this.a));
			e3q e3q = base.k();
			if (e3q != null)
			{
				e3q.c(new EventHandler<c1>(this.b));
			}
		}
	}

	// Token: 0x0600C2B4 RID: 49844 RVA: 0x00436678 File Offset: 0x00434878
	private new bool a()
	{
		e3q e3q = base.k();
		return e3q != null && e3q.h() > 0 && base.j().f() < csn.a(e3q.Level);
	}
}
