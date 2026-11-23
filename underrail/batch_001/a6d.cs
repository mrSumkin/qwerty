using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.Space;
using TimelapseVertigo.Rules;

// Token: 0x02000A8A RID: 2698
[eiz("TCHUISJ")]
[Serializable]
public sealed class a6d : cze, ISerializable
{
	// Token: 0x06003F60 RID: 16224 RVA: 0x0017FF10 File Offset: 0x0017E110
	private a6d(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06003F61 RID: 16225 RVA: 0x0017FF1C File Offset: 0x0017E11C
	public a6d()
	{
	}

	// Token: 0x06003F62 RID: 16226 RVA: 0x0017FF28 File Offset: 0x0017E128
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		d02 service = bpo.GetService<d02>();
		if (serviceOrThrow.aqu() != null && service != null && A_1 != null && A_1.Zone != null)
		{
			bool value = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_tch_tremorsStarted", new bool?(false)).Value;
			bool value2 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_tch_spawnedFacelessExpedition", new bool?(false)).Value;
			if (serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_tch_invasionStarted", new bool?(false)).Value)
			{
				new dvn(serviceOrThrow.ar0(serviceOrThrow.aqu().c().b(), serviceOrThrow.aqu()).Id, "Faceless").ym(null, null, null);
				string[] array = new string[]
				{
					"creature\\Faceless\\FacelessSoldier-AssaultRifle",
					"creature\\Faceless\\FacelessSoldier-EnergyPistol",
					"creature\\Faceless\\FacelessSoldier-Sledgehammer",
					"creature\\Faceless\\FacelessSoldier-Smg",
					"creatures\\Faceless\\FacelessDoctor",
					"creatures\\Faceless\\FacelessDoctor",
					"creatures\\Faceless\\FacelessCentaur",
					"creatures\\Faceless\\FacelessCentaur",
					"creatures\\Faceless\\FacelessMindreader",
					"creatures\\Faceless\\FacelessMindreader",
					"creatures\\Faceless\\AugmentedRathound",
					"creatures\\Faceless\\AugmentedRathound"
				};
				c1a c1a = A_1.Zone;
				for (int i = 0; i < 10; i++)
				{
					int num = 0;
					List<string> list = new List<string>();
					foreach (csd csd in c1a.Waypoints)
					{
						if (csd.Name.StartsWith("facelessGuard"))
						{
							list.Add(csd.Name);
							num++;
						}
					}
					int num2 = 0;
					foreach (d4n d4n in service.ahl())
					{
						if (d4n.b != null && (d4n.b.aa().FactionId == asp.cc || d4n.b.aa().FactionId == asp.cd))
						{
							num2++;
							if (d4n.b.a8() != null && d4n.b.a8().t.b != null)
							{
								bt4 classPropertyValue = d4n.b.a8().t.b.y6().GetClassPropertyValue<bt4>(ddq.ay);
								if (classPropertyValue != null && classPropertyValue.d())
								{
									list.Remove(classPropertyValue.b());
								}
							}
						}
					}
					if (num2 >= num || list.Count <= 0)
					{
						return;
					}
					List<csd> list2 = new List<csd>();
					foreach (csd csd2 in Enumerable.Where<csd>(c1a.Waypoints, new Func<csd, bool>(a6d.a.a.a)))
					{
						aud aud;
						Vector3 a_;
						HorizontalDirection horizontalDirection;
						new bt4(csd2.Name).a(c1a, out aud, out a_, out horizontalDirection);
						ak1 ak = aud.a(a_.a());
						if (ak != null && !aw1.a(null, ak, false, null))
						{
							list2.Add(csd2);
						}
					}
					if (list2.Count > 0)
					{
						csd a_2 = list2[cuo.a.Next(list2.Count)];
						c5x c5x = vq.a(array[cuo.a.Next(array.Length)], a_2, false);
						if (c5x != null)
						{
							if (c5x.t.b != null)
							{
								string a_3 = list[cuo.a.Next(list.Count)];
								c5x.t.b.y6()[ddq.ay] = new bt4(a_3);
							}
							if (c5x.h.b != null)
							{
								a6p aspect = c5x.GetAspect<a6p>();
								if (aspect != null)
								{
									aspect.d().Add("-jobs");
								}
								c5x.h.b.ay().Clear();
								bu6 serviceOrThrow2 = bpo.GetServiceOrThrow<bu6>();
								if (serviceOrThrow2.aq2() == GameDifficulty.Hard)
								{
									cu0 a_4 = new cu0(0, 0.5);
									c5x.h.b.aa().StatusEffects.a(a_4, false, false, false);
								}
								else if (serviceOrThrow2.aq2() == GameDifficulty.Dominating)
								{
									cu0 a_5 = new cu0(0, 1.0);
									c5x.h.b.aa().StatusEffects.a(a_5, false, false, false);
								}
							}
						}
					}
				}
				return;
			}
			if (value)
			{
				if (!value2)
				{
					serviceOrThrow.aqu().a(new bw0("tch-ww5", new xh(), 1));
					serviceOrThrow.aqu().r()["loc_tch_spawnedFacelessExpedition"] = true;
				}
				if (!string.Equals(A_1.Zone.y8(), "tch-entry"))
				{
					TimeSpan? primitivePropertyValue = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<TimeSpan>("loc_tch_nextTremor", null);
					bool flag = false;
					if (primitivePropertyValue == null)
					{
						flag = true;
					}
					else if (primitivePropertyValue.Value < serviceOrThrow.aqu().p())
					{
						ps service2 = bpo.GetService<ps>();
						if (service2 != null)
						{
							service2.ane(2000, null, null, null, null, null);
						}
						if (serviceOrThrow.aqu().v() != null)
						{
							c5x c5x2 = serviceOrThrow.aqu().v().b() as c5x;
							if (c5x2 != null)
							{
								c5x2.c().a("EarthquakeShort");
							}
						}
						flag = true;
					}
					if (flag)
					{
						primitivePropertyValue = new TimeSpan?(serviceOrThrow.aqu().p() + TimeSpan.FromSeconds((double)(30 + cuo.a.Next(15))));
						serviceOrThrow.aqu().r()["loc_tch_nextTremor"] = primitivePropertyValue;
						return;
					}
				}
			}
			else if (!string.Equals(A_1.Zone.y8(), "tch-entry"))
			{
				cky cky = (serviceOrThrow.aqu().ac() as bv9).abu(asp.a, asp.es);
				if (cky != null && cky.a == h.a)
				{
					serviceOrThrow.aqu().r()["loc_tch_tremorsStarted"] = true;
				}
			}
		}
	}

	// Token: 0x04001BD6 RID: 7126
	private new const int a = 20;

	// Token: 0x04001BD7 RID: 7127
	private const int b = 35;

	// Token: 0x02000A8B RID: 2699
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06003F65 RID: 16229 RVA: 0x0018066C File Offset: 0x0017E86C
		internal bool a(csd A_0)
		{
			return A_0.Name != null && A_0.Name.StartsWith("facelessIn");
		}

		// Token: 0x04001BD8 RID: 7128
		public static readonly a6d.a a = new a6d.a();

		// Token: 0x04001BD9 RID: 7129
		public static Func<csd, bool> b;
	}
}
