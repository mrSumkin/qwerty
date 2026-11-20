using System;
using System.Diagnostics;

// Token: 0x020020F6 RID: 8438
[bmq("1.1.4.0_Cc_ZamansLair_AddPsychosomaticPredationMentor", "1.1.4.0", "cc_zamansLair", false)]
public sealed class t2 : fg
{
	// Token: 0x0600C840 RID: 51264 RVA: 0x0046989C File Offset: 0x00467A9C
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			c5x c5x = new ar7(new Guid("b2f55044-3da6-4e75-866a-0c2d9fad139d"), A_1.n("cc_zamansLair")).ao() as c5x;
			if (c5x != null)
			{
				c7j c7j = c5x.GetAspect<bim>() as c7j;
				if (c7j != null)
				{
					coh coh = new d48(ez2.CreateDefinitonProvider<eml>("PsiMentors\\PsychosomaticPredation"));
					if (coh != null)
					{
						c7j.ItemContainer.z3(coh, true);
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
