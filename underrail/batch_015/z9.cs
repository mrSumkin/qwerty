using System;
using System.Runtime.Serialization;

// Token: 0x02000F5A RID: 3930
[eiz("PIWPAC")]
[Serializable]
public sealed class z9 : dnh, ISerializable
{
	// Token: 0x06004FA3 RID: 20387 RVA: 0x0023D4C0 File Offset: 0x0023B6C0
	private z9(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetBoolean("PIWPAC:I");
	}

	// Token: 0x06004FA4 RID: 20388 RVA: 0x0023D4DC File Offset: 0x0023B6DC
	public new void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("PIWPAC:I", this.a);
	}

	// Token: 0x06004FA5 RID: 20389 RVA: 0x0023D4F8 File Offset: 0x0023B6F8
	public bool b()
	{
		return this.a;
	}

	// Token: 0x06004FA6 RID: 20390 RVA: 0x0023D500 File Offset: 0x0023B700
	public void a(bool A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06004FA7 RID: 20391 RVA: 0x0023D50C File Offset: 0x0023B70C
	public z9()
	{
	}

	// Token: 0x06004FA8 RID: 20392 RVA: 0x0023D518 File Offset: 0x0023B718
	public override bool cw(bq8 A_0, bq8 A_1)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		bool flag = false;
		if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null && serviceOrThrow.aqu().v().Gear.l().Item != null)
		{
			string text = serviceOrThrow.aqu().v().Gear.l().Item.fu().e();
			if (text == "prbio" || text == "xpbl_prns")
			{
				flag = true;
			}
		}
		return flag ^ this.a;
	}

	// Token: 0x06004FA9 RID: 20393 RVA: 0x0023D5B8 File Offset: 0x0023B7B8
	public string a()
	{
		return "PlayerIsWearingProtectorateArmorCondition";
	}

	// Token: 0x04002095 RID: 8341
	private bool a;
}
