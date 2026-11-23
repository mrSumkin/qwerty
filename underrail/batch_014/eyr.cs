using System;
using System.Runtime.Serialization;

// Token: 0x02001A85 RID: 6789
[eiz("MWASE")]
[Serializable]
public sealed class eyr : els, ISerializable
{
	// Token: 0x06009368 RID: 37736 RVA: 0x003A24D0 File Offset: 0x003A06D0
	private eyr(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetInt32("MWASE:I");
	}

	// Token: 0x06009369 RID: 37737 RVA: 0x003A24EC File Offset: 0x003A06EC
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("MWASE:I", this.a);
	}

	// Token: 0x17000270 RID: 624
	// (get) Token: 0x0600936A RID: 37738 RVA: 0x003A2508 File Offset: 0x003A0708
	public override bool Visible
	{
		get
		{
			return false;
		}
	}

	// Token: 0x0600936B RID: 37739 RVA: 0x003A2510 File Offset: 0x003A0710
	public eyr(int A_0) : base(eyr.b, "Ломка от движения", ci8.c)
	{
		base.Duration = A_0;
		base.Stacking = axm.b;
		base.Icon = "Misc.0";
		this.y = "MotionWithdrawalAggregatorExpires";
		this.aa = "MotionWithdrawalAggregatorExpires";
	}

	// Token: 0x0600936C RID: 37740 RVA: 0x003A2560 File Offset: 0x003A0760
	public override string cb(ll A_0)
	{
		return "";
	}

	// Token: 0x04003899 RID: 14489
	public new int a;

	// Token: 0x0400389A RID: 14490
	public static readonly string b = "motionWithdrawalAggregator";
}
