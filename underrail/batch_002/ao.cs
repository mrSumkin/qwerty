using System;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x02001729 RID: 5929
[eiz("SRSKCA")]
[Serializable]
public sealed class ao : a6k
{
	// Token: 0x0600800F RID: 32783 RVA: 0x00360CB0 File Offset: 0x0035EEB0
	private ao(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06008010 RID: 32784 RVA: 0x00360CBC File Offset: 0x0035EEBC
	public ao()
	{
	}

	// Token: 0x06008011 RID: 32785 RVA: 0x00360CC8 File Offset: 0x0035EEC8
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null)
		{
			double num = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<double>("xpbl_gy_disturbanceLevel", new double?(0.0)).Value;
			num = Math.Min(100.0, num + 5.0);
			serviceOrThrow.aqu().r()["xpbl_gy_disturbanceLevel"] = num;
			string classPropertyValue = serviceOrThrow.aqu().r().GetClassPropertyValue<string>("xpbl_skerderGraveSearchedBodyPart");
			string classPropertyValue2 = serviceOrThrow.aqu().r().GetClassPropertyValue<string>(bp5.m);
			bool value = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("xpbl_shardFound", new bool?(false)).Value;
			if (!string.IsNullOrEmpty(classPropertyValue))
			{
				if (!value && classPropertyValue == classPropertyValue2)
				{
					serviceOrThrow.aqu().r()["xpbl_shardFound"] = true;
					string text = "Вы что-то нашли";
					a7v.a(new h0(text + ".", new Color?(adi.c)));
					bmj.a(base.vg().q(), new d53(text, adi.c, null, false));
					mk mk = new mk();
					mk.StaticItems.z3(new d48(ez2.CreateDefinitonProvider<dj3>("Plot\\xpbl\\shard")), true);
					mk.PublishEventsForPlayer = true;
					mk.GiveTo = bvl.b;
					mk.ym(base.vg().q(), null, null);
				}
				else
				{
					string text2 = "Вы не нашли ничего интересного";
					a7v.a(new h0(text2 + ".", new Color?(adi.h)));
					bmj.a(base.vg().q(), new d53(text2, adi.h, null, false));
				}
				return dc4.c;
			}
		}
		return dc4.e;
	}
}
