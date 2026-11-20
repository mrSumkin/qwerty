using System;
using System.Linq;
using System.Runtime.Serialization;

// Token: 0x0200096E RID: 2414
[eiz("DCDFFFLO")]
[Serializable]
public sealed class dbk : bdw, ISerializable
{
	// Token: 0x06003AB2 RID: 15026 RVA: 0x0015C128 File Offset: 0x0015A328
	private dbk(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003AB3 RID: 15027 RVA: 0x0015C130 File Offset: 0x0015A330
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003AB4 RID: 15028 RVA: 0x0015C134 File Offset: 0x0015A334
	public dbk()
	{
	}

	// Token: 0x06003AB5 RID: 15029 RVA: 0x0015C140 File Offset: 0x0015A340
	public void av(c1a A_0, cyt A_1)
	{
		if (A_1 != null)
		{
			bool value = A_1.r().GetPrimitivePropertyValue<bool>("global_TchortDefeated", new bool?(false)).Value;
			bool value2 = A_1.r().GetPrimitivePropertyValue<bool>("npc_dc_flcom_died", new bool?(false)).Value;
			int value3 = A_1.r().GetPrimitivePropertyValue<int>("loc_dc-flo_medBayKilled", new int?(0)).Value;
			int value4 = A_1.r().GetPrimitivePropertyValue<int>("loc_dc-flo_medBayKilled", new int?(0)).Value;
			if (value && A_0 != null)
			{
				aud aud = A_0.n("dc-flo");
				if (aud != null)
				{
					foreach (b0b b0b in Enumerable.ToList<b0b>(aud.Entities))
					{
						c5x c5x = (c5x)b0b;
						if (c5x.h.b != null)
						{
							if ((c5x.h.b.aa().FactionId == asp.ch || c5x.h.b.aa().FactionId == asp.ci) && !c5x.h.b.aa().Dead)
							{
								c5x.w();
								c5x.an();
							}
						}
						else if (value4 < this.a())
						{
							if (c5x.s.b is c7j)
							{
								c7j c7j = c5x.s.b as c7j;
								d2b aspect = c5x.GetAspect<d2b>();
								if (c7j != null)
								{
									c7j.ItemContainer.z7();
									c7j.d(true);
								}
								if (aspect != null)
								{
									aspect.a(true, false);
									aspect.a(d1c.a);
								}
							}
							else
							{
								if (c5x.o.b != null)
								{
									float? d = c5x.o.b.d;
									float num = 0f;
									if ((d.GetValueOrDefault() == num & d != null) && c5x.Layer == 1 && c5x.o.b.a == "Floor\\ConcreteTile2")
									{
										c5x.w();
										c5x.an();
										continue;
									}
								}
								if (!string.IsNullOrEmpty(c5x.y8()) && c5x.h.b == null && c5x.s.b is c7j && (c5x.y8().EndsWith("- тело") || c5x.y8() == "Останки"))
								{
									c5x.w();
									c5x.an();
								}
								else if (c5x.o.b != null && c5x.o.b.a == "Effects\\BloodPool")
								{
									c5x.w();
									c5x.an();
								}
								else if (c5x != null && c5x.GetAspect<a3f>() != null && c5x.GetAspect<a3f>().a().GetPrimitivePropertyValue<bool>("IsCorpse", new bool?(false)).Value)
								{
									c5x.an();
									c5x.w();
								}
							}
						}
					}
					c5x c5x2 = new ar7(new Guid("9322e54e-3904-4e6a-a9c9-9dae60ac9067"), aud).ao() as c5x;
					if (c5x2 != null && value4 < this.a())
					{
						c5x2.w();
						c5x2.an();
					}
					c5x c5x3 = new ar7(new Guid("2f9f2c8a-e9dd-4152-b6bb-53359aef4e3c"), aud).ao() as c5x;
					if (c5x3 != null && !c5x3.h.b.aa().Dead)
					{
						if (value3 < 2)
						{
							c5x3.w();
							c5x3.an();
							return;
						}
						c5x3.h.b.aa().a(null, null, false);
					}
				}
			}
		}
	}

	// Token: 0x06003AB6 RID: 15030 RVA: 0x0015C58C File Offset: 0x0015A78C
	private int a()
	{
		return 10;
	}
}
