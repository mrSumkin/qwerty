using System;
using System.Diagnostics;
using Microsoft.Xna.Framework;

// Token: 0x020020BB RID: 8379
[bmq("1.1.5.6_Up7_RandomEventPhoneBlockFix", "1.1.5.6", "up7", false)]
public sealed class aew : fg
{
	// Token: 0x0600C7E2 RID: 51170 RVA: 0x00466C08 File Offset: 0x00464E08
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			aud aud = A_1.n("up7");
			if (aud != null)
			{
				ak1 ak = aud.b(40, 17);
				ak1 ak2 = aud.b(41, 17);
				if (ak != null)
				{
					foreach (b0b b0b in ak.Entities)
					{
						c5x c5x = (c5x)b0b;
						if (!c5x.IsFloor && !c5x.IsGround && c5x.h.b == null && c5x.TileFormationModifiers.a(1))
						{
							c5x.Location = new Vector3(c5x.Location.X, c5x.Location.Y + 1f, c5x.Location.Z);
							c5x.ah();
						}
					}
				}
				if (ak2 != null)
				{
					foreach (b0b b0b2 in ak2.Entities)
					{
						c5x c5x2 = (c5x)b0b2;
						if (!c5x2.IsFloor && !c5x2.IsGround && c5x2.h.b == null && c5x2.TileFormationModifiers.a(1))
						{
							c5x2.Location = new Vector3(c5x2.Location.X, c5x2.Location.Y + 1f, c5x2.Location.Z);
							c5x2.ah();
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
