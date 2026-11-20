using System;
using System.Runtime.Serialization;

// Token: 0x02000C7D RID: 3197
[eiz("EBADE")]
[Serializable]
public sealed class ehh : cd2
{
	// Token: 0x06004831 RID: 18481 RVA: 0x001D9970 File Offset: 0x001D7B70
	private ehh(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06004832 RID: 18482 RVA: 0x001D997C File Offset: 0x001D7B7C
	public override TimeSpan ge()
	{
		return TimeSpan.FromMinutes(8.0);
	}

	// Token: 0x06004833 RID: 18483 RVA: 0x001D998C File Offset: 0x001D7B8C
	public override TimeSpan gf()
	{
		return TimeSpan.FromMinutes(4.0);
	}

	// Token: 0x06004834 RID: 18484 RVA: 0x001D999C File Offset: 0x001D7B9C
	public ehh() : base(ehh.a)
	{
	}

	// Token: 0x06004835 RID: 18485 RVA: 0x001D99AC File Offset: 0x001D7BAC
	protected override void gg(cyt A_0)
	{
		A_0.r()["quest_xpbl_boneyard_ambushing"] = false;
	}

	// Token: 0x04001CAF RID: 7343
	public new static readonly string a = "endBoneyardAmbushing";
}
