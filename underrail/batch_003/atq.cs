using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Characters;

// Token: 0x02001A36 RID: 6710
[eiz("F19")]
[Serializable]
public sealed class atq : d3e, ISerializable
{
	// Token: 0x06009181 RID: 37249 RVA: 0x0039D1C4 File Offset: 0x0039B3C4
	private atq(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06009182 RID: 37250 RVA: 0x0039D1D0 File Offset: 0x0039B3D0
	public atq()
	{
	}

	// Token: 0x06009183 RID: 37251 RVA: 0x0039D1D8 File Offset: 0x0039B3D8
	protected override void @in(ll A_0)
	{
		A_0.a().Immunities |= CharacterImmunities.Fear;
	}

	// Token: 0x06009184 RID: 37252 RVA: 0x0039D1F4 File Offset: 0x0039B3F4
	public override d3e b3()
	{
		atq atq = new atq();
		this.xx(atq);
		return atq;
	}
}
