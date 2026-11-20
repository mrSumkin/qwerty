using System;
using System.Diagnostics;
using System.Linq;
using Microsoft.Xna.Framework;

// Token: 0x02002192 RID: 8594
[bmq("1.0.3.0_LostVaultEntranceChanges", "1.0.3.0", "lux-b9", false)]
public sealed class air : fg
{
	// Token: 0x0600C977 RID: 51575 RVA: 0x004737D4 File Offset: 0x004719D4
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			c5x c5x = new ar7(new Guid("47ad72a1-d392-4649-87c1-1c31b9b29705"), A_1.n("lux-b9")).ao() as c5x;
			if (c5x != null && c5x.Location != new Vector3(2f, 18.4f, 0.7f))
			{
				c5x.Location = new Vector3(2f, 18.4f, 0.7f);
				c5x.ah();
			}
			c5x c5x2 = new ar7(new Guid("d86201d0-f8b8-44a2-8335-2f5a8d741c9f"), A_1.n("lux-b9")).ao() as c5x;
			if (c5x2 != null)
			{
				d2b aspect = c5x2.GetAspect<d2b>();
				c7j c7j = c5x2.GetAspect<bim>() as c7j;
				if (aspect != null && !aspect.n() && c7j != null && Enumerable.Any<d5o>(c7j.ItemContainer.z2().a("key.lostVault_securitycard", 1)))
				{
					c5x c5x3 = new ar7(new Guid("2aea6e96-6ebd-4a52-8088-8895954292d1"), A_1.n("lux-b9")).ao() as c5x;
					c7j c7j2 = c5x3.GetAspect<bim>() as c7j;
					if (c5x3 != null && c7j2 != null)
					{
						foreach (coh coh in c7j.ItemContainer.z2())
						{
							if (coh.Definition.a5() == "key.lostVault_securitycard")
							{
								c7j2.ItemContainer.z2().Add(coh);
								c7j.ItemContainer.z2().Remove(coh);
								coh coh2 = new d48(ez2.CreateDefinitonProvider<a0z>("luxury\\goldRing"));
								if (coh2 != null)
								{
									c7j2.ItemContainer.z3(coh2, true);
								}
							}
						}
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
