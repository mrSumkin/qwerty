using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Characters;

// Token: 0x0200142A RID: 5162
[bs6("PanicExpiresAction")]
[eiz("P12")]
[Serializable]
public sealed class ehm : bhv, ISerializable
{
	// Token: 0x060073BF RID: 29631 RVA: 0x0030E5AC File Offset: 0x0030C7AC
	private ehm(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060073C0 RID: 29632 RVA: 0x0030E5B8 File Offset: 0x0030C7B8
	public ehm()
	{
	}

	// Token: 0x060073C1 RID: 29633 RVA: 0x0030E5C4 File Offset: 0x0030C7C4
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		if (base.x0().a() != null && (base.x0().a().ImmunitiesBase & CharacterImmunities.Fear) != CharacterImmunities.Fear)
		{
			base.x0().a().StatusEffects.a(new ciu(Math.Max(d0u.b * 3, base.xy().Duration)), false, false, false);
		}
		return dc4.c;
	}
}
