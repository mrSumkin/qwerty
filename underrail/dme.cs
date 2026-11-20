using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.Space;

// Token: 0x02000A7A RID: 2682
[eiz("LUUFBSJ")]
[Serializable]
public sealed class dme : cze, ISerializable
{
	// Token: 0x06003F2A RID: 16170 RVA: 0x0017E4FC File Offset: 0x0017C6FC
	private dme(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06003F2B RID: 16171 RVA: 0x0017E508 File Offset: 0x0017C708
	public dme()
	{
	}

	// Token: 0x06003F2C RID: 16172 RVA: 0x0017E514 File Offset: 0x0017C714
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		d02 service = bpo.GetService<d02>();
		if (serviceOrThrow.aqu() != null && service != null && A_1 != null && A_1.Zone != null)
		{
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
			if (!serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_cc_facelessRetreated", new bool?(false)).Value)
			{
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
						break;
					}
					List<csd> list2 = new List<csd>();
					foreach (csd csd2 in Enumerable.Where<csd>(c1a.Waypoints, new Func<csd, bool>(dme.a.a.a)))
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
						if (c5x != null && c5x.t.b != null)
						{
							string a_3 = list[cuo.a.Next(list.Count)];
							c5x.t.b.y6()[ddq.ay] = new bt4(a_3);
						}
					}
				}
			}
		}
	}

	// Token: 0x02000A7B RID: 2683
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06003F2F RID: 16175 RVA: 0x0017E908 File Offset: 0x0017CB08
		internal bool a(csd A_0)
		{
			return A_0.Name != null && A_0.Name.StartsWith("facelessIn");
		}

		// Token: 0x04001BD2 RID: 7122
		public static readonly dme.a a = new dme.a();

		// Token: 0x04001BD3 RID: 7123
		public static Func<csd, bool> b;
	}
}
