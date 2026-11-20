using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02000A7C RID: 2684
[eiz("LURSTA")]
[Serializable]
public sealed class dvz : cze, ISerializable
{
	// Token: 0x06003F30 RID: 16176 RVA: 0x0017E928 File Offset: 0x0017CB28
	private dvz(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06003F31 RID: 16177 RVA: 0x0017E934 File Offset: 0x0017CB34
	public dvz()
	{
	}

	// Token: 0x06003F32 RID: 16178 RVA: 0x0017E940 File Offset: 0x0017CB40
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		aud a_ = null;
		if (A_0 != null)
		{
			a_ = A_0.Area;
		}
		else if (A_1 != null)
		{
			a_ = A_1.Area;
		}
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && serviceOrThrow.aqw() != null)
		{
			axh aspect = (new ar7(new Guid("72fe5195-2c9a-431b-a976-b9e0981d85d4"), a_).ao() as c5x).GetAspect<axh>();
			if (serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_lu_raf_cameFromVent", new bool?(false)).Value)
			{
				d60 addon = serviceOrThrow.aqw().GetAddon<d60>();
				if (addon != null)
				{
					List<b0b> list = addon.ab4(new string[]
					{
						"lu-raf_AlarmSpeakers"
					});
					if (list != null && list.Count > 0)
					{
						foreach (b0b b0b in list)
						{
							aru aru = ((c5x)b0b).c();
							if (aspect != null && aspect.i())
							{
								app app;
								aru.e().TryGetValue("alarm", out app);
								if (app == null)
								{
									aru.a("alarm", "PrisonAlarm", 0.15f, c9z.a, true, false);
								}
							}
							else
							{
								aru.a("alarm", false);
							}
						}
					}
				}
			}
		}
	}
}
