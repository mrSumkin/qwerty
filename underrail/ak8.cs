using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02000B08 RID: 2824
[eiz("XPBLFRCIPSGPF")]
[Serializable]
public sealed class ak8 : cze, ISerializable
{
	// Token: 0x0600415C RID: 16732 RVA: 0x001901E0 File Offset: 0x0018E3E0
	private ak8(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600415D RID: 16733 RVA: 0x001901EC File Offset: 0x0018E3EC
	public ak8()
	{
	}

	// Token: 0x0600415E RID: 16734 RVA: 0x001901F8 File Offset: 0x0018E3F8
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null)
		{
			int value = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("npc_xpbl_ferryman_philosoFeatScore", new int?(0)).Value;
			string str = "Philosophy";
			if (!serviceOrThrow.aqu().v().Feats.a(ck.a(str + 3.ToString())))
			{
				if (value >= 5 && !serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_xpbl_ferryman_attitude_friendly", new bool?(false)).Value)
				{
					serviceOrThrow.aqu().r()["npc_xpbl_ferryman_attitude_friendly"] = true;
				}
				if (value >= 13)
				{
					this.b(str + 2.ToString());
					this.b(str + 1.ToString());
					this.a(str + 3.ToString());
					return;
				}
				if (value >= 9)
				{
					if (!serviceOrThrow.aqu().v().Feats.a(ck.a(str + 2.ToString())))
					{
						this.b(str + 1.ToString());
						this.a(str + 2.ToString());
						return;
					}
				}
				else if (value >= 4 && !serviceOrThrow.aqu().v().Feats.a(ck.a(str + 1.ToString())))
				{
					this.a(str + 1.ToString());
				}
			}
		}
	}

	// Token: 0x0600415F RID: 16735 RVA: 0x001903B8 File Offset: 0x0018E5B8
	private void b(string A_0)
	{
		a9w a9w = new a9w();
		a9w.a(A_0);
		a9w.a(true);
		a9w.ym(null, null, null);
	}

	// Token: 0x06004160 RID: 16736 RVA: 0x001903E0 File Offset: 0x0018E5E0
	private void a(string A_0)
	{
		c93 c = new c93();
		c.a(A_0);
		c.a(true);
		c.ym(null, null, null);
	}
}
