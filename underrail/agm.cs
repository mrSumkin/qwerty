using System;
using System.Diagnostics;

// Token: 0x020021E1 RID: 8673
[bmq("1.0.0.9_PanaceaLab", "1.0.0.9", "plb", false)]
public sealed class agm : fg
{
	// Token: 0x0600CA1A RID: 51738 RVA: 0x004788C8 File Offset: 0x00476AC8
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			c5x c5x = new ar7(new Guid("7e8e16dc-7ff3-4814-83fc-4cea0958f8b2"), A_1.n("plb")).ao() as c5x;
			if (c5x != null && !A_0.r().GetPrimitivePropertyValue<bool>("patch_placedContaminatedBulletsBlueprint", new bool?(false)).Value)
			{
				c7j c7j = c5x.GetAspect<bim>() as c7j;
				if (c7j != null)
				{
					coh coh = new d48(ez2.CreateDefinitonProvider<avz>("blueprints\\contaminatedBullets"));
					if (coh != null)
					{
						c7j.ItemContainer.z3(coh, true);
						A_0.r()["patch_placedContaminatedBulletsBlueprint"] = true;
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
