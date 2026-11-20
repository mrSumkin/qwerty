using System;
using System.Diagnostics;

// Token: 0x020021DD RID: 8669
[bmq("1.0.0.9_HRO", "1.0.0.9", "hro1", false)]
public sealed class eoe : fg
{
	// Token: 0x0600CA12 RID: 51730 RVA: 0x00478558 File Offset: 0x00476758
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			c5x c5x = new ar7(new Guid("05114c44-7f37-4bb0-8031-b1c2e3c36867"), A_1.n("hro1")).ao() as c5x;
			if (c5x != null && !A_0.r().GetPrimitivePropertyValue<bool>("patch_placedShockBulletsBlueprint", new bool?(false)).Value)
			{
				c7j c7j = c5x.GetAspect<bim>() as c7j;
				if (c7j != null)
				{
					coh coh = new d48(ez2.CreateDefinitonProvider<avz>("blueprints\\shockBullets"));
					if (coh != null)
					{
						c7j.ItemContainer.z3(coh, true);
						A_0.r()["patch_placedShockBulletsBlueprint"] = true;
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
