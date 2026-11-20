using System;
using System.Runtime.Serialization;

// Token: 0x020007E0 RID: 2016
[eiz("RCMBT")]
[Serializable]
public sealed class aj6 : ya, ISerializable
{
	// Token: 0x06003284 RID: 12932 RVA: 0x0013A018 File Offset: 0x00138218
	private aj6(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06003285 RID: 12933 RVA: 0x0013A024 File Offset: 0x00138224
	public aj6()
	{
	}

	// Token: 0x06003286 RID: 12934 RVA: 0x0013A030 File Offset: 0x00138230
	protected override void jk(b0b A_0)
	{
		base.jk(A_0);
		c5x c5x = A_0 as c5x;
		if (c5x != null && c5x.h.b != null && c5x.h.b.aa().Id == "jared")
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() != null)
			{
				serviceOrThrow.aqu().r()["npc_rcjared_enteredMedbay"] = true;
			}
			if (!serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_rc1_jaredCaught", new bool?(false)).Value)
			{
				c5x.h.b.aa().FactionId = "neutral";
				return;
			}
			c5x.h.b.aa().FactionId = "railCrossing";
		}
	}

	// Token: 0x06003287 RID: 12935 RVA: 0x0013A110 File Offset: 0x00138310
	protected override void pq(b0b A_0)
	{
		base.pq(A_0);
		c5x c5x = A_0 as c5x;
		if (c5x != null && c5x.h.b != null && c5x.h.b.aa().Id == "jared")
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() != null)
			{
				serviceOrThrow.aqu().r()["npc_rcjared_enteredMedbay"] = false;
			}
			c5x.h.b.aa().FactionId = "railCrossing";
		}
	}
}
