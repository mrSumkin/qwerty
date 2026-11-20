using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

// Token: 0x02000944 RID: 2372
[eiz("XPBLSRN")]
[Serializable]
public sealed class b0v : bdw, ISerializable
{
	// Token: 0x06003A07 RID: 14855 RVA: 0x00157518 File Offset: 0x00155718
	private b0v(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003A08 RID: 14856 RVA: 0x00157520 File Offset: 0x00155720
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003A09 RID: 14857 RVA: 0x00157524 File Offset: 0x00155724
	public b0v()
	{
	}

	// Token: 0x06003A0A RID: 14858 RVA: 0x0015752C File Offset: 0x0015572C
	public void av(c1a A_0, cyt A_1)
	{
		if (A_0 != null)
		{
			aud aud = null;
			if (A_0.y8() == "xpbl_e6")
			{
				aud = A_0.n("xpbl_e6");
			}
			else if (A_0.y8() == "xpbl_d5")
			{
				aud = A_0.n("xpbl_d5");
			}
			if (aud != null)
			{
				foreach (csd csd in Enumerable.ToList<csd>(A_0.Waypoints))
				{
					if (csd != null && csd.Name == "SpawnNaga" && aw1.a(new bt4(csd.Name), aud, l9.a))
					{
						c5x c5x = vq.a("creatures\\machines\\xpbl\\LemurianNagaProtectorDamaged", csd, false);
						if (c5x != null)
						{
							c5x = new d5a().a(c5x);
							int value = A_1.r().GetPrimitivePropertyValue<int>("global_xpbl_aegisSecTroopersAvailable", new int?(0)).Value;
							if (value > 3)
							{
								c5x.h.b.aa().a(null, null, false);
								A_1.r()["global_xpbl_aegisSecTroopersAvailable"] = value - 3;
								d60 d = aud.Zone.a();
								if (d == null)
								{
									continue;
								}
								using (List<b0b>.Enumerator enumerator2 = d.ab4(new string[]
								{
									"nagaKillBlood"
								}).GetEnumerator())
								{
									while (enumerator2.MoveNext())
									{
										b0b b0b = enumerator2.Current;
										c5x c5x2 = (c5x)b0b;
										if (c5x2 != null)
										{
											c5x2.ae = new float?((float)1);
										}
									}
									continue;
								}
							}
							if (c5x.h.b != null)
							{
								c5x.h.b.aa().FactionId = asp.@as;
							}
							c5x.b("xpbl_e5_damagedNaga");
							bm6 aspect = c5x.GetAspect<bm6>();
							if (aspect != null)
							{
								aspect.y6()[ddq.bm] = true;
								aspect.y6()[ddq.bn] = 15;
							}
						}
					}
				}
			}
		}
	}
}
