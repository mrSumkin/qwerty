using System;
using System.Diagnostics;

// Token: 0x02002174 RID: 8564
[bmq("1.0.4.16_ArleneMerchantAspect", "1.0.4.16", "StationAlpha-Level3", false)]
public sealed class die : fg
{
	// Token: 0x0600C932 RID: 51506 RVA: 0x00471558 File Offset: 0x0046F758
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			c5x c5x = new ar7(new Guid("83cd7a34-f8e8-461d-af96-e3ac9622b1bc"), A_1.n("l5")).ao() as c5x;
			if (c5x != null && c5x.GetAspect<dvp>() == null)
			{
				dvp dvp = new dvp(c5x);
				c5x.SetAspect<dvp>(dvp);
				dvp.b("sgs_arlene");
				dvp.aqc(false);
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
