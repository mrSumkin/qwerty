using System;
using System.Diagnostics;

// Token: 0x02002145 RID: 8517
[s3("1.1.2.1_ShootingSpreeAsAbilityChange", "1.1.2.1")]
public sealed class dq : cwo
{
	// Token: 0x0600C8CF RID: 51407 RVA: 0x0046DDAC File Offset: 0x0046BFAC
	public bool ee(cyt A_0)
	{
		try
		{
			if (A_0.v() != null && A_0.v().Feats.Contains<elj>() && !A_0.v().SpecialAbilities.a(typeof(bcq)))
			{
				A_0.v().SpecialAbilities.b(dgk.Get<bcq>());
			}
			return true;
		}
		catch (Exception ex)
		{
			Trace.WriteLine(ex.ToString());
		}
		return false;
	}
}
