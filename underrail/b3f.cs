using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Playfield.Locale;

// Token: 0x0200145B RID: 5211
[eiz("NCA")]
[Serializable]
public sealed class b3f : pl, ISerializable
{
	// Token: 0x0600756E RID: 30062 RVA: 0x0031C3FC File Offset: 0x0031A5FC
	private b3f(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (A_0.GetValue("NCA:S", typeof(CharacterState?)) as CharacterState?);
		this.b = (A_0.GetValue("NCA:PS", typeof(int?)) as int?);
	}

	// Token: 0x0600756F RID: 30063 RVA: 0x0031C45C File Offset: 0x0031A65C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("NCA:S", this.a);
		info.AddValue("NCA:PS", this.b);
	}

	// Token: 0x06007570 RID: 30064 RVA: 0x0031C494 File Offset: 0x0031A694
	public override CharacterState? m3()
	{
		return this.a;
	}

	// Token: 0x06007571 RID: 30065 RVA: 0x0031C49C File Offset: 0x0031A69C
	public b3f(ad5 A_0, CharacterState? A_1 = null, int? A_2 = null) : base(A_0)
	{
		this.a = A_1;
		this.b = A_2;
	}

	// Token: 0x06007572 RID: 30066 RVA: 0x0031C4B4 File Offset: 0x0031A6B4
	protected override int ade()
	{
		if (this.b != null)
		{
			return this.b.Value;
		}
		return int.MaxValue;
	}

	// Token: 0x04003011 RID: 12305
	private new CharacterState? a;

	// Token: 0x04003012 RID: 12306
	private int? b;
}
