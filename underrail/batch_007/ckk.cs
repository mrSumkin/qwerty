using System;
using System.Diagnostics;

// Token: 0x020020F5 RID: 8437
[bmq("1.1.4.0_Up_Mall_AddMotorCognitiveTransferenceMentor", "1.1.4.0", "up_mall", false)]
public sealed class ckk : fg
{
	// Token: 0x0600C83E RID: 51262 RVA: 0x004697FC File Offset: 0x004679FC
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			c5x c5x = new ar7(new Guid("3dec437e-f74a-40b7-ae23-445c84f94418"), A_1.n("up_mall")).ao() as c5x;
			if (c5x != null)
			{
				c7j c7j = c5x.GetAspect<bim>() as c7j;
				if (c7j != null)
				{
					coh coh = new d48(ez2.CreateDefinitonProvider<eml>("PsiMentors\\MotorCognitiveTransference"));
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
