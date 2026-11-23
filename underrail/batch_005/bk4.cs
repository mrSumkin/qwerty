using System;
using System.Diagnostics;
using TimelapseVertigo.Rules.Items;

// Token: 0x02002185 RID: 8581
[bmq("1.0.3.24_AddWorkerArmors", "1.0.3.24", "*", true)]
public sealed class bk4 : fg
{
	// Token: 0x0600C95B RID: 51547 RVA: 0x004725A8 File Offset: 0x004707A8
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			foreach (aud aud in A_1.Areas)
			{
				foreach (b0b b0b in aud.Entities)
				{
					c5x c5x = (c5x)b0b;
					amc amc;
					if (c5x.h != null)
					{
						amc = c5x.h.b;
					}
					else
					{
						amc = c5x.GetAspect<amc>();
					}
					if (amc != null && (amc.am() == bln.ac || amc.am() == bln.ad || amc.am() == bln.ae || amc.am() == bln.af) && amc.aa().Gear.l().Item == null)
					{
						amc.aa().Gear.l().a(new c8d(new LibraryItemDefinitionProvider<c43>("Armor\\WorkerSuit")), true);
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
