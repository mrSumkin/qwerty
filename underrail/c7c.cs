using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Playfield.Locale;

// Token: 0x0200145C RID: 5212
[eiz("NCTA")]
[Serializable]
public sealed class c7c : boa, ISerializable
{
	// Token: 0x06007573 RID: 30067 RVA: 0x0031C4D8 File Offset: 0x0031A6D8
	private c7c(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (A_0.GetValue("NCTA:S", typeof(CharacterState?)) as CharacterState?);
	}

	// Token: 0x06007574 RID: 30068 RVA: 0x0031C508 File Offset: 0x0031A708
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("NCTA:S", this.a);
	}

	// Token: 0x06007575 RID: 30069 RVA: 0x0031C528 File Offset: 0x0031A728
	public override CharacterState? q1()
	{
		return this.a;
	}

	// Token: 0x06007576 RID: 30070 RVA: 0x0031C530 File Offset: 0x0031A730
	public c7c(ad5 A_0, CharacterState? A_1, afq A_2, params evd[] A_3) : base(A_0, A_2, A_3)
	{
		this.a = A_1;
	}

	// Token: 0x04003013 RID: 12307
	private new CharacterState? a;
}
