using System;
using System.Collections.Generic;
using System.Linq;

// Token: 0x02001224 RID: 4644
public class dtg : e5m
{
	// Token: 0x0600640A RID: 25610 RVA: 0x002B08AC File Offset: 0x002AEAAC
	public override string md()
	{
		return "pbl";
	}

	// Token: 0x0600640B RID: 25611 RVA: 0x002B08B4 File Offset: 0x002AEAB4
	public override string me()
	{
		return "Xpbl_LeakingPropaneTank";
	}

	// Token: 0x0600640C RID: 25612 RVA: 0x002B08BC File Offset: 0x002AEABC
	protected override cd1 mf(efk A_0)
	{
		return euf.a();
	}

	// Token: 0x0600640D RID: 25613 RVA: 0x002B08C4 File Offset: 0x002AEAC4
	public override Dictionary<string, app> mi(amc A_0)
	{
		Dictionary<string, app> dictionary = new Dictionary<string, app>();
		string key = "leak";
		app app = new app();
		app.a("xpbl_PropaneLeak");
		app.b(true);
		app.a(c9z.b);
		dictionary[key] = app;
		return dictionary;
	}

	// Token: 0x0600640E RID: 25614 RVA: 0x002B0900 File Offset: 0x002AEB00
	public override void q7(amc A_0, c5i A_1)
	{
		if (A_0 != null)
		{
			int a_ = 10;
			if (A_1 != null && A_1.a8() != null)
			{
				dm aspect = A_1.a8().GetAspect<dm>();
				if (aspect != null)
				{
					z7 z = Enumerable.FirstOrDefault<z7>(Enumerable.OfType<z7>(aspect.d()));
					if (z != null)
					{
						a_ = z.RemainingTicks;
					}
				}
			}
			au1 a_2 = new au1(a_);
			A_0.aa().StatusEffects.a(a_2, false, false, false);
		}
	}

	// Token: 0x0600640F RID: 25615 RVA: 0x002B0974 File Offset: 0x002AEB74
	public override void akc(amc A_0)
	{
		if (A_0 != null)
		{
			foreach (au1 a_ in A_0.aa().StatusEffects.Get<au1>())
			{
				A_0.aa().StatusEffects.d(a_);
			}
		}
	}

	// Token: 0x06006410 RID: 25616 RVA: 0x002B09E8 File Offset: 0x002AEBE8
	protected override string adj()
	{
		return "Xpbl_LeakingPropaneTank";
	}
}
