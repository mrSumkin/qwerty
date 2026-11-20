using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

// Token: 0x02000A8E RID: 2702
[eiz("LUUHPSJ")]
[Serializable]
public sealed class ecw : cze, ISerializable
{
	// Token: 0x06003F6F RID: 16239 RVA: 0x00180A00 File Offset: 0x0017EC00
	private ecw(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06003F70 RID: 16240 RVA: 0x00180A0C File Offset: 0x0017EC0C
	public ecw()
	{
	}

	// Token: 0x06003F71 RID: 16241 RVA: 0x00180A18 File Offset: 0x0017EC18
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		if (A_1 != null && A_1.Zone != null)
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() != null && !serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_hro_powerReset", new bool?(false)).Value)
			{
				int num = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("loc_hro_powerSwitchCounter", new int?(3)).Value - 1;
				if (num <= 0)
				{
					axh axh = this.a(A_1.Zone, "hro_mainPower");
					axh axh2 = this.a(A_1.Zone, "hro_warningPower");
					if (axh != null && axh.i())
					{
						num = 2;
						if (axh2 != null && axh2.i())
						{
							axh2.a(null, false, null);
						}
					}
					else
					{
						num = 4;
					}
					if (axh != null)
					{
						axh.a(null, !axh.i(), null);
					}
					axh axh3 = this.a(A_1.Zone, "hro_auxLight");
					if (axh3 != null)
					{
						axh3.a(null, !axh3.i(), null);
					}
				}
				if (num == 1)
				{
					axh axh4 = this.a(A_1.Zone, "hro_mainPower");
					axh axh5 = this.a(A_1.Zone, "hro_warningPower");
					if (axh5 != null && !axh5.i() && axh4 != null && !axh4.i())
					{
						axh5.a(null, true, null);
					}
				}
				serviceOrThrow.aqu().r()["loc_hro_powerSwitchCounter"] = num;
			}
		}
	}

	// Token: 0x06003F72 RID: 16242 RVA: 0x00180BDC File Offset: 0x0017EDDC
	private axh a(c1a A_0, string A_1)
	{
		d60 addon = A_0.GetAddon<d60>();
		if (addon != null)
		{
			c5x c5x = Enumerable.FirstOrDefault<b0b>(addon.ab4(new string[]
			{
				"powerSourceEntity:" + A_1
			})) as c5x;
			if (c5x != null)
			{
				return c5x.GetAspect<axh>();
			}
		}
		return null;
	}
}
