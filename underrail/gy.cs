using System;
using System.Diagnostics;
using System.Linq;

// Token: 0x0200213C RID: 8508
[bmq("1.1.2.0_RemoveFoundryMinesTrapsAfterBeastsDeath", "1.1.2.0", "fom1,fom2,fom3,fom4,fom5,fom6,fom7,fom8,crys1,crys2", false)]
public sealed class gy : fg
{
	// Token: 0x0600C8BB RID: 51387 RVA: 0x0046D3D4 File Offset: 0x0046B5D4
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			if (A_0.r().GetPrimitivePropertyValue<bool>("loc_fo_mineReopened", new bool?(false)).Value)
			{
				foreach (aud aud in Enumerable.ToList<aud>(A_1.Areas))
				{
					foreach (cos cos in Enumerable.OfType<cos>(aud.Triggers))
					{
						if (cos.Layer == 1)
						{
							cos.TrapEntity.w();
							cos.TrapEntity.an();
							cos.o();
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
