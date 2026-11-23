using System;
using System.Diagnostics;

// Token: 0x02002197 RID: 8599
[bmq("1.0.1.5_Lu_b22x", "1.0.1.5", "lu-b22x", false)]
public sealed class eqv : fg
{
	// Token: 0x0600C982 RID: 51586 RVA: 0x00473F34 File Offset: 0x00472134
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			c5x c5x = new ar7(new Guid("c249904c-2368-4a25-8e57-0f30be5369ce"), A_1.n("lu-b22x")).ao() as c5x;
			if (c5x != null && !c5x.TileFormationModifiers.a(4))
			{
				c5x.TileFormationModifiers = new bjp(new byte[]
				{
					4
				});
				c5x.z();
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
