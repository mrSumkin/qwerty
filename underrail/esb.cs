using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x02000AAD RID: 2733
[eiz("SCHJ")]
[Serializable]
public sealed class esb : cze, ISerializable
{
	// Token: 0x06003FE6 RID: 16358 RVA: 0x00183C6C File Offset: 0x00181E6C
	private esb(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06003FE7 RID: 16359 RVA: 0x00183C78 File Offset: 0x00181E78
	public esb()
	{
	}

	// Token: 0x06003FE8 RID: 16360 RVA: 0x00183C80 File Offset: 0x00181E80
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		if (A_0 != null && A_0.Area != null && A_0.Area.y8() == "StationAlpha-Level8")
		{
			string[] array = esb.a();
			c5k c5k = bpo.GetServiceOrThrow<d6j>().dv().a("locale\\creatures\\cavehopper");
			if (c5k != null)
			{
				esb.a a = new esb.a();
				a.a = 0;
				while (a.a < 3)
				{
					csd csd = Enumerable.FirstOrDefault<csd>(Enumerable.Where<csd>(A_0.Area.Zone.Waypoints, new Func<csd, bool>(a.a)));
					if (csd != null)
					{
						Point a_ = this.a(A_0.Area, csd);
						c5x c5x = c5k.a(null, false) as c5x;
						if (c5x != null)
						{
							c5x.Location = a_.a();
							c5x.Layer = aju.x;
							c5x.VisualDirection = bnx.a();
							if (array != null && array.Length > a.a)
							{
								c5x.q(array[a.a]);
							}
							if (c5x.h.b != null)
							{
								c5x.h.b.aa().FactionId = asp.g;
							}
							a6p aspect = c5x.GetAspect<a6p>();
							if (aspect != null)
							{
								aspect.a(new List<string>
								{
									"full",
									"-system",
									"-ai"
								});
							}
							if (c5x.t.b != null)
							{
								c5x.t.b.b("neutralAnimal");
								c5x.t.b.c("soldier");
							}
							A_0.Area.a(c5x);
						}
					}
					int a2 = a.a;
					a.a = a2 + 1;
				}
			}
		}
	}

	// Token: 0x06003FE9 RID: 16361 RVA: 0x00183E64 File Offset: 0x00182064
	private Point a(aud A_0, csd A_1)
	{
		for (int i = -1; i <= 1; i++)
		{
			for (int j = -1; j <= 1; j++)
			{
				ak1 ak = A_0.b((int)A_1.Location.X + i, (int)A_1.Location.Y + j);
				if (ak != null && !ak.Formation.a(1))
				{
					return ak.Location;
				}
			}
		}
		return A_1.Location.a();
	}

	// Token: 0x06003FEA RID: 16362 RVA: 0x00183EDC File Offset: 0x001820DC
	private static string[] a()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null)
		{
			string classPropertyValue = serviceOrThrow.aqu().r().GetClassPropertyValue<string>("quest_hopperRoundUpQuest_names");
			if (!string.IsNullOrEmpty(classPropertyValue))
			{
				return classPropertyValue.Split(new char[]
				{
					','
				});
			}
		}
		return null;
	}

	// Token: 0x02000AAE RID: 2734
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06003FEC RID: 16364 RVA: 0x00183F38 File Offset: 0x00182138
		internal bool a(csd A_0)
		{
			return A_0.Name == "hopperSpawnPoint" + this.a.ToString();
		}

		// Token: 0x04001BE6 RID: 7142
		public int a;
	}
}
