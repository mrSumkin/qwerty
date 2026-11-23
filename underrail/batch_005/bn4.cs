using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Playfield.Locale;

// Token: 0x02001599 RID: 5529
[eiz("SACA1")]
[Serializable]
public sealed class bn4 : pl, ISerializable
{
	// Token: 0x06007AB2 RID: 31410 RVA: 0x00335CF0 File Offset: 0x00333EF0
	private bn4(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() == 0)
		{
			base.GetType() == typeof(bn4);
		}
	}

	// Token: 0x06007AB3 RID: 31411 RVA: 0x00335D1C File Offset: 0x00333F1C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
	}

	// Token: 0x06007AB4 RID: 31412 RVA: 0x00335D28 File Offset: 0x00333F28
	public override CharacterState? m3()
	{
		return new CharacterState?(CharacterState.Attack1);
	}

	// Token: 0x06007AB5 RID: 31413 RVA: 0x00335D30 File Offset: 0x00333F30
	public override CharacterState? q1()
	{
		if (!(base.vg().e().p() is eua))
		{
			return new CharacterState?(CharacterState.Attack1);
		}
		return base.q1();
	}

	// Token: 0x06007AB6 RID: 31414 RVA: 0x00335D5C File Offset: 0x00333F5C
	public override int? tm()
	{
		return new int?(0);
	}

	// Token: 0x06007AB7 RID: 31415 RVA: 0x00335D64 File Offset: 0x00333F64
	public bn4(ad5 A_0) : base(A_0)
	{
	}
}
