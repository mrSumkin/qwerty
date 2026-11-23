using System;

// Token: 0x0200200F RID: 8207
public sealed class efq : ant, ta
{
	// Token: 0x0600C1ED RID: 49645 RVA: 0x00433124 File Offset: 0x00431324
	protected override bool ln()
	{
		return base.c().Defense.i4();
	}

	// Token: 0x0600C1EE RID: 49646 RVA: 0x0043313C File Offset: 0x0043133C
	public override bool zd()
	{
		return base.c().Gear.h().Item != null;
	}

	// Token: 0x0600C1EF RID: 49647 RVA: 0x00433164 File Offset: 0x00431364
	public override void ze(bool A_0)
	{
	}

	// Token: 0x0600C1F0 RID: 49648 RVA: 0x00433168 File Offset: 0x00431368
	protected override coh lo()
	{
		return base.c().Gear.h().Item;
	}

	// Token: 0x0600C1F1 RID: 49649 RVA: 0x0043318C File Offset: 0x0043138C
	protected override ip as1()
	{
		return base.c().Cooldowns.b(d7f.d);
	}

	// Token: 0x0600C1F2 RID: 49650 RVA: 0x004331A4 File Offset: 0x004313A4
	protected override bool lp()
	{
		return !base.c().IsInControl;
	}

	// Token: 0x0600C1F3 RID: 49651 RVA: 0x004331B8 File Offset: 0x004313B8
	coh ta.a()
	{
		return base.c().Gear.h().Item;
	}

	// Token: 0x0600C1F4 RID: 49652 RVA: 0x004331DC File Offset: 0x004313DC
	bool ta.b()
	{
		return true;
	}

	// Token: 0x0600C1F5 RID: 49653 RVA: 0x004331E0 File Offset: 0x004313E0
	public efq(efk A_0) : base(A_0)
	{
	}

	// Token: 0x0600C1F6 RID: 49654 RVA: 0x004331EC File Offset: 0x004313EC
	public efq(efk A_0, esj A_1, esj A_2) : base(A_0, A_1, A_2)
	{
	}

	// Token: 0x0600C1F7 RID: 49655 RVA: 0x004331FC File Offset: 0x004313FC
	protected override void lq(object A_0, b25 A_1)
	{
		base.lq(A_0, A_1);
		if (d4f.b())
		{
			if (A_1.b() == eoo.b)
			{
				ta ta = A_0 as ta;
				if (ta != null && ta.zf())
				{
					d4f.b(ta);
					return;
				}
			}
			else if (A_1.b() == eoo.d)
			{
				d4f.a();
				return;
			}
		}
		else if (A_1.b() == eoo.b)
		{
			try
			{
				if (base.c().Cooldowns.b(d7f.d) == null && base.c().IsInControl && base.c().Vehicle == null)
				{
					base.c().Defense.a(!base.c().Defense.i4());
				}
			}
			catch
			{
			}
		}
	}
}
