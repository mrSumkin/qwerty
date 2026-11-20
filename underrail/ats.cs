using System;
using System.Diagnostics;

// Token: 0x02002156 RID: 8534
[bmq("1.1.0.15_Cc_WarehouseCorpseModelChange", "1.1.0.15", "cc_warehouse", false)]
public sealed class ats : fg
{
	// Token: 0x0600C8F8 RID: 51448 RVA: 0x0046FAE0 File Offset: 0x0046DCE0
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			foreach (b0b b0b in A_1.n("cc_warehouse").Entities)
			{
				c5x c5x = (c5x)b0b;
				if (!c5x.y8().Contains("Mercenary") && c5x.o.b != null && c5x.o.b.a.StartsWith("Creatures\\ag"))
				{
					if (c5x.o.b.a.StartsWith("Creatures\\ag_f"))
					{
						c5x.o.b.a = "Creatures\\crtec_f1\\di";
					}
					else if (cuo.a.Next(0, 101) > 50)
					{
						c5x.o.b.a = "Creatures\\crtec1\\di";
					}
					else
					{
						c5x.o.b.a = "Creatures\\crtec2\\di";
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
