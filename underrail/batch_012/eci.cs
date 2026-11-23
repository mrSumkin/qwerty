using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;

// Token: 0x02001227 RID: 4647
public sealed class eci : ang
{
	// Token: 0x06006421 RID: 25633 RVA: 0x002B0C3C File Offset: 0x002AEE3C
	public override string md()
	{
		return "bobl";
	}

	// Token: 0x06006422 RID: 25634 RVA: 0x002B0C44 File Offset: 0x002AEE44
	public override string me()
	{
		return "LeakingBlackOilBarrel";
	}

	// Token: 0x06006423 RID: 25635 RVA: 0x002B0C50 File Offset: 0x002AEE50
	public override void mg(c5x A_0)
	{
		if (A_0 != null && A_0.Area != null && this.a(A_0.h.b, 1))
		{
			Point a_ = A_0.aj().a();
			ak1 ak = A_0.Area.a(a_);
			if (ak != null)
			{
				new e3d(new edx(ak), null, true, false).ym(null, null, null);
			}
		}
	}

	// Token: 0x06006424 RID: 25636 RVA: 0x002B0CBC File Offset: 0x002AEEBC
	public override void mh(amc A_0)
	{
		if (A_0 != null && A_0.a8() != null && this.a(A_0, 3))
		{
			Point a_ = A_0.a8().aj().a();
			ak1 ak = A_0.a8().Area.a(a_);
			if (ak != null)
			{
				new e3d(new edx(ak), null, true, true).ym(null, null, null);
			}
		}
	}

	// Token: 0x06006425 RID: 25637 RVA: 0x002B0D28 File Offset: 0x002AEF28
	public override Dictionary<string, app> mi(amc A_0)
	{
		if (this.a(A_0))
		{
			Dictionary<string, app> dictionary = new Dictionary<string, app>();
			string key = "leak";
			app app = new app();
			app.a("BlackOilLeak");
			app.b(true);
			app.a(c9z.b);
			dictionary[key] = app;
			return dictionary;
		}
		return null;
	}

	// Token: 0x06006426 RID: 25638 RVA: 0x002B0D74 File Offset: 0x002AEF74
	public override void qr(amc A_0, amc A_1, cwt A_2, cru A_3)
	{
		base.qr(A_0, A_1, A_2, A_3);
		if (A_0 != null && A_1 != null && A_1.a8() != null && A_1.a8().Area != null && this.a(A_0, 3))
		{
			Point a_ = A_1.a8().aj().a();
			ak1 ak = A_1.a8().Area.a(a_);
			if (ak != null)
			{
				new e3d(new edx(ak), null, true, true).ym(null, null, null);
			}
		}
	}

	// Token: 0x06006427 RID: 25639 RVA: 0x002B0E00 File Offset: 0x002AF000
	protected override string qu()
	{
		return "LeakingBlackOilBarrel";
	}

	// Token: 0x06006428 RID: 25640 RVA: 0x002B0E0C File Offset: 0x002AF00C
	private bool a(amc A_0)
	{
		return A_0.aa().CustomProperties.GetPrimitivePropertyValue<int>(ddm.k, new int?(30)).Value > 0;
	}

	// Token: 0x06006429 RID: 25641 RVA: 0x002B0E48 File Offset: 0x002AF048
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
