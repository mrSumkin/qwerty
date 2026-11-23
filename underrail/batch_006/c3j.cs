using System;
using System.Diagnostics;

// Token: 0x02002189 RID: 8585
[bmq("1.0.3.23_UpdateCurtainDoors", "1.0.3.23", "*", true)]
public sealed class c3j : fg
{
	// Token: 0x0600C963 RID: 51555 RVA: 0x00472B18 File Offset: 0x00470D18
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			foreach (aud aud in A_1.Areas)
			{
				foreach (b0b b0b in aud.Entities)
				{
					c5x c5x = (c5x)b0b;
					cnb cnb = c5x.GetAspect<bim>() as cnb;
					cd0 aspect = c5x.GetAspect<cd0>();
					if (cnb != null && !cnb.d().b(4194304L) && aspect != null && (aspect.a == "Doors\\CurtainDoorV" || aspect.a == "Doors\\CurtainDoorH"))
					{
						cnb.d().s3(22);
						if (!cnb.q())
						{
							c5x.TileFormationModifiers.s3(22);
							c5x.z();
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
