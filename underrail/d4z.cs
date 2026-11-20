using System;
using System.Runtime.Serialization;

// Token: 0x02001424 RID: 5156
[bs6("ScExpiresAction")]
[eiz("SC11")]
[Serializable]
public sealed class d4z : bhv, ISerializable
{
	// Token: 0x0600739C RID: 29596 RVA: 0x0030C040 File Offset: 0x0030A240
	private d4z(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600739D RID: 29597 RVA: 0x0030C04C File Offset: 0x0030A24C
	public d4z()
	{
	}

	// Token: 0x0600739E RID: 29598 RVA: 0x0030C058 File Offset: 0x0030A258
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		if (base.x2() != null)
		{
			e8o.a(base.x2().a8());
			base.x0().a().StatusEffects.a(new b0y(d0u.b * 2), false, false, false);
		}
		return dc4.c;
	}
}
