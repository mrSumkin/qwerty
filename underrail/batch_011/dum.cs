using System;
using System.Diagnostics;
using System.Linq;
using Ouroboros.Playfield.Space;

// Token: 0x020020A7 RID: 8359
[bmq("1.2.0.14_Xphw_Exobase_Lab2_SplitGateCheckFix", "1.2.0.14", "xphw_exobase_lab2", false)]
public sealed class dum : fg
{
	// Token: 0x0600C7C1 RID: 51137 RVA: 0x0046612C File Offset: 0x0046432C
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			aud aud = A_1.n("xphw_exobase_lab2");
			if (aud != null)
			{
				c5x c5x = new ar7(new Guid("dd278640-8afb-4b43-8037-5be7e5fbc95a"), aud).ao() as c5x;
				if (c5x != null)
				{
					bb2 bb = c5x.GetAspect<bim>() as bb2;
					if (bb != null && Enumerable.Any<cze>(bb.s()))
					{
						cr5 cr = bb.s()[0] as cr5;
						if (cr != null)
						{
							if (!cr.b().Contains(HorizontalDirection.Northeast))
							{
								cr.b().Add(HorizontalDirection.Northeast);
							}
							if (!cr.b().Contains(HorizontalDirection.Northwest))
							{
								cr.b().Add(HorizontalDirection.Northwest);
							}
						}
						cr5 cr2 = bb.s()[1] as cr5;
						if (cr2 != null)
						{
							if (!cr2.b().Contains(HorizontalDirection.Southeast))
							{
								cr2.b().Add(HorizontalDirection.Southeast);
							}
							if (!cr2.b().Contains(HorizontalDirection.Southwest))
							{
								cr2.b().Add(HorizontalDirection.Southwest);
							}
						}
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
