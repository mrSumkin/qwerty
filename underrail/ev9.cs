using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Playfield.Locale;

// Token: 0x0200159A RID: 5530
[eiz("SACTA")]
[Serializable]
public sealed class ev9 : boa, ISerializable
{
	// Token: 0x06007AB8 RID: 31416 RVA: 0x00335D70 File Offset: 0x00333F70
	private ev9(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06007AB9 RID: 31417 RVA: 0x00335D7C File Offset: 0x00333F7C
	public override CharacterState? q1()
	{
		return new CharacterState?(CharacterState.Attack1);
	}

	// Token: 0x06007ABA RID: 31418 RVA: 0x00335D84 File Offset: 0x00333F84
	public override int au6()
	{
		return dz6.b(cux.f);
	}

	// Token: 0x06007ABB RID: 31419 RVA: 0x00335D90 File Offset: 0x00333F90
	public ev9(ad5 A_0, afq A_1, params evd[] A_2) : base(A_0, A_1, A_2)
	{
	}
}
