using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Microsoft.Xna.Framework;

// Token: 0x0200212F RID: 8495
[bmq("1.1.2.0_Cvw11_Expansion", "1.1.2.0", "cvw11", false)]
public sealed class acf : fg
{
	// Token: 0x0600C8AA RID: 51370 RVA: 0x0046CD00 File Offset: 0x0046AF00
	public bool b5(cyt A_0, c1a A_1)
	{
		Vector2 a_ = new Vector2(10f, 0f);
		try
		{
			aud aud = Enumerable.FirstOrDefault<aud>(A_1.Areas);
			if (aud != null)
			{
				foreach (b0b b0b in Enumerable.ToList<b0b>(aud.Entities))
				{
					c5x c5x = (c5x)b0b;
					if (c5x.Layer == 1 && (!c5x.IsPlayer || !ary.a.b) && (c5x.GetAspect<dqv>() == null || !ary.a.b))
					{
						c5x.Location += a_.b();
						c5x.ah();
						bool flag = false;
						using (List<ak1>.Enumerator enumerator2 = c5x.l.GetEnumerator())
						{
							while (enumerator2.MoveNext())
							{
								if (enumerator2.Current.a((long)((ulong)dm9.a)))
								{
									flag = true;
									break;
								}
							}
						}
						if (flag)
						{
							c5x.a(dm9.a);
						}
						c5x.Layer = aju.x;
					}
				}
				foreach (ya ya in Enumerable.ToList<ya>(aud.Triggers))
				{
					if (ya.Layer == 1 && !(ya is c5e) && !(ya is bo9) && ya.Id != new Guid("01f6e76a-16a0-41f8-aec7-c65dc383fb95"))
					{
						ya.o();
						ya.Location = d05.a(ya.Location, a_.a(), false);
						aud.b(ya);
					}
				}
				foreach (csd csd in A_1.Waypoints)
				{
					if (csd.Layer == 1 && csd.Area == aud)
					{
						csd.Location += a_.b();
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
