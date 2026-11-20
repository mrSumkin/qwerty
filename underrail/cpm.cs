using System;
using System.Diagnostics;
using System.Linq;

// Token: 0x020021D7 RID: 8663
[bmq("1.0.1.13_Fo_OculusSound", "1.0.1.13", "fo3", false)]
public sealed class cpm : fg
{
	// Token: 0x0600CA05 RID: 51717 RVA: 0x00477E70 File Offset: 0x00476070
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			foreach (b0b b0b in Enumerable.ToList<b0b>(A_1.n("fo3_roof").Entities))
			{
				c5x c5x = (c5x)b0b;
				if (c5x != null && c5x.h.b != null && c5x.h.b.aa().FactionId == asp.dh)
				{
					bm6 aspect = c5x.GetAspect<bm6>();
					if (aspect != null)
					{
						aspect.y6()[ddq.bs] = new exw(d6n.c, 0.0, true, null);
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
