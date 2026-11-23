using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x02000AF4 RID: 2804
[eiz("XPBLASGRJ")]
[Serializable]
public sealed class dkl : cze, ISerializable
{
	// Token: 0x0600411C RID: 16668 RVA: 0x0018D5C4 File Offset: 0x0018B7C4
	private dkl(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600411D RID: 16669 RVA: 0x0018D5D0 File Offset: 0x0018B7D0
	public dkl()
	{
	}

	// Token: 0x0600411E RID: 16670 RVA: 0x0018D5D8 File Offset: 0x0018B7D8
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && serviceOrThrow.aqw() != null)
		{
			List<int> classPropertyValue = serviceOrThrow.aqu().r().GetClassPropertyValue<List<int>>("xpbl_gy_skerderGravesRandomizedList");
			int value = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>(bp5.l, new int?(0)).Value;
			int value2 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("xpbl_gy_crankLocation", new int?(0)).Value;
			if (classPropertyValue != null)
			{
				d60 addon = serviceOrThrow.aqw().GetAddon<d60>();
				if (addon != null)
				{
					foreach (b0b b0b in addon.ab4(new string[]
					{
						"GraveMechanism"
					}))
					{
						bli bli = ((c5x)b0b).GetAspect<bim>() as bli;
						if (value2 == bli.g())
						{
							bli.a(true);
							bli.k();
						}
						if (bli != null && classPropertyValue.Count > bli.g())
						{
							if (value == classPropertyValue[bli.g()])
							{
								c5x c5x = addon.ab5("GraveRope_" + bli.g().ToString()) as c5x;
								if (c5x != null && c5x.o.b != null)
								{
									if (c5x.o.b.a == "Objects\\Obstacles\\xpbl_SavageSkaerderGraveX_Skaerder")
									{
										c5x.o.b.a = "Objects\\Obstacles\\xpbl_SavageSkaerderGraveX_Skaerder_Large";
									}
									if (c5x.o.b.a == "Objects\\Obstacles\\xpbl_SavageSkaerderGraveY_Skaerder")
									{
										c5x.o.b.a = "Objects\\Obstacles\\xpbl_SavageSkaerderGraveY_Skaerder_Large";
									}
								}
							}
							c5x c5x2 = addon.ab5("GraveRune_" + bli.g().ToString()) as c5x;
							if (c5x2 != null && c5x2.o.b != null)
							{
								c5x2.o.b.b = new Point(classPropertyValue[bli.g()], c5x2.o.b.b.Y);
							}
						}
					}
					if (value2 >= 20)
					{
						csd csd = serviceOrThrow.aqw().g("crank_" + value2.ToString());
						if (csd != null)
						{
							vq.a("object\\plot\\xpbl\\boneCrank", csd, false);
						}
					}
				}
			}
		}
	}
}
