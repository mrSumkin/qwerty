using System;
using System.Diagnostics;

// Token: 0x020021DF RID: 8671
[bmq("1.0.0.9_Up10", "1.0.0.9", "up10", false)]
public sealed class bua : fg
{
	// Token: 0x0600CA16 RID: 51734 RVA: 0x00478710 File Offset: 0x00476910
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			c5x c5x = new ar7(new Guid("5012e9e6-521c-4939-be25-ea51cbc48ae6"), A_1.n("up10")).ao() as c5x;
			if (c5x != null && !A_0.r().GetPrimitivePropertyValue<bool>("patch_placedExplosiveBulletsBlueprint", new bool?(false)).Value)
			{
				c7j c7j = c5x.GetAspect<bim>() as c7j;
				if (c7j != null)
				{
					coh coh = new d48(ez2.CreateDefinitonProvider<avz>("blueprints\\explosiveBullets"));
					if (coh != null)
					{
						c7j.ItemContainer.z3(coh, true);
						A_0.r()["patch_placedExplosiveBulletsBlueprint"] = true;
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
