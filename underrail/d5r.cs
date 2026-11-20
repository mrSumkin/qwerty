using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Playfield.Locale;

// Token: 0x020017DB RID: 6107
[eiz("CCTA")]
[Serializable]
public sealed class d5r : boa, ISerializable
{
	// Token: 0x0600821C RID: 33308 RVA: 0x0036C49C File Offset: 0x0036A69C
	private d5r(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() == 0)
		{
			base.GetType() == typeof(d5r);
		}
	}

	// Token: 0x0600821D RID: 33309 RVA: 0x0036C4C8 File Offset: 0x0036A6C8
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
	}

	// Token: 0x0600821E RID: 33310 RVA: 0x0036C4D4 File Offset: 0x0036A6D4
	public override CharacterState? q1()
	{
		return new CharacterState?(CharacterState.Operating);
	}

	// Token: 0x0600821F RID: 33311 RVA: 0x0036C4DC File Offset: 0x0036A6DC
	public override bool aqt()
	{
		return false;
	}

	// Token: 0x06008220 RID: 33312 RVA: 0x0036C4E0 File Offset: 0x0036A6E0
	public d5r(ad5 A_0, afq A_1, params evd[] A_2) : base(A_0, A_1, A_2)
	{
	}
}
