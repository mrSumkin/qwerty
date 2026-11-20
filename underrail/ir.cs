using System;
using System.Diagnostics;

// Token: 0x02002159 RID: 8537
[bmq("1.1.0.15_Cc_s6_CornellModelChange", "1.1.0.15", "cc_s6", false)]
public sealed class ir : fg
{
	// Token: 0x0600C8FE RID: 51454 RVA: 0x0046FFB4 File Offset: 0x0046E1B4
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			c5x c5x = new ar7(new Guid("2ec4fc90-d6aa-45ef-bdea-24cec633aa51"), A_1.n("cc_s6c2")).ao() as c5x;
			if (c5x != null)
			{
				amc aspect = c5x.GetAspect<amc>();
				if (aspect != null)
				{
					aspect.a(bln.ct);
				}
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
