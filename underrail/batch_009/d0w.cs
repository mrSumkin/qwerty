using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Ouroboros.Playfield.References;

// Token: 0x02000B2C RID: 2860
[eiz("GSFWR4")]
[Serializable]
public sealed class d0w : cze, ISerializable
{
	// Token: 0x060041F7 RID: 16887 RVA: 0x00198D64 File Offset: 0x00196F64
	private d0w(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060041F8 RID: 16888 RVA: 0x00198D70 File Offset: 0x00196F70
	public d0w()
	{
	}

	// Token: 0x060041F9 RID: 16889 RVA: 0x00198D7C File Offset: 0x00196F7C
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		if (A_1 != null && A_1.Zone != null)
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			int num = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("gms_l3_raidersKilled", new int?(0)).Value;
			num++;
			serviceOrThrow.aqu().r()["gms_l3_raidersKilled"] = num;
			if (num >= 8 && serviceOrThrow.aqu() != null)
			{
				serviceOrThrow.aqu().r()["gms_l3_allRaidersDead"] = true;
				aud aud = (serviceOrThrow.aqu().v().b() as c5x).Area;
				c5x c5x = new ar7(new Guid("77c5c7c9-8376-4146-85f3-76523689f473"), aud).ao() as c5x;
				c5x c5x2 = new ar7(new Guid("5bfbfa6b-75fc-4a95-ab43-38af664a9a20"), aud).ao() as c5x;
				c5x c5x3 = new ar7(new Guid("bde9cbb2-b0eb-47be-9568-108c22053ab8"), aud).ao() as c5x;
				c5x c5x4 = new ar7(new Guid("40a33185-6d36-4a1f-a411-95c75e70a99c"), aud).ao() as c5x;
				d2b d2b = new EntityAspectReference<d2b, d2b>(aud, new Guid("333f670f-c227-4dc3-8881-a2efe6006e8d")).ao();
				if (c5x3 != null)
				{
					c5x3.t.b.y6()[ddq.ay] = new bt4("freeCitizen1");
				}
				if (c5x4 != null)
				{
					c5x4.t.b.y6()[ddq.ay] = new bt4("freeCitizen2");
				}
				if (c5x2 != null)
				{
					if (d2b != null && !d2b.n())
					{
						c5x2.t.b.y6()[ddq.ay] = new bt4("freeHostage");
					}
					else
					{
						c5x2.t.b.y6()[ddq.ay] = new bt4("freeHostageLocked");
					}
				}
				if (c5x != null)
				{
					c5x.t.b.y6()[ddq.ay] = new bt4("leaderLoc");
				}
			}
		}
	}
}
