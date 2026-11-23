using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;

// Token: 0x02000977 RID: 2423
[eiz("FDOR")]
[Serializable]
public sealed class mw : bdw, ISerializable
{
	// Token: 0x06003AD7 RID: 15063 RVA: 0x0015D18C File Offset: 0x0015B38C
	private mw(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003AD8 RID: 15064 RVA: 0x0015D194 File Offset: 0x0015B394
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003AD9 RID: 15065 RVA: 0x0015D198 File Offset: 0x0015B398
	public mw()
	{
	}

	// Token: 0x06003ADA RID: 15066 RVA: 0x0015D1A4 File Offset: 0x0015B3A4
	public void av(c1a A_0, cyt A_1)
	{
		if (A_0 != null)
		{
			int value = A_0.CustomProperties.GetPrimitivePropertyValue<int>("CaveInLayer", new int?(2)).Value;
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			bool value2 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_cc_facelessRetreated", new bool?(false)).Value;
			bool flag = false;
			foreach (aud aud in A_0.Areas)
			{
				if (aud != null && serviceOrThrow != null)
				{
					List<c5x> list = new List<c5x>();
					foreach (b0b b0b in aud.Entities)
					{
						c5x c5x = (c5x)b0b;
						if (c5x.h.b != null && !c5x.h.b.aa().Dead && c5x.h.b.aa().FactionId.StartsWith("faceless", StringComparison.OrdinalIgnoreCase))
						{
							if (value2)
							{
								list.Add(c5x);
							}
							else
							{
								flag = true;
							}
						}
					}
					foreach (c5x c5x2 in list)
					{
						c5x2.w();
						c5x2.an();
					}
					if (value2 || !flag)
					{
						foreach (b0b b0b2 in aud.Entities)
						{
							c5x c5x3 = (c5x)b0b2;
							if (c5x3.Layer == aju.x && c5x3.q.b != null && c5x3.y8() == "Tunneller")
							{
								c5x3.w();
								c5x3.an();
								break;
							}
						}
					}
				}
			}
			string name = string.Format("loc_{0}_facelessLeft", A_0.y8().ToLowerInvariant());
			if (!serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>(name, new bool?(false)).Value && (value2 || !flag))
			{
				string text = Path.Combine(d5x.q(), A_0.y8() + "_l" + value.ToString()) + ".uzl";
				if (File.Exists(text))
				{
					doq a_ = doq.a(text);
					A_0.a(a_, aju.x, null);
					serviceOrThrow.aqu().r()[name] = true;
				}
				string classPropertyValue = A_0.CustomProperties.GetClassPropertyValue<string>("TunnelerLantern");
				if (!string.IsNullOrEmpty(classPropertyValue))
				{
					ah7 ah = A_0.i(classPropertyValue);
					if (ah != null)
					{
						ah.Enabled = flag;
						ah.d();
					}
				}
			}
		}
	}
}
