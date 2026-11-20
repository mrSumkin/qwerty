using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Playfield.Locale;

// Token: 0x02001457 RID: 5207
[eiz("GTCA")]
[Serializable]
public sealed class dre : pl, ISerializable
{
	// Token: 0x06007524 RID: 29988 RVA: 0x0031A5DC File Offset: 0x003187DC
	private dre(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06007525 RID: 29989 RVA: 0x0031A5E8 File Offset: 0x003187E8
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
	}

	// Token: 0x06007526 RID: 29990 RVA: 0x0031A5F4 File Offset: 0x003187F4
	public override CharacterState? m3()
	{
		return new CharacterState?(CharacterState.Throw);
	}

	// Token: 0x06007527 RID: 29991 RVA: 0x0031A5FC File Offset: 0x003187FC
	public dre(ad5 A_0) : base(A_0)
	{
	}

	// Token: 0x06007528 RID: 29992 RVA: 0x0031A608 File Offset: 0x00318808
	protected override int ade()
	{
		return 100000;
	}
}
