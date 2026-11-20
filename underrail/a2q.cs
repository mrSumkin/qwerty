using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x02000AB9 RID: 2745
[eiz("WBBUAS")]
[Serializable]
public sealed class a2q : cze, ISerializable
{
	// Token: 0x06004017 RID: 16407 RVA: 0x001850D4 File Offset: 0x001832D4
	private a2q(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06004018 RID: 16408 RVA: 0x001850E0 File Offset: 0x001832E0
	public a2q()
	{
	}

	// Token: 0x06004019 RID: 16409 RVA: 0x001850EC File Offset: 0x001832EC
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && serviceOrThrow.aqw() != null)
		{
			string name = string.Format("loc_wbb_{0}_alarmActive", serviceOrThrow.aqw().y8());
			TimeSpan value = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<TimeSpan>("loc_wbb_alarmActiveUntil", new TimeSpan?(TimeSpan.Zero)).Value;
			bool value2 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>(name, new bool?(false)).Value;
			bool flag = value > serviceOrThrow.aqu().p();
			if (flag != value2)
			{
				Color color;
				if (flag)
				{
					color = new Color(255, 25, 25);
				}
				else
				{
					color = new Color(200, 200, 50);
				}
				serviceOrThrow.aqu().r()[name] = flag;
				foreach (string a_ in new string[]
				{
					"neon",
					"neonSecurity"
				})
				{
					ah7 ah = serviceOrThrow.aqw().i(a_);
					if (ah != null)
					{
						if (flag)
						{
							ah.Light = new ae8(color, ah.Light.c(), ah.Light.a());
						}
						else
						{
							ah.Light = new ae8(color, ah.Light.c(), ah.Light.a());
						}
						ah.d();
					}
				}
				d60 addon = serviceOrThrow.aqw().GetAddon<d60>();
				if (addon != null)
				{
					List<b0b> list = addon.ab4(new string[]
					{
						"alarmSpeaker"
					});
					if (list != null && list.Count > 0)
					{
						foreach (b0b b0b in list)
						{
							aru aru = ((c5x)b0b).c();
							if (flag)
							{
								app app;
								aru.e().TryGetValue("alarm", out app);
								if (app == null)
								{
									aru.a("alarm", "PrisonAlarm", 0.3f, c9z.b, true, false);
								}
							}
							else
							{
								aru.a("alarm", false);
							}
						}
					}
					List<b0b> list2 = addon.ab4(new string[]
					{
						"powSrc_wbb_neon",
						"powSrc_wbb_security"
					});
					if (list2 != null && list2.Count > 0)
					{
						foreach (b0b b0b2 in list2)
						{
							c5x c5x = (c5x)b0b2;
							if (c5x.p.b != null && c5x.p.b.a.Count == 3)
							{
								c5x.p.b.a[1].c = new Color?(color);
								c5x.p.b.a[2].c = new Color?(color);
							}
						}
					}
				}
				foreach (aud aud in serviceOrThrow.aqw().Areas)
				{
					foreach (b0b b0b3 in aud.Entities)
					{
						c5x c5x2 = (c5x)b0b3;
						if (c5x2.t.b != null)
						{
							bt4 classPropertyValue = c5x2.t.b.y6().GetClassPropertyValue<bt4>(ddq.ay);
							int num;
							if (classPropertyValue != null && classPropertyValue.d() && (classPropertyValue.b().StartsWith("A", StringComparison.OrdinalIgnoreCase) || classPropertyValue.b().StartsWith("NA", StringComparison.OrdinalIgnoreCase)) && int.TryParse(classPropertyValue.b().Replace("A", "").Replace("N", ""), NumberStyles.Number, CultureInfo.InvariantCulture, out num))
							{
								string a_2;
								if (flag)
								{
									a_2 = string.Format("A{0}", num);
								}
								else
								{
									a_2 = string.Format("NA{0}", num);
								}
								csd csd = serviceOrThrow.aqw().g(a_2);
								if (csd != null)
								{
									c5x2.t.b.y6()[ddq.ay] = new bt4(csd.Name);
								}
							}
						}
					}
				}
			}
		}
	}
}
