using System;

// Token: 0x020021DC RID: 8668
[dp2("1.0.1.13_NewStandardArmorVariations", "1.0.1.13")]
public sealed class bg8 : dnv
{
	// Token: 0x0600CA0F RID: 51727 RVA: 0x0047848C File Offset: 0x0047668C
	public bool eq(bk3 A_0)
	{
		c43 c = A_0 as c43;
		if (c != null && A_0.a3() != null)
		{
			if (A_0.a3().Contains(".Siphoner") || A_0.a3().Contains(".InfusedSiphoner"))
			{
				c.a("siple");
			}
			else if (A_0.a3().Contains(".AncientRathound") || A_0.a3().Contains(".InfusedAncientRathound"))
			{
				c.a("arhl");
			}
			else if (A_0.a3().StartsWith("Armor.Metal.SuperSteel"))
			{
				c.a("mt_ss");
			}
		}
		return true;
	}

	// Token: 0x0600CA10 RID: 51728 RVA: 0x00478548 File Offset: 0x00476748
	public bool er(coh A_0)
	{
		return true;
	}
}
