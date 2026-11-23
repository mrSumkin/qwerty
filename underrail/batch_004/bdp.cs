using System;
using System.Diagnostics;

// Token: 0x0200216C RID: 8556
[bmq("1.0.4.17_FixPlasmaTurretTileFormation", "1.0.4.17", "*", true)]
public sealed class bdp : fg
{
	// Token: 0x0600C927 RID: 51495 RVA: 0x00471270 File Offset: 0x0046F470
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			foreach (aud aud in A_1.Areas)
			{
				foreach (b0b b0b in aud.Entities)
				{
					c5x c5x = (c5x)b0b;
					if (c5x.h.b != null && c5x.h.b.am() == bln.e6 && c5x.TileFormationModifiers.b.Count == 0)
					{
						c5x.TileFormationModifiers.s3(1);
						c5x.z();
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
