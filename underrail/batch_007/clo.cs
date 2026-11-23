using System;

// Token: 0x02000351 RID: 849
public sealed class clo : t7
{
	// Token: 0x06001814 RID: 6164 RVA: 0x00079BC0 File Offset: 0x00077DC0
	protected override cst ip()
	{
		efk efk = base.b().g().aa();
		if (!efk.Dead && efk.IsInControl)
		{
			amc amc = new bzv(base.b().c().y6()).g();
			if (amc != null && cgh.a(amc, base.b().c()))
			{
				return base.b().c().a8().h.b.b(amc);
			}
		}
		return null;
	}
}
