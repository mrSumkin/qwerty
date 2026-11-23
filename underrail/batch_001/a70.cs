using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x02000AC3 RID: 2755
[eiz("XPBLWUAS")]
[Serializable]
public sealed class a70 : cze, ISerializable
{
	// Token: 0x06004036 RID: 16438 RVA: 0x00186708 File Offset: 0x00184908
	private a70(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06004037 RID: 16439 RVA: 0x00186714 File Offset: 0x00184914
	public a70()
	{
	}

	// Token: 0x06004038 RID: 16440 RVA: 0x00186720 File Offset: 0x00184920
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && serviceOrThrow.aqw() != null)
		{
			string name = string.Format("loc_{0}_alarmActive", serviceOrThrow.aqw().y8());
			TimeSpan value = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<TimeSpan>("loc_xpbl_wumb_alarmActiveUntil", new TimeSpan?(TimeSpan.Zero)).Value;
			bool value2 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>(name, new bool?(false)).Value;
			bool flag = value > serviceOrThrow.aqu().p();
			if (flag && serviceOrThrow.aqw().y8() == "xpbl_wumb1" && !serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_xpbl_wumb_specialForcesSentIn", new bool?(false)).Value)
			{
				int num = 0;
				foreach (d4n d4n in bpo.GetServiceOrThrow<d02>().ahl())
				{
					if (d4n.b != null && d4n.b.aa().FactionId == asp.fn)
					{
						num++;
					}
				}
				if (num <= 10)
				{
					serviceOrThrow.aqu().r()["loc_xpbl_wumb_specialForcesSentIn"] = true;
					doq a_ = doq.a(Path.Combine(d5x.q(), "xpbl_wumb1_l2") + ".uzl");
					serviceOrThrow.aqw().a(a_, aju.x, null);
					b6r b6r = new b6r();
					b6r.a(bbo.b);
					b6r.b(new Guid("b60e7d4b-5340-4069-9c71-b6584178f63d"));
					b6r.a(new Guid("0bdf986f-4762-4ebf-80c1-4bd66acb18b4"));
					b6r.b("xpbl_wumb1");
					b6r.ym(A_0, A_1, null);
					b6r b6r2 = new b6r();
					b6r2.a(bbo.b);
					b6r2.b(new Guid("486434a5-3a4a-41aa-8034-2d062b95792e"));
					b6r2.a(new Guid("9e00ce5a-eaaa-4956-8077-b48d6f1d1b91"));
					b6r2.b("xpbl_wumb1");
					b6r2.ym(A_0, A_1, null);
					new eb7(new Guid?(new Guid("925e5ce0-8016-45e9-a645-80c2ff233f06")), false).ym(A_0, A_1, null);
				}
			}
			if (flag != value2)
			{
				serviceOrThrow.aqu().r()[name] = flag;
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
							c5x c5x = (c5x)b0b;
							aru aru = c5x.c();
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
							alv aspect = c5x.GetAspect<alv>();
							if (aspect != null && aspect.a.Count >= 2)
							{
								if (flag)
								{
									aspect.a[1].d = null;
									aspect.a[1].c = new Color?(Color.White);
								}
								else
								{
									aspect.a[1].d = new float?(0f);
								}
							}
						}
					}
				}
				foreach (aud aud in serviceOrThrow.aqw().Areas)
				{
					foreach (b0b b0b2 in aud.Entities)
					{
						c5x c5x2 = (c5x)b0b2;
						if (c5x2.t.b != null)
						{
							List<string> classPropertyValue = c5x2.t.b.y6().GetClassPropertyValue<List<string>>("AlarmPatrolRoute");
							List<string> classPropertyValue2 = c5x2.t.b.y6().GetClassPropertyValue<List<string>>(ddq.k);
							bt4 classPropertyValue3 = c5x2.t.b.y6().GetClassPropertyValue<bt4>(ddq.ay);
							bt4 classPropertyValue4 = c5x2.t.b.y6().GetClassPropertyValue<bt4>("NoAlarmGuardLoc");
							int num2;
							if (c5x2.t.b.y6().GetPrimitivePropertyValue<bool>("AlarmPatrol", new bool?(false)).Value)
							{
								if (flag)
								{
									if (classPropertyValue2 == null && classPropertyValue != null)
									{
										c5x2.t.b.y6()[ddq.k] = classPropertyValue;
										c5x2.t.b.y6().RemoveProperty("AlarmPatrolRoute");
									}
									if (classPropertyValue3 != null && classPropertyValue4 == null)
									{
										c5x2.t.b.y6()["NoAlarmGuardLoc"] = classPropertyValue3;
										c5x2.t.b.y6().RemoveProperty(ddq.ay);
									}
								}
								else
								{
									if (classPropertyValue2 != null)
									{
										c5x2.t.b.y6().RemoveProperty(ddq.k);
										c5x2.t.b.y6()["NoAlarmGuardLoc"] = classPropertyValue2;
									}
									if (classPropertyValue3 == null && classPropertyValue4 != null)
									{
										c5x2.t.b.y6()[ddq.ay] = classPropertyValue4;
									}
								}
							}
							else if (classPropertyValue3 != null && classPropertyValue3.d() && (classPropertyValue3.b().StartsWith("A", StringComparison.OrdinalIgnoreCase) || classPropertyValue3.b().StartsWith("NA", StringComparison.OrdinalIgnoreCase)) && int.TryParse(classPropertyValue3.b().Replace("A", "").Replace("N", ""), NumberStyles.Number, CultureInfo.InvariantCulture, out num2))
							{
								string a_2;
								if (flag)
								{
									a_2 = string.Format("A{0}", num2);
								}
								else
								{
									a_2 = string.Format("NA{0}", num2);
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
