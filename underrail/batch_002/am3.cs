using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Playfield.Locale;

// Token: 0x02001494 RID: 5268
[eiz("UCTA")]
[Serializable]
public sealed class am3 : boa, ISerializable
{
	// Token: 0x060076B5 RID: 30389 RVA: 0x00323C40 File Offset: 0x00321E40
	private am3(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() == 0)
		{
			base.GetType() == typeof(am3);
		}
	}

	// Token: 0x060076B6 RID: 30390 RVA: 0x00323C6C File Offset: 0x00321E6C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
	}

	// Token: 0x060076B7 RID: 30391 RVA: 0x00323C78 File Offset: 0x00321E78
	public override CharacterState? q1()
	{
		return new CharacterState?(CharacterState.Operating);
	}

	// Token: 0x060076B8 RID: 30392 RVA: 0x00323C80 File Offset: 0x00321E80
	public am3(ad5 A_0, afq A_1, params evd[] A_2) : base(A_0, A_1, A_2)
	{
	}
}
