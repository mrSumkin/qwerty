using System;
using System.Diagnostics;

// Token: 0x020021E0 RID: 8672
[bmq("1.0.0.9_Lux_MD", "1.0.0.9", "lux-md", false)]
public sealed class p4 : fg
{
	// Token: 0x0600CA18 RID: 51736 RVA: 0x004787EC File Offset: 0x004769EC
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			c5x c5x = new ar7(new Guid("3515695d-d118-414c-a0da-62931c621e47"), A_1.n("lux-md")).ao() as c5x;
			if (c5x != null && !A_0.r().GetPrimitivePropertyValue<bool>("patch_placedAcidBulletsBlueprint", new bool?(false)).Value)
			{
				c7j c7j = c5x.GetAspect<bim>() as c7j;
				if (c7j != null)
				{
					coh coh = new d48(ez2.CreateDefinitonProvider<avz>("blueprints\\acidBullets"));
					if (coh != null)
					{
						c7j.ItemContainer.z3(coh, true);
						A_0.r()["patch_placedAcidBulletsBlueprint"] = true;
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
