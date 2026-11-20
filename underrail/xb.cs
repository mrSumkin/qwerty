using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Playfield.Locale;

// Token: 0x020017DA RID: 6106
[eiz("CCA")]
[Serializable]
public sealed class xb : pl, ISerializable
{
	// Token: 0x06008218 RID: 33304 RVA: 0x0036C43C File Offset: 0x0036A63C
	private xb(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() == 0)
		{
			base.GetType() == typeof(xb);
		}
	}

	// Token: 0x06008219 RID: 33305 RVA: 0x0036C468 File Offset: 0x0036A668
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
	}

	// Token: 0x0600821A RID: 33306 RVA: 0x0036C478 File Offset: 0x0036A678
	public override CharacterState? m3()
	{
		return null;
	}

	// Token: 0x0600821B RID: 33307 RVA: 0x0036C490 File Offset: 0x0036A690
	public xb(ad5 A_0) : base(A_0)
	{
	}
}
