using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;

// Token: 0x02000930 RID: 2352
[eiz("CCFRB")]
[Serializable]
public sealed class bfy : bdw, ISerializable
{
	// Token: 0x060039B4 RID: 14772 RVA: 0x00155210 File Offset: 0x00153410
	private bfy(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x060039B5 RID: 14773 RVA: 0x00155218 File Offset: 0x00153418
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x060039B6 RID: 14774 RVA: 0x0015521C File Offset: 0x0015341C
	public bfy()
	{
	}

	// Token: 0x060039B7 RID: 14775 RVA: 0x00155228 File Offset: 0x00153428
	public void av(c1a A_0, cyt A_1)
	{
		aud aud = A_0.n("lu-cblock");
		if (A_0 != null)
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			bool value = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_cc_facelessRetreated", new bool?(false)).Value;
			bool flag = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_lu-c5_donePreproc", new bool?(false)).Value;
			if (value)
			{
				foreach (b0b b0b in Enumerable.ToList<b0b>(aud.Entities))
				{
					c5x c5x = (c5x)b0b;
					if (c5x.Layer == aju.x && c5x.q.b != null && c5x.y8() == "Tunneller")
					{
						serviceOrThrow.aqu().r()["loc_lu-c5_donePreproc"] = false;
						flag = false;
					}
				}
			}
			if (!flag && value)
			{
				if (aud != null && serviceOrThrow != null)
				{
					List<c5x> list = new List<c5x>();
					foreach (b0b b0b2 in Enumerable.ToList<b0b>(aud.Entities))
					{
						c5x c5x2 = (c5x)b0b2;
						if (c5x2.h.b != null && !c5x2.h.b.aa().Dead && c5x2.h.b.aa().FactionId.StartsWith("faceless", StringComparison.OrdinalIgnoreCase))
						{
							list.Add(c5x2);
						}
					}
					foreach (c5x c5x3 in list)
					{
						c5x3.w();
						c5x3.an();
					}
					if (value)
					{
						foreach (b0b b0b3 in Enumerable.ToList<b0b>(aud.Entities))
						{
							c5x c5x4 = (c5x)b0b3;
							if (c5x4.Layer == aju.x && c5x4.q.b != null && c5x4.y8() == "Tunneller")
							{
								c5x4.w();
								c5x4.an();
							}
							else
							{
								if (c5x4.o.b != null)
								{
									float? d = c5x4.o.b.d;
									float num = 0f;
									if ((d.GetValueOrDefault() == num & d != null) && c5x4.Layer == 1 && c5x4.o.b.a == "Floor\\ConcreteTile2")
									{
										c5x4.w();
										c5x4.an();
										continue;
									}
								}
								if (!string.IsNullOrEmpty(c5x4.y8()) && c5x4.h.b == null && c5x4.s.b is c7j && (c5x4.y8().EndsWith("- тело") || c5x4.y8() == "Останки"))
								{
									c5x4.w();
									c5x4.an();
								}
								else if (c5x4.o.b != null && c5x4.o.b.a == "Effects\\BloodPool")
								{
									c5x4.w();
									c5x4.an();
								}
							}
						}
					}
				}
				if (value)
				{
					doq a_ = doq.a(Path.Combine(d5x.q(), "lu-cblock_l2") + ".uzl");
					aud.Zone.a(a_, 1, null);
					string classPropertyValue = A_0.CustomProperties.GetClassPropertyValue<string>("TunnelerLantern");
					new dvn(serviceOrThrow.ar0(serviceOrThrow.aqu().c().b(), serviceOrThrow.aqu()).Id, "LowerUnderrail").ym(null, null, null);
					if (!string.IsNullOrEmpty(classPropertyValue))
					{
						ah7 ah = A_0.i(classPropertyValue);
						if (ah != null)
						{
							ah.Enabled = false;
							ah.d();
						}
					}
				}
				serviceOrThrow.aqu().r()["loc_lu-c5_donePreproc"] = true;
			}
		}
	}
}
