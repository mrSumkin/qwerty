using System;
using System.Runtime.Serialization;

// Token: 0x02001C0C RID: 7180
[eiz("IAI")]
[Serializable]
public sealed class ahx : ISerializable
{
	// Token: 0x06009D81 RID: 40321 RVA: 0x003DE888 File Offset: 0x003DCA88
	private ahx(SerializationInfo A_0, StreamingContext A_1)
	{
		if (ell.a() != 0)
		{
			this.a = A_0.GetDouble("IAI:PR");
			this.b = A_0.GetDouble("IAI:IRC");
			return;
		}
		if (base.GetType() == typeof(ahx))
		{
			this.a = A_0.GetDouble("PushbackReduction");
			this.b = A_0.GetDouble("InterruptionResistChance");
			return;
		}
		this.a = A_0.GetDouble("InterruptibleAttackInfo+PushbackReduction");
		this.b = A_0.GetDouble("InterruptibleAttackInfo+InterruptionResistChance");
	}

	// Token: 0x06009D82 RID: 40322 RVA: 0x003DE928 File Offset: 0x003DCB28
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		info.AddValue("IAI:PR", this.a);
		info.AddValue("IAI:IRC", this.b);
	}

	// Token: 0x06009D83 RID: 40323 RVA: 0x003DE94C File Offset: 0x003DCB4C
	public void a()
	{
		this.a = 0.0;
		this.b = 0.0;
	}

	// Token: 0x06009D84 RID: 40324 RVA: 0x003DE96C File Offset: 0x003DCB6C
	public ahx()
	{
	}

	// Token: 0x04003CED RID: 15597
	public double a;

	// Token: 0x04003CEE RID: 15598
	public double b;
}
