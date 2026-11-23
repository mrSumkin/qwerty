using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

// Token: 0x020008EF RID: 2287
[eiz("LUPFDBCM")]
[Serializable]
public sealed class ckr : bdw, ISerializable
{
	// Token: 0x060038A9 RID: 14505 RVA: 0x0014FBAC File Offset: 0x0014DDAC
	private ckr(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x060038AA RID: 14506 RVA: 0x0014FBB4 File Offset: 0x0014DDB4
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x060038AB RID: 14507 RVA: 0x0014FBB8 File Offset: 0x0014DDB8
	public ckr()
	{
	}

	// Token: 0x060038AC RID: 14508 RVA: 0x0014FBC4 File Offset: 0x0014DDC4
	public void av(c1a A_0, cyt A_1)
	{
		if (A_1.r().GetPrimitivePropertyValue<bool>("loc_lup_freeDroneBase_gasStopped", new bool?(false)).Value)
		{
			foreach (aud aud in Enumerable.ToList<aud>(A_0.Areas))
			{
				foreach (b0b b0b in Enumerable.ToList<b0b>(aud.Entities))
				{
					c5x c5x = (c5x)b0b;
					if (c5x.h.b != null && c5x.h.b.aa().FactionId.Contains("free_drones"))
					{
						if (!c5x.h.b.aa().StatusEffects.a(dal.a))
						{
							c5x.h.b.aa().StatusEffects.a(new dal
							{
								Duration = 1
							}, false, false, false);
						}
					}
					else
					{
						dm aspect = c5x.GetAspect<dm>();
						if (aspect != null)
						{
							using (List<cze>.Enumerator enumerator3 = Enumerable.ToList<cze>(aspect.d()).GetEnumerator())
							{
								while (enumerator3.MoveNext())
								{
									cze cze = enumerator3.Current;
									if (cze.GetType() == typeof(d4y))
									{
										aspect.d().Remove(cze);
									}
								}
								continue;
							}
						}
						dxv aspect2 = c5x.GetAspect<dxv>();
						if (aspect2 != null && aspect2.d() == "zombieMutagenGas")
						{
							aspect2.a(false);
						}
						else
						{
							cry aspect3 = c5x.GetAspect<cry>();
							if (aspect3 != null && !aspect3.g() && aspect3.gv() == "zombieMutagenGas")
							{
								aspect3.b(100.0);
							}
						}
					}
				}
			}
		}
	}
}
