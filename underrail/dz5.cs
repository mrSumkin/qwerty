using System;
using System.Diagnostics;

// Token: 0x0200216B RID: 8555
[bmq("1.0.4.17_FixWeaponShelfNames", "1.0.4.17", "*", true)]
public sealed class dz5 : fg
{
	// Token: 0x0600C925 RID: 51493 RVA: 0x0047112C File Offset: 0x0046F32C
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			foreach (aud aud in A_1.Areas)
			{
				foreach (b0b b0b in aud.Entities)
				{
					c5x c5x = (c5x)b0b;
					if (c5x.s.b is c7j && c5x.o.b != null && c5x.o.b.a.Contains("Objects\\Containers\\WeaponShelve") && (c5x.y8() == null || (c5x.y8() != null && c5x.y8() == "Оружейный шкаф")))
					{
						c5x.q("Шкафчик для оружия");
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
