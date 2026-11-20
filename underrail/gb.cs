using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.Serialization;

// Token: 0x02000AC2 RID: 2754
[eiz("XPBLLEIA")]
[Serializable]
public sealed class gb : cze, ISerializable
{
	// Token: 0x06004033 RID: 16435 RVA: 0x00186270 File Offset: 0x00184470
	private gb(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06004034 RID: 16436 RVA: 0x0018627C File Offset: 0x0018447C
	public gb()
	{
	}

	// Token: 0x06004035 RID: 16437 RVA: 0x00186288 File Offset: 0x00184488
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && serviceOrThrow.aqw() != null)
		{
			d60 addon = serviceOrThrow.aqw().GetAddon<d60>();
			if (addon != null)
			{
				List<b0b> list = addon.ab4(new string[]
				{
					"alarmSoundSource"
				});
				if (list != null && list.Count > 0)
				{
					foreach (b0b b0b in list)
					{
						aru aru = ((c5x)b0b).c();
						app app;
						aru.e().TryGetValue("alarm", out app);
						if (app == null)
						{
							aru.a("alarm", "PrisonAlarm", 0.8f, c9z.b, true, false);
						}
					}
				}
			}
			foreach (aud aud in serviceOrThrow.aqw().Areas)
			{
				foreach (b0b b0b2 in aud.Entities)
				{
					c5x c5x = (c5x)b0b2;
					if (c5x.t.b != null)
					{
						List<string> classPropertyValue = c5x.t.b.y6().GetClassPropertyValue<List<string>>("AlarmPatrolRoute");
						List<string> classPropertyValue2 = c5x.t.b.y6().GetClassPropertyValue<List<string>>(ddq.k);
						bt4 classPropertyValue3 = c5x.t.b.y6().GetClassPropertyValue<bt4>(ddq.ay);
						bt4 classPropertyValue4 = c5x.t.b.y6().GetClassPropertyValue<bt4>("NoAlarmGuardLoc");
						bool value = c5x.t.b.y6().GetPrimitivePropertyValue<bool>("AlarmPatrol", new bool?(false)).Value;
						int num;
						if (c5x.qe() == new Guid("d4ac396e-10f7-4a61-8f0e-941c31813923"))
						{
							c5x.t.b.y6()[ddq.ay] = new bt4("global:xpbl_oldfield:mrchTent");
						}
						else if (c5x.qe() == new Guid("fb77cf3a-ae4a-4ab8-9ef3-695f0920db83"))
						{
							c5x.t.b.y6()[ddq.ay] = new bt4("global:xpbl_briggs:front");
						}
						else if (value)
						{
							if (classPropertyValue2 == null && classPropertyValue != null)
							{
								c5x.t.b.y6()[ddq.k] = classPropertyValue;
								c5x.t.b.y6().RemoveProperty("AlarmPatrolRoute");
							}
							if (classPropertyValue3 != null && classPropertyValue4 == null)
							{
								c5x.t.b.y6()["NoAlarmGuardLoc"] = classPropertyValue3;
								c5x.t.b.y6().RemoveProperty(ddq.ay);
							}
						}
						else if (classPropertyValue3 != null && classPropertyValue3.d() && (classPropertyValue3.b().StartsWith("A", StringComparison.OrdinalIgnoreCase) || classPropertyValue3.b().StartsWith("NA", StringComparison.OrdinalIgnoreCase)) && int.TryParse(classPropertyValue3.b().Replace("A", "").Replace("N", ""), NumberStyles.Number, CultureInfo.InvariantCulture, out num))
						{
							string a_ = string.Format("A{0}", num);
							csd csd = serviceOrThrow.aqw().g(a_);
							if (csd != null)
							{
								c5x.t.b.y6()[ddq.ay] = new bt4(csd.Name);
							}
						}
					}
					if (c5x.qe() == new Guid("eaa0a2ff-1596-468b-988c-60ba825a1d61") && c5x.h.b != null)
					{
						c5x.h.b.aa().Offense.k();
					}
				}
			}
		}
	}
}
