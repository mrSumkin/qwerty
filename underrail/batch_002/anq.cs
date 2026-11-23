using System;
using System.Runtime.Serialization;

// Token: 0x02001ABE RID: 6846
[eiz("SGWSSE")]
[Serializable]
public sealed class anq : els, ISerializable
{
	// Token: 0x0600946D RID: 37997 RVA: 0x003A63D8 File Offset: 0x003A45D8
	private anq(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600946E RID: 37998 RVA: 0x003A63E4 File Offset: 0x003A45E4
	public anq(int A_0, float A_1) : base(anq.a, "Замедление (сеть)", ci8.c)
	{
		base.Icon = "Status.WebSlow";
		base.Duration = A_0;
		base.StaticEffects.Add(new i0(A_1, false, false, false));
	}

	// Token: 0x0600946F RID: 37999 RVA: 0x003A6428 File Offset: 0x003A4628
	public override string cb(ll A_0)
	{
		i0 i = base.StaticEffects[0] as i0;
		return qv.a("StatusEffects/WebSlow", new object[]
		{
			(int)Math.Abs(i.Amount * 100f)
		});
	}

	// Token: 0x04003912 RID: 14610
	public new static readonly string a = "SpiderGroundWebSlow";
}
