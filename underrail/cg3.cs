using System;
using System.Diagnostics;
using Microsoft.Xna.Framework;

// Token: 0x0200212A RID: 8490
[bmq("1.1.2.2_SpawnDudesCaveOverlayWall", "1.1.2.2", "lux-c5", false)]
public sealed class cg3 : fg
{
	// Token: 0x0600C8A0 RID: 51360 RVA: 0x0046C8E0 File Offset: 0x0046AAE0
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			c5x c5x = new ar7(new Guid("52d06390-bc20-4923-8ed7-ec71354c8639"), A_1.n(A_1.y8())).ao() as c5x;
			if (c5x != null)
			{
				b4h aspect = c5x.GetAspect<b4h>();
				if (aspect != null && aspect.j())
				{
					return true;
				}
			}
			c5x c5x2 = vq.a("Door\\SecretCaveDoorX", A_1, new bt4(A_1.y8(), new Vector3(21f, 7f, 0f)), false);
			if (c5x2 != null)
			{
				c5x2.i(new Guid("5587bc8d-5232-4885-a719-e23dbc1eb380"));
				c5x2.RemoveAspect<bim>();
				c5x2.RemoveAspect<buf>();
				csi.a(c5x2);
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
