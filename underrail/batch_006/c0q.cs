using System;
using System.Collections.Generic;
using System.Diagnostics;

// Token: 0x02002200 RID: 8704
[bmq("1.0.0.11_DCLights", "1.0.0.11", "*", false)]
public sealed class c0q : fg
{
	// Token: 0x0600CA59 RID: 51801 RVA: 0x0047A598 File Offset: 0x00478798
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			foreach (aud aud in A_1.Areas)
			{
				foreach (b0b b0b in aud.Entities)
				{
					c5x c5x = (c5x)b0b;
					if (c5x.p.b != null && c5x.p.b.a.Count == 2 && c5x.p.b.a[0].a == "Objects\\LightSources\\StandLightDC")
					{
						dt5 aspect = c5x.GetAspect<dt5>();
						if (aspect != null)
						{
							aspect.f().Clear();
							List<cze> list = aspect.f();
							bi5 bi = new bi5();
							bi.a(new int?(0));
							bi.b(0);
							bi.b(true);
							list.Add(bi);
							List<cze> list2 = aspect.f();
							bi5 bi2 = new bi5();
							bi2.a(new int?(1));
							bi2.b(0);
							bi2.b(true);
							list2.Add(bi2);
							aspect.b();
							aspect.h();
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
