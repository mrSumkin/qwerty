using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02001019 RID: 4121
[eiz("FOEJ2")]
[Serializable]
public sealed class akm : cze, ISerializable
{
	// Token: 0x06005506 RID: 21766 RVA: 0x0025A2E8 File Offset: 0x002584E8
	private akm(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetBoolean("FOEJ2:SDAE");
	}

	// Token: 0x06005507 RID: 21767 RVA: 0x0025A30C File Offset: 0x0025850C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("FOEJ2:SDAE", this.a);
	}

	// Token: 0x06005508 RID: 21768 RVA: 0x0025A328 File Offset: 0x00258528
	public bool a()
	{
		return this.a;
	}

	// Token: 0x06005509 RID: 21769 RVA: 0x0025A330 File Offset: 0x00258530
	public void a(bool A_0)
	{
		this.a = A_0;
	}

	// Token: 0x0600550A RID: 21770 RVA: 0x0025A33C File Offset: 0x0025853C
	public akm()
	{
	}

	// Token: 0x0600550B RID: 21771 RVA: 0x0025A350 File Offset: 0x00258550
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		c5x c5x = A_1 as c5x;
		if (c5x == null || c5x.Zone == null)
		{
			return;
		}
		awx awx = new awx();
		awx awx2 = awx;
		awx2.a(awx2.kh() | m7.b);
		ad6 ad = new ad6(c5x);
		ad.b((double)c5x.ae.GetValueOrDefault(1f));
		ad.c(0.0);
		ad.a(0.0005);
		ad6 item = ad;
		awx.ad().Add(item);
		if (this.a)
		{
			c5x.TileFormationModifiers.c();
			c5x.z();
			List<auv> list = awx.ad();
			uk uk = new uk();
			uk.a(new Guid?(c5x.qe()));
			uk.a(bvl.e);
			list.Add(new a4s(uk, null, null, null));
		}
		c5x.Zone.ActionManager.g9(awx, atp.a);
	}

	// Token: 0x040022B1 RID: 8881
	private new bool a = true;
}
