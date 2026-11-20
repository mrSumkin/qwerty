using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;

// Token: 0x0200122A RID: 4650
public sealed class u9 : a1d
{
	// Token: 0x0600643B RID: 25659 RVA: 0x002B12F4 File Offset: 0x002AF4F4
	public override string md()
	{
		return "acl";
	}

	// Token: 0x0600643C RID: 25660 RVA: 0x002B12FC File Offset: 0x002AF4FC
	public override string me()
	{
		return "Xpbl_LeakingAcidBarrel";
	}

	// Token: 0x0600643D RID: 25661 RVA: 0x002B1308 File Offset: 0x002AF508
	protected override cd1 mf(efk A_0)
	{
		cd1 cd = euf.a();
		cd.TypedDefinition.aa().Add(new edm("SpewAcid", 1.0, 1, true));
		cd.TypedDefinition.aa().Add(new edm("acid", 1.0, 50, true));
		return cd;
	}

	// Token: 0x0600643E RID: 25662 RVA: 0x002B1368 File Offset: 0x002AF568
	public override void mg(c5x A_0)
	{
		if (A_0 != null && A_0.Area != null && this.a(A_0.h.b, 1))
		{
			Point a_ = A_0.aj().a();
			ak1 ak = A_0.Area.a(a_);
			if (ak != null)
			{
				new dku(new edx(ak), null, true, false, false).ym(null, null, null);
			}
		}
	}

	// Token: 0x0600643F RID: 25663 RVA: 0x002B13D4 File Offset: 0x002AF5D4
	public override void mh(amc A_0)
	{
		if (A_0 != null && A_0.a8() != null && this.a(A_0, 3))
		{
			Point a_ = A_0.a8().aj().a();
			ak1 ak = A_0.a8().Area.a(a_);
			if (ak != null)
			{
				new dku(new edx(ak), null, true, true, false).ym(null, null, null);
			}
		}
	}

	// Token: 0x06006440 RID: 25664 RVA: 0x002B1440 File Offset: 0x002AF640
	public override Dictionary<string, app> mi(amc A_0)
	{
		if (this.a(A_0))
		{
			Dictionary<string, app> dictionary = new Dictionary<string, app>();
			string key = "leak";
			app app = new app();
			app.a("xpbl_AcidLeak");
			app.b(true);
			app.a(c9z.b);
			dictionary[key] = app;
			return dictionary;
		}
		return null;
	}

	// Token: 0x06006441 RID: 25665 RVA: 0x002B148C File Offset: 0x002AF68C
	protected override string mj()
	{
		return "Xpbl_LeakingAcidBarrel";
	}

	// Token: 0x06006442 RID: 25666 RVA: 0x002B1494 File Offset: 0x002AF694
	private bool a(amc A_0)
	{
		return A_0.aa().CustomProperties.GetPrimitivePropertyValue<int>(ddm.k, new int?(30)).Value > 0;
	}

	// Token: 0x06006443 RID: 25667 RVA: 0x002B14D0 File Offset: 0x002AF6D0
	private bool a(amc A_0, int A_1)
	{
		if (A_0 != null)
		{
			int num = A_0.aa().CustomProperties.GetPrimitivePropertyValue<int>(ddm.k, new int?(30)).Value;
			if (num > 0)
			{
				num = Math.Max(0, num - A_1);
				A_0.aa().CustomProperties[ddm.k] = num;
				return true;
			}
		}
		return false;
	}
}
