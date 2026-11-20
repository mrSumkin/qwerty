using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02000AB8 RID: 2744
[eiz("UPULWR")]
[Serializable]
public sealed class ew5 : cze, ISerializable
{
	// Token: 0x06004013 RID: 16403 RVA: 0x00184E48 File Offset: 0x00183048
	private ew5(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06004014 RID: 16404 RVA: 0x00184E54 File Offset: 0x00183054
	public ew5()
	{
	}

	// Token: 0x06004015 RID: 16405 RVA: 0x00184E60 File Offset: 0x00183060
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("up_lw_alarmState", new bool?(false)).Value && A_0 != null && A_0.Zone != null)
		{
			c5x[] array = new c5x[]
			{
				this.a("89421712-45fc-48c9-a850-20f3b660cea3", A_0.Zone),
				this.a("1e83ffb1-c8d1-4666-89cd-e25c6a02df47", A_0.Zone),
				this.a("c561b2f1-bce3-4725-93d5-4bb9519403c8", A_0.Zone)
			};
			c5x c5x = this.a("a1aa219e-1825-4d7b-95b5-5be65b30f4ec", A_0.Zone);
			if (c5x != null)
			{
				bool flag = !c5x.TileFormationModifiers.c(2L);
				for (int i = 1; i <= 3; i++)
				{
					c5x c5x2 = array[i - 1];
					if (c5x2 != null && c5x2.t.b != null)
					{
						bool flag2 = c5x2.Location.Y >= 23f && c5x2.Location.Y <= 33f && c5x2.Location.X >= 1f && c5x2.Location.X <= 6f;
						if (!flag && (c5x2.Area.y8().Equals("up-lw1", StringComparison.OrdinalIgnoreCase) || flag2))
						{
							c5x2.t.b.y6()[ddq.ay] = new bt4("reOut" + i.ToString());
						}
						else
						{
							c5x2.t.b.y6()[ddq.ay] = new bt4("reIn" + i.ToString());
						}
					}
				}
			}
		}
	}

	// Token: 0x06004016 RID: 16406 RVA: 0x00185058 File Offset: 0x00183258
	private c5x a(string A_0, c1a A_1)
	{
		foreach (aud a_ in A_1.Areas)
		{
			c5x c5x = new ar7(new Guid(A_0), a_).ao() as c5x;
			if (c5x != null)
			{
				return c5x;
			}
		}
		return null;
	}
}
