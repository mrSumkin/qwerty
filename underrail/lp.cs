using System;
using System.Diagnostics;

// Token: 0x020020C2 RID: 8386
[bmq("1.1.5.0_Xpbl_Rig2_BlackEelPatrolControllerFix", "1.1.5.0", "xpbl_rig2", false)]
public sealed class lp : fg
{
	// Token: 0x0600C7EE RID: 51182 RVA: 0x004672B8 File Offset: 0x004654B8
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			c5x c5x = new ar7(new Guid("140f3dd6-f5fe-4a32-9268-57c5c738ee8d"), A_1.n("xpbl_rig2")).ao() as c5x;
			c5x c5x2 = new ar7(new Guid("874c2316-ad18-42de-90d7-83b85d9bdcd5"), A_1.n("xpbl_rig2")).ao() as c5x;
			c5x c5x3 = new ar7(new Guid("1f6ed495-dc5d-42b1-ab64-5a79b1f6203f"), A_1.n("xpbl_rig2")).ao() as c5x;
			if (c5x != null)
			{
				ehi aspect = c5x.GetAspect<ehi>();
				if (aspect != null && aspect.j().StartsWith("gen"))
				{
					aspect.a(new aea());
				}
			}
			if (c5x2 != null)
			{
				ehi aspect2 = c5x2.GetAspect<ehi>();
				if (aspect2 != null && aspect2.j().StartsWith("gen"))
				{
					aspect2.a(new aea());
				}
			}
			if (c5x3 != null)
			{
				ehi aspect3 = c5x3.GetAspect<ehi>();
				if (aspect3 != null && aspect3.j().StartsWith("gen"))
				{
					aspect3.a(new aea());
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
