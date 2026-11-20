using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02000B72 RID: 2930
[eiz("FOUPRJ")]
[Serializable]
public sealed class dz7 : cze, ISerializable
{
	// Token: 0x06004308 RID: 17160 RVA: 0x001A2CD4 File Offset: 0x001A0ED4
	private dz7(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06004309 RID: 17161 RVA: 0x001A2CE0 File Offset: 0x001A0EE0
	public dz7()
	{
	}

	// Token: 0x0600430A RID: 17162 RVA: 0x001A2CEC File Offset: 0x001A0EEC
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v().b() != null)
		{
			bool flag = false;
			if (serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_fo_prison_caughtOnCamera", new bool?(false)).Value)
			{
				flag = true;
			}
			else
			{
				d02 service = bpo.GetService<d02>();
				if (service != null)
				{
					foreach (d4n d4n in service.ahl())
					{
						h h;
						if (d4n.b != null && !d4n.b.aa().Dead && !d4n.b.aa().Passive && d4n.b.aa().FactionId != asp.a && d4n.b.aa().PersonalAttitudes.TryGetValue(asp.a, out h) && h == h.a)
						{
							flag = true;
							break;
						}
					}
				}
			}
			if (flag)
			{
				serviceOrThrow.aqu().r()["loc_fo_shouldMakeFoundryHostile"] = true;
			}
			bool flag2 = false;
			string[] array = new string[]
			{
				"ad88e828-c313-49b3-8284-1224f6728ab5",
				"71bade63-8fcd-4d03-9a43-19a39c348055",
				"84227bfa-ef33-4690-b163-e6fa15010abe",
				"9921efef-ea1b-4c36-96eb-9c4d36e6d8c6",
				"b0786b0a-7bfc-46a8-9997-5170cb429dd7",
				"0195a807-9185-4dee-ab5d-14030ba96803",
				"1e7bd52b-e0ba-4960-a642-4970a211be43"
			};
			for (int i = 0; i < array.Length; i++)
			{
				c5x c5x = new ar7(new Guid(array[i]), serviceOrThrow.aqu().v().b().Area).ao() as c5x;
				if (c5x != null)
				{
					cnb cnb = c5x.s.b as cnb;
					if (cnb != null && cnb.q())
					{
						flag2 = true;
						break;
					}
				}
			}
			if (!flag2)
			{
				bool flag3 = false;
				bool flag4 = false;
				foreach (b0b b0b in serviceOrThrow.aqu().v().b().Area.Entities)
				{
					c5x c5x2 = (c5x)b0b;
					if (c5x2.Layer == aju.x)
					{
						if (c5x2.s.b is c7j && !string.IsNullOrEmpty(c5x2.y8()) && c5x2.y8().EndsWith(" - тело"))
						{
							flag3 = true;
						}
						else if (c5x2.h.b != null && !c5x2.h.b.aa().Passive && c5x2.h.b.aa().FactionId == asp.c0)
						{
							flag4 = true;
						}
					}
				}
				if (flag3 && flag4)
				{
					flag2 = true;
				}
			}
			if (flag2)
			{
				serviceOrThrow.aqu().r()["loc_fo_shouldSetPrisonSecurityBreach"] = true;
			}
		}
	}
}
