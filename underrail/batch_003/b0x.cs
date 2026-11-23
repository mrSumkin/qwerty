using System;
using System.Diagnostics;

// Token: 0x0200219A RID: 8602
[bmq("1.0.1.5_Lux_A3_Rat", "1.0.1.5", "lux-a3", false)]
public sealed class b0x : fg
{
	// Token: 0x0600C988 RID: 51592 RVA: 0x0047422C File Offset: 0x0047242C
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			c5x c5x = new ar7(new Guid("f3368780-5f23-4e49-9f00-7a3c0ec63fe1"), A_1.n("lux-a3")).ao() as c5x;
			if (c5x != null)
			{
				c7j c7j = c5x.GetAspect<bim>() as c7j;
				if (c7j != null)
				{
					foreach (coh coh in c7j.ItemContainer.z2())
					{
						if (coh.Definition != null && coh.Definition.a5() == "component.rathoundLeather" && coh == c7j.ItemContainer.z2()[0])
						{
							c7j.ItemContainer.z5(coh);
							break;
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
