using System;
using System.Diagnostics;

// Token: 0x020021FD RID: 8701
[bmq("1.0.0.11_Cc23_Animation", "1.0.0.11", "cc23", false)]
public sealed class dn7 : fg
{
	// Token: 0x0600CA53 RID: 51795 RVA: 0x0047A2A8 File Offset: 0x004784A8
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			c5x c5x = new ar7(new Guid("a53f5a91-b7a2-4f80-8818-262f90aa8374"), A_1.n("cc23")).ao() as c5x;
			if (c5x != null)
			{
				bm6 aspect = c5x.GetAspect<bm6>();
				if (aspect != null && aspect.y6().GetPrimitivePropertyValue<int>("GuardAnimationPhaseStep", new int?(0)).Value != 105)
				{
					aspect.y6()[ddq.x] = 105;
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
