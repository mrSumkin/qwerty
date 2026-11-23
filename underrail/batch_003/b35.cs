using System;
using System.Diagnostics;

// Token: 0x0200215E RID: 8542
[bmq("1.1.0.15_RemoveToddFromCeto", "1.1.0.15", "xpbl_g2_InnerShip", false)]
public sealed class b35 : fg
{
	// Token: 0x0600C908 RID: 51464 RVA: 0x00470390 File Offset: 0x0046E590
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			if (A_0.r().GetPrimitivePropertyValue<bool>("npc_xpbl_pir_grim_metTodd", new bool?(false)).Value)
			{
				foreach (b0b b0b in A_1.n("xpbl_g2_cabine").Entities)
				{
					c5x c5x = (c5x)b0b;
					if (c5x.y8() == "Todd" && c5x.h.b != null)
					{
						c5x.w();
						c5x.an();
						break;
					}
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
