using System;
using System.Diagnostics;

// Token: 0x0200219C RID: 8604
[bmq("1.0.1.5_Lu_b29Bandit", "1.0.1.5", "lu-b29", false)]
public sealed class aze : fg
{
	// Token: 0x0600C98C RID: 51596 RVA: 0x00474504 File Offset: 0x00472704
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			c5x c5x = new ar7(new Guid("8865b6de-0ddb-46f1-8ccc-4ac7034d913c"), A_1.n("lu-b29")).ao() as c5x;
			if (c5x != null && c5x.y8() != "Bandit")
			{
				c5x.q("Bandit");
				amc aspect = c5x.GetAspect<amc>();
				if (aspect != null)
				{
					aspect.aa().Name = "Bandit";
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
