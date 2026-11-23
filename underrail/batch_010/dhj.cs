using System;
using System.Diagnostics;

// Token: 0x020021DE RID: 8670
[bmq("1.0.0.9_Lup_A8", "1.0.0.9", "lup-a8", false)]
public sealed class dhj : fg
{
	// Token: 0x0600CA14 RID: 51732 RVA: 0x00478634 File Offset: 0x00476834
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			c5x c5x = new ar7(new Guid("6c352a0f-e9f4-4d7e-a66e-e8668eedfcaa"), A_1.n("lup-a8")).ao() as c5x;
			if (c5x != null && !A_0.r().GetPrimitivePropertyValue<bool>("patch_placedMicroShrapnelBulletsBlueprint", new bool?(false)).Value)
			{
				c7j c7j = c5x.GetAspect<bim>() as c7j;
				if (c7j != null)
				{
					coh coh = new d48(ez2.CreateDefinitonProvider<avz>("blueprints\\microShrapnelBullets"));
					if (coh != null)
					{
						c7j.ItemContainer.z3(coh, true);
						A_0.r()["patch_placedMicroShrapnelBulletsBlueprint"] = true;
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
