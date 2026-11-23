using System;
using System.Diagnostics;

// Token: 0x020020FF RID: 8447
[bmq("1.0.3.4_Cc_S5_LubensCorpseFix", "1.0.3.4", "cc_s5", false)]
public sealed class ev6 : fg
{
	// Token: 0x0600C84B RID: 51275 RVA: 0x00469DE8 File Offset: 0x00467FE8
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			c5x c5x = new ar7(new Guid("2c396701-f839-4285-9bb2-3cdb35d74cb4"), A_1.n("lux-b9")).ao() as c5x;
			if (c5x != null && !A_0.r().GetPrimitivePropertyValue<bool>("npc_cc_luben_escaped", new bool?(false)).Value)
			{
				c5x.w();
				c5x.an();
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
