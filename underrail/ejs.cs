using System;
using System.Linq;
using TimelapseVertigo.Rules.Combat;

// Token: 0x0200214F RID: 8527
[dp2("1.1.0.8_RiotGearChange", "1.1.0.8")]
public sealed class ejs : dnv
{
	// Token: 0x0600C8E4 RID: 51428 RVA: 0x0046F0C4 File Offset: 0x0046D2C4
	public bool eq(bk3 A_0)
	{
		c43 c = A_0 as c43;
		if (c != null)
		{
			string a = (c.e() ?? "").ToLowerInvariant();
			if (a == "ri" || a == "ri_c" || a == "ri_s" || a == "ri_c_s")
			{
				eey eey = Enumerable.FirstOrDefault<eey>(Enumerable.OfType<eey>(c.f()));
				if (eey != null)
				{
					eey.Bonus += 0.25;
				}
				c6o.a(c, new du2(DamageType.Mechanical, 2, 0.0));
			}
		}
		return true;
	}

	// Token: 0x0600C8E5 RID: 51429 RVA: 0x0046F17C File Offset: 0x0046D37C
	public bool er(coh A_0)
	{
		return true;
	}
}
