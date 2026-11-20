using System;
using System.Diagnostics;
using Ouroboros.Playfield.Space;

// Token: 0x0200217B RID: 8571
[bmq("1.0.3.6_Cc_GauntletEntrance_Lockers", "1.0.3.6", "cc_enterGauntlet", false)]
public sealed class csa : fg
{
	// Token: 0x0600C941 RID: 51521 RVA: 0x00471B18 File Offset: 0x0046FD18
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			c5x c5x = new ar7(new Guid("faece3bd-d1a2-4e25-8466-2b5388fe1208"), A_1.n("cc_enterGauntlet")).ao() as c5x;
			c5x c5x2 = new ar7(new Guid("81f51ca1-5b99-4312-8d89-c3c8d261680c"), A_1.n("cc_enterGauntlet")).ao() as c5x;
			c5x c5x3 = new ar7(new Guid("f15debf0-cd3a-4a99-b351-3db67aefe4e3"), A_1.n("cc_enterGauntlet")).ao() as c5x;
			if (c5x != null && c5x.VisualDirection != HorizontalDirection.East)
			{
				c5x.VisualDirection = HorizontalDirection.East;
				c5x.ah();
			}
			if (c5x2 != null && c5x2.VisualDirection != HorizontalDirection.East)
			{
				c5x2.VisualDirection = HorizontalDirection.East;
				c5x2.ah();
			}
			if (c5x3 != null && c5x3.VisualDirection != HorizontalDirection.East)
			{
				c5x3.VisualDirection = HorizontalDirection.East;
				c5x3.ah();
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
