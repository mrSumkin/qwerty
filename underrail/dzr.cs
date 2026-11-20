using System;
using System.Diagnostics;
using System.Linq;
using Microsoft.Xna.Framework;

// Token: 0x020020EF RID: 8431
[bmq("1.1.4.0_BurningBarrelsWarmthSourceAddition", "1.1.4.0", "*", true)]
public sealed class dzr : fg
{
	// Token: 0x0600C834 RID: 51252 RVA: 0x0046918C File Offset: 0x0046738C
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			if (A_1 != null && A_1.y8() != "xpbl_lux_dh")
			{
				foreach (aud aud in A_1.Areas)
				{
					foreach (b0b b0b in Enumerable.ToList<b0b>(aud.Entities))
					{
						c5x c5x = (c5x)b0b;
						int? num = null;
						if (c5x.p != null && c5x.p.b != null)
						{
							foreach (cd0 cd in c5x.p.b.a)
							{
								if (cd is etz)
								{
									float? d = cd.d;
									float num2 = 0f;
									if (!(d.GetValueOrDefault() == num2 & d != null) && cd.a != null)
									{
										if (string.Equals(cd.a, "Effects\\BarrelFire", StringComparison.OrdinalIgnoreCase))
										{
											num = new int?(3);
											break;
										}
										if (cd.a.StartsWith("Objects\\Containers\\BarrelSoup", StringComparison.OrdinalIgnoreCase))
										{
											num = new int?(2);
											break;
										}
									}
								}
							}
						}
						if (num != null)
						{
							c5x c5x2 = null;
							if (c5x.Layer == 0)
							{
								foreach (b0b b0b2 in c5x.Area.a(c5x.Location.a()).Entities)
								{
									if (b0b2.y8() == "metaWarmthSource_patched")
									{
										c5x2 = (b0b2 as c5x);
										break;
									}
								}
								if (c5x2 == null)
								{
									c5x2 = new c5x();
									c5x2.Layer = aju.x;
									c5x2.Location = c5x.Location;
									c5x2.Size = new Vector3(0.1f, 0.1f, 0.1f);
									c5x2.aa = true;
									c5x.Area.a(c5x2);
								}
							}
							else
							{
								c5x2 = c5x;
							}
							if (c5x2 != null)
							{
								a2r a2r = c5x2.GetAspect<a2r>();
								if (a2r == null)
								{
									a2r = new a2r(c5x2);
									c5x2.SetAspect<a2r>(a2r);
								}
								a2r.a((float)num.Value);
							}
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
