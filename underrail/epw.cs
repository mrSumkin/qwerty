using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using TimelapseVertigo.Playfield.Locale;

// Token: 0x02001100 RID: 4352
[eiz("S44")]
[Serializable]
public sealed class epw : cze, ISerializable
{
	// Token: 0x06005C53 RID: 23635 RVA: 0x00277BA8 File Offset: 0x00275DA8
	private epw(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (A_0.GetValue("S44:S", typeof(CharacterState?)) as CharacterState?);
	}

	// Token: 0x06005C54 RID: 23636 RVA: 0x00277BD8 File Offset: 0x00275DD8
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("S44:S", this.a);
	}

	// Token: 0x06005C55 RID: 23637 RVA: 0x00277BF8 File Offset: 0x00275DF8
	public CharacterState? a()
	{
		return this.a;
	}

	// Token: 0x06005C56 RID: 23638 RVA: 0x00277C00 File Offset: 0x00275E00
	public void a(CharacterState? A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06005C57 RID: 23639 RVA: 0x00277C0C File Offset: 0x00275E0C
	public epw()
	{
	}

	// Token: 0x06005C58 RID: 23640 RVA: 0x00277C14 File Offset: 0x00275E14
	public epw(CharacterState? A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06005C59 RID: 23641 RVA: 0x00277C24 File Offset: 0x00275E24
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		c5x c5x = A_1 as c5x;
		if (c5x != null && c5x.h.b != null)
		{
			c5x.h.b.ap = this.a;
		}
	}

	// Token: 0x040024D8 RID: 9432
	private new CharacterState? a;
}
