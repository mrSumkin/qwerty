using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Playfield.Locale;

// Token: 0x02001631 RID: 5681
[eiz("PCA2")]
[Serializable]
public sealed class axs : pl, ISerializable
{
	// Token: 0x06007CC9 RID: 31945 RVA: 0x0034B470 File Offset: 0x00349670
	private axs(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() == 0)
		{
			base.GetType() == typeof(axs);
		}
	}

	// Token: 0x06007CCA RID: 31946 RVA: 0x0034B49C File Offset: 0x0034969C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
	}

	// Token: 0x06007CCB RID: 31947 RVA: 0x0034B4A8 File Offset: 0x003496A8
	public override CharacterState? m3()
	{
		return new CharacterState?(CharacterState.CastingPsi);
	}

	// Token: 0x06007CCC RID: 31948 RVA: 0x0034B4B0 File Offset: 0x003496B0
	public axs(ad5 A_0) : base(A_0)
	{
	}
}
