using System;
using System.Collections.Generic;
using System.Diagnostics;

// Token: 0x0200220D RID: 8717
[bmq("1.0.0.11_Jye_Elevators", "1.0.0.11", "jye3", false)]
public sealed class bhc : fg
{
	// Token: 0x0600CA73 RID: 51827 RVA: 0x0047B634 File Offset: 0x00479834
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			c5x c5x = new ar7(new Guid("3b935ef4-c719-47bb-bb0f-9f9da03d51f2"), A_1.n("jye3")).ao() as c5x;
			if (c5x != null)
			{
				alv aspect = c5x.GetAspect<alv>();
				if (aspect != null)
				{
					float? d = aspect.a[1].d;
					float num = 0f;
					if (!(d.GetValueOrDefault() == num & d != null))
					{
						aspect.a[1].d = new float?(0f);
					}
				}
				dt5 aspect2 = c5x.GetAspect<dt5>();
				if (aspect2 != null)
				{
					aspect2.d().Clear();
					aspect2.f().Clear();
					List<cze> list = aspect2.d();
					bi5 bi = new bi5();
					bi.a(new float?(1f));
					bi.a(true);
					bi.a(new int?(1));
					list.Add(bi);
					List<cze> list2 = aspect2.f();
					bi5 bi2 = new bi5();
					bi2.a(new float?(0f));
					bi2.a(true);
					bi2.a(new int?(1));
					list2.Add(bi2);
					aspect2.h();
					aspect2.b();
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
